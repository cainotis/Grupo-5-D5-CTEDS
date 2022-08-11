using MovieFinder.Models;

namespace MovieFinder.Interfaces
{
	internal interface PlatformRepository
	{
		List<Platform> ReadAll();

        Plataform GetByName(string name);

		Platform Add(Platform platform);

		Platform Update(Platform platform);
	}
}