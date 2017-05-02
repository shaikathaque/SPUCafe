using System;
using System.Diagnostics;
using MvvmCross.Core.ViewModels;

namespace SPUCafe.Core
{
	public class DaysViewModel : MvxViewModel
	{
		readonly ICafeDataService _cafeDataService;

		public int weekId { get; set; }

		public MvxObservableCollection<Day> Days { get; set; }

		public MvxCommand<Day> ShowMealsCommand => new MvxCommand<Day>(ShowMealsViewModel);

		public void Init(int weekIndex)
		{
			weekId = weekIndex;

			Days = new MvxObservableCollection<Day>(_cafeDataService.getDays(weekId));
		}

		public DaysViewModel(ICafeDataService cafeDataService)
		{
			_cafeDataService = cafeDataService;
		}

		void ShowMealsViewModel(Day obj)
		{
			int dayId = Days.IndexOf(obj);
			Debug.WriteLine(dayId);
			ShowViewModel<MealsViewModel>(new { weekIndex = weekId, dayIndex = dayId });
		}
	}
}
