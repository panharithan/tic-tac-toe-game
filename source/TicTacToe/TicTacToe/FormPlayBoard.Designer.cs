namespace TicTacToe
{
    partial class FormPlayBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTurn = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelVictory = new System.Windows.Forms.Label();
            this.labelBoardTitle = new System.Windows.Forms.Label();
            this.labelBoard = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelPlayer3 = new System.Windows.Forms.Label();
            this.labelPlusVictoryCount = new System.Windows.Forms.Label();
            this.buttonPlayerMode = new System.Windows.Forms.Button();
            this.labelPlusVictory = new System.Windows.Forms.Label();
            this.labelOvictoryCount = new System.Windows.Forms.Label();
            this.buttonNewgame = new System.Windows.Forms.Button();
            this.labelXvictoryCount = new System.Windows.Forms.Label();
            this.labelOvictory = new System.Windows.Forms.Label();
            this.labelPlayerMode = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelXvictory = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelTurn);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.labelVictory);
            this.panel1.Controls.Add(this.labelBoardTitle);
            this.panel1.Controls.Add(this.labelBoard);
            this.panel1.Controls.Add(this.labelPlayer2);
            this.panel1.Controls.Add(this.labelPlayer3);
            this.panel1.Controls.Add(this.labelPlusVictoryCount);
            this.panel1.Controls.Add(this.buttonPlayerMode);
            this.panel1.Controls.Add(this.labelPlusVictory);
            this.panel1.Controls.Add(this.labelOvictoryCount);
            this.panel1.Controls.Add(this.buttonNewgame);
            this.panel1.Controls.Add(this.labelXvictoryCount);
            this.panel1.Controls.Add(this.labelOvictory);
            this.panel1.Controls.Add(this.labelPlayerMode);
            this.panel1.Controls.Add(this.labelResult);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.labelXvictory);
            this.panel1.Controls.Add(this.labelPlayer1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(637, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 841);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTurn.Font = new System.Drawing.Font("Perpetua", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.ForeColor = System.Drawing.SystemColors.Info;
            this.labelTurn.Location = new System.Drawing.Point(216, 721);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(96, 42);
            this.labelTurn.TabIndex = 23;
            this.labelTurn.Text = "Turn";
            this.labelTurn.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.buttonRefresh.Location = new System.Drawing.Point(284, 57);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(153, 40);
            this.buttonRefresh.TabIndex = 22;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelVictory
            // 
            this.labelVictory.AutoSize = true;
            this.labelVictory.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVictory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelVictory.Location = new System.Drawing.Point(240, 130);
            this.labelVictory.Name = "labelVictory";
            this.labelVictory.Size = new System.Drawing.Size(113, 36);
            this.labelVictory.TabIndex = 11;
            this.labelVictory.Text = "label5";
            // 
            // labelBoardTitle
            // 
            this.labelBoardTitle.AutoSize = true;
            this.labelBoardTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelBoardTitle.Location = new System.Drawing.Point(255, 764);
            this.labelBoardTitle.Name = "labelBoardTitle";
            this.labelBoardTitle.Size = new System.Drawing.Size(69, 28);
            this.labelBoardTitle.TabIndex = 21;
            this.labelBoardTitle.Text = "Board";
            // 
            // labelBoard
            // 
            this.labelBoard.AutoSize = true;
            this.labelBoard.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelBoard.Location = new System.Drawing.Point(330, 764);
            this.labelBoard.Name = "labelBoard";
            this.labelBoard.Size = new System.Drawing.Size(23, 28);
            this.labelBoard.TabIndex = 20;
            this.labelBoard.Text = "1";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2.Location = new System.Drawing.Point(8, 351);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(115, 32);
            this.labelPlayer2.TabIndex = 14;
            this.labelPlayer2.Text = "Player2";
            this.labelPlayer2.Click += new System.EventHandler(this.labelPlayer2_Click);
            // 
            // labelPlayer3
            // 
            this.labelPlayer3.AutoSize = true;
            this.labelPlayer3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer3.Location = new System.Drawing.Point(3, 575);
            this.labelPlayer3.Name = "labelPlayer3";
            this.labelPlayer3.Size = new System.Drawing.Size(115, 32);
            this.labelPlayer3.TabIndex = 15;
            this.labelPlayer3.Text = "Player3";
            this.labelPlayer3.Click += new System.EventHandler(this.labelPlayer3_Click);
            // 
            // labelPlusVictoryCount
            // 
            this.labelPlusVictoryCount.AutoSize = true;
            this.labelPlusVictoryCount.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlusVictoryCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelPlusVictoryCount.Location = new System.Drawing.Point(255, 645);
            this.labelPlusVictoryCount.Name = "labelPlusVictoryCount";
            this.labelPlusVictoryCount.Size = new System.Drawing.Size(98, 28);
            this.labelPlusVictoryCount.TabIndex = 19;
            this.labelPlusVictoryCount.Text = "X victory";
            // 
            // buttonPlayerMode
            // 
            this.buttonPlayerMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayerMode.ForeColor = System.Drawing.Color.Blue;
            this.buttonPlayerMode.Location = new System.Drawing.Point(3, 87);
            this.buttonPlayerMode.Name = "buttonPlayerMode";
            this.buttonPlayerMode.Size = new System.Drawing.Size(204, 40);
            this.buttonPlayerMode.TabIndex = 9;
            this.buttonPlayerMode.Text = "Player Mode";
            this.buttonPlayerMode.UseVisualStyleBackColor = true;
            this.buttonPlayerMode.Click += new System.EventHandler(this.buttonPlayerMode_Click);
            // 
            // labelPlusVictory
            // 
            this.labelPlusVictory.AutoSize = true;
            this.labelPlusVictory.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlusVictory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelPlusVictory.Location = new System.Drawing.Point(255, 617);
            this.labelPlusVictory.Name = "labelPlusVictory";
            this.labelPlusVictory.Size = new System.Drawing.Size(95, 28);
            this.labelPlusVictory.TabIndex = 15;
            this.labelPlusVictory.Text = "+ victory";
            // 
            // labelOvictoryCount
            // 
            this.labelOvictoryCount.AutoSize = true;
            this.labelOvictoryCount.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOvictoryCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelOvictoryCount.Location = new System.Drawing.Point(252, 414);
            this.labelOvictoryCount.Name = "labelOvictoryCount";
            this.labelOvictoryCount.Size = new System.Drawing.Size(98, 28);
            this.labelOvictoryCount.TabIndex = 18;
            this.labelOvictoryCount.Text = "X victory";
            // 
            // buttonNewgame
            // 
            this.buttonNewgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewgame.ForeColor = System.Drawing.Color.Blue;
            this.buttonNewgame.Location = new System.Drawing.Point(3, 3);
            this.buttonNewgame.Name = "buttonNewgame";
            this.buttonNewgame.Size = new System.Drawing.Size(176, 48);
            this.buttonNewgame.TabIndex = 8;
            this.buttonNewgame.Text = "New game";
            this.buttonNewgame.UseVisualStyleBackColor = true;
            this.buttonNewgame.Click += new System.EventHandler(this.buttonNewgame_Click);
            // 
            // labelXvictoryCount
            // 
            this.labelXvictoryCount.AutoSize = true;
            this.labelXvictoryCount.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXvictoryCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelXvictoryCount.Location = new System.Drawing.Point(252, 220);
            this.labelXvictoryCount.Name = "labelXvictoryCount";
            this.labelXvictoryCount.Size = new System.Drawing.Size(98, 28);
            this.labelXvictoryCount.TabIndex = 17;
            this.labelXvictoryCount.Text = "X victory";
            // 
            // labelOvictory
            // 
            this.labelOvictory.AutoSize = true;
            this.labelOvictory.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOvictory.ForeColor = System.Drawing.Color.Red;
            this.labelOvictory.Location = new System.Drawing.Point(249, 386);
            this.labelOvictory.Name = "labelOvictory";
            this.labelOvictory.Size = new System.Drawing.Size(101, 28);
            this.labelOvictory.TabIndex = 14;
            this.labelOvictory.Text = "O victory";
            // 
            // labelPlayerMode
            // 
            this.labelPlayerMode.AutoSize = true;
            this.labelPlayerMode.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerMode.Location = new System.Drawing.Point(9, 54);
            this.labelPlayerMode.Name = "labelPlayerMode";
            this.labelPlayerMode.Size = new System.Drawing.Size(138, 30);
            this.labelPlayerMode.TabIndex = 10;
            this.labelPlayerMode.Text = "1 player";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelResult.Location = new System.Drawing.Point(242, 92);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(85, 32);
            this.labelResult.TabIndex = 16;
            this.labelResult.Text = "Result";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(9, 610);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(198, 175);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // labelXvictory
            // 
            this.labelXvictory.AutoSize = true;
            this.labelXvictory.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXvictory.ForeColor = System.Drawing.Color.Blue;
            this.labelXvictory.Location = new System.Drawing.Point(249, 192);
            this.labelXvictory.Name = "labelXvictory";
            this.labelXvictory.Size = new System.Drawing.Size(98, 28);
            this.labelXvictory.TabIndex = 13;
            this.labelXvictory.Text = "X victory";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.Location = new System.Drawing.Point(3, 130);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(115, 32);
            this.labelPlayer1.TabIndex = 13;
            this.labelPlayer1.Text = "Player1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(9, 386);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 186);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(9, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.Crimson;
            this.buttonQuit.Location = new System.Drawing.Point(185, 5);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(93, 46);
            this.buttonQuit.TabIndex = 12;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.BlueViolet;
            this.buttonSave.Location = new System.Drawing.Point(284, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 46);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(396, 799);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 33);
            this.label10.TabIndex = 24;
            this.label10.Text = "s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(292, 799);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 33);
            this.label9.TabIndex = 25;
            this.label9.Text = "m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(209, 799);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 33);
            this.label8.TabIndex = 26;
            this.label8.Text = "h";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 799);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 33);
            this.label7.TabIndex = 27;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 799);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 33);
            this.label6.TabIndex = 28;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 799);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 33);
            this.label5.TabIndex = 29;
            this.label5.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 799);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 33);
            this.label4.TabIndex = 30;
            this.label4.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 799);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "0";
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // FormPlayBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1131, 841);
            this.Controls.Add(this.panel1);
            this.Name = "FormPlayBoard";
            this.Text = "FormPlayBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlayBoard_FormClosing);
            this.Load += new System.EventHandler(this.FormPlayBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelVictory;
        private System.Windows.Forms.Label labelPlayerMode;
        private System.Windows.Forms.Button buttonPlayerMode;
        private System.Windows.Forms.Button buttonNewgame;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelPlayer3;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelXvictory;
        private System.Windows.Forms.Label labelOvictory;
        private System.Windows.Forms.Label labelPlusVictory;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelXvictoryCount;
        private System.Windows.Forms.Label labelOvictoryCount;
        private System.Windows.Forms.Label labelPlusVictoryCount;
        private System.Windows.Forms.Label labelBoard;
        private System.Windows.Forms.Label labelBoardTitle;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer4;
    }
}