namespace TicTacToe
{
    partial class FormNewGame5inRow1Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewGame5inRow1Player));
            this.panel1InFormNewGame1Player = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonPlayInFormNewGame1Player = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1InFormNewGame1Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1InFormNewGame1Player
            // 
            this.panel1InFormNewGame1Player.Controls.Add(this.label1);
            this.panel1InFormNewGame1Player.Controls.Add(this.buttonClear);
            this.panel1InFormNewGame1Player.Controls.Add(this.buttonBrowse);
            this.panel1InFormNewGame1Player.Controls.Add(this.pictureBox2);
            this.panel1InFormNewGame1Player.Controls.Add(this.buttonPlayInFormNewGame1Player);
            this.panel1InFormNewGame1Player.Controls.Add(this.textBox1);
            this.panel1InFormNewGame1Player.Controls.Add(this.pictureBox1);
            this.panel1InFormNewGame1Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1InFormNewGame1Player.Location = new System.Drawing.Point(0, 0);
            this.panel1InFormNewGame1Player.Name = "panel1InFormNewGame1Player";
            this.panel1InFormNewGame1Player.Size = new System.Drawing.Size(831, 514);
            this.panel1InFormNewGame1Player.TabIndex = 0;
            this.panel1InFormNewGame1Player.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1InFormNewGame1Player_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(166, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 38);
            this.label1.TabIndex = 58;
            this.label1.Text = "Your Avatar";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(469, 280);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(92, 37);
            this.buttonClear.TabIndex = 57;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(469, 342);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(92, 37);
            this.buttonBrowse.TabIndex = 56;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::TicTacToe.Properties.Resources.dracMinion;
            this.pictureBox2.Location = new System.Drawing.Point(140, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 246);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonPlayInFormNewGame1Player
            // 
            this.buttonPlayInFormNewGame1Player.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlayInFormNewGame1Player.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonPlayInFormNewGame1Player.FlatAppearance.BorderSize = 5;
            this.buttonPlayInFormNewGame1Player.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonPlayInFormNewGame1Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayInFormNewGame1Player.Font = new System.Drawing.Font("Jokerman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayInFormNewGame1Player.ForeColor = System.Drawing.Color.Black;
            this.buttonPlayInFormNewGame1Player.Location = new System.Drawing.Point(537, 15);
            this.buttonPlayInFormNewGame1Player.Name = "buttonPlayInFormNewGame1Player";
            this.buttonPlayInFormNewGame1Player.Size = new System.Drawing.Size(98, 48);
            this.buttonPlayInFormNewGame1Player.TabIndex = 54;
            this.buttonPlayInFormNewGame1Player.Text = "Play";
            this.buttonPlayInFormNewGame1Player.UseVisualStyleBackColor = false;
            this.buttonPlayInFormNewGame1Player.Click += new System.EventHandler(this.buttonPlayInFormNewGame1Player_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(139, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 50);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Player 1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Player1";
            this.openFileDialog1.Filter = "\"Image Files | * .png; *.jpg;* .gif; *.bmp; *tif\"";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FormNewGame5inRow1Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 514);
            this.Controls.Add(this.panel1InFormNewGame1Player);
            this.Location = new System.Drawing.Point(350, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewGame5inRow1Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Complete Your Name";
            this.Load += new System.EventHandler(this.FormNewGame1Player_Load);
            this.panel1InFormNewGame1Player.ResumeLayout(false);
            this.panel1InFormNewGame1Player.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1InFormNewGame1Player;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonPlayInFormNewGame1Player;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label1;
    }
}