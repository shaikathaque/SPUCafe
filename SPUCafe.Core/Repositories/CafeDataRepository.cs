using System;
using System.Collections.Generic;

namespace SPUCafe.Core
{
	public class CafeDataRepository : ICafeDataRepository
	{
		CafeData cafeData;

		public CafeDataRepository()
		{
			//CafeData cafeData = new CafeData();

			//Create mock items

			Meal meal1 = new Meal();
			meal1.MealName = "Breakfast";
			meal1.Items = new List<Item>();
			meal1.Items.Add(new Item() { ItemName = "Eggs"});
			meal1.Items.Add(new Item() { ItemName = "Potatoes"});
			meal1.Items.Add(new Item() { ItemName = "Pancakces"});

			Meal meal2 = new Meal();
			meal2.MealName = "Lunch";
			meal2.Items = new List<Item>();
			meal2.Items.Add(new Item() { ItemName = "Chicken"});
			meal2.Items.Add(new Item() { ItemName = "Beef"});
			meal2.Items.Add(new Item() { ItemName = "French Fries"});
			meal2.Items.Add(new Item() { ItemName = "Mashed Potatoes"});

			Meal meal3 = new Meal();
			meal3.MealName = "Dinner";
			meal3.Items = new List<Item>();
			meal3.Items.Add(new Item() { ItemName = "Fried rice"});
			meal3.Items.Add(new Item() { ItemName = "General Tso's Chicken"});
			meal3.Items.Add(new Item() { ItemName = "French Fries"});
			meal3.Items.Add(new Item() { ItemName = "Chicken Tenders"});

			Day day1 = new Day();
			day1.DayName = "Monday";
			day1.Meals = new List<Meal>();
			day1.Meals.Add(meal1);
			day1.Meals.Add(meal2);
			//day1.Meals.Add(meal3);

			Day day2 = new Day();
			day2.DayName = "Tuesday";
			day2.Meals = new List<Meal>();
			//day2.Meals.Add(meal1);
			day2.Meals.Add(meal2);
			day2.Meals.Add(meal3);

			Week week1 = new Week();
			week1.DateRange = "5/1/17 - 5/7/17";
			week1.Days = new List<Day>();
			week1.Days.Add(day1);
			week1.Days.Add(day2);

			Week week2 = new Week();
			week2.DateRange = "5/8/17 - 5/14/17";
			week2.Days = new List<Day>();
			week2.Days.Add(day2);
			//week2.Days.Add(day1);

			cafeData = new CafeData();
			cafeData.Weeks = new List<Week>();
			cafeData.Weeks.Add(week1);
			cafeData.Weeks.Add(week2);
		}

		public CafeData getCafeData()
		{
			return cafeData;
		}

	}
}
