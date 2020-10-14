using System;

namespace KlassProv
{
    public class Kunder
    {
        private int amount;

        private int money;

        private int interest;

        private Random generator = new Random();

        public void Costumer()//Costumer kommer att slumpa antalet pengar och interest. Det fungerar att lägga detta i en och samma metod då man kan se det som att individen skapas.
        {
            int interestDecider = generator.Next(1,4);
            if(interestDecider == 1)
            {

            }
        }
        public int GetAmount()//Spelaren får skriva in hur många kunder hen vill ha. 
        {
            System.Console.WriteLine("How many costomers do you want");
            string answer = Console.ReadLine();
            //Tryparse
            //amount = answer;

            return amount;
        }

    }
}
