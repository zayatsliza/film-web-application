using System;
using System.Collections.Generic;

#nullable disable

namespace FilmWebApp
{
    public partial class Genre
    {
        public Genre()
        {
            FilmGenres = new HashSet<FilmGenre>();
        }

        public int Idgenres { get; set; }
        public string Name { get; set; }
        public string Descript { get; set; }

        public virtual ICollection<FilmGenre> FilmGenres { get; set; }
    }
}
