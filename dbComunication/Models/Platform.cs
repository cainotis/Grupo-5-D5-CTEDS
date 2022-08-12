using System;
using System.Collections.Generic;

namespace DBWebApp
{
    public partial class Platform
    {
        public Platform()
        {
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
