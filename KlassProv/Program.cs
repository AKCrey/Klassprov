using System;

namespace KlassProv
{
    class Program
    {
        static void Main(string[] args)
        {
            Book theBook = new Book();
            
            theBook.GetName();

            theBook.Boook();

            theBook.PrintInfo();

            Console.ReadLine();

            //Planerade att lägga allt i en for-loop, där man får fortsätter tills antalet kunder man valt tar slut. Eller när ekonomin tar slut. 
        }
    }
}
