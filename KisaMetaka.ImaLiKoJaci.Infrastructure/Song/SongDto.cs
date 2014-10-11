using System;

namespace KisaMetaka.ImaLiKoJaci.Infrastructure.Song
{
    public class SongDto
    {
        public SongDto(Data.Song song)
        {
            if (song == null) { throw new ArgumentException("song"); }

            this.Id = song.Id;
            this.Title = song.Title;
            this.YoutubeUrl = song.YoutubeUrl;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string YoutubeUrl { get; private set; }
    }
}
