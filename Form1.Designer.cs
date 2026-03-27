namespace Tic_Tac_Toe_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitleGame = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.lbltitlewinner = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.comBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleGame
            // 
            this.lblTitleGame.AutoSize = true;
            this.lblTitleGame.Font = new System.Drawing.Font("Elephant", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleGame.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblTitleGame.Location = new System.Drawing.Point(519, 47);
            this.lblTitleGame.Name = "lblTitleGame";
            this.lblTitleGame.Size = new System.Drawing.Size(370, 46);
            this.lblTitleGame.TabIndex = 9;
            this.lblTitleGame.Text = "Tic Tac Toe Game";
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblPlayerTurn.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPlayerTurn.Location = new System.Drawing.Point(125, 151);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(91, 39);
            this.lblPlayerTurn.TabIndex = 10;
            this.lblPlayerTurn.Text = "Turn";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblPlayer.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblPlayer.Location = new System.Drawing.Point(112, 207);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(147, 39);
            this.lblPlayer.TabIndex = 11;
            this.lblPlayer.Text = "Player 1";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(431, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 126);
            this.button1.TabIndex = 12;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(659, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 126);
            this.button2.TabIndex = 13;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(887, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 126);
            this.button3.TabIndex = 14;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button4.Location = new System.Drawing.Point(431, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 126);
            this.button4.TabIndex = 15;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button5.Location = new System.Drawing.Point(659, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 126);
            this.button5.TabIndex = 16;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button6.Location = new System.Drawing.Point(887, 319);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 126);
            this.button6.TabIndex = 17;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button7.Location = new System.Drawing.Point(431, 477);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 126);
            this.button7.TabIndex = 18;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button8.Location = new System.Drawing.Point(659, 477);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(159, 126);
            this.button8.TabIndex = 19;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button9.Location = new System.Drawing.Point(887, 477);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(159, 126);
            this.button9.TabIndex = 20;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // lbltitlewinner
            // 
            this.lbltitlewinner.AutoSize = true;
            this.lbltitlewinner.BackColor = System.Drawing.Color.Transparent;
            this.lbltitlewinner.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbltitlewinner.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbltitlewinner.Location = new System.Drawing.Point(125, 280);
            this.lbltitlewinner.Name = "lbltitlewinner";
            this.lbltitlewinner.Size = new System.Drawing.Size(133, 39);
            this.lbltitlewinner.TabIndex = 21;
            this.lbltitlewinner.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblWinner.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblWinner.Location = new System.Drawing.Point(94, 357);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(192, 39);
            this.lblWinner.TabIndex = 22;
            this.lblWinner.Text = "InProgress";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnReset.Location = new System.Drawing.Point(101, 446);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(199, 60);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // comBox1
            // 
            this.comBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comBox1.FormattingEnabled = true;
            this.comBox1.Items.AddRange(new object[] {
            "Player1",
            "Player2"});
            this.comBox1.Location = new System.Drawing.Point(35, 47);
            this.comBox1.Name = "comBox1";
            this.comBox1.Size = new System.Drawing.Size(150, 32);
            this.comBox1.TabIndex = 24;
            this.comBox1.SelectedIndexChanged += new System.EventHandler(this.WhoWillStart);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Who will Start";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1069, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lbltitlewinner);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.lblTitleGame);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitleGame;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lbltitlewinner;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox comBox1;
        private System.Windows.Forms.Label label1;
    }
}

