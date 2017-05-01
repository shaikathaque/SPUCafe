using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace SPUCafe.Core
{
	public class MealsViewModel : MvxViewModel
	{
		ICafeDataService _cafeDataService;

		public int weekId { get; set; }

		public int dayId { get; set; }

		public MvxObservableCollection<Meal> Meals { get; set; }

		public MvxCommand<Meal> ShowItemsCommand => new MvxCommand<Meal>(ShowItemsViewModel);

		public void Init(int weekIndex, int dayIndex)
		{
			weekId = weekIndex;
			dayId = dayIndex;

			Meals = new MvxObservableCollection<Meal>(_cafeDataService.getMeals(weekId, dayId));
		}

		public MealsViewModel(ICafeDataService cafeDataService)
		{
			_cafeDataService = cafeDataService;

			//Meals.Add(new Meal { MealName = "Breakfast" });
			//Meals.Add(new Meal { MealName = "Lunch" });
			//Meals.Add(new Meal { MealName = "Dinner" });
		}

		void ShowItemsViewModel(Meal obj)
		{
			int mealId = Meals.IndexOf(obj);
			ShowViewModel<ItemsViewModel>(new { weekIndex = weekId, dayIndex = dayId, mealIndex = mealId });
		}
	}
}