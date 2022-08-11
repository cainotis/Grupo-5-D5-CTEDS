using MovieFinder.Models;

namespace  MovieFinder.Interfaces
{
	internal interface MovieRepository
	{
		List<Movie> ReadAll();

		Movie Add(Movie movie);

		Movie Update(Movie movie);

	}
}