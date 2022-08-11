using System;

namespace MovieFinder.Models
{
	internal class Movie
	{
		public long ?id { get; set; }
		public string name { get; set; }
		public DateTime updated_dttm { get; set; }

		public Movie(string name)
		{
			this.name = name;
			updated_dttm = DateTime.Now;
		}
	}
}