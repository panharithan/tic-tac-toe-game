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
    public partial class FormNewGameChoosePlay : Form
    {
        FileStream fileSetting;
        public FormNewGameChoosePlay()
        {
            InitializeComponent();
        }

        
        private void buttonChallengePlayInFormNewGameChooseMode_Click_1(object sender, EventArgs e)
        {

           // try
           //{

                this.panel1.Controls.Clear();
                ResourceSet rs = new ResourceSet("SettingChoise.resx");

                string mode = rs.GetString("mode");
                string levell = rs.GetString("level");

                rs.Close();

                if (mode == "3")
                {

                    FormNewGame_typePlayer3InArow formNewGamePlay = new FormNewGame_typePlayer3InArow();
                    for (int i = 0; i < formNewGamePlay.Controls.Count; i++)
                    {
                        this.panel1.Controls.Add(formNewGamePlay.Controls[i]);
                    }

                }
                else if (mode == "5")
                {

                    FormNewGame_typePlayer5InArow formNewGamePlay = new FormNewGame_typePlayer5InArow();
                    for (int i = 0; i < formNewGamePlay.Controls.Count; i++)
                    {
                        this.panel1.Controls.Add(formNewGamePlay.Controls[i]);
                    }
                }
                //--------------------------------------------------------------
                ResourceWriter rw0 = new ResourceWriter("userChoise.resx");
                //   rw.AddResource("choise", "");
                rw0.AddResource("choise", "");
                rw0.Close();
                
                ResourceWriter rw = new ResourceWriter("userChoise.resx");
             //   rw.AddResource("choise", "");
                rw.AddResource("choise", "c");
                rw.Close();

              
        //    }
      /*
            catch
            {
                MessageBox.Show("Reset the Setting in Main Menu.", "Game is not set yet");
                this.panel1.Controls.Add(buttonTimerPlayInFormNewGameChooseMode);
                this.panel1.Controls.Add(buttonQuckPlayInFormNewGameChooseMode);
                this.panel1.Controls.Add(buttonChallengePlayInFormNewGameChooseMode);
                this.panel1.Controls.Add(buttonBackk);

            }


            */




        }

        private void FormNewGameChoosePlay_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonQuckPlayInFormNewGameChooseMode_Click(object sender, EventArgs e)
        {
            ResourceWriter rw = new ResourceWriter("userChoise.resx");
            rw.AddResource("choise", "q");
            rw.Close();
      //   try
      //   {

                ResourceSet rs = new ResourceSet("SettingChoise.resx");

                string mode = rs.GetString("mode");
                string levell = rs.GetString("level");

                rs.Close();

                if (mode == "3")
                {



                }
                else if (mode == "5")
                {

                    FormPlayBoard formNewGamePlay = new FormPlayBoard();
                    //Application.Run(new FormPlayBoard()); 
                    formNewGamePlay.ShowDialog();

                }


               

    //     }
   /*      catch
           {
                MessageBox.Show("Reset the Setting in Main Menu.", "Game is not set yet");
                this.panel1.Controls.Add(buttonTimerPlayInFormNewGameChooseMode);
                this.panel1.Controls.Add(buttonQuckPlayInFormNewGameChooseMode);
                this.panel1.Controls.Add(buttonChallengePlayInFormNewGameChooseMode);
                this.panel1.Controls.Add(buttonBackk);
            
          }
*/
           




          //  this.panel1.Controls.Remove(buttonTimerPlayInFormNewGameChooseMode);
         //   this.panel1.Controls.Remove(buttonQuckPlayInFormNewGameChooseMode);
         //   this.panel1.Controls.Remove(buttonChallengePlayInFormNewGameChooseMode);
          //  this.panel1.Controls.Remove(buttonBackInFormNewGameChooseMode);
     /*       try
            {
                string[] Setting = new string[3];

                string text = System.IO.File.ReadAllText(@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\setting\GameSetting.txt");


                char s1 = text[0];
                char s2 = text[1];
                Setting[1] = s1.ToString();
                Setting[2] = s2.ToString();

                if (Setting[1] == "T")
                {

                    // panel1.Visible = false;
                    //    FormNewGame_typePlayer5InArow formNewGamePlay = new FormNewGame_typePlayer5InArow();

                    FormPlayBoard formNewGamePlay = new FormPlayBoard();
                    //Application.Run(new FormPlayBoard()); 
                    formNewGamePlay.ShowDialog();

                }
                else
                {
                    FormNewGame_typePlayer3InArow formNewGamePlay = new FormNewGame_typePlayer3InArow();
                    for (int i = 0; i < formNewGamePlay.Controls.Count; i++)
                    {
                        Setting = null;
                        this.panel1.Controls.Add(formNewGamePlay.Controls[i]);
                    }
                }

                string text1 = System.IO.File.ReadAllText(@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\userchoise\userchoise.txt");


                if (!System.IO.File.Exists(@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\userchoise\userchoise.txt"))
                {
                    // MessageBox.Show("Hey girl");
                    fileSetting = new FileStream(@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\userchoise\userchoise.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                    //  File.Delete(file);

                }


                FileStream fil = new FileStream(@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\userchoise\userchoise.txt",
                                                FileMode.OpenOrCreate, FileAccess.ReadWrite);

                /*   StreamReader r = new StreamReader(fileSetting);
                if (r.ReadLine() != "")
                {
                    fw.WriteLine(""); // clear the old text
                
                }
                */
       /*         StreamWriter fw = new StreamWriter(fil);






                fw.Write(text1 + "Q");
                //fw.Write(level.ToString());

                fw.Close();
                fw = null;
                
            }
            catch
            {
                MessageBox.Show("Reset the Setting in Main Menu.","Game is not set yet");
                this.panel1.Controls.Add(buttonTimerPlayInFormNewGameChooseMode);
                this.panel1.Controls.Add(buttonQuckPlayInFormNewGameChooseMode);
                this.panel1.Controls.Add(buttonChallengePlayInFormNewGameChooseMode);
                this.panel1.Controls.Add(buttonBackk);
            
            
            }



            */


        }

        private void buttonTimerPlayInFormNewGameChooseMode_Click(object sender, EventArgs e)
        {
            try
            {
               // this.panel1.Controls.Clear();
                ResourceSet rs = new ResourceSet("SettingChoise.resx");

                string mode = rs.GetString("mode");
                string levell = rs.GetString("level");

                rs.Close();

                if (mode == "3")
                {

                    FormNewGame_typePlayer3InArow formNewGamePlay = new FormNewGame_typePlayer3InArow();
                    for (int i = 0; i < formNewGamePlay.Controls.Count; i++)
                    {
                        this.panel1.Controls.Add(formNewGamePlay.Controls[i]);
                    }

                }
                else if (mode == "5")
                {
                    /*
                    FormNewGame_typePlayer5InArow formNewGamePlay = new FormNewGame_typePlayer5InArow();
                    for (int i = 0; i < formNewGamePlay.Controls.Count; i++)
                    {
                        this.panel1.Controls.Add(formNewGamePlay.Controls[i]);
                    }
                    */
                    FormNewGame5inRow1Player f = new FormNewGame5inRow1Player();
                    f.Show();

                }
                ResourceWriter rw = new ResourceWriter("userChoise.resx");
                rw.AddResource("choise", "t");
                rw.Close();
            }
            catch
            {
                MessageBox.Show("Reset the Setting in Main Menu.", "Game is not set yet");
                this.panel1.Controls.Add(buttonTimerPlayInFormNewGameChooseMode);
                this.panel1.Controls.Add(buttonQuckPlayInFormNewGameChooseMode);
                this.panel1.Controls.Add(buttonChallengePlayInFormNewGameChooseMode);
                this.panel1.Controls.Add(buttonBackk);

            }
            
            
         
        }

        private void buttonBackInFormNewGame_Click(object sender, EventArgs e)
        {
            







        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBackk_Click(object sender, EventArgs e)
        {
           this.panel1.Controls.Clear();
           this.pictureBox1.Visible = false;
         //   this.pictureBox2.Visible = false;
            FormMainMenu formNewGamePlay = new FormMainMenu();
            for (int i = 0; i < formNewGamePlay.Controls.Count; i++)
            {
                this.panel1.Controls.Add(formNewGamePlay.Controls[i]);
            }

            ResourceSet rs = new ResourceSet("userChoise.resx");
            string s = rs.GetString("choise");
            rs.Close();

            if (s == "") return;
           



            ResourceWriter rw = new ResourceWriter("userChoise.resx");
            rw.AddResource("choise", "");
            rw.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
