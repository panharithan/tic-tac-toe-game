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
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }

        private void labelPlayer2_Click(object sender, EventArgs e)
        {

        }

        private void labelPlayer3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            labelPlayer3.Visible = false;
            pictureBox3.Visible = false;
         
            ResourceSet rs = new ResourceSet("userChoise.resx");
            string userPlay = rs.GetString("choise");
            rs.Close();
            // MessageBox.Show(userPlay);
            if (userPlay == "c1")
            {
                Challenge1();
            }
            else if (userPlay == "c2")
            {
               // Challenge2(); // require a name

            }
            else if (userPlay == "c3")
            {
                //Challenge3();

            }
            else if (userPlay == "t1")
            {
                //Timer1();
            }
            else if (userPlay == "t2")
            {
               // Timer2();

            }

            else if (userPlay == "t1")
            {
                //Timer3();

            }










        }

        //--------------------------------------------------------------------------------------------
        private void Challenge1()
        {
            /*  ResourceWriter r = new ResourceWriter("HighscoreL1.resx");
                r.AddResource("victory", "");
                r.Close();
                return; 
               */
               // buttonPlayerMode.Visible = false;
              //  labelPlayerMode.Visible = false;

                pictureBox1.Visible = true;
                labelPlayer1.Visible = true;
                pictureBox2.Visible = true;
                labelPlayer2.Visible = true;
                string userChoise = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\temp";

                string s = userChoise + @"\save.txt";
                StreamReader StReader = new StreamReader(s);
                string player = StReader.ReadLine();
                StReader.Close();
                labelPlayer1.ForeColor = Color.White;
                labelPlayer1.BackColor = Color.Blue;
                labelPlayer1.Text = player;

                userChoise = userChoise + @"\avatar";
                // MessageBox.Show(userChoise);

                labelPlayer2.BackColor = Color.Red;
                labelPlayer2.ForeColor = Color.White;
                labelPlayer2.Text = "A.I";

              //  labelXvictory.Text = player.ToString();
               // labelOvictory.Text = "AI";


                pictureBox1.ImageLocation = userChoise;

                ResourceSet resourceSet = new ResourceSet("SettingChoise.resx");

                string levell = resourceSet.GetString("level");

                resourceSet.Close();

                // Avatar of A.I
              //  try
              //  {
                    //   MessageBox.Show(levell);
                    if (levell == "1")
                    {

                            labelTitle.Text = "Result: Challenge AI level 1";
                            pictureBox2.Image = Properties.Resources.spiderMinion;
                            // check the high score
                                   ResourceSet resultRS = new ResourceSet("ResultHighscoreRequet.resx");
                                  string nameOfResult = resultRS.GetString("name");
                                  string victoryOfResult_string = resultRS.GetString("victory");
                                 string failureOfResult_string = resultRS.GetString("failure");
                                  string drawOfResult_string = resultRS.GetString("draw");
                                resultRS.Close();
                
                            string victoryOfHighscore_string = "";
                            string highscoreL1Rs = AppDomain.CurrentDomain.BaseDirectory + @"\HighscoreL1.resx";
                            if (File.Exists(highscoreL1Rs)==false)
                            {
                                victoryOfHighscore_string = "";
                                  ResourceWriter rw1 = new ResourceWriter("HighscoreL1.resx");
                                rw1.AddResource("name", "P");
                                  rw1.Close();
                            }
                            else
                            {
                                ResourceSet highscoreRS = new ResourceSet("HighscoreL1.resx");
                                victoryOfHighscore_string = highscoreRS.GetString("victory");
                                highscoreRS.Close();
                            }
                                  int victoryOfHighscore = -1;

                                   if (victoryOfHighscore_string=="x")
                                    {
                                        victoryOfHighscore = 0;
                                    }
                                    else if (victoryOfResult_string=="")
                                    {
                                       victoryOfHighscore = 0;
                                    }
                                    else
                                    {
                                   victoryOfHighscore = StringToInt(victoryOfHighscore_string);
                                    }
                                    int victoryOfResult = StringToInt(victoryOfResult_string);

   
                                    if (victoryOfResult > victoryOfHighscore) // set the new high score of the result
                                    {
                                        MessageBox.Show("You made the new record of this level higscore", "Congratulation!");
                                        ResourceWriter rw = new ResourceWriter("HighscoreL1.resx");
                                        rw.AddResource("name", nameOfResult);
                                        rw.AddResource("victory",victoryOfResult_string);
                                        rw.AddResource("failure", failureOfResult_string);
                                        rw.AddResource("draw", drawOfResult_string);
                                        rw.Close();

                                        string HighscoreDir = AppDomain.CurrentDomain.BaseDirectory + @"Highscore";
                                        string HighscoreLevel1_avatarDir = AppDomain.CurrentDomain.BaseDirectory + @"Highscore\L1";
                                        if (!Directory.Exists(HighscoreDir))
                                        {
                                            Directory.CreateDirectory(HighscoreDir);
                                        }
                                        if (!Directory.Exists(HighscoreLevel1_avatarDir))
                                        {
                                            Directory.CreateDirectory(HighscoreLevel1_avatarDir);
                                        }
                    if (File.Exists(HighscoreLevel1_avatarDir + @"\avatar"))
                    {
                        File.Delete(HighscoreLevel1_avatarDir + @"\avatar");
                    }

                    File.Copy(userChoise, HighscoreLevel1_avatarDir + @"\avatar");
                    }

            }

                else if (levell == "2")
                {
                    pictureBox2.Image = Properties.Resources.wolveMinion;
                //----------------------------------------------------
                labelTitle.Text = "Result: Challenge AI level 2";
                pictureBox2.Image = Properties.Resources.spiderMinion;
                // check the high score
                ResourceSet resultRS = new ResourceSet("ResultHighscoreRequet.resx");
                string nameOfResult = resultRS.GetString("name");
                string victoryOfResult_string = resultRS.GetString("victory");
                string failureOfResult_string = resultRS.GetString("failure");
                string drawOfResult_string = resultRS.GetString("draw");
                resultRS.Close();

                string victoryOfHighscore_string = "";
                string highscoreL1Rs = AppDomain.CurrentDomain.BaseDirectory + @"\HighscoreL2.resx";
                if (File.Exists(highscoreL1Rs) == false)
                {
                    victoryOfHighscore_string = "";
                    ResourceWriter rw1 = new ResourceWriter("HighscoreL2.resx");
                    rw1.AddResource("name", "P");
                    rw1.Close();
                }
                else
                {
                    ResourceSet highscoreRS = new ResourceSet("HighscoreL2.resx");
                    victoryOfHighscore_string = highscoreRS.GetString("victory");
                    highscoreRS.Close();
                }
                int victoryOfHighscore = -1;

                if (victoryOfHighscore_string == "x")
                {
                    victoryOfHighscore = 0;
                }
                else if (victoryOfResult_string == "")
                {
                    victoryOfHighscore = 0;
                }
                else
                {
                    victoryOfHighscore = StringToInt(victoryOfHighscore_string);
                }
                int victoryOfResult = StringToInt(victoryOfResult_string);


                if (victoryOfResult > victoryOfHighscore) // set the new high score of the result
                {
                    MessageBox.Show("You made the new record of this level higscore", "Congratulation!");
                    ResourceWriter rw = new ResourceWriter("HighscoreL2.resx");
                    rw.AddResource("name", nameOfResult);
                    rw.AddResource("victory", victoryOfResult_string);
                    rw.AddResource("failure", failureOfResult_string);
                    rw.AddResource("draw", drawOfResult_string);
                    rw.Close();

                    string HighscoreDir = AppDomain.CurrentDomain.BaseDirectory + @"Highscore";
                    string HighscoreLevel1_avatarDir = AppDomain.CurrentDomain.BaseDirectory + @"Highscore\L2";
                    if (!Directory.Exists(HighscoreDir))
                    {
                        Directory.CreateDirectory(HighscoreDir);
                    }
                    if (!Directory.Exists(HighscoreLevel1_avatarDir))
                    {
                        Directory.CreateDirectory(HighscoreLevel1_avatarDir);
                    }
                    if (File.Exists(HighscoreLevel1_avatarDir + @"\avatar"))
                    {
                        File.Delete(HighscoreLevel1_avatarDir + @"\avatar");
                    }

                    File.Copy(userChoise, HighscoreLevel1_avatarDir + @"\avatar");
                }

            }
            else if (levell == "3")
                {
                    pictureBox2.Image = Properties.Resources.dracMinion;
                labelTitle.Text = "Result: Challenge AI level 3";
                pictureBox2.Image = Properties.Resources.spiderMinion;
                // check the high score
                ResourceSet resultRS = new ResourceSet("ResultHighscoreRequet.resx");
                string nameOfResult = resultRS.GetString("name");
                string victoryOfResult_string = resultRS.GetString("victory");
                string failureOfResult_string = resultRS.GetString("failure");
                string drawOfResult_string = resultRS.GetString("draw");
                resultRS.Close();

                string victoryOfHighscore_string = "";
                string highscoreL1Rs = AppDomain.CurrentDomain.BaseDirectory + @"\HighscoreL3.resx";
                if (File.Exists(highscoreL1Rs) == false)
                {
                    victoryOfHighscore_string = "";
                    ResourceWriter rw1 = new ResourceWriter("HighscoreL3.resx");
                    rw1.AddResource("name", "P");
                    rw1.Close();
                }
                else
                {
                    ResourceSet highscoreRS = new ResourceSet("HighscoreL3.resx");
                    victoryOfHighscore_string = highscoreRS.GetString("victory");
                    highscoreRS.Close();
                }
                int victoryOfHighscore = -1;

                if (victoryOfHighscore_string == "x")
                {
                    victoryOfHighscore = 0;
                }
                else if (victoryOfResult_string == "")
                {
                    victoryOfHighscore = 0;
                }
                else
                {
                    victoryOfHighscore = StringToInt(victoryOfHighscore_string);
                }
                int victoryOfResult = StringToInt(victoryOfResult_string);


                if (victoryOfResult > victoryOfHighscore) // set the new high score of the result
                {
                    MessageBox.Show("You made the new record of this level higscore", "Congratulation!");
                    ResourceWriter rw = new ResourceWriter("HighscoreL3.resx");
                    rw.AddResource("name", nameOfResult);
                    rw.AddResource("victory", victoryOfResult_string);
                    rw.AddResource("failure", failureOfResult_string);
                    rw.AddResource("draw", drawOfResult_string);
                    rw.Close();

                    string HighscoreDir = AppDomain.CurrentDomain.BaseDirectory + @"Highscore";
                    string HighscoreLevel1_avatarDir = AppDomain.CurrentDomain.BaseDirectory + @"Highscore\L3";
                    if (!Directory.Exists(HighscoreDir))
                    {
                        Directory.CreateDirectory(HighscoreDir);
                    }
                    if (!Directory.Exists(HighscoreLevel1_avatarDir))
                    {
                        Directory.CreateDirectory(HighscoreLevel1_avatarDir);
                    }
                    if (File.Exists(HighscoreLevel1_avatarDir + @"\avatar"))
                    {
                        File.Delete(HighscoreLevel1_avatarDir + @"\avatar");
                    }

                    File.Copy(userChoise, HighscoreLevel1_avatarDir + @"\avatar");
                }

            }
            else if (levell == "4")
                {
                    pictureBox2.Image = Properties.Resources.minionCreed;
                //-----------------------------------------
                labelTitle.Text = "Result: Challenge AI level 4";
                pictureBox2.Image = Properties.Resources.spiderMinion;
                // check the high score
                ResourceSet resultRS = new ResourceSet("ResultHighscoreRequet.resx");
                string nameOfResult = resultRS.GetString("name");
                string victoryOfResult_string = resultRS.GetString("victory");
                string failureOfResult_string = resultRS.GetString("failure");
                string drawOfResult_string = resultRS.GetString("draw");
                resultRS.Close();

                string victoryOfHighscore_string = "";
                string highscoreL1Rs = AppDomain.CurrentDomain.BaseDirectory + @"\HighscoreL4.resx";
                if (File.Exists(highscoreL1Rs) == false)
                {
                    victoryOfHighscore_string = "";
                    ResourceWriter rw1 = new ResourceWriter("HighscoreL4.resx");
                    rw1.AddResource("name", "P");
                    rw1.Close();
                }
                else
                {
                    ResourceSet highscoreRS = new ResourceSet("HighscoreL4.resx");
                    victoryOfHighscore_string = highscoreRS.GetString("victory");
                    highscoreRS.Close();
                }
                int victoryOfHighscore = -1;

                if (victoryOfHighscore_string == "x")
                {
                    victoryOfHighscore = 0;
                }
                else if (victoryOfResult_string == "")
                {
                    victoryOfHighscore = 0;
                }
                else
                {
                    victoryOfHighscore = StringToInt(victoryOfHighscore_string);
                }
                int victoryOfResult = StringToInt(victoryOfResult_string);


                if (victoryOfResult > victoryOfHighscore) // set the new high score of the result
                {
                    MessageBox.Show("You made the new record of this level higscore", "Congratulation!");
                    ResourceWriter rw = new ResourceWriter("HighscoreL4.resx");
                    rw.AddResource("name", nameOfResult);
                    rw.AddResource("victory", victoryOfResult_string);
                    rw.AddResource("failure", failureOfResult_string);
                    rw.AddResource("draw", drawOfResult_string);
                    rw.Close();

                    string HighscoreDir = AppDomain.CurrentDomain.BaseDirectory + @"Highscore";
                    string HighscoreLevel1_avatarDir = AppDomain.CurrentDomain.BaseDirectory + @"Highscore\L4";
                    if (!Directory.Exists(HighscoreDir))
                    {
                        Directory.CreateDirectory(HighscoreDir);
                    }
                    if (!Directory.Exists(HighscoreLevel1_avatarDir))
                    {
                        Directory.CreateDirectory(HighscoreLevel1_avatarDir);
                    }
                    if (File.Exists(HighscoreLevel1_avatarDir + @"\avatar"))
                    {
                        File.Delete(HighscoreLevel1_avatarDir + @"\avatar");
                    }

                    File.Copy(userChoise, HighscoreLevel1_avatarDir + @"\avatar");
                }

            }
            else if (levell == "5")
                {
                    pictureBox2.Image = Properties.Resources.ironMinion;
                //-----------------------------
                labelTitle.Text = "Result: Challenge AI level 5";
                pictureBox2.Image = Properties.Resources.spiderMinion;
                // check the high score
                ResourceSet resultRS = new ResourceSet("ResultHighscoreRequet.resx");
                string nameOfResult = resultRS.GetString("name");
                string victoryOfResult_string = resultRS.GetString("victory");
                string failureOfResult_string = resultRS.GetString("failure");
                string drawOfResult_string = resultRS.GetString("draw");
                resultRS.Close();

                string victoryOfHighscore_string = "";
                string highscoreL1Rs = AppDomain.CurrentDomain.BaseDirectory + @"\HighscoreL5.resx";
                if (File.Exists(highscoreL1Rs) == false)
                {
                    victoryOfHighscore_string = "";
                    ResourceWriter rw1 = new ResourceWriter("HighscoreL5.resx");
                    rw1.AddResource("name", "P");
                    rw1.Close();
                }
                else
                {
                    ResourceSet highscoreRS = new ResourceSet("HighscoreL5.resx");
                    victoryOfHighscore_string = highscoreRS.GetString("victory");
                    highscoreRS.Close();
                }
                int victoryOfHighscore = -1;

                if (victoryOfHighscore_string == "x")
                {
                    victoryOfHighscore = 0;
                }
                else if (victoryOfResult_string == "")
                {
                    victoryOfHighscore = 0;
                }
                else
                {
                    victoryOfHighscore = StringToInt(victoryOfHighscore_string);
                }
                int victoryOfResult = StringToInt(victoryOfResult_string);


                if (victoryOfResult > victoryOfHighscore) // set the new high score of the result
                {
                    MessageBox.Show("You made the new record of this level higscore", "Congratulation!");
                    ResourceWriter rw = new ResourceWriter("HighscoreL5.resx");
                    rw.AddResource("name", nameOfResult);
                    rw.AddResource("victory", victoryOfResult_string);
                    rw.AddResource("failure", failureOfResult_string);
                    rw.AddResource("draw", drawOfResult_string);
                    rw.Close();

                    string HighscoreDir = AppDomain.CurrentDomain.BaseDirectory + @"Highscore";
                    string HighscoreLevel1_avatarDir = AppDomain.CurrentDomain.BaseDirectory + @"Highscore\L5";
                    if (!Directory.Exists(HighscoreDir))
                    {
                        Directory.CreateDirectory(HighscoreDir);
                    }
                    if (!Directory.Exists(HighscoreLevel1_avatarDir))
                    {
                        Directory.CreateDirectory(HighscoreLevel1_avatarDir);
                    }

                    if (File.Exists( HighscoreLevel1_avatarDir + @"\avatar"))
                    {
                        File.Delete(HighscoreLevel1_avatarDir + @"\avatar");
                    }

                    File.Copy(userChoise, HighscoreLevel1_avatarDir + @"\avatar");
                }

            }
            else
                {
                    pictureBox2.Image = Properties.Resources.capMinion;

                }




         //   }
          //  catch
          //  {

          //  }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private int StringToInt(string num)
        {
            //MessageBox.Show(num.Count().ToString());
            try
            {
                if (num == "")
                {
                    return -1;
                }
                if (num == "x")
                {
                    return -1;
                }
                int theValue = 0;
                int theSize = num.Length;//num.Count();
                char temp = num[0];
                int time = 0;
                for (int i = 0; i < num.Count(); ++i)
                {
                    time = num.Count() - i - 1;
                    temp = num[i];
                    if (temp == '0')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 0 * thePow;
                    }
                    else if (temp == '1')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 1 * thePow;
                    }
                    else if (temp == '2')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 2 * thePow;
                    }
                    else if (temp == '3')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 3 * thePow;
                    }
                    else if (temp == '4')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 4 * thePow;
                    }
                    else if (temp == '5')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 5 * thePow;
                    }
                    else if (temp == '6')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 6 * thePow;
                    }
                    else if (temp == '7')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 7 * thePow;
                    }
                    else if (temp == '8')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 8 * thePow;
                    }
                    else if (temp == '9')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 9 * thePow;
                    }
                    else
                    {
                        return 0;
                    }
                }



                return theValue;
            }
            catch
            {
                return -1;
            }


        }














    }
}
