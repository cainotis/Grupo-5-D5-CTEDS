using MovieFinder.Models;
using MovieFinder.Repositories;

using System.Text.Json;
using System.Text.Json.Serialization;

using System;
using System.Configuration;

namespace MovieFinder
{
	class Program
	{

		static void Main(){

            using var db = new DbConnection(appSettings["ConnectionString"]);

            var appSettings = ConfigurationManager.AppSettings;

			Platform filme = db.Platforms
				.OrderBy(b => b.id)
				.First();

            string jsonString = JsonSerializer.Serialize(appSettings);
			Console.WriteLine(appSettings["ConnectionString"]);
		}

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
