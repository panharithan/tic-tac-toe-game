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
    public partial class FormSaveReplace : Form
    {
        string saveLoc = AppDomain.CurrentDomain.BaseDirectory;




        public FormSaveReplace()
        {
            InitializeComponent();
        }

        private void FormSaveReplace_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            labelPlayer1.Visible = false;
            labelPlayer2.Visible = false;
            labelPlayer3.Visible = false;
          




          //  Image img = Image.FromFile(path);

            Image img1 = Properties.Resources._4;
            Image img2 = Properties.Resources._5;
            Image img3 = Properties.Resources._7;
            Image img4 = Properties.Resources._8;
            Image img5 = Properties.Resources._11;

            imageList1.Images.Add(img1);
            imageList1.Images.Add(img2);
            imageList1.Images.Add(img3);
            imageList1.Images.Add(img4);
            imageList1.Images.Add(img5);


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







            ListViewItem item = new ListViewItem();
            item.ImageIndex = imageList1.Images.Count - 1;
          //  item.Text = fileName;
            listView1.Items.Add(item);


            ResourceSet resou = new ResourceSet("userChoise.resx");
            string userPlay = resou.GetString("choise");
            resou.Close();


            if (userPlay == "c1")
            {
               // Challenge1();
                pictureBox1.Visible = true;
                labelPlayer1.Visible = true;
                saveLoc = saveLoc + @"";
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
               // Timer1();
            }
            else if (userPlay == "t2")
            {
               // Timer2();

            }

            else if (userPlay == "t1")
            {
               // Timer3();

            }








        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                buttonSaveReplace.Enabled = true;
                int index = listView1.SelectedIndices[0];

                ListViewItem selectedItem = listView1.SelectedItems[0];
                int imageIndex = selectedItem.ImageIndex;
                Image img = imageList1.Images[imageIndex];

               // pictureBox1.Image = img;
                //pictureBox1.ImageLocation = null;
            }
            else
            {
                buttonSaveReplace.Enabled = false;
            }
        }

        private void buttonSaveReplace_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Replace and save confirm !", "Save and replace !", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {



                int index = listView1.SelectedIndices[0];// 
                int i = index + 1;
                if (i == 1) // save 1 is selected
                {

                }





              //  listView1.Items.RemoveAt(index);
              //  imageList1.Images.RemoveAt(index);

               // pictureBox1.ImageLocation = null;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
