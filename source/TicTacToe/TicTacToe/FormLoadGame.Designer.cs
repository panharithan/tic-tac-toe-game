namespace TicTacToe
{
    partial class FormLoadGame
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPlayer3 = new System.Windows.Forms.Label();
            this.pictureBoxPlayer3 = new System.Windows.Forms.PictureBox();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.buttonShowAllGame = new System.Windows.Forms.Button();
            this.player1score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player2score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player3score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Draw = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.boardNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.player1,
            this.player2,
            this.player3,
            this.level});
            this.listView1.Location = new System.Drawing.Point(12, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(558, 305);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // labelPlayer3
            // 
            this.labelPlayer3.AutoSize = true;
            this.labelPlayer3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer3.ForeColor = System.Drawing.Color.Black;
            this.labelPlayer3.Location = new System.Drawing.Point(759, 465);
            this.labelPlayer3.Name = "labelPlayer3";
            this.labelPlayer3.Size = new System.Drawing.Size(93, 33);
            this.labelPlayer3.TabIndex = 79;
            this.labelPlayer3.Text = "Player 3";
            this.labelPlayer3.Visible = false;
            // 
            // pictureBoxPlayer3
            // 
            this.pictureBoxPlayer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPlayer3.Location = new System.Drawing.Point(697, 306);
            this.pictureBoxPlayer3.Name = "pictureBoxPlayer3";
            this.pictureBoxPlayer3.Size = new System.Drawing.Size(205, 156);
            this.pictureBoxPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer3.TabIndex = 78;
            this.pictureBoxPlayer3.TabStop = false;
            this.pictureBoxPlayer3.Visible = false;
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2.ForeColor = System.Drawing.Color.Red;
            this.labelPlayer2.Location = new System.Drawing.Point(1015, 261);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(93, 33);
            this.labelPlayer2.TabIndex = 77;
            this.labelPlayer2.Text = "Player 2";
            this.labelPlayer2.Visible = false;
            this.labelPlayer2.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.ForeColor = System.Drawing.Color.Blue;
            this.labelPlayer1.Location = new System.Drawing.Point(732, 258);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(100, 36);
            this.labelPlayer1.TabIndex = 76;
            this.labelPlayer1.Text = "Player 1";
            this.labelPlayer1.Visible = false;
            // 
            // pictureBoxPlayer2
            // 
            this.pictureBoxPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(955, 102);
            this.pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(205, 156);
            this.pictureBoxPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer2.TabIndex = 75;
            this.pictureBoxPlayer2.TabStop = false;
            this.pictureBoxPlayer2.Visible = false;
            this.pictureBoxPlayer2.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(697, 100);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(205, 156);
            this.pictureBoxPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayer1.TabIndex = 74;
            this.pictureBoxPlayer1.TabStop = false;
            this.pictureBoxPlayer1.Visible = false;
            // 
            // buttonShowAllGame
            // 
            this.buttonShowAllGame.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonShowAllGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonShowAllGame.FlatAppearance.BorderSize = 5;
            this.buttonShowAllGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonShowAllGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAllGame.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAllGame.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonShowAllGame.Location = new System.Drawing.Point(697, 37);
            this.buttonShowAllGame.Name = "buttonShowAllGame";
            this.buttonShowAllGame.Size = new System.Drawing.Size(282, 50);
            this.buttonShowAllGame.TabIndex = 80;
            this.buttonShowAllGame.Text = "Show all games";
            this.buttonShowAllGame.UseVisualStyleBackColor = false;
            this.buttonShowAllGame.Click += new System.EventHandler(this.buttonHighscoreInForMainMenu_Click);
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
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.player1score,
            this.player2score,
            this.player3score,
            this.Draw,
            this.boardNumber});
            this.listView2.Location = new System.Drawing.Point(12, 374);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(558, 344);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(586, 337);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 46);
            this.buttonDelete.TabIndex = 81;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormLoadGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 733);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonShowAllGame);
            this.Controls.Add(this.labelPlayer3);
            this.Controls.Add(this.pictureBoxPlayer3);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.pictureBoxPlayer2);
            this.Controls.Add(this.pictureBoxPlayer1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "FormLoadGame";
            this.Text = "FormLoadGame";
            this.Load += new System.EventHandler(this.FormLoadGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader player1;
        private System.Windows.Forms.ColumnHeader player2;
        private System.Windows.Forms.ColumnHeader player3;
        private System.Windows.Forms.ColumnHeader level;
        private System.Windows.Forms.Label labelPlayer3;
        private System.Windows.Forms.PictureBox pictureBoxPlayer3;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.Button buttonShowAllGame;
        private System.Windows.Forms.ColumnHeader player1score;
        private System.Windows.Forms.ColumnHeader player2score;
        private System.Windows.Forms.ColumnHeader player3score;
        private System.Windows.Forms.ColumnHeader Draw;
        private System.Windows.Forms.ColumnHeader boardNumber;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button buttonDelete;
    }
}