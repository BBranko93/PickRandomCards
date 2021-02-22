using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of cards to pick:  ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                // This foreach loop executes Console.WriteLine(card) for each element in the array
                // returned by PickSomeCards
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("The number that you entered is not valid number!!");
            }
        }
    }
}
