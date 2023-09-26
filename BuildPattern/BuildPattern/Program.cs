using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern
{
    using BuildPattern;
    class Program
    {
        static void Main(string[] args)
        {
            var mealBuilder = new MealBuilder();

            var slicepizza = mealBuilder.SlicePizzaMeal();
            Console.WriteLine("Slice Pizza Meal");
            slicepizza.ShowItems();
            Console.WriteLine("Total Price :" + slicepizza.GetCost());


            var MixedMeal = mealBuilder.MixedPizzaMeal();
            Console.WriteLine("MixedPizza Meal");
            MixedMeal.ShowItems();
            Console.WriteLine("Total Price :" + MixedMeal.GetCost());

            var MargaritaMeal = mealBuilder.MargaritaPizzaMeal();
            Console.WriteLine("MixedPizza Meal");
            MargaritaMeal.ShowItems();
            Console.WriteLine("Total Price :" + MargaritaMeal.GetCost());

            Console.ReadLine();
        }
    }
}
