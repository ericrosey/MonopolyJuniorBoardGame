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
        private Button piece;
        

        public PlayerClass()
        {
            playerLocation = 0;
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
        public void movePiece(int roll)
        {
            if (playerLocation + roll <= 23)
            {
                playerLocation = playerLocation + roll;//for if they dont pass go
            }
            else//if they pass go
            {
                int newLocation = (playerLocation + roll) - 24;
                playerLocation = newLocation;
            }
            MessageBox.Show("PlayerLocation: " + playerLocation.ToString()); 
        }
        public Button makeButton()
        {
            Button gamePiece = new Button();
            gamePiece.BackColor = playerColor;
            gamePiece.Size = new Size(25, 25);
            gamePiece.Location = new Point(450, 460);
            
            piece = gamePiece;
            return piece;
        }
    }
}
