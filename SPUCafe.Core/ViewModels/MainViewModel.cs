using System;
using System.Diagnostics;
using MvvmCross.Core.ViewModels;

namespace SPUCafe.Core
{
	public class MainViewModel : MvxViewModel
	{
		CafeDataService _cafeDataService;

		public MvxObservableCollection<Week> Weeks { get; set; }

		public MvxCommand<Week> ShowDaysCommand => new MvxCommand<Week>(ShowDaysViewModel);

		public MainViewModel()
		{
			Debug.WriteLine("MainViewModel constructor called");
		}

		void ShowDaysViewModel(Week obj)
		{
			int weekId = Weeks.IndexOf(obj);
			Debug.WriteLine(weekId);
			ShowViewModel<DaysViewModel>(new { weekIndex = weekId });
		}

		public void LoadData()
		{
			_cafeDataService = new CafeDataService();
			Weeks = new MvxObservableCollection<Week>(_cafeDataService.getWeeks());
		}
	}
}
