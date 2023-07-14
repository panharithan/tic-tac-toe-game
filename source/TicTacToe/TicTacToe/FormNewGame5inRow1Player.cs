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
    public partial class FormNewGame5inRow1Player : Form
    {
        DialogResult result;
        int clear = 0;
        public FormNewGame5inRow1Player()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          //  textBox1.BackColor = Color.Blue;
            textBox1.ForeColor = Color.Blue;
        }

        private void FormNewGame1Player_Load(object sender, EventArgs e)
        {
          

            Random rd = new Random();
            int picture = rd.Next(0, 16);
            clear = picture;
            rd = null;

            if (picture == 1)
            {
                pictureBox2.Image = Properties.Resources._1;
            }
            else if (picture == 2)
            {
                pictureBox2.Image = Properties.Resources._2;
            }
            else if (picture == 3)
            {
                pictureBox2.Image = Properties.Resources._3;
            }
            else if (picture == 4)
            {
                pictureBox2.Image = Properties.Resources._4;
            }
            else if (picture == 5)
            {
                pictureBox2.Image = Properties.Resources._5;
            }
            else if (picture == 6)
            {
                pictureBox2.Image = Properties.Resources._6;
            }
            else if (picture == 7)
            {
                pictureBox2.Image = Properties.Resources._7;
            }
            else if (picture == 8)
            {
                pictureBox2.Image = Properties.Resources._8;

            }
            else if (picture == 9)
            {
                pictureBox2.Image = Properties.Resources._9;
            }
            else if (picture == 10)
            {
                pictureBox2.Image = Properties.Resources._10;
            }
            else if (picture == 11)
            {
                pictureBox2.Image = Properties.Resources._11;
            }
            else if (picture == 12)
            {
                pictureBox2.Image = Properties.Resources._12;
            }
            else if (picture == 13)
            {
                pictureBox2.Image = Properties.Resources._13;
            }

            else if (picture == 14)
            {
                pictureBox2.Image = Properties.Resources._14;
            }

            else if (picture == 15)
            {
                pictureBox2.Image = Properties.Resources._15;
            }
            else
            {
                pictureBox2.Image = Properties.Resources._16;
            }



            
            
            
            this.BackColor = Color.LightYellow;
            this.textBox1.Focus();
        }

        private void panel1InFormNewGame1Player_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
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
               // pictureBox2.ImageLocation = dest;



                Image img = Image.FromFile(source);
               // imageList1.Images.Add(img);
                pictureBox2.Image = img;



                //   MessageBox.Show(openFileDialog1.FileName);
                //    pictureBox1.ImageLocation = openFileDialog1.FileName;
        /*        Image img = Image.FromFile(dest);// binary file >> array of byte . store in RAM.

                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                Byte[] imageByte = ms.ToArray();
                pictureBox1.Image = img;

                // to trea from MySQL
                MemoryStream mest = new MemoryStream(imageByte);
                Image NewImge = Image.FromStream(mest);

                */
            }




        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

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


            ResourceSet ress = new ResourceSet("userChoise.resx");
            string newgame = ress.GetString("choise");
            ress.Close();

            if (newgame == "c")
            {

                savePath = AppDomain.CurrentDomain.BaseDirectory + @"SaveGame";
                if (mode == "3")
                {
                    savePath = savePath + @"\3InArow" + @"\1Player";
                }
                else if (mode == "5")
                {
                    savePath = savePath + @"\5InArow" + @"\1Player";
                }
            }
            else if (newgame == "t")
            {
                savePath = AppDomain.CurrentDomain.BaseDirectory + @"SaveGameTimer";
                if (mode == "3")
                {
                    savePath = savePath + @"\3InArow" + @"\1Player";
                }
                else if (mode == "5")
                {
                    savePath = savePath + @"\5InArow" + @"\1Player";
                }

            }

            ResourceSet ResourceChoise = new ResourceSet("userChoise.resx");
            string play = ResourceChoise.GetString("choise");
            ResourceChoise.Close();
            //      MessageBox.Show(play);

            string temp = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\temp";
            if (!System.IO.Directory.Exists(temp))
            {
                System.IO.Directory.CreateDirectory(temp);
            }



            FileStream save = new FileStream
                                (temp + @"\save.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            string player1 = textBox1.Text;
            StreamWriter fw = new StreamWriter(save);
            fw.WriteLine(player1.ToString() + "\n");
            fw.Close();

            // now.... copy the image


            string source = openFileDialog1.FileName;


            string fileName = openFileDialog1.SafeFileName;
            string dest = temp + @"\avatar";


            pictureBox2.Image.Save(dest);

            save.Close();

            try
            {
                ResourceSet res = new ResourceSet("userChoise.resx");
                string previousChoise = res.GetString("choise");
                res.Close();
                previousChoise = previousChoise + "1";


                ResourceWriter rw = new ResourceWriter("userChoise.resx");
                rw.AddResource("choise", previousChoise);
                rw.Close();
                this.Close();

                FormPlayBoard FormPB = new FormPlayBoard();
                FormPB.Show();





            }// end of try

            catch
            {
                MessageBox.Show("Some problems occurs ! ", "Try again");

            }



        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            int picture = clear;

            if (picture == 1)
            {
                pictureBox2.Image = Properties.Resources._1;
            }
            else if (picture == 2)
            {
                pictureBox2.Image = Properties.Resources._2;
            }
            else if (picture == 3)
            {
                pictureBox2.Image = Properties.Resources._3;
            }
            else if (picture == 4)
            {
                pictureBox2.Image = Properties.Resources._4;
            }
            else if (picture == 5)
            {
                pictureBox2.Image = Properties.Resources._5;
            }
            else if (picture == 6)
            {
                pictureBox2.Image = Properties.Resources._6;
            }
            else if (picture == 7)
            {
                pictureBox2.Image = Properties.Resources._7;
            }
            else if (picture == 8)
            {
                pictureBox2.Image = Properties.Resources._8;

            }
            else if (picture == 9)
            {
                pictureBox2.Image = Properties.Resources._9;
            }
            else if (picture == 10)
            {
                pictureBox2.Image = Properties.Resources._10;
            }
            else if (picture == 11)
            {
                pictureBox2.Image = Properties.Resources._11;
            }
            else if (picture == 12)
            {
                pictureBox2.Image = Properties.Resources._12;
            }
            else if (picture == 13)
            {
                pictureBox2.Image = Properties.Resources._13;
            }

            else if (picture == 14)
            {
                pictureBox2.Image = Properties.Resources._14;
            }

            else if (picture == 15)
            {
                pictureBox2.Image = Properties.Resources._15;
            }
            else
            {
                pictureBox2.Image = Properties.Resources._16;
            }

            
            


        }

        private void FormNewGame5inRow1Player_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResourceWriter rw = new ResourceWriter("userChoise.resx");
            rw.AddResource("choise", "");
            rw.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
