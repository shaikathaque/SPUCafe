using System;
using MvvmCross.Core.ViewModels;

namespace SPUCafe.Core
{
	public class ItemsViewModel : MvxViewModel
	{
		ICafeDataService _cafeDataService;

		public int weekId { get; set; }
		public int dayId { get; set; }
		public int mealId { get; set;}


		public MvxObservableCollection<Item> Items { get; set; }

		public void Init(int weekIndex, int dayIndex, int mealIndex)
		{
			weekId = weekIndex;
			dayId = dayIndex;
			mealId = mealIndex;

			Items = new MvxObservableCollection<Item>(_cafeDataService.getItems(weekId, dayId, mealId));
		}

		public ItemsViewModel(ICafeDataService cafeDataService)
		{
			_cafeDataService = cafeDataService;
		}

	}
}
