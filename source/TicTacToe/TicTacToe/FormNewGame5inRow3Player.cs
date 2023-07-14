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
    public partial class FormNewGame5inRow3Player : Form
    {
        int clear1 = 0;
        int clear2 = 0;
        int clear3 = 0;
        public FormNewGame5inRow3Player()
        {
            InitializeComponent();
        }

        private void textBoxPlayer1_TextChanged(object sender, EventArgs e)
        {
            textBoxPlayer1.ForeColor = Color.Blue;
        }

        private void textBoxPlayer2_TextChanged(object sender, EventArgs e)
        {
            textBoxPlayer1.ForeColor = Color.Red;

        }

        private void textBoxPlayer3_TextChanged(object sender, EventArgs e)
        {
            textBoxPlayer1.ForeColor = Color.Black;

        }

        private void panel1InFormNewGame1Player_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }

        private void FormNewGame5inRow3Player_Load(object sender, EventArgs e)
        {
            this.textBoxPlayer1.Focus();

            //MessageBox.Show("Hell0");
            Random rd = new Random();
            int picture1 = rd.Next(0, 16);
            clear1 = picture1;
            //clear = picture;
            int picture2 = rd.Next(0, 16);
            clear2 = picture2;
            int picture3 = rd.Next(0, 16);
            rd = null;

            /*  do
              {
                  picture2 = rd.Next(1, 16);
                  if (picture2 != picture1) break;
              }
              while (picture2 == picture1);
  */
            // InitPictureboxPlayer1(picture1);
            // InitPictureboxPlayer2(picture2);
            /*
                        while (true)
                        {
                            picture2 = rd.Next(1, 16);

                            if (picture2 != picture1) break;

                        }
                        */


            ///MessageBox.Show(picture1.ToString());
            //  MessageBox.Show(picture2.ToString());
            if (picture1 == 1)
            {
                pictureBox2.Image = Properties.Resources._1;
            }
            else if (picture1 == 2)
            {
                pictureBox2.Image = Properties.Resources._2;
            }
            else if (picture1 == 3)
            {
                pictureBox2.Image = Properties.Resources._3;
            }
            else if (picture1 == 4)
            {
                pictureBox2.Image = Properties.Resources._4;
            }
            else if (picture1 == 5)
            {
                pictureBox2.Image = Properties.Resources._5;
            }
            else if (picture1 == 6)
            {
                pictureBox2.Image = Properties.Resources._6;
            }
            else if (picture1 == 7)
            {
                pictureBox2.Image = Properties.Resources._7;
            }
            else if (picture1 == 8)
            {
                pictureBox2.Image = Properties.Resources._8;

            }
            else if (picture1 == 9)
            {
                pictureBox2.Image = Properties.Resources._9;
            }
            else if (picture1 == 10)
            {
                pictureBox2.Image = Properties.Resources._10;
            }
            else if (picture1 == 11)
            {
                pictureBox2.Image = Properties.Resources._11;
            }
            else if (picture1 == 12)
            {
                pictureBox2.Image = Properties.Resources._12;
            }
            else if (picture1 == 13)
            {
                pictureBox2.Image = Properties.Resources._13;
            }

            else if (picture1 == 14)
            {
                pictureBox2.Image = Properties.Resources._14;
            }

            else if (picture1 == 15)
            {
                pictureBox2.Image = Properties.Resources._15;
            }
            else
            {
                pictureBox2.Image = Properties.Resources._16;
            }




            if (picture2 == 1)
            {
                pictureBox3.Image = Properties.Resources._1;
            }
            else if (picture2 == 2)
            {
                pictureBox3.Image = Properties.Resources._2;
            }
            else if (picture2 == 3)
            {
                pictureBox3.Image = Properties.Resources._3;
            }
            else if (picture2 == 4)
            {
                pictureBox3.Image = Properties.Resources._4;
            }
            else if (picture2 == 5)
            {
                pictureBox3.Image = Properties.Resources._5;
            }
            else if (picture2 == 6)
            {
                pictureBox3.Image = Properties.Resources._6;
            }
            else if (picture2 == 7)
            {
                pictureBox3.Image = Properties.Resources._7;
            }
            else if (picture2 == 8)
            {
                pictureBox3.Image = Properties.Resources._8;

            }
            else if (picture2 == 9)
            {
                pictureBox3.Image = Properties.Resources._9;
            }
            else if (picture2 == 10)
            {
                pictureBox3.Image = Properties.Resources._10;
            }
            else if (picture2 == 11)
            {
                pictureBox3.Image = Properties.Resources._11;
            }
            else if (picture2 == 12)
            {
                pictureBox3.Image = Properties.Resources._12;
            }
            else if (picture2 == 13)
            {
                pictureBox3.Image = Properties.Resources._13;
            }

            else if (picture2 == 14)
            {
                pictureBox3.Image = Properties.Resources._14;
            }

            else if (picture2 == 15)
            {
                pictureBox3.Image = Properties.Resources._15;
            }
            else
            {
                pictureBox3.Image = Properties.Resources._16;
            }




            if (picture3 == 1)
            {
                pictureBox4.Image = Properties.Resources._1;
            }
            else if (picture3 == 2)
            {
                pictureBox4.Image = Properties.Resources._2;
            }
            else if (picture3 == 3)
            {
                pictureBox4.Image = Properties.Resources._3;
            }
            else if (picture3 == 4)
            {
                pictureBox4.Image = Properties.Resources._4;
            }
            else if (picture3 == 5)
            {
                pictureBox4.Image = Properties.Resources._5;
            }
            else if (picture3 == 6)
            {
                pictureBox4.Image = Properties.Resources._6;
            }
            else if (picture3 == 7)
            {
                pictureBox4.Image = Properties.Resources._7;
            }
            else if (picture3 == 8)
            {
                pictureBox4.Image = Properties.Resources._8;

            }
            else if (picture3 == 9)
            {
                pictureBox4.Image = Properties.Resources._9;
            }
            else if (picture3 == 10)
            {
                pictureBox4.Image = Properties.Resources._10;
            }
            else if (picture3 == 11)
            {
                pictureBox4.Image = Properties.Resources._11;
            }
            else if (picture3 == 12)
            {
                pictureBox4.Image = Properties.Resources._12;
            }
            else if (picture3 == 13)
            {
                pictureBox4.Image = Properties.Resources._13;
            }

            else if (picture3 == 14)
            {
                pictureBox4.Image = Properties.Resources._14;
            }

            else if (picture3 == 15)
            {
                pictureBox4.Image = Properties.Resources._15;
            }
            else
            {
                pictureBox4.Image = Properties.Resources._16;
            }








        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxPlayer2.ForeColor = Color.Red;

        }

        private void textBoxPlayer3_TextChanged_1(object sender, EventArgs e)
        {
            textBoxPlayer3.ForeColor = Color.Black;
        }

        private void buttonPlayInFormNewGame1Player_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"loadGame"))
            {
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"loadGame");
            }

            // find a directory to save
            ResourceSet rs = new ResourceSet("SettingChoise.resx");
            string mode = rs.GetString("mode");
            string level = rs.GetString("level");
            rs.Close();

            string savePath = "";
            ResourceSet reso = new ResourceSet("userChoise.resx");
            string newgame = reso.GetString("choise");
            reso.Close();

            if (newgame == "c")
            {
                savePath = AppDomain.CurrentDomain.BaseDirectory + @"SaveGame";
                if (mode == "3")
                {
                    savePath = savePath + @"\3InArow" + @"\3Player";
                }
                else if (mode == "5")
                {
                    savePath = savePath + @"\5InArow" + @"\3Player";
                }
            }
            else if (newgame == "t")
            {
                savePath = AppDomain.CurrentDomain.BaseDirectory + @"SaveGameTimer";
                if (mode == "3")
                {
                    savePath = savePath + @"\3InArow" + @"\3Player";
                }
                else if (mode == "5")
                {
                    savePath = savePath + @"\5InArow" + @"\3Player";
                }
            }
            /*
            ResourceSet ress = new ResourceSet("userChoise.resx");
            string play = ress.GetString("choise");
            ress.Close();
            */
            //    MessageBox.Show(savePath+ @"\save1\save.txt");





            string temp = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\temp";
            if (!System.IO.Directory.Exists(temp))
            {
                System.IO.Directory.CreateDirectory(temp);
            }


            FileStream save = new FileStream
                                (temp + @"\save.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);





            string player1 = textBoxPlayer1.Text;
            string player2 = textBoxPlayer2.Text;
            string player3 = textBoxPlayer3.Text;
            StreamWriter fw = new StreamWriter(save);
            fw.WriteLine(player1.ToString() + "\n");
            fw.WriteLine(player2.ToString() + "\n");
            fw.WriteLine(player3.ToString() + "\n");
            fw.Close();

            // now.... copy the image
            string source1 = openFileDialog1.FileName;
            string fileName1 = openFileDialog1.SafeFileName;
            string dest1 = temp + @"\avatar1";
            //       Directory.GetFiles("path"); >>>>>> return string as the number of the object in the directory.
            pictureBox2.Image.Save(dest1);

            string source2 = openFileDialog2.FileName;
            string fileName2 = openFileDialog2.SafeFileName;
            string dest2 = temp + @"\avatar2";


            pictureBox3.Image.Save(dest2);

            string source3 = openFileDialog3.FileName;
            string dest3 = temp + @"\avatar3";
            pictureBox4.Image.Save(dest3);

            try
            {

                ResourceSet res = new ResourceSet("userChoise.resx");
                string previousChoise = res.GetString("choise");
                res.Close();
                previousChoise = previousChoise + "3";
                //    MessageBox.Show(":"+previousChoise);
                ResourceWriter rw = new ResourceWriter("userChoise.resx");
                rw.AddResource("choise", previousChoise);
                rw.Close();

                this.Close();

                FormPlayBoard FormPB = new FormPlayBoard();
                FormPB.Show();
                return;

            }// end of try

            catch
            {
                MessageBox.Show("Some problems occurs ! ", "Try again");
            }

        }

        private void buttonBrowsePlayer1_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {

                string source = openFileDialog1.FileName;
                string fileName = openFileDialog1.SafeFileName;
                // MessageBox.Show(fileName);
                string dest = AppDomain.CurrentDomain.BaseDirectory
                                     + "\\SaveGame\\"
                    //  + "\\images\\"
                    //   + "\\images\\" 
                    + fileName;
                //       Directory.GetFiles("path"); >>>>>> return string as the number of the object in the directory.
                //    File.Copy(source, dest, true);
             //   pictureBox2.ImageLocation = dest;
                Image img = Image.FromFile(source);
                pictureBox2.Image = img;
            }
        }

        private void buttonBrowsePlayer2_Click(object sender, EventArgs e)
        {
             DialogResult result = openFileDialog2.ShowDialog();
             if (result == System.Windows.Forms.DialogResult.OK)
             {

                 string source = openFileDialog2.FileName;
                 string fileName = openFileDialog2.SafeFileName;
                 // MessageBox.Show(fileName);
                 string dest = AppDomain.CurrentDomain.BaseDirectory
                                      + "\\SaveGame\\"
                     //  + "\\images\\"
                     //   + "\\images\\" 
                     + fileName;
                 //       Directory.GetFiles("path"); >>>>>> return string as the number of the object in the directory.
                 //    File.Copy(source, dest, true);
              //   pictureBox3.ImageLocation = dest;
                 Image img = Image.FromFile(source);
                 pictureBox3.Image = img;
             }
        }

        private void buttonBrowserPlayer3_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog3.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {

                string source = openFileDialog3.FileName;
                string fileName = openFileDialog3.SafeFileName;
                // MessageBox.Show(fileName);
                string dest = AppDomain.CurrentDomain.BaseDirectory
                                     + "\\SaveGame\\"
                    //  + "\\images\\"
                    //   + "\\images\\" 
                    + fileName;
                //       Directory.GetFiles("path"); >>>>>> return string as the number of the object in the directory.
                //    File.Copy(source, dest, true);
              //  pictureBox4.ImageLocation = dest;
                Image img = Image.FromFile(source);
                pictureBox4.Image = img;
            }
        }

        private void buttonClear1_Click(object sender, EventArgs e)
        {
            if (clear1 == 1)
            {
                pictureBox2.Image = Properties.Resources._1;
            }
            else if (clear1 == 2)
            {
                pictureBox2.Image = Properties.Resources._2;
            }
            else if (clear1 == 3)
            {
                pictureBox2.Image = Properties.Resources._3;
            }
            else if (clear1 == 4)
            {
                pictureBox2.Image = Properties.Resources._4;
            }
            else if (clear1 == 5)
            {
                pictureBox2.Image = Properties.Resources._5;
            }
            else if (clear1 == 6)
            {
                pictureBox2.Image = Properties.Resources._6;
            }
            else if (clear1 == 7)
            {
                pictureBox2.Image = Properties.Resources._7;
            }
            else if (clear1 == 8)
            {
                pictureBox2.Image = Properties.Resources._8;

            }
            else if (clear1 == 9)
            {
                pictureBox2.Image = Properties.Resources._9;
            }
            else if (clear1 == 10)
            {
                pictureBox2.Image = Properties.Resources._10;
            }
            else if (clear1 == 11)
            {
                pictureBox2.Image = Properties.Resources._11;
            }
            else if (clear1 == 12)
            {
                pictureBox2.Image = Properties.Resources._12;
            }
            else if (clear1 == 13)
            {
                pictureBox2.Image = Properties.Resources._13;
            }

            else if (clear1 == 14)
            {
                pictureBox2.Image = Properties.Resources._14;
            }

            else if (clear1 == 15)
            {
                pictureBox2.Image = Properties.Resources._15;
            }
            else
            {
                pictureBox2.Image = Properties.Resources._16;
            }

        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {
            if (clear2 == 1)
            {
                pictureBox3.Image = Properties.Resources._1;
            }
            else if (clear2 == 2)
            {
                pictureBox3.Image = Properties.Resources._2;
            }
            else if (clear2 == 3)
            {
                pictureBox3.Image = Properties.Resources._3;
            }
            else if (clear2 == 4)
            {
                pictureBox3.Image = Properties.Resources._4;
            }
            else if (clear2 == 5)
            {
                pictureBox3.Image = Properties.Resources._5;
            }
            else if (clear2 == 6)
            {
                pictureBox3.Image = Properties.Resources._6;
            }
            else if (clear2 == 7)
            {
                pictureBox3.Image = Properties.Resources._7;
            }
            else if (clear2 == 8)
            {
                pictureBox3.Image = Properties.Resources._8;

            }
            else if (clear2 == 9)
            {
                pictureBox3.Image = Properties.Resources._9;
            }
            else if (clear2 == 10)
            {
                pictureBox3.Image = Properties.Resources._10;
            }
            else if (clear2 == 11)
            {
                pictureBox3.Image = Properties.Resources._11;
            }
            else if (clear2 == 12)
            {
                pictureBox3.Image = Properties.Resources._12;
            }
            else if (clear2 == 13)
            {
                pictureBox3.Image = Properties.Resources._13;
            }

            else if (clear2 == 14)
            {
                pictureBox3.Image = Properties.Resources._14;
            }

            else if (clear2 == 15)
            {
                pictureBox3.Image = Properties.Resources._15;
            }
            else
            {
                pictureBox3.Image = Properties.Resources._16;
            }

        }

        private void buttonClear3_Click(object sender, EventArgs e)
        {
            if (clear3 == 1)
            {
                pictureBox4.Image = Properties.Resources._1;
            }
            else if (clear3 == 2)
            {
                pictureBox4.Image = Properties.Resources._2;
            }
            else if (clear3 == 3)
            {
                pictureBox4.Image = Properties.Resources._3;
            }
            else if (clear3 == 4)
            {
                pictureBox4.Image = Properties.Resources._4;
            }
            else if (clear3 == 5)
            {
                pictureBox4.Image = Properties.Resources._5;
            }
            else if (clear3 == 6)
            {
                pictureBox4.Image = Properties.Resources._6;
            }
            else if (clear3 == 7)
            {
                pictureBox4.Image = Properties.Resources._7;
            }
            else if (clear3 == 8)
            {
                pictureBox4.Image = Properties.Resources._8;

            }
            else if (clear3 == 9)
            {
                pictureBox4.Image = Properties.Resources._9;
            }
            else if (clear3 == 10)
            {
                pictureBox4.Image = Properties.Resources._10;
            }
            else if (clear3 == 11)
            {
                pictureBox4.Image = Properties.Resources._11;
            }
            else if (clear3 == 12)
            {
                pictureBox4.Image = Properties.Resources._12;
            }
            else if (clear3 == 13)
            {
                pictureBox4.Image = Properties.Resources._13;
            }

            else if (clear3 == 14)
            {
                pictureBox4.Image = Properties.Resources._14;
            }

            else if (clear3 == 15)
            {
                pictureBox4.Image = Properties.Resources._15;
            }
            else
            {
                pictureBox4.Image = Properties.Resources._16;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
