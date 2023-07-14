using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }
        int show = 0;
        private void buttonBack_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormMainMenu f = new FormMainMenu();
            for (int i = 0; i < f.Controls.Count; i++)
            {
                this.panel1.Controls.Add(f.Controls[i]);
            }
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            labelName.Text += "AN Panharith";
            labelRespondsibility.Text += "Leader";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonNext.Text = "Next";
            show++;
            if (show==1)
            {
                pictureBoxMember1.Image = Properties.Resources.Panharith1;

                labelName.Text += "AN Panharith";
                labelRespondsibility.Text += "Leader";
            }
            if (show==2) // Makara
            {
                //pictureBox.Image = Properties.Resources._7;
                pictureBoxMember1.Image = Properties.Resources.makara;
                labelName.Text = "Name: Moun Makara";
                labelRespondsibility.Text = "Role: Sub-leader1";

            }
            else if (show ==3) // Sam
            {
                pictureBoxMember1.Image = Properties.Resources.Sammnang;
                labelName.Text = "Name: Cheasim Sammnamg";
                labelRespondsibility.Text = "Role: Sub-leader2";

            }
            else if (show ==4) //Kuntha
            {
                return;
                pictureBoxMember1.Image = Properties.Resources.kuntha;
                labelName.Text = "Name: Pin Kuntha";
                labelRespondsibility.Text = "Role: Team member";

            }
            else if (show ==5) // Lika
            {
                return;
                pictureBoxMember1.Image = Properties.Resources.Lika;
                labelName.Text = "Name: Long Lika";
                labelRespondsibility.Text = "Role: Team member ";

            }

        }
    }
}
