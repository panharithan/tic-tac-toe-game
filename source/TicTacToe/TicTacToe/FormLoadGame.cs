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
    public partial class FormLoadGame : Form
    {
        public FormLoadGame()
        {
            InitializeComponent();
        }

        private void FormLoadGame_Load(object sender, EventArgs e) 
        {
            //MessageBox.Show("The boy");
           // int size = System.IO.Directory.
            pictureBoxPlayer1.Visible = false;
            pictureBoxPlayer2.Visible = false;
            pictureBoxPlayer3.Visible = false;
            labelPlayer1.Visible = false;
            labelPlayer2.Visible = false;
            labelPlayer3.Visible = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                int index = listView1.SelectedIndices[0];

                ListViewItem selectedItem = listView1.SelectedItems[0];
                int imageIndex = selectedItem.ImageIndex;

                int theGameIndex = index + 1;

                string game = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame" + theGameIndex.ToString();
                //MessageBox.Show(game);
               
                string infoSaveFile = game + @"\info.txt";
                //MessageBox.Show(infoSaveFile);
                //return;
                if (File.Exists(infoSaveFile))
                {
                    //ResourceSet rs = new ResourceSet(infoSaveFile);
                   // string mode = rs.GetString("mode");
                   // string level = rs.GetString("level");
                  
                 //   rs.Close();
                    //  int numDir = Directory.GetDirectories(loadGameDir).Length;

                    string loadGame = @"\loadGame";
                    
                    // 1
                    // Declare new List.
                    List<string> lines = new List<string>();
                    // 2
                    // Use using StreamReader for disposing.

                    using (StreamReader r = new StreamReader(infoSaveFile))
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
                    MessageBox.Show(lines[0].ToString());
                    if (lines[0]=="c1")
                    {
//MessageBox.Show("Hey");
                        //listView2.Show();
                    }



                    //-------------------------------------------------------------------------
                }
                else if (!File.Exists(infoSaveFile))
                {
                    MessageBox.Show(infoSaveFile);
                    MessageBox.Show("File is not found!");
                }




                // MessageBox.Show(index.ToString());


                // Image img = imageList1.Images[imageIndex];

                // pictureBox1.Image = img;
                // pictureBox1.ImageLocation = null;
            }
            else
            {
               // buttonDelete.Enabled = false;
            }
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
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
                    for (int i = 1; i <= numDir-1; ++i)
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
                                pictureBoxPlayer1.Visible = false;
                                pictureBoxPlayer2.Visible = false;
                                pictureBoxPlayer3.Visible = false;
                                labelPlayer1.Visible = false;
                                labelPlayer2.Visible = false;
                                labelPlayer3.Visible = false;


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

  /*                              ListViewItem lv2 = new ListViewItem(lines[3]);
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
                                pictureBoxPlayer1.Visible = false;
                                pictureBoxPlayer2.Visible = false;
                                pictureBoxPlayer3.Visible = false;
                                labelPlayer1.Visible = false;
                                labelPlayer2.Visible = false;
                                labelPlayer3.Visible = false;

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
/*
                                ListViewItem lv2 = new ListViewItem(lines[3]);
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
                                pictureBoxPlayer1.Visible = false;
                                pictureBoxPlayer2.Visible = false;
                                pictureBoxPlayer3.Visible = false;
                                labelPlayer1.Visible = false;
                                labelPlayer2.Visible = false;
                                labelPlayer3.Visible = false;

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


                                drawNum = totalBoard - xWins - oWins-plusWins;
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

               /*                 ListViewItem lv2 = new ListViewItem(lines[4]);
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
            }
            catch (Exception ex)
           {
                MessageBox.Show("Infinity");
            }


        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void buttonHighscoreInForMainMenu_Click(object sender, EventArgs e)
        {
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
                    for (int i = 1; i <= numDir - 1; ++i)
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

                pictureBoxPlayer1.Visible = false;
                pictureBoxPlayer2.Visible = false;
                pictureBoxPlayer3.Visible = false;
                labelPlayer1.Visible = false;
                labelPlayer2.Visible = false;
                labelPlayer3.Visible = false;
                //listView2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Infinity");
            }


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {


            if (listView1.SelectedItems.Count > 0)
            {

                int index = listView1.SelectedIndices[0];

                ListViewItem selectedItem = listView1.SelectedItems[0];
                int imageIndex = selectedItem.ImageIndex;

                int theGameIndex = index + 1;

                string game = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame" + theGameIndex.ToString();
                //MessageBox.Show(game);

                string infoSaveFile = game + @"\info.txt";
                MessageBox.Show(game);
                return;
                if (File.Exists(infoSaveFile))
                {
                    //ResourceSet rs = new ResourceSet(infoSaveFile);
                    // string mode = rs.GetString("mode");
                    // string level = rs.GetString("level");

                    //   rs.Close();
                    //  int numDir = Directory.GetDirectories(loadGameDir).Length;

                    string loadGame = @"\loadGame";

                    // 1
                    // Declare new List.
                    List<string> lines = new List<string>();
                    // 2
                    // Use using StreamReader for disposing.

                    using (StreamReader r = new StreamReader(infoSaveFile))
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
                    MessageBox.Show(lines[0].ToString());
                    if (lines[0] == "c1")
                    {
                        //MessageBox.Show("Hey");
                        //listView2.Show();
                    }



                    //-------------------------------------------------------------------------
                }
                else if (!File.Exists(infoSaveFile))
                {
                    MessageBox.Show(infoSaveFile);
                    MessageBox.Show("File is not found!");
                }




                // MessageBox.Show(index.ToString());


                // Image img = imageList1.Images[imageIndex];

                // pictureBox1.Image = img;
                // pictureBox1.ImageLocation = null;
            }
        }
    }
}
