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
    public partial class FormSetting : Form
    {
        public string mode = "";
        public int level = 1;

        
        public FormSetting()
        {
            InitializeComponent();
          

        }
        public FormSetting(bool choosingMode , int level)
        {
            InitializeComponent();
            
           

        }

        public void init()
        {
           
            string choise = "";

            ResourceSet rs = new ResourceSet("SettingChoise.resx");
            choise = rs.GetString("mode");
            if (choise == "3")
            {
                radioButton3InArow.Select();


                string levell = rs.GetString("level");
                if (levell == "1" || levell == "2" || levell == "3" )
                {
                    comboBox1.Text = "Level " + levell;

                }
                rs.Close();
                return;
            

            }

            else if (choise == "5")
            {
                radioButton5InArow.Select();

            
            }

            string level = rs.GetString("level");
            if (level == "1" || level == "2" || level == "3" || level == "4" || level == "5" || level == "6")
            {
                comboBox1.Text = "Level " + level;

            }
            rs.Close();


        
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            radioButton3InArow.Visible = false;
          
           init();            

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton5InArow_CheckedChanged(object sender, EventArgs e)
        {
            mode = "5";
        }

        private void radioButton3InArow_CheckedChanged(object sender, EventArgs e)
        {
            mode = "3";

            
        }

        private void buttonAcceptInFormSetting_Click(object sender, EventArgs e)
        {

            if (radioButton3InArow.Checked == true)
            {
                mode = "3";
               
            }
            else
            {

                mode = "5";

            }

            string levelText = comboBox1.Text.ToString();

            if (levelText == "Level 1")
            {
                level = 1;
            
            }
           else if (levelText == "Level 2")
            {
                level = 2;


            }
            else if (levelText == "Level 3")
            {
                level = 3;


            }
            else if (levelText == "Level 4")
            {
                level = 4;


            }
            else if (levelText == "Level 5")
            {

                level = 5;

            }
            else if (levelText == "Level 6")
            {

                level = 6;

            }

            ResourceWriter rw = new ResourceWriter("SettingChoise.resx");
            rw.AddResource("mode", mode);
            rw.AddResource("level", level.ToString());
            rw.Close();

            this.Close();


       }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
