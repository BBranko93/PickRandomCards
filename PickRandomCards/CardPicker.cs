using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    class CardPicker
    {
        // This is a static field called random that
        // we will use to generate random numbers
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // Get a random number from 1 to 4
            int value = random.Next(1, 5);
            // If it's 1 return the string Spades
            if (value == 1) return "Spades";
            // If it's 2 return the string Hearts
            if (value == 2) return "Hearts";
            // If it's 3 return the string Clubs
            if (value == 3) return "Clubs";
            // If we havent returned yet, return the string Diamonds
            return "Diamonds";
        }

        private static string RandomValue()
        {
            // Get a random number from 1 to 14
            int value = random.Next(1, 14);
            // If it's 1 return the string Ace
            if (value == 1) return "Ace";
            // If it's 11 return the string Jack
            if (value == 11) return "Jack";
            // If it's 12 return the string Queen
            if (value == 12) return "Queen";
            // If it's 13 return the string King
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
