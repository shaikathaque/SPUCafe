using System;
using System.Collections.Generic;

namespace SPUCafe.Core
{
	public class CafeDataService : ICafeDataService
	{
		readonly CafeDataRepository _cafeDataRepository;

		public CafeDataService()
		{
			_cafeDataRepository = new CafeDataRepository();
		}

		public CafeData getCafeData()
		{
			return _cafeDataRepository.getCafeData();
		}

		public List<Week> getWeeks()
		{
			return _cafeDataRepository.getCafeData().Weeks;
		}

		public List<Day> getDays(int index)
		{
			return _cafeDataRepository.getCafeData().Weeks[index].Days;
		}

		public List<Meal> getMeals(int weekIndex, int dayIndex)
		{
			return _cafeDataRepository.getCafeData().Weeks[weekIndex].Days[dayIndex].Meals;
		}

		public List<Item> getItems(int weekIndex, int dayIndex, int mealIndex)
		{
			return _cafeDataRepository.getCafeData().Weeks[weekIndex].Days[dayIndex].Meals[mealIndex].Items;
		}
	}
}
