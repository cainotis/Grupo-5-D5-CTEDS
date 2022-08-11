using MovieFinder.Models;

namespace MovieFinder.Interfaces
{
	internal interface PlatformRepository
	{
		List<Platform> ReadAll();

		Platform Add(Platform platform);

		Platform Update(Platform platform);
	}
}