namespace TicTacToe
{
    partial class FormNewGameChoosePlay
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonBackk = new System.Windows.Forms.Button();
            this.buttonTimerPlayInFormNewGameChooseMode = new System.Windows.Forms.Button();
            this.buttonChallengePlayInFormNewGameChooseMode = new System.Windows.Forms.Button();
            this.buttonQuckPlayInFormNewGameChooseMode = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonBackk);
            this.panel1.Controls.Add(this.buttonTimerPlayInFormNewGameChooseMode);
            this.panel1.Controls.Add(this.buttonChallengePlayInFormNewGameChooseMode);
            this.panel1.Controls.Add(this.buttonQuckPlayInFormNewGameChooseMode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 733);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicTacToe.Properties.Resources.virtual_rupp;
            this.pictureBox1.Location = new System.Drawing.Point(284, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(963, 663);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 118);
            this.panel2.TabIndex = 67;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.labelTitle.Location = new System.Drawing.Point(25, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(568, 112);
            this.labelTitle.TabIndex = 66;
            this.labelTitle.Text = "New game";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBackk
            // 
            this.buttonBackk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonBackk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBackk.FlatAppearance.BorderSize = 5;
            this.buttonBackk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackk.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackk.ForeColor = System.Drawing.Color.Indigo;
            this.buttonBackk.Location = new System.Drawing.Point(4, 619);
            this.buttonBackk.Name = "buttonBackk";
            this.buttonBackk.Size = new System.Drawing.Size(253, 105);
            this.buttonBackk.TabIndex = 64;
            this.buttonBackk.Text = "Back";
            this.buttonBackk.UseVisualStyleBackColor = false;
            this.buttonBackk.Click += new System.EventHandler(this.buttonBackk_Click);
            // 
            // buttonTimerPlayInFormNewGameChooseMode
            // 
            this.buttonTimerPlayInFormNewGameChooseMode.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonTimerPlayInFormNewGameChooseMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonTimerPlayInFormNewGameChooseMode.FlatAppearance.BorderSize = 5;
            this.buttonTimerPlayInFormNewGameChooseMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimerPlayInFormNewGameChooseMode.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimerPlayInFormNewGameChooseMode.ForeColor = System.Drawing.Color.Navy;
            this.buttonTimerPlayInFormNewGameChooseMode.Location = new System.Drawing.Point(4, 501);
            this.buttonTimerPlayInFormNewGameChooseMode.Name = "buttonTimerPlayInFormNewGameChooseMode";
            this.buttonTimerPlayInFormNewGameChooseMode.Size = new System.Drawing.Size(253, 112);
            this.buttonTimerPlayInFormNewGameChooseMode.TabIndex = 61;
            this.buttonTimerPlayInFormNewGameChooseMode.Text = "Timer Play";
            this.buttonTimerPlayInFormNewGameChooseMode.UseVisualStyleBackColor = false;
            this.buttonTimerPlayInFormNewGameChooseMode.Click += new System.EventHandler(this.buttonTimerPlayInFormNewGameChooseMode_Click);
            // 
            // buttonChallengePlayInFormNewGameChooseMode
            // 
            this.buttonChallengePlayInFormNewGameChooseMode.BackColor = System.Drawing.Color.Tan;
            this.buttonChallengePlayInFormNewGameChooseMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonChallengePlayInFormNewGameChooseMode.FlatAppearance.BorderSize = 5;
            this.buttonChallengePlayInFormNewGameChooseMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonChallengePlayInFormNewGameChooseMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChallengePlayInFormNewGameChooseMode.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChallengePlayInFormNewGameChooseMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonChallengePlayInFormNewGameChooseMode.Location = new System.Drawing.Point(4, 383);
            this.buttonChallengePlayInFormNewGameChooseMode.Name = "buttonChallengePlayInFormNewGameChooseMode";
            this.buttonChallengePlayInFormNewGameChooseMode.Size = new System.Drawing.Size(253, 112);
            this.buttonChallengePlayInFormNewGameChooseMode.TabIndex = 60;
            this.buttonChallengePlayInFormNewGameChooseMode.Text = "Challenge Play";
            this.buttonChallengePlayInFormNewGameChooseMode.UseVisualStyleBackColor = false;
            this.buttonChallengePlayInFormNewGameChooseMode.Click += new System.EventHandler(this.buttonChallengePlayInFormNewGameChooseMode_Click_1);
            // 
            // buttonQuckPlayInFormNewGameChooseMode
            // 
            this.buttonQuckPlayInFormNewGameChooseMode.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonQuckPlayInFormNewGameChooseMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonQuckPlayInFormNewGameChooseMode.FlatAppearance.BorderSize = 5;
            this.buttonQuckPlayInFormNewGameChooseMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonQuckPlayInFormNewGameChooseMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuckPlayInFormNewGameChooseMode.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuckPlayInFormNewGameChooseMode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonQuckPlayInFormNewGameChooseMode.Location = new System.Drawing.Point(4, 266);
            this.buttonQuckPlayInFormNewGameChooseMode.Name = "buttonQuckPlayInFormNewGameChooseMode";
            this.buttonQuckPlayInFormNewGameChooseMode.Size = new System.Drawing.Size(253, 112);
            this.buttonQuckPlayInFormNewGameChooseMode.TabIndex = 59;
            this.buttonQuckPlayInFormNewGameChooseMode.Text = "Quick Play";
            this.buttonQuckPlayInFormNewGameChooseMode.UseVisualStyleBackColor = false;
            this.buttonQuckPlayInFormNewGameChooseMode.Click += new System.EventHandler(this.buttonQuckPlayInFormNewGameChooseMode_Click);
            // 
            // FormNewGameChoosePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 733);
            this.Controls.Add(this.panel1);
            this.Name = "FormNewGameChoosePlay";
            this.Text = "Developed by AI team";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNewGameChoosePlay_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTimerPlayInFormNewGameChooseMode;
        private System.Windows.Forms.Button buttonChallengePlayInFormNewGameChooseMode;
        private System.Windows.Forms.Button buttonQuckPlayInFormNewGameChooseMode;
        private System.Windows.Forms.Button buttonBackk;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}