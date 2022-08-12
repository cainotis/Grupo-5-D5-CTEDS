using System;

namespace MovieFinder.Models
{
    public class Filme
    {
        public long ?id { get; set; }
        public string name { get; set; }
        public DateTime updated_dttm { get; set; }

        public Filme(string name)
        {
            this.name = name;
            updated_dttm = DateTime.Now;
        }
    }
}