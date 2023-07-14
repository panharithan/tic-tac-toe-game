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
namespace TicTacToe
{
    public partial class FormNewGame_typePlayer5InArow : Form
    {
        public FormNewGame_typePlayer5InArow()
        {
            InitializeComponent();
        }

        private void button1PlayerInNewGameForm_Click(object sender, EventArgs e)
        {

        }

        private void button1PlayerInNewGameForm_Click_1(object sender, EventArgs e)
        {
            FormNewGame5inRow1Player theForm = new FormNewGame5inRow1Player();
            theForm.Visible = true;
        }

        private void FormNewGame_Load(object sender, EventArgs e)
        {

        }

        private void button2PlayerInNewGameForm_Click(object sender, EventArgs e)
        {
            FormNewGame5InRow2Player theForm = new FormNewGame5InRow2Player();
            theForm.Visible = true;
        }

        private void button3PlayerInNewGameForm_Click(object sender, EventArgs e)
        {
            FormNewGame5inRow3Player theForm = new FormNewGame5inRow3Player();
            theForm.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBackInFormNewGame_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonBackkk_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Remove(buttonBackkk);
           
            FormNewGameChoosePlay form1 = new FormNewGameChoosePlay();
            //MessageBox.Show(form1.Controls.Count.ToString());
            // this.panel1.ControlRemoved();



            for (int i = 0; i < form1.Controls.Count; i++)
            {
                this.panel1.Controls.Add(form1.Controls[i]);




            }



            for (int i = 0; i < form1.Controls.Count; i++)
            {
                this.panel1.Controls.Add(form1.Controls[i]);
            }



        }
    }
}
