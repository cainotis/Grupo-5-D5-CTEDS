namespace MovieFinder.Models
{
	internal class Platform
	{
		public long ?id { get; set; }
		public string name { get; set; }

		public Platform(string name)
		{
			this.name = name;
		}
	}
}