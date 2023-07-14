namespace TicTacToe
{
    partial class FormLoadGame1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonShowAllGame = new System.Windows.Forms.Button();
            this.labelPlayer3 = new System.Windows.Forms.Label();
            this.pictureBoxPlayer3 = new System.Windows.Forms.PictureBox();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.player1score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player2score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player3score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Draw = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boardNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonShowAllGame);
            this.panel1.Controls.Add(this.labelPlayer3);
            this.panel1.Controls.Add(this.pictureBoxPlayer3);
            this.panel1.Controls.Add(this.labelPlayer2);
            this.panel1.Controls.Add(this.labelPlayer1);
            this.panel1.Controls.Add(this.pictureBoxPlayer2);
            this.panel1.Controls.Add(this.pictureBoxPlayer1);
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 733);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDelete.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(727, 195);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(128, 46);
            this.buttonDelete.TabIndex = 100;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonBack.FlatAppearance.BorderSize = 5;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonBack.Location = new System.Drawing.Point(897, 195);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(134, 46);
            this.buttonBack.TabIndex = 99;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonShowAllGame
            // 
            this.buttonShowAllGame.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonShowAllGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonShowAllGame.FlatAppearance.BorderSize = 5;
            this.buttonShowAllGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonShowAllGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAllGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAllGame.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonShowAllGame.Location = new System.Drawing.Point(727, 125);
            this.buttonShowAllGame.Name = "buttonShowAllGame";
            this.buttonShowAllGame.Size = new System.Drawing.Size(304, 55);
            this.buttonShowAllGame.TabIndex = 98;
            this.buttonShowAllGame.Text = "Show all games";
            this.buttonShowAllGame.UseVisualStyleBackColor = false;
            this.buttonShowAllGame.Click += new System.EventHandler(this.buttonShowAllGame_Click);
            // 
            // labelPlayer3
            // 
            this.labelPlayer3.AutoSize = true;
            this.labelPlayer3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer3.ForeColor = System.Drawing.Color.Black;
            this.labelPlayer3.Location = new System.Drawing.Point(789, 627);
            this.labelPlayer3.Name = "labelPlayer3";
            this.labelPlayer3.Size = new System.Drawing.Size(93, 33);
            this.labelPlayer3.TabIndex = 97;
            this.labelPlayer3.Text = "Player 3";
            this.labelPlayer3.Visible = false;
            // 
            // pictureBoxPlayer3
            // 
            this.pictureBoxPlayer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPlayer3.Location = new System.Drawing.Point(727, 468);
            this.pictureBoxPlayer3.Name = "pictureBoxPlayer3";
            this.pictureBoxPlayer3.Size = new System.Drawing.Size(205, 156);
            this.pictureBoxPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer3.TabIndex = 96;
            this.pictureBoxPlayer3.TabStop = false;
            this.pictureBoxPlayer3.Visible = false;
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2.ForeColor = System.Drawing.Color.Red;
            this.labelPlayer2.Location = new System.Drawing.Point(1041, 423);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(93, 33);
            this.labelPlayer2.TabIndex = 95;
            this.labelPlayer2.Text = "Player 2";
            this.labelPlayer2.Visible = false;
            // 
            // pictureBoxPlayer2
            // 
            this.pictureBoxPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(985, 264);
            this.pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(205, 156);
            this.pictureBoxPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer2.TabIndex = 93;
            this.pictureBoxPlayer2.TabStop = false;
            this.pictureBoxPlayer2.Visible = false;
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(727, 262);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(205, 156);
            this.pictureBoxPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer1.TabIndex = 92;
            this.pictureBoxPlayer1.TabStop = false;
            this.pictureBoxPlayer1.Visible = false;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.player1score,
            this.player2score,
            this.player3score,
            this.Draw,
            this.boardNumber});
            this.listView2.Location = new System.Drawing.Point(40, 498);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(601, 110);
            this.listView2.TabIndex = 91;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // player1score
            // 
            this.player1score.Text = "Player1 score";
            this.player1score.Width = 97;
            // 
            // player2score
            // 
            this.player2score.Text = "Player2 score";
            this.player2score.Width = 104;
            // 
            // player3score
            // 
            this.player3score.Text = "Player3 score";
            this.player3score.Width = 95;
            // 
            // Draw
            // 
            this.Draw.Text = "Draw";
            this.Draw.Width = 94;
            // 
            // boardNumber
            // 
            this.boardNumber.Text = "Current board";
            this.boardNumber.Width = 188;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.player1,
            this.player2,
            this.player3,
            this.level});
            this.listView1.Location = new System.Drawing.Point(40, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(601, 305);
            this.listView1.TabIndex = 90;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Game";
            this.columnHeader1.Width = 92;
            // 
            // player1
            // 
            this.player1.Text = "Player 1";
            this.player1.Width = 107;
            // 
            // player2
            // 
            this.player2.Text = "Player 2";
            this.player2.Width = 111;
            // 
            // player3
            // 
            this.player3.Text = "Player 3";
            this.player3.Width = 140;
            // 
            // level
            // 
            this.level.Text = "Level AI";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.ForeColor = System.Drawing.Color.Blue;
            this.labelPlayer1.Location = new System.Drawing.Point(762, 420);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(100, 36);
            this.labelPlayer1.TabIndex = 94;
            this.labelPlayer1.Text = "Player 1";
            this.labelPlayer1.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MoolBoran", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Blue;
            this.labelTime.Location = new System.Drawing.Point(49, 611);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 65);
            this.labelTime.TabIndex = 101;
            this.labelTime.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Navy;
            this.label6.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(144, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(387, 71);
            this.label6.TabIndex = 102;
            this.label6.Text = "Load game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(50, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 60);
            this.label2.TabIndex = 103;
            this.label2.Text = "Current Result";
            this.label2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 93);
            this.panel2.TabIndex = 104;
            // 
            // FormLoadGame1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 733);
            this.Controls.Add(this.panel1);
            this.Name = "FormLoadGame1";
            this.Text = "FormLoadGame1";
            this.Load += new System.EventHandler(this.FormLoadGame1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShowAllGame;
        private System.Windows.Forms.Label labelPlayer3;
        private System.Windows.Forms.PictureBox pictureBoxPlayer3;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader player1score;
        private System.Windows.Forms.ColumnHeader player2score;
        private System.Windows.Forms.ColumnHeader player3score;
        private System.Windows.Forms.ColumnHeader Draw;
        private System.Windows.Forms.ColumnHeader boardNumber;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader player1;
        private System.Windows.Forms.ColumnHeader player2;
        private System.Windows.Forms.ColumnHeader player3;
        private System.Windows.Forms.ColumnHeader level;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}