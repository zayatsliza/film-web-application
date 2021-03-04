using System;
using System.Collections.Generic;

#nullable disable

namespace FilmWebApp
{
    public partial class Film
    {
        public Film()
        {
            FilmGenres = new HashSet<FilmGenre>();
            FilmMembers = new HashSet<FilmMember>();
        }

        public int Idfilm { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Descript { get; set; }
        public double Rating { get; set; }

        public virtual ICollection<FilmGenre> FilmGenres { get; set; }
        public virtual ICollection<FilmMember> FilmMembers { get; set; }
    }
}
