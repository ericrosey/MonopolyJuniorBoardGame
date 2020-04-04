using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonopolyJr
{
    class PlayerClass
    {
        private string playerName;
        private int playerLocation, playerMoney;
        private System.Drawing.Color playerColor;
        

        public PlayerClass()
        {

        }
        public void setName(string newName)
        {
            playerName = newName; 
        }
        public string getName()
        {
            return playerName;
        }
        public void setColor(System.Drawing.Color newColor)
        {
            playerColor = newColor;
        }

        public System.Drawing.Color getColor()
        {
            return playerColor;
        }
        public string displayPlayer()
        {
            return "Name: " + playerName + "\nColor: " + playerColor;
        }
        public void movePiece(Button movingButton)
        {

        }
    }
}
