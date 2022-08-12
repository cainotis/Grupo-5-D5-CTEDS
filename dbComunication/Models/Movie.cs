using System;
using System.Collections.Generic;

namespace DBWebApp
{
    public partial class Movie
    {
        public Movie()
        {
            Platforms = new HashSet<Platform>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? UpdateDttm { get; set; }

        public virtual ICollection<Platform> Platforms { get; set; }
    }
}
