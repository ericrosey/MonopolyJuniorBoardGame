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
    public partial class MonopolyBoard : Form
    {
        public MonopolyBoard()
        {
            InitializeComponent();
        }
        private const int MONOPOLYBOARDSIZE = 7;

        private PictureBox[,] newPictureBox = new PictureBox[MONOPOLYBOARDSIZE, MONOPOLYBOARDSIZE];

        public Point[] locations = new Point[23];

        int spaceCellWidth = 72;
        int spaceCellHeight = 72;
        int xboardUpperLeft = 45;
        int yboardUpperLeft = 45;

        private void createMonopolyBoardOnForm()//allows for panel to be visible and starts creating board
        {
            pnlBoard.Visible = true;
            createBoard();
        }
        
        private void createBoard()//makes the board on the panel
        {
            Size size = new Size(spaceCellWidth, spaceCellHeight);
            Point loc = new Point(0, 0);

            int x;
            int y;
            int imageListIndex = 0;


            for(int row = 0; row < MONOPOLYBOARDSIZE; row++)
            {
                loc.Y = row * size.Height;
                for (int col = 0; col < MONOPOLYBOARDSIZE; col++)
                {
                    if(row == 0) //top row
                    {
                        newPictureBox[row, col] = new PictureBox();
                        newPictureBox[row, col].Location = new Point(col * size.Width, loc.Y);//sets its location
                        newPictureBox[row, col].Size = size;//sets its size
                        newPictureBox[row, col].BackColor = System.Drawing.Color.Black;//sets backcolor for border visual
                        newPictureBox[row, col].Image = imgListSpaces.Images[imageListIndex];//sets picture to proper space image
                        newPictureBox[row, col].Padding = new System.Windows.Forms.Padding(1);//padding helped with border
                        imageListIndex++;//increment img index to change images for image list
                    }
                    else if(row == 1 && col == 0) //2nd row 1st col
                    {
                        newPictureBox[row, col] = new PictureBox();
                        newPictureBox[row, col].Location = new Point(col * size.Width , loc.Y);
                        newPictureBox[row, col].Size = size;
                        newPictureBox[row, col].BackColor = System.Drawing.Color.Black;
                        newPictureBox[row, col].Image = imgListSpaces.Images[imageListIndex];
                        newPictureBox[row, col].Padding = new System.Windows.Forms.Padding(1);
                        imageListIndex++;
                    }
                    else if(row == 1 && col == 6) //2nd row 6th col
                    {
                        newPictureBox[row, col] = new PictureBox();
                        newPictureBox[row, col].Location = new Point(col * size.Width, loc.Y);
                        newPictureBox[row, col].Size = size;
                        newPictureBox[row, col].BackColor = System.Drawing.Color.Black;
                        newPictureBox[row, col].Image = imgListSpaces.Images[imageListIndex];
                        newPictureBox[row, col].Padding = new System.Windows.Forms.Padding(1);
                        imageListIndex++;
                    }
                    else if(row == 2 && col == 0)
                    {
                        newPictureBox[row, col] = new PictureBox();
                        newPictureBox[row, col].Location = new Point(col * size.Width, loc.Y);
                        newPictureBox[row, col].Size = size;
                        newPictureBox[row, col].BackColor = System.Drawing.Color.Black;
                        newPictureBox[row, col].Image = imgListSpaces.Images[imageListIndex];
                        newPictureBox[row, col].Padding = new System.Windows.Forms.Padding(1);
                        imageListIndex++;
                    }
                    else if (row == 2 && col == 6)
                    {
                        newPictureBox[row, col] = new PictureBox();
                        newPictureBox[row, col].Location = new Point(col * size.Width, loc.Y);
                        newPictureBox[row, col].Size = size;
                        newPictureBox[row, col].BackColor = System.Drawing.Color.Black;
                        newPictureBox[row, col].Image = imgListSpaces.Images[imageListIndex];
                        newPictureBox[row, col].Padding = new System.Windows.Forms.Padding(1);
                        imageListIndex++;
                    }
                    else if (row == 3 && col == 0)
                    {
                        newPictureBox[row, col] = new PictureBox();
                        newPictureBox[row, col].Location = new Point(col * size.Width, loc.Y);
                        newPictureBox[row, col].Size = size;
                        newPictureBox[row, col].BackColor = System.Drawing.Color.Black;
                        newPictureBox[row, col].Image = imgListSpaces.Images[imageListIndex];
                        newPictureBox[row, col].Padding = new System.Windows.Forms.Padding(1);
                        imageListIndex++;
                    }
                    else if (row == 3 && col == 6)
                    {
                        newPictureBox[row, col] = new PictureBox();
                        newPictureBox[row, col].Location = new Point(col * size.Width, loc.Y);
                        newPictureBox[row, col].Size = size;
                        newPictureBox[row, col].BackColor = System.Drawing.Color.Black;
                        newPictureBox[row, col].Image = imgListSpaces.Images[imageListIndex];
                        newPictureBox[row, col].Padding = new System.Windows.Forms.Padding(1);
                        imageListIndex++;
                    }
                    else if (row == 4 && col == 0)
                    {
                        newPictureBox[row, col] = new PictureBox();
                        newPictureBox[row, col].Location = new Point(col * size.Width, loc.Y);
                        newPictureBox[row, col].Size = size;
                        newPictureBox[row, col].BackColor = System.Drawing.Color.Black;
                        newPictureBox[row, col].Image = imgListSpaces.Images[imageListIndex];
                        newPictureBox[row, col].Padding = new System.Windows.Forms.Padding(1);
                        imageListIndex++;
                    }
                    else if (row == 4 && col == 6)
                    {
                        newPictureBox[row, col] = new PictureBox();
                        newPictureBox[row, col].Location = new Point(col * size.Width, loc.Y);
                        newPictureBox[row, col].Size = size;
                        newPictureBox[row, col].BackColor = System.Drawing.Color.Black;
                        newPictureBox[row, col].Image = imgListSpaces.Images[imageListIndex];
                        newPictureBox[row, col].Padding = new System.Windows.Forms.Padding(1);
                        imageListIndex++;
                    }
                    else if (row == 5 && col == 0)
                    {
                        newPictureBox[row, col] = new PictureBox();
                        newPictureBox[row, col].Location = new Point(col * size.Width, loc.Y);
                        newPictureBox[row, col].Size = size;
                        newPictureBox[row, col].BackColor = System.Drawing.Color.Black;
                        newPictureBox[row, col].Image = imgListSpaces.Images[imageListIndex];
                        newPictureBox[row, col].Padding = new System.Windows.Forms.Padding(1);
                        imageListIndex++;
                    }
                    else if (row == 5 && col == 6)
                    {
                        newPictureBox[row, col] = new PictureBox();
                        newPictureBox[row, col].Location = new Point(col * size.Width, loc.Y);
                        newPictureBox[row, col].Size = size;
                        newPictureBox[row, col].BackColor = System.Drawing.Color.Black;
                        newPictureBox[row, col].Image = imgListSpaces.Images[imageListIndex];
                        newPictureBox[row, col].Padding = new System.Windows.Forms.Padding(1);
                        imageListIndex++;
                    }
                    else if (row == 6)
                    {
                        newPictureBox[row, col] = new PictureBox();
                        newPictureBox[row, col].Location = new Point(col * size.Width, loc.Y);
                        newPictureBox[row, col].Size = size;
                        newPictureBox[row, col].BackColor = System.Drawing.Color.Black;
                        newPictureBox[row, col].Image = imgListSpaces.Images[imageListIndex];
                        newPictureBox[row, col].Padding = new System.Windows.Forms.Padding(1);
                        imageListIndex++;
                    }
                    else//sets center of board to be white
                    {
                        newPictureBox[row, col] = new PictureBox();
                        newPictureBox[row, col].Location = new Point(col * size.Width, loc.Y);
                        newPictureBox[row, col].Size = size;
                        newPictureBox[row, col].BackColor = System.Drawing.Color.White ;
                    }
                    newPictureBox[row, col].Name = "pbx" + row.ToString() + col.ToString();
                    pnlBoard.Controls.Add(newPictureBox[row, col]);

                }//end col for loop
            }//end row for loop
        }//end createBoard

        private void Form1_Load(object sender, EventArgs e)
        {
            createMonopolyBoardOnForm();//create board on form
            txtUserPlayerName.Text = MonopolyBoardGame.user.getName();//sets textbox to user name
            btnUserColor.BackColor = MonopolyBoardGame.user.getColor();//sets color for user to the color they picked

            txtUserMoney.Text = "$" + Convert.ToString(MonopolyBoardGame.user.getMoney());//puts user money in textbox
            pnlBoard.SendToBack();//forces panel to back

            MonopolyBoardGame.player2.setColor(System.Drawing.Color.Orange);//sets color for 2nd player
            MonopolyBoardGame.player2.setName("Player 2");//sets name for 2nd player
            txtPlayer2Name.Text = MonopolyBoardGame.player2.getName();//puts 2nd players name in textbox
            txtPlayer2Money.Text = "$" + Convert.ToString(MonopolyBoardGame.player2.getMoney());//puts 2nd player money in textbox

            Button btn2 = MonopolyBoardGame.player2.makeButton();//makes button from player2 info
            pnlBoard.Controls.Add(btn2);//adds btn to panel
            btn2.BringToFront();//makes sure it is visible above the panel

            Button btn1 = MonopolyBoardGame.user.makeButton();//makes button from user info
            pnlBoard.Controls.Add(btn1);//adds btn to panel
            btn1.BringToFront();//makes sure it is visible
            MonopolyBoardGame.spaceList.initializeEntireList();//initializes space list

            MonopolyBoardGame.cardList.initializeCardList();//initializes card list
        }
        
        private void btnRollDie_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int roll = random.Next(1, 7);//gets random num for dice roll
            MessageBox.Show("Roll: " + roll);//shows dice roll
            if (!MonopolyBoardGame.turn)//user turn
            {
                MonopolyBoardGame.user.movePiece(roll);
                txtUserMoney.Text = "$" + Convert.ToString(MonopolyBoardGame.user.getMoney());//sets visible money to correct values
                txtPlayer2Money.Text = "$" + Convert.ToString(MonopolyBoardGame.player2.getMoney());
                if(MonopolyBoardGame.user.getMoney() == 0)//user is bankrupt
                {
                    btnRollDie.Enabled = false;//doesnt let them roll again
                    MessageBox.Show(MonopolyBoardGame.player2.getName() + " IS THE WINNER!!!!!");
                }
            }
            else//player2 turn
            {
                MonopolyBoardGame.player2.movePiece(roll);
                txtPlayer2Money.Text = "$" + Convert.ToString(MonopolyBoardGame.player2.getMoney());//sets visible money to correct values
                txtUserMoney.Text = "$" + Convert.ToString(MonopolyBoardGame.user.getMoney());
                if (MonopolyBoardGame.player2.getMoney() == 0)//player 2 bankrupt
                {
                    btnRollDie.Enabled = false;//doesnt let them roll again
                    MessageBox.Show(MonopolyBoardGame.user.getName() + " IS THE WINNER!!!!!");
                }
            }
            
        }
    }//close class
}//close namespace
