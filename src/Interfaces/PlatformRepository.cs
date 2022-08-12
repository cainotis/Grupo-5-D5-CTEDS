using MovieFinder.Models;

namespace MovieFinder.Interfaces
{
	internal interface PlatformRepository
	{
		List<Platform> ReadAll();

        Platform GetByName(string name);

		Platform Add(Platform platform);

		Platform Update(Platform platform);
	}
}