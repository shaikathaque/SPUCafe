using System;
using MvvmCross.Core.ViewModels;

namespace SPUCafe.Core
{
	public class MainViewModel : MvxViewModel
	{
		public MvxObservableCollection<Week> Weeks { get; set; }

		public MvxCommand<Week> ShowDaysCommand => new MvxCommand<Week>(ShowDaysViewModel);

		public MainViewModel()
		{
			Weeks = new MvxObservableCollection<Week>();
			Weeks.Add(new Week { DateRange = "4/3/2017 - 4/9/2017" });
			Weeks.Add(new Week { DateRange = "4/10/2017 - 4/16/2017" });
		}

		void ShowDaysViewModel(Week obj)
		{
			ShowViewModel<DaysViewModel>();
		}
	}

	public class Week
	{
		public string DateRange { get; set; }
	}
}
