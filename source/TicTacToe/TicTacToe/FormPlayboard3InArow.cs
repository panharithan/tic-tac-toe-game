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
    public partial class FormPlayboard3InArow : Form
    {
        //#########################################################################################################
        int AILevel = 6;
        int boardNumber = 1; int theTurn = 1;
        int AI1stTurn = 1;
        bool isXturn = true;

        bool btn1IsAlreadyClicked = false;
        bool btn2IsAlreadyClicked = false;
        bool btn3IsAlreadyClicked = false;
        bool btn4IsAlreadyClicked = false;
        bool btn5IsAlreadyClicked = false;
        bool btn6IsAlreadyClicked = false;
        bool btn7IsAlreadyClicked = false;
        bool btn8IsAlreadyClicked = false;
        bool btn9IsAlreadyClicked = false;

        int[] boardIsTie = new int[10];
        Single[] Movement = new Single[10];
        bool is2PlayerMode = true;

        bool xFirstMove = true;

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        bool used23 = false;
        bool used13 = false;
        bool used12 = false;

        bool used56 = false;
        bool used46 = false;
        bool used45 = false;

        bool used89 = false;
        bool used79 = false;
        bool used78 = false;

        bool used47 = false;
        bool used17 = false;
        bool used14 = false;

        bool used58 = false;
        bool used28 = false;
        bool used25 = false;

        bool used69 = false;
        bool used39 = false;
        bool used36 = false;

        bool used59 = false;
        bool used19 = false;
        bool used15 = false;

        bool used75 = false;
        bool used73 = false;
        bool used53 = false;

        bool soundOn = true;

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //#########################################################################################################//

        int suffle()
        {
            /*
            int[] numbers = new int[5] { 32, 67, 88, 13, 50 };
            Random rd = new Random();
            int randomIndex = rd.Next(0, 5);
            int randomNumber = numbers[randomIndex];
            return randomNumber;
            */
            int[] numbers = new int[4] { 1, 3, 7, 9 };
            Random rd = new Random();
            int first = rd.Next(0, 4);




            int randomNumber = numbers[first];
            rd = null;
            return randomNumber;
        }




        public FormPlayboard3InArow()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPlayboard3InArow_Load(object sender, EventArgs e)
        {

            string choise = "";

            ResourceSet rs = new ResourceSet("SettingChoise.resx");
            choise = rs.GetString("mode");
          
            string level = rs.GetString("level");
                
            if (level=="1")
            {
                AILevel = 1;
            }
            else if (level == "2")
            {
                AILevel = 2;
            }
            else if (level == "3")
            {
                AILevel = 3;
            }
            else if (level == "4")
            {
                AILevel = 4;
            }
            else if (level == "5")
            {
                AILevel = 5;
            }
            else if (level == "6")
            {
                AILevel = 6;
            }
            rs.Close();





            Label1.Visible = false;
            LabelAImove.Visible = false;
            ButtonSound.Visible = false;
            
            labelBoardNumber.Text = labelBoardNumber.Text + (" 1");
            LabelAImove.Text = suffle().ToString();
            // Me.BackColor = Color.Gold
            Movement[1] = 0;
            Movement[2] = 0;
            Movement[3] = 0;
            Movement[4] = 0;
            Movement[5] = 0;
            Movement[6] = 0;
            Movement[7] = 0;
            Movement[8] = 0;
            Movement[9] = 0;
            LabelVictory.Text = ("");
            isXturn = true;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (btn1IsAlreadyClicked == true)
                return;
            //------------------------------------------------------------------------------------
            if (is2PlayerMode == false) //  call to AI function
            {
                if ((AI1stTurn == 1) && (boardNumber % 2 == 0))
                {
                    AI1stTurn++;
                    AIMovement();
                }

                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");
                Button1.ForeColor = Color.Blue;
                Button1.Text = ("x");
                isXturn = false;
                btn1IsAlreadyClicked = true;
                Movement[1] = 1;
                boardIsTie[1] = 1;
                DetectWinner();
                IsTie();
                if (IsTie())
                {
                    return;
                }

                AIMovement();
                return;
            }
            //--------------------------------
            //' These below codes are 2 player mode
            // theTurn =theTurn + boardNumber % 2;
            if ((theTurn == 1) && (boardNumber % 2 == 1))
            {
                isXturn = true;
                theTurn++;
            }

            else if ((theTurn == 1) && (boardNumber % 2 == 0))
            {
                isXturn = false;
                theTurn++;

            }
            //--------------------------------------
            if (isXturn == true)
            {
                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button1.ForeColor = Color.Blue;
                Button1.Text = ("x");
                isXturn = false;
                btn1IsAlreadyClicked = true;
                Movement[1] = 1;
                boardIsTie[1] = 1;
                DetectWinner();
                IsTie();
                return;
            }

            LabelTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.Text = ("x");

            Button1.ForeColor = Color.Red;
            Button1.Text = ("o");
            isXturn = true;
            btn1IsAlreadyClicked = true;
            Movement[1] = -1;
            boardIsTie[1] = 1;

            DetectWinner();
            IsTie();

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (btn2IsAlreadyClicked == true)
                return;
            //------------------------------------------------------------------------------------
            if (is2PlayerMode == false) //  call to AI function
            {
                if ((AI1stTurn == 1) && (boardNumber % 2 == 0))
                {
                    AI1stTurn++;
                    AIMovement();
                }


                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button2.ForeColor = Color.Blue;
                Button2.Text = ("x");
                isXturn = false;
                btn2IsAlreadyClicked = true;
                Movement[2] = 1;
                boardIsTie[2] = 1;
                DetectWinner();
                IsTie();

                if (IsTie())
                {
                    return;
                }
                AIMovement();
                return;
            }


            //' These below codes are 2 player mode
            if ((theTurn == 1) && (boardNumber % 2 == 1))
            {
                isXturn = true;
                theTurn++;
            }
            else if ((theTurn == 1) && (boardNumber % 2 == 0))
            {
                isXturn = false;
                theTurn++;
            }

            //-----------------------------------
            if (isXturn == true)
            {
                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button2.ForeColor = Color.Blue;
                Button2.Text = ("x");
                isXturn = false;
                btn2IsAlreadyClicked = true;
                Movement[2] = 1;
                boardIsTie[2] = 1;
                DetectWinner();
                IsTie();
                return;
            }

            LabelTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.Text = ("x");

            Button2.ForeColor = Color.Red;
            Button2.Text = ("o");
            isXturn = true;
            btn2IsAlreadyClicked = true;
            Movement[2] = -1;
            boardIsTie[2] = 1;

            DetectWinner();
            IsTie();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (btn3IsAlreadyClicked == true)
                return;
            //------------------------------------------------------------------------------------
            if (is2PlayerMode == false) //  call to AI function
            {
                if ((AI1stTurn == 1) && (boardNumber % 2 == 0))
                {
                    AI1stTurn++;
                    AIMovement();
                }


                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button3.ForeColor = Color.Blue;
                Button3.Text = ("x");
                isXturn = false;
                btn3IsAlreadyClicked = true;
                Movement[3] = 1;
                boardIsTie[3] = 1;
                DetectWinner();
                IsTie();

                if (IsTie())
                {
                    return;
                }
                AIMovement();
                return;
            }

            //' These below codes are 2 player mode
            if ((theTurn == 1) && (boardNumber % 2 == 1))
            {
                isXturn = true;
                theTurn++;
            }
            else if ((theTurn == 1) && (boardNumber % 2 == 0))
            {
                isXturn = false;
                theTurn++;
            }

            //------------------------------
            if (isXturn == true)
            {
                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button3.ForeColor = Color.Blue;
                Button3.Text = ("x");
                isXturn = false;
                btn3IsAlreadyClicked = true;
                Movement[3] = 1;
                boardIsTie[3] = 1;
                DetectWinner();
                IsTie();
                return;
            }

            LabelTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.Text = ("x");

            Button3.ForeColor = Color.Red;
            Button3.Text = ("o");
            isXturn = true;
            btn3IsAlreadyClicked = true;
            Movement[3] = -1;
            boardIsTie[3] = 1;

            DetectWinner();
            IsTie();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (btn4IsAlreadyClicked == true)
                return;
            //------------------------------------------------------------------------------------
            if (is2PlayerMode == false) //  call to AI function
            {
                if ((AI1stTurn == 1) && (boardNumber % 2 == 0))
                {
                    AI1stTurn++;
                    AIMovement();
                }


                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button4.ForeColor = Color.Blue;
                Button4.Text = ("x");
                isXturn = false;
                btn4IsAlreadyClicked = true;
                Movement[4] = 1;
                boardIsTie[4] = 1;
                DetectWinner();
                IsTie();
                if (IsTie())
                {
                    return;
                }

                AIMovement();
                return;
            }


            //' These below codes are 2 player mode
            if ((theTurn == 1) && (boardNumber % 2 == 1))
            {
                isXturn = true;
                theTurn++;
            }
            else if ((theTurn == 1) && (boardNumber % 2 == 0))
            {
                isXturn = false;
                theTurn++;
            }

            //------------------------------
            if (isXturn == true)
            {
                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button4.ForeColor = Color.Blue;
                Button4.Text = ("x");
                isXturn = false;
                btn4IsAlreadyClicked = true;
                Movement[4] = 1;
                boardIsTie[4] = 1;
                DetectWinner();
                IsTie();
                return;
            }

            LabelTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.Text = ("x");

            Button4.ForeColor = Color.Red;
            Button4.Text = ("o");
            isXturn = true;
            btn4IsAlreadyClicked = true;
            Movement[4] = -1;
            boardIsTie[4] = 1;

            DetectWinner();
            IsTie();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (btn5IsAlreadyClicked == true)
                return;
            //------------------------------------------------------------------------------------
            if (is2PlayerMode == false) //  call to AI function
            {
                if ((AI1stTurn == 1) && (boardNumber % 2 == 0))
                {
                    AI1stTurn++;
                    AIMovement();
                }


                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button5.ForeColor = Color.Blue;
                Button5.Text = ("x");
                isXturn = false;
                btn5IsAlreadyClicked = true;
                Movement[5] = 1;
                boardIsTie[5] = 1;
                DetectWinner();
                IsTie();
                if (IsTie())
                {
                    return;
                }

                AIMovement();
                return;
            }

            //' These below codes are 2 player mode
            if ((theTurn == 1) && (boardNumber % 2 == 1))
            {
                isXturn = true;
                theTurn++;
            }
            else if ((theTurn == 1) && (boardNumber % 2 == 0))
            {
                isXturn = false;
                theTurn++;
            }

            //------------------------------
            if (isXturn == true)
            {
                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button5.ForeColor = Color.Blue;
                Button5.Text = ("x");
                isXturn = false;
                btn5IsAlreadyClicked = true;
                Movement[5] = 1;
                boardIsTie[5] = 1;
                DetectWinner();
                IsTie();
                return;
            }

            LabelTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.Text = ("x");

            Button5.ForeColor = Color.Red;
            Button5.Text = ("o");
            isXturn = true;
            btn5IsAlreadyClicked = true;
            Movement[5] = -1;
            boardIsTie[5] = 1;

            DetectWinner();
            IsTie();
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            if (btn6IsAlreadyClicked == true)
                return;
            //------------------------------------------------------------------------------------
            if (is2PlayerMode == false) //  call to AI function
            {
                if ((AI1stTurn == 1) && (boardNumber % 2 == 0))
                {
                    AI1stTurn++;
                    AIMovement();
                }


                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button6.ForeColor = Color.Blue;
                Button6.Text = ("x");
                isXturn = false;
                btn6IsAlreadyClicked = true;
                Movement[6] = 1;
                boardIsTie[6] = 1;
                DetectWinner();
                IsTie();
                if (IsTie())
                {
                    return;
                }

                AIMovement();
                return;
            }


            //' These below codes are 2 player mode
            if ((theTurn == 1) && (boardNumber % 2 == 1))
            {
                isXturn = true;
                theTurn++;
            }
            else if ((theTurn == 1) && (boardNumber % 2 == 0))
            {
                isXturn = false;
                theTurn++;
            }

            //------------------------------
            if (isXturn == true)
            {
                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button6.ForeColor = Color.Blue;
                Button6.Text = ("x");
                isXturn = false;
                btn6IsAlreadyClicked = true;
                Movement[6] = 1;
                boardIsTie[6] = 1;
                DetectWinner();
                IsTie();
                return;
            }

            LabelTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.Text = ("x");

            Button6.ForeColor = Color.Red;
            Button6.Text = ("o");
            isXturn = true;
            btn6IsAlreadyClicked = true;
            Movement[6] = -1;
            boardIsTie[6] = 1;

            DetectWinner();
            IsTie();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (btn7IsAlreadyClicked == true)
                return;
            //------------------------------------------------------------------------------------
            if (is2PlayerMode == false) //  call to AI function
            {
                if ((AI1stTurn == 1) && (boardNumber % 2 == 0))
                {
                    AI1stTurn++;
                    AIMovement();
                }


                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button7.ForeColor = Color.Blue;
                Button7.Text = ("x");
                isXturn = false;
                btn7IsAlreadyClicked = true;
                Movement[7] = 1;
                boardIsTie[7] = 1;
                DetectWinner();
                IsTie();
                if (IsTie())
                {
                    return;
                }

                AIMovement();
                return;
            }


            //' These below codes are 2 player mode
            if ((theTurn == 1) && (boardNumber % 2 == 1))
            {
                isXturn = true;
                theTurn++;
            }
            else if ((theTurn == 1) && (boardNumber % 2 == 0))
            {
                isXturn = false;
                theTurn++;
            }

            //------------------------------
            if (isXturn == true)
            {
                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button7.ForeColor = Color.Blue;
                Button7.Text = ("x");
                isXturn = false;
                btn7IsAlreadyClicked = true;
                Movement[7] = 1;
                boardIsTie[7] = 1;
                DetectWinner();
                IsTie();
                return;
            }

            LabelTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.Text = ("x");

            Button7.ForeColor = Color.Red;
            Button7.Text = ("o");
            isXturn = true;
            btn7IsAlreadyClicked = true;
            Movement[7] = -1;
            boardIsTie[7] = 1;

            DetectWinner();
            IsTie();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (btn8IsAlreadyClicked == true)
                return;
            //------------------------------------------------------------------------------------
            if (is2PlayerMode == false) //  call to AI function
            {
                if ((AI1stTurn == 1) && (boardNumber % 2 == 0))
                {
                    AI1stTurn++;
                    AIMovement();
                }


                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button8.ForeColor = Color.Blue;
                Button8.Text = ("x");
                isXturn = false;
                btn8IsAlreadyClicked = true;
                Movement[8] = 1;
                boardIsTie[8] = 1;
                DetectWinner();
                IsTie();
                if (IsTie())
                {
                    return;
                }

                AIMovement();
                return;
            }


            //' These below codes are 2 player mode
            if ((theTurn == 1) && (boardNumber % 2 == 1))
            {
                isXturn = true;
                theTurn++;
            }
            else if ((theTurn == 1) && (boardNumber % 2 == 0))
            {
                isXturn = false;
                theTurn++;
            }

            //------------------------------
            if (isXturn == true)
            {
                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button8.ForeColor = Color.Blue;
                Button8.Text = ("x");
                isXturn = false;
                btn8IsAlreadyClicked = true;
                Movement[8] = 1;
                boardIsTie[8] = 1;
                DetectWinner();
                IsTie();
                return;
            }

            LabelTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.Text = ("x");

            Button8.ForeColor = Color.Red;
            Button8.Text = ("o");
            isXturn = true;
            btn8IsAlreadyClicked = true;
            Movement[8] = -1;
            boardIsTie[8] = 1;

            DetectWinner();
            IsTie();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (btn9IsAlreadyClicked == true)
                return;
            //------------------------------------------------------------------------------------
            if (is2PlayerMode == false) //  call to AI function
            {
                if ((AI1stTurn == 1) && (boardNumber % 2 == 0))
                {
                    AI1stTurn++;
                    AIMovement();
                }

                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button9.ForeColor = Color.Blue;
                Button9.Text = ("x");
                isXturn = false;
                btn9IsAlreadyClicked = true;
                Movement[9] = 1;
                boardIsTie[9] = 1;
                DetectWinner();
                IsTie();
                if (IsTie())
                {
                    return;
                }

                AIMovement();
                return;
            }

            //' These below codes are 2 player mode
            if ((theTurn == 1) && (boardNumber % 2 == 1))
            {
                isXturn = true;
                theTurn++;
            }
            else if ((theTurn == 1) && (boardNumber % 2 == 0))
            {
                isXturn = false;
                theTurn++;
            }

            //------------------------------
            if (isXturn == true)
            {
                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");

                Button9.ForeColor = Color.Blue;
                Button9.Text = ("x");
                isXturn = false;
                btn9IsAlreadyClicked = true;
                Movement[9] = 1;
                boardIsTie[9] = 1;
                DetectWinner();
                IsTie();
                return;
            }

            LabelTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.Text = ("x");

            Button9.ForeColor = Color.Red;
            Button9.Text = ("o");
            isXturn = true;
            btn9IsAlreadyClicked = true;
            Movement[9] = -1;
            boardIsTie[9] = 1;

            DetectWinner();
            IsTie();
        }

        private void ButtonChangePlayer_Click(object sender, EventArgs e)
        {
            ResetGame();
            boardNumber = 1;
            theTurn = 1;
            AI1stTurn = 1;
            labelBoardNumber.Text = ("board number 1");
            if (is2PlayerMode == true)// ' we change game to one player
            {

                LabelPlayerMode.Text = ("1 player mode");
                is2PlayerMode = false;
                return;
            }
            //'------------------------------------------------------


            LabelPlayerMode.Text = ("2 player mode");
            is2PlayerMode = true;

        }

        private void ButtonReplay_Click(object sender, EventArgs e)
        {
            ResetGame();
            boardNumber++;// reset board
            theTurn = 1;
            labelBoardNumber.Text = ("board number ") + boardNumber.ToString();

            //-------
            if ((is2PlayerMode == false) && (boardNumber % 2 == 0))
            {
                AI1stTurn++;
                AIMovement();
                return;
            }


            //-- these below codes related to 2 player mode
            if (boardNumber % 2 == 1)
            {

                LabelTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.Text = ("x");

            }
            else if (boardNumber % 2 == 0)
            {

                LabelTurn.ForeColor = Color.Red;
                LabelPlayerTurn.ForeColor = Color.Red;
                LabelPlayerTurn.Text = ("o");


            }

        }

        private void ButtonSound_Click(object sender, EventArgs e)
        {
            if (soundOn == true)
            {
                soundOn = false;
                ButtonSound.Text = ("on");
            }
            else
            {
                soundOn = true;
                ButtonSound.Text = ("off");
            }
        }


        //################################################################################################################//
        /* useful function*/
        void ResetGame()
        {

            xMove = 1;// used in level 4
            xFirstMove = true;

            isXturn = true;

            LabelVictory.Text = ("");

            LabelTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.ForeColor = Color.Blue;
            LabelPlayerTurn.Text = ("x");

            Button1.Text = ("");
            Button2.Text = ("");
            Button3.Text = ("");
            Button4.Text = ("");
            Button5.Text = ("");
            Button6.Text = ("");
            Button7.Text = ("");
            Button8.Text = ("");
            Button9.Text = ("");

            // ' btn1IsAlreadyClicked = btn2IsAlreadyClicked = btn3IsAlreadyClicked = btn4IsAlreadyClicked = btn5IsAlreadyClicked = btn6IsAlreadyClicked = btn7IsAlreadyClicked = btn8IsAlreadyClicked = btn9IsAlreadyClicked = False
            btn1IsAlreadyClicked = false;
            btn2IsAlreadyClicked = false;
            btn3IsAlreadyClicked = false;
            btn4IsAlreadyClicked = false;
            btn5IsAlreadyClicked = false;
            btn6IsAlreadyClicked = false;
            btn7IsAlreadyClicked = false;
            btn8IsAlreadyClicked = false;
            btn9IsAlreadyClicked = false;


            Movement[1] = 0;
            Movement[2] = 0;
            Movement[3] = 0;
            Movement[4] = 0;
            Movement[5] = 0;
            Movement[6] = 0;
            Movement[7] = 0;
            Movement[8] = 0;
            Movement[9] = 0;

            boardIsTie[1] = 0;
            boardIsTie[2] = 0;
            boardIsTie[3] = 0;
            boardIsTie[4] = 0;
            boardIsTie[5] = 0;
            boardIsTie[6] = 0;
            boardIsTie[7] = 0;
            boardIsTie[8] = 0;
            boardIsTie[9] = 0;
            //  '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            used23 = false;
            used13 = false;
            used12 = false;

            used56 = false;
            used46 = false;
            used45 = false;

            used89 = false;
            used79 = false;
            used78 = false;

            used47 = false;
            used17 = false;
            used14 = false;

            used58 = false;
            used28 = false;
            used25 = false;

            used69 = false;
            used39 = false;
            used36 = false;

            used59 = false;
            used19 = false;
            used15 = false;

            used75 = false;
            used73 = false;
            used53 = false;

        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        void NoDrawing()
        {
            btn1IsAlreadyClicked = true;
            btn2IsAlreadyClicked = true;
            btn3IsAlreadyClicked = true;
            btn4IsAlreadyClicked = true;
            btn5IsAlreadyClicked = true;
            btn6IsAlreadyClicked = true;
            btn7IsAlreadyClicked = true;
            btn8IsAlreadyClicked = true;
            btn9IsAlreadyClicked = true;

        }

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        void DetectWinner()
        {
            // ' there are 8 ways to win
            //' 3 for winning by row
            // ' 3 for winning by column 
            // ' 2 for winning by cross

            // ' box 1 + 2 +3
            // '---------------------------------------------------
            if (Movement[1] + Movement[2] + Movement[3] == 3)
            {
                LabelVictory.Text = ("Player X won the game!");

                if (soundOn == true) ;
                {
                    //Dim SAPI
                    //  SAPI = CreateObject("SAPI.spvoice")
                    // SAPI.Speak("Player X won the game!")

                }

                NoDrawing();
                return;
            }
            else if (Movement[1] + Movement[2] + Movement[3] == -3)
            {
                LabelVictory.Text = ("Player O won the game!");

                if (soundOn == true)
                {  // Dim SAPI
                   // SAPI = CreateObject("SAPI.spvoice")
                   //SAPI.Speak("Player O won the game!")

                }

                NoDrawing();
                return;
            }
            //-------------------------------------------------------------
            if (Movement[4] + Movement[5] + Movement[6] == 3)
            {
                LabelVictory.Text = ("Player X won the game!");

                if (soundOn == true) ;
                {
                    //Dim SAPI
                    //  SAPI = CreateObject("SAPI.spvoice")
                    // SAPI.Speak("Player X won the game!")

                }

                NoDrawing();
                return;
            }
            else if (Movement[4] + Movement[5] + Movement[6] == -3)
            {
                LabelVictory.Text = ("Player O won the game!");

                if (soundOn == true)
                {  // Dim SAPI
                   // SAPI = CreateObject("SAPI.spvoice")
                   //SAPI.Speak("Player O won the game!")

                }

                NoDrawing();
                return;
            }
            //-------------------------------------------------------------
            if (Movement[7] + Movement[8] + Movement[9] == 3)
            {
                LabelVictory.Text = ("Player X won the game!");

                if (soundOn == true) ;
                {
                    //Dim SAPI
                    //  SAPI = CreateObject("SAPI.spvoice")
                    // SAPI.Speak("Player X won the game!")

                }

                NoDrawing();
                return;
            }
            else if (Movement[7] + Movement[8] + Movement[9] == -3)
            {
                LabelVictory.Text = ("Player O won the game!");

                if (soundOn == true)
                {  // Dim SAPI
                   // SAPI = CreateObject("SAPI.spvoice")
                   //SAPI.Speak("Player O won the game!")

                }

                NoDrawing();
                return;
            }

            //-------------------------------------------------------------
            if (Movement[1] + Movement[4] + Movement[7] == 3)
            {
                LabelVictory.Text = ("Player X won the game!");

                if (soundOn == true) ;
                {
                    //Dim SAPI
                    //  SAPI = CreateObject("SAPI.spvoice")
                    // SAPI.Speak("Player X won the game!")

                }

                NoDrawing();
                return;
            }
            else if (Movement[1] + Movement[4] + Movement[7] == -3)
            {
                LabelVictory.Text = ("Player O won the game!");

                if (soundOn == true)
                {  // Dim SAPI
                   // SAPI = CreateObject("SAPI.spvoice")
                   //SAPI.Speak("Player O won the game!")

                }

                NoDrawing();
                return;
            }
            //-------------------------------------------------------------
            if (Movement[2] + Movement[5] + Movement[8] == 3)
            {
                LabelVictory.Text = ("Player X won the game!");

                if (soundOn == true) ;
                {
                    //Dim SAPI
                    //  SAPI = CreateObject("SAPI.spvoice")
                    // SAPI.Speak("Player X won the game!")

                }

                NoDrawing();
                return;
            }
            else if (Movement[2] + Movement[5] + Movement[8] == -3)
            {
                LabelVictory.Text = ("Player O won the game!");

                if (soundOn == true)
                {  // Dim SAPI
                   // SAPI = CreateObject("SAPI.spvoice")
                   //SAPI.Speak("Player O won the game!")

                }

                NoDrawing();
                return;
            }
            //-------------------------------------------------------------
            if (Movement[3] + Movement[6] + Movement[9] == 3)
            {
                LabelVictory.Text = ("Player X won the game!");

                if (soundOn == true) ;
                {
                    //Dim SAPI
                    //  SAPI = CreateObject("SAPI.spvoice")
                    // SAPI.Speak("Player X won the game!")

                }

                NoDrawing();
                return;
            }
            else if (Movement[3] + Movement[6] + Movement[9] == -3)
            {
                LabelVictory.Text = ("Player O won the game!");

                if (soundOn == true)
                {  // Dim SAPI
                   // SAPI = CreateObject("SAPI.spvoice")
                   //SAPI.Speak("Player O won the game!")

                }

                NoDrawing();
                return;
            }
            //-------------------------------------------------------------
            if (Movement[1] + Movement[5] + Movement[9] == 3)
            {
                LabelVictory.Text = ("Player X won the game!");

                if (soundOn == true) ;
                {
                    //Dim SAPI
                    //  SAPI = CreateObject("SAPI.spvoice")
                    // SAPI.Speak("Player X won the game!")

                }

                NoDrawing();
                return;
            }
            else if (Movement[1] + Movement[5] + Movement[9] == -3)
            {
                LabelVictory.Text = ("Player O won the game!");

                if (soundOn == true)
                {  // Dim SAPI
                   // SAPI = CreateObject("SAPI.spvoice")
                   //SAPI.Speak("Player O won the game!")

                }

                NoDrawing();
                return;
            }
            //-------------------------------------------------------------
            if (Movement[3] + Movement[5] + Movement[7] == 3)
            {
                LabelVictory.Text = ("Player X won the game!");

                if (soundOn == true) ;
                {
                    //Dim SAPI
                    //  SAPI = CreateObject("SAPI.spvoice")
                    // SAPI.Speak("Player X won the game!")

                }

                NoDrawing();
                return;
            }
            else if (Movement[3] + Movement[5] + Movement[7] == -3)
            {
                LabelVictory.Text = ("Player O won the game!");

                if (soundOn == true)
                {  // Dim SAPI
                   // SAPI = CreateObject("SAPI.spvoice")
                   //SAPI.Speak("Player O won the game!")

                }

                NoDrawing();
                return;
            }


        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        bool IsTie()
        {
            if (boardIsTie[1] + boardIsTie[2] + boardIsTie[3] + boardIsTie[4] + boardIsTie[5] + boardIsTie[6] + boardIsTie[7] + boardIsTie[8] + boardIsTie[9] == 9)
            {

                LabelVictory.Text = ("Tie!Click Replay.Thanks!");
                if (soundOn == true)
                {
                    // Dim SAPI
                    // SAPI = CreateObject("SAPI.spvoice")
                    // SAPI.Speak("Board is tie. Click the Button Replay to continue. Thanks!")

                }
                return true;
            }
            return false;
        }

        /*#############################################################################################################
         *          AI function for one player
         *          By - AN Panharith
         *             - Cheasim Samnang
         *             -Moun Makara
         * 
         *############################################################################################################# */
        /*tips*/        //' Remember, AI is the player "o". and we want player o to win
                        //' as a idea, we will teach AI to play Tic Tac Toe
                        //' AI wants to win so we will let her find the value -3. 
                        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        int DrawAndWinThisStep()
        {
            //============================================================================
            //===== 1 row
            // 1.1 path 123
            if (Movement[2] + Movement[3] == -2)
            {
                return 1;
            }
            if (Movement[1] + Movement[3] == -2)
            {
                return 2;
            }
            if (Movement[1] + Movement[2] == -2)
            {
                return 3;
            }
            //------------
            // 1.2 path 456
            if (Movement[5] + Movement[6] == -2)
            {
                return 4;
            }
            if (Movement[4] + Movement[6] == -2)
            {
                return 5;
            }
            if (Movement[4] + Movement[5] == -2)
            {
                return 6;
            }
            //-------
            // 1.3 path 789
            if (Movement[8] + Movement[9] == -2)
            {
                return 7;
            }
            if (Movement[7] + Movement[9] == -2)
            {
                return 8;
            }
            if (Movement[7] + Movement[8] == -2)
            {
                return 9;
            }
            //================================================================================================
            //====== 2 column
            //---- 2.1 path147
            if (Movement[4] + Movement[7] == -2)
            {
                return 1;
            }
            if (Movement[1] + Movement[7] == -2)
            {
                return 4;
            }
            if (Movement[1] + Movement[4] == -2)
            {
                return 7;
            }
            //---- 2.2 path258
            if (Movement[5] + Movement[8] == -2)
            {
                return 2;
            }
            if (Movement[2] + Movement[8] == -2)
            {
                return 5;
            }
            if (Movement[2] + Movement[5] == -2)
            {
                return 8;
            }
            //----- 2.3 path369
            if (Movement[6] + Movement[9] == -2)
            {
                return 3;
            }
            if (Movement[3] + Movement[9] == -2)
            {
                return 6;
            }
            if (Movement[3] + Movement[6] == -2)
            {
                return 9;
            }
            //==========================================================================================================
            //====== 3 cross 1
            //-----  path159
            if (Movement[5] + Movement[9] == -2)
            {
                return 1;
            }
            if (Movement[1] + Movement[9] == -2)
            {
                return 5;
            }
            if (Movement[1] + Movement[5] == -2)
            {
                return 9;
            }
            //==================================================================================================================
            //====== 4 cross 2
            //--- path 357
            if (Movement[7] + Movement[5] == -2)
            {
                return 3;
            }
            if (Movement[7] + Movement[3] == -2)
            {
                return 5;
                if (Movement[5] + Movement[3] == -2)
                {
                    return 7;
                }

            }

            return 0;

        }

        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        int DrawAndPreventLoseHigerLevel()
        {
            //=========================================================================================
            // ---------' 1. row
            //----- 1.1 path 123
            if ((Movement[2] + Movement[3] == 2) && (used23 == false) && (Movement[1] != -1))
            {
                used23 = true;
                return 1;
            }

            if ((Movement[1] + Movement[3] == 2) && (used13 == false) && (Movement[2] != -1))
            {

                used13 = true;
                return 2;
            }
            if ((Movement[1] + Movement[2] == 2) && (used12 == false) && (Movement[3] != -1))
            {
                used12 = true;
                return 3;
            }
            //----------1.2 path 456
            if ((Movement[5] + Movement[6] == 2) && (used56 == false) && (Movement[4] != -1))
            {
                used56 = true;
                return 4;
            }
            if ((Movement[4] + Movement[6] == 2) && (used46 == false) && (Movement[5] != -1))
            {
                used46 = true;
                return 5;
            }
            if ((Movement[4] + Movement[5] == 2) && (used45 == false) && (Movement[6] != -1))
            {
                used45 = true;
                return 6;
            }
            //----- 1.3 path 789
            if ((Movement[8] + Movement[9] == 2) && (used89 == false) && (Movement[7] != -1))
            {
                used89 = true;
                return 7;
            }
            if ((Movement[7] + Movement[9] == 2) && (used79 == false) && (Movement[8] != -1))
            {
                used79 = true;
                return 8;
            }

            if ((Movement[7] + Movement[8] == 2) && (used78 == false) && (Movement[9] != -1))
            {
                used78 = true;
                return 9;
            }

            //'====================================================
            //-----'2 column
            //------ 2.1 path 147
            if ((Movement[4] + Movement[7] == 2) && (used47 == false) && (Movement[1] != -1))
            {
                used47 = true;
                return 1;
            }

            if ((Movement[1] + Movement[7] == 2) && (used17 == false) && (Movement[4] != -1))
            {
                used17 = true;
                return 4;
            }

            if ((Movement[1] + Movement[4] == 2) && (used14 == false) && (Movement[7] != -1))
            {
                used14 = true;
                return 7;
            }
            //------ 2.2 path 258
            if ((Movement[5] + Movement[8] == 2) && (used58 == false) && (Movement[2] != -1))
            {
                used58 = true;
                return 2;
            }
            if ((Movement[2] + Movement[8] == 2) && (used28 == false) && (Movement[5] != -1))
            {
                used28 = true;
                return 5;
            }
            if ((Movement[2] + Movement[5] == 2) && (used25 == false) && (Movement[8] != -1))
            {
                used25 = true;
                return 8;
            }
            //------ 2.3 path 369
            if ((Movement[6] + Movement[9] == 2) && (used69 == false) && (Movement[3] != -1))
            {
                used69 = true;
                return 3;
            }
            if ((Movement[3] + Movement[9] == 2) && (used39 == false) && (Movement[6] != -1))
            {
                used39 = true;
                return 6;
            }
            if ((Movement[3] + Movement[6] == 2) && (used36 == false) && (Movement[9] != -1))
            {
                used36 = true;
                return 9;
            }
            // '====================================================================
            //------ '3. cross 1
            //---- path 159
            if ((Movement[5] + Movement[9] == 2) && (used59 == false) && (Movement[1] != -1))
            {
                used59 = true;
                return 1;
            }
            if ((Movement[1] + Movement[9] == 2) && (used19 == false) && (Movement[5] != -1))
            {
                used19 = true;
                return 5;
            }
            if ((Movement[1] + Movement[5] == 2) && (used15 == false) && (Movement[9] != -1))
            {
                used15 = true;
                return 9;
            }
            //'==============================================================================
            //'-------4. cross up
            //--- path 357
            if ((Movement[7] + Movement[5] == 2) && (used75 == false) && (Movement[3] != -1))
            {
                used75 = true;
                return 3;
            }

            if ((Movement[7] + Movement[3] == 2) && (used73 == false) && (Movement[5] != -1))
            {
                used73 = true;
                return 5;
            }
            if ((Movement[5] + Movement[3] == 2) && (used53 == false) && (Movement[7] != -1))
            {
                used53 = true;
                return 7;
            }
            // '===============================================================================
            //  ' Otherwise, there is no chance to win for this case
            // ' so return 0


            return 0;


        } // end of function

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        int BestMove()
        {
            int Best = 0;

            // '1 . first priority of best move is Put-And-win

            Best = DrawAndWinThisStep();
            if ((Best != 0) && (Movement[Best] == 0))
            {
                return Best;

            }

            // '2. second priority of best move is Put-To-Prevent-losing
            Best = DrawAndPreventLoseHigerLevel();
            if ((Best != 0) && (Movement[Best] == 0))
            {
                return Best;

            }
            // '3. Otherwise, do it randomly
            Best = 1;
            int i = 1;

            for (i = 1; i <= 9; ++i)
            {
                if (Movement[Best] == 0)
                {
                    return Best;

                }
                else
                    Best++;


            }
            //--------------otherwise
            return 0;

        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        int BestMove_MediumLevel()
        {
            int Best = 0;

            // '1 . first priority of best move is Put-And-win

            Best = DrawAndWinThisStep();
            if ((Best != 0) && (Movement[Best] == 0))
            {
                return Best;

            }

            // '2. second priority of best move is Put-To-Prevent-losing
            Best = DrawAndPreventLoseHigerLevel();
            if ((Best != 0) && (Movement[Best] == 0))
            {
                return Best;

            }
            // '3. Otherwise, do it randomly
            Best = 1;
            int i = 1;
            int[] z = new int[10];
            int free = 0;
            for (i = 1; i <= 9; ++i)
            {
                if (Movement[Best] == 0)
                {
                    z[i] = Best;
                    free++;
                }

                Best++;


            }
            if (IsTie())
            {
                //   MessageBox.Show("Suffle");

                return 0;
            }
            /*


              z = null;
              rd = null;*/
            // return randomNumber;
            //  int randomIndex ;
            //  int randomNumber = z[randomIndex];
            Random rd = new Random();

            do
            {
                int randomIndex = rd.Next(1, 9);
                if (Movement[randomIndex] == 0)
                {
                    //  MessageBox.Show("yep");

                    return randomIndex;
                }
            }
            while (true);







            //--------------otherwise
            //return 0;

        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        int BestMove_level3()
        {
            int Best = 0;



            // '1 . first priority of best move is Put-And-win

            Best = DrawAndWinThisStep();
            if ((Best != 0) && (Movement[Best] == 0))
            {
                return Best;

            }

            // '2. second priority of best move is Put-To-Prevent-losing
            Best = DrawAndPreventLoseHigerLevel();
            if ((Best != 0) && (Movement[Best] == 0))
            {
                return Best;

            }
            // '3. Otherwise,
            if (IsTie())
            {
                //   MessageBox.Show("Suffle");

                return 0;
            }
            /*


              z = null;
              rd = null;*/
            // return randomNumber;
            //  int randomIndex ;
            //  int randomNumber = z[randomIndex];
            if ((xFirstMove == true) && (Movement[5] == 0))
            {




                xFirstMove = false;
                return 5;
            }

            Random rd = new Random();

            do
            {
                int randomIndex = rd.Next(1, 9);
                if (Movement[randomIndex] == 0)
                {
                    //  MessageBox.Show("yep");

                    return randomIndex;
                }
            }
            while (true);







            //--------------otherwise
            //return 0;

        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        int xMove = 1;
        int BestMove_Level4()
        {
            int Best = 0;




            // '1 . first priority of best move is Put-And-win

            Best = DrawAndWinThisStep();
            if ((Best != 0) && (Movement[Best] == 0))
            {
                return Best;

            }

            // '2. second priority of best move is Put-To-Prevent-losing
            Best = DrawAndPreventLoseHigerLevel();
            if ((Best != 0) && (Movement[Best] == 0))
            {
                return Best;

            }
            // '3. Otherwise,

            if (IsTie())
            {
                //   MessageBox.Show("Suffle");

                return 0;
            }
            if (xMove == 1)
            {
                xMove++;
                if (Movement[5] == 0) return 5;
                if (Movement[1] == 0) return 1;
                if (Movement[3] == 0) return 3;
                if (Movement[7] == 0) return 7;
                if (Movement[9] == 0) return 9;



            }
            if (xMove == 2)
            {
                xMove++;
                if (Movement[1] == 0) return 1;
                if (Movement[3] == 0) return 3;
                if (Movement[7] == 0) return 7;
                if (Movement[9] == 0) return 9;




            }
            //---------------
            Random rd = new Random();

            do
            {
                int randomIndex = rd.Next(1, 9);
                if (Movement[randomIndex] == 0)
                {
                    //  MessageBox.Show("yep");

                    return randomIndex;
                }
            }
            while (true);

            //--------------------
            return 0;
        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        int BestMove_Level5() // most advance
        {
            int Best = 0;




            // '1 . first priority of best move is Put-And-win

            Best = DrawAndWinThisStep();
            if ((Best != 0) && (Movement[Best] == 0))
            {
                return Best;

            }

            // '2. second priority of best move is Put-To-Prevent-losing
            Best = DrawAndPreventLoseHigerLevel();
            if ((Best != 0) && (Movement[Best] == 0))
            {
                return Best;

            }
            // '3. Otherwise,

            if (IsTie())
            {
                //   MessageBox.Show("Suffle");

                return 0;
            }
            /*
            if (xMove == 1)
            {
                xMove++;
                if (Movement[5] == 0) return 5;
                if (Movement[1] == 0) return 1;
                if (Movement[3] == 0) return 3;
                if (Movement[7] == 0) return 7;
                if (Movement[9] == 0) return 9;



            }
            if (xMove == 2)
            {
                xMove++;
                if (Movement[1] == 0) return 1;
                if (Movement[3] == 0) return 3;
                if (Movement[7] == 0) return 7;
                if (Movement[9] == 0) return 9;




            }


            */
            //---------------
            /*
             Random rd = new Random();

             do
             {
                 int randomIndex = rd.Next(1, 9);
                 if (Movement[randomIndex] == 0)
                 {
                     //  MessageBox.Show("yep");

                     return randomIndex;
                 }
             }
             while (true);

             //--------------------
             return 0;
             */

            if (boardNumber % 2 == 0) // in case , AI gets the first move before the oponent
            {
                //1. the first move

                if ((Movement[1] == 0) && (Movement[2] == 0) && (Movement[3] == 0) && (Movement[4] == 0) && (Movement[5] == 0) && (Movement[6] == 0) && (Movement[7] == 0) && (Movement[8] == 0) && (Movement[9] == 0))
                {

                    int[] numbers = new int[9] { 1, 3, 7, 9, 2, 4, 5, 8, 6 };
                    Random rd = new Random();
                    int first = rd.Next(0, 9);
                    int randomNumber = numbers[first];
                    rd = null;
                    return randomNumber;
                }
                // 2. second move 
                if ((Movement[5] == -1)) // case 2.1 if AI first move = 5

                {
                    //2.1.1 and x first move is ={ 2,4,6,8} 
                    if (Movement[2] == 1)
                    {
                        int[] numbers = new int[2] { 4, 6 };
                        Random rd = new Random();
                        int first = rd.Next(0, 2);
                        int randomNumber = numbers[first];
                        rd = null;
                        return randomNumber;


                    }
                    if (Movement[4] == 1)
                    {
                        int[] numbers = new int[2] { 2, 8 };
                        Random rd = new Random();
                        int first = rd.Next(0, 2);
                        int randomNumber = numbers[first];
                        rd = null;
                        return randomNumber;


                    }
                    if (Movement[6] == 1)
                    {

                        int[] numbers = new int[2] { 2, 8 };
                        Random rd = new Random();
                        int first = rd.Next(0, 2);
                        int randomNumber = numbers[first];
                        rd = null;
                        return randomNumber;

                    }
                    if (Movement[8] == 1)
                    {

                        int[] numbers = new int[2] { 4, 6 };
                        Random rd = new Random();
                        int first = rd.Next(0, 2);
                        int randomNumber = numbers[first];
                        rd = null;
                        return randomNumber;

                    }











                }















                // case 2.2 if AI first move =5 , and x first move is = {1,3,7,9,}










                // 1. first move                
                if ((Movement[1] == 0) && (Movement[2] == 0) && (Movement[3] == 0) && (Movement[4] == 0) && (Movement[5] == 0) && (Movement[6] == 0) && (Movement[7] == 0) && (Movement[8] == 0) && (Movement[9] == 0))
                {

                    int[] numbers = new int[4] { 1, 3, 7, 9 };
                    Random rd = new Random();
                    int first = rd.Next(0, 4);
                    int randomNumber = numbers[first];
                    rd = null;
                    return randomNumber;
                }
                //--- 2. second move
                if (Movement[1] == -1)
                {
                    if (Movement[9] == 0) return 9;

                }
                if (Movement[3] == -1)
                {
                    if (Movement[7] == 0) return 7;

                }
                if (Movement[7] == -1)
                {
                    if (Movement[3] == 0) return 3;

                }
                if (Movement[9] == -1)
                {
                    if (Movement[1] == 0) return 1;

                }
                //------3. Third move
                /*
                if ( (Movement[1]==-1)&&(Movement[9]==-1) )
                {
                 if (Movement[3] == 0) return 3;
                    if (Movement[7] == 0) return 7;
                
                }
                if ((Movement[3] == -1) && (Movement[7] == -1))
                {
                    if (Movement[1] == 0) return 1 ;
                    if (Movement[9] == 0) return 9;

                }
                */


            }
            if (boardNumber % 2 == 1)
            {
                if ((Movement[1] == 1) || (Movement[2] == 1) || (Movement[3] == 1) || (Movement[4] == 1) || (Movement[5] == 1) || (Movement[6] == 1) || (Movement[7] == 1) || (Movement[8] == 1) || (Movement[9] == 1))
                {
                    if (Movement[5] == 0) return 5;
                    else if (Movement[5] == 1)
                    {
                        do
                        {
                            int[] numbers = new int[4] { 2, 4, 6, 8 };
                            Random rd = new Random();
                            int first = rd.Next(0, 4);
                            int randomNumber = numbers[first];
                            rd = null;
                            if (Movement[randomNumber] == 0)
                            {
                                return randomNumber;
                            }
                        } while (true);

                    }
                }
                // otherwise
                if ((Movement[1] == 1) || (Movement[3] == 1) || (Movement[7] == 1) || (Movement[9] == 1))
                {

                    do
                    {
                        int[] numbers = new int[4] { 2, 4, 6, 8 };
                        Random rd = new Random();
                        int first = rd.Next(0, 4);
                        int randomNumber = numbers[first];
                        rd = null;
                        if (Movement[randomNumber] == 0)
                        {
                            return randomNumber;
                        }
                    } while (true);

                }
                if ((Movement[2] == 1) || (Movement[4] == 1) || (Movement[6] == 1) || (Movement[8] == 1))
                {
                    do
                    {
                        int[] numbers = new int[4] { 1, 3, 7, 9 };
                        Random rd = new Random();
                        int first = rd.Next(0, 4);
                        int randomNumber = numbers[first];
                        rd = null;
                        if (Movement[randomNumber] == 0)
                        {
                            return randomNumber;
                        }
                    } while (true);


                }

            }







            return 0;
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        int level6_AIstep = 0;
        int AIstep = 1;

        int BestMove_Level6() // most advance
        {
            int Best = 0;


            // MessageBox.Show((Movement[5]+Movement[9]).ToString());
            //if (Movement[5] + Movement[9] == -2 && Movement[1]==0)
            //{
            //    return 1;
            //}
            //if (Movement[4] + Movement[7] == -2 && Movement[1] == 0)
            //{
            //    return 1;
            //}
            //if (Movement[1] + Movement[4] == -2 && Movement[7] == 0)
            //{
            //    return 7;
            //}
            //if (Movement[5] + Movement[7] == -2 && Movement[3] == 0)
            //{
            //    return 3;
            //}
            // '1 . first priority of best move is Put-And-win

            Best = DrawAndWinThisStep();
            if ((Best != 0) && (Movement[Best] == 0))
            {
                return Best;

            }

            // '2. second priority of best move is Put-To-Prevent-losing
            Best = DrawAndPreventLoseHigerLevel();
            if ((Best != 0) && (Movement[Best] == 0))
            {
                return Best;

            }
            // '3. Otherwise,

            if (IsTie())
            {
                return 0;
            }

            if (boardNumber % 2 == 0) // in case , AI gets the first move before the oponent
            {
                //  MessageBox.Show(boardNumber.ToString());
                if (AIstep == 1)
                {
                    AIstep++;
                    return 5;

                }
                else if (AIstep == 2)
                {
                    AIstep++;
                    if (Movement[2] == 1 || Movement[8] == 1)
                    {
                        //MessageBox.Show("Try Samnang");
                        int[] numbers = new int[2] { 4, 6 };
                        Random rd = new Random();
                        int first = rd.Next(0, 1);
                        int randomNumber = numbers[first];
                        rd = null;
                        return randomNumber;

                    }
                    else if (Movement[4] == 1 || Movement[6] == 1)
                    {
                        int[] numbers = new int[2] { 2, 8 };
                        Random rd = new Random();
                        int first = rd.Next(0, 1);
                        int randomNumber = numbers[first];
                        rd = null;

                        return randomNumber;
                    }

                    else if (Movement[1] == 1 || Movement[3] == 1 || Movement[7] == 1 || Movement[9] == 1)
                    {
                        while (true)
                        {
                            int[] numbers = new int[8] { 1, 2, 3, 4, 6, 7, 9, 8 };
                            Random rd = new Random();
                            int first = rd.Next(0, 8);
                            int randomNumber = numbers[first];
                            rd = null;
                            if (Movement[randomNumber] == 0)
                            {

                                return randomNumber;
                            }
                        }
                    }


                }// end of step 2
                else if (AIstep == 3)
                {
                    //for movement x in even number
                    if ((Movement[5] == -1) && (Movement[2] == 1) && (Movement[4] == -1))
                    {

                        if (Movement[6] == 1)
                        {

                            int[] numbers = new int[2] { 1, 7 };
                            Random rd = new Random();
                            int first = rd.Next(0, 1);
                            int randomNumber = numbers[first];
                            rd = null;

                            return randomNumber;

                        }

                    }
                    else if ((Movement[5] == -1) && (Movement[2] == 1) && (Movement[6] == -1))
                    {
                        if (Movement[4] == 1)
                        {

                            int[] numbers = new int[2] { 3, 9 };
                            Random rd = new Random();
                            int first = rd.Next(0, 1);
                            int randomNumber = numbers[first];
                            rd = null;


                            return randomNumber;
                        }
                    }
                    else if ((Movement[5] == -1) && (Movement[4] == 1) && (Movement[2] == -1))
                    {
                        if (Movement[8] == 1)
                        {

                            int[] numbers = new int[2] { 1, 3 };
                            Random rd = new Random();
                            int first = rd.Next(0, 1);
                            int randomNumber = numbers[first];
                            rd = null;


                            return randomNumber;

                        }
                    }
                }
                else if ((Movement[5] == -1) && (Movement[4] == 1) && (Movement[8] == -1))
                {
                    if (Movement[2] == 1)
                    {

                        int[] numbers = new int[2] { 7, 9 };
                        Random rd = new Random();
                        int first = rd.Next(0, 1);
                        int randomNumber = numbers[first];
                        rd = null;


                        return randomNumber;

                    }
                }
            }
            else if ((Movement[5] == -1) && (Movement[6] == 1) && (Movement[2] == -1))
            {
                if (Movement[8] == 1)
                {
                    while (true)
                    {
                        int[] numbers = new int[2] { 1, 3 };
                        Random rd = new Random();
                        int first = rd.Next(0, 1);
                        int randomNumber = numbers[first];
                        rd = null;

                        if (Movement[randomNumber] == 0)
                        {
                            return randomNumber;
                        }
                    }
                }
            }
            else if ((Movement[5] == -1) && (Movement[6] == 1) && (Movement[8] == -1))
            {
                if (Movement[2] == 1)
                {
                    while (true)
                    {
                        int[] numbers = new int[2] { 7, 9 };
                        Random rd = new Random();
                        int first = rd.Next(0, 1);
                        int randomNumber = numbers[first];
                        rd = null;

                        if (Movement[randomNumber] == 0)
                        {
                            return randomNumber;
                        }
                    }
                }
            }
            else if ((Movement[5] == -1) && (Movement[8] == 1) && (Movement[4] == -1))
            {
                if (Movement[6] == 1)
                {

                    int[] numbers = new int[2] { 7, 1 };
                    Random rd = new Random();
                    int first = rd.Next(0, 1);
                    int randomNumber = numbers[first];
                    rd = null;


                    return randomNumber;


                }

            }
            else if ((Movement[5] == -1) && (Movement[8] == 1) && (Movement[6] == -1))
            {
                if (Movement[4] == 1)
                {

                    int[] numbers = new int[2] { 3, 9 };
                    Random rd = new Random();
                    int first = rd.Next(0, 1);
                    int randomNumber = numbers[first];
                    rd = null;

                    return randomNumber;


                }
            }
            else if ((Movement[5] == -1) && (Movement[1] == 1) && (Movement[9] == -1))
            {
                if (Movement[6] == 1)
                {
                    while (true)
                    {
                        int[] numbers = new int[2] { 7, 8 };
                        Random rd = new Random();
                        int first = rd.Next(0, 1);
                        int randomNumber = numbers[first];
                        rd = null;

                        if (Movement[randomNumber] == 0)
                        {
                            return randomNumber;
                        }
                    }
                }
                if (Movement[8] == 1)
                {
                    while (true)
                    {
                        int[] numbers = new int[2] { 3, 6 };
                        Random rd = new Random();
                        int first = rd.Next(0, 1);
                        int randomNumber = numbers[first];
                        rd = null;
                        if (Movement[randomNumber] == 0)
                        {
                            return randomNumber;
                        }
                    }
                }
            }
            else if ((Movement[5] == -1) && (Movement[3] == 1) && (Movement[7] == -1))
            {
                if (Movement[4] == 1)
                {
                    return 9;
                }
                if (Movement[8] == 1)
                {
                    while (true)
                    {
                        int[] numbers = new int[2] { 1, 4 };
                        Random rd = new Random();
                        int first = rd.Next(0, 1);
                        int randomNumber = numbers[first];
                        rd = null;
                        if (Movement[randomNumber] == 0)
                        {
                            return randomNumber;
                        }
                    }
                }
            }
            else if ((Movement[5] == -1) && (Movement[7] == 1) && (Movement[3] == -1))
            {
                if (Movement[2] == 1)
                {
                    while (true)
                    {
                        int[] numbers = new int[2] { 6, 9 };
                        Random rd = new Random();
                        int first = rd.Next(0, 1);
                        int randomNumber = numbers[first];
                        rd = null;

                        if (Movement[randomNumber] == 0)
                        {
                            return randomNumber;
                        }
                    }
                }
                if (Movement[6] == 1)
                {
                    while (true)
                    {
                        int[] numbers = new int[2] { 1, 2 };
                        Random rd = new Random();
                        int first = rd.Next(0, 1);
                        int randomNumber = numbers[first];
                        rd = null;

                        if (Movement[randomNumber] == 0)
                        {
                            return randomNumber;
                        }
                    }
                }
            }
            else if ((Movement[5] == -1) && (Movement[9] == 1) && (Movement[1] == -1))
            {
                if (Movement[2] == 1)
                {
                    while (true)
                    {
                        int[] numbers = new int[2] { 7, 4 };
                        Random rd = new Random();
                        int first = rd.Next(0, 1);
                        int randomNumber = numbers[first];
                        rd = null;
                        if (Movement[randomNumber] == 0)
                        {
                            return randomNumber;
                        }
                    }
                }
                if (Movement[4] == 1)
                {
                    while (true)
                    {
                        int[] numbers = new int[2] { 3, 2 };
                        Random rd = new Random();
                        int first = rd.Next(0, 1);
                        int randomNumber = numbers[first];
                        rd = null;
                        if (Movement[randomNumber] == 0)
                        {
                            return randomNumber;
                        }
                    }
                }
            }

            // otherwise, we random the free button
            int[] free = new int[10];
            int freeSize = 0;
            for (int k = 1; k <= 9; ++k)
            {
                if (Movement[k] == 0) // it is free
                {
                    freeSize++;
                    free[k] = k;

                }
            }

            Random rad = new Random();
            int freeRad = rad.Next(0, freeSize);
            int randomFree = free[freeRad];
            rad = null;

            return randomFree;


            return 0;



            //end if board

            if (boardNumber % 2 == 1) // in case , AI gets the second move before the oponent
            {
                if (AIstep == 1)
                {
                    AIstep++;
                    if (Movement[5] == 0) return 5;
                    else
                    {
                        int[] numbers = new int[4] { 1, 3, 7, 9 };
                        Random rd = new Random();
                        int first = rd.Next(0, 3);
                        int randomNumber = numbers[first];
                        rd = null;
                        return randomNumber;
                    }
                    if (AIstep == 2)
                    {
                        AIstep++;
                        if (Movement[5] == -1 && Movement[3] == 1)
                        {
                            if (Movement[4] == 1)
                            {
                                int[] numbers = new int[2] { 2, 8 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[7] == 1)
                            {
                                int[] numbers = new int[4] { 4, 6, 2, 8 };
                                Random rd = new Random();
                                int first = rd.Next(0, 3);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[8] == 1)
                            {
                                int[] numbers = new int[2] { 4, 6 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                        }
                        //--------------------------------------
                        else if (Movement[5] == -1 && Movement[1] == 1)
                        {
                            if (Movement[6] == 1)
                            {
                                int[] numbers = new int[2] { 2, 8 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[9] == 1)
                            {
                                int[] numbers = new int[4] { 4, 6, 2, 8 };
                                Random rd = new Random();
                                int first = rd.Next(0, 3);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[8] == 1)
                            {
                                int[] numbers = new int[2] { 4, 6 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                        }
                        //--------------------------------------------------
                        else if (Movement[5] == -1 && Movement[7] == 1)
                        {
                            if (Movement[6] == 1)
                            {
                                int[] numbers = new int[2] { 2, 8 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[3] == 1)
                            {
                                int[] numbers = new int[4] { 4, 6, 2, 8 };
                                Random rd = new Random();
                                int first = rd.Next(0, 3);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[2] == 1)
                            {
                                int[] numbers = new int[2] { 4, 6 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                        }
                        //-------------------------------------------------
                        else if (Movement[5] == -1 && Movement[9] == 1)
                        {
                            if (Movement[4] == 1)
                            {
                                int[] numbers = new int[2] { 2, 8 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[1] == 1)
                            {
                                int[] numbers = new int[4] { 4, 6, 2, 8 };
                                Random rd = new Random();
                                int first = rd.Next(0, 3);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[2] == 1)
                            {
                                int[] numbers = new int[2] { 4, 6 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                        }
                        //if x put in even
                        else if (Movement[5] == -1 && Movement[2] == 1)
                        {
                            if (Movement[4] == 1)
                            {
                                int[] numbers = new int[2] { 1, 7 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[7] == 1)
                            {
                                int[] numbers = new int[2] { 1, 4 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[6] == 1)
                            {
                                int[] numbers = new int[2] { 3, 9 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[9] == 1)
                            {
                                int[] numbers = new int[2] { 3, 6 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[8] == 1)
                            {
                                int[] numbers = new int[2] { 4, 6 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                        }
                        //--------------------------------------------
                        else if (Movement[5] == -1 && Movement[4] == 1)
                        {
                            if (Movement[2] == 1)
                            {
                                int[] numbers = new int[2] { 1, 3 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[3] == 1)
                            {
                                int[] numbers = new int[2] { 1, 2 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[8] == 1)
                            {
                                int[] numbers = new int[2] { 7, 9 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[9] == 1)
                            {
                                int[] numbers = new int[2] { 7, 8 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[6] == 1)
                            {
                                int[] numbers = new int[2] { 2, 8 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                        }
                        //------------------------------------------------------------
                        else if (Movement[5] == -1 && Movement[6] == 1)
                        {
                            if (Movement[1] == 1)
                            {
                                int[] numbers = new int[2] { 2, 3 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[2] == 1)
                            {
                                int[] numbers = new int[2] { 1, 3 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[7] == 1)
                            {
                                int[] numbers = new int[2] { 8, 9 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[8] == 1)
                            {
                                int[] numbers = new int[2] { 7, 9 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[4] == 1)
                            {
                                int[] numbers = new int[2] { 2, 8 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                        }
                        //-------------------------------------------------
                        else if (Movement[5] == -1 && Movement[8] == 1)
                        {
                            if (Movement[1] == 1)
                            {
                                int[] numbers = new int[2] { 4, 7 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[4] == 1)
                            {
                                int[] numbers = new int[2] { 1, 7 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[3] == 1)
                            {
                                int[] numbers = new int[2] { 6, 9 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[6] == 1)
                            {
                                int[] numbers = new int[2] { 3, 9 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                            if (Movement[2] == 1)
                            {
                                int[] numbers = new int[2] { 4, 6 };
                                Random rd = new Random();
                                int first = rd.Next(0, 1);
                                int randomNumber = numbers[first];
                                rd = null;
                                return randomNumber;
                            }
                        }
                        //other  x is 5
                        else if (Movement[5] == 1 && Movement[3] == -1 && Movement[7] == 1)
                        {
                            int[] numbers = new int[2] { 1, 9 };
                            Random rd = new Random();
                            int first = rd.Next(0, 1);
                            int randomNumber = numbers[first];
                            rd = null;
                            return randomNumber;
                        }
                        else if (Movement[5] == 1 && Movement[7] == -1 && Movement[3] == 1)
                        {
                            int[] numbers = new int[2] { 1, 9 };
                            Random rd = new Random();
                            int first = rd.Next(0, 1);
                            int randomNumber = numbers[first];
                            rd = null;
                            return randomNumber;
                        }
                        else if (Movement[5] == 1 && Movement[9] == -1 && Movement[1] == 1)
                        {
                            int[] numbers = new int[2] { 3, 7 };
                            Random rd = new Random();
                            int first = rd.Next(0, 1);
                            int randomNumber = numbers[first];
                            rd = null;
                            return randomNumber;
                        }
                        else if (Movement[5] == 1 && Movement[1] == -1 && Movement[9] == 1)
                        {
                            int[] numbers = new int[2] { 3, 7 };
                            Random rd = new Random();
                            int first = rd.Next(0, 1);
                            int randomNumber = numbers[first];
                            rd = null;
                            return randomNumber;
                        }
                    }//end step 2



                    // otherwise, we random the free button
                    //  MessageBox.Show("5=" + Movement[5].ToString());
                    //   MessageBox.Show("Sokhong Tiang");

                    if (Movement[5] == 0) return 5;
                    int[] f = new int[10];
                    int fs = 0;
                    for (int k = 1; k <= 9; ++k)
                    {
                        if (Movement[k] == 0) // it is free
                        {
                            fs++;
                            f[k] = k;

                        }
                    }
                    Random r = new Random();
                    int fr = r.Next(0, fs);
                    int rf = f[fr];
                    r = null;
                    return rf;



                }//end if board

                return 0;
            }



        } // end of function


        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        void AIMovement()
        {
            int AI = 0;
            // AI = BestMove_MediumLevel();
            //  AI = BestMove_AdvanceLevel();
            if (AILevel==1)
            {
                AI = BestMove();
            }
            else if (AILevel==2)
            {
                AI = BestMove_MediumLevel();
            }
            else if (AILevel==3)
            {
                AI = BestMove_level3();
            }
            else if (AILevel==4)
            {
                AI = BestMove_Level4();
            }
            else if (AILevel==5)
            {
                AI = BestMove_Level5();
            }
            else
            {
                AI = BestMove_Level6();
            }
          //  AI = BestMove_Level5();



            if (AI == 1)
            {
                LabelTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.Text = ("x");

                Button1.ForeColor = Color.Red;
                Button1.Text = ("o");
                isXturn = true;
                btn1IsAlreadyClicked = true;
                Movement[1] = -1;
                boardIsTie[1] = 1;

                DetectWinner();
                IsTie();
                return;
            }
            if (AI == 2)
            {
                LabelTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.Text = ("x");

                Button2.ForeColor = Color.Red;
                Button2.Text = ("o");
                isXturn = true;
                btn2IsAlreadyClicked = true;
                Movement[2] = -1;
                boardIsTie[2] = 1;

                DetectWinner();
                IsTie();
                return;
            }
            if (AI == 3)
            {
                LabelTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.Text = ("x");

                Button3.ForeColor = Color.Red;
                Button3.Text = ("o");
                isXturn = true;
                btn3IsAlreadyClicked = true;
                Movement[3] = -1;
                boardIsTie[3] = 1;

                DetectWinner();
                IsTie();
                return;
            }
            if (AI == 4)
            {
                LabelTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.Text = ("x");

                Button4.ForeColor = Color.Red;
                Button4.Text = ("o");
                isXturn = true;
                btn4IsAlreadyClicked = true;
                Movement[4] = -1;
                boardIsTie[4] = 1;

                DetectWinner();
                IsTie();
                return;
            }
            if (AI == 5)
            {
                LabelTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.Text = ("x");

                Button5.ForeColor = Color.Red;
                Button5.Text = ("o");
                isXturn = true;
                btn5IsAlreadyClicked = true;
                Movement[5] = -1;
                boardIsTie[5] = 1;

                DetectWinner();
                IsTie();
                return;
            }
            if (AI == 6)
            {
                LabelTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.Text = ("x");

                Button6.ForeColor = Color.Red;
                Button6.Text = ("o");
                isXturn = true;
                btn6IsAlreadyClicked = true;
                Movement[6] = -1;
                boardIsTie[6] = 1;

                DetectWinner();
                IsTie();
                return;
            }
            if (AI == 7)
            {
                LabelTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.Text = ("x");

                Button7.ForeColor = Color.Red;
                Button7.Text = ("o");
                isXturn = true;
                btn7IsAlreadyClicked = true;
                Movement[7] = -1;
                boardIsTie[7] = 1;

                DetectWinner();
                IsTie();
                return;
            }
            if (AI == 8)
            {
                LabelTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.Text = ("x");

                Button8.ForeColor = Color.Red;
                Button8.Text = ("o");
                isXturn = true;
                btn8IsAlreadyClicked = true;
                Movement[8] = -1;
                boardIsTie[8] = 1;

                DetectWinner();
                IsTie();
                return;
            }
            if (AI == 9)
            {
                LabelTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.ForeColor = Color.Blue;
                LabelPlayerTurn.Text = ("x");

                Button9.ForeColor = Color.Red;
                Button9.Text = ("o");
                isXturn = true;
                btn9IsAlreadyClicked = true;
                Movement[9] = -1;
                boardIsTie[9] = 1;

                DetectWinner();
                IsTie();
                return;
            }
        }// end of function AIMovement
    }
    //---------------------------------------------------------------------------
    
}

