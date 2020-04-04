namespace MonopolyJr
{
    partial class MonopolyBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonopolyBoard));
            this.imgListSpaces = new System.Windows.Forms.ImageList(this.components);
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblUserPlayerName = new System.Windows.Forms.Label();
            this.txtUserPlayerName = new System.Windows.Forms.TextBox();
            this.btnUserColor = new System.Windows.Forms.Button();
            this.pbxDie = new System.Windows.Forms.PictureBox();
            this.btnRollDie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie)).BeginInit();
            this.SuspendLayout();
            // 
            // imgListSpaces
            // 
            this.imgListSpaces.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListSpaces.ImageStream")));
            this.imgListSpaces.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListSpaces.Images.SetKeyName(0, "FreeParking.jpg");
            this.imgListSpaces.Images.SetKeyName(1, "VideoArcade.jpg");
            this.imgListSpaces.Images.SetKeyName(2, "Cinema.jpg");
            this.imgListSpaces.Images.SetKeyName(3, "Chance3.jpg");
            this.imgListSpaces.Images.SetKeyName(4, "ToyStore.jpg");
            this.imgListSpaces.Images.SetKeyName(5, "PetStore.jpg");
            this.imgListSpaces.Images.SetKeyName(6, "GoToJail.jpg");
            this.imgListSpaces.Images.SetKeyName(7, "SwimmingPool.jpg");
            this.imgListSpaces.Images.SetKeyName(8, "BowlingAlley.jpg");
            this.imgListSpaces.Images.SetKeyName(9, "SkatePark.jpg");
            this.imgListSpaces.Images.SetKeyName(10, "Zoo.jpg");
            this.imgListSpaces.Images.SetKeyName(11, "Chance2.jpg");
            this.imgListSpaces.Images.SetKeyName(12, "Chance4.jpg");
            this.imgListSpaces.Images.SetKeyName(13, "Library.jpg");
            this.imgListSpaces.Images.SetKeyName(14, "ParkPlace.jpg");
            this.imgListSpaces.Images.SetKeyName(15, "Museum.jpg");
            this.imgListSpaces.Images.SetKeyName(16, "Boardwalk.jpg");
            this.imgListSpaces.Images.SetKeyName(17, "Jail.jpg");
            this.imgListSpaces.Images.SetKeyName(18, "IceCreamParlor.jpg");
            this.imgListSpaces.Images.SetKeyName(19, "CandyStore.jpg");
            this.imgListSpaces.Images.SetKeyName(20, "Chance1.jpg");
            this.imgListSpaces.Images.SetKeyName(21, "PizzaHouse.jpg");
            this.imgListSpaces.Images.SetKeyName(22, "BurgerJoint.jpg");
            this.imgListSpaces.Images.SetKeyName(23, "Go.jpg");
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(57, 37);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(688, 645);
            this.pnlBoard.TabIndex = 0;
            this.pnlBoard.Visible = false;
            // 
            // lblUserPlayerName
            // 
            this.lblUserPlayerName.AutoSize = true;
            this.lblUserPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPlayerName.Location = new System.Drawing.Point(1005, 201);
            this.lblUserPlayerName.Name = "lblUserPlayerName";
            this.lblUserPlayerName.Size = new System.Drawing.Size(73, 25);
            this.lblUserPlayerName.TabIndex = 0;
            this.lblUserPlayerName.Text = "Player:";
            // 
            // txtUserPlayerName
            // 
            this.txtUserPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPlayerName.Location = new System.Drawing.Point(1084, 198);
            this.txtUserPlayerName.Name = "txtUserPlayerName";
            this.txtUserPlayerName.ReadOnly = true;
            this.txtUserPlayerName.Size = new System.Drawing.Size(168, 30);
            this.txtUserPlayerName.TabIndex = 1;
            // 
            // btnUserColor
            // 
            this.btnUserColor.Enabled = false;
            this.btnUserColor.Location = new System.Drawing.Point(1010, 229);
            this.btnUserColor.Name = "btnUserColor";
            this.btnUserColor.Size = new System.Drawing.Size(50, 50);
            this.btnUserColor.TabIndex = 2;
            this.btnUserColor.UseVisualStyleBackColor = true;
            // 
            // pbxDie
            // 
            this.pbxDie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxDie.BackgroundImage")));
            this.pbxDie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxDie.InitialImage = null;
            this.pbxDie.Location = new System.Drawing.Point(932, 528);
            this.pbxDie.Name = "pbxDie";
            this.pbxDie.Size = new System.Drawing.Size(100, 100);
            this.pbxDie.TabIndex = 4;
            this.pbxDie.TabStop = false;
            // 
            // btnRollDie
            // 
            this.btnRollDie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDie.Location = new System.Drawing.Point(903, 647);
            this.btnRollDie.Name = "btnRollDie";
            this.btnRollDie.Size = new System.Drawing.Size(157, 35);
            this.btnRollDie.TabIndex = 5;
            this.btnRollDie.Text = "ROLL DIE";
            this.btnRollDie.UseVisualStyleBackColor = true;
            this.btnRollDie.Click += new System.EventHandler(this.btnRollDie_Click);
            // 
            // MonopolyBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 965);
            this.Controls.Add(this.btnRollDie);
            this.Controls.Add(this.pbxDie);
            this.Controls.Add(this.btnUserColor);
            this.Controls.Add(this.txtUserPlayerName);
            this.Controls.Add(this.lblUserPlayerName);
            this.Controls.Add(this.pnlBoard);
            this.Name = "MonopolyBoard";
            this.Text = "MonopolyBoard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgListSpaces;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblUserPlayerName;
        private System.Windows.Forms.TextBox txtUserPlayerName;
        private System.Windows.Forms.Button btnUserColor;
        private System.Windows.Forms.PictureBox pbxDie;
        private System.Windows.Forms.Button btnRollDie;
    }
}

