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
    public partial class FormLoadGame1 : Form
    {
        public FormLoadGame1()
        {
            InitializeComponent();
        }
        private int StringToInt(string num)
        {
            if (num == "")
            {
                return -1;
            }
            int theValue = 0;
            int theSize = num.Count();
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
            }



            return theValue;



        }

        private int FindDrawBy2Parameter(string xWin, string oWin)
        {
            int draw = 0;
            int xVic = StringToInt(xWin);
            int oVic = StringToInt(oWin);
            draw = 10 - xVic - oVic;
            return draw;
        }
        private int FindDrawBy3Parameter(string xWin, string oWin, string plusWin)
        {
            int draw = 0;
            int xVic = StringToInt(xWin);
            int oVic = StringToInt(oWin);
            int pVic = StringToInt(plusWin);
            draw = 10 - xVic - oVic - pVic;
            return draw;
        }
        private void showAllLoadGames()
        {

            pictureBoxPlayer1.Visible = true;
            pictureBoxPlayer2.Visible = true;
            pictureBoxPlayer3.Visible = true;
            labelPlayer1.Visible = true;
            labelPlayer2.Visible = true;
            labelPlayer3.Visible = true;

            buttonShowAllGame.Enabled = false;

            try
            {


                string loadGameDir = AppDomain.CurrentDomain.BaseDirectory + @"loadGame";
                if (!Directory.Exists(loadGameDir))
                {

                }
                else
                {
                    int numDir = Directory.GetDirectories(loadGameDir).Length;
                    string loadGame = @"\loadGame";
                    // MessageBox.Show(numDir.ToString());
                    for (int i = 1; i <= numDir; ++i)
                    {

                        string gamePath = loadGameDir + loadGame + i.ToString();
                        string infoSaveFile = gamePath + @"\info.txt";

                        string f = infoSaveFile;

                        // 1
                        // Declare new List.
                        List<string> lines = new List<string>();
                        // 2
                        // Use using StreamReader for disposing.

                        using (StreamReader r = new StreamReader(f))
                        {
                            // 3
                            // Use while != null pattern for loop
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                // 4
                                // Insert logic here.
                                // ...
                                // "line" is a line in the file. Add it to our List.
                                lines.Add(line);
                            }
                        }

                        if (lines[0] == "c1")
                        {
                            try
                            {
                                /*          pictureBoxPlayer1.Visible = false;
                                          pictureBoxPlayer2.Visible = false;
                                          pictureBoxPlayer3.Visible = false;
                                          labelPlayer1.Visible = false;
                                          labelPlayer2.Visible = false;
                                          labelPlayer3.Visible = false;
                              */

                                int lineNum = lines.Count();
                                if (lineNum != 6)
                                {
                                    MessageBox.Show("erro file! ");
                                    return;
                                }

                                // find draw number
                                int totalBoard = 10;
                                int xWins = 0; int oWins = 0; int drawNum = 0;
                                if (lines[3] == "0")
                                {
                                    xWins = 0;
                                }
                                else if (lines[3] == "1")
                                {
                                    xWins = 1;
                                }
                                else if (lines[3] == "2")
                                {
                                    xWins = 2;
                                }
                                else if (lines[3] == "3")
                                {
                                    xWins = 3;
                                }
                                else if (lines[3] == "4")
                                {
                                    xWins = 4;
                                }
                                else if (lines[3] == "5")
                                {
                                    xWins = 5;
                                }
                                else if (lines[3] == "6")
                                {
                                    xWins = 6;
                                }
                                else if (lines[3] == "7")
                                {
                                    xWins = 7;
                                }
                                else if (lines[3] == "8")
                                {
                                    xWins = 8;
                                }
                                else if (lines[3] == "9")
                                {
                                    xWins = 9;
                                }
                                else if (lines[3] == "10")
                                {
                                    xWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file!");
                                    return;
                                }

                                if (lines[4] == "0")
                                {
                                    oWins = 0;
                                }
                                else if (lines[4] == "1")
                                {
                                    oWins = 1;
                                }
                                else if (lines[4] == "2")
                                {
                                    oWins = 2;
                                }
                                else if (lines[4] == "3")
                                {
                                    oWins = 3;
                                }
                                else if (lines[4] == "4")
                                {
                                    oWins = 4;
                                }
                                else if (lines[4] == "5")
                                {
                                    oWins = 5;
                                }
                                else if (lines[4] == "6")
                                {
                                    oWins = 6;
                                }
                                else if (lines[4] == "7")
                                {
                                    oWins = 7;
                                }
                                else if (lines[4] == "8")
                                {
                                    oWins = 8;
                                }
                                else if (lines[4] == "9")
                                {
                                    oWins = 9;
                                }
                                else if (lines[4] == "10")
                                {
                                    oWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file");
                                    return;
                                }

                                drawNum = totalBoard - xWins - oWins;
                                if (drawNum < 0)
                                {
                                    MessageBox.Show("Error file!!!");
                                    return;
                                }

                                ListViewItem lv1 = new ListViewItem("Challange 1p");
                                lv1.SubItems.Add(lines[1]);
                                lv1.SubItems.Add("AI");
                                lv1.SubItems.Add("No");
                                lv1.SubItems.Add(lines[2]);

                                listView1.Items.Add(lv1);

                                /*                       ListViewItem lv2 = new ListViewItem(lines[3]);
                                                       lv2.SubItems.Add(lines[4].ToString());
                                                       lv2.SubItems.Add("No");
                                                       lv2.SubItems.Add(drawNum.ToString());
                                                       lv2.SubItems.Add(lines[5].ToString());


                                                       // lv2.SubItems.Add(lines[5]);
                                                       listView2.Items.Add(lv2);
                       */

                                // work with the pictures
                                pictureBoxPlayer1.Visible = true;
                                pictureBoxPlayer2.Visible = true;
                                labelPlayer1.Visible = true;
                                labelPlayer2.Visible = true;

                                labelPlayer1.Text = (lines[1]);
                                labelPlayer2.Text = "AI";

                                string picP1Path = gamePath + @"\avatar";
                                string picAIpath = gamePath + @"\AI";
                                if (File.Exists(picP1Path))
                                {
                                    pictureBoxPlayer1.ImageLocation = picP1Path;
                                }
                                if (File.Exists(picAIpath))
                                {
                                    pictureBoxPlayer2.ImageLocation = picAIpath;
                                }


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Delete this game,it's erro");
                            }



                        }
                        else if (lines[0] == "c2")
                        {
                            try
                            {
                                /*  pictureBoxPlayer1.Visible = false;
                                  pictureBoxPlayer2.Visible = false;
                                  pictureBoxPlayer3.Visible = false;
                                  labelPlayer1.Visible = false;
                                  labelPlayer2.Visible = false;
                                  labelPlayer3.Visible = false;
                                  */
                                int lineNum = lines.Count();
                                if (lineNum != 6)
                                {
                                    MessageBox.Show("erro file !!");
                                    return;
                                }

                                // find draw number
                                int totalBoard = 10;
                                int xWins = 0; int oWins = 0; int drawNum = 0;
                                if (lines[3] == "0")
                                {
                                    xWins = 0;
                                }
                                else if (lines[3] == "1")
                                {
                                    xWins = 1;
                                }
                                else if (lines[3] == "2")
                                {
                                    xWins = 2;
                                }
                                else if (lines[3] == "3")
                                {
                                    xWins = 3;
                                }
                                else if (lines[3] == "4")
                                {
                                    xWins = 4;
                                }
                                else if (lines[3] == "5")
                                {
                                    xWins = 5;
                                }
                                else if (lines[3] == "6")
                                {
                                    xWins = 6;
                                }
                                else if (lines[3] == "7")
                                {
                                    xWins = 7;
                                }
                                else if (lines[3] == "8")
                                {
                                    xWins = 8;
                                }
                                else if (lines[3] == "9")
                                {
                                    xWins = 9;
                                }
                                else if (lines[3] == "10")
                                {
                                    xWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file");
                                    return;
                                }

                                if (lines[4] == "0")
                                {
                                    oWins = 0;
                                }
                                else if (lines[4] == "1")
                                {
                                    oWins = 1;
                                }
                                else if (lines[4] == "2")
                                {
                                    oWins = 2;
                                }
                                else if (lines[4] == "3")
                                {
                                    oWins = 3;
                                }
                                else if (lines[4] == "4")
                                {
                                    oWins = 4;
                                }
                                else if (lines[4] == "5")
                                {
                                    oWins = 5;
                                }
                                else if (lines[4] == "6")
                                {
                                    oWins = 6;
                                }
                                else if (lines[4] == "7")
                                {
                                    oWins = 7;
                                }
                                else if (lines[4] == "8")
                                {
                                    oWins = 8;
                                }
                                else if (lines[4] == "9")
                                {
                                    oWins = 9;
                                }
                                else if (lines[4] == "10")
                                {
                                    oWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file");
                                    return;
                                }

                                drawNum = totalBoard - xWins - oWins;
                                if (drawNum < 0)
                                {
                                    MessageBox.Show("Error file!!");
                                    return;
                                }



                                ListViewItem lv1 = new ListViewItem("Challange 2p");
                                lv1.SubItems.Add(lines[1]);
                                lv1.SubItems.Add(lines[2]);
                                lv1.SubItems.Add("No");
                                lv1.SubItems.Add("No");

                                listView1.Items.Add(lv1);

                                /*                           ListViewItem lv2 = new ListViewItem(lines[3]);
                                                           lv2.SubItems.Add(lines[4].ToString());
                                                           lv2.SubItems.Add("No");
                                                           lv2.SubItems.Add(drawNum.ToString());
                                                           lv2.SubItems.Add(lines[5].ToString());


                                                           // lv2.SubItems.Add(lines[5]);
                                                           listView2.Items.Add(lv2);

                           */
                                // work with the pictures
                                pictureBoxPlayer1.Visible = true;
                                pictureBoxPlayer2.Visible = true;
                                labelPlayer1.Visible = true;
                                labelPlayer2.Visible = true;

                                labelPlayer1.Text = (lines[1]);
                                labelPlayer2.Text = lines[2];

                                string picP1Path = gamePath + @"\avatar1";
                                string picP2Path = gamePath + @"\avatar2";
                                if (File.Exists(picP1Path))
                                {
                                    pictureBoxPlayer1.ImageLocation = picP1Path;
                                }
                                if (File.Exists(picP2Path))
                                {
                                    pictureBoxPlayer2.ImageLocation = picP2Path;
                                }


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Delete this game,it's erro");
                            }

                        }
                        else if (lines[0] == "c3")
                        {
                            try
                            {
                                /*   pictureBoxPlayer1.Visible = false;
                                   pictureBoxPlayer2.Visible = false;
                                   pictureBoxPlayer3.Visible = false;
                                   labelPlayer1.Visible = false;
                                   labelPlayer2.Visible = false;
                                   labelPlayer3.Visible = false;
                                   */
                                int lineNum = lines.Count();
                                if (lineNum != 8)
                                {
                                    MessageBox.Show("erro file !!!");
                                    return;
                                }

                                // find draw number
                                int totalBoard = 10;
                                int xWins = 0; int oWins = 0; int drawNum = 0;
                                int plusWins = 0;

                                if (lines[4] == "0")
                                {
                                    xWins = 0;
                                }
                                else if (lines[4] == "1")
                                {
                                    xWins = 1;
                                }
                                else if (lines[4] == "2")
                                {
                                    xWins = 2;
                                }
                                else if (lines[4] == "3")
                                {
                                    xWins = 3;
                                }
                                else if (lines[4] == "4")
                                {
                                    xWins = 4;
                                }
                                else if (lines[4] == "5")
                                {
                                    xWins = 5;
                                }
                                else if (lines[4] == "6")
                                {
                                    xWins = 6;
                                }
                                else if (lines[4] == "7")
                                {
                                    xWins = 7;
                                }
                                else if (lines[4] == "8")
                                {
                                    xWins = 8;
                                }
                                else if (lines[4] == "9")
                                {
                                    xWins = 9;
                                }
                                else if (lines[4] == "10")
                                {
                                    xWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file !!!");
                                    return;
                                }

                                if (lines[5] == "0")
                                {
                                    oWins = 0;
                                }
                                else if (lines[5] == "1")
                                {
                                    oWins = 1;
                                }
                                else if (lines[4] == "2")
                                {
                                    oWins = 2;
                                }
                                else if (lines[5] == "3")
                                {
                                    oWins = 3;
                                }
                                else if (lines[5] == "4")
                                {
                                    oWins = 4;
                                }
                                else if (lines[5] == "5")
                                {
                                    oWins = 5;
                                }
                                else if (lines[5] == "6")
                                {
                                    oWins = 6;
                                }
                                else if (lines[5] == "7")
                                {
                                    oWins = 7;
                                }
                                else if (lines[5] == "8")
                                {
                                    oWins = 8;
                                }
                                else if (lines[5] == "9")
                                {
                                    oWins = 9;
                                }
                                else if (lines[5] == "10")
                                {
                                    oWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file !!!");
                                    return;
                                }

                                if (lines[6] == "0")
                                {
                                    plusWins = 0;
                                }

                                else if (lines[6] == "1")
                                {
                                    plusWins = 1;
                                }
                                else if (lines[6] == "2")
                                {
                                    plusWins = 2;
                                }
                                else if (lines[6] == "3")
                                {
                                    plusWins = 3;
                                }
                                else if (lines[6] == "4")
                                {
                                    plusWins = 4;
                                }
                                else if (lines[6] == "5")
                                {
                                    plusWins = 5;
                                }
                                else if (lines[6] == "6")
                                {
                                    plusWins = 6;
                                }
                                else if (lines[6] == "7")
                                {
                                    plusWins = 7;
                                }
                                else if (lines[6] == "8")
                                {
                                    plusWins = 8;
                                }
                                else if (lines[6] == "9")
                                {
                                    plusWins = 9;
                                }
                                else if (lines[6] == "10")
                                {
                                    plusWins = 10;
                                }


                                drawNum = totalBoard - xWins - oWins - plusWins;
                                if (drawNum < 0)
                                {
                                    MessageBox.Show("Error file");
                                    return;
                                }



                                ListViewItem lv1 = new ListViewItem("Challange 3p");
                                lv1.SubItems.Add(lines[1]);
                                lv1.SubItems.Add(lines[2]);
                                lv1.SubItems.Add(lines[3]);
                                lv1.SubItems.Add("No");

                                listView1.Items.Add(lv1);

                                /*                              ListViewItem lv2 = new ListViewItem(lines[4]);
                                                              lv2.SubItems.Add(lines[5].ToString());
                                                              lv2.SubItems.Add(lines[6]);
                                                              lv2.SubItems.Add(drawNum.ToString());
                                                              lv2.SubItems.Add(lines[7].ToString());


                                                              // lv2.SubItems.Add(lines[5]);
                                                              listView2.Items.Add(lv2);
                              */

                                // work with the pictures
                                pictureBoxPlayer1.Visible = true;
                                pictureBoxPlayer2.Visible = true;
                                pictureBoxPlayer3.Visible = true;
                                labelPlayer1.Visible = true;
                                labelPlayer2.Visible = true;
                                labelPlayer3.Visible = true;

                                labelPlayer1.Text = (lines[1]);
                                labelPlayer2.Text = lines[2];
                                labelPlayer3.Text = lines[3];

                                string picP1Path = gamePath + @"\avatar1";
                                string picP2Path = gamePath + @"\avatar2";
                                string picP3Path = gamePath + @"\avatar3";
                                if (File.Exists(picP1Path))
                                {
                                    pictureBoxPlayer1.ImageLocation = picP1Path;
                                }
                                if (File.Exists(picP2Path))
                                {
                                    pictureBoxPlayer2.ImageLocation = picP2Path;
                                }
                                if (File.Exists(picP3Path))
                                {
                                    pictureBoxPlayer3.ImageLocation = picP3Path;
                                }


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Delete this game,it's erro");
                            }

                        }
                        else if (lines[0] == "t1")
                        {

                        }

                        else if (lines[0] == "t2")
                        {

                        }
                        else if (lines[0] == "t3")
                        {

                        }

                        // break;

                    }



                }
                pictureBoxPlayer1.ImageLocation = null;
                pictureBoxPlayer2.ImageLocation = null;
                pictureBoxPlayer3.ImageLocation = null;
                labelPlayer1.Text = "";
                labelPlayer2.Text = "";
                labelPlayer3.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Infinity");
            }


        }
        private void buttonShowAllGame_Click(object sender, EventArgs e)
        {
            // delete tempDir
            string tempDir = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\temp";
            if (Directory.Exists(tempDir))
            {
                DirectoryInfo di1 = new DirectoryInfo(tempDir);
                foreach (System.IO.FileInfo file in di1.GetFiles())
                {
                    file.Delete();
                }

                if (Directory.Exists(tempDir))
                {
                    Directory.Delete(tempDir);
                }
            }



            pictureBoxPlayer1.Visible = true;
            pictureBoxPlayer2.Visible = true;
            pictureBoxPlayer3.Visible = true;
            labelPlayer1.Visible = true;
            labelPlayer2.Visible = true;
            labelPlayer3.Visible = true;

            buttonShowAllGame.Enabled = false;

            try
            {
                string loadGameDir = AppDomain.CurrentDomain.BaseDirectory + @"loadGame";
                if (!Directory.Exists(loadGameDir))
                {

                }
                else
                {
                    int numDir = Directory.GetDirectories(loadGameDir).Length;
                    string loadGame = @"\loadGame";
                    // MessageBox.Show(numDir.ToString());
                    for (int i = 1; i <= numDir ; ++i)
                    {

                        string gamePath = loadGameDir + loadGame + i.ToString();
                        string infoSaveFile = gamePath + @"\info.txt";

                        string f = infoSaveFile;

                        // 1
                        // Declare new List.
                        List<string> lines = new List<string>();
                        // 2
                        // Use using StreamReader for disposing.

                        using (StreamReader r = new StreamReader(f))
                        {
                            // 3
                            // Use while != null pattern for loop
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                // 4
                                // Insert logic here.
                                // ...
                                // "line" is a line in the file. Add it to our List.
                                lines.Add(line);
                            }
                        }

                        if (lines[0] == "c1")
                        {
                            try
                            {
                                /*          pictureBoxPlayer1.Visible = false;
                                          pictureBoxPlayer2.Visible = false;
                                          pictureBoxPlayer3.Visible = false;
                                          labelPlayer1.Visible = false;
                                          labelPlayer2.Visible = false;
                                          labelPlayer3.Visible = false;
                              */

                                int lineNum = lines.Count();
                                if (lineNum != 6)
                                {
                                    MessageBox.Show("erro file! ");
                                    return;
                                }

                                // find draw number
                                int totalBoard = 10;
                                int xWins = 0; int oWins = 0; int drawNum = 0;
                                if (lines[3] == "0")
                                {
                                    xWins = 0;
                                }
                                else if (lines[3] == "1")
                                {
                                    xWins = 1;
                                }
                                else if (lines[3] == "2")
                                {
                                    xWins = 2;
                                }
                                else if (lines[3] == "3")
                                {
                                    xWins = 3;
                                }
                                else if (lines[3] == "4")
                                {
                                    xWins = 4;
                                }
                                else if (lines[3] == "5")
                                {
                                    xWins = 5;
                                }
                                else if (lines[3] == "6")
                                {
                                    xWins = 6;
                                }
                                else if (lines[3] == "7")
                                {
                                    xWins = 7;
                                }
                                else if (lines[3] == "8")
                                {
                                    xWins = 8;
                                }
                                else if (lines[3] == "9")
                                {
                                    xWins = 9;
                                }
                                else if (lines[3] == "10")
                                {
                                    xWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file!");
                                    return;
                                }

                                if (lines[4] == "0")
                                {
                                    oWins = 0;
                                }
                                else if (lines[4] == "1")
                                {
                                    oWins = 1;
                                }
                                else if (lines[4] == "2")
                                {
                                    oWins = 2;
                                }
                                else if (lines[4] == "3")
                                {
                                    oWins = 3;
                                }
                                else if (lines[4] == "4")
                                {
                                    oWins = 4;
                                }
                                else if (lines[4] == "5")
                                {
                                    oWins = 5;
                                }
                                else if (lines[4] == "6")
                                {
                                    oWins = 6;
                                }
                                else if (lines[4] == "7")
                                {
                                    oWins = 7;
                                }
                                else if (lines[4] == "8")
                                {
                                    oWins = 8;
                                }
                                else if (lines[4] == "9")
                                {
                                    oWins = 9;
                                }
                                else if (lines[4] == "10")
                                {
                                    oWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file");
                                    return;
                                }

                                drawNum = totalBoard - xWins - oWins;
                                if (drawNum < 0)
                                {
                                    MessageBox.Show("Error file!!!");
                                    return;
                                }

                                ListViewItem lv1 = new ListViewItem("Challange 1p");
                                lv1.SubItems.Add(lines[1]);
                                lv1.SubItems.Add("AI");
                                lv1.SubItems.Add("No");
                                lv1.SubItems.Add(lines[2]);

                                listView1.Items.Add(lv1);

                                /*                       ListViewItem lv2 = new ListViewItem(lines[3]);
                                                       lv2.SubItems.Add(lines[4].ToString());
                                                       lv2.SubItems.Add("No");
                                                       lv2.SubItems.Add(drawNum.ToString());
                                                       lv2.SubItems.Add(lines[5].ToString());


                                                       // lv2.SubItems.Add(lines[5]);
                                                       listView2.Items.Add(lv2);
                       */

                                // work with the pictures
                                pictureBoxPlayer1.Visible = true;
                                pictureBoxPlayer2.Visible = true;
                                labelPlayer1.Visible = true;
                                labelPlayer2.Visible = true;

                                labelPlayer1.Text = (lines[1]);
                                labelPlayer2.Text = "AI";

                                string picP1Path = gamePath + @"\avatar";
                                string picAIpath = gamePath + @"\AI";
                                if (File.Exists(picP1Path))
                                {
                                    pictureBoxPlayer1.ImageLocation = picP1Path;
                                }
                                if (File.Exists(picAIpath))
                                {
                                    pictureBoxPlayer2.ImageLocation = picAIpath;
                                }


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Delete this game,it's erro");
                            }



                        }
                        else if (lines[0] == "c2")
                        {
                            try
                            {
                                /*  pictureBoxPlayer1.Visible = false;
                                  pictureBoxPlayer2.Visible = false;
                                  pictureBoxPlayer3.Visible = false;
                                  labelPlayer1.Visible = false;
                                  labelPlayer2.Visible = false;
                                  labelPlayer3.Visible = false;
                                  */
                                int lineNum = lines.Count();
                                if (lineNum != 6)
                                {
                                    MessageBox.Show("erro file !!");
                                    return;
                                }

                                // find draw number
                                int totalBoard = 10;
                                int xWins = 0; int oWins = 0; int drawNum = 0;
                                if (lines[3] == "0")
                                {
                                    xWins = 0;
                                }
                                else if (lines[3] == "1")
                                {
                                    xWins = 1;
                                }
                                else if (lines[3] == "2")
                                {
                                    xWins = 2;
                                }
                                else if (lines[3] == "3")
                                {
                                    xWins = 3;
                                }
                                else if (lines[3] == "4")
                                {
                                    xWins = 4;
                                }
                                else if (lines[3] == "5")
                                {
                                    xWins = 5;
                                }
                                else if (lines[3] == "6")
                                {
                                    xWins = 6;
                                }
                                else if (lines[3] == "7")
                                {
                                    xWins = 7;
                                }
                                else if (lines[3] == "8")
                                {
                                    xWins = 8;
                                }
                                else if (lines[3] == "9")
                                {
                                    xWins = 9;
                                }
                                else if (lines[3] == "10")
                                {
                                    xWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file");
                                    return;
                                }

                                if (lines[4] == "0")
                                {
                                    oWins = 0;
                                }
                                else if (lines[4] == "1")
                                {
                                    oWins = 1;
                                }
                                else if (lines[4] == "2")
                                {
                                    oWins = 2;
                                }
                                else if (lines[4] == "3")
                                {
                                    oWins = 3;
                                }
                                else if (lines[4] == "4")
                                {
                                    oWins = 4;
                                }
                                else if (lines[4] == "5")
                                {
                                    oWins = 5;
                                }
                                else if (lines[4] == "6")
                                {
                                    oWins = 6;
                                }
                                else if (lines[4] == "7")
                                {
                                    oWins = 7;
                                }
                                else if (lines[4] == "8")
                                {
                                    oWins = 8;
                                }
                                else if (lines[4] == "9")
                                {
                                    oWins = 9;
                                }
                                else if (lines[4] == "10")
                                {
                                    oWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file");
                                    return;
                                }

                                drawNum = totalBoard - xWins - oWins;
                                if (drawNum < 0)
                                {
                                    MessageBox.Show("Error file!!");
                                    return;
                                }
                                ListViewItem lv1 = new ListViewItem("Challange 2p");
                                lv1.SubItems.Add(lines[1]);
                                lv1.SubItems.Add(lines[2]);
                                lv1.SubItems.Add("No");
                                lv1.SubItems.Add("No");

                                listView1.Items.Add(lv1);

                                /*                           ListViewItem lv2 = new ListViewItem(lines[3]);
                                                           lv2.SubItems.Add(lines[4].ToString());
                                                           lv2.SubItems.Add("No");
                                                           lv2.SubItems.Add(drawNum.ToString());
                                                           lv2.SubItems.Add(lines[5].ToString());


                                                           // lv2.SubItems.Add(lines[5]);
                                                           listView2.Items.Add(lv2);

                           */
                                // work with the pictures
                                pictureBoxPlayer1.Visible = true;
                                pictureBoxPlayer2.Visible = true;
                                labelPlayer1.Visible = true;
                                labelPlayer2.Visible = true;

                                labelPlayer1.Text = (lines[1]);
                                labelPlayer2.Text = lines[2];

                                string picP1Path = gamePath + @"\avatar1";
                                string picP2Path = gamePath + @"\avatar2";
                                if (File.Exists(picP1Path))
                                {
                                    pictureBoxPlayer1.ImageLocation = picP1Path;
                                }
                                if (File.Exists(picP2Path))
                                {
                                    pictureBoxPlayer2.ImageLocation = picP2Path;
                                }


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Delete this game,it's erro");
                            }

                        }
                        else if (lines[0] == "c3")
                        {
                            try
                            {
                                /*   pictureBoxPlayer1.Visible = false;
                                   pictureBoxPlayer2.Visible = false;
                                   pictureBoxPlayer3.Visible = false;
                                   labelPlayer1.Visible = false;
                                   labelPlayer2.Visible = false;
                                   labelPlayer3.Visible = false;
                                   */
                                int lineNum = lines.Count();
                                if (lineNum != 8)
                                {
                                    MessageBox.Show("erro file !!!");
                                    return;
                                }

                                // find draw number
                                int totalBoard = 10;
                                int xWins = 0; int oWins = 0; int drawNum = 0;
                                int plusWins = 0;

                                if (lines[4] == "0")
                                {
                                    xWins = 0;
                                }
                                else if (lines[4] == "1")
                                {
                                    xWins = 1;
                                }
                                else if (lines[4] == "2")
                                {
                                    xWins = 2;
                                }
                                else if (lines[4] == "3")
                                {
                                    xWins = 3;
                                }
                                else if (lines[4] == "4")
                                {
                                    xWins = 4;
                                }
                                else if (lines[4] == "5")
                                {
                                    xWins = 5;
                                }
                                else if (lines[4] == "6")
                                {
                                    xWins = 6;
                                }
                                else if (lines[4] == "7")
                                {
                                    xWins = 7;
                                }
                                else if (lines[4] == "8")
                                {
                                    xWins = 8;
                                }
                                else if (lines[4] == "9")
                                {
                                    xWins = 9;
                                }
                                else if (lines[4] == "10")
                                {
                                    xWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file !!!");
                                    return;
                                }

                                if (lines[5] == "0")
                                {
                                    oWins = 0;
                                }
                                else if (lines[5] == "1")
                                {
                                    oWins = 1;
                                }
                                else if (lines[4] == "2")
                                {
                                    oWins = 2;
                                }
                                else if (lines[5] == "3")
                                {
                                    oWins = 3;
                                }
                                else if (lines[5] == "4")
                                {
                                    oWins = 4;
                                }
                                else if (lines[5] == "5")
                                {
                                    oWins = 5;
                                }
                                else if (lines[5] == "6")
                                {
                                    oWins = 6;
                                }
                                else if (lines[5] == "7")
                                {
                                    oWins = 7;
                                }
                                else if (lines[5] == "8")
                                {
                                    oWins = 8;
                                }
                                else if (lines[5] == "9")
                                {
                                    oWins = 9;
                                }
                                else if (lines[5] == "10")
                                {
                                    oWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file !!!");
                                    return;
                                }

                                if (lines[6] == "0")
                                {
                                    plusWins = 0;
                                }

                                else if (lines[6] == "1")
                                {
                                    plusWins = 1;
                                }
                                else if (lines[6] == "2")
                                {
                                    plusWins = 2;
                                }
                                else if (lines[6] == "3")
                                {
                                    plusWins = 3;
                                }
                                else if (lines[6] == "4")
                                {
                                    plusWins = 4;
                                }
                                else if (lines[6] == "5")
                                {
                                    plusWins = 5;
                                }
                                else if (lines[6] == "6")
                                {
                                    plusWins = 6;
                                }
                                else if (lines[6] == "7")
                                {
                                    plusWins = 7;
                                }
                                else if (lines[6] == "8")
                                {
                                    plusWins = 8;
                                }
                                else if (lines[6] == "9")
                                {
                                    plusWins = 9;
                                }
                                else if (lines[6] == "10")
                                {
                                    plusWins = 10;
                                }


                                drawNum = totalBoard - xWins - oWins - plusWins;
                                if (drawNum < 0)
                                {
                                    MessageBox.Show("Error file");
                                    return;
                                }



                                ListViewItem lv1 = new ListViewItem("Challange 3p");
                                lv1.SubItems.Add(lines[1]);
                                lv1.SubItems.Add(lines[2]);
                                lv1.SubItems.Add(lines[3]);
                                lv1.SubItems.Add("No");

                                listView1.Items.Add(lv1);

                                /*                              ListViewItem lv2 = new ListViewItem(lines[4]);
                                                              lv2.SubItems.Add(lines[5].ToString());
                                                              lv2.SubItems.Add(lines[6]);
                                                              lv2.SubItems.Add(drawNum.ToString());
                                                              lv2.SubItems.Add(lines[7].ToString());


                                                              // lv2.SubItems.Add(lines[5]);
                                                              listView2.Items.Add(lv2);
                              */

                                // work with the pictures
                                pictureBoxPlayer1.Visible = true;
                                pictureBoxPlayer2.Visible = true;
                                pictureBoxPlayer3.Visible = true;
                                labelPlayer1.Visible = true;
                                labelPlayer2.Visible = true;
                                labelPlayer3.Visible = true;

                                labelPlayer1.Text = (lines[1]);
                                labelPlayer2.Text = lines[2];
                                labelPlayer3.Text = lines[3];

                                string picP1Path = gamePath + @"\avatar1";
                                string picP2Path = gamePath + @"\avatar2";
                                string picP3Path = gamePath + @"\avatar3";
                                if (File.Exists(picP1Path))
                                {
                                    pictureBoxPlayer1.ImageLocation = picP1Path;
                                }
                                if (File.Exists(picP2Path))
                                {
                                    pictureBoxPlayer2.ImageLocation = picP2Path;
                                }
                                if (File.Exists(picP3Path))
                                {
                                    pictureBoxPlayer3.ImageLocation = picP3Path;
                                }


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Delete this game,it's erro");
                            }

                        }
                        else if (lines[0] == "t1")
                        {
                          //  MessageBox.Show("the Boy");
                            labelTime.Text = "Time:";
                            try
                            {
                                /*          pictureBoxPlayer1.Visible = false;
                                          pictureBoxPlayer2.Visible = false;
                                          pictureBoxPlayer3.Visible = false;
                                          labelPlayer1.Visible = false;
                                          labelPlayer2.Visible = false;
                                          labelPlayer3.Visible = false;
                              */

                                int lineNum = lines.Count();
                                if (lineNum != 6+1)
                                {
                                    MessageBox.Show("erro file! ");
                                    return;
                                }

                                // find draw number
                                int totalBoard = 10;
                                int xWins = 0; int oWins = 0; int drawNum = 0;
                                if (lines[3] == "0")
                                {
                                    xWins = 0;
                                }
                                else if (lines[3] == "1")
                                {
                                    xWins = 1;
                                }
                                else if (lines[3] == "2")
                                {
                                    xWins = 2;
                                }
                                else if (lines[3] == "3")
                                {
                                    xWins = 3;
                                }
                                else if (lines[3] == "4")
                                {
                                    xWins = 4;
                                }
                                else if (lines[3] == "5")
                                {
                                    xWins = 5;
                                }
                                else if (lines[3] == "6")
                                {
                                    xWins = 6;
                                }
                                else if (lines[3] == "7")
                                {
                                    xWins = 7;
                                }
                                else if (lines[3] == "8")
                                {
                                    xWins = 8;
                                }
                                else if (lines[3] == "9")
                                {
                                    xWins = 9;
                                }
                                else if (lines[3] == "10")
                                {
                                    xWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file!");
                                    return;
                                }

                                if (lines[4] == "0")
                                {
                                    oWins = 0;
                                }
                                else if (lines[4] == "1")
                                {
                                    oWins = 1;
                                }
                                else if (lines[4] == "2")
                                {
                                    oWins = 2;
                                }
                                else if (lines[4] == "3")
                                {
                                    oWins = 3;
                                }
                                else if (lines[4] == "4")
                                {
                                    oWins = 4;
                                }
                                else if (lines[4] == "5")
                                {
                                    oWins = 5;
                                }
                                else if (lines[4] == "6")
                                {
                                    oWins = 6;
                                }
                                else if (lines[4] == "7")
                                {
                                    oWins = 7;
                                }
                                else if (lines[4] == "8")
                                {
                                    oWins = 8;
                                }
                                else if (lines[4] == "9")
                                {
                                    oWins = 9;
                                }
                                else if (lines[4] == "10")
                                {
                                    oWins = 10;
                                }
                                else
                                {
                                    MessageBox.Show("Error file");
                                    return;
                                }

                                drawNum = totalBoard - xWins - oWins;
                                if (drawNum < 0)
                                {
                                    MessageBox.Show("Error file!!!");
                                    return;
                                }

                                ListViewItem lv1 = new ListViewItem("Timer");
                                lv1.SubItems.Add(lines[1]);
                                lv1.SubItems.Add("AI");
                                lv1.SubItems.Add("No");
                                lv1.SubItems.Add(lines[2]);

                                listView1.Items.Add(lv1);

                                /*                       ListViewItem lv2 = new ListViewItem(lines[3]);
                                                       lv2.SubItems.Add(lines[4].ToString());
                                                       lv2.SubItems.Add("No");
                                                       lv2.SubItems.Add(drawNum.ToString());
                                                       lv2.SubItems.Add(lines[5].ToString());


                                                       // lv2.SubItems.Add(lines[5]);
                                                       listView2.Items.Add(lv2);
                       */

                                // work with the pictures
                                pictureBoxPlayer1.Visible = true;
                                pictureBoxPlayer2.Visible = true;
                                labelPlayer1.Visible = true;
                                labelPlayer2.Visible = true;

                                labelPlayer1.Text = (lines[1]);
                                labelPlayer2.Text = "AI";

                                string picP1Path = gamePath + @"\avatar";
                                string picAIpath = gamePath + @"\AI";
                                if (File.Exists(picP1Path))
                                {
                                    pictureBoxPlayer1.ImageLocation = picP1Path;
                                }
                                if (File.Exists(picAIpath))
                                {
                                    pictureBoxPlayer2.ImageLocation = picAIpath;
                                }
                                // wroking with the timer. 22-May-2016 by AN Panharith (the Boy)



                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Delete this game,it's erro");
                            }
                            


                        }

                        else if (lines[0] == "t2")
                        {

                        }
                        else if (lines[0] == "t3")
                        {

                        }

                        // break;

                    }



                }
                pictureBoxPlayer1.ImageLocation = null;
                pictureBoxPlayer2.ImageLocation = null;
                pictureBoxPlayer3.ImageLocation = null;
                labelPlayer1.Text = "";
                labelPlayer2.Text = "";
                labelPlayer3.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Infinity");
            }

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // updated 18/5/2016 by AN Panharith (the Boy)
            labelTime.Text = "";
            if (listView1.SelectedItems.Count > 0)
            {

                int index = listView1.SelectedIndices[0];

                ListViewItem selectedItem = listView1.SelectedItems[0];
                int imageIndex = selectedItem.ImageIndex;

                int theGameIndex = index + 1;

                string loadGameLocation = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame" + theGameIndex.ToString();
                //MessageBox.Show(game);

                string infoSaveFile = loadGameLocation + @"\info.txt";
                //MessageBox.Show(infoSaveFile);
                //return;
                if (File.Exists(infoSaveFile))
                {
                    //  string loadGame = @"\loadGame";
                    StreamReader sr = new StreamReader(infoSaveFile);
                    string gameType = sr.ReadLine();
                    sr.Close();

                    if (gameType == "c1")
                    {
                        List<string> lines = new List<string>();
                        using (StreamReader r = new StreamReader(infoSaveFile))
                        {
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                lines.Add(line);
                            }
                        }
                        int theSize = lines.Count;

                        if (theSize != 6)
                        {
                            MessageBox.Show("Game is error! ");
                            return;
                        }

                        string theAvatar = loadGameLocation + @"\Avatar";
                        if (File.Exists(theAvatar)) // show the avatar
                        {
                            pictureBoxPlayer1.ImageLocation = theAvatar;
                        }

                        labelPlayer1.Text = lines[1]; // show the name of the player
                                                      // Avatar of A.I
                        try
                        {
                            //     MessageBox.Show(levell);
                            if (lines[2] == "1")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.spiderMinion;
                            }

                            else if (lines[2] == "2")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.wolveMinion;

                            }
                            else if (lines[2] == "3")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.dracMinion;

                            }
                            else if (lines[2] == "4")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.minionCreed;

                            }
                            else if (lines[2] == "5")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.ironMinion;

                            }
                            else if (lines[2] == "6")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.capMinion;

                            }

                            else
                            {


                            }


                        }
                        catch
                        {

                        }

                        labelPlayer2.Text = ("AI");
                        labelPlayer3.Text = "";
                        pictureBoxPlayer3.ImageLocation = null;



                        // clear the old item in listview 2
                        listView2.Items.Clear();

                        ListViewItem theItem = new ListViewItem(lines[3]);
                        theItem.SubItems.Add(lines[4]);
                        theItem.SubItems.Add("No");
                        theItem.SubItems.Add(FindDrawBy2Parameter(lines[3], lines[4]).ToString());
                        theItem.SubItems.Add(lines[5]);

                        listView2.Items.Add(theItem);
                        //listView1.Items.Add(lv1);





                    }
                    else if (gameType == "c2")
                    {
                        List<string> lines = new List<string>();

                        using (StreamReader r = new StreamReader(infoSaveFile))
                        {
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                lines.Add(line);
                            }
                        }
                        int theSize = lines.Count;

                        if (theSize != 6)
                        {
                            MessageBox.Show("Game is error! ");
                            return;
                        }

                        string theAvatar1 = loadGameLocation + @"\Avatar1";
                        if (File.Exists(theAvatar1)) // show the avatar
                        {
                            pictureBoxPlayer1.ImageLocation = theAvatar1;
                        }

                        labelPlayer1.Text = lines[1]; // show the name of the player
                        string theAvatar2 = loadGameLocation + @"\Avatar2";
                        if (File.Exists(theAvatar2)) // show the avatar
                        {
                            pictureBoxPlayer2.ImageLocation = theAvatar2;
                        }

                        labelPlayer2.Text = lines[2]; // show the name of the player
                        labelPlayer3.Text = "";
                        pictureBoxPlayer3.ImageLocation = null;

                        // clear the old item in listview 2
                        listView2.Items.Clear();

                        ListViewItem theItem = new ListViewItem(lines[3]);
                        theItem.SubItems.Add(lines[4]);
                        theItem.SubItems.Add("No");
                        theItem.SubItems.Add(FindDrawBy2Parameter(lines[3], lines[4]).ToString());
                        theItem.SubItems.Add(lines[5]);

                        listView2.Items.Add(theItem);
                        //listView1.Items.Add(lv1);



                    }
                    else if (gameType == "c3")
                    {
                        List<string> lines = new List<string>();

                        using (StreamReader r = new StreamReader(infoSaveFile))
                        {
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                lines.Add(line);
                            }
                        }
                        int theSize = lines.Count;

                        if (theSize != 8)
                        {
                            MessageBox.Show("Game is error! ");
                            return;
                        }

                        string theAvatar1 = loadGameLocation + @"\Avatar1";
                        if (File.Exists(theAvatar1)) // show the avatar
                        {
                            pictureBoxPlayer1.ImageLocation = theAvatar1;
                        }

                        labelPlayer1.Text = lines[1]; // show the name of the player
                        string theAvatar2 = loadGameLocation + @"\Avatar2";
                        if (File.Exists(theAvatar2)) // show the avatar
                        {
                            pictureBoxPlayer2.ImageLocation = theAvatar2;
                        }

                        labelPlayer2.Text = lines[2]; // show the name of the player
                        //------------
                        string theAvatar3 = loadGameLocation + @"\Avatar3";
                        if (File.Exists(theAvatar3)) // show the avatar
                        {
                            pictureBoxPlayer3.ImageLocation = theAvatar3;
                        }
                        labelPlayer3.Text = lines[3];

                        // clear the old item in listview 2
                        listView2.Items.Clear();

                        ListViewItem theItem = new ListViewItem(lines[4]);
                        theItem.SubItems.Add(lines[5]);
                        theItem.SubItems.Add(lines[6]);
                        theItem.SubItems.Add(FindDrawBy3Parameter(lines[4], lines[5], lines[6]).ToString());
                        theItem.SubItems.Add(lines[7]);

                        listView2.Items.Add(theItem);
                        //listView1.Items.Add(lv1);

                    }
                    else if (gameType == "t1")
                    {
                        List<string> lines = new List<string>();
                        using (StreamReader r = new StreamReader(infoSaveFile))
                        {
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                lines.Add(line);
                            }
                        }
                        int theSize = lines.Count;

                        if (theSize != 6 +1 )
                        {
                            MessageBox.Show("Game is error! ");
                            return;
                        }

                        string theAvatar = loadGameLocation + @"\Avatar";
                        if (File.Exists(theAvatar)) // show the avatar
                        {
                            pictureBoxPlayer1.ImageLocation = theAvatar;
                        }

                        labelPlayer1.Text = lines[1]; // show the name of the player
                                                      // Avatar of A.I
                        try
                        {
                            //     MessageBox.Show(levell);
                            if (lines[2] == "1")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.spiderMinion;
                            }

                            else if (lines[2] == "2")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.wolveMinion;

                            }
                            else if (lines[2] == "3")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.dracMinion;

                            }
                            else if (lines[2] == "4")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.minionCreed;

                            }
                            else if (lines[2] == "5")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.ironMinion;

                            }
                            else if (lines[2] == "6")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.capMinion;

                            }

                            else
                            {


                            }


                        }
                        catch
                        {

                        }

                        labelPlayer2.Text = ("AI");
                        labelPlayer3.Text = "";
                        pictureBoxPlayer3.ImageLocation = null;



                        // clear the old item in listview 2
                        listView2.Items.Clear();

                        ListViewItem theItem = new ListViewItem(lines[3]);
                        theItem.SubItems.Add(lines[4]);
                        theItem.SubItems.Add("No");
                        theItem.SubItems.Add(FindDrawBy2Parameter(lines[3], lines[4]).ToString());
                        theItem.SubItems.Add(lines[5]);

                        listView2.Items.Add(theItem);
                        //listView1.Items.Add(lv1);
                        // working with the time
                      //  MessageBox.Show("skrillex");
                        labelTime.Show();


                        labelTime.Text = "Time: ";
                        int theTime = StringToInt(lines[6]);

                        //Font standardFont = new Font(labelTime.Font);
                       // Font underFont = new Font(standardFont, FontStyle.Underline);
                    //   MessageBox.Show(theTime.ToString());
                        int hour = 0;
                        int minute = 0;
                        int second = 0;
                        hour = theTime / 3600;
                        int remain1 = theTime - (hour * 3600);
                        minute = remain1 / 60;
                        second = remain1 - (minute * 60);

                        labelTime.Text += hour.ToString() + "H " + minute.ToString() + "Min " + second.ToString() + "Second";


                    }
                    //-------------------------------------------------------------------------
                }
                else if (!File.Exists(infoSaveFile))
                {
                    MessageBox.Show(infoSaveFile);
                    MessageBox.Show("File is not found!");
                }

            }
            else
            {
                // buttonDelete.Enabled = false;
            }
        }

        private void FormLoadGame1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Tic Tac Toe");
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            // updated 18/5/2016 by AN Panharith (the Boy)
            if (listView1.SelectedItems.Count > 0)
            {

                int index = listView1.SelectedIndices[0];

                ListViewItem selectedItem = listView1.SelectedItems[0];
                int imageIndex = selectedItem.ImageIndex;

                int theGameIndex = index + 1;

                string loadGameLocation = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame" + theGameIndex.ToString();
                //MessageBox.Show(game);
                ResourceWriter rw = new ResourceWriter("LoadGameRequest.resx");
                rw.AddResource("gameLocationRequest", loadGameLocation);
                rw.Close();
                ResourceWriter rw1 = new ResourceWriter("userChoise.resx");
                rw1.AddResource("choise", "L");
                rw1.Close();

                FormPlayBoard FormPB = new FormPlayBoard();
                FormPB.Show();


                return;
                string infoSaveFile = loadGameLocation + @"\info.txt";
                //MessageBox.Show(infoSaveFile);
                //return;
                if (File.Exists(infoSaveFile))
                {
                    //  string loadGame = @"\loadGame";
                    StreamReader sr = new StreamReader(infoSaveFile);
                    string gameType = sr.ReadLine();
                    sr.Close();

                    if (gameType == "c1")
                    {
                        List<string> lines = new List<string>();
                        using (StreamReader r = new StreamReader(infoSaveFile))
                        {
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                lines.Add(line);
                            }
                        }
                        int theSize = lines.Count;

                        if (theSize != 6)
                        {
                            MessageBox.Show("Game is error! ");
                            return;
                        }

                        string theAvatar = loadGameLocation + @"\Avatar";
                        if (File.Exists(theAvatar)) // show the avatar
                        {
                            pictureBoxPlayer1.ImageLocation = theAvatar;
                        }

                        labelPlayer1.Text = lines[1]; // show the name of the player
                                                      // Avatar of A.I
                        try
                        {
                            //     MessageBox.Show(levell);
                            if (lines[2] == "1")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.spiderMinion;
                            }

                            else if (lines[2] == "2")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.wolveMinion;

                            }
                            else if (lines[2] == "3")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.dracMinion;

                            }
                            else if (lines[2] == "4")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.minionCreed;

                            }
                            else if (lines[2] == "5")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.ironMinion;

                            }
                            else if (lines[2] == "6")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.capMinion;

                            }

                            else
                            {


                            }


                        }
                        catch
                        {

                        }

                        labelPlayer2.Text = ("AI");
                        labelPlayer3.Text = "";
                        pictureBoxPlayer3.ImageLocation = null;



                        // clear the old item in listview 2
                        listView2.Items.Clear();

                        ListViewItem theItem = new ListViewItem(lines[3]);
                        theItem.SubItems.Add(lines[4]);
                        theItem.SubItems.Add("No");
                        theItem.SubItems.Add(FindDrawBy2Parameter(lines[3], lines[4]).ToString());
                        theItem.SubItems.Add(lines[5]);

                        listView2.Items.Add(theItem);
                        //listView1.Items.Add(lv1);





                    }
                    else if (gameType == "c2")
                    {
                        List<string> lines = new List<string>();

                        using (StreamReader r = new StreamReader(infoSaveFile))
                        {
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                lines.Add(line);
                            }
                        }
                        int theSize = lines.Count;

                        if (theSize != 6)
                        {
                            MessageBox.Show("Game is error! ");
                            return;
                        }

                        string theAvatar1 = loadGameLocation + @"\Avatar1";
                        if (File.Exists(theAvatar1)) // show the avatar
                        {
                            pictureBoxPlayer1.ImageLocation = theAvatar1;
                        }

                        labelPlayer1.Text = lines[1]; // show the name of the player
                        string theAvatar2 = loadGameLocation + @"\Avatar2";
                        if (File.Exists(theAvatar2)) // show the avatar
                        {
                            pictureBoxPlayer2.ImageLocation = theAvatar2;
                        }

                        labelPlayer2.Text = lines[2]; // show the name of the player
                        labelPlayer3.Text = "";
                        pictureBoxPlayer3.ImageLocation = null;

                        // clear the old item in listview 2
                        listView2.Items.Clear();

                        ListViewItem theItem = new ListViewItem(lines[3]);
                        theItem.SubItems.Add(lines[4]);
                        theItem.SubItems.Add("No");
                        theItem.SubItems.Add(FindDrawBy2Parameter(lines[3], lines[4]).ToString());
                        theItem.SubItems.Add(lines[5]);

                        listView2.Items.Add(theItem);
                        //listView1.Items.Add(lv1);



                    }
                    else if (gameType == "c3")
                    {
                        List<string> lines = new List<string>();

                        using (StreamReader r = new StreamReader(infoSaveFile))
                        {
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                lines.Add(line);
                            }
                        }
                        int theSize = lines.Count;

                        if (theSize != 8)
                        {
                            MessageBox.Show("Game is error! ");
                            return;
                        }

                        string theAvatar1 = loadGameLocation + @"\Avatar1";
                        if (File.Exists(theAvatar1)) // show the avatar
                        {
                            pictureBoxPlayer1.ImageLocation = theAvatar1;
                        }

                        labelPlayer1.Text = lines[1]; // show the name of the player
                        string theAvatar2 = loadGameLocation + @"\Avatar2";
                        if (File.Exists(theAvatar2)) // show the avatar
                        {
                            pictureBoxPlayer2.ImageLocation = theAvatar2;
                        }

                        labelPlayer2.Text = lines[2]; // show the name of the player
                        //------------
                        string theAvatar3 = loadGameLocation + @"\Avatar3";
                        if (File.Exists(theAvatar3)) // show the avatar
                        {
                            pictureBoxPlayer3.ImageLocation = theAvatar3;
                        }
                        labelPlayer3.Text = lines[3];

                        // clear the old item in listview 2
                        listView2.Items.Clear();

                        ListViewItem theItem = new ListViewItem(lines[4]);
                        theItem.SubItems.Add(lines[5]);
                        theItem.SubItems.Add(lines[6]);
                        theItem.SubItems.Add(FindDrawBy3Parameter(lines[4], lines[5], lines[6]).ToString());
                        theItem.SubItems.Add(lines[7]);

                        listView2.Items.Add(theItem);
                        //listView1.Items.Add(lv1);

                    }
                    else if (gameType == "t1")
                    {
                        MessageBox.Show("level skrillex");
                        List<string> lines = new List<string>();
                        using (StreamReader r = new StreamReader(infoSaveFile))
                        {
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                lines.Add(line);
                            }
                        }
                        int theSize = lines.Count;

                        if (theSize != 6)
                        {
                            MessageBox.Show("Game is error! ");
                            return;
                        }

                        string theAvatar = loadGameLocation + @"\Avatar";
                        if (File.Exists(theAvatar)) // show the avatar
                        {
                            pictureBoxPlayer1.ImageLocation = theAvatar;
                        }

                        labelPlayer1.Text = lines[1]; // show the name of the player
                                                      // Avatar of A.I
                        try
                        {
                            //     MessageBox.Show(levell);
                            if (lines[2] == "1")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.spiderMinion;
                            }

                            else if (lines[2] == "2")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.wolveMinion;

                            }
                            else if (lines[2] == "3")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.dracMinion;

                            }
                            else if (lines[2] == "4")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.minionCreed;

                            }
                            else if (lines[2] == "5")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.ironMinion;

                            }
                            else if (lines[2] == "6")
                            {
                                pictureBoxPlayer2.Image = Properties.Resources.capMinion;

                            }

                            else
                            {


                            }


                        }
                        catch
                        {

                        }

                        labelPlayer2.Text = ("AI");
                        labelPlayer3.Text = "";
                        pictureBoxPlayer3.ImageLocation = null;



                        // clear the old item in listview 2
                        listView2.Items.Clear();

                        ListViewItem theItem = new ListViewItem(lines[3]);
                        theItem.SubItems.Add(lines[4]);
                        theItem.SubItems.Add("No");
                        theItem.SubItems.Add(FindDrawBy2Parameter(lines[3], lines[4]).ToString());
                        theItem.SubItems.Add(lines[5]);

                        listView2.Items.Add(theItem);
                        //listView1.Items.Add(lv1);

                        labelTime.Text = "Time: ";

                    }
                    //-------------------------------------------------------------------------
                }
                else if (!File.Exists(infoSaveFile))
                {
                    MessageBox.Show(infoSaveFile);
                    MessageBox.Show("File is not found!");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            

            if (listView1.SelectedItems.Count > 0)
            {
                //-----------------------------
                int index = listView1.SelectedIndices[0];
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int imageIndex = selectedItem.ImageIndex;

                int theGameIndex = index + 1;

                string deletedGame = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame" + theGameIndex.ToString();


                DirectoryInfo di =  new DirectoryInfo(deletedGame);
                foreach (System.IO.FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                
                Directory.Delete(deletedGame);
            

                string loadGameDir = AppDomain.CurrentDomain.BaseDirectory + @"loadGame";
                string tempDir = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\temp";
                if (Directory.Exists(tempDir))
                {
                    DirectoryInfo di1 = new DirectoryInfo(tempDir);
                    foreach (System.IO.FileInfo file in di1.GetFiles())
                    {
                        file.Delete();
                    }

                    if (Directory.Exists(tempDir))
                    {
                        Directory.Delete(tempDir);
                    }
                }

                int allDir = Directory.GetDirectories(loadGameDir).Length;
                int restDir = allDir - theGameIndex;
                string theGame = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame";
                for (int i=theGameIndex+1;i<=theGameIndex+1+ restDir;++i)
                {
                    theGame = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame" + i.ToString();

                     if (theGame == deletedGame) continue;
                    if (Directory.Exists(theGame))
                    {
                        string destDir = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame" + (i-1).ToString();
                         Directory.Move(theGame, destDir);
                   }

                }
                listView1.Items.Clear();
                listView2.Items.Clear();
                try
                {


                    string loadGameDir1 = AppDomain.CurrentDomain.BaseDirectory + @"loadGame";
                    if (!Directory.Exists(loadGameDir1))
                    {

                    }
                    else
                    {
                        int numDir = Directory.GetDirectories(loadGameDir1).Length;
                        string loadGame = @"\loadGame";
                        // MessageBox.Show(numDir.ToString());
                        for (int i = 1; i <= numDir ; ++i)
                        {

                            string gamePath = loadGameDir1 + loadGame + i.ToString();
                            string infoSaveFile = gamePath + @"\info.txt";

                            string f = infoSaveFile;

                            // 1
                            // Declare new List.
                            List<string> lines = new List<string>();
                            // 2
                            // Use using StreamReader for disposing.

                            using (StreamReader r = new StreamReader(f))
                            {
                                // 3
                                // Use while != null pattern for loop
                                string line;
                                while ((line = r.ReadLine()) != null)
                                {
                                    // 4
                                    // Insert logic here.
                                    // ...
                                    // "line" is a line in the file. Add it to our List.
                                    lines.Add(line);
                                }
                            }

                            if (lines[0] == "c1")
                            {
                                try
                                {
                                    /*          pictureBoxPlayer1.Visible = false;
                                              pictureBoxPlayer2.Visible = false;
                                              pictureBoxPlayer3.Visible = false;
                                              labelPlayer1.Visible = false;
                                              labelPlayer2.Visible = false;
                                              labelPlayer3.Visible = false;
                                  */

                                    int lineNum = lines.Count();
                                    if (lineNum != 6)
                                    {
                                        MessageBox.Show("erro file! ");
                                        return;
                                    }

                                    // find draw number
                                    int totalBoard = 10;
                                    int xWins = 0; int oWins = 0; int drawNum = 0;
                                    if (lines[3] == "0")
                                    {
                                        xWins = 0;
                                    }
                                    else if (lines[3] == "1")
                                    {
                                        xWins = 1;
                                    }
                                    else if (lines[3] == "2")
                                    {
                                        xWins = 2;
                                    }
                                    else if (lines[3] == "3")
                                    {
                                        xWins = 3;
                                    }
                                    else if (lines[3] == "4")
                                    {
                                        xWins = 4;
                                    }
                                    else if (lines[3] == "5")
                                    {
                                        xWins = 5;
                                    }
                                    else if (lines[3] == "6")
                                    {
                                        xWins = 6;
                                    }
                                    else if (lines[3] == "7")
                                    {
                                        xWins = 7;
                                    }
                                    else if (lines[3] == "8")
                                    {
                                        xWins = 8;
                                    }
                                    else if (lines[3] == "9")
                                    {
                                        xWins = 9;
                                    }
                                    else if (lines[3] == "10")
                                    {
                                        xWins = 10;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error file!");
                                        return;
                                    }

                                    if (lines[4] == "0")
                                    {
                                        oWins = 0;
                                    }
                                    else if (lines[4] == "1")
                                    {
                                        oWins = 1;
                                    }
                                    else if (lines[4] == "2")
                                    {
                                        oWins = 2;
                                    }
                                    else if (lines[4] == "3")
                                    {
                                        oWins = 3;
                                    }
                                    else if (lines[4] == "4")
                                    {
                                        oWins = 4;
                                    }
                                    else if (lines[4] == "5")
                                    {
                                        oWins = 5;
                                    }
                                    else if (lines[4] == "6")
                                    {
                                        oWins = 6;
                                    }
                                    else if (lines[4] == "7")
                                    {
                                        oWins = 7;
                                    }
                                    else if (lines[4] == "8")
                                    {
                                        oWins = 8;
                                    }
                                    else if (lines[4] == "9")
                                    {
                                        oWins = 9;
                                    }
                                    else if (lines[4] == "10")
                                    {
                                        oWins = 10;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error file");
                                        return;
                                    }

                                    drawNum = totalBoard - xWins - oWins;
                                    if (drawNum < 0)
                                    {
                                        MessageBox.Show("Error file!!!");
                                        return;
                                    }

                                    ListViewItem lv1 = new ListViewItem("Challange 1p");
                                    lv1.SubItems.Add(lines[1]);
                                    lv1.SubItems.Add("AI");
                                    lv1.SubItems.Add("No");
                                    lv1.SubItems.Add(lines[2]);

                                    listView1.Items.Add(lv1);

                                    /*                       ListViewItem lv2 = new ListViewItem(lines[3]);
                                                           lv2.SubItems.Add(lines[4].ToString());
                                                           lv2.SubItems.Add("No");
                                                           lv2.SubItems.Add(drawNum.ToString());
                                                           lv2.SubItems.Add(lines[5].ToString());


                                                           // lv2.SubItems.Add(lines[5]);
                                                           listView2.Items.Add(lv2);
                           */

                                    // work with the pictures
                                    pictureBoxPlayer1.Visible = true;
                                    pictureBoxPlayer2.Visible = true;
                                    labelPlayer1.Visible = true;
                                    labelPlayer2.Visible = true;

                                    labelPlayer1.Text = (lines[1]);
                                    labelPlayer2.Text = "AI";

                                    string picP1Path = gamePath + @"\avatar";
                                    string picAIpath = gamePath + @"\AI";
                                    if (File.Exists(picP1Path))
                                    {
                                        pictureBoxPlayer1.ImageLocation = picP1Path;
                                    }
                                    if (File.Exists(picAIpath))
                                    {
                                        pictureBoxPlayer2.ImageLocation = picAIpath;
                                    }


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Delete this game,it's erro");
                                }



                            }
                            else if (lines[0] == "c2")
                            {
                                try
                                {
                                    /*  pictureBoxPlayer1.Visible = false;
                                      pictureBoxPlayer2.Visible = false;
                                      pictureBoxPlayer3.Visible = false;
                                      labelPlayer1.Visible = false;
                                      labelPlayer2.Visible = false;
                                      labelPlayer3.Visible = false;
                                      */
                                    int lineNum = lines.Count();
                                    if (lineNum != 6)
                                    {
                                        MessageBox.Show("erro file !!");
                                        return;
                                    }

                                    // find draw number
                                    int totalBoard = 10;
                                    int xWins = 0; int oWins = 0; int drawNum = 0;
                                    if (lines[3] == "0")
                                    {
                                        xWins = 0;
                                    }
                                    else if (lines[3] == "1")
                                    {
                                        xWins = 1;
                                    }
                                    else if (lines[3] == "2")
                                    {
                                        xWins = 2;
                                    }
                                    else if (lines[3] == "3")
                                    {
                                        xWins = 3;
                                    }
                                    else if (lines[3] == "4")
                                    {
                                        xWins = 4;
                                    }
                                    else if (lines[3] == "5")
                                    {
                                        xWins = 5;
                                    }
                                    else if (lines[3] == "6")
                                    {
                                        xWins = 6;
                                    }
                                    else if (lines[3] == "7")
                                    {
                                        xWins = 7;
                                    }
                                    else if (lines[3] == "8")
                                    {
                                        xWins = 8;
                                    }
                                    else if (lines[3] == "9")
                                    {
                                        xWins = 9;
                                    }
                                    else if (lines[3] == "10")
                                    {
                                        xWins = 10;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error file");
                                        return;
                                    }

                                    if (lines[4] == "0")
                                    {
                                        oWins = 0;
                                    }
                                    else if (lines[4] == "1")
                                    {
                                        oWins = 1;
                                    }
                                    else if (lines[4] == "2")
                                    {
                                        oWins = 2;
                                    }
                                    else if (lines[4] == "3")
                                    {
                                        oWins = 3;
                                    }
                                    else if (lines[4] == "4")
                                    {
                                        oWins = 4;
                                    }
                                    else if (lines[4] == "5")
                                    {
                                        oWins = 5;
                                    }
                                    else if (lines[4] == "6")
                                    {
                                        oWins = 6;
                                    }
                                    else if (lines[4] == "7")
                                    {
                                        oWins = 7;
                                    }
                                    else if (lines[4] == "8")
                                    {
                                        oWins = 8;
                                    }
                                    else if (lines[4] == "9")
                                    {
                                        oWins = 9;
                                    }
                                    else if (lines[4] == "10")
                                    {
                                        oWins = 10;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error file");
                                        return;
                                    }

                                    drawNum = totalBoard - xWins - oWins;
                                    if (drawNum < 0)
                                    {
                                        MessageBox.Show("Error file!!");
                                        return;
                                    }



                                    ListViewItem lv1 = new ListViewItem("Challange 2p");
                                    lv1.SubItems.Add(lines[1]);
                                    lv1.SubItems.Add(lines[2]);
                                    lv1.SubItems.Add("No");
                                    lv1.SubItems.Add("No");

                                    listView1.Items.Add(lv1);

                                    /*                           ListViewItem lv2 = new ListViewItem(lines[3]);
                                                               lv2.SubItems.Add(lines[4].ToString());
                                                               lv2.SubItems.Add("No");
                                                               lv2.SubItems.Add(drawNum.ToString());
                                                               lv2.SubItems.Add(lines[5].ToString());


                                                               // lv2.SubItems.Add(lines[5]);
                                                               listView2.Items.Add(lv2);

                               */
                                    // work with the pictures
                                    pictureBoxPlayer1.Visible = true;
                                    pictureBoxPlayer2.Visible = true;
                                    labelPlayer1.Visible = true;
                                    labelPlayer2.Visible = true;

                                    labelPlayer1.Text = (lines[1]);
                                    labelPlayer2.Text = lines[2];

                                    string picP1Path = gamePath + @"\avatar1";
                                    string picP2Path = gamePath + @"\avatar2";
                                    if (File.Exists(picP1Path))
                                    {
                                        pictureBoxPlayer1.ImageLocation = picP1Path;
                                    }
                                    if (File.Exists(picP2Path))
                                    {
                                        pictureBoxPlayer2.ImageLocation = picP2Path;
                                    }


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Delete this game,it's erro");
                                }

                            }
                            else if (lines[0] == "c3")
                            {
                                try
                                {
                                    /*   pictureBoxPlayer1.Visible = false;
                                       pictureBoxPlayer2.Visible = false;
                                       pictureBoxPlayer3.Visible = false;
                                       labelPlayer1.Visible = false;
                                       labelPlayer2.Visible = false;
                                       labelPlayer3.Visible = false;
                                       */
                                    int lineNum = lines.Count();
                                    if (lineNum != 8)
                                    {
                                        MessageBox.Show("erro file !!!");
                                        return;
                                    }

                                    // find draw number
                                    int totalBoard = 10;
                                    int xWins = 0; int oWins = 0; int drawNum = 0;
                                    int plusWins = 0;

                                    if (lines[4] == "0")
                                    {
                                        xWins = 0;
                                    }
                                    else if (lines[4] == "1")
                                    {
                                        xWins = 1;
                                    }
                                    else if (lines[4] == "2")
                                    {
                                        xWins = 2;
                                    }
                                    else if (lines[4] == "3")
                                    {
                                        xWins = 3;
                                    }
                                    else if (lines[4] == "4")
                                    {
                                        xWins = 4;
                                    }
                                    else if (lines[4] == "5")
                                    {
                                        xWins = 5;
                                    }
                                    else if (lines[4] == "6")
                                    {
                                        xWins = 6;
                                    }
                                    else if (lines[4] == "7")
                                    {
                                        xWins = 7;
                                    }
                                    else if (lines[4] == "8")
                                    {
                                        xWins = 8;
                                    }
                                    else if (lines[4] == "9")
                                    {
                                        xWins = 9;
                                    }
                                    else if (lines[4] == "10")
                                    {
                                        xWins = 10;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error file !!!");
                                        return;
                                    }

                                    if (lines[5] == "0")
                                    {
                                        oWins = 0;
                                    }
                                    else if (lines[5] == "1")
                                    {
                                        oWins = 1;
                                    }
                                    else if (lines[4] == "2")
                                    {
                                        oWins = 2;
                                    }
                                    else if (lines[5] == "3")
                                    {
                                        oWins = 3;
                                    }
                                    else if (lines[5] == "4")
                                    {
                                        oWins = 4;
                                    }
                                    else if (lines[5] == "5")
                                    {
                                        oWins = 5;
                                    }
                                    else if (lines[5] == "6")
                                    {
                                        oWins = 6;
                                    }
                                    else if (lines[5] == "7")
                                    {
                                        oWins = 7;
                                    }
                                    else if (lines[5] == "8")
                                    {
                                        oWins = 8;
                                    }
                                    else if (lines[5] == "9")
                                    {
                                        oWins = 9;
                                    }
                                    else if (lines[5] == "10")
                                    {
                                        oWins = 10;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error file !!!");
                                        return;
                                    }

                                    if (lines[6] == "0")
                                    {
                                        plusWins = 0;
                                    }

                                    else if (lines[6] == "1")
                                    {
                                        plusWins = 1;
                                    }
                                    else if (lines[6] == "2")
                                    {
                                        plusWins = 2;
                                    }
                                    else if (lines[6] == "3")
                                    {
                                        plusWins = 3;
                                    }
                                    else if (lines[6] == "4")
                                    {
                                        plusWins = 4;
                                    }
                                    else if (lines[6] == "5")
                                    {
                                        plusWins = 5;
                                    }
                                    else if (lines[6] == "6")
                                    {
                                        plusWins = 6;
                                    }
                                    else if (lines[6] == "7")
                                    {
                                        plusWins = 7;
                                    }
                                    else if (lines[6] == "8")
                                    {
                                        plusWins = 8;
                                    }
                                    else if (lines[6] == "9")
                                    {
                                        plusWins = 9;
                                    }
                                    else if (lines[6] == "10")
                                    {
                                        plusWins = 10;
                                    }


                                    drawNum = totalBoard - xWins - oWins - plusWins;
                                    if (drawNum < 0)
                                    {
                                        MessageBox.Show("Error file");
                                        return;
                                    }



                                    ListViewItem lv1 = new ListViewItem("Challange 3p");
                                    lv1.SubItems.Add(lines[1]);
                                    lv1.SubItems.Add(lines[2]);
                                    lv1.SubItems.Add(lines[3]);
                                    lv1.SubItems.Add("No");

                                    listView1.Items.Add(lv1);

                                    /*                              ListViewItem lv2 = new ListViewItem(lines[4]);
                                                                  lv2.SubItems.Add(lines[5].ToString());
                                                                  lv2.SubItems.Add(lines[6]);
                                                                  lv2.SubItems.Add(drawNum.ToString());
                                                                  lv2.SubItems.Add(lines[7].ToString());


                                                                  // lv2.SubItems.Add(lines[5]);
                                                                  listView2.Items.Add(lv2);
                                  */

                                    // work with the pictures
                                    pictureBoxPlayer1.Visible = true;
                                    pictureBoxPlayer2.Visible = true;
                                    pictureBoxPlayer3.Visible = true;
                                    labelPlayer1.Visible = true;
                                    labelPlayer2.Visible = true;
                                    labelPlayer3.Visible = true;

                                    labelPlayer1.Text = (lines[1]);
                                    labelPlayer2.Text = lines[2];
                                    labelPlayer3.Text = lines[3];

                                    string picP1Path = gamePath + @"\avatar1";
                                    string picP2Path = gamePath + @"\avatar2";
                                    string picP3Path = gamePath + @"\avatar3";
                                    if (File.Exists(picP1Path))
                                    {
                                        pictureBoxPlayer1.ImageLocation = picP1Path;
                                    }
                                    if (File.Exists(picP2Path))
                                    {
                                        pictureBoxPlayer2.ImageLocation = picP2Path;
                                    }
                                    if (File.Exists(picP3Path))
                                    {
                                        pictureBoxPlayer3.ImageLocation = picP3Path;
                                    }


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Delete this game,it's erro");
                                }

                            }
                            else if (lines[0] == "t1")
                            {

                            }

                            else if (lines[0] == "t2")
                            {

                            }
                            else if (lines[0] == "t3")
                            {

                            }

                            // break;

                        }



                    }
                    pictureBoxPlayer1.ImageLocation = null;
                    pictureBoxPlayer2.ImageLocation = null;
                    pictureBoxPlayer3.ImageLocation = null;
                    labelPlayer1.Text = "";
                    labelPlayer2.Text = "";
                    labelPlayer3.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Infinity");
                }



                return;
                
            }
        }
    }
}
