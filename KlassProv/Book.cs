using System;
using System.Collections.Generic;

namespace KlassProv
{
    public class Book
    {
        public int price;

        //private List<string> name = new List<string>() {"Döden", "Magi", "Lycka"};

        private string name = "Väsen";

        private int rarity;

        private List<string> category = new List<string>() {"Folkhistoria", "Väsen", "Dimensioner"};

        private int actualValue;

        private bool cursed = true;

        private Random generator = new Random();

        public void Boook()
        {
            actualValue = generator.Next(30,101); //Slumpar ett pris mellan 30 och 100
            rarity = generator.Next(1, 4);//Tänkte att 1 skulle bli common, 2 bli rare, och 3 bli legendary. 
            int curse = generator.Next(1, 3);//inte den bästa lösningen direkt, men nu slumpas iaf curse på en 50/50. 
            if(curse == 1)
            {
                cursed = true;
            }
            else
            {
                cursed = false;
            }

            //name = generator.Next(0, name.Count);


        }

        public void PrintInfo()
        {
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Rarity: " + rarity);
            System.Console.WriteLine("Category: " + category[generator.Next(0, category.Count)]);
            System.Console.WriteLine("Price: " + price);
        }

        /*public int Evaluate()
        {
            price = actualValue * price;

            //price = (float) generator.NextDouble();
        }*/

        /*public string GetCategory()
        {
            return category;
        }*/

        public string GetName()
        {
            System.Console.WriteLine("Give the book a name:");
            name = Console.ReadLine();
            return name;
        }

        /*public bool IsCursed()
        {

        }*/
    }
}
