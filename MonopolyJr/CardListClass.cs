using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string nextCard;
            Boolean isEndOfFile = true;
            Boolean success;
            int countSpaces = 0;

            nextCard = MonopolyBoardGame.readCardFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                countSpaces++;
                CardClass card = new CardClass();
                success = card.createCardObject(nextCard);
                if (success != true)
                {
                    MessageBox.Show("unable to create spaceObject");
                    return false;
                }
                InternalList.Add(card);
                nextCard = MonopolyBoardGame.readCardFile.getNextRecord(ref isEndOfFile);

            }
            if (countSpaces > 0)
                return true;
            else
                return false;

        }
        public int randomNumberCard()
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1, 9);
            return number;
        }
        public CardClass randomCard()
        {
            index = randomNumberCard();
            foreach (CardClass card in InternalList)
            {
                if (card.checkCardID(index) == true)
                    return card;
                
            }
            CardClass cards = new CardClass();
            return cards;
            
        }


        }
    }

