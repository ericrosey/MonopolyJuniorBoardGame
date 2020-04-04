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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        //PlayerClass user = new PlayerClass();

        private void btnConfirmName_Click(object sender, EventArgs e)
        {
            if(txtPlayerName.Text == "")
            {
                MessageBox.Show("You Must Enter a Name");
                return;
            }
            else
            { 
                btnConfirmName.Enabled = false;
                txtPlayerName.ReadOnly = true;
                lblWhichColor.Visible = true;
                btnRed.Visible = true;
                btnBlue.Visible = true;
                btnYellow.Visible = true;
                btnPink.Visible = true;
                MonopolyBoardGame.user.setName(txtPlayerName.Text);
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            MonopolyBoardGame.user.setColor(System.Drawing.Color.Red);
            btnRed.Enabled = false;
            btnBlue.Enabled = false;
            btnYellow.Enabled = false;
            btnPink.Enabled = false;
            btnPlayGame.Visible = true;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            MonopolyBoardGame.user.setColor(System.Drawing.Color.Blue);
            btnRed.Enabled = false;
            btnBlue.Enabled = false;
            btnYellow.Enabled = false;
            btnPink.Enabled = false;
            btnPlayGame.Visible = true;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            MonopolyBoardGame.user.setColor(System.Drawing.Color.Yellow);
            btnRed.Enabled = false;
            btnBlue.Enabled = false;
            btnYellow.Enabled = false;
            btnPink.Enabled = false;
            btnPlayGame.Visible = true;
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            MonopolyBoardGame.user.setColor(System.Drawing.Color.Pink);
            btnRed.Enabled = false;
            btnBlue.Enabled = false;
            btnYellow.Enabled = false;
            btnPink.Enabled = false;
            btnPlayGame.Visible = true;
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MonopolyBoardGame.user.displayPlayer());
            Form MonopolyBoard = new MonopolyBoard();
            MonopolyBoard.ShowDialog();
            this.Visible = false;
            this.Close(); 
        }
    }
}
