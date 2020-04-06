using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonopolyJr
{
    class CardClass
    {

        private int cardId, cardValue;
        private string cardText;

        public CardClass()
        {

        }

        public string displayCard()
        {
            return cardText + "\n$" + cardValue;
        }
        public int getCardValue()
        {
            return cardValue;
        } 

        public Boolean createCardObject(string c)
        {
            CardClass card = this;
            string[] cardString = c.Split('*');

            int cardStringSize = cardString.GetLength(0);
            for(int i = 0; i < cardStringSize; i++)
            {
                cardString[i] = cardString[i].Trim();
            }
            if(cardString[0].Length > 1)
            {
                MessageBox.Show("incorrect length");
                return false;
            }
            try
            {
                cardId = Convert.ToInt32(cardString[0]);

            }
            catch
            {
                MessageBox.Show("not a number");
                return false;
            }
            cardText = cardString[1];
            if(cardText == "" || cardText == " ")
            {
                MessageBox.Show("Card has no text");
                return false;
            }
            try
            {
                cardValue = Convert.ToInt32(cardString[2]);
            }
            catch
            {
                MessageBox.Show("Card Value Not Integer");
            }
            return true;
        }
        public Boolean checkCardID(int ID)//to get space in list for SpaceListClass
        {
            CardClass card = this;

            if (ID == card.cardId)
            {
                cardId = card.cardId;
                cardText = card.cardText;
                cardValue = card.cardValue;

                return true;
            }

            else
            {
                return false;
            }
        }




    }
}
