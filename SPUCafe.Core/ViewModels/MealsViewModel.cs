using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace SPUCafe.Core
{
	public class MealsViewModel : MvxViewModel
	{
		public MvxObservableCollection<Meal> Meals { get; set; }

		public MvxCommand<Meal> ShowItemsCommand => new MvxCommand<Meal>(ShowItemsViewModel);

		public MealsViewModel()
		{
			Meals = new MvxObservableCollection<Meal>();

			Meals.Add(new Meal { MealName = "Breakfast" });
			Meals.Add(new Meal { MealName = "Lunch" });
			Meals.Add(new Meal { MealName = "Dinner" });
		}

		void ShowItemsViewModel(Meal obj)
		{
			ShowViewModel<ItemsViewModel>();
		}
	}

	public class Meal
	{
		public string MealName { get; set; }
	}
}