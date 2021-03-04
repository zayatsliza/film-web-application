using System;
using System.Collections.Generic;

#nullable disable

namespace FilmWebApp
{
    public partial class Position
    {
        public Position()
        {
            FilmMembers = new HashSet<FilmMember>();
        }

        public int Idpost { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FilmMember> FilmMembers { get; set; }
    }
}
