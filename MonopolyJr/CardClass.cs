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

        private int cardValue;
        private string cardText;

        public object MessageShow { get; private set; }

        private Boolean createCardObject(string c)
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
                cardValue = Convert.ToInt32(cardString[0]);

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
            return true;
        }


        public bool getCardText(int ID)
        {
            return true;
        }
        public bool getCardValue(int ID)
        {
            return true;
        }
    }
}
