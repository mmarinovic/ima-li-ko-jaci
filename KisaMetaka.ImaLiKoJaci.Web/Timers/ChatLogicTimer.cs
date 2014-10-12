using System;
using System.Threading;
using System.Web.Hosting;
using KisaMetaka.ImaLiKoJaci.Infrastructure.Lyrics;
using KisaMetaka.ImaLiKoJaci.Infrastructure.User;
using KisaMetaka.ImaLiKoJaci.Infrastructure.Utility;
using KisaMetaka.ImaLiKoJaci.Web.Hubs;
using KisaMetaka.ImaLiKoJaci.Web.Models.Chat;
using StructureMap;

namespace KisaMetaka.ImaLiKoJaci.Web.Timers
{
    public class ChatLogicTimer : IRegisteredObject
    {
        private Timer _timer;
        private bool _isRoundInProgress;
        private LyricsDto _currentLyrics;
        private readonly UserDto _botUser;
        private readonly ILyricsRepository _lyricsRepository;
        private readonly IUserRepository _userRepository;

        public ChatLogicTimer()
        {
            _lyricsRepository = ObjectFactory.GetInstance<ILyricsRepository>();
            _userRepository = ObjectFactory.GetInstance<IUserRepository>();

            _botUser = _userRepository.TryGet("bot");

            _StartTimer();
        }

        private void _StartTimer()
        {
            var messageModel = new MessageModel(_botUser, "Pripremite se za novu rundu...", MessageType.Info);
            PublicHub.SendMessage(messageModel);

            _timer = new Timer(_FinishAndSetupNewRound, null, TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(30));
        }

        private void _FinishAndSetupNewRound(object state)
        {
            if (!_isRoundInProgress)
            {
                _currentLyrics = _lyricsRepository.GetRandom();

                var questionMessageModel = new MessageModel(_botUser, _currentLyrics.Question, MessageType.Question);
                PublicHub.SendMessage(questionMessageModel);

                var hiddenAnswerMessageModel = new MessageModel(_botUser, _currentLyrics.HiddenAnswer, MessageType.Question);
                PublicHub.SendMessage(hiddenAnswerMessageModel);

                _isRoundInProgress = true;
            }
            else
            {
                this.Stop(true);

                var messageModel = new MessageModel(_botUser, "Runda završena...", MessageType.Info);
                PublicHub.SendMessage(messageModel);

                var correctAnswerMessageModel = new CorrectAnswerMessageModel(
                    _botUser, _currentLyrics.Answer, MessageType.CorrectAnswer, _currentLyrics.Song.Url, _currentLyrics.FromSecond, _currentLyrics.ToSecond
                    );

                PublicHub.SendMessage(correctAnswerMessageModel);

                _isRoundInProgress = false;
                _StartTimer();
            }
        }

        public bool CheckWinningAnswer(string answer, UserDto user)
        {
            if (!_isRoundInProgress) { return false; }

            var isWinningAnswer = answer.LyricEquals(_currentLyrics.Answer);

            if (isWinningAnswer)
            {
                var winningMessage = string.Format("{0} je točno odgovorio za +{1} bodova!", user.DisplayName, _currentLyrics.ScoreValue);
                var winningMessageModel = new MessageModel(_botUser, winningMessage, MessageType.WinningAnswer);

                PublicHub.SendMessage(winningMessageModel);

                _userRepository.AddScore(user.Id, _currentLyrics.ScoreValue);
            }

            return isWinningAnswer;
        }

        public void Stop(bool immediate)
        {
            _timer.Dispose();
        }
    }
}