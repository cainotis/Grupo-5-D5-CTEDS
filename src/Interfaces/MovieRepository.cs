using MovieFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace  MovieFinder.Interfaces
{
	internal interface MovieRepository
	{
		List<Movie> ReadAll();

		Movie GetByName(string name);

		Movie Add(Movie movie);

		Movie Update(Movie movie);

	}
}