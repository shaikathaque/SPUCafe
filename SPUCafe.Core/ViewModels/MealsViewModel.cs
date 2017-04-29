using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace SPUCafe.Core
{
	public class MealsViewModel : MvxViewModel
	{
		public MvxObservableCollection<Meal> Meals { get; set; }

		public MealsViewModel()
		{
			Meals = new MvxObservableCollection<Meal>();

			Meals.Add(new Meal { MealName = "Breakfast" });
			Meals.Add(new Meal { MealName = "Lunch" });
			Meals.Add(new Meal { MealName = "Dinner" });
		}
	}

	public class Meal
	{
		public String MealName { get; set; }
		public MealItems Items { get; set; }
	}

	public class MealItems
	{
		public MvxObservableCollection<String> ItemsList { get; set; }

		public MealItems()
		{
			ItemsList = new MvxObservableCollection<String>();

			ItemsList.Add("Chicken");
			ItemsList.Add("Rice");
			ItemsList.Add("Pasta");
		}
	}
}