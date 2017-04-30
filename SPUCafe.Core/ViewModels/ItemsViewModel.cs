using System;
using MvvmCross.Core.ViewModels;

namespace SPUCafe.Core
{
	public class ItemsViewModel : MvxViewModel
	{
		public MvxObservableCollection<Item> Items { get; set; } 

		public ItemsViewModel()
		{
			Items = new MvxObservableCollection<Item>();

			Items.Add(new Item { ItemName = "Chicken" });
			Items.Add(new Item { ItemName = "Mashed Potatoes" });
			Items.Add(new Item { ItemName = "Lasgna" });
			Items.Add(new Item { ItemName = "Beed" });
			Items.Add(new Item { ItemName = "Rice" });
		}

	}

	public class Item
	{	
		public string ItemName { get; set; }
	}
}
