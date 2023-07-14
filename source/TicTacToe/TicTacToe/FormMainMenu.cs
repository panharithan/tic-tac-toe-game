using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Resources;

namespace TicTacToe
{
    public partial class FormMainMenu : Form
    {


        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void buttonNewgameInForhome_Click(object sender, EventArgs e)
        {
            string choise = "";

            ResourceSet rs = new ResourceSet("SettingChoise.resx");
            choise = rs.GetString("mode");
            if (choise == "3")
            {
                // radioButton3InArow.Select();
                FormPlayboard3InArow f = new FormPlayboard3InArow();
                f.Show();
                return;

            }
/*
            else if (choise == "5")
            {
                radioButton5InArow.Select();


            }

            string level = rs.GetString("level");
            if (level == "1" || level == "2" || level == "3" || level == "4" || level == "5" || level == "6")
            {
                comboBox1.Text = "Level " + level;

            }
            */
            rs.Close();


            /*
            ResourceWriter rw = new ResourceWriter("userChoise.resx");
            rw.AddResource("choise", "N");
            rw.Close();
      */
            panel1.Controls.Clear();
            FormNewGameChoosePlay formNewGamePlay = new FormNewGameChoosePlay();
            for (int i = 0; i < formNewGamePlay.Controls.Count; i++)
            {
                this.panel1.Controls.Add(formNewGamePlay.Controls[i]);
            }

/*

         //   try
         //   {
              //  System.IO.File.Delete(@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\userchoise\userchoise.txt");

            if (!System.IO.File.Exists(@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\userchoise\userchoise.txt"))
            {
               // MessageBox.Show("Hey girl");
          //      fileSetting = new FileStream(@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\userchoiseuserchoise.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                //  File.Delete(file);

            }
            */
   
         ///   }
           // catch
        //    {


          //  }





            //-------
        }

        private void buttonSettingInForMainMenu_Click(object sender, EventArgs e)
        {
            FormSetting form = new FormSetting();
            form.Show();
        }

        private void buttonExitInFormHome_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonHighscoreInForMainMenu_Click(object sender, EventArgs e)
        {
            // panel1.ForeColor = Color.White;
            //this.BackColor = Color.Transparent;
            panel1.Controls.Clear();
            FormHighscore FH = new FormHighscore();
            for (int i = 0; i < FH.Controls.Count; i++)
            {
                this.panel1.Controls.Add(FH.Controls[i]);
            }

        }

        private void buttonExitt_Click(object sender, EventArgs e)
        {
            /*
            if (System.IO.File.Exists
                (@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\userchoise\userchoise.txt"))
            {
                // MessageBox.Show("Hey girl");
                // fileSetting = new FileStream(@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\userchoiseuserchoise.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                //  File.Delete(file);
                System.IO.File.Delete(
                    (@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\userchoise\userchoise.txt"));
            }

            */
            ResourceWriter rw = new ResourceWriter("userChoise.resx");
            rw.AddResource("choise", "");
            rw.Close();

            Application.Exit();

        }

        private void labelDeveloped_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadgameInForMainMenu_Click(object sender, EventArgs e)
        {
            ResourceWriter rw = new ResourceWriter("userChoise.resx");
            rw.AddResource("choise", "N");
            rw.Close();

            panel1.Controls.Clear();
            FormLoadGame1 flg = new FormLoadGame1();
            for (int i = 0; i < flg.Controls.Count; i++)
            {
                this.panel1.Controls.Add(flg.Controls[i]);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAboutInFormMainMenu_Click(object sender, EventArgs e)
        {
            // panel1.ForeColor = Color.White;
            //this.BackColor = Color.Transparent;
            panel1.Controls.Clear();
            FormAbout theForm = new FormAbout();
            for (int i = 0; i < theForm.Controls.Count; i++)
            {
                this.panel1.Controls.Add(theForm.Controls[i]);
            }

        }
    }
}
