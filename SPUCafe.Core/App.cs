using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace SPUCafe.Core
{
	public class App : MvxApplication
	{
		public override async void Initialize()
		{
			base.Initialize();

			CreatableTypes()
				.EndingWith("Repository")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			ScraperService scraper = new ScraperService();
			string result = await scraper.getDocAsync();
			await log(result);

		}

		public async Task log(string result)
		{
			Debug.WriteLine(result);
		}

	}
}
