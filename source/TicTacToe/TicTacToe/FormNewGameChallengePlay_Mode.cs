using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FormNewGameChallengePlay_Mode : Form
    {
        public FormNewGameChallengePlay_Mode()
        {
            InitializeComponent();
        }

        private void FormNewGameChooseMode_Load(object sender, EventArgs e)
        {

        }

        private void buttonNewGame5InArow_Click(object sender, EventArgs e)
        {



        }

        private void button3InArowInFormNewGameMode_Click(object sender, EventArgs e)
        {

        }

        private void button5InArowInFormNewGameMode_Click(object sender, EventArgs e)
        {

            panel1.Controls.Remove(button5InArowInFormNewGameMode);
            FormNewGame_typePlayer5InArow form = new FormNewGame_typePlayer5InArow();
            

        for (int i = 0; i < form.Controls.Count; i++)
            {
                this.panel1.Controls.Add(form.Controls[i]);
            }

        }

    }
}
