using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace SPUCafe.Core
{
	public class App : MvxApplication
	{
		public override void Initialize()
		{
			Debug.WriteLine("App.cs Initialize called before base.Initialize");
			base.Initialize();
			Debug.WriteLine("App.cs Initialize after base.Initialize");

			CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();
		}


	}
}
