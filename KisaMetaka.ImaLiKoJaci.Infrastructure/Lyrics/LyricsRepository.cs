using System;
using System.Linq;
using KisaMetaka.ImaLiKoJaci.Infrastructure.Data;

namespace KisaMetaka.ImaLiKoJaci.Infrastructure.Lyrics
{
    public class LyricsRepository : ILyricsRepository
    {
        private readonly DataModel _context;

        public LyricsRepository(DataModel context)
        {
            _context = context;
        }

        public LyricsDto GetRandom()
        {
            var lyrics = _context.Lyrics
                .OrderBy(x => Guid.NewGuid())
                .FirstOrDefault();

            if (lyrics == null) { return null; }

            return new LyricsDto(lyrics);
        }
    }
}
