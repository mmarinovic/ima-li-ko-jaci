using System;
using KisaMetaka.ImaLiKoJaci.Infrastructure.Lyrics;

namespace KisaMetaka.ImaLiKoJaci.Web.Models.Chat
{
    public class QuestionModel
    {
        public QuestionModel(LyricsDto lyrics)
        {
            if (lyrics == null) { throw new ArgumentException("lyrics"); }

            this.Lyrics = lyrics;
        }

        public LyricsDto Lyrics { get; private set; }
    }
}