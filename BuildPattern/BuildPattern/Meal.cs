using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern
{
    class Meal
    {
		private List<Item> items = new List<Item>();


		public void AddItem(Item _item)
		{
			items.Add(_item);
		}

        internal void AddItem(SlicePizza slicePizza)
        {
            throw new NotImplementedException();
        }

        public decimal GetCost()
		{
			try
			{
				decimal total = 0;

				foreach (var item in items)
				{
					total = total + item.Price();
				}

				return total;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void ShowItems()
		{
			foreach (var item in items)
			{
				Console.Write("Item :" + item.Name());
				Console.Write(", Packing : " + item.Packing());
				Console.WriteLine(", Price : " + item.Price());
			}
		}

		public Meal()
		{
		}
	}
}
