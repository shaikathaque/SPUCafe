using System.Collections.Generic;

namespace SPUCafe.Core
{
	public interface ICafeDataService
	{
		CafeData getCafeData();

		List<Week> getWeeks();

		List<Day> getDays(int index);

		List<Meal> getMeals(int weekIndex, int dayIndex);

		List<Item> getItems(int weekIndex, int dayIndex, int mealIndex);
	}
}
