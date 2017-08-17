using System;
using System.Diagnostics;
using MvvmCross.Core.ViewModels;

namespace SPUCafe.Core
{
	public class MainViewModel : MvxViewModel
	{
		readonly ICafeDataService _cafeDataService;

		public MvxObservableCollection<Week> Weeks { get; set; }

		public MvxCommand<Week> ShowDaysCommand => new MvxCommand<Week>(ShowDaysViewModel);

		public MainViewModel(ICafeDataService cafeDataService)
		{
			//ScraperService scraper = new ScraperService();
			//var doc = scraper.getDocAsync();

			_cafeDataService = cafeDataService;
			Weeks = new MvxObservableCollection<Week>(_cafeDataService.getWeeks());
		}

		void ShowDaysViewModel(Week obj)
		{
			int weekId = Weeks.IndexOf(obj);
			Debug.WriteLine(weekId);
			ShowViewModel<DaysViewModel>(new { weekIndex = weekId });
		}
	}
}
