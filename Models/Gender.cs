using System;
using System.Collections.Generic;

#nullable disable

namespace FilmWebApp
{
    public partial class Gender
    {
        public Gender()
        {
            FilmMembers = new HashSet<FilmMember>();
        }

        public int Idgender { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FilmMember> FilmMembers { get; set; }
    }
}
