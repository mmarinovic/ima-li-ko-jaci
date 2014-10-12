using System;
using System.Threading;
using System.Web.Hosting;
using KisaMetaka.ImaLiKoJaci.Infrastructure.Lyrics;
using KisaMetaka.ImaLiKoJaci.Web.Hubs;
using KisaMetaka.ImaLiKoJaci.Web.Models.Chat;
using StructureMap;

namespace KisaMetaka.ImaLiKoJaci.Web.Timers
{
    public class ChatLogicTimer : IRegisteredObject
    {
        private Timer _timer;
        private readonly ILyricsRepository _lyricsRepository;

        public ChatLogicTimer()
        {
            _lyricsRepository = ObjectFactory.GetInstance<ILyricsRepository>();

            _StartTimer();
        }

        private void _StartTimer()
        {
            _timer = new Timer(_AnnounceWinnerAndSendNewQuestion, null, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(10));
        }

        private void _AnnounceWinnerAndSendNewQuestion(object state)
        {
            var lyrics = _lyricsRepository.GetRandom();
            var questionModel = new QuestionModel(lyrics);

            PublicHub.ShowNewQuestion(questionModel);
        }

        public void Stop(bool immediate)
        {
            _timer.Dispose();

            HostingEnvironment.UnregisterObject(this);
        }
    }
}