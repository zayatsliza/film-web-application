using System;
using System.Collections.Generic;

#nullable disable

namespace FilmWebApp
{
    public partial class FilmMember
    {
        public int Idfilmem { get; set; }
        public int Idpost { get; set; }
        public int Idfilm { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int Idgender { get; set; }

        public virtual Film IdfilmNavigation { get; set; }
        public virtual Gender IdgenderNavigation { get; set; }
        public virtual Position IdpostNavigation { get; set; }
    }
}
