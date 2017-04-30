using System;
using MvvmCross.Core.ViewModels;

namespace SPUCafe.Core
{
	public class DaysViewModel : MvxViewModel
	{
		public MvxObservableCollection<Day> Days { get; set; }

		public MvxCommand<Day> ShowMealsCommand => new MvxCommand<Day>(ShowMealsViewModel);

		public DaysViewModel()
		{
			Days = new MvxObservableCollection<Day>();

			Days.Add(new Day { DayName = "Monday" });
			Days.Add(new Day { DayName = "Tuesday" });
			Days.Add(new Day { DayName = "Wednesday" });
			Days.Add(new Day { DayName = "Thursday" });
			Days.Add(new Day { DayName = "Friday" });
			Days.Add(new Day { DayName = "Saturday" });
			Days.Add(new Day { DayName = "Sunday" });
		}

		void ShowMealsViewModel(Day obj)
		{
			ShowViewModel<MealsViewModel>();
		}
	}

	public class Day
	{
		public string DayName { get; set; }	
	}
}
