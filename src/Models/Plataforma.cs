namespace MovieFinder.Models
{
    public class Plataforma
    {
        public long ?id { get; set; }
        public string name { get; set; }

        public Plataforma(string name)
        {
            this.name = name;
        }
    }
}