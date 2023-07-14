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
    public partial class FormNewGame_typePlayer3InArow : Form
    {
        public FormNewGame_typePlayer3InArow()
        {
            InitializeComponent();
        }

        private void buttonBackInFormNewGame_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Remove(buttonBackInFormNewGame);
            FormNewGameChoosePlay form1 = new FormNewGameChoosePlay();
            //MessageBox.Show(form1.Controls.Count.ToString());
            // this.panel1.ControlRemoved();



            /*

            if (System.IO.File.Exists
                (@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\userchoise\userchoise.txt"))
            {
                // MessageBox.Show("Hey girl");
                // fileSetting = new FileStream(@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\userchoiseuserchoise.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                //  File.Delete(file);
                System.IO.File.Delete(
                    (@"D:\TicTacToe guide\TicTacToe\TicTacToe\TicTacToe\bin\Debug\userchoise\userchoise.txt"));
            }

            */









        }

        private void button1PlayerInNewGameForm_typePlayer3Inarow_Click(object sender, EventArgs e)
        {
            FormNewGame5inRow1Player theForm = new FormNewGame5inRow1Player();
            theForm.Visible = true;
        }

        private void button2PlayerInNewGameForm_typePlayer3inArow_Click(object sender, EventArgs e)
        {
            FormNewGame5InRow2Player theForm = new FormNewGame5InRow2Player();
            theForm.Visible = true;
        }
    }
}
