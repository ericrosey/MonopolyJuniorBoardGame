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
        //three attributes of card object
        private int cardId, cardValue;
        private string cardText;

        public CardClass()//paramterless constructor
        {

        }

        public string displayCard()//display method that adds attribtues
        {
            return cardText + "\n$" + cardValue;
        }
        public int getCardValue()//getter
        {
            return cardValue;
        } 

        public Boolean createCardObject(string c)//creates card objects from text file
        {
            CardClass card = this;//creates object 
            string[] cardString = c.Split('*');//splits object into seperate text for conversion of attributes

            int cardStringSize = cardString.GetLength(0);
            for(int i = 0; i < cardStringSize; i++)//loops thru cards
            {
                cardString[i] = cardString[i].Trim();
            }
            if(cardString[0].Length > 1)//for card id
            {
                MessageBox.Show("incorrect length");
                return false;
            }
            try
            {
                cardId = Convert.ToInt32(cardString[0]);//tries to convert

            }
            catch//catches if not a number
            {
                MessageBox.Show("not a number");
                return false;
            }
            cardText = cardString[1];
            if(cardText == "" || cardText == " ")//makes sure there is some text
            {
                MessageBox.Show("Card has no text");
                return false;
            }
            try
            {
                cardValue = Convert.ToInt32(cardString[2]);//tries ti cnvert  card value
            }
            catch
            {
                MessageBox.Show("Card Value Not Integer");
            }
            return true;
        }
        public Boolean checkCardID(int ID)//to get space in list for SpaceListClass
        {
            CardClass card = this;//object

            if (ID == card.cardId)
            {
                //cards attributes
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
