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
        private List<SpaceClass> ownedSpaces = new List<SpaceClass>();
        private Button piece;
        private Point[] locations = new Point[24];

        public PlayerClass()//sets money and location to starting values, and fills location array
        {
            playerMoney = 20;
            playerLocation = 0;
            fillLocations();
        }
        public int getMoney()
        {
            return playerMoney;
        }
        public void setMoney(int newMoney)
        {
            playerMoney = newMoney;
        }
        public void fillLocations()//sets locations to points on board corresponding to spaces
        {
            locations[0] = new Point(450, 450);
            locations[1] = new Point(380, 450);
            locations[2] = new Point(310, 450);
            locations[3] = new Point(240, 450);
            locations[4] = new Point(170, 450);
            locations[5] = new Point(100, 450);
            locations[6] = new Point(30, 450);
            locations[7] = new Point(30, 380);
            locations[8] = new Point(30, 310);
            locations[9] = new Point(30, 240);
            locations[10] = new Point(30, 170);
            locations[11] = new Point(30, 100);
            locations[12] = new Point(30, 30);
            locations[13] = new Point(100, 30);
            locations[14] = new Point(170, 30);
            locations[15] = new Point(240, 30);
            locations[16] = new Point(310, 30);
            locations[17] = new Point(380, 30);
            locations[18] = new Point(450, 30);
            locations[19] = new Point(450, 100);
            locations[20] = new Point(450, 170);
            locations[21] = new Point(450, 240);
            locations[22] = new Point(450, 310);
            locations[23] = new Point(450, 380);
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
                playerMoney = playerMoney + 2;//gives them $2 for passing go
                int newLocation = (playerLocation + roll) - 24;
                playerLocation = newLocation;
            }
            if(playerLocation == 18)//if they land on go to jail
            {
                if (playerMoney - 1 <= 0)
                {
                    MessageBox.Show("You don't have enough money to get out of jail");
                    getWinner();
                }
                else
                {
                    MessageBox.Show("You have to go to Jail :(");
                    playerMoney = playerMoney - 1;
                    playerLocation = 6;//sets location to jail
                    piece.Location = locations[6];//moves piece to jail
                    if (MonopolyBoardGame.turn)
                    {
                        MonopolyBoardGame.turn = false;
                    }
                    else
                    {
                        MonopolyBoardGame.turn = true;
                    }
                    return;
                }
            }
            piece.Location = locations[playerLocation];//sets loaction pf piece to player location
            MonopolyBoardGame.spaceList.getSpaceInList(playerLocation);
            //MessageBox.Show("PlayerLocation: " + playerLocation.ToString()); 
        }
        public Button makeButton()//creates button using player info
        {
            Button gamePiece = new Button();
            gamePiece.BackColor = playerColor;
            gamePiece.Size = new Size(25, 25);
            gamePiece.Location = new Point(450, 450);
            
            piece = gamePiece;
            return piece;
        }
        public void buyProperty(int rent, SpaceClass boughtSpace)
        {
            if(playerMoney - rent <= 0)//if they cant afford to buy
            {
                MessageBox.Show("Not enough Money!");
                getWinner();
            }
            else//subtracts money and add property to owned spaces
            {
                MessageBox.Show("You just bought: " + boughtSpace.getName());
                boughtSpace.setOwn(true);
                ownedSpaces.Add(boughtSpace);
                playerMoney = playerMoney - rent;
                
            }
        }
        public void userPayRent(int rent, SpaceClass landedSpace)
        {
            if (ownedSpaces.Contains(landedSpace))
            {
                MessageBox.Show("You own this space\n" + "Your turn is over");
            }
            else
            {
                if(playerMoney - rent <= 0)//if they cant afford to buy
                {
                    MessageBox.Show("You dont have enough money");
                    getWinner();
                }
                else//subtracts money and add money to other player
                {
                    MessageBox.Show("You owe $" + rent + "for " + landedSpace.getName());
                    int tempMoney = MonopolyBoardGame.player2.getMoney();
                    tempMoney = tempMoney + rent;
                    MonopolyBoardGame.player2.setMoney(tempMoney);
                    playerMoney = playerMoney - rent;
                }
            }
        }//end userPayRent
        public void player2PayRent(int rent, SpaceClass landedSpace)
        {
            if (ownedSpaces.Contains(landedSpace))
            {
                MessageBox.Show("You own this space");
            }
            else
            {
                if (playerMoney - rent <= 0)
                {
                    MessageBox.Show("You dont have enough money");//if they cant afford to pay
                    getWinner();
                }
                else//subtracts money and add money to other player
                {
                    MessageBox.Show("You owe $" + rent + "for " + landedSpace.getName());
                    int tempMoney = MonopolyBoardGame.user.getMoney();
                    tempMoney = tempMoney + rent;
                    MonopolyBoardGame.user.setMoney(tempMoney);
                    playerMoney = playerMoney - rent;
                }
            }
        }
        public void doChanceCard(CardClass pickedCard)
        {
            int moneyOnCard = pickedCard.getCardValue();
            if(playerMoney + moneyOnCard <= 0)//if they dont have enough money after chance action
            {
                MessageBox.Show("You are out of money");
                getWinner();
            }
            else//performs chance action
            {
                playerMoney = playerMoney + moneyOnCard;
            }
        }
        public void getWinner()//sets player money to zero after they run out
        {
            playerMoney = 0;
        }
        
    }
}
