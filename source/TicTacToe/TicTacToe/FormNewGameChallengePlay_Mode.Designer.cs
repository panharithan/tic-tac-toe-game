namespace TicTacToe
{
    partial class FormNewGameChallengePlay_Mode
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
            this.panel1InFormNewGame = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1InFormHome = new System.Windows.Forms.Panel();
            this.button5InArowInFormNewGameMode = new System.Windows.Forms.Button();
            this.panel1InFormNewGame.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel1InFormHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1InFormNewGame
            // 
            this.panel1InFormNewGame.Controls.Add(this.panel1);
            this.panel1InFormNewGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1InFormNewGame.Location = new System.Drawing.Point(0, 0);
            this.panel1InFormNewGame.Name = "panel1InFormNewGame";
            this.panel1InFormNewGame.Size = new System.Drawing.Size(1055, 733);
            this.panel1InFormNewGame.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel1InFormHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 733);
            this.panel1.TabIndex = 1;
            // 
            // panel1InFormHome
            // 
            this.panel1InFormHome.Controls.Add(this.button5InArowInFormNewGameMode);
            this.panel1InFormHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1InFormHome.Location = new System.Drawing.Point(0, 0);
            this.panel1InFormHome.Name = "panel1InFormHome";
            this.panel1InFormHome.Size = new System.Drawing.Size(1055, 733);
            this.panel1InFormHome.TabIndex = 2;
            // 
            // button5InArowInFormNewGameMode
            // 
            this.button5InArowInFormNewGameMode.BackColor = System.Drawing.Color.White;
            this.button5InArowInFormNewGameMode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5InArowInFormNewGameMode.FlatAppearance.BorderSize = 5;
            this.button5InArowInFormNewGameMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button5InArowInFormNewGameMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5InArowInFormNewGameMode.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5InArowInFormNewGameMode.Location = new System.Drawing.Point(3, 12);
            this.button5InArowInFormNewGameMode.Name = "button5InArowInFormNewGameMode";
            this.button5InArowInFormNewGameMode.Size = new System.Drawing.Size(244, 85);
            this.button5InArowInFormNewGameMode.TabIndex = 49;
            this.button5InArowInFormNewGameMode.Text = "5 In a row";
            this.button5InArowInFormNewGameMode.UseVisualStyleBackColor = false;
            this.button5InArowInFormNewGameMode.Click += new System.EventHandler(this.button5InArowInFormNewGameMode_Click);
            // 
            // FormNewGameChallengePlay_Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 733);
            this.Controls.Add(this.panel1InFormNewGame);
            this.Name = "FormNewGameChallengePlay_Mode";
            this.Text = "FormNewGameChooseMode";
            this.Load += new System.EventHandler(this.FormNewGameChooseMode_Load);
            this.panel1InFormNewGame.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1InFormHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1InFormNewGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel1InFormHome;
        private System.Windows.Forms.Button button5InArowInFormNewGameMode;

    }
}