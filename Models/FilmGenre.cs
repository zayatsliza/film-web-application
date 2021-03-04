using System;
using System.Collections.Generic;

#nullable disable

namespace FilmWebApp
{
    public partial class FilmGenre
    {
        public int IdfilmGenres { get; set; }
        public int Idgenres { get; set; }
        public int Idfilm { get; set; }

        public virtual Film IdfilmNavigation { get; set; }
        public virtual Genre IdgenresNavigation { get; set; }
    }
}
