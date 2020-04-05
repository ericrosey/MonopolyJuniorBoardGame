using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyJr
{
    class CardListClass
    {
        private CardClass Card = new CardClass();
        private int index;
        private List<CardClass> InternalList;

        public CardListClass()
        {
            InternalList = new List<CardClass>();
        }
        public Boolean initializeCardList()
        {
            return true;
        }
        public int randomNumberCard()
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1, 8);
            return number;
        }
        public string randomCard()
        {
            return "t";
        }
    }
}
