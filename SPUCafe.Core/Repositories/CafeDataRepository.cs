using System;
using System.Collections.Generic;

namespace SPUCafe.Core
{
	public class CafeDataRepository : ICafeDataRepository
	{
		CafeData cafeData;

		public CafeDataRepository()
		{
			//Create mock items

			//Add item objects to day objects

			//Monday
			Meal mealMon1 = new Meal();
			mealMon1.MealName = "Breakfast";
			mealMon1.Items = new List<Item>();
			mealMon1.Items.Add(new Item() { ItemName = "Sausage Patty"});
			mealMon1.Items.Add(new Item() { ItemName = "Turkey Sausage Patty"});
			mealMon1.Items.Add(new Item() { ItemName = "Shredded Hash Brown Potatoes, Frozen"});
			mealMon1.Items.Add(new Item() { ItemName = "Oatmeal"});
			mealMon1.Items.Add(new Item() { ItemName = "Chocolate Chip Pancakes"});

			Meal mealMon2 = new Meal();
			mealMon2.MealName = "Lunch";
			mealMon2.Items = new List<Item>();
			mealMon2.Items.Add(new Item() { ItemName = "Mojo Lime Jerk Chicken Breast"});
			mealMon2.Items.Add(new Item() { ItemName = "Mexican Brown Rice with Toasted Pepitas"});
			mealMon2.Items.Add(new Item() { ItemName = "Ranch Style Black Beans"});
			mealMon2.Items.Add(new Item() { ItemName = "Sweet Potato Mexicano"});
			mealMon2.Items.Add(new Item() { ItemName = "Mexican Vegetables"});

			Meal mealMon3 = new Meal();
			mealMon3.MealName = "Dinner";
			mealMon3.Items = new List<Item>();
			mealMon3.Items.Add(new Item() { ItemName = "Beef Meatballs"});
			mealMon3.Items.Add(new Item() { ItemName = "Baked Ziti Casserette"});
			mealMon3.Items.Add(new Item() { ItemName = "Parmesan-Dusted Acorn Squash"});
			mealMon3.Items.Add(new Item() { ItemName = "Fresh Broccoli Raab/Rabe (Rapini)"});
			mealMon3.Items.Add(new Item() { ItemName = "Roasted Red Potatoes & Rosemary"});

			//Tuesday
			Meal mealTues1 = new Meal();
			mealTues1.MealName = "Breakfast";
			mealTues1.Items = new List<Item>();
			mealTues1.Items.Add(new Item() { ItemName = "Bacon"});
			mealTues1.Items.Add(new Item() { ItemName = "Turkey Bacon"});
			mealTues1.Items.Add(new Item() { ItemName = "Hash Browned Potato Patty"});
			mealTues1.Items.Add(new Item() { ItemName = "Classic Grits"});
			mealTues1.Items.Add(new Item() { ItemName = "Scrambled Eggs"});


			Meal mealTues2 = new Meal();
			mealTues2.MealName = "Lunch";
			mealTues2.Items = new List<Item>();
			mealTues2.Items.Add(new Item() { ItemName = "Bistec al Ajioco"});
			mealTues2.Items.Add(new Item() { ItemName = "Fried Sweet Plantains"});
			mealTues2.Items.Add(new Item() { ItemName = "Yellow Rice with Red Beans"});
			mealTues2.Items.Add(new Item() { ItemName = "Country Kitchen Vegetable"});
			mealTues2.Items.Add(new Item() { ItemName = "Angel Hair Pasta, Dry"});
			mealTues2.Items.Add(new Item() { ItemName = "Sun-Dried Tomato Pesto Sauce"});

			Meal mealTues3 = new Meal();
			mealTues3.MealName = "Dinner";
			mealTues3.Items = new List<Item>();
			mealTues3.Items.Add(new Item() { ItemName = "Baked Potato Bar"});


			//Wednesday
			Meal mealWed1 = new Meal();
			mealWed1.MealName = "Breakfast";
			mealWed1.Items = new List<Item>();
			mealWed1.Items.Add(new Item() { ItemName = "Sausage Links" });
			mealWed1.Items.Add(new Item() { ItemName = "Turkey Sausage Links, All NAT, Raw, 1 oz" });
			mealWed1.Items.Add(new Item() { ItemName = "O'Brien Potatoes" });
			mealWed1.Items.Add(new Item() { ItemName = "Old Fashioned Oatmeal" });
			mealWed1.Items.Add(new Item() { ItemName = "Cinnamon Swirl French Toast" });

			Meal mealWed2 = new Meal();
			mealWed2.MealName = "Lunch";
			mealWed2.Items = new List<Item>();
			mealWed2.Items.Add(new Item() { ItemName = "BBQ Beef Brisket" });
			mealWed2.Items.Add(new Item() { ItemName = "Cornbread" });
			mealWed2.Items.Add(new Item() { ItemName = "Scratch Macaroni and Cheese" });
			mealWed2.Items.Add(new Item() { ItemName = "Sauteed Spinach with Red Onion & Garlic" });
			mealWed2.Items.Add(new Item() { ItemName = "Stewed Tomato Garbanzo Beans Plate" });

			Meal mealWed3 = new Meal();
			mealWed3.MealName = "Dinner";
            mealWed3.Items = new List<Item>();
            mealWed3.Items.Add(new Item() { ItemName = "Coconut Chicken w/ Orange Sauce" });
            mealWed3.Items.Add(new Item() { ItemName = "Cilantro Jasmine Rice" });
            mealWed3.Items.Add(new Item() { ItemName = "Cantonese Vegetable Stir Fry" });
            mealWed3.Items.Add(new Item() { ItemName = "Fresh Broccoli (Steamed)" });
            mealWed3.Items.Add(new Item() { ItemName = "Scallion Lo Mein Noodles" });

			//Thursday
			Meal mealThurs1 = new Meal();
			mealThurs1.MealName = "Breakfast";
            mealThurs1.Items = new List<Item>();
            mealThurs1.Items.Add(new Item() { ItemName = "Sausage Patty" });
            mealThurs1.Items.Add(new Item() { ItemName = "Turkey Sausage Patty" });
            mealThurs1.Items.Add(new Item() { ItemName = "Sliced Lyonnaise Potatoes" });
            mealThurs1.Items.Add(new Item() { ItemName = "Cream of Wheat (Farina)" });
            mealThurs1.Items.Add(new Item() { ItemName = "Scrambled Eggs" });

            Meal mealThurs2 = new Meal();
			mealThurs2.MealName = "Lunch";
            mealThurs2.Items = new List<Item>();
            mealThurs2.Items.Add(new Item() { ItemName = "Chicken Fried Steak with Old Bay Gravy" });
            mealThurs2.Items.Add(new Item() { ItemName = "Creamed Corn, Canned" });
            mealThurs2.Items.Add(new Item() { ItemName = "Cheesy Grits" });
            mealThurs2.Items.Add(new Item() { ItemName = "Lighter Fare Cauliflower Mash" });
            mealThurs2.Items.Add(new Item() { ItemName = "Lemon Garlic Green Beans" });

            Meal mealThurs3 = new Meal();
			mealThurs3.MealName = "Dinner";
            mealThurs3.Items = new List<Item>();
            mealThurs3.Items.Add(new Item() { ItemName = "Baked Chicken Adobo" });
            mealThurs3.Items.Add(new Item() { ItemName = "Spinach & Jack Cheese Enchiladas" });
            mealThurs3.Items.Add(new Item() { ItemName = "Honey Mustard Glazed Brussels Sprouts" });
            mealThurs3.Items.Add(new Item() { ItemName = "Leek, Spinach, and Mushroom Frittata" });
            mealThurs3.Items.Add(new Item() { ItemName = "White Rice" });

			//Friday
			Meal mealFri1 = new Meal();
			mealFri1.MealName = "Breakfast";
            mealFri1.Items = new List<Item>();
            mealFri1.Items.Add(new Item() { ItemName = "Breakfast Ham Steak" });
            mealFri1.Items.Add(new Item() { ItemName = "Turkey Bacon" });
            mealFri1.Items.Add(new Item() { ItemName = "French Fried Tater Tot" });
            mealFri1.Items.Add(new Item() { ItemName = "Oatmeal" });
            mealFri1.Items.Add(new Item() { ItemName = "Banana Pancake" });

            Meal mealFri2 = new Meal();
			mealFri2.MealName = "Lunch";
            mealFri2.Items = new List<Item>();
            mealFri2.Items.Add(new Item() { ItemName = "Mojo Chicken Fajita" });
            mealFri2.Items.Add(new Item() { ItemName = "Mexican Fiesta Rice" });
            mealFri2.Items.Add(new Item() { ItemName = "Baja Black Bean" });
            mealFri2.Items.Add(new Item() { ItemName = "Mexican Vegetables" });
            mealFri2.Items.Add(new Item() { ItemName = "Mexican Breakfast Potatoes" });

            Meal mealFri3 = new Meal();
			mealFri3.MealName = "Dinner";
            mealFri3.Items = new List<Item>();
            mealFri3.Items.Add(new Item() { ItemName = "Fried Tofu" });
            mealFri3.Items.Add(new Item() { ItemName = "Imperial Fried Rice" });
            mealFri3.Items.Add(new Item() { ItemName = "Gingered Sweet Potatoes" });
            mealFri3.Items.Add(new Item() { ItemName = "Curried Cauliflower" });
            mealFri3.Items.Add(new Item() { ItemName = "Vegan Macaroni Dinner" });

			//Saturday
			Meal mealSat1 = new Meal();
			mealSat1.MealName = "Lunch";
            mealSat1.Items = new List<Item>();
            mealSat1.Items.Add(new Item() { ItemName = "Pork Sausage Links" });
            mealSat1.Items.Add(new Item() { ItemName = "Turkey Sausage Links" });
            mealSat1.Items.Add(new Item() { ItemName = "Roasted Red Bliss Potatoes" });
            mealSat1.Items.Add(new Item() { ItemName = "Cheesy Grits" });
            mealSat1.Items.Add(new Item() { ItemName = "Apple Pancakes" });
			mealSat1.Items.Add(new Item() { ItemName = "Scrambled Eggs" });
			mealSat1.Items.Add(new Item() { ItemName = "Oven Fried Chicken Eighths" });

            Meal mealSat2 = new Meal();
            mealSat2.MealName = "Dinnner";
            mealSat2.Items = new List<Item>();
            mealSat2.Items.Add(new Item() { ItemName = "House Taco Bar" });
            mealSat2.Items.Add(new Item() { ItemName = "Quinoa & Black Bean Tortilla Salad" });
            mealSat2.Items.Add(new Item() { ItemName = "Mexican Fiesta Rice" });

			//Sunday
			Meal mealSun1 = new Meal();
			mealSun1.MealName = "Lunch";
            mealSun1.Items = new List<Item>();
            mealSun1.Items.Add(new Item() { ItemName = "Pork Sausage Links" });
            mealSun1.Items.Add(new Item() { ItemName = "Turkey Bacon" });
            mealSun1.Items.Add(new Item() { ItemName = "Sauteed Hash Browns" });
            mealSun1.Items.Add(new Item() { ItemName = "Old Fashioned Oatmeal" });
            mealSun1.Items.Add(new Item() { ItemName = "Banana Nut Bread French Toast (3)" });
            mealSun1.Items.Add(new Item() { ItemName = "Roasted Vegetable Frittata" });
            mealSun1.Items.Add(new Item() { ItemName = "Blackened Flank Steak" });

            Meal mealSun2 = new Meal();
			mealSun2.MealName = "Dinnner";
            mealSun2.Items = new List<Item>();
            mealSun2.Items.Add(new Item() { ItemName = "Grilled Jerk Chicken Breast" });
            mealSun2.Items.Add(new Item() { ItemName = "Pigeon Peas & Rice" });
            mealSun2.Items.Add(new Item() { ItemName = "Charred Summer Vegetables" });
			mealSun2.Items.Add(new Item() { ItemName = "Red Bliss Smashed Potatoes" });
			mealSun2.Items.Add(new Item() { ItemName = "Penne Pasta" });
			mealSun2.Items.Add(new Item() { ItemName = "Vodka Sauce" });

			//Add meal objecys to day objects
			Day day1 = new Day();
			day1.DayName = "Monday";
			day1.Meals = new List<Meal>();
			day1.Meals.Add(mealMon1);
			day1.Meals.Add(mealMon2);
			day1.Meals.Add(mealMon3);

			Day day2 = new Day();
			day2.DayName = "Tuesday";
			day2.Meals = new List<Meal>();
			day2.Meals.Add(mealTues1);
			day2.Meals.Add(mealTues2);
			day2.Meals.Add(mealTues3);

			Day day3 = new Day();
			day3.DayName = "Wednesday";
			day3.Meals = new List<Meal>();
			day3.Meals.Add(mealWed1);
			day3.Meals.Add(mealWed2);
			day3.Meals.Add(mealWed3);

			Day day4 = new Day();
			day4.DayName = "Thursday";
			day4.Meals = new List<Meal>();
			day4.Meals.Add(mealThurs1);
			day4.Meals.Add(mealThurs2);
			day4.Meals.Add(mealThurs3);

			Day day5 = new Day();
			day5.DayName = "Friday";
			day5.Meals = new List<Meal>();
			day5.Meals.Add(mealFri1);
			day5.Meals.Add(mealFri2);
			day5.Meals.Add(mealFri3);

			Day day6 = new Day();
			day6.DayName = "Saturday";
			day6.Meals = new List<Meal>();
			day6.Meals.Add(mealSat1);
			day6.Meals.Add(mealSat2);

			Day day7 = new Day();
			day7.DayName = "Sunday";
			day7.Meals = new List<Meal>();
			day7.Meals.Add(mealSun1);
			day7.Meals.Add(mealSun2);

			//add day objects to week object
			Week week1 = new Week();
			week1.DateRange = "5/1/2017 - 5/7/2017";
			week1.Days = new List<Day>();
			week1.Days.Add(day1);
			week1.Days.Add(day2);
			week1.Days.Add(day3);
			week1.Days.Add(day4);
			week1.Days.Add(day5);
			week1.Days.Add(day6);
			week1.Days.Add(day7);

			//add week object to CafeData object
			cafeData = new CafeData();
			cafeData.Weeks = new List<Week>();
			cafeData.Weeks.Add(week1);
		}

		public CafeData getCafeData()
		{
			return cafeData;
		}

	}
}
