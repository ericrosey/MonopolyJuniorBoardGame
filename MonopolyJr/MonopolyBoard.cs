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

        int spaceCellWidth = 72;
        int spaceCellHeight = 72;
        int xboardUpperLeft = 45;
        int yboardUpperLeft = 45;

        private void createMonopolyBoardOnForm()
        {
            pnlBoard.Visible = true;
            createBoard();
        }
        private void createBoard()
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
                        newPictureBox[row, col].Location = new Point(col * size.Width, loc.Y);
                        newPictureBox[row, col].Size = size;
                        newPictureBox[row, col].BackColor = System.Drawing.Color.Black;
                        newPictureBox[row, col].Image = imgListSpaces.Images[imageListIndex];
                        newPictureBox[row, col].Padding = new System.Windows.Forms.Padding(1);
                        imageListIndex++;
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
                    else
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
            createMonopolyBoardOnForm();
            txtUserPlayerName.Text = MonopolyBoardGame.user.getName();
            btnUserColor.BackColor = MonopolyBoardGame.user.getColor();
            btnUserPiece.BackColor = MonopolyBoardGame.user.getColor();
        }
    }//close class
}//close namespace
