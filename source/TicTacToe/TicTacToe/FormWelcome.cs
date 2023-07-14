using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Resources;

namespace TicTacToe
{
    public partial class FormWelcome : Form
    {
        Thread H;
        public FormWelcome()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("DKFJKLFJ");

            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            labelPress.ForeColor = Color.FromArgb(A, R, G, B);

        }

        private void WellComeForm_Close(object sender, EventArgs e)
        {
            MessageBox.Show("AN");
        }

        private void WellComeForm_Load(object sender, EventArgs e)
        {
            
            panel2.Visible = false;
            labelTitle.Parent = pictureBox1;
            labelDeveloped.Parent = pictureBox1;
           // labelPowerBy.Parent = pictureBox1;
            labelPress.Parent = pictureBox1;

            labelTitle.BackColor = Color.Transparent;
            labelDeveloped.BackColor = Color.Transparent;
            //labelPowerBy.BackColor = Color.Transparent;
            this.BackColor = Color.LightYellow;
            timer1.Start();
            timer1.Enabled = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
            H = new Thread(OpenSecondForm);
            H.SetApartmentState(ApartmentState.STA);
            H.Start();
        }
           private void OpenSecondForm(object obj)
        {
           // Application.Run(new SecondForm());
        }

           private void pictureBox1_Click(object sender, EventArgs e)
           {

           }

           private void lbltitle_Click(object sender, EventArgs e)
           {

           }

           private void btnContinue_Click_1(object sender, EventArgs e)
           {

           }

           private void WellComeForm_KeyPress(object sender, KeyPressEventArgs e)
           {
             //ResXResourceSet resxSet = new ResXResourceSet("AppSetting.resx");
            
             //  MessageBox.Show(resxSet.GetString("Choise"));
              // resxSet.Close();
            //   pictureBox1.Visible = false;
               panel2.Visible = true;
               panel1.BackColor = Color.Transparent;
               panel1.ForeColor = Color.Transparent;
               labelPress.Hide();

         /*
               FormHome form1 = new FormHome();
               //MessageBox.Show(form1.Controls.Count.ToString());
              // this.panel1.ControlRemoved();



               for (int i = 0; i < form1.Controls.Count; i++)
               {
                   this.panel1.Controls.Add(form1.Controls[i]);
                



               }
                
               */
             //  pictureBox1.Image = global::TicTacToe.Properties.Resources._3;
               pictureBox1.Image = null;
               FormMainMenu formNewGamePlay = new FormMainMenu();
               for (int i = 0; i < formNewGamePlay.Controls.Count; i++)
               {
                   this.panel2.Controls.Add(formNewGamePlay.Controls[i]);
               }



           }

           private void FormWelcome_FormClosing(object sender, FormClosingEventArgs e)
           {

              
               ResourceWriter rw = new ResourceWriter("userChoise.resx");
               rw.AddResource("choise", "");
               rw.Close();

               Application.Exit();
           }

           private void labelDeveloped_Click(object sender, EventArgs e)
           {

           }

           private void timer1_Tick_1(object sender, EventArgs e)
           {
               Random rand = new Random();
               int A = rand.Next(0, 0);
               int R = rand.Next(0, 0);
               int G = rand.Next(0, 255);
               int B = rand.Next(0, 255);
              labelPress.ForeColor = Color.FromArgb(A ,R,G,B);
             //  labelPress.ForeColor = Color.Black;
            //   labelPress.ForeColor = Color.White;
           }

    }
}
