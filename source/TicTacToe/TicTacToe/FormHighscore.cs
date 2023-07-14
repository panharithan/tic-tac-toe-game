using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;
namespace TicTacToe
{
    public partial class FormHighscore : Form
    {
        public FormHighscore()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormMainMenu f = new FormMainMenu();
            for (int i = 0; i < f.Controls.Count; i++)
            {
                this.panel1.Controls.Add(f.Controls[i]);
            }
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            buttonClick.Enabled = false;
            ResourceSet resourceSet = new ResourceSet("SettingChoise.resx");

            string levell = resourceSet.GetString("level");

            resourceSet.Close();

            if (levell=="1")
            {
                ResourceSet rs = new ResourceSet("HighscoreL1.resx");
                labelName.Text += "  " + rs.GetString("name");
                labelVictory.Text += "  " + rs.GetString("victory");
                labelFailure.Text += "  " + rs.GetString("failure");
                labelDraw.Text += "  " + rs.GetString("draw");
                rs.Close();
                string Avatar = AppDomain.CurrentDomain.BaseDirectory + @"\Highscore\L1\avatar";
                if (File.Exists(Avatar))
                {
                    pictureBox1.ImageLocation = Avatar;
                }
            }

            else if (levell == "2")
            {
                ResourceSet rs = new ResourceSet("HighscoreL2.resx");
                labelName.Text += "  " + rs.GetString("name");
                labelVictory.Text += "  " + rs.GetString("victory");
                labelFailure.Text += "  " + rs.GetString("failure");
                labelDraw.Text += "  " + rs.GetString("draw");
                rs.Close();
                string Avatar = AppDomain.CurrentDomain.BaseDirectory + @"\Highscore\L2\avatar";
                if (File.Exists(Avatar))
                {
                    pictureBox1.ImageLocation = Avatar;
                }
            }
            else if (levell == "3")
            {
                ResourceSet rs = new ResourceSet("HighscoreL3.resx");
                labelName.Text += "  " + rs.GetString("name");
                labelVictory.Text += "  " + rs.GetString("victory");
                labelFailure.Text += "  " + rs.GetString("failure");
                labelDraw.Text += "  " + rs.GetString("draw");
                rs.Close();
                string Avatar = AppDomain.CurrentDomain.BaseDirectory + @"\Highscore\L3\avatar";
                if (File.Exists(Avatar))
                {
                    pictureBox1.ImageLocation = Avatar;
                }
            }
            else if (levell == "4")
            {
                ResourceSet rs = new ResourceSet("HighscoreL4.resx");
                labelName.Text += "  " + rs.GetString("name");
                labelVictory.Text += "  " + rs.GetString("victory");
                labelFailure.Text += "  " + rs.GetString("failure");
                labelDraw.Text += "  " + rs.GetString("draw");
                rs.Close();
                string Avatar = AppDomain.CurrentDomain.BaseDirectory + @"\Highscore\L4\avatar";
                if (File.Exists(Avatar))
                {
                    pictureBox1.ImageLocation = Avatar;
                }
            }
            else if (levell == "5")
            {
                ResourceSet rs = new ResourceSet("HighscoreL5.resx");
                string theName = rs.GetString("name");
                if (theName == "P" || theName=="")
                {
                    MessageBox.Show("No highscore record !", "Tic-Tac-Toe highscore.");
                    rs.Close();
                    return;
                }
                labelName.Text += "  " + rs.GetString("name");
                labelVictory.Text += "  " + rs.GetString("victory");
                labelFailure.Text += "  " + rs.GetString("failure");
                labelDraw.Text += "  " + rs.GetString("draw");
                
                rs.Close();
               
                string Avatar = AppDomain.CurrentDomain.BaseDirectory + @"\Highscore\L5\avatar";
                if (File.Exists(Avatar))
                {
                    pictureBox1.ImageLocation = Avatar;
                }
            }









        }
    }
}
