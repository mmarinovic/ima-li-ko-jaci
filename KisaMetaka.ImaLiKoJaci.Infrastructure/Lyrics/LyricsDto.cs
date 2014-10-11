using System;
using KisaMetaka.ImaLiKoJaci.Infrastructure.Song;

namespace KisaMetaka.ImaLiKoJaci.Infrastructure.Lyrics
{
    public class LyricsDto
    {
        public LyricsDto(Data.Lyrics lyrics)
        {
            if (lyrics == null) { throw new ArgumentException("lyrics"); }

            this.Id = lyrics.Id;
            this.Question = lyrics.Question;
            this.Answer = lyrics.Answer;
            this.FromSecond = lyrics.FromSecond;
            this.ToSecond = lyrics.ToSecond;
            this.ScoreValue = lyrics.ScoreValue;
            this.Song = new SongDto(lyrics.Song);
        }

        public int Id { get; private set; }
        public string Question { get; private set; }
        public string Answer { get; private set; }
        public int FromSecond { get; private set; }
        public int ToSecond { get; private set; }
        public int ScoreValue { get; private set; }
        public SongDto Song { get; private set; }
    }
}
