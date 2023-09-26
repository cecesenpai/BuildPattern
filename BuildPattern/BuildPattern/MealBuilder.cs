using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern
{
   public class MealBuilder
    {
		public Meal SlicePizzaMeal()
		{
			var meal = new Meal();
			meal.AddItem(new SlicePizza());
			meal.AddItem(new Coke());
			return meal;
		}

		public Meal MixedPizzaMeal()
		{
			var meal = new Meal();
			meal.AddItem(new MixedPizza());
			meal.AddItem(new Fanta());
			return meal;
		}

        public Meal MargaritaPizzaMeal()
		{
			var meal = new Meal();
			meal.AddItem(new MargaritaPizza());
			meal.AddItem(new Sprite());
			return meal;
		}

		public MealBuilder()
		{
		}
	}
}
