namespace MonopolyJr
{
    partial class Welcome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWhatsYourName = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnConfirmName = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnPink = new System.Windows.Forms.Button();
            this.lblWhichColor = new System.Windows.Forms.Label();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(162, 23);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(464, 39);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Monopoly Junior!";
            // 
            // lblWhatsYourName
            // 
            this.lblWhatsYourName.AutoSize = true;
            this.lblWhatsYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatsYourName.Location = new System.Drawing.Point(278, 82);
            this.lblWhatsYourName.Name = "lblWhatsYourName";
            this.lblWhatsYourName.Size = new System.Drawing.Size(213, 29);
            this.lblWhatsYourName.TabIndex = 1;
            this.lblWhatsYourName.Text = "What\'s your name?";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(273, 123);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(218, 30);
            this.txtPlayerName.TabIndex = 2;
            // 
            // btnConfirmName
            // 
            this.btnConfirmName.BackColor = System.Drawing.Color.Green;
            this.btnConfirmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmName.Location = new System.Drawing.Point(531, 123);
            this.btnConfirmName.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirmName.Name = "btnConfirmName";
            this.btnConfirmName.Size = new System.Drawing.Size(144, 30);
            this.btnConfirmName.TabIndex = 3;
            this.btnConfirmName.Text = "CONFIRM";
            this.btnConfirmName.UseVisualStyleBackColor = false;
            this.btnConfirmName.Click += new System.EventHandler(this.btnConfirmName_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(115, 271);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(100, 100);
            this.btnRed.TabIndex = 4;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Visible = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(250, 271);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(100, 100);
            this.btnBlue.TabIndex = 5;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Visible = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(391, 271);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(100, 100);
            this.btnYellow.TabIndex = 6;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Visible = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnPink
            // 
            this.btnPink.BackColor = System.Drawing.Color.Pink;
            this.btnPink.Location = new System.Drawing.Point(531, 271);
            this.btnPink.Name = "btnPink";
            this.btnPink.Size = new System.Drawing.Size(100, 100);
            this.btnPink.TabIndex = 7;
            this.btnPink.UseVisualStyleBackColor = false;
            this.btnPink.Visible = false;
            this.btnPink.Click += new System.EventHandler(this.btnPink_Click);
            // 
            // lblWhichColor
            // 
            this.lblWhichColor.AutoSize = true;
            this.lblWhichColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhichColor.Location = new System.Drawing.Point(195, 198);
            this.lblWhichColor.Name = "lblWhichColor";
            this.lblWhichColor.Size = new System.Drawing.Size(366, 29);
            this.lblWhichColor.TabIndex = 8;
            this.lblWhichColor.Text = "Choose Your Game-Piece Color!";
            this.lblWhichColor.Visible = false;
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.BackColor = System.Drawing.Color.Green;
            this.btnPlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlayGame.Location = new System.Drawing.Point(321, 419);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(147, 38);
            this.btnPlayGame.TabIndex = 9;
            this.btnPlayGame.Text = "PLAY GAME";
            this.btnPlayGame.UseVisualStyleBackColor = false;
            this.btnPlayGame.Visible = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.lblWhichColor);
            this.Controls.Add(this.btnPink);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnConfirmName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblWhatsYourName);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWhatsYourName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnConfirmName;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnPink;
        private System.Windows.Forms.Label lblWhichColor;
        private System.Windows.Forms.Button btnPlayGame;
    }
}