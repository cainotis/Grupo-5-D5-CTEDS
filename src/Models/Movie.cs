using System;

namespace MovieFinder.Models
{
	internal class Movie
	{
		public long? id { get; set; }
		public string name { get; set; }
		public DateTime update_dttm { get; set; }

		public Movie(string name)
		{
			this.name = name;
			update_dttm = DateTime.Now;
		}
	}
}