using System;
using System.Collections.Generic;

namespace SPUCafe.Core
{
	public class CafeDataRepository : ICafeDataRepository
	{
		private static List<CafeData> CafeDataList = new List<CafeData>();

		public List<CafeData> getCafeData()
		{
			//CafeData cafeData = new CafeData();

			//Create mock items
			Item items = new Item();
			items.ItemsNames.Add("Chicken");
			items.ItemsNames.Add("Beef");
			items.ItemsNames.Add("Rice");
			items.ItemsNames.Add("Beans");
			items.ItemsNames.Add("Mashed Potatoes");




		    //CafeDataList.Add(cafeData);

			return CafeDataList;
		}
	}
}
