namespace TicTacToe
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReject = new System.Windows.Forms.Button();
            this.buttonAcceptInFormSetting = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton5InArow = new System.Windows.Forms.RadioButton();
            this.radioButton3InArow = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonReject);
            this.panel1.Controls.Add(this.buttonAcceptInFormSetting);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.radioButton5InArow);
            this.panel1.Controls.Add(this.radioButton3InArow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 411);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(222, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 39);
            this.label1.TabIndex = 68;
            this.label1.Text = "Artificial Intelligence";
            // 
            // buttonReject
            // 
            this.buttonReject.BackColor = System.Drawing.Color.White;
            this.buttonReject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonReject.FlatAppearance.BorderSize = 5;
            this.buttonReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReject.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReject.Location = new System.Drawing.Point(570, 159);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(126, 54);
            this.buttonReject.TabIndex = 69;
            this.buttonReject.Text = "Reject";
            this.buttonReject.UseVisualStyleBackColor = false;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // buttonAcceptInFormSetting
            // 
            this.buttonAcceptInFormSetting.BackColor = System.Drawing.Color.White;
            this.buttonAcceptInFormSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAcceptInFormSetting.FlatAppearance.BorderSize = 5;
            this.buttonAcceptInFormSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonAcceptInFormSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcceptInFormSetting.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceptInFormSetting.Location = new System.Drawing.Point(443, 159);
            this.buttonAcceptInFormSetting.Name = "buttonAcceptInFormSetting";
            this.buttonAcceptInFormSetting.Size = new System.Drawing.Size(121, 54);
            this.buttonAcceptInFormSetting.TabIndex = 68;
            this.buttonAcceptInFormSetting.Text = "Accept";
            this.buttonAcceptInFormSetting.UseVisualStyleBackColor = false;
            this.buttonAcceptInFormSetting.Click += new System.EventHandler(this.buttonAcceptInFormSetting_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5"});
            this.comboBox1.Location = new System.Drawing.Point(229, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 42);
            this.comboBox1.TabIndex = 67;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioButton5InArow
            // 
            this.radioButton5InArow.AutoSize = true;
            this.radioButton5InArow.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5InArow.Location = new System.Drawing.Point(224, 28);
            this.radioButton5InArow.Name = "radioButton5InArow";
            this.radioButton5InArow.Size = new System.Drawing.Size(239, 42);
            this.radioButton5InArow.TabIndex = 64;
            this.radioButton5InArow.TabStop = true;
            this.radioButton5InArow.Text = "Five in a row";
            this.radioButton5InArow.UseVisualStyleBackColor = true;
            this.radioButton5InArow.CheckedChanged += new System.EventHandler(this.radioButton5InArow_CheckedChanged);
            // 
            // radioButton3InArow
            // 
            this.radioButton3InArow.AutoSize = true;
            this.radioButton3InArow.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3InArow.Location = new System.Drawing.Point(454, 44);
            this.radioButton3InArow.Name = "radioButton3InArow";
            this.radioButton3InArow.Size = new System.Drawing.Size(262, 42);
            this.radioButton3InArow.TabIndex = 63;
            this.radioButton3InArow.TabStop = true;
            this.radioButton3InArow.Text = "Three in a row";
            this.radioButton3InArow.UseVisualStyleBackColor = true;
            this.radioButton3InArow.CheckedChanged += new System.EventHandler(this.radioButton3InArow_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.labelLevel);
            this.panel2.Controls.Add(this.labelMode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 411);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.Color.Transparent;
            this.labelLevel.Location = new System.Drawing.Point(3, 105);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(193, 39);
            this.labelLevel.TabIndex = 66;
            this.labelLevel.Text = "Level for";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMode.ForeColor = System.Drawing.Color.Transparent;
            this.labelMode.Location = new System.Drawing.Point(3, 28);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(215, 39);
            this.labelMode.TabIndex = 65;
            this.labelMode.Text = "Game mode";
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3InArow;
        private System.Windows.Forms.RadioButton radioButton5InArow;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAcceptInFormSetting;
        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.Label label1;
    }
}