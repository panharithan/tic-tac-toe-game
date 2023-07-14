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
    public partial class FormPlayBoard : Form
    {
        /* Declare variables*/
        string userPlay = "";

        const int lengthOfBoard = 880;
        const int heighOfBoard = 680;
        const int lengthOfGrid = 40;
        const int totalRow = heighOfBoard / lengthOfGrid;
        const int totalColumn = lengthOfBoard / lengthOfGrid;
        int x, y;
        bool isPlaying = false;

        int[,] Movement = new int[totalRow + 1, totalColumn + 1]; // we will now use zero-indexes
        int[,] defend = new int[totalRow + 1, totalColumn + 1];
        int[] RangeRow = new int[totalRow + 1];
        int[] RangeColumn = new int[totalColumn + 1];
        int findIndexRow = 0;
        int findIndexColumn = 0;
        int turnIn2PlayerMode = 1;// 1 is x , 2 is o
        int turnIn3PlayerMode = 1; // 1 is x , 2 is o, is +
        int playerMode = 1;
        int boardNumber = 0;
        int xWin = 0;
        int oWin = 0;
        int plusWin = 0;
        bool isDraw = true;
        bool singleModeWinner = false;
        int singleModeLevel = 4;//1;
               //timer
        int h = 0;
        int m = 0;
        int s = 0;
        int total = 0;


        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        public FormPlayBoard()
        {
            InitializeComponent();
            SetRangeRowAndColumn();
        }

        /* ....... Logic of the program ........ */
        private void Challenge1()
        {
            buttonSave.Enabled = true;
            buttonPlayerMode.Visible = false;
            labelPlayerMode.Visible = false;

            pictureBox1.Visible = true;
            labelPlayer1.Visible = true;
            pictureBox2.Visible = true;
            labelPlayer2.Visible = true;
           // ResourceSet rs = new ResourceSet("userChoise.resx");
          //  string userChoise = rs.GetString("game");
           // rs.Close();
            string userChoise = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\temp";

            string s = userChoise + @"\save.txt";
            StreamReader StReader = new StreamReader(s);
            string player = StReader.ReadLine();
            StReader.Close();
            labelPlayer1.ForeColor = Color.White;
            labelPlayer1.BackColor = Color.Blue;
            labelPlayer1.Text = player;

            userChoise = userChoise + @"\avatar";
            // MessageBox.Show(userChoise);
          
            labelPlayer2.BackColor = Color.Red;
            labelPlayer2.ForeColor = Color.White;
            labelPlayer2.Text = "A.I";

            labelXvictory.Text = player.ToString();
            labelOvictory.Text = "AI";


            pictureBox1.ImageLocation = userChoise;

            ResourceSet resourceSet = new ResourceSet("SettingChoise.resx");

            string levell = resourceSet.GetString("level");

            resourceSet.Close();

            // Avatar of A.I
            try
            {
           //     MessageBox.Show(levell);
                if (levell == "1")
                {
                    pictureBox2.Image = Properties.Resources.spiderMinion;
                    singleModeLevel = 1;
                }

           else     if (levell == "2")
                {
                    pictureBox2.Image = Properties.Resources.wolveMinion;
                    singleModeLevel = 2;

                }
                else if (levell == "3")
                {
                    pictureBox2.Image = Properties.Resources.dracMinion;
                    singleModeLevel = 3;

                }
                else if (levell == "4")
                {
                    pictureBox2.Image = Properties.Resources.minionCreed;
                    singleModeLevel = 4;

                }
                else if (levell == "5")
                {
                    pictureBox2.Image = Properties.Resources.ironMinion;
                    singleModeLevel = 5;

                }
                else if (levell == "6")
                {
                    pictureBox2.Image = Properties.Resources.capMinion;

                }

                else
                {


                }


            }
            catch
            {

            }
            

        }

        private void Challenge2()
        {
            buttonSave.Enabled = true;
            playerMode = 2;
            buttonPlayerMode.Visible = false;
            labelPlayerMode.Visible = false;

            pictureBox1.Visible = true;
            labelPlayer1.Visible = true;
            pictureBox2.Visible = true;
            labelPlayer2.Visible = true;
            labelPlayer1.ForeColor = Color.White;
            labelPlayer2.ForeColor = Color.White;
            labelPlayer1.BackColor = Color.Blue;
            labelPlayer2.BackColor = Color.Red;
            ResourceSet rs = new ResourceSet("userChoise.resx");
            string userChoise= rs.GetString("game");
            rs.Close();
         
            string player1 = "";
            string player2 = "";

         //   string s = userChoise + @"\save.txt";
           // StreamReader StReader = new StreamReader(s);
            string userChoisee = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\temp";

            string s = userChoisee + @"\save.txt";
            StreamReader StReader = new StreamReader(s);

            for (int i = 1; i <= 3; ++i)
            {
                if (i == 1)
                {
                    player1 = StReader.ReadLine();
                }
                else if (i == 2)
                {
                    string str = StReader.ReadLine();
                }
                else if (i == 3)
                {
                    player2 = StReader.ReadLine();

                }
            }



            StReader.Close();

            labelPlayer2.Text = player2.ToString();
            labelPlayer1.Text = player1.ToString();
            labelXvictory.Text= player1.ToString();
            labelOvictory.Text= player2.ToString();

            string pic1Loc = userChoisee + @"\avatar1";
            string pic2Loc = userChoisee + @"\avatar2";

            pictureBox1.ImageLocation = pic1Loc;
            pictureBox2.ImageLocation = pic2Loc;


        }

        private void Challenge3()
        {
            playerMode = 3;

            buttonSave.Enabled = true;
            buttonPlayerMode.Visible = false;
            labelPlayerMode.Visible = false;

            pictureBox1.Visible = true;
            labelPlayer1.Visible = true;
            pictureBox2.Visible = true;
            labelPlayer2.Visible = true;
            pictureBox3.Visible = true;
            labelPlayer3.Visible = true;
            
            labelPlayer1.ForeColor = Color.White;
            labelPlayer2.ForeColor = Color.White;
            labelPlayer3.ForeColor = Color.White;
            labelPlayer1.BackColor = Color.Blue;
            labelPlayer2.BackColor = Color.Red;
            labelPlayer3.BackColor = Color.Black;
            



            ResourceSet rs = new ResourceSet("userChoise.resx");
           string userChoise = rs.GetString("game");
            rs.Close();
            string userChoisee = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\temp";

         //   string s = userChoisee + @"\save.txt";

            string player1 = "";
            string player2 = "";
            string player3 = "";

            string s = userChoisee + @"\save.txt";
            StreamReader StReader = new StreamReader(s);


            for (int i = 1; i <= 5; ++i)
            {
                if (i == 1)
                {
                    player1 = StReader.ReadLine();
                }
                else if (i == 2)
                {
                    string str = StReader.ReadLine();
                }
                else if (i == 3)
                {
                    player2 = StReader.ReadLine();

                }
                else if (i == 4)
                {
                    string str = StReader.ReadLine();
                }
                else if (i == 5)
                {
                    player3 = StReader.ReadLine();
                }
            }



            StReader.Close();

            labelPlayer2.Text = player2.ToString();
            labelPlayer1.Text = player1.ToString();
            labelPlayer3.Text = player3.ToString();
            labelXvictory.Text = player1.ToString();
            labelOvictory.Text = player2.ToString();
           

            string pic1Loc = userChoisee + @"\avatar1";
            string pic2Loc = userChoisee + @"\avatar2";
            string pic3Loc = userChoisee + @"\avatar3";
            pictureBox1.ImageLocation = pic1Loc;
            pictureBox2.ImageLocation = pic2Loc;
            pictureBox3.ImageLocation = pic3Loc;
        }

        // >>>>>>>>>>>>>>
        private void Timer1()
        {

            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;

            buttonSave.Enabled = true;
            buttonPlayerMode.Visible = false;
            labelPlayerMode.Visible = false;

            pictureBox1.Visible = true;
            labelPlayer1.Visible = true;
            pictureBox2.Visible = true;
            labelPlayer2.Visible = true;
            // ResourceSet rs = new ResourceSet("userChoise.resx");
            //  string userChoise = rs.GetString("game");
            // rs.Close();
            string userChoise = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\temp";

            string s = userChoise + @"\save.txt";
            StreamReader StReader = new StreamReader(s);
            string player = StReader.ReadLine();
            StReader.Close();
            labelPlayer1.ForeColor = Color.White;
            labelPlayer1.BackColor = Color.Blue;
            labelPlayer1.Text = player;

            userChoise = userChoise + @"\avatar";
            // MessageBox.Show(userChoise);

            labelPlayer2.BackColor = Color.Red;
            labelPlayer2.ForeColor = Color.White;
            labelPlayer2.Text = "A.I";

            labelXvictory.Text = player.ToString();
            labelOvictory.Text = "AI";


            pictureBox1.ImageLocation = userChoise;

            ResourceSet resourceSet = new ResourceSet("SettingChoise.resx");

            string levell = resourceSet.GetString("level");

            resourceSet.Close();


            // Avatar of A.I
            try
            {
                //     MessageBox.Show(levell);
                if (levell == "1")
                {
                    pictureBox2.Image = Properties.Resources.spiderMinion;
                    singleModeLevel = 1;
                }

                else if (levell == "2")
                {
                    pictureBox2.Image = Properties.Resources.wolveMinion;
                    singleModeLevel = 2;

                }
                else if (levell == "3")
                {
                    pictureBox2.Image = Properties.Resources.dracMinion;
                    singleModeLevel = 3;

                }
                else if (levell == "4")
                {
                    pictureBox2.Image = Properties.Resources.minionCreed;
                    singleModeLevel = 4;

                }
                else if (levell == "5")
                {
                    pictureBox2.Image = Properties.Resources.ironMinion;
                    singleModeLevel = 5;

                }
                else if (levell == "6")
                {
                    pictureBox2.Image = Properties.Resources.capMinion;

                }

                else
                {


                }


            }
            catch
            {

            }

        }

        private void Timer2()
        {

        }


        private void Timer3()
        {

        }
        private void OnePlayer()
        {

            pictureBox1.Visible = true;
            labelPlayer1.Visible = true;

            Random rd = new Random();
            int picture = rd.Next(0, 16);
            //  clear = picture;
            rd = null;

            if (picture == 1)
            {
                pictureBox1.Image = Properties.Resources._1;
            }
            else if (picture == 2)
            {
                pictureBox2.Image = Properties.Resources._2;
            }
            else if (picture == 3)
            {
                pictureBox1.Image = Properties.Resources._3;
            }
            else if (picture == 4)
            {
                pictureBox1.Image = Properties.Resources._4;
            }
            else if (picture == 5)
            {
                pictureBox1.Image = Properties.Resources._5;
            }
            else if (picture == 6)
            {
                pictureBox1.Image = Properties.Resources._6;
            }
            else if (picture == 7)
            {
                pictureBox1.Image = Properties.Resources._7;
            }
            else if (picture == 8)
            {
                pictureBox1.Image = Properties.Resources._8;

            }
            else if (picture == 9)
            {
                pictureBox1.Image = Properties.Resources._9;
            }
            else if (picture == 10)
            {
                pictureBox1.Image = Properties.Resources._10;
            }
            else if (picture == 11)
            {
                pictureBox1.Image = Properties.Resources._11;
            }
            else if (picture == 12)
            {
                pictureBox1.Image = Properties.Resources._12;
            }
            else if (picture == 13)
            {
                pictureBox1.Image = Properties.Resources._13;
            }

            else if (picture == 14)
            {
                pictureBox1.Image = Properties.Resources._14;
            }

            else if (picture == 15)
            {
                pictureBox1.Image = Properties.Resources._15;
            }
            else
            {
                pictureBox1.Image = Properties.Resources._16;
            }





            pictureBox2.Visible = true;
            labelPlayer2.Visible = true;
            labelPlayer2.Text = ("A.I");
            // buttonSave.Visible = false;
            buttonSave.Enabled = false;
            labelXvictory.Text = "Player 1";
            labelOvictory.Text = "AI";
            buttonPlayerMode.Visible = true;
            labelPlayerMode.Visible = true;
            ResourceSet resourceSet = new ResourceSet("SettingChoise.resx");

            string levell = resourceSet.GetString("level");

            resourceSet.Close();

            // Avatar of A.I
            try
            {
                //     MessageBox.Show(levell);
                if (levell == "1")
                {
                    pictureBox2.Image = Properties.Resources.spiderMinion;
                    singleModeLevel = 1;
                }

                else if (levell == "2")
                {
                    pictureBox2.Image = Properties.Resources.wolveMinion;
                    singleModeLevel = 2;

                }
                else if (levell == "3")
                {
                    pictureBox2.Image = Properties.Resources.dracMinion;
                    singleModeLevel = 3;

                }
                else if (levell == "4")
                {
                    pictureBox2.Image = Properties.Resources.minionCreed;
                    singleModeLevel = 4;

                }
                else if (levell == "5")
                {
                    pictureBox2.Image = Properties.Resources.ironMinion;
                    singleModeLevel = 5;

                }
                else if (levell == "6")
                {
                    pictureBox2.Image = Properties.Resources.capMinion;
                    singleModeLevel = 6;

                }

                else
                {


                }
            }
            catch
            {
            }


        }

        private void ActivateTheBoard(string boardLoc,string infoLoc)
        {
           // MessageBox.Show(boardLoc);
            if (!File.Exists(boardLoc))
            {
                MessageBox.Show("Board is error!","Tic-Tac-Toe 5 in a row" );
                return;
            }
            List<string> lines = new List<string>();
            using (StreamReader r = new StreamReader(boardLoc))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            //MessageBox.Show(lines.Count.ToString());
            if (lines.Count!=17 && lines.Count!=18)
            {
                MessageBox.Show("Board is error!", "Tic-Tac-Toe 5 in a row");
                return;
            }
            int row = 1;
            for (row =0;row<lines.Count -1;++row)
            {
                string theMove = lines[row ];
                char c = theMove[0];
                for (int column=0;column<22;++column)
                {
                    if (c=='0')
                    {
                        Movement[row + 1, column + 1] = 0;
                    }
                    else if (c=='1')
                    {
                        Movement[row + 1, column + 1] = 1;

                    }
                    else if (c=='2')
                    {
                        Movement[row+1, column + 1] = -1;


                    }
                    else if (c=='3')
                    {
                        Movement[row+1, column + 1] = 10;

                    }

                    c = theMove[column];
                }

            }

            
            StreamReader sr = new StreamReader(infoLoc);
            string gameType = sr.ReadLine();
            sr.Close();
            if (gameType == "c2")
            {
                playerMode = 2;
                
                // working with the turn 
                int i = lines.Count;
                if (lines[i - 1] == "1")// it is x
                {
                    labelTurn.BackColor = Color.Blue;
                    labelTurn.Text = "Turn player X";
                    turnIn2PlayerMode = 1;
                }
                else if (lines[i - 1] == "2") // it is o
                {
                    
                    labelTurn.BackColor = Color.Red;
                    labelTurn.Text = "Turn player O";
                    turnIn2PlayerMode = 2;
                }
            }
            else if (gameType == "c3")
            {
                playerMode = 3;

                // working with the turn 
                int i = lines.Count;
                if (lines[i - 1] == "1")// it is x
                {
                    labelTurn.BackColor = Color.Blue;
                    labelTurn.Text = "Turn player X";
                    turnIn2PlayerMode = 1;
                }
                else if (lines[i - 1] == "2") // it is o
                {

                    labelTurn.BackColor = Color.Red;
                    labelTurn.Text = "Turn player O";
                    turnIn2PlayerMode = 2;
                }
                else if (lines[i - 1] == "3")
                {

                    labelTurn.BackColor = Color.Black;
                    labelTurn.Text = "Turn player +f";

                }
             //   else
             //   {
              //      MessageBox.Show("Board is error!", "Tic-Tac-Toe 5 in a row");
             //   }

            }
            else
            {
                playerMode = 1;
            }
            

            MessageBox.Show("Welcome back!","Tic-Tac-Toe 5 in a row");
            isPlaying = true;
            RefreshBoard();
            DetectWinner();
           // buttonRefresh.Text = "Continue";

        }
        private void LoadGameRequest()
        {
            ResourceSet rs = new ResourceSet("LoadGameRequest.resx");
            string loadGameLocation = rs.GetString("gameLocationRequest");
            rs.Close();


            string infoSaveFile = loadGameLocation + @"\info.txt";
            //MessageBox.Show(infoSaveFile);
            //return;
            if (File.Exists(infoSaveFile))
            {
                //  string loadGame = @"\loadGame";
                StreamReader sr = new StreamReader(infoSaveFile);
                string gameType = sr.ReadLine();
                sr.Close();

                if (gameType == "c1")
                {
                    playerMode = 1;
                    
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    labelPlayer1.Visible = true;
                    labelPlayer2.Visible = true;
                    labelBoard.Visible = true;
                    labelBoardTitle.Visible = true;
                    labelXvictory.Visible = true;
                    labelXvictoryCount.Visible = true;
                    labelOvictory.Visible = true;
                    labelOvictoryCount.Visible = true;
                    buttonSave.Enabled = true;

                    List<string> lines = new List<string>();
                    using (StreamReader r = new StreamReader(infoSaveFile))
                    {
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            lines.Add(line);
                        }
                    }
                    int theSize = lines.Count;

                    if (theSize != 6)
                    {
                        MessageBox.Show("Game is error! ");
                        return;
                    }

                    string theAvatar = loadGameLocation + @"\Avatar";
                    if (File.Exists(theAvatar)) // show the avatar
                    {
                        pictureBox1.ImageLocation = theAvatar;
                    }

                    labelPlayer1.Text = lines[1]; // show the name of the player
                                                  // Avatar of A.I
                        try
                        {
                            //     MessageBox.Show(levell);S
                            if (lines[2] == "1")
                            {
                                pictureBox2.Image = Properties.Resources.spiderMinion;
                                singleModeLevel = 1;
                            }

                            else if (lines[2] == "2")
                            {
                                pictureBox2.Image = Properties.Resources.wolveMinion;
                                singleModeLevel = 2;

                            }
                            else if (lines[2] == "3")
                            {
                                pictureBox2.Image = Properties.Resources.dracMinion;
                                singleModeLevel = 3;

                            }
                            else if (lines[2] == "4")
                            {
                                pictureBox2.Image = Properties.Resources.minionCreed;
                                singleModeLevel = 4;

                            }
                            else if (lines[2] == "5")
                            {
                                pictureBox2.Image = Properties.Resources.ironMinion;
                                singleModeLevel = 5;

                            }
                            else if (lines[2] == "6")
                            {
                                pictureBox2.Image = Properties.Resources.capMinion;
                                singleModeLevel = 6;

                            }

                            else
                            {


                            }


                        }
                        catch
                        {

                        }

                        labelPlayer2.Text = ("AI");
                        labelPlayer3.Text = "";
                    // pictureBox3.ImageLocation = null;
                    
                    labelXvictoryCount.Text = lines[3];
                    labelOvictoryCount.Text = lines[4];
                    labelBoard.Text = lines[5];
                    string boardLoc= loadGameLocation + @"\board.txt";

                    ActivateTheBoard(boardLoc,infoSaveFile);

                }
                else if (gameType == "c2")
                {
                    playerMode = 2;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    labelPlayer1.Visible = true;
                    labelPlayer2.Visible = true;
                    labelBoard.Visible = true;
                    labelBoardTitle.Visible = true;
                    labelXvictory.Visible = true;
                    labelXvictoryCount.Visible = true;
                    labelOvictory.Visible = true;
                    labelOvictoryCount.Visible = true;
                    buttonSave.Enabled = true;
                    labelTurn.Visible = true;

                    List<string> lines = new List<string>();

                    using (StreamReader r = new StreamReader(infoSaveFile))
                    {
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            lines.Add(line);
                        }
                    }
                    int theSize = lines.Count;

                    if (theSize != 6)
                    {
                        MessageBox.Show("Game is error! ");
                        return;
                    }

                    string theAvatar1 = loadGameLocation + @"\Avatar1";
                    if (File.Exists(theAvatar1)) // show the avatar
                    {
                        pictureBox1.ImageLocation = theAvatar1;
                    }

                    labelPlayer1.Text = lines[1]; // show the name of the player
                    string theAvatar2 = loadGameLocation + @"\Avatar2";
                    if (File.Exists(theAvatar2)) // show the avatar
                    {
                        pictureBox2.ImageLocation = theAvatar2;
                    }

                    labelPlayer2.Text = lines[2]; // show the name of the player
                    labelPlayer3.Text = "";
                    pictureBox3.ImageLocation = null;

                    labelXvictoryCount.Text = lines[3];
                    labelOvictoryCount.Text = lines[4];
                    labelBoard.Text = lines[5];
                    string boardLoc = loadGameLocation + @"\board.txt";
                    ActivateTheBoard(boardLoc,infoSaveFile);



                }
                else if (gameType == "c3")
                {
                    playerMode = 3;

                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    labelPlayer1.Visible = true;
                    labelPlayer2.Visible = true;
                    labelPlayer3.Visible = true;
                    labelBoard.Visible = true;
                    labelBoardTitle.Visible = true;
                    labelXvictory.Visible = true;
                    labelXvictoryCount.Visible = true;
                    labelOvictory.Visible = true;
                    labelOvictoryCount.Visible = true;
                    labelPlusVictory.Visible = true;
                    labelPlusVictoryCount.Visible = true;
                    buttonSave.Enabled = true;
                    labelTurn.Visible = true;
                    List<string> lines = new List<string>();

                    using (StreamReader r = new StreamReader(infoSaveFile))
                    {
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            lines.Add(line);
                        }
                    }
                    int theSize = lines.Count;

                    if (theSize != 8)
                    {
                        MessageBox.Show("Game is error! ");
                        return;
                    }

                    string theAvatar1 = loadGameLocation + @"\Avatar1";
                    if (File.Exists(theAvatar1)) // show the avatar
                    {
                        pictureBox1.ImageLocation = theAvatar1;
                    }

                    labelPlayer1.Text = lines[1]; // show the name of the player
                    string theAvatar2 = loadGameLocation + @"\Avatar2";
                    if (File.Exists(theAvatar2)) // show the avatar
                    {
                        pictureBox2.ImageLocation = theAvatar2;
                    }

                    labelPlayer2.Text = lines[2]; // show the name of the player
                                                  //------------
                    string theAvatar3 = loadGameLocation + @"\Avatar3";
                    if (File.Exists(theAvatar3)) // show the avatar
                    {
                        pictureBox3.ImageLocation = theAvatar3;
                    }
                    labelPlayer3.Text = lines[3] ;

                    labelXvictoryCount.Text = lines[4];
                    labelOvictoryCount.Text = lines[5];
                    labelPlusVictoryCount.Text = lines[6];
                    labelBoard.Text = lines[7];


                    string boardLoc = loadGameLocation + @"\board.txt";
                    ActivateTheBoard(boardLoc, infoSaveFile);

                }
                else if (gameType == "t1")
                {
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;


                    playerMode = 1;

                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    labelPlayer1.Visible = true;
                    labelPlayer2.Visible = true;
                    labelBoard.Visible = true;
                    labelBoardTitle.Visible = true;
                    labelXvictory.Visible = true;
                    labelXvictoryCount.Visible = true;
                    labelOvictory.Visible = true;
                    labelOvictoryCount.Visible = true;
                    buttonSave.Enabled = true;

                    List<string> lines = new List<string>();
                    using (StreamReader r = new StreamReader(infoSaveFile))
                    {
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            lines.Add(line);
                        }
                    }
                    int theSize = lines.Count;

                    if (theSize != 6 +1 )
                    {
                        MessageBox.Show("Game is error! ");
                        return;
                    }

                    string theAvatar = loadGameLocation + @"\Avatar";
                    if (File.Exists(theAvatar)) // show the avatar
                    {
                        pictureBox1.ImageLocation = theAvatar;
                    }

                    labelPlayer1.Text = lines[1]; // show the name of the player
                                                  // Avatar of A.I
                    try
                    {
                        //     MessageBox.Show(levell);S
                        if (lines[2] == "1")
                        {
                            pictureBox2.Image = Properties.Resources.spiderMinion;
                            singleModeLevel = 1;
                        }

                        else if (lines[2] == "2")
                        {
                            pictureBox2.Image = Properties.Resources.wolveMinion;
                            singleModeLevel = 2;

                        }
                        else if (lines[2] == "3")
                        {
                            pictureBox2.Image = Properties.Resources.dracMinion;
                            singleModeLevel = 3;

                        }
                        else if (lines[2] == "4")
                        {
                            pictureBox2.Image = Properties.Resources.minionCreed;
                            singleModeLevel = 4;

                        }
                        else if (lines[2] == "5")
                        {
                            pictureBox2.Image = Properties.Resources.ironMinion;
                            singleModeLevel = 5;

                        }
                        else if (lines[2] == "6")
                        {
                            pictureBox2.Image = Properties.Resources.capMinion;
                            singleModeLevel = 6;

                        }

                        else
                        {


                        }


                    }
                    catch
                    {

                    }

                    labelPlayer2.Text = ("AI");
                    labelPlayer3.Text = "";
                    // pictureBox3.ImageLocation = null;

                    labelXvictoryCount.Text = lines[3];
                    labelOvictoryCount.Text = lines[4];
                    labelBoard.Text = lines[5];
                    string boardLoc = loadGameLocation + @"\board.txt";
                    ActivateTheBoard(boardLoc, infoSaveFile);

                    // working with the timer. 
                    int theTime = StringToInt(lines[6]);
                    // MessageBox.Show(theTime.ToString());
                    h = 0;
                    m = 0;
                    s = 0;
                    h = theTime / 3600;
                    int remain1 = theTime - (m * 3600);
                    m = remain1 / 60;
                    s = remain1 - (m * 60);

                    //labelTime.Text += hour.ToString() + "H " + second.ToString() + "Min " + second.ToString() + "Second";
                    timer4.Start();




                    


                }
                //-------------------------------------------------------------------------
            }
            else if (!File.Exists(infoSaveFile))
            {
                MessageBox.Show(infoSaveFile);
                MessageBox.Show("File is not found!");
            }

        
          

        }


        //.............................................. .Logic
        //.......................................


        private void FormPlayBoard_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;




            buttonPlayerMode.Visible = false;
            labelPlayerMode.Visible = false;
            buttonSave.Enabled = false;
            labelTurn.Visible = false;
            SetRangeRowAndColumn();
            labelVictory.Text = ("");
            buttonNewgame.Text = "Start";
            buttonPlayerMode.Visible = false;
            //labelResult.Text = "Result & Victory";

            labelPlayer1.Visible = false;
            labelPlayer2.Visible = false;
            labelPlayer3.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            labelPlusVictoryCount.Text = "0";
            labelXvictoryCount.Text = "0";
            labelOvictoryCount.Text = "0";
            labelPlayerMode.Visible = false;

            labelResult.Visible = false;
            labelBoardTitle.Visible = false;
            //   labelVictory.Visible = false;
            labelXvictory.Visible = false;
            labelXvictoryCount.Visible = false;
            labelOvictory.Visible = false;
            labelOvictoryCount.Visible = false;
            labelPlusVictory.Visible = false;
            labelPlusVictoryCount.Visible = false;
            labelBoard.Visible = false;
            labelBoard.Text = "1";

            //  Challenge1();
            //...... check the user choise before request 
            ResourceSet rs = new ResourceSet("userChoise.resx");
             userPlay = rs.GetString("choise");
            rs.Close();
          //  MessageBox.Show(userPlay);
            //  MessageBox.Show(userPlay);
            if (userPlay == "c1")
            {
                Challenge1();
            }
            else if (userPlay == "c2")
            {
                Challenge2(); // require a name

            }
            else if (userPlay == "c3")
            {
                Challenge3();

            }
            else if (userPlay == "t1")
            {
                Timer1();
            }
            else if (userPlay == "t2")
            {
                Timer2();

            }

            else if (userPlay == "t1")
            {
                Timer3();

            }
            else if (userPlay == "q") // quickplay
            {

                OnePlayer();
                return;
                pictureBox1.Visible = true;
                labelPlayer1.Visible = true;

                Random rd = new Random();
                int picture = rd.Next(0, 16);
              //  clear = picture;
                rd = null;

                if (picture == 1)
                {
                    pictureBox1.Image = Properties.Resources._1;
                }
                else if (picture == 2)
                {
                    pictureBox2.Image = Properties.Resources._2;
                }
                else if (picture == 3)
                {
                    pictureBox1.Image = Properties.Resources._3;
                }
                else if (picture == 4)
                {
                    pictureBox1.Image = Properties.Resources._4;
                }
                else if (picture == 5)
                {
                    pictureBox1.Image = Properties.Resources._5;
                }
                else if (picture == 6)
                {
                    pictureBox1.Image = Properties.Resources._6;
                }
                else if (picture == 7)
                {
                    pictureBox1.Image = Properties.Resources._7;
                }
                else if (picture == 8)
                {
                    pictureBox1.Image = Properties.Resources._8;

                }
                else if (picture == 9)
                {
                    pictureBox1.Image = Properties.Resources._9;
                }
                else if (picture == 10)
                {
                    pictureBox1.Image = Properties.Resources._10;
                }
                else if (picture == 11)
                {
                    pictureBox1.Image = Properties.Resources._11;
                }
                else if (picture == 12)
                {
                    pictureBox1.Image = Properties.Resources._12;
                }
                else if (picture == 13)
                {
                    pictureBox1.Image = Properties.Resources._13;
                }

                else if (picture == 14)
                {
                    pictureBox1.Image = Properties.Resources._14;
                }

                else if (picture == 15)
                {
                    pictureBox1.Image = Properties.Resources._15;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources._16;
                }





                pictureBox2.Visible = true;
                labelPlayer2.Visible = true;
                labelPlayer2.Text = ("A.I");
                // buttonSave.Visible = false;
                buttonSave.Enabled = false;
                labelXvictory.Text = "Player 1";
                labelOvictory.Text = "AI";
                buttonPlayerMode.Visible = true;
                labelPlayerMode.Visible = true;
                ResourceSet resourceSet = new ResourceSet("SettingChoise.resx");

                string levell = resourceSet.GetString("level");

                resourceSet.Close();

                // Avatar of A.I
                try
                {
                    //     MessageBox.Show(levell);
                    if (levell == "1")
                    {
                        pictureBox2.Image = Properties.Resources.spiderMinion;
                        singleModeLevel = 1;
                    }

                    else if (levell == "2")
                    {
                        pictureBox2.Image = Properties.Resources.wolveMinion;
                        singleModeLevel = 2;

                    }
                    else if (levell == "3")
                    {
                        pictureBox2.Image = Properties.Resources.dracMinion;
                        singleModeLevel = 3;

                    }
                    else if (levell == "4")
                    {
                        pictureBox2.Image = Properties.Resources.minionCreed;
                        singleModeLevel = 4;

                    }
                    else if (levell == "5")
                    {
                        pictureBox2.Image = Properties.Resources.ironMinion;
                        singleModeLevel = 5;

                    }
                    else if (levell == "6")
                    {
                        pictureBox2.Image = Properties.Resources.capMinion;
                        singleModeLevel = 6;

                    }

                    else
                    {


                    }
                }
                catch
                {
                }

            }/////end of function
            else if (userPlay=="L")
            {
                LoadGameRequest();
             }

        }







        /******** Quick Mode ***************/




        //============================================================
        void SetRangeRowAndColumn()
        {
            RangeRow[1] = lengthOfGrid / 2;
            RangeColumn[1] = lengthOfGrid / 2;
            for (int i = 2; i <= totalRow; ++i)
            {
                RangeRow[i] = RangeRow[i - 1] + (lengthOfGrid / 2);

            }

            for (int j = 2; j <= totalColumn; ++j)
            {
                RangeColumn[j] = RangeColumn[j - 1] + (lengthOfGrid / 2);

            }

        }




        //==========================================================
        void ResetBoard()
        {
            for (int i = 1; i <= totalRow; ++i)
            {
                for (int j = 1; j <= totalColumn; ++j)
                {
                    Movement[i, j] = 0;
                    defend[i, j] = 0;

                }
                isDraw = true;
            }
            labelVictory.Text = ("");
            singleModeWinner = false;

            boardNumber++;

            // MessageBox.Show((boardNumber % 2).ToString());
            ResourceSet rs = new ResourceSet("userChoise.resx");
            string userPlay = rs.GetString("choise");
            rs.Close();
            // MessageBox.Show(userPlay);
            
            if (boardNumber % 2 == 0)
            {
                //     MessageBox.Show(userPlay);


                if (userPlay == "c1" || userPlay == "t1" || userPlay == "q")
                {
                    AIMove();
                    //      MessageBox.Show("Hello world");
                }
            }

        }
        //=========================================================
        void DrawBoard()
        {

            Graphics dc = this.CreateGraphics();
            dc.Clear(Color.White);
            this.Show();
            Pen penBoard = new Pen(Color.Maroon, 2);
            dc.DrawRectangle(penBoard, 0, 0, lengthOfBoard, heighOfBoard);

            // 1. draw horizontal lines
            penBoard.Color = Color.BlueViolet;
            // penBoard.Color = Color.Black;
            int y = lengthOfGrid;
            int x1 = 0;
            int x2 = lengthOfBoard;
            for (int i = 1; i <= 16; i++)
            {
                dc.DrawLine(penBoard, x1, y, x2, y);

                y += lengthOfGrid;

            }
            // 2. draw vertical lines
            int x = lengthOfGrid;
            int y1 = 0;
            int y2 = heighOfBoard;
            for (int j = 1; j <= 22; ++j)
            {
                dc.DrawLine(penBoard, x, y1, x, y2);
                x += lengthOfGrid;
            }
        }
        //==============================================================
        protected override void OnMouseClick(MouseEventArgs e)
        {
            
            if (isPlaying == false) return;
            //----------------------------------------------

            base.OnMouseClick(e);
            x = e.X;
            y = e.Y;
            if ((x > 0) && (x < lengthOfBoard) && (y > 0) && (y < heighOfBoard))
            {
                // x = RangeColumn[findIndexColumn];
                //   y = RangeRow[findIndexRow];
                findIndexRow = 1 + (y / lengthOfGrid);
                findIndexColumn = 1 + (x / lengthOfGrid);
                //---------------------------------------------
                if (playerMode == 2)// this is 2 player mode
                {
                    Graphics playerGraphic;
                    Pen penPlayer = new Pen(Color.Blue, 3);
                    playerGraphic = this.CreateGraphics();


                    if (defend[findIndexRow, findIndexColumn] == 1) // grid is already clicked.
                    {
                        return;
                    }

                    //  x = RangeColumn[findIndexColumn];
                    //   y = RangeRow[findIndexRow];
                    x = findIndexColumn * 40;
                    y = findIndexRow * 40;
                    int a = x - 20; int b = y - 20;

                    if (turnIn2PlayerMode == 1) // player X's turn
                    {

                        playerGraphic.DrawLine(penPlayer, a - 10 - 5, b - 10 - 5, a + 10 + 5, b + 10 + 5);
                        playerGraphic.DrawLine(penPlayer, a - 10 - 5, b + 10 + 5, a + 10 + 5, b - 10 - 5);

                        turnIn2PlayerMode = 2;
                        Movement[findIndexRow, findIndexColumn] = 1;
                        defend[findIndexRow, findIndexColumn] = 1;

                        // change to O
                        labelTurn.BackColor = Color.Red;
                        labelTurn.Text = "Player O's turn";
                    }
                    else if (turnIn2PlayerMode == 2)// o's turn
                    {
                        Rectangle myRectangle = new Rectangle();
                        penPlayer = new Pen(Color.Red, 3);
                        playerGraphic = this.CreateGraphics();
                        this.Show();
                        myRectangle.X = a - 20 + 10 - 5;
                        myRectangle.Y = b - 20 + 5;
                        myRectangle.Width = 30;
                        myRectangle.Height = 30;
                        playerGraphic.DrawEllipse(penPlayer, myRectangle);
                        turnIn2PlayerMode = 1;
                        defend[findIndexRow, findIndexColumn] = 1;
                        Movement[findIndexRow, findIndexColumn] = -1;
                        // change to X
                        labelTurn.BackColor = Color.Blue;
                        labelTurn.Text = "Player X's turn";


                    }


                    DetectWinner();



                }
                //------------------------------------------------
                else if (playerMode == 3)// this is 3 player mode
                {





                    Graphics playerGraphic;
                    Pen penPlayer = new Pen(Color.Blue, 3);
                    playerGraphic = this.CreateGraphics();


                    if (defend[findIndexRow, findIndexColumn] == 1) // grid is already clicked.
                    {
                        return;
                    }

                    //  x = RangeColumn[findIndexColumn];
                    //   y = RangeRow[findIndexRow];
                    x = findIndexColumn * 40;
                    y = findIndexRow * 40;
                    int a = x - 20; int b = y - 20;

                    if (turnIn3PlayerMode == 1) // player X's turn
                    {

                        playerGraphic.DrawLine(penPlayer, a - 10 - 5, b - 10 - 5, a + 10 + 5, b + 10 + 5);
                        playerGraphic.DrawLine(penPlayer, a - 10 - 5, b + 10 + 5, a + 10 + 5, b - 10 - 5);

                        turnIn3PlayerMode = 2;
                        Movement[findIndexRow, findIndexColumn] = 1;
                        defend[findIndexRow, findIndexColumn] = 1;
                        // change to O
                        labelTurn.BackColor = Color.Red;
                        labelTurn.Text = "Player O's Turn";
                    }
                    else if (turnIn3PlayerMode == 2)// o's turn
                    {
                        Rectangle myRectangle = new Rectangle();
                        penPlayer = new Pen(Color.Red, 3);
                        playerGraphic = this.CreateGraphics();
                        this.Show();
                        myRectangle.X = a - 20 + 10 - 5;
                        myRectangle.Y = b - 20 + 5;
                        myRectangle.Width = 30;
                        myRectangle.Height = 30;
                        playerGraphic.DrawEllipse(penPlayer, myRectangle);
                        turnIn3PlayerMode = 3;
                        defend[findIndexRow, findIndexColumn] = 1;
                        Movement[findIndexRow, findIndexColumn] = -1;
                        // change to + 
                        labelTurn.BackColor = Color.Black;
                        labelTurn.Text = "Player + 's turn";



                    }
                    else if (turnIn3PlayerMode == 3)
                    {

                        // it is "+" 's turn
                        // draw + symbol


                        penPlayer = new Pen(Color.Black, 3);
                        playerGraphic = this.CreateGraphics();
                        playerGraphic.DrawLine(penPlayer, x - 20, y + 5 - 40, x - 20, y + 35 - 40);
                        playerGraphic.DrawLine(penPlayer, x + 5 - 20 - 20, y + 20 - 40, x + 35 - 20 - 20, y + 20 - 40);

                        turnIn3PlayerMode = 1;
                        defend[findIndexRow, findIndexColumn] = 1;
                        Movement[findIndexRow, findIndexColumn] = 10;
                        // change to player X
                        labelTurn.BackColor = Color.Blue;
                        labelTurn.Text = "Player X's turn";
                    }

                    DetectWinner();
                }
                //---------------------------------------------------
                else if (playerMode == 1)// this is single player mode
                {
                    Graphics playerGraphic;
                    Pen penPlayer = new Pen(Color.Blue, 3);
                    playerGraphic = this.CreateGraphics();


                    if (defend[findIndexRow, findIndexColumn] == 1) // grid is already clicked.
                    {
                        return;
                    }

                    //  x = RangeColumn[findIndexColumn];
                    //   y = RangeRow[findIndexRow];
                    x = findIndexColumn * 40;
                    y = findIndexRow * 40;
                    int a = x - 20; int b = y - 20;

                    playerGraphic.DrawLine(penPlayer, a - 10 - 5, b - 10 - 5, a + 10 + 5, b + 10 + 5);
                    playerGraphic.DrawLine(penPlayer, a - 10 - 5, b + 10 + 5, a + 10 + 5, b - 10 - 5);

                    Movement[findIndexRow, findIndexColumn] = 1;
                    defend[findIndexRow, findIndexColumn] = 1;
                    DetectWinner();

                    //  AIMove(findIndexRow,findIndexColumn);
                    if (singleModeWinner == false)
                    {
                        AIMove();
                    }

                }
                //------------------------------------------------

            }

        }
        //===============================================================
        void NoDrawing()
        {
            isPlaying = false;

        }
        //==================================================================




        
        void DetectWinner()
        {
            if (WinBy_Row())
            {
                isDraw = false;
                isPlaying = false;
                return;
            }

            if (WinBy_Col())
            {
                isDraw = false;
                isPlaying = false;
                return;
            }
            


            if (WinByCross1_ColumnAndRowIncrease())
            {
                isDraw = false;
                isPlaying = false;
                return;
            }

            if (WinByCross2_ColumnAndRowDecrease())
            {
                isDraw = false;
                isPlaying = false;
                return;
            }
        }
        //----------------------------------------------------------------
        bool WinBy_Row()
        {

            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2] +
                                Movement[rowAIMove, columnAIMove + 3] +
                                Movement[rowAIMove, columnAIMove + 4];
                   
                    if (score == -5)
                    {
                        VictoryByRow("o", rowAIMove, columnAIMove);

                        NoDrawing();

                        oWin++;
                        //labelOvictoryCount.ForeColor = Color.Red;
                        labelOvictoryCount.Text = oWin.ToString();


                        return true;
                    }
                    else if (score == +5)
                    {
                        if (playerMode == 1)
                        {
                            singleModeWinner = true;
                        }

                        VictoryByRow("x", rowAIMove, columnAIMove);
                        NoDrawing();
                        xWin++;
                        //   labelXvictoryCount.ForeColor = Color.Blue;
                        labelXvictoryCount.Text = xWin.ToString();
                        return true;

                    }
                    else if (score == 50)
                    {
                        VictoryByRow("+", rowAIMove, columnAIMove);
                        NoDrawing();
                        plusWin++;
                        labelPlusVictoryCount.Text = plusWin.ToString();
                        return true;

                    }


                } // end for loop ColumnOfAI

            } // end for rowOfAI
            return false;
        }

        bool WinBy_Col()
        {

            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove] +
                            Movement[rowAIMove + 3, columnAIMove] +
                            Movement[rowAIMove + 4, columnAIMove];
                    if (score == -5) // there is one move that we can win the game
                    {
                        VictoryByColumn("o", rowAIMove, columnAIMove);

                        NoDrawing();
                        oWin++;
                        //    labelOvictoryCount.ForeColor = Color.Blue;
                        labelOvictoryCount.Text = oWin.ToString();
                        return true;
                    }
                    else if (score == +5)
                    {
                        if (playerMode == 1)
                        {
                            singleModeWinner = true;
                        }
                        VictoryByColumn("x",rowAIMove, columnAIMove);
                        NoDrawing();
                        xWin++;
                        //  labelXvictoryCount.ForeColor = Color.Red;
                        labelXvictoryCount.Text = xWin.ToString();
                        return true;


                    }
                    else if (score == 50)
                    {
                        VictoryByColumn("+", rowAIMove, columnAIMove);
                        NoDrawing();
                        plusWin++;
                        labelPlusVictoryCount.Text = plusWin.ToString();
                        return true;

                    }
                }
            }
            return false;
        }

        bool WinByRow(int row)
        {
            //    MessageBox.Show(row.ToString());




            int column = 1; // start from index 1, we don't use index 0
            int score = 0;

            while (column <= 18)
            {
                score = Movement[row, column] +
                            Movement[row, column + 1] +
                            Movement[row, column + 2] +
                            Movement[row, column + 3] +
                            Movement[row, column + 4];
                if (score == 5)
                {
                    if (playerMode == 1)
                    {
                        singleModeWinner = true;
                    }

                    VictoryByRow("x", row, column);
                    NoDrawing();
                    xWin++;
                 //   labelXvictoryCount.ForeColor = Color.Blue;
                    labelXvictoryCount.Text = xWin.ToString();
                    return true;

                }
                else if (score == -5)
                {
                    VictoryByRow("o", row, column);

                    NoDrawing();

                    oWin++;
                    //labelOvictoryCount.ForeColor = Color.Red;
                    labelOvictoryCount.Text = oWin.ToString();


                    return true;

                }
                else if (score == 50)
                {
                    VictoryByRow("+", row, column);
                    NoDrawing();
                    plusWin++;
                    labelPlusVictoryCount.Text = plusWin.ToString();
                    return true;

                }
                column++;
            }
            return false;
        }

        void VictoryByRow(string player, int rowWinning, int columnWinning)
        {
            Graphics GraphicWinner;
            GraphicWinner = this.CreateGraphics();
            Pen penWinner = new Pen(Color.Blue, 5);

            int y = ((rowWinning) * lengthOfGrid) - (lengthOfGrid / 2);
            int x1 = (columnWinning - 1) * lengthOfGrid;
            int x2 = (columnWinning + 4) * lengthOfGrid;

            if (player == "x")
            {
                GraphicWinner.DrawLine(penWinner, x1, y, x2, y);
                labelVictory.Text = ("x won");


            }
            else if (player == "o")
            {
                penWinner.Color = Color.Red;
                GraphicWinner.DrawLine(penWinner, x1, y, x2, y);
                labelVictory.Text = ("o won");

            }
            else if (player == "+")
            {
                penWinner.Color = Color.Black;
                GraphicWinner.DrawLine(penWinner, x1, y, x2, y);
                labelVictory.Text = ("+ won");

            }


        }
        //-----------------------------------------------------------------
        bool WinByColumn(int column)
        {

            int row = 1; // start from index 1, we don't use index 0
            int score = 0;
            while (row <= 13)
            {
                score = Movement[row, column] +
                            Movement[row + 1, column] +
                            Movement[row + 2, column] +
                            Movement[row + 3, column] +
                            Movement[row + 4, column];
                if (score == 5)
                {
                    if (playerMode == 1)
                    {
                        singleModeWinner = true;
                    }
                    VictoryByColumn("x", row, column);
                    NoDrawing();
                    xWin++;
                  //  labelXvictoryCount.ForeColor = Color.Red;
                    labelXvictoryCount.Text = xWin.ToString();
                    return true;

                }
                else if (score == -5)
                {
                    VictoryByColumn("o", row, column);

                    NoDrawing();
                    oWin++;
                //    labelOvictoryCount.ForeColor = Color.Blue;
                    labelOvictoryCount.Text = oWin.ToString();
                    return true;

                }
                else if (score == 50)
                {
                    VictoryByColumn("+", row, column);
                    NoDrawing();
                    plusWin++;
                    labelPlusVictoryCount.Text = plusWin.ToString();
                    return true;

                }
                row++;
            }

            return false;

        }
        void VictoryByColumn(string player, int rowWinning, int columnWinning)
        {

            Graphics GraphicWinner;
            GraphicWinner = this.CreateGraphics();
            Pen penWinner = new Pen(Color.Blue, 5);

            int x = (columnWinning * lengthOfGrid) - (lengthOfGrid / 2);
            int y1 = (rowWinning - 1) * lengthOfGrid;
            int y2 = (rowWinning + 4) * lengthOfGrid;

            if (player == "x")
            {
                GraphicWinner.DrawLine(penWinner, x, y1, x, y2);
                labelVictory.Text = ("x won");


            }
            else if (player == "o")
            {
                penWinner.Color = Color.Red;
                GraphicWinner.DrawLine(penWinner, x, y1, x, y2);
                labelVictory.Text = ("o won");

            }
            else if (player == "+")
            {
                penWinner.Color = Color.Black;
                GraphicWinner.DrawLine(penWinner, x, y1, x, y2);
                labelVictory.Text = ("+ won");

            }



        }
        //---------------------------------------------------------------------------------------------------
        bool WinByCross1_ColumnAndRowIncrease()
        {

            int rowOfArray = 1;
            int columnOfArray = 1;
            int score = 0;

            for (rowOfArray = 1; rowOfArray <= 13; rowOfArray++)
                for (columnOfArray = 1; columnOfArray <= 18; columnOfArray++)
                {
                    score = Movement[rowOfArray, columnOfArray] +
                             Movement[rowOfArray + 1, columnOfArray + 1] +
                             Movement[rowOfArray + 2, columnOfArray + 2] +
                             Movement[rowOfArray + 3, columnOfArray + 3] +
                             Movement[rowOfArray + 4, columnOfArray + 4];

                    if (score == 5)
                    {
                        if (playerMode == 1)
                        {
                            singleModeWinner = true;
                        }
                        DrawlineForWinnerByRowColumnIncrease("x", rowOfArray, columnOfArray);
                        labelVictory.Text = ("x won");
                        NoDrawing();
                        xWin++;
                   //     labelXvictoryCount.ForeColor = Color.Red;
                        labelXvictoryCount.Text = xWin.ToString();
                        return true;


                    }
                    else if (score == -5)
                    {
                        DrawlineForWinnerByRowColumnIncrease("o", rowOfArray, columnOfArray);
                        labelVictory.Text = ("o won");
                        NoDrawing();
                        oWin++;
                      //  labelOvictoryCount.ForeColor = Color.Blue;
                        labelOvictoryCount.Text = oWin.ToString();
                        return true;



                    }
                    else if (score == 50)
                    {
                        DrawlineForWinnerByRowColumnIncrease("+", rowOfArray, columnOfArray);
                        labelVictory.Text = ("+ won");
                        NoDrawing();
                        plusWin++;
                        labelPlusVictoryCount.Text = plusWin.ToString();
                        return true;

                    }

                }
            return false;

        }

        void DrawlineForWinnerByRowColumnIncrease(string player, int rowWinning, int columnWinning)
        {
            Graphics GraphicWinner;
            GraphicWinner = this.CreateGraphics();
            Pen penWinner = new Pen(Color.Blue, 5);

            int x1 = (columnWinning - 1) * lengthOfGrid /*- (lengthOfGrid / 2)*/;
            int y1 = (rowWinning - 1) * lengthOfGrid;
            int x2 = (columnWinning + 4) * lengthOfGrid;
            int y2 = (rowWinning + 4) * lengthOfGrid;

            if (player == "x")
            {
                GraphicWinner.DrawLine(penWinner, x1, y1, x2, y2);
                labelVictory.Text = ("x won");


            }
            else if (player == "o")
            {
                penWinner.Color = Color.Red;
                GraphicWinner.DrawLine(penWinner, x1, y1, x2, y2);
                labelVictory.Text = ("o won");

            }
            else if (player == "+")
            {
                penWinner.Color = Color.Black;
                GraphicWinner.DrawLine(penWinner, x1, y1, x2, y2);
                labelVictory.Text = ("+ won");

            }




        }
        //--------------------------------------------------------------------------------------------------------
        bool WinByCross2_ColumnAndRowDecrease()
        {

            int rowOfArray = 17;
            int columnOfArray = 22;
            int score = 0;
            // MessageBox.Show("Hello girl");
            for (rowOfArray = 17; rowOfArray >= 5; --rowOfArray)
                for (columnOfArray = 1; columnOfArray <= 18; ++columnOfArray)
                {
                    score = Movement[rowOfArray, columnOfArray] +
                            Movement[rowOfArray - 1, columnOfArray + 1] +
                            Movement[rowOfArray - 2, columnOfArray + 2] +
                            Movement[rowOfArray - 3, columnOfArray + 3] +
                            Movement[rowOfArray - 4, columnOfArray + 4];

                    if (score == 5)
                    {
                        if (playerMode == 1)
                        {
                            singleModeWinner = true;
                        }
                        DrawlineForWinnerByRowColumnDecrease("x", rowOfArray, columnOfArray);
                        labelVictory.Text = ("x won");
                        NoDrawing();
                        xWin++;
                       // labelXvictoryCount.ForeColor = Color.Red;
                        labelXvictoryCount.Text = xWin.ToString();
                        return true;


                    }
                    else if (score == -5)
                    {
                        DrawlineForWinnerByRowColumnDecrease("o", rowOfArray, columnOfArray);
                        labelVictory.Text = ("o won");
                        NoDrawing();
                        oWin++;
                      //  labelOvictoryCount.ForeColor = Color.Blue;
                        labelOvictoryCount.Text = oWin.ToString();
                        return true;


                    }
                    else if (score == 50)
                    {
                        DrawlineForWinnerByRowColumnDecrease("+", rowOfArray, columnOfArray);
                        labelVictory.Text = ("+ won");
                        NoDrawing();
                        plusWin++;
                        labelPlusVictoryCount.Text = plusWin.ToString();
                        return true;

                    }

                }

            return false;
        }
        void DrawlineForWinnerByRowColumnDecrease(string player, int rowWinnig, int columnWinning)
        {



            Graphics GraphicWinner;
            GraphicWinner = this.CreateGraphics();
            Pen penWinner = new Pen(Color.Blue, 5);

            int x1 = (columnWinning - 1) * lengthOfGrid /*- (lengthOfGrid / 2)*/;
            int y1 = (rowWinnig) * lengthOfGrid;
            int x2 = (columnWinning + 4) * lengthOfGrid;
            int y2 = (rowWinnig - 4 - 1) * lengthOfGrid;

            if (player == "x")
            {
                GraphicWinner.DrawLine(penWinner, x1, y1, x2, y2);
                labelVictory.Text = ("x won");


            }
            else if (player == "o")
            {
                penWinner.Color = Color.Red;
                GraphicWinner.DrawLine(penWinner, x1, y1, x2, y2);
                labelVictory.Text = ("o won");

            }
            else if (player == "+")
            {
                penWinner.Color = Color.Black;
                GraphicWinner.DrawLine(penWinner, x1, y1, x2, y2);
                labelVictory.Text = ("+ won");

            }

        }
        //========================================================================
        /*********************************************************************
         *******
         *          Artificial Intelligence for one player   ****************
         *          By  - AN Panharith (the Boy)
         *              
         *              
         * ***************************************************************/
        int test = 1;
        int roww = 10;
        int col = 10;

        void AIMove()
        {
            // we need to find rowAIMove and columnAIMove
            int[] best = new int[3];
            best[0] = 0;// we don't use the zero index
            best[1] = 0;
            best[2] = 0;


            if (singleModeLevel == 1)
            {



                /*

                if (test <= 1)
                {
                 //   MessageBox.Show("hello girl");

                    Graphics playerGraphic;
                    playerGraphic = this.CreateGraphics();
                    Pen penAI;
                    int a = col * 40 - 20;
                    int b = roww * 40 - 20;
                    Rectangle myRectangle = new Rectangle();
                    penAI = new Pen(Color.Red, 3);
                    playerGraphic = this.CreateGraphics();
                    this.Show();
                    myRectangle.X = a - 20 + 10 - 5;
                    myRectangle.Y = b - 20 + 5;
                    myRectangle.Width = 30;
                    myRectangle.Height = 30;
                    playerGraphic.DrawEllipse(penAI, myRectangle);
                    defend[roww, col] = 1;
                    Movement[roww, col] = -1;
                    roww --; 
                    col ++;
                   // columnAIMove++;
                    test++;
                    return;
                }
    
                */


                //============================================================
                /* 1 draw and win */
                //--------------------------------------------------
                DrawAndWin_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    int rowAIMove = best[1];
                    int columnAIMove = best[2];

                    //MessageBox.Show("we made it");
                    Osymbol(best[1], best[2]);

                    defend[rowAIMove, columnAIMove] = 1;
                    Movement[rowAIMove, columnAIMove] = -1;

                    WinByRow(rowAIMove);
                    best = null; // remove an object, or array
                    isDraw = false;
                    return;
                }

                //------------------------------------------------
                DrawAndWin_ByColumn(best);

                if ((best[1] != 0) && (best[2] != 0))
                {
                    int rowAIMove = best[1];
                    int columnAIMove = best[2];
                    Osymbol(best[1], best[2]);

                    defend[rowAIMove, columnAIMove] = 1;
                    Movement[rowAIMove, columnAIMove] = -1;

                    WinByColumn(columnAIMove);

                    best = null; // remove an object, or array
                    isDraw = false;

                    return;
                }
                //----------------------------------------------------
                DrawWin_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {

                    Osymbol(best[1], best[2]);
                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;

                    WinByCross1_ColumnAndRowIncrease();
                    best = null; // remove an object, or array
                    isDraw = false;

                    return;
                }
                //  DrawAndWin_ByRow();


                //   MessageBox.Show(" hi");




                // DetectWinner();
                //------------------------------------------------------
                DrawWin_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    int rowAIMove = best[1];
                    int columnAIMove = best[2];

                    Graphics playerGraphic;
                    playerGraphic = this.CreateGraphics();
                    Pen penAI;
                    int a = columnAIMove * 40 - 20;
                    int b = rowAIMove * 40 - 20;
                    Rectangle myRectangle = new Rectangle();
                    penAI = new Pen(Color.Red, 3);
                    playerGraphic = this.CreateGraphics();
                    this.Show();
                    myRectangle.X = a - 20 + 10 - 5;
                    myRectangle.Y = b - 20 + 5;
                    myRectangle.Width = 30;
                    myRectangle.Height = 30;
                    playerGraphic.DrawEllipse(penAI, myRectangle);
                    defend[rowAIMove, columnAIMove] = 1;
                    Movement[rowAIMove, columnAIMove] = -1;

                    WinByCross2_ColumnAndRowDecrease();
                    best = null; // remove an object, or array
                    isDraw = false;

                    return;
                }
                //========================================================================================================
                /* 2 draw if there is X 4 times in sequence */
                //-----------2.1 : For row!
                x4Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {

                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //-----------2.2 : For column!
                x4Times_ByColumn(best);

                if ((best[1] != 0) && (best[2] != 0))
                {

                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //----------2.3 : For cross_1 
                x4Times_ByCross1_ColumnAndRowIncrease(best);

                if ((best[1] != 0) && (best[2] != 0))
                {

                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //----------2.4 : For cross_2
                x4Times_ByCross2_ColumnAndRowDecrease(best);


                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }



                /* 3. draw if there is O 3 times in sequence */
                //--------- 3.1 . For row

                o3Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {

                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------------ 3.2 : For column
                o3Times_ByColumn(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------------- 3.3 : for cross_1
                o3Times_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------------- 3.4 : for cross_2
                o3Times_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }

                /* 4. draw if there is X 3 times in sequence */
                //---------4.1 : For row
                x3Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //---------4.2 : For column
                x3Times_ByColumn(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //--------- 4.3 : For cross_1
                x3Times_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //---------- 4.4 : For cross_2
                x3Times_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                /* 5. draw if there is O 2 times in sequence */
                //------ 5.1 For row
                o2Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }

                //--------5.2 For column
                o2Times_ByColumn(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //---------5.3 For cross_1
                o2Times_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------- 5.4 For cross_2
                o2Times_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                /* 6. draw if there is X 2 times in sequence */
                //--------- 6.1 For row
                x2Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //-------- 6.2 For column
                x2Times_ByColumn(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //----- 6.3 For cross_1
                x2Times_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------ 6.4 For cross 2
                x2Times_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }

                /* 7. draw if there is o 1 times in sequence */
                //--------- 7.1 For row
                o1Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------ 7.2 For column
                o1Times_ByColumn(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------- 7.3 For cross_1
                o1Times_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {

                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //----------- 7.4 For cross_2

                o1Times_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                /* 8. draw if there is x 1   times in sequence */
                //------ 8.1 For row
                x1Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------ 8.2 for column 
                x1Times_ByColumn(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------ 8.3 for Cross_1
                x1Times_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //-------- 8.4 For cross_2
                x1Times_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }



                //----- other wise, it is player O first turn . we random 
                int[] arr1 = new int[8] { 5, 6, 7, 8, 9, 10, 11, 12 };
                Random rd1 = new Random();
                int[] arr2 = new int[13] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
                Random rd2 = new Random();
                int firstRow = 0;
                int randomRow = 0;

                int firstCol = 0;
                int randomCol = 0;
                do
                {

                    firstRow = rd1.Next(0, 2);
                    randomRow = arr1[firstRow];
                    best[1] = randomRow;


                    firstCol = rd2.Next(0, 13);
                    randomCol = rd2.Next(0, 13);
                    best[2] = randomCol;


                    if ((best[1] != 0) && (best[2] != 0) && (Movement[best[1], best[2]] == 0))
                    {
                        Osymbol(best[1], best[2]);

                        defend[best[1], best[2]] = 1;
                        Movement[best[1], best[2]] = -1;
                        best = null; // remove an object, or array
                        rd1 = null;
                        rd2 = null;
                        arr1 = null;
                        arr2 = null;
                        return;
                    }
                } while (true);




            }// end if-condition, singleModeLevel=1
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            else if (singleModeLevel == 2)
            {

                //============================================================
                /* 1 draw and win */
                //--------------------------------------------------
                DrawAndWin_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    int rowAIMove = best[1];
                    int columnAIMove = best[2];

                    //MessageBox.Show("we made it");
                    Osymbol(best[1], best[2]);

                    defend[rowAIMove, columnAIMove] = 1;
                    Movement[rowAIMove, columnAIMove] = -1;

                    WinByRow(rowAIMove);
                    best = null; // remove an object, or array
                    isDraw = false;

                    return;
                }

                //------------------------------------------------
                DrawAndWin_ByColumn(best);

                if ((best[1] != 0) && (best[2] != 0))
                {
                    int rowAIMove = best[1];
                    int columnAIMove = best[2];
                    Osymbol(best[1], best[2]);

                    defend[rowAIMove, columnAIMove] = 1;
                    Movement[rowAIMove, columnAIMove] = -1;

                    WinByColumn(columnAIMove);

                    best = null; // remove an object, or array
                    isDraw = false;

                    return;
                }
                //----------------------------------------------------
                DrawWin_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {

                    Osymbol(best[1], best[2]);
                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;

                    WinByCross1_ColumnAndRowIncrease();
                    best = null; // remove an object, or array
                    isDraw = false;

                    return;
                }
                //  DrawAndWin_ByRow();


                //   MessageBox.Show(" hi");




                // DetectWinner();
                //------------------------------------------------------
                DrawWin_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    int rowAIMove = best[1];
                    int columnAIMove = best[2];

                    Graphics playerGraphic;
                    playerGraphic = this.CreateGraphics();
                    Pen penAI;
                    int a = columnAIMove * 40 - 20;
                    int b = rowAIMove * 40 - 20;
                    Rectangle myRectangle = new Rectangle();
                    penAI = new Pen(Color.Red, 3);
                    playerGraphic = this.CreateGraphics();
                    this.Show();
                    myRectangle.X = a - 20 + 10 - 5;
                    myRectangle.Y = b - 20 + 5;
                    myRectangle.Width = 30;
                    myRectangle.Height = 30;
                    playerGraphic.DrawEllipse(penAI, myRectangle);
                    defend[rowAIMove, columnAIMove] = 1;
                    Movement[rowAIMove, columnAIMove] = -1;

                    WinByCross2_ColumnAndRowDecrease();
                    best = null; // remove an object, or array
                    isDraw = false;

                    return;
                }
                //========================================================================================================
                /* 2 draw if there is X 4 times in sequence */


                //-----------2.1 : For row!
                x4Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {

                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //-----------2.2 : For column!
                x4Times_ByColumn(best);

                if ((best[1] != 0) && (best[2] != 0))
                {

                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //----------2.3 : For cross_1 
                x4Times_ByCross1_ColumnAndRowIncrease(best);

                if ((best[1] != 0) && (best[2] != 0))
                {

                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //----------2.4 : For cross_2
                x4Times_ByCross2_ColumnAndRowDecrease(best);


                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }



                /* 3. draw if there is O 3 times in sequence */
                //--------- 3.1 . For row

                o3Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {

                    Osymbol(best[1], best[2]);
                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------------ 3.2 : For column
                o3Times_ByColumn(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------------- 3.3 : for cross_1
                o3Times_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------------- 3.4 : for cross_2
                o3Times_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                // 4. x 3 times, we need to decide the mark
                int mark_xByrow = 0;
                int mark_xByCol = 0;
                int mark_xByCross1 = 0;
                int mark_xByCross2 = 0;
                int markTemp = 0;
                int tempRow = 0;
                int tempCol = 0;
                // 4.1 row
                x3Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    tempRow = best[1];
                    tempCol = best[2];
                    int c = best[2];
                    // MessageBox.Show(c.ToString());
                    //   while (c > 0)
                    // for (int c1=tempCol; c1>=1; c1=c1-1)
                    for (c = best[2]; c >= 1; c = c - 1)
                    {
                        if (Movement[best[1], c] == 1)
                        {
                            mark_xByrow++;
                        }
                        else if (Movement[best[1], c] == -1)
                        {
                            mark_xByrow--; break; //break;
                        }

                        // c--;
                    }
                    c = best[2];
                    // while (c <= 22)
                    for (c = best[2]; c <= 22; c++)
                    {
                        if (Movement[best[1], c] == 1)
                        {
                            mark_xByrow++;
                        }
                        else if (Movement[best[1], c] == -1)
                        {
                            mark_xByrow--; break;// break;
                        }

                        //c++;
                    }
                    //MessageBox.Show(mark_xByrow.ToString());

                    markTemp = mark_xByrow;
                    // MessageBox.Show(mark_x.ToString());
                }
                //-------
                x3Times_ByColumn(best);
                if ((best[1] != 0) && (best[2] != 0))
                {

                    int r = best[1];
                    while (r > 0)
                    {
                        if (Movement[r, best[2]] == 1)
                        {
                            mark_xByCol++;
                        }
                        else if (Movement[r, best[2]] == -1)
                        {
                            mark_xByCol--; break;
                        }
                        r--;
                    }
                    r = best[1];
                    while (r <= 17)
                    {
                        if (Movement[r, best[2]] == 1)
                        {
                            mark_xByCol++;
                        }
                        else if (Movement[r, best[2]] == -1)
                        {
                            mark_xByCol--; break;
                        }
                        r++;

                    }

                    if (mark_xByCol > markTemp)
                    {
                        markTemp = mark_xByCol;
                        tempRow = best[1];
                        tempCol = best[2];
                    }
                }


                x3Times_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    int r = best[1];
                    int c = best[2];
                    while (r > 0)
                    {
                        if (c < 1) break;

                        if (Movement[r, c] == 1)
                        {
                            mark_xByCross1++;
                        }
                        else if (Movement[r, c] == -1)
                        {
                            mark_xByCross1--; break;
                        }

                        r--; c--;
                    }

                    r = best[1]; c = best[2];
                    while (r <= 17)
                    {
                        if (c > 22) break;

                        if (Movement[r, c] == 1)
                        {
                            mark_xByCross1 = mark_xByCross1 + 1;
                        }
                        else if (Movement[r, c] == -1)
                        {
                            mark_xByCross1--; break;
                        }
                        r++; c++;
                    }

                    if (mark_xByCross1 > markTemp)
                    {
                        markTemp = mark_xByCross1;
                        tempRow = best[1];
                        tempCol = best[2];
                    }


                }// end cross1
                x3Times_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    int r = best[1];
                    int c = best[2];
                    while (r > 0)
                    {
                        if (c > 22) break;

                        if (Movement[r, c] == 1)
                        {
                            mark_xByCross2++;
                        }
                        else if (Movement[r, c] == -1)
                        {
                            mark_xByCross2--; break;
                        }

                        r--; c++;
                    }// end while r>0
                    r = best[1];
                    c = best[2];
                    while (r <= 17)
                    {
                        if (c < 1) break;
                        if (Movement[r, c] == 1)
                        {
                            mark_xByCross2++;
                        }
                        else if (Movement[r, c] == -1)
                        {
                            mark_xByCross2--; break;
                        }
                        r++; c--;


                    }// end while r<=17
                    if (mark_xByCross2 > markTemp)
                    {
                        markTemp = mark_xByCross2;
                        tempRow = best[1];
                        tempCol = best[2];
                    }


                }// end of case cross2

                /**** Decide to draw */
                if ((tempRow != 0) && (tempCol != 0))
                {
                    Osymbol(tempRow, tempCol);

                    defend[tempRow, tempCol] = 1;
                    Movement[tempRow, tempCol] = -1;
                    best = null; // remove an object, or array
                    return;
                }

                /* 5. draw if there is O 2 times in sequence */
                //------ 5.1 For row
                o2Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }

                //--------5.2 For column
                o2Times_ByColumn(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //---------5.3 For cross_1
                o2Times_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------- 5.4 For cross_2
                o2Times_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                /* 6. draw if there is X 2 times in sequence */
                //--------- 6.1 For row
                x2Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //-------- 6.2 For column
                x2Times_ByColumn(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //----- 6.3 For cross_1
                x2Times_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------ 6.4 For cross 2
                x2Times_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }

                /* 7. draw if there is o 1 times in sequence */
                //--------- 7.1 For row
                o1Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------ 7.2 For column
                o1Times_ByColumn(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------- 7.3 For cross_1
                o1Times_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {

                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //----------- 7.4 For cross_2

                o1Times_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                /* 8. draw if there is x 1   times in sequence */
                //------ 8.1 For row
                x1Times_ByRow(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------ 8.2 for column 
                x1Times_ByColumn(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //------ 8.3 for Cross_1
                x1Times_ByCross1_ColumnAndRowIncrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }
                //-------- 8.4 For cross_2
                x1Times_ByCross2_ColumnAndRowDecrease(best);
                if ((best[1] != 0) && (best[2] != 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    return;
                }



                //----- other wise, it is player O first turn . we random 
                int[] arr1 = new int[8] { 5, 6, 7, 8, 9, 10, 11, 12 };
                Random rd1 = new Random();
                int[] arr2 = new int[13] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
                Random rd2 = new Random();
                int firstRow = 0;
                int randomRow = 0;

                int firstCol = 0;
                int randomCol = 0;
                do
                {

                    firstRow = rd1.Next(0, 2);
                    randomRow = arr1[firstRow];
                    best[1] = randomRow;


                    firstCol = rd2.Next(0, 13);
                    randomCol = rd2.Next(0, 13);
                    best[2] = randomCol;


                    if ((best[1] != 0) && (best[2] != 0) && (Movement[best[1], best[2]] == 0))
                    {
                        Osymbol(best[1], best[2]);

                        defend[best[1], best[2]] = 1;
                        Movement[best[1], best[2]] = -1;
                        best = null; // remove an object, or array
                        rd1 = null;
                        rd2 = null;
                        arr1 = null;
                        arr2 = null;
                        return;
                    }
                } while (true);



                //-----
            }// end if-condition, singleModeLevel=2


                //+++++++++++++++++++++++++++++++++++++++++++++++
            else if (singleModeLevel == 3)
            {
                StrategyLevel3();




            }// end if-condition, singleModeLevel=3

            else if (singleModeLevel == 4)
            {
                StrategyLevel4();



            }// end if- condition, singleModeLevel==4
            else if (singleModeLevel == 5)
            {
              //  MessageBox.Show("l5");

                StrategyLevel5();
                


            }// end if-condition, singleModeLevel=5
            else if (singleModeLevel == 6)
            {
                StrategyLevel6();
            }
            else if (singleModeLevel == 7)
            {

            }

        } // end of the function.


        void DrawAndWin()
        {
            //  DrawAndWin_ByRow(BeginInvoke);
            //DrawAndWin_ByColumn();

        }
        //#####################################################################################################################
        void Osymbol(int row, int column)
        {


            Graphics playerGraphic;
            playerGraphic = this.CreateGraphics();
            Pen penAI;
            int a = column * 40 - 20;
            int b = row * 40 - 20;
            Rectangle myRectangle = new Rectangle();
            penAI = new Pen(Color.Red, 3);
            playerGraphic = this.CreateGraphics();
            this.Show();
            myRectangle.X = a - 20 + 10 - 5;
            myRectangle.Y = b - 20 + 5;
            myRectangle.Width = 30;
            myRectangle.Height = 30;
            playerGraphic.DrawEllipse(penAI, myRectangle);



        }
        void Xsymbol(int row, int column)
        {
            Graphics playerGraphic = this.CreateGraphics();
            Pen penPlayer1 = new Pen(Color.Blue, 3);

            //  x = findIndexColumn * 40;
            // y = findIndexRow * 40;
            int b = (row * 40) - 20; int a = (column * 40) - 20;


            playerGraphic.DrawLine(penPlayer1,
                                    a - 10 - 5,
                                    b - 10 - 5,
                                    a + 10 + 5,
                                    b + 10 + 5);
            playerGraphic.DrawLine(penPlayer1,
                                    a - 10 - 5,
                                    b + 10 + 5,
                                    a + 10 + 5,
                                    b - 10 - 5);




        }
        void PlusSymbol(int row, int column)
        {
            Graphics playerGraphic = this.CreateGraphics();
            Pen penPlayer = new Pen(Color.Blue, 3);

            //  x = findIndexColumn * 40;
            // y = findIndexRow * 40;
            int b = (row * 40); int a = (column * 40);



            penPlayer = new Pen(Color.Black, 3);
            playerGraphic = this.CreateGraphics();
            playerGraphic.DrawLine(penPlayer, a - 20, b + 5 - 40, a - 20, b + 35 - 40);
            playerGraphic.DrawLine(penPlayer, a + 5 - 20 - 20, b + 20 - 40, a + 35 - 20 - 20, b + 20 - 40);


        }
        //##########################################################################################################################
        /*****
         *
         *  AI 1st, draw and win
         *  *****************/

        void DrawAndWin_ByRow(int[] Move)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2] +
                                Movement[rowAIMove, columnAIMove + 3] +
                                Movement[rowAIMove, columnAIMove + 4];
                    if (score == -4)
                    {
                        int bestMove_Column = columnAIMove;

                        for (int i = columnAIMove; i <= columnAIMove + 5; ++i)
                        {
                            if (Movement[rowAIMove, i] == 0)
                            {

                                Move[1] = rowAIMove;
                                Move[2] = i;
                                return;
                            }
                        }
                    }
                } // end for loop ColumnOfAI

            } // end for rowOfAI

        }
        //------------------------------------------------------------------------------------------------------------
        void DrawAndWin_ByColumn(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove] +
                            Movement[rowAIMove + 3, columnAIMove] +
                            Movement[rowAIMove + 4, columnAIMove];
                    if (score == -4) // there is one move that we can win the game
                    {
                        for (int j = rowAIMove; j <= rowAIMove + 5; ++j)
                        {
                            if (Movement[j, columnAIMove] == 0)
                            {

                                Move[1] = j;
                                Move[2] = columnAIMove;
                                return;
                            }
                        }
                    }
                }
            }
        }


        //---------------------------------------------------------------------------------------------------------------     

        void DrawWin_ByCross1_ColumnAndRowIncrease(int[] good)
        {

            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2] +
                             Movement[rowAIMove + 3, columnAIMove + 3] +
                             Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == -4)
                    {

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5; i++)
                        {
                            if (Movement[i, j] == 0)
                            {

                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            j++;
                        }
                    }
                }
        }
        //--------------------------------------------------------------------------------------------------------

        void DrawWin_ByCross2_ColumnAndRowDecrease(int[] good)
        {
            /*
                        int rowAIMove = 17;
                        int columnAIMove = 22;
                        int score = 0;
                        // MessageBox.Show("Hello girl");
                        for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                            for (columnAIMove = 1; columnAIMove <= 18; ++columnAIMove)
                            {
                                score = Movement[rowAIMove, columnAIMove] +
                                        Movement[rowAIMove - 1, columnAIMove + 1] +
                                        Movement[rowAIMove - 2, columnAIMove + 2] +
                                        Movement[rowAIMove - 3, columnAIMove + 3] +
                                        Movement[rowAIMove - 4, columnAIMove + 4];


                                if (score == -4) // there is one move that we can win the game
                                {
                                    int bestMove_row = rowAIMove;

                                    int i = rowAIMove;
                                    int j = columnAIMove;
                                    for (i = rowAIMove; i <= rowAIMove + 5; i++)
                                    {
                                        if (Movement[i, j] == 0)
                                        {
                                            // we made it. Yeah.
                                            label5.Text = i.ToString();
                                            label6.Text = j.ToString();
                                            good[1] = i;
                                            good[2] = j;
                                            return;

                                        }
                                        j--;
                                    }

                                }
                            }
                        */
            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2] +
                            Movement[rowAIMove - 3, columnAIMove + 3] +
                    Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == -4) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;

                        int i = rowAIMove;
                        int j = columnAIMove;

                        for (j = columnAIMove; j <= columnAIMove + 5; ++j)
                        {
                            if (Movement[i, j] == 0)
                            {
                                // we made it. Yeah.

                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            i--;
                        }

                    }
                }











        }
        //##########################################################################################################################
        /*****
     *
     *  AI 2nd, draw when there is x 4 times in sequence
     *  *****************/

        void x4Times_ByRow(int[] Move)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2] +
                                Movement[rowAIMove, columnAIMove + 3] +
                                Movement[rowAIMove, columnAIMove + 4];
                    if (score == 4)
                    {
                        int bestMove_Column = columnAIMove;

                        for (int i = columnAIMove; i <= columnAIMove + 5; ++i)
                        {
                            if (Movement[rowAIMove, i] == 0)
                            {

                                Move[1] = rowAIMove;
                                Move[2] = i;
                                return;
                            }
                        }
                    }
                } // end for loop ColumnOfAI

            } // end for rowOfAI

        }
        //------------------------------------------------------------------------------------
        void x4Times_ByColumn(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove] +
                            Movement[rowAIMove + 3, columnAIMove] +
                            Movement[rowAIMove + 4, columnAIMove];
                    if (score == 4) // there is one move that we can win the game
                    {
                        for (int j = rowAIMove; j <= rowAIMove + 5; ++j)
                        {
                            if (Movement[j, columnAIMove] == 0)
                            {

                                Move[1] = j;
                                Move[2] = columnAIMove;
                                return;
                            }
                        }
                    }
                }
            }
        }
        //--------------------------------------------------------------------------
        void x4Times_ByCross1_ColumnAndRowIncrease(int[] good)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2] +
                             Movement[rowAIMove + 3, columnAIMove + 3] +
                             Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == 4)
                    {

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5; i++)
                        {
                            if (Movement[i, j] == 0)
                            {

                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            j++;
                        }
                    }
                }
        }
        //-----------------------------------------------------------
        void x4Times_ByCross2_ColumnAndRowDecrease(int[] good)
        {

            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2] +
                            Movement[rowAIMove - 3, columnAIMove + 3] +
                            Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == 4) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;

                        int i = rowAIMove;
                        int j = columnAIMove;

                        for (j = columnAIMove; j <= columnAIMove + 5; j++)
                        {
                            if (Movement[i, j] == 0)
                            {
                                // we made it. Yeah.

                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            i--;
                        }


                    }
                }
        }


        //##########################################################################################################################

        void x3Times_ByRow(int[] Move)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2] +
                                Movement[rowAIMove, columnAIMove + 3];
                    //Movement[rowAIMove, columnAIMove + 4];
                    if (score == 3)
                    {
                        int bestMove_Column = columnAIMove;

                        for (int i = columnAIMove; i <= columnAIMove + 5 - 1; ++i)
                        {
                            if (Movement[rowAIMove, i] == 0)
                            {

                                Move[1] = rowAIMove;
                                Move[2] = i;
                                return;
                            }
                        }
                    }
                } // end for loop ColumnOfAI

            } // end for rowOfAI

        }
        //------------------------------------------------------------------------------------
        void x3Times_ByColumn(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13 + 1; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove] +
                            Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == 3) // there is one move that we can win the game
                    {
                        for (int j = rowAIMove; j <= rowAIMove + 5 - 1; ++j)
                        {
                            if (Movement[j, columnAIMove] == 0)
                            {
                                Move[1] = j;
                                Move[2] = columnAIMove;
                                return;
                            }
                        }
                    }
                }
            }
        }
        //------------------------------------------------------------------------------------

        void x3Times_ByCross1_ColumnAndRowIncrease(int[] good)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18 + 1; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2] +
                             Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == 3)
                    {

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1; i++)
                        {
                            if (Movement[i, j] == 0)
                            {


                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            j++;
                        }
                    }
                }
        }

        //------------------------------------------------------------------------------------
        void x3Times_ByCross2_ColumnAndRowDecrease(int[] good)
        {

            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2] +
                            Movement[rowAIMove - 3, columnAIMove + 3];
                    //  Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == 3) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;

                        int i = rowAIMove;
                        int j = columnAIMove;

                        for (j = columnAIMove; j <= columnAIMove + 5 - 1; j++)
                        {
                            if (Movement[i, j] == 0)
                            {
                                // we made it. Yeah.

                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            i--;
                        }


                    }
                }
        }
        //##########################################################################################################################
        void o3Times_ByRow(int[] Move)
        {

            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2] +
                                Movement[rowAIMove, columnAIMove + 3];
                    //  Movement[rowAIMove, columnAIMove + 4];
                    if (score == -3)
                    {
                        int bestMove_Column = columnAIMove;

                        for (int i = columnAIMove; i <= columnAIMove + 5 - 1; ++i)
                        {
                            if (Movement[rowAIMove, i] == 0)
                            {
                                Move[1] = rowAIMove;
                                Move[2] = i;





                                break;
                            }
                        }

                        if (Move[2] < 22&& Move[1]-4 >0)
                        {
                            if (Movement[Move[1], Move[2] + 1] == 1)// there is another x, we are not going to make another o
                            {
                                if (Movement[Move[1], Move[2] - 4] == 0)
                                {
                                    Move[2] -= 4;
                                    return;

                                }
                                //  MessageBox.Show("Hello AN");
                                Move[1] = 0;
                                Move[2] = 0;
                                // return ;
                            }
                        }
                        if (Move[2] > 1 && Move[2]+4 <22)
                        {

                            if (Movement[Move[1], Move[2] - 1] == 1)// there is another x, we are not going to make another o
                            {
                                if (Movement[Move[1], Move[2] + 4] == 0)
                                {
                                    Move[2] += 4;
                                    return;
                                }

                                Move[1] = 0;
                                Move[2] = 0;
                                // return ;
                            }

                        }
                    }
                } // end for loop ColumnOfAI

            } // end for rowOfAI
            if (Move[2] == 1)
            {
                if (Movement[Move[1], Move[2] + 4] == 1) // there is x 
                {
                    Move[1] = 0;
                    Move[2] = 0;
                    return;
                }
            }
            if (Move[2] == 22)
            {
                if (Movement[Move[1], Move[2] - 4] == 1) // there is x 
                {
                    Move[1] = 0;
                    Move[2] = 0;
                    return;
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------
        void o3Times_ByColumn(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13 + 1; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove] +
                            Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == -3) // there is one move that we can win the game
                    {
                        for (int j = rowAIMove; j <= rowAIMove + 5 - 1; ++j)
                        {
                            if (Movement[j, columnAIMove] == 0)
                            {

                                Move[1] = j;
                                Move[2] = columnAIMove;
                                if (Move[1] < 17 && Move[1]-4>0)
                                {
                                    if (Movement[Move[1] + 1, Move[2]] == 1)// there is another x, we are not going to make another o
                                    {
                                        if (Movement[Move[1] - 4, Move[2]] == 0)
                                        {
                                            Move[1] -= 4;
                                            return;
                                        }


                                        Move[1] = 0;
                                        Move[2] = 0;
                                    }
                                }
                                if (Move[1] > 1&& Move[1]+4<=17)
                                {
                                    if (Movement[Move[1] - 1, Move[2]] == 1)// there is another x, we are not going to make another o
                                    {
                                        if (Movement[Move[1] + 4, Move[2]] == 0)
                                        {
                                            Move[1] += 4;
                                            return;
                                        }
                                        Move[1] = 0;
                                        Move[2] = 0;
                                    }



                                }



                                break;
                            }
                        }
                    }
                }
            }

            if (Move[1] == 1)
            {
                if (Movement[Move[1] + 4, Move[2]] == 1) // there is x 
                {
                    Move[1] = 0;
                    Move[2] = 0;
                    return;
                }

            }

            if (Move[1] == 17)
            {
                if (Movement[Move[1] - 4, Move[2]] == 1) // there is x 
                {
                    Move[1] = 0;
                    Move[2] = 0;
                    return;
                }

            }

        }

        //---------------------------------------------------------------------------------------------------------------     

        void o3Times_ByCross1_ColumnAndRowIncrease(int[] good)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18 + 1; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2] +
                             Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == -3)
                    {

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1; i++)
                        {
                            if (Movement[i, j] == 0)
                            {

                                good[1] = i;
                                good[2] = j;


                                if (good[1] < 17 && good[2] < 22)
                                {
                                    if (Movement[good[1] + 1, good[2] + 1] == 1)// there is another x, we are not going to make another o
                                    {
                                        good[1] = 0;
                                        good[2] = 0;
                                    }
                                }

                                if (good[1] > 1 && good[2] > 1)
                                {
                                    if (Movement[good[1] - 1, good[2] - 1] == 1)// there is another x, we are not going to make another o
                                    {
                                        good[1] = 0;
                                        good[2] = 0;
                                    }
                                }





                                break;

                            }
                            j++;
                        }
                    }
                }

            if (good[1] == 1)
            {
                if (Movement[good[1] + 4, good[2] + 4] == 1)// x
                {
                    good[1] = 0; good[2] = 0;
                }

            }




        }
        //--------------------------------------------------------------------------------------------------------

        void o3Times_ByCross2_ColumnAndRowDecrease(int[] good)
        {

            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2] +
                            Movement[rowAIMove - 3, columnAIMove + 3];
                    //Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == -3) // there is one move that we can win the game
                    {

                        int bestMove_row = rowAIMove;

                        int i = rowAIMove;
                        int j = columnAIMove;


                        for (i = rowAIMove; i < rowAIMove + 5; i++)
                        {
                            if (i > 17) continue;
                            if (j < 1) continue;
                            if (Movement[i, j] == 1) break;
                            else if (Movement[i, j] == 0)
                            {
                                good[1] = i;
                                good[2] = j;
                                if (good[1] > 1 && good[2] < 22)
                                {
                                    if (Movement[good[1] - 1, good[2] + 1] == 1)// there is another x, we are not going to make another o
                                    {
                                        good[1] = 0;
                                        good[2] = 0;
                                    }
                                }
                                if (good[1] < 17 && good[2] > 1)
                                {
                                    if (Movement[good[1] + 1, good[2] - 1] == 1)// there is another x, we are not going to make another o
                                    {
                                        good[1] = 0;
                                        good[2] = 0;
                                    }
                                }





                                break;
                            }
                            j--;
                        }

                        i = rowAIMove; j = columnAIMove;
                        for (i = rowAIMove; i > rowAIMove - 5; i--)
                        {
                            if (i < 1) continue;
                            if (j > 22) continue;

                            if (Movement[i, j] == 1) break;
                            else if (Movement[i, j] == 0)
                            {
                                good[1] = i;
                                good[2] = j;
                                if (good[1] > 1 && good[2] < 22)
                                {
                                    if (Movement[good[1] - 1, good[2] + 1] == 1)// there is another x, we are not going to make another o
                                    {
                                        good[1] = 0;
                                        good[2] = 0;
                                    }
                                }
                                if (good[1] < 17 && good[2] > 1)
                                {
                                    if (Movement[good[1] + 1, good[2] - 1] == 1)// there is another x, we are not going to make another o
                                    {
                                        good[1] = 0;
                                        good[2] = 0;
                                    }
                                }
                                break;
                            }

                            j++;
                        }


                        if (good[1] == 1 || good[2] == 1)
                        {
                            if ((good[1] + 4 <= 17) && (good[1] + 4 <= 22))
                            {
                                if (Movement[good[1] + 4, good[2] + 4] == 0)
                                {
                                    good[1] += 4;
                                    good[2] += 4;
                                    return;
                                }
                            }


                            good[1] = 0;
                            good[2] = 0;

                        }



                        /*

                        for (i = rowAIMove; i <= rowAIMove + 5-1; i++)
                        {
                            if (Movement[i, j] == 0)
                            {
                                // we made it. Yeah.
                                
                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            j--;
                        }
                        */
                    }
                }
        }
        //##############################################################################################################################
        void o2Times_ByRow(int[] Move)
        {

            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2];
                    // Movement[rowAIMove, columnAIMove + 3];
                    //  Movement[rowAIMove, columnAIMove + 4];
                    if (score == -2)
                    {
                        int bestMove_Column = columnAIMove;

                        for (int i = columnAIMove; i <= columnAIMove + 5 - 1 - 1; ++i)
                        {
                            if (Movement[rowAIMove, i] == 0)
                            {

                                Move[1] = rowAIMove;
                                Move[2] = i;
                                if (Move[2] < 22)
                                {
                                    if (Movement[Move[1], Move[2] + 1] == 1)// there is another x, we are not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        // return ;
                                    }
                                }
                                if (Move[2] > 1)
                                {

                                    if (Movement[Move[1], Move[2] - 1] == 1)// there is another x, we are not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        // return ;
                                    }

                                }
                                break;
                            }
                        }
                    }
                } // end for loop ColumnOfAI

            } // end for rowOfAI 



        }
        //------------------------------------------------------------------------------------------------------
        void o2Times_ByColumn(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13 + 1 + 1; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove];
                    //  Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == -2) // there is one move that we can win the game
                    {
                        for (int j = rowAIMove; j <= rowAIMove + 5 - 1 - 1; ++j)
                        {
                            if (Movement[j, columnAIMove] == 0)
                            {

                                Move[1] = j;
                                Move[2] = columnAIMove;
                                if (Move[1] < 17)
                                {
                                    if (Movement[Move[1] + 1, Move[2]] == 1)// there is another x, we are not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                    }
                                }
                                if (Move[1] > 1)
                                {
                                    if (Movement[Move[1] - 1, Move[2]] == 1)// there is another x, we are not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                    }

                                }




                                break;
                            }
                        }
                    }
                }
            }
        }

        //---------------------------------------------------------------------
        void o2Times_ByCross1_ColumnAndRowIncrease(int[] good)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2];
                    // Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == -2)
                    {

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1; i++)
                        {
                            if (Movement[i, j] == 0)
                            {

                                good[1] = i;
                                good[2] = j;
                                if ((good[1] < 17 && good[2] < 22) && (Movement[good[1] + 1, good[2] + 1] == 1))// there is another x, we are not going to make another o
                                {


                                    //  MessageBox.Show("Ryan AN");

                                    good[1] = 0;
                                    good[2] = 0;

                                }
                                if ((good[1] > 1 && good[2] > 1) && (Movement[good[1] - 1, good[2] - 1] == 1))// there is another x, we are not going to make another o
                                {

                                    //  MessageBox.Show("Pheakdey AN");

                                    good[1] = 0;
                                    good[2] = 0;

                                }
                                // break;
                                return;
                            }
                            j++;
                        }
                    }
                }
        }
        //--------------------------------------------------------------------------------------------------------------
        void o2Times_ByCross2_ColumnAndRowDecrease(int[] good)
        {

            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2];
                    // Movement[rowAIMove - 3, columnAIMove + 3];
                    //Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == -2) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1; i++)
                        {
                            if (Movement[i, j] == 0)
                            {
                                // we made it. Yeah.

                                good[1] = i;
                                good[2] = j;
                                if (good[1] > 1 && good[2] < 22 && (Movement[good[1] - 1, good[2] + 1] == 1))// there is another x, we are not going to make another o
                                {
                                    good[1] = 0;
                                    good[2] = 0;

                                }
                                else if ((good[1] < 17 && good[2] > 1) && (Movement[good[1] + 1, good[2] - 1] == 1))// there is another x, we are not going to make another o
                                {

                                    good[1] = 0;
                                    good[2] = 0;

                                }
                                break;
                                //return;
                            }
                            j--;
                        }

                    }
                }
        }

        //################################################################################################################################

        void x2Times_ByRow(int[] Move)
        {

            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2];
                    //   Movement[rowAIMove, columnAIMove + 3];
                    //Movement[rowAIMove, columnAIMove + 4];
                    if (score == 2)
                    {
                        int bestMove_Column = columnAIMove;

                        for (int i = columnAIMove; i <= columnAIMove + 5 - 1 - 1; ++i)
                        {
                            if (Movement[rowAIMove, i] == 0)
                            {

                                Move[1] = rowAIMove;
                                Move[2] = i;
                                return;
                            }
                        }
                    }
                } // end for loop ColumnOfAI

            } // end for rowOfAI

        }
        //------------------------------------------------------------------------------------
        void x2Times_ByColumn(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13 + 1 + 1; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove];
                    //  Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == 2) // there is one move that we can win the game
                    {
                        for (int j = rowAIMove; j <= rowAIMove + 5 - 1 - 1; ++j)
                        {
                            if (Movement[j, columnAIMove] == 0)
                            {

                                Move[1] = j;
                                Move[2] = columnAIMove;
                                return;
                            }
                        }
                    }
                }
            }
        }
        //------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

        void x2Times_ByCross1_ColumnAndRowIncrease(int[] good)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2];
                    // Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == 2)
                    {

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1; i++)
                        {
                            if (Movement[i, j] == 0)
                            {

                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            j++;
                        }
                    }
                }
        }
        //---------------------------------------------------------------------------------------------------------------------
        void x2Times_ByCross2_ColumnAndRowDecrease(int[] good)
        {

            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2];
                    //  Movement[rowAIMove - 3, columnAIMove + 3];
                    //  Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == 2) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;

                        int i = rowAIMove;
                        int j = columnAIMove;

                        for (j = columnAIMove; j <= columnAIMove + 5 - 1 - 1; j++)
                        {
                            if (Movement[i, j] == 0)
                            {
                                // we made it. Yeah.

                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            i--;
                        }


                    }
                }
        }

        //##############################################################################################################################
        void o1Times_ByRow(int[] Move)
        {

            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1];
                    // Movement[rowAIMove, columnAIMove + 2];
                    // Movement[rowAIMove, columnAIMove + 3];
                    //  Movement[rowAIMove, columnAIMove + 4];
                    if (score == -1)
                    {
                        int bestMove_Column = columnAIMove;

                        for (int i = columnAIMove; i <= columnAIMove + 5 - 1 - 1 - 1; ++i)
                        {
                            if (Movement[rowAIMove, i] == 0)
                            {

                                Move[1] = rowAIMove;
                                Move[2] = i;
                                return;
                            }
                        }
                    }
                } // end for loop ColumnOfAI

            } // end for rowOfAI 

        }

        //------------------------------------------------------------------------------------------------------
        void o1Times_ByColumn(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13 + 1 + 1 + 1; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove];
                    //Movement[rowAIMove + 2, columnAIMove];
                    //  Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == -1) // there is one move that we can win the game
                    {
                        for (int j = rowAIMove; j <= rowAIMove + 5 - 1 - 1 - 1; ++j)
                        {
                            if (Movement[j, columnAIMove] == 0)
                            {

                                Move[1] = j;
                                Move[2] = columnAIMove;
                                return;
                            }
                        }
                    }
                }
            }
        }
        //---------------------------------------------------------------------
        void o1Times_ByCross1_ColumnAndRowIncrease(int[] good)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1 + 1; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1];
                    // Movement[rowAIMove + 2, columnAIMove + 2];
                    // Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == -1)
                    {

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1 - 1; i++)
                        {
                            if (Movement[i, j] == 0)
                            {

                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            j++;
                        }
                    }
                }
        }
        //----------------------------------------------------------------------------------------------------------------
        void o1Times_ByCross2_ColumnAndRowDecrease(int[] good)
        {

            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1];
                    //  Movement[rowAIMove - 2, columnAIMove + 2];
                    // Movement[rowAIMove - 3, columnAIMove + 3];
                    //Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == -1) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1 - 1; i++)
                        {
                            if (Movement[i, j] == 0)
                            {
                                // we made it. Yeah.

                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            j--;
                        }

                    }
                }
        }

        //################################################################################################################################

        void x1Times_ByRow(int[] Move)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1];
                    //   Movement[rowAIMove, columnAIMove + 2];
                    //   Movement[rowAIMove, columnAIMove + 3];
                    //Movement[rowAIMove, columnAIMove + 4];
                    if (score == 1)
                    {
                        int bestMove_Column = columnAIMove;

                        for (int i = columnAIMove; i <= columnAIMove + 5 - 1 - 1 - 1; ++i)
                        {
                            if (Movement[rowAIMove, i] == 0)
                            {
                                Move[1] = rowAIMove;
                                Move[2] = i;
                                return;
                            }
                        }
                    }
                } // end for loop ColumnOfAI

            } // end for rowOfAI

        }
        //------------------------------------------------------------------------------------
        void x1Times_ByColumn(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13 + 1 + 1 + 1; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove];
                    //  Movement[rowAIMove + 2, columnAIMove];
                    //  Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == 1) // there is one move that we can win the game
                    {
                        for (int j = rowAIMove; j <= rowAIMove + 5 - 1 - 1 - 1; ++j)
                        {
                            if (Movement[j, columnAIMove] == 0)
                            {

                                Move[1] = j;
                                Move[2] = columnAIMove;
                                return;
                            }
                        }
                    }
                }
            }
        }

        //------------------------------------------------------------------------------------

        void x1Times_ByCross1_ColumnAndRowIncrease(int[] good)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1 + 1; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1];
                    //  Movement[rowAIMove + 2, columnAIMove + 2];
                    // Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == 1)
                    {

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1 - 1; i++)
                        {
                            if (Movement[i, j] == 0)
                            {


                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            j++;
                        }
                    }
                }
        }
        //---------------------------------------------------------------------------------------------------------------------
        void x1Times_ByCross2_ColumnAndRowDecrease(int[] good)
        {

            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1];
                    // Movement[rowAIMove - 2, columnAIMove + 2];
                    //  Movement[rowAIMove - 3, columnAIMove + 3];
                    //  Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == 1) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;

                        int i = rowAIMove;
                        int j = columnAIMove;

                        for (j = columnAIMove; j <= columnAIMove + 5 - 1 - 1 - 1; j++)
                        {
                            if (Movement[i, j] == 0)
                            {
                                // we made it. Yeah.


                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            i--;
                        }


                    }
                }
        }

        /*######################################################################################################################################################*/
        /***** Useful Functin for AI Level 2****************/

        void x3Times_ByRow_Level2(int[] Move, int[] tempIndexRow, int[] tempIndexCol)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2] +
                                Movement[rowAIMove, columnAIMove + 3];
                    //Movement[rowAIMove, columnAIMove + 4];
                    if (score == 3)
                    {
                        int bestMove_Column = columnAIMove;
                        tempIndexRow[1] = rowAIMove;
                        tempIndexCol[1] = columnAIMove;
                        for (int i = columnAIMove; i <= columnAIMove + 5 - 1; ++i)
                        {
                            if (i > 22) continue;
                            if (Movement[rowAIMove, i] == 0)
                            {

                                Move[1] = rowAIMove;
                                Move[2] = i;
                                return;
                            }
                        }
                    }
                } // end for loop ColumnOfAI

            } // end for rowOfAI

        }

        //------------------------------------------------------------------------------------
        void x3Times_ByColumn_Level2(int[] Move, int[] tempIndexRow, int[] tempIndexCol)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13 + 1; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove] +
                            Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == 3) // there is one move that we can win the game
                    {
                        tempIndexRow[2] = rowAIMove;
                        tempIndexCol[2] = columnAIMove;
                        for (int j = rowAIMove; j <= rowAIMove + 5 - 1; ++j)
                        {
                            if (j > 17) continue;
                            if (Movement[j, columnAIMove] == 0)
                            {

                                Move[1] = j;
                                Move[2] = columnAIMove;
                                return;
                            }
                        }
                    }
                }
            }
        }

        //------------------------------------------------------------------------------------------------
        void x3Times_ByCross1_ColumnAndRowIncrease_Level2(int[] good, int[] tempIndexRow, int[] tempIndexCol)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18 + 1; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2] +
                             Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == 3)
                    {
                        tempIndexRow[3] = rowAIMove;
                        tempIndexCol[3] = columnAIMove;
                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1; i++)
                        {
                            if (Movement[i, j] == 0)
                            {
                                good[1] = i;
                                good[2] = j;
                                return;
                            }
                            j++;
                        }
                    }
                }
        }

        //------------------------------------------------------------------------------------
        void x3Times_ByCross2_ColumnAndRowDecrease_Level2(int[] good, int[] tempIndexRow, int[] tempIndexCol)
        {

            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2] +
                            Movement[rowAIMove - 3, columnAIMove + 3];
                    //  Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == 3) // there is one move that we can win the game
                    {
                        // MessageBox.Show("bingo");


                        tempIndexRow[4] = rowAIMove;
                        tempIndexCol[4] = columnAIMove;
                        int bestMove_row = rowAIMove;
                        int i = rowAIMove;
                        int j = columnAIMove;

                        for (j = columnAIMove; j <= columnAIMove + 5 - 1; j++)
                        {
                            if (Movement[i, j] == 0)
                            {
                                // we made it. Yeah.

                                good[1] = i;
                                good[2] = j;
                                return;

                            }
                            i--;
                        }


                    }
                }
        }
        //###########################################################################################################
        /********* Useful function used in AI level 3
         * ***************************************************/
        double x3Times_ByRowLevel3(int[] Move)
        {
            int tempRow = 0;
            int tempCol = 0;
            double tempMark = 0;
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 2; columnAIMove <= 18 ; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2] +
                                Movement[rowAIMove, columnAIMove + 3];
                    //Movement[rowAIMove, columnAIMove + 4];
                    if (score == 3)
                    {
                        Move[1] = rowAIMove; 
                        Move[2] = columnAIMove;
                            for (int i = columnAIMove; i < columnAIMove + 5 - 1; ++i)
                            {
                                if (Movement[rowAIMove, i] == 0)
                                {
                                   Move[1] = rowAIMove;
                                   Move[2] = i;
                                    break;
                                }
                            }
                        double xMark = 0;
                        for (int z = Move[2]; z <= Move[2] + 4; z++)
                        {
                            //  if (z > Move[2]) x++;
                            if (z > 22)
                            {
                                continue;
                            }
                            if (Movement[Move[1], z] == 1)
                            {
                                xMark ++;
                            }
                            else if (Movement[Move[1], z] == -1)
                            {
                            //    MessageBox.Show("Hello");
                                xMark -= 1; break;
                            }
                        }

                        for (int z = Move[2]; z > Move[2] - 5; --z)
                        {
                            if (z < 1)
                            {
                                continue;
                            }
                            if (Movement[Move[1], z] == 1)
                            {
                                xMark++;
                            }
                            else if (Movement[Move[1], z] == -1)
                            {
                                xMark -= 1; break;
                            }
                        }
                        if (tempMark < xMark)
                        {
                            tempRow = Move[1];
                            tempCol = Move[2];
                            tempMark = xMark;
                        }
                    }//end of if-statement score==3
                } // end for loop ColumnOfAI
            } // end for rowOfAI

            Move[1] = tempRow;
            Move[2] = tempCol;
                    return tempMark;
        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        double x3Times_ByColumn_Level3(int[] Move)
        {
            int tempRow = 0; int tempCol = 0;
            double tempMark = 0;
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 2; rowAIMove <= 13; ++rowAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove] +
                            Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == 3) // there is one move that we can win the game
                    {
                        double xMark = 0;
                         if (rowAIMove == 14)
                        {
                            if (Movement[13, columnAIMove] == 0)
                            {
                                Move[1] = 13;
                                Move[2] = columnAIMove;
                                tempRow = Move[1];
                                tempCol = Move[2];
                                tempMark = 2;
                            }
                        }
                        else if (rowAIMove == 13)
                        {
                            if (Movement[13, columnAIMove] == 0)
                            {
                                Move[1] = 13;
                                Move[2] = columnAIMove;
                                tempRow = Move[1];
                                tempCol = Move[2];
                                tempMark = 2;
                            }
                            else if (Movement[12, columnAIMove] == 0)
                            {
                                Move[1] = 12;
                                Move[2] = columnAIMove;
                                tempRow = Move[1];
                                tempCol = Move[2];
                                tempMark = 2;
                            }
                        }
                        else if (rowAIMove == 2)
                        {
                            if (Movement[5, columnAIMove] == 0)
                            {
                                Move[1] = 5;
                                Move[2] = columnAIMove;
                                tempRow = Move[1];
                                tempCol = Move[2];
                                tempMark = 2;
                            }
                        }
                        else
                        {
                            for (int j = rowAIMove; j <= rowAIMove + 5 - 1; ++j)
                            {
                                if (j > 17) continue;
                                if (Movement[j, columnAIMove] == 0)
                                {
                                    Move[1] = j;
                                    Move[2] = columnAIMove;
                                    break;
                                }
                            }
                            //--------
                        }

                        for (int z = Move[1]; z > Move[1] - 4 - 1; --z) // down row
                        {
                            if (z < 1) continue;
                            if (Movement[z, Move[2]] == 1)
                            {
                                xMark++;
                            }
                            else if (Movement[z, Move[2]] == -1)
                            {
                                xMark--;
                                break;
                            }
                        }
                        for (int z = Move[1]; z <= Move[1] + 4 + 1; z++) // up row
                        {
                            if (z > 17) continue;
                            if (Movement[z, Move[2]] == 1)
                            {
                                xMark++;
                            }
                            else if (Movement[z, Move[2]] == -1)
                            {
                                xMark--; break;
                            }
                        }

                        if (tempMark < xMark)
                        {
                            tempRow = Move[1];
                            tempCol = Move[2];
                            tempMark = xMark;
                        }

                    }//end of if statements: score==3
                }
            }
            Move[1] = tempRow;
            Move[2] = tempCol;
            return tempMark;
        }

        double x3Times_ByCross1_ColumnAndRowIncrease_Level3(int[] Move)
        {
            int tempRow = 0;
            int tempCol = 0;
            double tempMark = 0;
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1 + 1; columnAIMove <= 18; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2] +
                             Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == 3)
                    {
                            if (rowAIMove == 12 && columnAIMove == 17)
                        {
                            if (Movement[11, 16] == 0)
                            {
                                tempRow = 11;
                                tempCol = 16;

                                Move[1] = 11;
                                Move[2] = 16;
                                tempMark = 2;
                            }
                          
                        }
                        else if (rowAIMove == 1 && columnAIMove == 18)// it is next to the wall
                        {
                            tempRow = 0;
                            tempCol = 0;

                            Move[1] = 0;
                            Move[2] = 0;
                            tempMark = 0;
                        }
                        else
                        {

                            int i = rowAIMove;
                            int j = columnAIMove;
                            for (i = rowAIMove; i <= rowAIMove + 5 - 1; i++)
                            {
                                if (i > 17) continue;
                                if (j > 22) continue;
                                if (Movement[i, j] == 0)
                                {
                                    Move[1] = i;
                                    Move[2] = j;
                                    break;
                                }
                                j++;
                            }
                          
                            double xCross1 = 0;
                            int c = Move[2];
                            int r = Move[1];
                            for (r = Move[1]; r < Move[1] + 5; ++r)
                            {
                                if (r > 17) continue;
                                if (c > 22) continue;

                                if (Movement[r, c] == 1)
                                {
                                    xCross1++;
                                }
                                else if (Movement[r, c] == -1)
                                {
                                    xCross1--; break;
                                }
                                c++;
                            }

                            c = Move[2];
                            for (r = Move[1]; r > Move[1] - 5; --r)
                            {
                                if (r < 1) continue;
                                if (c < 1) continue;

                                if (Movement[r, c] == 1)
                                {
                                    xCross1++;
                                }
                                else if (Movement[r, c] == -1)
                                {
                                    xCross1--; break;
                                }

                                c--;
                            }

                            if (tempMark < xCross1)
                            {
                                tempRow = Move[1];
                                tempCol = Move[2];
                                tempMark = xCross1;
                            }

                        }// end of else
                    } // end of if condition: score ==3

                } // end of two main for-loops
            Move[1] = tempRow;
            Move[2] = tempCol;
            return tempMark;
        }
        double x3Times_ByCross2_ColumnAndRowDecrease_Level3(int[] Move)
        {
            int tempRow = 0;
            int tempCol = 0;
            double tempMark = 0;
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (rowAIMove = 17; rowAIMove >3; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2] +
                            Movement[rowAIMove - 3, columnAIMove + 3];
                    //  Movement[rowAIMove - 4, columnAIMove + 4];
                    if (score == 3) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;
                        int i = rowAIMove;
                        int j = columnAIMove;
                        if (rowAIMove == 17 && columnAIMove == 1)
                        {
                            tempRow = 0;
                            tempCol = 0;
                            tempMark = 0;
                        }
                        else
                        {
                            for (j = columnAIMove; j <= columnAIMove + 5 - 1; j++)
                            {
                                if (Movement[i, j] == 0)
                                {
                                    // we made it. Yeah.

                                    Move[1] = i;
                                    Move[2] = j;
                                    break;
                                }
                                i--;
                            }
                            double xCross2 = 0;
                            int c = Move[2];
                            int r = Move[1];

                            for (r = Move[1]; r > Move[1] - 5; --r)// up
                            {
                                if (r < 1)
                                {
                                   // xCross2--;
                                    continue;
                                }
                                if (c > 22)
                                {
                                  //  xCross2--;
                                    continue;
                                }

                                if (Movement[r, c] == 1)
                                {
                                    xCross2++;
                                }
                                else if (Movement[r, c] == -1)
                                {
                                    xCross2--; break;
                                }
                                c++;
                            }

                            c = Move[2];
                            for (r = Move[1]; r < Move[1] + 5; ++r)// down
                            {
                                if (r > 17)
                                {
                                   // xCross2--;
                                    continue;
                                }
                                if (c < 1)
                                {
                                 //   xCross2--;
                                    continue;
                                }
                                if (Movement[r, c] == 1)
                                {
                                    xCross2++;
                                }
                                else if (Movement[r, c] == -1)
                                {
                                    xCross2--; break;
                                }

                                c--;
                            }
                            if (tempMark < xCross2)
                            {
                                tempRow = Move[1];
                                tempCol = Move[2];
                                tempMark = xCross2;
                            }
                        }//end of else
                    } // end of if statement: score==3;
                }// end of the two main for-loops
            Move[1] = tempRow;
            Move[2] = tempCol;
            return tempMark;
        }

        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        public void StrategyLevel3()
        {
            int[] best = new int[3];
            //============================================================
            /* 1 draw and win */
            //--------------------------------------------------
            DrawAndWin_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                int rowAIMove = best[1];
                int columnAIMove = best[2];

                //MessageBox.Show("we made it");
                Osymbol(best[1], best[2]);

                defend[rowAIMove, columnAIMove] = 1;
                Movement[rowAIMove, columnAIMove] = -1;

                WinByRow(rowAIMove);
                best = null; // remove an object, or array
                isDraw = false;

                return;
            }

            //------------------------------------------------
            DrawAndWin_ByColumn(best);

            if ((best[1] != 0) && (best[2] != 0))
            {
                int rowAIMove = best[1];
                int columnAIMove = best[2];
                Osymbol(best[1], best[2]);

                defend[rowAIMove, columnAIMove] = 1;
                Movement[rowAIMove, columnAIMove] = -1;

                WinByColumn(columnAIMove);

                best = null; // remove an object, or array
                isDraw = false;

                return;
            }
            //----------------------------------------------------
            DrawWin_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);
                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;

                WinByCross1_ColumnAndRowIncrease();
                best = null; // remove an object, or array
                isDraw = false;

                return;
            }
            //  DrawAndWin_ByRow();


            //   MessageBox.Show(" hi");




            // DetectWinner();
            //------------------------------------------------------
            DrawWin_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                int rowAIMove = best[1];
                int columnAIMove = best[2];

                Graphics playerGraphic;
                playerGraphic = this.CreateGraphics();
                Pen penAI;
                int a = columnAIMove * 40 - 20;
                int b = rowAIMove * 40 - 20;
                Rectangle myRectangle = new Rectangle();
                penAI = new Pen(Color.Red, 3);
                playerGraphic = this.CreateGraphics();
                this.Show();
                myRectangle.X = a - 20 + 10 - 5;
                myRectangle.Y = b - 20 + 5;
                myRectangle.Width = 30;
                myRectangle.Height = 30;
                playerGraphic.DrawEllipse(penAI, myRectangle);
                defend[rowAIMove, columnAIMove] = 1;
                Movement[rowAIMove, columnAIMove] = -1;

                WinByCross2_ColumnAndRowDecrease();
                best = null; // remove an object, or array
                isDraw = false;

                return;
            }
            //========================================================================================================
            /* 2 draw if there is X 4 times in sequence */


            //-----------2.1 : For row!
            x4Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //-----------2.2 : For column!
            x4Times_ByColumn(best);

            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //----------2.3 : For cross_1 
            x4Times_ByCross1_ColumnAndRowIncrease(best);

            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //----------2.4 : For cross_2
            x4Times_ByCross2_ColumnAndRowDecrease(best);


            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }

            /* 3. draw if there is O 3 times in sequence */
            //--------- 3.1 . For row

            o3Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {



                Osymbol(best[1], best[2]);
                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------------ 3.2 : For column
            o3Times_ByColumn(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------------- 3.3 : for cross_1
            o3Times_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------------- 3.4 : for cross_2
            o3Times_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            // 4. x 3 times, we need to decide the mark

            double tempX = 0;

            int tempRow = 0;
            int tempCol = 0;
            // 4.1 row

            // best[1] is row.
            double xMarkByrow = x3Times_ByRowLevel3(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                tempX = xMarkByrow;
                tempRow = best[1];
                tempCol = best[2];
            }

            double xMarkByCol = x3Times_ByColumn_Level3(best);
            if ((best[1] != 0) && (best[2] != 0) && (tempX < xMarkByCol))
            {
                tempX = xMarkByCol;
                tempRow = best[1];
                tempCol = best[2];
            }
            double xMarkByCross1 = x3Times_ByCross1_ColumnAndRowIncrease_Level3(best);
            if ((best[1] != 0) && (best[2] != 0) && (tempX < xMarkByCross1))
            {
                tempX = xMarkByCross1;
                tempRow = best[1];
                tempCol = best[2];
            }
            double xMarkByCross2;
            xMarkByCross2 = x3Times_ByCross2_ColumnAndRowDecrease_Level3(best);
            if ((best[1] != 0) && (best[2] != 0) && (tempX < xMarkByCross2))
            {
                tempX = xMarkByCross2;
                tempRow = best[1];
                tempCol = best[2];
            }

            // ->>> decide the best move
            if ((tempRow != 0) && (tempCol != 0))
            {
                Osymbol(tempRow, tempCol);

                defend[tempRow, tempCol] = 1;
                Movement[tempRow, tempCol] = -1;
                best = null; // remove an object, or array
                return;

            }
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }

            /* 5. draw if there is O 2 times in sequence */
            //------ 5.1 For row
            o2Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }

            //--------5.2 For column
            o2Times_ByColumn(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //---------5.3 For cross_1
            o2Times_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------- 5.4 For cross_2
            o2Times_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            /* 6. draw if there is X 2 times in sequence */
            //--------- 6.1 For row
            x2Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //-------- 6.2 For column
            x2Times_ByColumn(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //----- 6.3 For cross_1
            x2Times_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);
                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------ 6.4 For cross 2
            x2Times_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }

            /* 7. draw if there is o 1 times in sequence */
            //--------- 7.1 For row
            o1Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------ 7.2 For column
            o1Times_ByColumn(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------- 7.3 For cross_1
            o1Times_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //----------- 7.4 For cross_2

            o1Times_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            /* 8. draw if there is x 1   times in sequence */
            //------ 8.1 For row
            x1Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------ 8.2 for column 
            x1Times_ByColumn(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------ 8.3 for Cross_1
            x1Times_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //-------- 8.4 For cross_2
            x1Times_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }



            //----- other wise, it is player O first turn . we random 
            int[] arr1 = new int[8] { 5, 6, 7, 8, 9, 10, 11, 12 };
            Random rd1 = new Random();
            int[] arr2 = new int[13] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            Random rd2 = new Random();
            int firstRow = 0;
            int randomRow = 0;

            int firstCol = 0;
            int randomCol = 0;
            do
            {

                firstRow = rd1.Next(0, 2);
                randomRow = arr1[firstRow];
                best[1] = randomRow;


                firstCol = rd2.Next(0, 13);
                randomCol = rd2.Next(0, 13);
                best[2] = randomCol;


                if ((best[1] != 0) && (best[2] != 0) && (Movement[best[1], best[2]] == 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    rd1 = null;
                    rd2 = null;
                    arr1 = null;
                    arr2 = null;
                    return;
                }
            } while (true);



            //-----










            /*
                  if ((best[1] != 0) && (best[2] != 0))
                   {
                       Osymbol(best[1], best[2]);
                       defend[best[1], best[2]] = 1;
                       Movement[best[1], best[2]] = -1;
                       best = null; // remove an object, or array
                       return;
                   }
                   */


            /*
        x3Times_ByColumn(best);
        if ((best[1] != 0) && (best[2] != 0))
        {

            int r = best[1];
            while (r > 0)
            {
                if (Movement[r, best[2]] == 1)
                {
                    mark_xByCol++;
                }
                else if (Movement[r, best[2]] == -1)
                {
                    mark_xByCol--; break;
                }
                r--;
            }
            r = best[1];
            while (r <= 17)
            {
                if (Movement[r, best[2]] == 1)
                {
                    mark_xByCol++;
                }
                else if (Movement[r, best[2]] == -1)
                {
                    mark_xByCol--; break;
                }
                r++;

            }

            if (mark_xByCol > markTemp)
            {
                markTemp = mark_xByCol;
                tempRow = best[1];
                tempCol = best[2];
            }
        }


        x3Times_ByCross1_ColumnAndRowIncrease(best);
        if ((best[1] != 0) && (best[2] != 0))
        {
            int r = best[1];
            int c = best[2];
            while (r > 0)
            {
                if (c < 1) break;

                if (Movement[r, c] == 1)
                {
                    mark_xByCross1++;
                }
                else if (Movement[r, c] == -1)
                {
                    mark_xByCross1--; break;
                }

                r--; c--;
            }

            r = best[1]; c = best[2];
            while (r <= 17)
            {
                if (c > 22) break;

                if (Movement[r, c] == 1)
                {
                    mark_xByCross1 = mark_xByCross1 + 1;
                }
                else if (Movement[r, c] == -1)
                {
                    mark_xByCross1--; break;
                }
                r++; c++;
            }

            if (mark_xByCross1 > markTemp)
            {
                markTemp = mark_xByCross1;
                tempRow = best[1];
                tempCol = best[2];
            }


        }// end cross1
        x3Times_ByCross2_ColumnAndRowDecrease(best);
        if ((best[1] != 0) && (best[2] != 0))
        {
            int r = best[1];
            int c = best[2];
            while (r > 0)
            {
                if (c > 22) break;

                if (Movement[r, c] == 1)
                {
                    mark_xByCross2++;
                }
                else if (Movement[r, c] == -1)
                {
                    mark_xByCross2--; break;
                }

                r--; c++;
            }// end while r>0
            r = best[1];
            c = best[2];
            while (r <= 17)
            {
                if (c < 1) break;
                if (Movement[r, c] == 1)
                {
                    mark_xByCross2++;
                }
                else if (Movement[r, c] == -1)
                {
                    mark_xByCross2--; break;
                }
                r++; c--;


            }// end while r<=17
            if (mark_xByCross2 > markTemp)
            {
                markTemp = mark_xByCross2;
                tempRow = best[1];
                tempCol = best[2];
            }


        }// end of case cross2

        /**** Decide to draw */










        }
        //##################################################################################################################################################
        /* Useful functions in level 4 */
        double x3Times_ByRowLevel4(int[] Move)
        {
            int tempRow = 0;
            int tempCol = 0;
            double tempMark = 0;
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 2; columnAIMove <= 18; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2] +
                                Movement[rowAIMove, columnAIMove + 3];
                    //Movement[rowAIMove, columnAIMove + 4];
                    if (score == 3)
                    {
                        Move[1] = rowAIMove;
                        Move[2] = columnAIMove;
                        for (int i = columnAIMove; i < columnAIMove + 5 - 1; ++i)
                        {
                            if (Movement[rowAIMove, i] == 0)
                            {
                                Move[1] = rowAIMove;
                                Move[2] = i;
                                break;
                            }
                        }
                        double xMark = 0;
                        for (int z = Move[2]; z <= Move[2] + 4; z++)
                        {
                            //  if (z > Move[2]) x++;
                            if (z > 22)
                            {
                                continue;
                            }
                            if (Movement[Move[1], z] == 1)
                            {
                                xMark+=2;
                            }
                            else if (Movement[Move[1], z] == -1)
                            {
                                //    MessageBox.Show("Hello");
                                xMark -= 3; break;
                            }
                        }

                        for (int z = Move[2]; z > Move[2] - 5; --z)
                        {
                            if (z < 1)
                            {
                                continue;
                            }
                            if (Movement[Move[1], z] == 1)
                            {
                                xMark+=2;
                            }
                            else if (Movement[Move[1], z] == -1)
                            {
                                xMark -= 3; break;
                            }
                        }
                        if (tempMark < xMark)
                        {
                            tempRow = Move[1];
                            tempCol = Move[2];
                            tempMark = xMark;
                        }
                    }//end of if-statement score==3
                } // end for loop ColumnOfAI
            } // end for rowOfAI

            Move[1] = tempRow;
            Move[2] = tempCol;
            return tempMark;
        }

        double x3Times_ByColumn_Level4(int[] Move)
        {
            int tempRow = 0; int tempCol = 0;
            double tempMark = 0;
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 2; rowAIMove <= 13; ++rowAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove] +
                            Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == 3) // there is one move that we can win the game
                    {
                        double xMark = 0;
                        if (rowAIMove == 14)
                        {
                            if (Movement[13, columnAIMove] == 0)
                            {
                                Move[1] = 13;
                                Move[2] = columnAIMove;
                                tempRow = Move[1];
                                tempCol = Move[2];
                                tempMark = 2;
                            }
                        }
                        else if (rowAIMove == 13)
                        {
                            if (Movement[13, columnAIMove] == 0)
                            {
                                Move[1] = 13;
                                Move[2] = columnAIMove;
                                tempRow = Move[1];
                                tempCol = Move[2];
                                tempMark = 2;
                            }
                            else if (Movement[12, columnAIMove] == 0)
                            {
                                Move[1] = 12;
                                Move[2] = columnAIMove;
                                tempRow = Move[1];
                                tempCol = Move[2];
                                tempMark = 2;
                            }
                        }
                        else if (rowAIMove == 2)
                        {
                            if (Movement[5, columnAIMove] == 0)
                            {
                                Move[1] = 5;
                                Move[2] = columnAIMove;
                                tempRow = Move[1];
                                tempCol = Move[2];
                                tempMark = 2;
                            }
                        }
                        else
                        {
                            for (int j = rowAIMove; j <= rowAIMove + 5 - 1; ++j)
                            {
                                if (j > 17) continue;
                                if (Movement[j, columnAIMove] == 0)
                                {
                                    Move[1] = j;
                                    Move[2] = columnAIMove;
                                    break;
                                }
                            }
                            //--------
                        }

                        for (int z = Move[1]; z > Move[1] - 4 - 1; --z) // down row
                        {
                            if (z < 1) continue;
                            if (Movement[z, Move[2]] == 1)
                            {
                                xMark+=2;
                            }
                            else if (Movement[z, Move[2]] == -1)
                            {
                                xMark-=3;
                                break;
                            }
                        }
                        for (int z = Move[1]; z <= Move[1] + 4 + 1; z++) // up row
                        {
                            if (z > 17) continue;
                            if (Movement[z, Move[2]] == 1)
                            {
                                xMark+=2;
                            }
                            else if (Movement[z, Move[2]] == -1)
                            {
                                xMark-=3; break;
                            }
                        }

                        if (tempMark < xMark)
                        {
                            tempRow = Move[1];
                            tempCol = Move[2];
                            tempMark = xMark;
                        }

                    }//end of if statements: score==3
                }
            }
            Move[1] = tempRow;
            Move[2] = tempCol;
            return tempMark;
        }

        double x3Times_ByCross1_ColumnAndRowIncrease_Level4(int[] Move)
        {
            int tempRow = 0;
            int tempCol = 0;
            double tempMark = 0;
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1 + 1; columnAIMove <= 18; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2] +
                             Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == 3)
                    {
                        if (rowAIMove == 12 && columnAIMove == 17)
                        {
                            if (Movement[11, 16] == 0)
                            {
                                tempRow = 11;
                                tempCol = 16;

                                Move[1] = 11;
                                Move[2] = 16;
                                tempMark = 2;
                            }

                        }
                        else if (rowAIMove == 1 && columnAIMove == 18)// it is next to the wall
                        {
                            tempRow = 0;
                            tempCol = 0;

                            Move[1] = 0;
                            Move[2] = 0;
                            tempMark = 0;
                        }
                        else
                        {

                            int i = rowAIMove;
                            int j = columnAIMove;
                            for (i = rowAIMove; i <= rowAIMove + 5 - 1; i++)
                            {
                                if (i > 17) continue;
                                if (j > 22) continue;
                                if (Movement[i, j] == 0)
                                {
                                    Move[1] = i;
                                    Move[2] = j;
                                    break;
                                }
                                j++;
                            }

                            double xCross1 = 0;
                            int c = Move[2];
                            int r = Move[1];
                            for (r = Move[1]; r < Move[1] + 5; ++r)
                            {
                                if (r > 17) continue;
                                if (c > 22) continue;

                                if (Movement[r, c] == 1)
                                {
                                    xCross1 +=2;
                                }
                                else if (Movement[r, c] == -1)
                                {
                                    xCross1 -=3; break;
                                }
                                c++;
                            }

                            c = Move[2];
                            for (r = Move[1]; r > Move[1] - 5; --r)
                            {
                                if (r < 1) continue;
                                if (c < 1) continue;

                                if (Movement[r, c] == 1)
                                {
                                    xCross1 +=2;
                                }
                                else if (Movement[r, c] == -1)
                                {
                                    xCross1 -=3; break;
                                }

                                c--;
                            }

                            if (tempMark < xCross1)
                            {
                                tempRow = Move[1];
                                tempCol = Move[2];
                                tempMark = xCross1;
                            }

                        }// end of else
                    } // end of if condition: score ==3

                } // end of two main for-loops
            Move[1] = tempRow;
            Move[2] = tempCol;
            return tempMark;
        }

        double x3Times_ByCross2_ColumnAndRowDecrease_Level4(int[] Move)
        {
            int tempRow = 0;
            int tempCol = 0;
            double tempMark = 0;
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            for (rowAIMove = 17; rowAIMove > 3; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2] +
                            Movement[rowAIMove - 3, columnAIMove + 3];
                    //  Movement[rowAIMove - 4, columnAIMove + 4];
                    if (score == 3) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;
                        int i = rowAIMove;
                        int j = columnAIMove;
                        if (rowAIMove == 17 && columnAIMove == 1)
                        {
                            tempRow = 0;
                            tempCol = 0;
                            tempMark = 0;
                        }
                        else
                        {
                            for (j = columnAIMove; j <= columnAIMove + 5 - 1; j++)
                            {
                                if (Movement[i, j] == 0)
                                {
                                    // we made it. Yeah.

                                    Move[1] = i;
                                    Move[2] = j;
                                    break;
                                }
                                i--;
                            }
                            double xCross2 = 0;
                            int c = Move[2];
                            int r = Move[1];

                            for (r = Move[1]; r > Move[1] - 5; --r)// up
                            {
                                if (r < 1)
                                {
                                    // xCross2--;
                                    continue;
                                }
                                if (c > 22)
                                {
                                    //  xCross2--;
                                    continue;
                                }

                                if (Movement[r, c] == 1)
                                {
                                    xCross2+=2;
                                }
                                else if (Movement[r, c] == -1)
                                {
                                    xCross2-=3; break;
                                }
                                c++;
                            }

                            c = Move[2];
                            for (r = Move[1]; r < Move[1] + 5; ++r)// down
                            {
                                if (r > 17)
                                {
                                    // xCross2--;
                                    continue;
                                }
                                if (c < 1)
                                {
                                    //   xCross2--;
                                    continue;
                                }
                                if (Movement[r, c] == 1)
                                {
                                    xCross2+=2;
                                }
                                else if (Movement[r, c] == -1)
                                {
                                    xCross2-=3; break;
                                }

                                c--;
                            }
                            if (tempMark < xCross2)
                            {
                                tempRow = Move[1];
                                tempCol = Move[2];
                                tempMark = xCross2;
                            }
                        }//end of else
                    } // end of if statement: score==3;
                }// end of the two main for-loops
            Move[1] = tempRow;
            Move[2] = tempCol;
            return tempMark;
        }

        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        double o2Times_ByRow_Level4(int[] Move)
        {

            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempMark = 0;
            int tempRow = 0;
            int tempCol = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2];
                    // Movement[rowAIMove, columnAIMove + 3];
                    //  Movement[rowAIMove, columnAIMove + 4];

                    if (score == -2)
                    {

                        int bestMove_Column = columnAIMove;

                        for (int i = columnAIMove; i <= columnAIMove + 5 - 1 - 1; ++i)
                        {
                            if (i > 17) continue;
                            if (Movement[rowAIMove, i] == 0)
                            {

                                Move[1] = rowAIMove;
                                Move[2] = i;

                                if (Move[2] < 22)
                                {
                                    if (Movement[Move[1], Move[2] + 1] == 1)// there is another x,  not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        // return ;
                                    }
                                }
                                if (Move[2] > 1)
                                {

                                    if (Movement[Move[1], Move[2] - 1] == 1)// there is another x, not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        // return ;
                                    }

                                }

                                break;
                            }
                            //---------
                        }

                        int c = Move[2];
                        int xMark = 0;

                        for (c = Move[2]; c < Move[2] + 4 + 1; c++)
                        {
                            if (c > 22) continue;
                            if (Movement[Move[1], c] == -1) // it is o
                            {
                                xMark += 2;
                            }
                            else if (Movement[Move[1], c] == 1) // it is x
                            {
                                xMark -= 1; // add  2
                                break;
                            }
                        }// end of for loop c
                        c = Move[2];
                        for (c = Move[2]; c > Move[2] - 4 - 1; c--)
                        {
                            if (c < 1) continue;
                            if (Movement[Move[1], c] == -1) // it is o
                            {
                                xMark += 2;

                            }
                            else if (Movement[Move[1], c] == 1) // it is x
                            {
                                xMark -= 1;
                                break;
                            }
                        }//end of for loop c

                        if (tempMark < xMark)
                        {
                            tempMark = xMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }


                    }// end of if
                } // end for loop ColumnOfAI

            } // end for rowOfAI 

            Move[1] = tempRow;
            Move[2] = tempCol;

            if (Move[2] < 5)
            {
                if (Movement[Move[1], 5] == 1)
                {
                    Move[1] = 0;
                    Move[2] = 0;
                    tempMark = 0;
                    return 0;
                }

            }
            if (Move[2] > 18)
            {
                if (Movement[Move[1], 18] == 1)
                {
                    Move[1] = 0;
                    Move[2] = 0;
                    tempMark = 0;
                    return 0;
                }
            }







            return tempMark;
        }
        //>>>>>>>>>>>>>>>>>>>>>?

        double o2Times_ByColumn_Level4(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempRow = 0;
            int tempCol = 0;
            int tempMark = 0;
            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13 + 1 + 1; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove];
                    //  Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == -2) // there is one move that we can win the game
                    {
                        for (int j = rowAIMove; j <= rowAIMove + 5 - 1 - 1; ++j)
                        {
                            if (j > 22) continue;
                            if (Movement[j, columnAIMove] == 0)
                            {

                                Move[1] = j;
                                Move[2] = columnAIMove;
                                if (Move[1] < 17)
                                {
                                    if (Movement[Move[1] + 1, Move[2]] == 1)// there is another x, we are not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        tempMark = 0;
                                    }
                                }
                                if (Move[1] > 1)
                                {
                                    if (Movement[Move[1] - 1, Move[2]] == 1)// there is another x, we are not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        tempMark = 0;
                                    }

                                }

                                break;
                            }
                        }// end of -for loop j
                        int r = Move[1];
                        int oMark = 0;
                        for (r = Move[1]; r < Move[1] + 4 + 1; r++)
                        {
                            if (r > 17) continue;
                            if (Movement[r, Move[2]] == -1) // it is o
                            {
                                oMark += 2; // add 2
                            }
                            else if (Movement[r, Move[2]] == 1) // it is x 
                            {
                                oMark -= 1; // minus 1;
                                break;
                            }
                        }
                        r = Move[1];
                        for (r = Move[1]; r > Move[1] - 4 - 1; r--)
                        {
                            if (r < 1) continue;
                            if (Movement[r, Move[2]] == -1) // it is o
                            {
                                oMark += 2; // add 2
                            }
                            else if (Movement[r, Move[2]] == 1) // it is x 
                            {
                                oMark -= 1; // minus 1;
                                break;
                            }
                        }
                        if (tempMark < oMark)
                        {
                            tempMark = oMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }
                    }// end of if condition : score ==-2
                }
            }
            Move[1] = tempRow;
            Move[2] = tempCol;
            if (Move[1] == 1)
            {
                if (Movement[Move[1] + 3, Move[2]] == 0)
                {
                    Move[1] += 3;
                }

            }



            if (Move[1] < 5)
            {
                if (Movement[5, Move[2]] == 1)
                {
                    Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                }

            }
            if (Move[1] > 13)
            {
                if (Movement[13, Move[2]] == 1)
                {
                    Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                }
            }



            return tempMark;
        }
        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        double o2Times_ByCross1_ColumnAndRowIncrease_Level4(int[] Move)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempMark = 0;
            int tempRow = 0;
            int tempCol = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2];
                    // Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == -2)
                    {

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1; i++)
                        {
                            if (i > 17) continue;
                            if (j > 22) continue;
                            if (Movement[i, j] == 0)
                            {

                                Move[1] = i;
                                Move[2] = j;
                                if ((Move[1] < 17 && Move[2] < 22) && (Movement[Move[1] + 1, Move[2] + 1] == 1))// there is another x, we are not going to make another o
                                {


                                    //  MessageBox.Show("Ryan AN");

                                    Move[1] = 0;
                                    Move[2] = 0;

                                }
                                if ((Move[1] > 1 && Move[2] > 1) && (Movement[Move[1] - 1, Move[2] - 1] == 1))// there is another x, we are not going to make another o
                                {

                                    //  MessageBox.Show("Pheakdey AN");

                                    Move[1] = 0;
                                    Move[2] = 0;

                                }
                                break;
                            }
                            j++;
                        }// end of for loop i
                        int r = Move[1];
                        int c = Move[2];
                        int oMark = 0;
                        for (r = Move[1]; r < Move[1] + 4 + 1; ++r)
                        {
                            if (r > 17) continue;
                            if (c > 22) continue;
                            if (Movement[r, c] == -1) // it is o
                            {
                                oMark += 2; // we add 2 more to the mark

                            }
                            else if (Movement[r, c] == 1) // it is x
                            {
                                oMark -= 1; // we minus mark only 1
                                break;
                            }

                            c++;
                        }
                        r = Move[1];
                        c = Move[2];
                        for (r = Move[1]; r > Move[1] - 4 - 1; r--)
                        {
                            if (r < 1) continue;
                            if (c < 1) continue;

                            if (Movement[r, c] == -1) // it is o
                            {
                                oMark += 2; // we add 2 more to the mark

                            }
                            else if (Movement[r, c] == 1) // it is x
                            {
                                oMark -= 1; // we minus mark only 1
                                break;
                            }
                            c--;
                        }
                        if (tempMark < oMark)
                        {
                            tempMark = oMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }

                    }// end of if sta. score==-2
                }// enf of the 2 main for loops
            Move[1] = tempRow;
            Move[2] = tempCol;
            if (Move[1] == 1)
            {
                if (Movement[5, Move[2] + 4] == 1)
                {
                    Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                }

            }



            if (Move[2] < 5)
            {
                int step = 5 - Move[2];
                if (Move[1] + step <= 17)
                {
                    if (Movement[Move[1] + step, 5] == 1)// there is x
                    {
                        Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                    }
                }
            }

            if (Move[2] > 17)
            {
                int step = Move[2] - 17;
                if (Move[1] + step <= 17)//row <=17
                {
                    if (Movement[Move[1] + step, 17] == 1)// there is x
                    {
                        Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                    }
                }
            }


            return tempMark;
        }
        //>>>>>>>>>>>>>>>>>>>>>>
        double o2Times_ByCross2_ColumnAndRowDecrease_Level4(int[] Move)
        {

            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            int tempRow = 0;
            int tempCol = 0;
            int tempMark = 0;
            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2];
                    // Movement[rowAIMove - 3, columnAIMove + 3];
                    //Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == -2) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;

                        int i = rowAIMove;
                        int j = columnAIMove;

                        for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1; i++)
                        {
                            if (j >= 23) continue;
                            if (i >= 18) continue;
                            
                            if (Movement[i, j] == 0)
                            {
                                // we made it. Yeah.

                                Move[1] = i;
                                Move[2] = j;
                                if (Move[1] > 1 && Move[2] < 22 && (Movement[Move[1] - 1, Move[2] + 1] == 1))// there is another x, we are not going to make another o
                                {
                                    Move[1] = 0;
                                    Move[2] = 0;

                                }
                                else if ((Move[1] < 17 && Move[2] > 1) && (Movement[Move[1] + 1, Move[2] - 1] == 1))// there is another x, we are not going to make another o
                                {

                                    Move[1] = 0;
                                    Move[2] = 0;

                                }
                                break;
                            }
                            j--;
                        }// end of for loop  :i

                        int r = Move[1];
                        int c = Move[2];
                        int oMark = 0;
                        for (r = Move[1]; r < Move[1] + 4 + 1; ++r)
                        {
                            if (r > 17) continue;
                            if (c < 1) continue;
                            if (Movement[r, c] == -1) // it is o
                            {
                                oMark += 2; // we add 2 more to the mark

                            }
                            else if (Movement[r, c] == 1) // it is x
                            {
                                oMark -= 1; // we minus mark only 1
                                break;
                            }

                            c--;
                        }
                        r = Move[1];
                        c = Move[2];
                        for (r = Move[1]; r > Move[1] - 4 - 1; r--)
                        {
                            if (r < 1) continue;
                            if (c > 22) continue;

                            if (Movement[r, c] == -1) // it is o
                            {
                                oMark += 2; // we add 2 more to the mark

                            }
                            else if (Movement[r, c] == 1) // it is x
                            {
                                oMark -= 1; // we minus mark only 1
                                break;
                            }
                            c++;
                        }
                        if (tempMark < oMark)
                        {
                            tempMark = oMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }
                    } // end of if statements : score ==-2
                }//end of the 2 main for loops

            Move[1] = tempRow;
            Move[2] = tempCol;

            if (Move[2] < 5)
            {
                int step = 5 - Move[2];
                if (Move[1] - step > 0)
                {
                    if (Movement[Move[1] - step, 5] == 1)
                    {
                        Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                    }
                }
            }
            if (Move[2] > 18)
            {
                int step = Move[2] - 18;
                if (Move[1] + step <= 22)
                {
                    if (Movement[Move[1] + step, 18] == 1)
                    {
                        Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                    }
                }
            }


            return tempMark;
        }
        double x2Times_ByRow_Level4(int[] Move)
        {

            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempMark = 0;
            int tempRow = 0;
            int tempCol = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2];
                    // Movement[rowAIMove, columnAIMove + 3];
                    //  Movement[rowAIMove, columnAIMove + 4];

                    if (score == 2)
                    {
                        int bestMove_Column = columnAIMove;

                        for (int i = columnAIMove; i <= columnAIMove + 5 - 1 - 1; ++i)
                        {
                            if (Movement[rowAIMove, i] == 0)
                            {

                                Move[1] = rowAIMove;
                                Move[2] = i;


                                if (Move[2] < 22)
                                {
                                    if (Movement[Move[1], Move[2] + 1] == -1)// there is another p,  not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        // return ;
                                    }
                                }
                                if (Move[2] > 1)
                                {

                                    if (Movement[Move[1], Move[2] - 1] == -1)// there is another o, not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        // return ;
                                    }

                                }
                                break;
                            }
                            //---------
                        }

                        int c = Move[2];
                        int xMark = 0;
                        for (c = Move[2]; c < Move[2] + 4 + 1; c++)
                        {
                            if (c > 22) continue;
                            if (Movement[Move[1], c] == -1) // it is o
                            {
                                xMark -= 3;// 1; 
                                break;
                            }
                            else if (Movement[Move[1], c] == 1) // it is x
                            {
                                xMark += 2; // add  2

                            }
                        }// end of for loop c
                        c = Move[2];
                        for (c = Move[2]; c > Move[2] - 4 - 1; c--)
                        {
                            if (c < 1) continue;
                            if (Movement[Move[1], c] == -1) // it is o
                            {
                                xMark -= 3;// 1; //  minus 1 to the mark
                                break;

                            }
                            else if (Movement[Move[1], c] == 1) // it is x
                            {
                                xMark += 2; //add 2
                            }
                        }//end of for loop c

                        if (tempMark < xMark)
                        {
                            tempMark = xMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }




                    }// end of if statement score==2
                } // end for loop ColumnOfAI

            } // end for rowOfAI 
            Move[1] = tempRow;
            Move[2] = tempCol;
            return tempMark;
        }
        //>>>>>>

        double x2Times_ByColumn_Level4(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempRow = 0;
            int tempCol = 0;
            int tempMark = 0;
            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13 + 1 + 1; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove];
                    //  Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == 2) // there is one move that we can win the game
                    {
                        for (int j = rowAIMove; j <= rowAIMove + 5 - 1 - 1; ++j)
                        {
                            if (Movement[j, columnAIMove] == 0)
                            {

                                Move[1] = j;
                                Move[2] = columnAIMove;
                                if (Move[1] < 17)
                                {
                                    if (Movement[Move[1] + 1, Move[2]] == -1)// there is another o, not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        tempMark = 0;
                                    }
                                }
                                if (Move[1] > 1)
                                {
                                    if (Movement[Move[1] - 1, Move[2]] == -1)// there is another o,  not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        tempMark = 0;
                                    }

                                }

                                break;
                            }
                        }// end of -for loop j
                        int r = Move[1];
                        int xMark = 0;
                        for (r = Move[1]; r < Move[1] + 4 + 1; r++)
                        {
                            if (r > 17) continue;
                            if (Movement[r, Move[2]] == -1) // it is o
                            {
                                xMark -= 3;// 1; // minus 1
                                break;
                            }
                            else if (Movement[r, Move[2]] == 1) // it is x 
                            {
                                xMark += 2; // add 2;
                            }
                        }
                        r = Move[1];
                        for (r = Move[1]; r > Move[1] - 4 - 1; r--)
                        {
                            if (r < 1) continue;
                            if (Movement[r, Move[2]] == -1) // it is o
                            {
                                xMark -= 3;// 1; // minus1
                                break;
                            }
                            else if (Movement[r, Move[2]] == 1) // it is x 
                            {
                                xMark += 2; // add 2;
                            }
                        }
                        if (tempMark < xMark)
                        {
                            tempMark = xMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }
                    }// end of if condition : score ==-2
                }
            }
            Move[1] = tempRow;
            Move[2] = tempCol;
            return tempMark;
        }
        //>>>>>>>>>>>>>>>
        double x2Times_ByCross1_ColumnAndRowIncrease_Level4(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempMark = 0;
            int tempRow = 0;
            int tempCol = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2];
                    // Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == 2)
                    {

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1; i++)
                        {
                            if (Movement[i, j] == 0)
                            {

                                Move[1] = i;
                                Move[2] = j;
                                if ((Move[1] < 17 && Move[2] < 22) && (Movement[Move[1] + 1, Move[2] + 1] == -1))// there is another o,  not going to make another x
                                {


                                    //  MessageBox.Show("Ryan AN");

                                    Move[1] = 0;
                                    Move[2] = 0;

                                }
                                if ((Move[1] > 1 && Move[2] > 1) && (Movement[Move[1] - 1, Move[2] - 1] == -1))// there is another o,not going to make another x
                                {

                                    //  MessageBox.Show("Pheakdey AN");

                                    Move[1] = 0;
                                    Move[2] = 0;

                                }
                                break;
                            }
                            j++;
                        }// end of for loop i

                        int r = Move[1];
                        int c = Move[2];
                        int xMark = 0;
                        for (r = Move[1]; r < Move[1] + 4 + 1; ++r)
                        {
                            if (r > 17) continue;
                            if (c > 22) continue;
                            if (Movement[r, c] == -1) // it is o
                            {
                                xMark -= 3;// 1;
                                break;

                            }
                            else if (Movement[r, c] == 1) // it is x
                            {
                                xMark += 2;
                            }

                            c++;
                        }
                        r = Move[1];
                        c = Move[2];
                        for (r = Move[1]; r > Move[1] - 4 - 1; r--)
                        {
                            if (r < 1) continue;
                            if (c < 1) continue;

                            if (Movement[r, c] == -1) // it is o
                            {
                                xMark -= 3;// 1; 
                                break;
                            }
                            else if (Movement[r, c] == 1) // it is x
                            {
                                xMark += 2;
                            }
                            c--;
                        }
                        if (tempMark < xMark)
                        {
                            tempMark = xMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }

                    }// end of if sta. score==-2
                }// enf of the 2 main for loops

            Move[1] = tempRow;
            Move[2] = tempCol;
            return tempMark;
        }
        //>>>>>>>>>>>>>>>>>>>>>>
        double x2Times_ByCross2_ColumnAndRowDecrease_Level4(int[] Move)
        {

            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            int tempRow = 0;
            int tempCol = 0;
            int tempMark = 0;
            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2];
                    // Movement[rowAIMove - 3, columnAIMove + 3];
                    //Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == 2) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;
                        int i = rowAIMove;
                        int j = columnAIMove;

                        if (Move[1] > 1 && Move[2] < 22 && (Movement[Move[1] - 1, Move[2] + 1] == -1))
                        {
                            Move[1] = 0;
                            Move[2] = 0;

                        }
                        else if ((Move[1] < 17 && Move[2] > 1) && (Movement[Move[1] + 1, Move[2] - 1] == -1))
                        {

                            Move[1] = 0;
                            Move[2] = 0;

                        }
                        else
                        {
                            for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1; i++)
                            {
                                if (i > 17) continue;
                                if (j > 22) continue;
                                if (Movement[i, j] == 0)
                                {
                                    // we made it. Yeah.

                                    Move[1] = i;
                                    Move[2] = j;

                                    break;
                                }
                                j--;
                            }// end of for loop  :i
                        }
                        int r = Move[1];
                        int c = Move[2];
                        int xMark = 0;
                        for (r = Move[1]; r < Move[1] + 4 + 1; ++r)
                        {
                            if (r > 17) continue;
                            if (c < 1) continue;
                            if (Movement[r, c] == -1) // it is o
                            {
                                xMark -= 3;// 1; // we add 2 more to the mark
                                break;
                            }
                            else if (Movement[r, c] == 1) // it is x
                            {
                                xMark += 2; // we minus mark only 1
                            }

                            c--;
                        }
                        r = Move[1];
                        c = Move[2];
                        for (r = Move[1]; r > Move[1] - 4 - 1; r--)
                        {
                            if (r < 1) continue;
                            if (c > 22) continue;

                            if (Movement[r, c] == -1) // it is o
                            {
                                xMark -= 3;// 1; 
                                break;
                            }
                            else if (Movement[r, c] == 1) // it is x
                            {
                                xMark += 2;
                            }
                            c++;
                        }
                        if (tempMark < xMark)
                        {
                            tempMark = xMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }
                    } // end of if statements : score ==-2
                }//end of the 2 main for loops
            Move[1] = tempRow;
            Move[2] = tempCol;

            return tempMark;
        }
        //>>>>>>>>>>>>>>>>>>>>>
        public void StrategyLevel4()
        {
            int[] best = new int[3];
            //============================================================
            /* 1 draw and win */
            //--------------------------------------------------
            DrawAndWin_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                int rowAIMove = best[1];
                int columnAIMove = best[2];

                //MessageBox.Show("we made it");
                Osymbol(best[1], best[2]);

                defend[rowAIMove, columnAIMove] = 1;
                Movement[rowAIMove, columnAIMove] = -1;

                WinByRow(rowAIMove);
                best = null; // remove an object, or array
                isDraw = false;

                return;
            }

            //------------------------------------------------
            DrawAndWin_ByColumn(best);

            if ((best[1] != 0) && (best[2] != 0))
            {
                int rowAIMove = best[1];
                int columnAIMove = best[2];
                Osymbol(best[1], best[2]);

                defend[rowAIMove, columnAIMove] = 1;
                Movement[rowAIMove, columnAIMove] = -1;

                WinByColumn(columnAIMove);

                best = null; // remove an object, or array
                isDraw = false;

                return;
            }
            //----------------------------------------------------
            DrawWin_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);
                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;

                WinByCross1_ColumnAndRowIncrease();
                best = null; // remove an object, or array
                isDraw = false;

                return;
            }
            //  DrawAndWin_ByRow();


            //   MessageBox.Show(" hi");

            // DetectWinner();
            //------------------------------------------------------
            DrawWin_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                int rowAIMove = best[1];
                int columnAIMove = best[2];

                Graphics playerGraphic;
                playerGraphic = this.CreateGraphics();
                Pen penAI;
                int a = columnAIMove * 40 - 20;
                int b = rowAIMove * 40 - 20;
                Rectangle myRectangle = new Rectangle();
                penAI = new Pen(Color.Red, 3);
                playerGraphic = this.CreateGraphics();
                this.Show();
                myRectangle.X = a - 20 + 10 - 5;
                myRectangle.Y = b - 20 + 5;
                myRectangle.Width = 30;
                myRectangle.Height = 30;
                playerGraphic.DrawEllipse(penAI, myRectangle);
                defend[rowAIMove, columnAIMove] = 1;
                Movement[rowAIMove, columnAIMove] = -1;

                WinByCross2_ColumnAndRowDecrease();
                best = null; // remove an object, or array
                isDraw = false;

                return;
            }
            //========================================================================================================
            /* 2 draw if there is X 4 times in sequence */


            //-----------2.1 : For row!
            x4Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //-----------2.2 : For column!
            x4Times_ByColumn(best);

            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //----------2.3 : For cross_1 
            x4Times_ByCross1_ColumnAndRowIncrease(best);

            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //----------2.4 : For cross_2
            x4Times_ByCross2_ColumnAndRowDecrease(best);


            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }

            /* 3. draw if there is O 3 times in sequence */
            //--------- 3.1 . For row

            o3Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);
                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------------ 3.2 : For column
            o3Times_ByColumn(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------------- 3.3 : for cross_1
            o3Times_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------------- 3.4 : for cross_2
            o3Times_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            double tempScore = 0;
            int tempRow = 0;
            int tempCol = 0;
            double x3ByRow = x3Times_ByRowLevel4(best);
         
            //  MessageBox.Show("1//"+x3ByRow.ToString());
            if (best[1] != 0 && best[2] != 0)
            {
               
                tempScore = x3ByRow;
                tempRow = best[1];
                tempCol = best[2];
            }
               
            double x3ByCol = x3Times_ByColumn_Level4(best);
            //  MessageBox.Show("2//"+x3ByCol.ToString());

            if (best[1] != 0 && best[2] != 0 && tempScore < x3ByCol)
            {
                tempScore = x3ByCol;
                tempRow = best[1];
                tempCol = best[2];
            }
        double x3ByCross1 = x3Times_ByCross1_ColumnAndRowIncrease_Level4(best);
            //   MessageBox.Show("x3Cr1=" + x3ByCross1.ToString());
            //    MessageBox.Show("3//"+x3ByCross1.ToString());

            if (best[1] != 0 && best[2] != 0 && tempScore < x3ByCross1)
            {
                tempScore = x3ByCross1;
                tempRow = best[1];
                tempCol = best[2];
            }
            
            double x3ByCross2 = x3Times_ByCross2_ColumnAndRowDecrease_Level4(best);
            //   MessageBox.Show("4//"+x3ByCross2.ToString());

            if (best[1] != 0 && best[2] != 0 && tempScore < x3ByCross2)
            {
                tempScore = x3ByCross2;
                tempRow = best[1];
                tempCol = best[2];
            }
            
            //----
            double o2ByRow = o2Times_ByRow_Level4(best);
            // MessageBox.Show("o2Row=" + o2ByRow.ToString());
            //   MessageBox.Show("5//"+o2ByRow.ToString());
            if ((best[1] != 0) && (best[2] != 0) && (tempScore < o2ByRow))
            {
                tempScore = o2ByRow;
                tempRow = best[1];
                tempCol = best[2];
            }
            double o2ByCol = o2Times_ByColumn_Level4(best);
            //  MessageBox.Show("6//"+o2ByCol.ToString());
            if (best[1] != 0 && best[2] != 0 && tempScore < o2ByCol)
            {
                tempScore = o2ByCol;
                tempRow = best[1];
                tempCol = best[2];
            }
            double o2ByCross1 = o2Times_ByCross1_ColumnAndRowIncrease_Level4(best);
            //   MessageBox.Show("7//"+o2ByCross1.ToString());
            if (best[1] != 0 && best[2] != 0 && tempScore < o2ByCross1)
            {
                tempScore = o2ByCross1;
                tempRow = best[1];
                tempCol = best[2];
            }
            double o2ByCross2 = o2Times_ByCross2_ColumnAndRowDecrease_Level4(best);
            //  MessageBox.Show("8//"+o2ByCross2.ToString());
            if (best[1] != 0 && best[2] != 0 && tempScore < o2ByCross2)
            {
                tempScore = o2ByCross2;
                tempRow = best[1];
                tempCol = best[2];
            }
            //-----
            double x2Byrow = x2Times_ByRow_Level4(best);
            //   MessageBox.Show("9//"+x2Byrow.ToString());
            if (best[1] != 0 && best[2] != 0 && tempScore < x2Byrow)
            {
                tempScore = x2Byrow;
                tempRow = best[1];
                tempCol = best[2];
            }
            double x2ByCol = x2Times_ByColumn_Level4(best);
            //    MessageBox.Show("10//"+x2ByCol.ToString());
            if (best[1] != 0 && best[2] != 0 && tempScore < x2ByCol)
            {
                tempScore = x2ByCol;
                tempRow = best[1];
                tempCol = best[2];
            }
            double x2ByCross1 = x2Times_ByCross1_ColumnAndRowIncrease_Level4(best);
            //    MessageBox.Show("11//"+x2ByCross1.ToString());
            if (best[1] != 0 && best[2] != 0 && tempScore < x2ByCross1)
            {
                tempScore = x2ByCross1;
                tempRow = best[1];
                tempCol = best[2];
            }
            double x2ByCross2 = x2Times_ByCross2_ColumnAndRowDecrease_Level4(best);
            //   MessageBox.Show("12//"+x2ByCross2.ToString());
            if (best[1] != 0 && best[2] != 0 && tempScore < x2ByCross2)
            {
                tempScore = x2ByCross2;
                tempRow = best[1];
                tempCol = best[2];
            }
            
            //      <<<<<<  Decide  >>>>>>>>>
            // MessageBox.Show("final=" + tempScore.ToString());

           if (/*(tempScore != 0) &&*/ (tempRow != 0) && (tempCol != 0))
            {
                Osymbol(tempRow, tempCol);

                defend[tempRow, tempCol] = 1;
                Movement[tempRow, tempCol] = -1;
                best = null; // remove an object, or array
                return;
            }


           /* 5. draw if there is O 2 times in sequence */
           //------ 5.1 For row
           o2Times_ByRow(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }

           //--------5.2 For column
           o2Times_ByColumn(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }
           //---------5.3 For cross_1
           o2Times_ByCross1_ColumnAndRowIncrease(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }
           //------- 5.4 For cross_2
           o2Times_ByCross2_ColumnAndRowDecrease(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }
           /* 6. draw if there is X 2 times in sequence */
           //--------- 6.1 For row
           x2Times_ByRow(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }
           //-------- 6.2 For column
           x2Times_ByColumn(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }
           //----- 6.3 For cross_1
           x2Times_ByCross1_ColumnAndRowIncrease(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);
               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }
           //------ 6.4 For cross 2
           x2Times_ByCross2_ColumnAndRowDecrease(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }

           /* 7. draw if there is o 1 times in sequence */
           //--------- 7.1 For row
           o1Times_ByRow(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }
           //------ 7.2 For column
           o1Times_ByColumn(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }
           //------- 7.3 For cross_1
           o1Times_ByCross1_ColumnAndRowIncrease(best);
           if ((best[1] != 0) && (best[2] != 0))
           {

               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }
           //----------- 7.4 For cross_2

           o1Times_ByCross2_ColumnAndRowDecrease(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }
           /* 8. draw if there is x 1   times in sequence */
           //------ 8.1 For row
           x1Times_ByRow(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }
           //------ 8.2 for column 
           x1Times_ByColumn(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }
           //------ 8.3 for Cross_1
           x1Times_ByCross1_ColumnAndRowIncrease(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }
           //-------- 8.4 For cross_2
           x1Times_ByCross2_ColumnAndRowDecrease(best);
           if ((best[1] != 0) && (best[2] != 0))
           {
               Osymbol(best[1], best[2]);

               defend[best[1], best[2]] = 1;
               Movement[best[1], best[2]] = -1;
               best = null; // remove an object, or array
               return;
           }



           //----- other wise, it is player O first turn . we random 
           int[] arr1 = new int[8] { 5, 6, 7, 8, 9, 10, 11, 12 };
           Random rd1 = new Random();
           int[] arr2 = new int[13] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
           Random rd2 = new Random();
           int firstRow = 0;
           int randomRow = 0;

           int firstCol = 0;
           int randomCol = 0;
           do
           {

               firstRow = rd1.Next(0, 2);
               randomRow = arr1[firstRow];
               best[1] = randomRow;


               firstCol = rd2.Next(0, 13);
               randomCol = rd2.Next(0, 13);
               best[2] = randomCol;


               if ((best[1] != 0) && (best[2] != 0) && (Movement[best[1], best[2]] == 0))
               {
                   Osymbol(best[1], best[2]);

                   defend[best[1], best[2]] = 1;
                   Movement[best[1], best[2]] = -1;
                   best = null; // remove an object, or array
                   rd1 = null;
                   rd2 = null;
                   arr1 = null;
                   arr2 = null;
                   return;
               }
           } while (true);





   
        } // end of function level 4


        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        /******
         * Level 5 zone ( Iron man )
         * 
         * ***************/

        void x3TimesAbsolute_ByRow(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;

            int tempRow = 0;
            int tempCol = 0;

            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2] +
                                Movement[rowAIMove, columnAIMove + 3];
                    //  Movement[rowAIMove, columnAIMove + 4];
                    if (score == 3)
                    {
                        int bestMove_Column = columnAIMove;

                        for (int i = columnAIMove; i <= columnAIMove + 5 - 1; ++i)
                        {
                            if (Movement[rowAIMove, i] == 0)
                            {
                                Move[1] = rowAIMove;
                                Move[2] = i;
                                break;
                            }
                        }
                                                
                        tempRow = Move[1];
                        tempCol = Move[2];

                        // find another seriously marks 
                        // new update AI 22-April-2016

                        // way 1. 
                        int m = 0, n = 0;
                        bool keepDoing = true;
                        int countt = 0;
                        ////////////////////////////////////
                        for (int num = Move[1]; num > Move[1] - 5; --num)
                        {

                            if (num < 1)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {

                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                        }
                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] - 1, Move[2]] + Movement[Move[1] - 2, Move[2]] == 2) // x2
                            {
                                //  xMark += 1000;
                                //      MessageBox.Show("1");
                                return;
                                //  tempRow = Move[1];
                                //tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 2, Move[2]] + Movement[Move[1] - 3, Move[2]] == 2) // x2
                            {
                                //     xMark += 1000;
                                //    MessageBox.Show("2");
                                return;
                                // tempRow = Move[1];
                                // tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 1, Move[2]] + Movement[Move[1] - 3, Move[2]] == 2) // x2
                            {
                                //    MessageBox.Show("3");
                                return;
                                //  xMark += 1000;
                                //  tempRow = Move[1];
                                // tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 2
                        ///////////////////////////////////////////
                        keepDoing = true;
                        m = Move[1]; n = Move[2];
                        countt = 0;
                        for (n = Move[2]; n > Move[2] - 5; --n)
                        {
                            if (n < 1)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (m < 1)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {

                                countt++;
                            }

                            if (countt >= 3)
                            {

                                keepDoing = false;
                            }
                            m--;
                        } // end of for loop



                        if (keepDoing == true)
                        {
                            //  MessageBox.Show("The boy2");
                            if (Movement[Move[1] - 1, Move[2] - 1] + Movement[Move[1] - 2, Move[2] - 2] == 2) // x2
                            {
                                //  MessageBox.Show("4");
                                return;
                                //   tempRow = Move[1];
                                //  tempCol = Move[2];

                            }
                            else if (Movement[Move[1] - 1, Move[2] - 1] + Movement[Move[1] - 3, Move[2] - 3] == 2) // x2
                            {
                                //   MessageBox.Show("5");
                                return;
                                //   tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 2, Move[2] - 2] + Movement[Move[1] - 3, Move[2] - 3] == 2) // x2
                            {
                                //  MessageBox.Show("6");
                                return;
                                //   tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }

                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 3   
                        ///////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (n = Move[2]; n > Move[2] - 5; --n)
                        {
                            if (n < 1)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }

                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }


                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }

                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1], Move[2] - 1] + Movement[Move[1], Move[2] - 2] == 2) // x2
                            {
                                //    MessageBox.Show("7");
                                return;
                                //  xMark += 1000;
                                //  tempRow = Move[1];
                                // tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] - 1] + Movement[Move[1], Move[2] - 3] == 2) // x2
                            {
                                //      MessageBox.Show("8");
                                return;
                                tempRow = Move[1];
                                tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] - 2] + Movement[Move[1], Move[2] - 3] == 2) // x2
                            {
                                //   MessageBox.Show("9");
                                return;
                                //tempRow = Move[1];
                                //    tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 4
                        /////////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (n = Move[2]; n > Move[2] - 5; --n)
                        {
                            if (n < 1)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (m > 17)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                            m++;
                        } // end of for loop

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] + 1, Move[2] - 1] + Movement[Move[1] + 2, Move[2] - 2] == 2) // x2
                            {
                                //     MessageBox.Show("10");
                                return;
                                //  xMark += 1000;
                                //  tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 1, Move[2] - 1] + Movement[Move[1] + 3, Move[2] - 3] == 2) // x2
                            {
                                //    MessageBox.Show("11");
                                return;
                                //  tempRow = Move[1];
                                // tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 2, Move[2] - 2] + Movement[Move[1] + 3, Move[2] - 3] == 2) // x2
                            {
                                ////    MessageBox.Show("12");
                                return;
                                //  tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 5
                        ////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (m = Move[1]; m < Move[1] + 5; ++m)
                        {
                            if (m > 17)
                            {
                                keepDoing = false;
                                break;
                            }

                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }

                        }
                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] + 1, Move[2]] + Movement[Move[1] + 2, Move[2]] == 2) // x2
                            {
                                return;
                                //     MessageBox.Show("13");
                                //     tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 1, Move[2]] + Movement[Move[1] + 3, Move[2]] == 2) // x2
                            {
                                //    MessageBox.Show("14");
                                return;
                                //    tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 2, Move[2]] + Movement[Move[1] + 3, Move[2]] == 2) // x2
                            {
                                //    MessageBox.Show("15");
                                return;
                                //   tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                        // way 6
                        //////////////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (m = Move[1]; m < Move[1] + 5; ++m)
                        {
                            if (m > 17)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (n > 22)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                            n++;
                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] + 1, Move[2] + 1] + Movement[Move[1] + 2, Move[2] + 2] == 2) // x2
                            {
                                return;
                                //    MessageBox.Show("16");
                                //    tempRow = Move[1];
                                //     tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 1, Move[2] + 1] + Movement[Move[1] + 3, Move[2] + 3] == 2) // x2
                            {
                                return;
                                //   MessageBox.Show("17");

                                //   tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 2, Move[2] + 2] + Movement[Move[1] + 3, Move[2] + 3] == 2) // x2
                            {
                                //    MessageBox.Show("18");
                                return;
                                //   tempRow = Move[1];
                                //    tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                        // way 7
                        /////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (n = Move[2]; n < Move[2] + 5; ++n)
                        {
                            if (n > 22)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }

                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1], Move[2] + 1] + Movement[Move[1], Move[2] + 2] == 2) // x2
                            {
                                //     MessageBox.Show("19");
                                return;
                                //    tempRow = Move[1];
                                //    tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] + 1] + Movement[Move[1], Move[2] + 3] == 2) // x2
                            {
                                //       MessageBox.Show("20");
                                return;
                                //     tempRow = Move[1];
                                //    tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] + 2] + Movement[Move[1], Move[2] + 3] == 2) // x2
                            {
                                // MessageBox.Show("21");
                                return;
                                // tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                        // way 8
                        //////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (m = Move[1]; m > Move[1] - 5; --m)
                        {
                            if (m < 1)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (n > 22)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                            n++;
                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] - 1, Move[2] + 1] + Movement[Move[1] - 2, Move[2] + 2] == 2) // x2
                            {
                                return;
                                //  MessageBox.Show("22");
                                //  tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 1, Move[2] + 1] + Movement[Move[1] - 3, Move[2] + 3] == 2) // x2
                            {
                                return;
                                //     MessageBox.Show("23");

                                //   tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 2, Move[2] + 2] + Movement[Move[1] - 3, Move[2] + 3] == 2) // x2
                            {
                                //      MessageBox.Show("24");
                                return;
                                //  tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                        

                    }
                } // end for loop ColumnOfAI

            } // end for rowOfAI
            if (Move[2] == 1 )
            {
                if (Movement[Move[1], Move[2] + 4] == 1) // there is x 
                {
                    Move[1] = 0;
                    Move[2] = 0;
                    return;
                }
            }
            if (Move[2] == 22)
            {
                if (Movement[Move[1], Move[2] - 4] == 1) // there is x 
                {
                    Move[1] = 0;
                    Move[2] = 0;
                    return;
                }
            }

            
                Move[1] = tempRow;
                Move[2] = tempCol;


               // MessageBox.Show("after"+Move[1].ToString());
              //  MessageBox.Show("after"+Move[2].ToString());
        }

        void x3TimesAbsolte_ByCol(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempRow = 0;
            int tempCol = 0;

            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13 + 1; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove] +
                            Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == 3) // there is one move that we can win the game
                    {
                        for (int j = rowAIMove; j <= rowAIMove + 5 - 1; ++j)
                        {
                            if (Movement[j, columnAIMove] == 0)
                            {

                                Move[1] = j;
                                Move[2] = columnAIMove;
                                if (Move[1] < 17 && Move[1]-4>0)
                                {
                                    if (Movement[Move[1] + 1, Move[2]] == 1)// there is another x, we are not going to make another o
                                    {
                                        if (Movement[Move[1] - 4, Move[2]] == 0)
                                        {
                                            tempRow -= 4;
                                           // return;
                                        }


                                        tempRow = 0;
                                        tempCol= 0;
                                    }
                                }
                                if (Move[1] > 1 && Move[1]+4 <=17)
                                {
                                    if (Movement[Move[1] - 1, Move[2]] == 1)// there is another x, we are not going to make another o
                                    {
                                        if (Movement[Move[1] + 4, Move[2]] == 0)
                                        {
                                            Move[1] += 4;
                                            //return;
                                        }
                                        Move[1] = 0;
                                        Move[2] = 0;
                                    }



                                }
                                break;
                            }



                        }// end of for loop

                        tempRow = Move[1];
                        tempCol = Move[2];

                        // find another seriously marks 
                        // new update AI 22-April-2016

                        // way 1. 
                        int m = 0, n = 0;
                        bool keepDoing = true;
                        int countt = 0;
                        ////////////////////////////////////
                        for (int num = Move[1]; num > Move[1] - 5; --num)
                        {

                            if (num < 1)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {

                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                        }
                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] - 1, Move[2]] + Movement[Move[1] - 2, Move[2]] == 2) // x2
                            {
                                //  xMark += 1000;
                                //      MessageBox.Show("1");
                                return;
                                //  tempRow = Move[1];
                                //tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 2, Move[2]] + Movement[Move[1] - 3, Move[2]] == 2) // x2
                            {
                                //     xMark += 1000;
                                //    MessageBox.Show("2");
                                return;
                                // tempRow = Move[1];
                                // tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 1, Move[2]] + Movement[Move[1] - 3, Move[2]] == 2) // x2
                            {
                                //    MessageBox.Show("3");
                                return;
                                //  xMark += 1000;
                                //  tempRow = Move[1];
                                // tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 2
                        ///////////////////////////////////////////
                        keepDoing = true;
                        m = Move[1]; n = Move[2];
                        countt = 0;
                        for (n = Move[2]; n > Move[2] - 5; --n)
                        {
                            if (n < 1)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (m < 1)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {

                                countt++;
                            }

                            if (countt >= 3)
                            {

                                keepDoing = false;
                            }
                            m--;
                        } // end of for loop



                        if (keepDoing == true)
                        {
                            //  MessageBox.Show("The boy2");
                            if (Movement[Move[1] - 1, Move[2] - 1] + Movement[Move[1] - 2, Move[2] - 2] == 2) // x2
                            {
                                //  MessageBox.Show("4");
                                return;
                                //   tempRow = Move[1];
                                //  tempCol = Move[2];

                            }
                            else if (Movement[Move[1] - 1, Move[2] - 1] + Movement[Move[1] - 3, Move[2] - 3] == 2) // x2
                            {
                                //   MessageBox.Show("5");
                                return;
                                //   tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 2, Move[2] - 2] + Movement[Move[1] - 3, Move[2] - 3] == 2) // x2
                            {
                                //  MessageBox.Show("6");
                                return;
                                //   tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }

                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 3   
                        ///////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (n = Move[2]; n > Move[2] - 5; --n)
                        {
                            if (n < 1)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }

                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }


                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }

                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1], Move[2] - 1] + Movement[Move[1], Move[2] - 2] == 2) // x2
                            {
                                //    MessageBox.Show("7");
                                return;
                                //  xMark += 1000;
                                //  tempRow = Move[1];
                                // tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] - 1] + Movement[Move[1], Move[2] - 3] == 2) // x2
                            {
                                //      MessageBox.Show("8");
                                return;
                                tempRow = Move[1];
                                tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] - 2] + Movement[Move[1], Move[2] - 3] == 2) // x2
                            {
                                //   MessageBox.Show("9");
                                return;
                                //tempRow = Move[1];
                                //    tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 4
                        /////////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (n = Move[2]; n > Move[2] - 5; --n)
                        {
                            if (n < 1)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (m > 17)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                            m++;
                        } // end of for loop

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] + 1, Move[2] - 1] + Movement[Move[1] + 2, Move[2] - 2] == 2) // x2
                            {
                                //     MessageBox.Show("10");
                                return;
                                //  xMark += 1000;
                                //  tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 1, Move[2] - 1] + Movement[Move[1] + 3, Move[2] - 3] == 2) // x2
                            {
                                //    MessageBox.Show("11");
                                return;
                                //  tempRow = Move[1];
                                // tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 2, Move[2] - 2] + Movement[Move[1] + 3, Move[2] - 3] == 2) // x2
                            {
                                ////    MessageBox.Show("12");
                                return;
                                //  tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 5
                        ////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (m = Move[1]; m < Move[1] + 5; ++m)
                        {
                            if (m > 17)
                            {
                                keepDoing = false;
                                break;
                            }

                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }

                        }
                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] + 1, Move[2]] + Movement[Move[1] + 2, Move[2]] == 2) // x2
                            {
                                return;
                                //     MessageBox.Show("13");
                                //     tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 1, Move[2]] + Movement[Move[1] + 3, Move[2]] == 2) // x2
                            {
                                //    MessageBox.Show("14");
                                return;
                                //    tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 2, Move[2]] + Movement[Move[1] + 3, Move[2]] == 2) // x2
                            {
                                //    MessageBox.Show("15");
                                return;
                                //   tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                        // way 6
                        //////////////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (m = Move[1]; m < Move[1] + 5; ++m)
                        {
                            if (m > 17)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (n > 22)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                            n++;
                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] + 1, Move[2] + 1] + Movement[Move[1] + 2, Move[2] + 2] == 2) // x2
                            {
                                return;
                                //    MessageBox.Show("16");
                                //    tempRow = Move[1];
                                //     tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 1, Move[2] + 1] + Movement[Move[1] + 3, Move[2] + 3] == 2) // x2
                            {
                                return;
                                //   MessageBox.Show("17");

                                //   tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 2, Move[2] + 2] + Movement[Move[1] + 3, Move[2] + 3] == 2) // x2
                            {
                                //    MessageBox.Show("18");
                                return;
                                //   tempRow = Move[1];
                                //    tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                        // way 7
                        /////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (n = Move[2]; n < Move[2] + 5; ++n)
                        {
                            if (n > 22)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }

                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1], Move[2] + 1] + Movement[Move[1], Move[2] + 2] == 2) // x2
                            {
                                //     MessageBox.Show("19");
                                return;
                                //    tempRow = Move[1];
                                //    tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] + 1] + Movement[Move[1], Move[2] + 3] == 2) // x2
                            {
                                //       MessageBox.Show("20");
                                return;
                                //     tempRow = Move[1];
                                //    tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] + 2] + Movement[Move[1], Move[2] + 3] == 2) // x2
                            {
                                // MessageBox.Show("21");
                                return;
                                // tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                        // way 8
                        //////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (m = Move[1]; m > Move[1] - 5; --m)
                        {
                            if (m < 1)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (n > 22)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                            n++;
                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] - 1, Move[2] + 1] + Movement[Move[1] - 2, Move[2] + 2] == 2) // x2
                            {
                                return;
                                //  MessageBox.Show("22");
                                //  tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 1, Move[2] + 1] + Movement[Move[1] - 3, Move[2] + 3] == 2) // x2
                            {
                                return;
                                //     MessageBox.Show("23");

                                //   tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 2, Move[2] + 2] + Movement[Move[1] - 3, Move[2] + 3] == 2) // x2
                            {
                                //      MessageBox.Show("24");
                                return;
                                //  tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }


                    }// end of score =3
                }
            }

            if (Move[1] == 1)
            {
                if (Movement[Move[1] + 4, Move[2]] == 1) // there is x 
                {
                    Move[1] = 0;
                    Move[2] = 0;
                    return;
                }

            }

            if (Move[1] == 17)
            {
                if (Movement[Move[1] - 4, Move[2]] == 1) // there is x 
                {
                    Move[1] = 0;
                    Move[2] = 0;
                    return;
                }

            }
             Move[1] = tempRow;
             Move[2] = tempCol;
        }
        void x3TimesAbsolute_ByCross1(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempRow = 0;
            int tempCol = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18 + 1; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2] +
                             Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == 3)
                    {

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1; i++)
                        {
                            if (Movement[i, j] == 0)
                            {

                                Move[1] = i;
                                Move[2] = j;

                                /*
                                if (Move[1] < 17 && Move[2] < 22)
                                {
                                    if (Movement[Move[1] + 1, Move[2] + 1] == 1)// there is another x, we are not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                    }
                                }

                                if (Move[1] > 1 && Move[2] > 1)
                                {
                                    if (Movement[Move[1] - 1, Move[2] - 1] == 1)// there is another x, we are not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                    }
                                }
                            */




                                break;

                            }
                            j++;
                        }
                        tempRow = Move[1];
                        tempCol = Move[2];

                        // find another seriously marks 
                        // new update AI 22-April-2016

                        // way 1. 
                        int m = 0, n = 0;
                        bool keepDoing = true;
                        int countt = 0;
                        ////////////////////////////////////
                        for (int num = Move[1]; num > Move[1] - 5; --num)
                        {

                            if (num < 1)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {

                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                        }
                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] - 1, Move[2]] + Movement[Move[1] - 2, Move[2]] == 2) // x2
                            {
                                //  xMark += 1000;
                             //      MessageBox.Show("1");
                                return;
                              //  tempRow = Move[1];
                                //tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 2, Move[2]] + Movement[Move[1] - 3, Move[2]] == 2) // x2
                            {
                                //     xMark += 1000;
                               //    MessageBox.Show("2");
                                return;
                               // tempRow = Move[1];
                               // tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 1, Move[2]] + Movement[Move[1] - 3, Move[2]] == 2) // x2
                            {
                              //    MessageBox.Show("3");
                                return;
                                //  xMark += 1000;
                              //  tempRow = Move[1];
                               // tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 2
                        ///////////////////////////////////////////
                        keepDoing = true;
                        m = Move[1]; n = Move[2];
                        countt = 0;
                        for (n = Move[2]; n > Move[2] - 5; --n)
                        {
                            if (n < 1)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (m < 1)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {

                                countt++;
                            }

                            if (countt >= 3)
                            {

                                keepDoing = false;
                            }
                            m--;
                        } // end of for loop

                       

                        if (keepDoing == true)
                        {
                        //  MessageBox.Show("The boy2");
                            if (Movement[Move[1] - 1, Move[2] - 1] + Movement[Move[1] - 2, Move[2] - 2] == 2) // x2
                            {
                                //  MessageBox.Show("4");
                                  return;
                             //   tempRow = Move[1];
                              //  tempCol = Move[2];
                               
                            }
                            else if (Movement[Move[1] - 1, Move[2] - 1] + Movement[Move[1] - 3, Move[2] - 3] == 2) // x2
                            {
                                //   MessageBox.Show("5");
                                return;
                             //   tempRow = Move[1];
                             //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 2, Move[2] - 2] + Movement[Move[1] - 3, Move[2] - 3] == 2) // x2
                            {
                                 //  MessageBox.Show("6");
                                return;
                             //   tempRow = Move[1];
                              //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }

                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 3   
                        ///////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (n = Move[2]; n > Move[2] - 5; --n)
                        {
                            if (n < 1)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }

                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }


                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }

                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1], Move[2] - 1] + Movement[Move[1], Move[2] - 2] == 2) // x2
                            {
                               //    MessageBox.Show("7");
                                return;
                                //  xMark += 1000;
                              //  tempRow = Move[1];
                               // tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] - 1] + Movement[Move[1], Move[2] - 3] == 2) // x2
                            {
                          //      MessageBox.Show("8");
                                return;
                                tempRow = Move[1];
                                tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] - 2] + Movement[Move[1], Move[2] - 3] == 2) // x2
                            {
                                //   MessageBox.Show("9");
                                return;
                                //tempRow = Move[1];
                            //    tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 4
                        /////////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (n = Move[2]; n > Move[2] - 5; --n)
                        {
                            if (n < 1)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (m > 17)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                            m++;
                        } // end of for loop

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] + 1, Move[2] - 1] + Movement[Move[1] + 2, Move[2] - 2] == 2) // x2
                            {
                                //     MessageBox.Show("10");
                                return;
                                //  xMark += 1000;
                              //  tempRow = Move[1];
                             //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 1, Move[2] - 1] + Movement[Move[1] + 3, Move[2] - 3] == 2) // x2
                            {
                                //    MessageBox.Show("11");
                                return;
                              //  tempRow = Move[1];
                               // tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 2, Move[2] - 2] + Movement[Move[1] + 3, Move[2] - 3] == 2) // x2
                            {
                                   ////    MessageBox.Show("12");
                                return;
                              //  tempRow = Move[1];
                              //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 5
                        ////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (m = Move[1]; m < Move[1] + 5; ++m)
                        {
                            if (m > 17)
                            {
                                keepDoing = false;
                                break;
                            }

                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }

                        }
                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] + 1, Move[2]] + Movement[Move[1] + 2, Move[2]] == 2) // x2
                            {
                                return;
                                 //     MessageBox.Show("13");
                           //     tempRow = Move[1];
                             //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 1, Move[2]] + Movement[Move[1] + 3, Move[2]] == 2) // x2
                            {
                                //    MessageBox.Show("14");
                                return;
                            //    tempRow = Move[1];
                              //  tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 2, Move[2]] + Movement[Move[1] + 3, Move[2]] == 2) // x2
                            {
                               //    MessageBox.Show("15");
                                return; 
                             //   tempRow = Move[1];
                             //   tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                        // way 6
                        //////////////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (m = Move[1]; m < Move[1] + 5; ++m)
                        {
                            if (m > 17)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (n > 22)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                            n++;
                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] + 1, Move[2] + 1] + Movement[Move[1] + 2, Move[2] + 2] == 2) // x2
                            {
                                return;
                                //    MessageBox.Show("16");
                            //    tempRow = Move[1];
                           //     tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 1, Move[2] + 1] + Movement[Move[1] + 3, Move[2] + 3] == 2) // x2
                            {
                                return;
                                //   MessageBox.Show("17");

                             //   tempRow = Move[1];
                              //  tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 2, Move[2] + 2] + Movement[Move[1] + 3, Move[2] + 3] == 2) // x2
                            {
                               //    MessageBox.Show("18");
                                return;
                             //   tempRow = Move[1];
                            //    tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                        // way 7
                        /////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (n = Move[2]; n < Move[2] + 5; ++n)
                        {
                            if (n > 22)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }

                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1], Move[2] + 1] + Movement[Move[1], Move[2] + 2] == 2) // x2
                            {
                              //     MessageBox.Show("19");
                                return;
                            //    tempRow = Move[1];
                            //    tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] + 1] + Movement[Move[1], Move[2] + 3] == 2) // x2
                            {
                             //       MessageBox.Show("20");
                                return;
                           //     tempRow = Move[1];
                            //    tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] + 2] + Movement[Move[1], Move[2] + 3] == 2) // x2
                            {
                                 // MessageBox.Show("21");
                                return;
                               // tempRow = Move[1];
                              //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                        // way 8
                        //////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (m = Move[1]; m > Move[1] - 5; --m)
                        {
                            if (m < 1)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (n > 22)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                            n++;
                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] - 1, Move[2] + 1] + Movement[Move[1] - 2, Move[2] + 2] == 2) // x2
                            {
                                return;
                                     //  MessageBox.Show("22");
                              //  tempRow = Move[1];
                              //  tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 1, Move[2] + 1] + Movement[Move[1] - 3, Move[2] + 3] == 2) // x2
                            {
                                return;
                                 //     MessageBox.Show("23");

                             //   tempRow = Move[1];
                             //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 2, Move[2] + 2] + Movement[Move[1] - 3, Move[2] + 3] == 2) // x2
                            {
                                //      MessageBox.Show("24");
                                return;
                              //  tempRow = Move[1];
                              //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                    } 
                }

            if (Move[1] == 1)
            {
                if (Movement[Move[1] + 4, Move[2] + 4] == 1)// x
                {
                    Move[1] = 0; Move[2] = 0;
                }

            }
            Move[1] = tempRow;
            Move[2] = tempCol;

        }
         void x3TimesAbsolute_ByCross2(int[] Move)
        {

            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            int tempRow = 0;
            int tempCol = 0;

            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2] +
                            Movement[rowAIMove - 3, columnAIMove + 3];
                    //Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == 3) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;

                        int i = rowAIMove;
                        int j = columnAIMove;


                        for (i = rowAIMove; i < rowAIMove + 5; i++)
                        {
                            if (i > 17) continue;
                            if (j < 1) continue;
                             if (Movement[i, j] == 0)
                            {
                                Move[1] = i;
                                Move[2] = j;
                               // Move[1] = j;
                                //Move[2] = i;
                                /*
                                if (Move[1] > 1 && Move[2] < 22)
                                {
                                    if (Movement[Move[1] - 1, Move[2] + 1] == 1)// there is another x, we are not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                    }
                                }
                                if (Move[1] < 17 && Move[2] > 1)
                                {
                                    if (Movement[Move[1] + 1, Move[2] - 1] == 1)// there is another x, we are not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                    }
                                }
                                */
                                break;
                            }
                            j--;
                        }
                        MessageBox.Show("r=" + Move[1].ToString());
                        MessageBox.Show("c=" + Move[2].ToString()); 
                       // i = rowAIMove; j = columnAIMove;
                        tempRow = Move[1];
                        tempCol = Move[2];

                        // find another seriously marks 
                        // new update AI 22-April-2016

                        // way 1. 
                        int m = 0, n = 0;
                        bool keepDoing = true;
                        int countt = 0;
                        ////////////////////////////////////
                        for (int num = Move[1]; num > Move[1] - 5; --num)
                        {

                            if (num < 1)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {

                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                        }
                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] - 1, Move[2]] + Movement[Move[1] - 2, Move[2]] == 2) // x2
                            {
                                //  xMark += 1000;
                                //      MessageBox.Show("1");
                                return;
                                //  tempRow = Move[1];
                                //tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 2, Move[2]] + Movement[Move[1] - 3, Move[2]] == 2) // x2
                            {
                                //     xMark += 1000;
                                //    MessageBox.Show("2");
                                return;
                                // tempRow = Move[1];
                                // tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 1, Move[2]] + Movement[Move[1] - 3, Move[2]] == 2) // x2
                            {
                                //    MessageBox.Show("3");
                                return;
                                //  xMark += 1000;
                                //  tempRow = Move[1];
                                // tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 2
                        ///////////////////////////////////////////
                        keepDoing = true;
                        m = Move[1]; n = Move[2];
                        countt = 0;
                        for (n = Move[2]; n > Move[2] - 5; --n)
                        {
                            if (n < 1)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (m < 1)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {

                                countt++;
                            }

                            if (countt >= 3)
                            {

                                keepDoing = false;
                            }
                            m--;
                        } // end of for loop



                        if (keepDoing == true)
                        {
                            //  MessageBox.Show("The boy2");
                            if (Movement[Move[1] - 1, Move[2] - 1] + Movement[Move[1] - 2, Move[2] - 2] == 2) // x2
                            {
                                //  MessageBox.Show("4");
                                return;
                                //   tempRow = Move[1];
                                //  tempCol = Move[2];

                            }
                            else if (Movement[Move[1] - 1, Move[2] - 1] + Movement[Move[1] - 3, Move[2] - 3] == 2) // x2
                            {
                                //   MessageBox.Show("5");
                                return;
                                //   tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 2, Move[2] - 2] + Movement[Move[1] - 3, Move[2] - 3] == 2) // x2
                            {
                                //  MessageBox.Show("6");
                                return;
                                //   tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }

                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 3   
                        ///////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (n = Move[2]; n > Move[2] - 5; --n)
                        {
                            if (n < 1)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }

                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }


                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }

                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1], Move[2] - 1] + Movement[Move[1], Move[2] - 2] == 2) // x2
                            {
                                //    MessageBox.Show("7");
                                return;
                                //  xMark += 1000;
                                //  tempRow = Move[1];
                                // tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] - 1] + Movement[Move[1], Move[2] - 3] == 2) // x2
                            {
                                //      MessageBox.Show("8");
                                return;
                               // tempRow = Move[1];
                                //tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] - 2] + Movement[Move[1], Move[2] - 3] == 2) // x2
                            {
                                //   MessageBox.Show("9");
                                return;
                                //tempRow = Move[1];
                                //    tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 4
                        /////////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (n = Move[2]; n > Move[2] - 5; --n)
                        {
                            if (n < 1)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (m > 17)
                            {
                                keepDoing = false;
                                break;

                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                            m++;
                        } // end of for loop

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] + 1, Move[2] - 1] + Movement[Move[1] + 2, Move[2] - 2] == 2) // x2
                            {
                                //     MessageBox.Show("10");
                                return;
                                //  xMark += 1000;
                                //  tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 1, Move[2] - 1] + Movement[Move[1] + 3, Move[2] - 3] == 2) // x2
                            {
                                //    MessageBox.Show("11");
                                return;
                                //  tempRow = Move[1];
                                // tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 2, Move[2] - 2] + Movement[Move[1] + 3, Move[2] - 3] == 2) // x2
                            {
                                ////    MessageBox.Show("12");
                                return;
                                //  tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }
                        // way 5
                        ////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (m = Move[1]; m < Move[1] + 5; ++m)
                        {
                            if (m > 17)
                            {
                                keepDoing = false;
                                break;
                            }

                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }

                        }
                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] + 1, Move[2]] + Movement[Move[1] + 2, Move[2]] == 2) // x2
                            {
                                return;
                                //     MessageBox.Show("13");
                                //     tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 1, Move[2]] + Movement[Move[1] + 3, Move[2]] == 2) // x2
                            {
                                //    MessageBox.Show("14");
                                return;
                                //    tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 2, Move[2]] + Movement[Move[1] + 3, Move[2]] == 2) // x2
                            {
                                //    MessageBox.Show("15");
                                return;
                                //   tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                        // way 6
                        //////////////////////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (m = Move[1]; m < Move[1] + 5; ++m)
                        {
                            if (m > 17)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (n > 22)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                            n++;
                        }

                        if (keepDoing == true)
                        {
                          //  MessageBox.Show("Justin Jak");
                       //     MessageBox.Show(Move[1].ToString());
                        //    MessageBox.Show(Move[2].ToString());
                            if (Movement[Move[1] + 1, Move[2] + 1] + Movement[Move[1] + 2, Move[2] + 2] == 2) // x2
                            {
                               
                                   // MessageBox.Show("16");
                                return;
                                //    tempRow = Move[1];
                                //     tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 1, Move[2] + 1] + Movement[Move[1] + 3, Move[2] + 3] == 2) // x2
                            {
                                 //  MessageBox.Show("17");
                                return;
                                //   tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else if (Movement[Move[1] + 2, Move[2] + 2] + Movement[Move[1] + 3, Move[2] + 3] == 2) // x2
                            {
                                   // MessageBox.Show("18");
                                return;
                                //   tempRow = Move[1];
                                //    tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                        // way 7
                        /////////////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (n = Move[2]; n < Move[2] + 5; ++n)
                        {
                            if (n > 22)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }

                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1], Move[2] + 1] + Movement[Move[1], Move[2] + 2] == 2) // x2
                            {
                                //     MessageBox.Show("19");
                                return;
                                //    tempRow = Move[1];
                                //    tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] + 1] + Movement[Move[1], Move[2] + 3] == 2) // x2
                            {
                                //       MessageBox.Show("20");
                                return;
                                //     tempRow = Move[1];
                                //    tempCol = Move[2];
                            }
                            else if (Movement[Move[1], Move[2] + 2] + Movement[Move[1], Move[2] + 3] == 2) // x2
                            {
                                // MessageBox.Show("21");
                                return;
                                // tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }

                        // way 8
                        //////////////////////////
                        m = Move[1]; n = Move[2];
                        keepDoing = true;
                        countt = 0;
                        for (m = Move[1]; m > Move[1] - 5; --m)
                        {
                            if (m < 1)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (n > 22)
                            {
                                keepDoing = false;
                                break;
                            }
                            if (Movement[m, n] == -1)
                            {
                                keepDoing = false;
                                break;
                            }
                            else if (Movement[m, n] == 1)
                            {
                                countt++;
                            }
                            if (countt >= 3)
                            {
                                keepDoing = false;
                            }
                            n++;
                        }

                        if (keepDoing == true)
                        {
                            if (Movement[Move[1] - 1, Move[2] + 1] + Movement[Move[1] - 2, Move[2] + 2] == 2) // x2
                            {
                                return;
                                //  MessageBox.Show("22");
                                //  tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 1, Move[2] + 1] + Movement[Move[1] - 3, Move[2] + 3] == 2) // x2
                            {
                                return;
                                //     MessageBox.Show("23");

                                //   tempRow = Move[1];
                                //   tempCol = Move[2];
                            }
                            else if (Movement[Move[1] - 2, Move[2] + 2] + Movement[Move[1] - 3, Move[2] + 3] == 2) // x2
                            {
                                //      MessageBox.Show("24");
                                return;
                                //  tempRow = Move[1];
                                //  tempCol = Move[2];
                            }
                            else
                            {
                                tempRow = 0;
                                tempCol = 0;
                            }
                        }
                        else if (keepDoing == false)
                        {
                            tempRow = 0;
                            tempCol = 0;
                        }


                    }
                }
/*

            if (Move[1] == 1 || Move[2] == 1)
            {
                if ((Move[1] + 4 <= 17) && (Move[1] + 4 <= 22))
                {
                    if (Movement[Move[1] + 4, Move[2] + 4] == 0)
                    {
                        Move[1] += 4;
                        Move[2] += 4;
                        return;
                    }
                }


                Move[1] = 0;
                Move[2] = 0;
                return;
            }
             */
            Move[1] = tempRow;
            Move[2] = tempCol;
        }

         void x3TimesAbsolutely_byC2(int[] Move)
         {
             int rowAIMove = 17;
             int columnAIMove = 22;
             int score = 0;
             int tempRow = 0, tempCol = 0;
             // MessageBox.Show("Hello girl");
             for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                 for (columnAIMove = 1; columnAIMove <= 18 + 1; ++columnAIMove)
                 {
                     score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove - 1, columnAIMove + 1] +
                             Movement[rowAIMove - 2, columnAIMove + 2] +
                             Movement[rowAIMove - 3, columnAIMove + 3];
                     //  Movement[rowAIMove - 4, columnAIMove + 4];


                     if (score == 3) // there is one move that we can win the game
                     {
                         // MessageBox.Show("bingo");


                         int bestMove_row = rowAIMove;
                         int i = rowAIMove;
                         int j = columnAIMove;

                         for (j = columnAIMove; j <= columnAIMove + 5 - 1; j++)
                         {
                             if (Movement[i, j] == 0)
                             {
                                 // we made it. Yeah.

                                 Move[1] = i;
                                 Move[2] = j;
                                 break;
                                // MessageBox.Show(Move[1].ToString());
                              //   MessageBox.Show(Move[2].ToString());
                             }
                             i--;
                         }


                         tempRow = Move[1];
                         tempCol = Move[2];

                         // find another seriously marks 
                         // new update AI 22-April-2016

                         // way 1. 
                         int m = 0, n = 0;
                         bool keepDoing = true;
                         int countt = 0;
                         ////////////////////////////////////
                         for (int num = Move[1]; num > Move[1] - 5; --num)
                         {

                             if (num < 1)
                             {
                                 keepDoing = false;
                                 break;
                             }
                             if (Movement[m, n] == -1)
                             {
                                 keepDoing = false;
                                 break;
                             }
                             else if (Movement[m, n] == 1)
                             {

                                 countt++;
                             }
                             if (countt >= 3)
                             {
                                 keepDoing = false;
                             }
                         }
                         if (keepDoing == true)
                         {
                             if (Movement[Move[1] - 1, Move[2]] + Movement[Move[1] - 2, Move[2]] == 2) // x2
                             {
                                 //  xMark += 1000;
                                 //      MessageBox.Show("1");
                                 return;
                                 //  tempRow = Move[1];
                                 //tempCol = Move[2];
                             }
                             else if (Movement[Move[1] - 2, Move[2]] + Movement[Move[1] - 3, Move[2]] == 2) // x2
                             {
                                 //     xMark += 1000;
                                 //    MessageBox.Show("2");
                                 return;
                                 // tempRow = Move[1];
                                 // tempCol = Move[2];
                             }
                             else if (Movement[Move[1] - 1, Move[2]] + Movement[Move[1] - 3, Move[2]] == 2) // x2
                             {
                                 //    MessageBox.Show("3");
                                 return;
                                 //  xMark += 1000;
                                 //  tempRow = Move[1];
                                 // tempCol = Move[2];
                             }
                             else
                             {
                                 tempRow = 0;
                                 tempCol = 0;
                             }
                         }
                         else if (keepDoing == false)
                         {
                             tempRow = 0;
                             tempCol = 0;
                         }
                         // way 2
                         ///////////////////////////////////////////
                         keepDoing = true;
                         m = Move[1]; n = Move[2];
                         countt = 0;
                         for (n = Move[2]; n > Move[2] - 5; --n)
                         {
                             if (n < 1)
                             {
                                 keepDoing = false;
                                 break;

                             }
                             if (m < 1)
                             {
                                 keepDoing = false;
                                 break;

                             }
                             if (Movement[m, n] == -1)
                             {
                                 keepDoing = false;
                                 break;
                             }
                             else if (Movement[m, n] == 1)
                             {

                                 countt++;
                             }

                             if (countt >= 3)
                             {

                                 keepDoing = false;
                             }
                             m--;
                         } // end of for loop



                         if (keepDoing == true)
                         {
                             //  MessageBox.Show("The boy2");
                             if (Movement[Move[1] - 1, Move[2] - 1] + Movement[Move[1] - 2, Move[2] - 2] == 2) // x2
                             {
                                 //  MessageBox.Show("4");
                                 return;
                                 //   tempRow = Move[1];
                                 //  tempCol = Move[2];

                             }
                             else if (Movement[Move[1] - 1, Move[2] - 1] + Movement[Move[1] - 3, Move[2] - 3] == 2) // x2
                             {
                                 //   MessageBox.Show("5");
                                 return;
                                 //   tempRow = Move[1];
                                 //   tempCol = Move[2];
                             }
                             else if (Movement[Move[1] - 2, Move[2] - 2] + Movement[Move[1] - 3, Move[2] - 3] == 2) // x2
                             {
                                 //  MessageBox.Show("6");
                                 return;
                                 //   tempRow = Move[1];
                                 //  tempCol = Move[2];
                             }
                             else
                             {
                                 tempRow = 0;
                                 tempCol = 0;
                             }

                         }
                         else if (keepDoing == false)
                         {
                             tempRow = 0;
                             tempCol = 0;
                         }
                         // way 3   
                         ///////////////////////////////////////////
                         m = Move[1]; n = Move[2];
                         keepDoing = true;
                         countt = 0;
                         for (n = Move[2]; n > Move[2] - 5; --n)
                         {
                             if (n < 1)
                             {
                                 keepDoing = false;
                                 break;
                             }
                             if (Movement[m, n] == -1)
                             {
                                 keepDoing = false;
                                 break;
                             }

                             else if (Movement[m, n] == 1)
                             {
                                 countt++;
                             }


                             if (countt >= 3)
                             {
                                 keepDoing = false;
                             }

                         }

                         if (keepDoing == true)
                         {
                             if (Movement[Move[1], Move[2] - 1] + Movement[Move[1], Move[2] - 2] == 2) // x2
                             {
                                 //    MessageBox.Show("7");
                                 return;
                                 //  xMark += 1000;
                                 //  tempRow = Move[1];
                                 // tempCol = Move[2];
                             }
                             else if (Movement[Move[1], Move[2] - 1] + Movement[Move[1], Move[2] - 3] == 2) // x2
                             {
                                 //      MessageBox.Show("8");
                                 return;
                                 tempRow = Move[1];
                                 tempCol = Move[2];
                             }
                             else if (Movement[Move[1], Move[2] - 2] + Movement[Move[1], Move[2] - 3] == 2) // x2
                             {
                                 //   MessageBox.Show("9");
                                 return;
                                 //tempRow = Move[1];
                                 //    tempCol = Move[2];
                             }
                             else
                             {
                                 tempRow = 0;
                                 tempCol = 0;
                             }
                         }
                         else if (keepDoing == false)
                         {
                             tempRow = 0;
                             tempCol = 0;
                         }
                         // way 4
                         /////////////////////////////////////////////
                         m = Move[1]; n = Move[2];
                         keepDoing = true;
                         countt = 0;
                         for (n = Move[2]; n > Move[2] - 5; --n)
                         {
                             if (n < 1)
                             {
                                 keepDoing = false;
                                 break;

                             }
                             if (m > 17)
                             {
                                 keepDoing = false;
                                 break;

                             }
                             if (Movement[m, n] == -1)
                             {
                                 keepDoing = false;
                                 break;
                             }
                             else if (Movement[m, n] == 1)
                             {
                                 countt++;
                             }
                             if (countt >= 3)
                             {
                                 keepDoing = false;
                             }
                             m++;
                         } // end of for loop

                         if (keepDoing == true)
                         {
                             if (Movement[Move[1] + 1, Move[2] - 1] + Movement[Move[1] + 2, Move[2] - 2] == 2) // x2
                             {
                                 //     MessageBox.Show("10");
                                 return;
                                 //  xMark += 1000;
                                 //  tempRow = Move[1];
                                 //   tempCol = Move[2];
                             }
                             else if (Movement[Move[1] + 1, Move[2] - 1] + Movement[Move[1] + 3, Move[2] - 3] == 2) // x2
                             {
                                 //    MessageBox.Show("11");
                                 return;
                                 //  tempRow = Move[1];
                                 // tempCol = Move[2];
                             }
                             else if (Movement[Move[1] + 2, Move[2] - 2] + Movement[Move[1] + 3, Move[2] - 3] == 2) // x2
                             {
                                 ////    MessageBox.Show("12");
                                 return;
                                 //  tempRow = Move[1];
                                 //  tempCol = Move[2];
                             }
                             else
                             {
                                 tempRow = 0;
                                 tempCol = 0;
                             }
                         }
                         else if (keepDoing == false)
                         {
                             tempRow = 0;
                             tempCol = 0;
                         }
                         // way 5
                         ////////////////////////////////////////
                         m = Move[1]; n = Move[2];
                         keepDoing = true;
                         countt = 0;
                         for (m = Move[1]; m < Move[1] + 5; ++m)
                         {
                             if (m > 17)
                             {
                                 keepDoing = false;
                                 break;
                             }

                             if (Movement[m, n] == -1)
                             {
                                 keepDoing = false;
                                 break;
                             }
                             else if (Movement[m, n] == 1)
                             {
                                 countt++;
                             }
                             if (countt >= 3)
                             {
                                 keepDoing = false;
                             }

                         }
                         if (keepDoing == true)
                         {
                             if (Movement[Move[1] + 1, Move[2]] + Movement[Move[1] + 2, Move[2]] == 2) // x2
                             {
                                 return;
                                 //     MessageBox.Show("13");
                                 //     tempRow = Move[1];
                                 //   tempCol = Move[2];
                             }
                             else if (Movement[Move[1] + 1, Move[2]] + Movement[Move[1] + 3, Move[2]] == 2) // x2
                             {
                                 //    MessageBox.Show("14");
                                 return;
                                 //    tempRow = Move[1];
                                 //  tempCol = Move[2];
                             }
                             else if (Movement[Move[1] + 2, Move[2]] + Movement[Move[1] + 3, Move[2]] == 2) // x2
                             {
                                 //    MessageBox.Show("15");
                                 return;
                                 //   tempRow = Move[1];
                                 //   tempCol = Move[2];
                             }
                             else
                             {
                                 tempRow = 0;
                                 tempCol = 0;
                             }
                         }
                         else if (keepDoing == false)
                         {
                             tempRow = 0;
                             tempCol = 0;
                         }

                         // way 6
                         //////////////////////////////////////////////////
                         m = Move[1]; n = Move[2];
                         keepDoing = true;
                         countt = 0;
                         for (m = Move[1]; m < Move[1] + 5; ++m)
                         {
                             if (m > 17)
                             {
                                 keepDoing = false;
                                 break;
                             }
                             if (n > 22)
                             {
                                 keepDoing = false;
                                 break;
                             }
                             if (Movement[m, n] == -1)
                             {
                                 keepDoing = false;
                                 break;
                             }
                             else if (Movement[m, n] == 1)
                             {
                                 countt++;
                             }
                             if (countt >= 3)
                             {
                                 keepDoing = false;
                             }
                             n++;
                         }

                         if (keepDoing == true)
                         {
                             if (Movement[Move[1] + 1, Move[2] + 1] + Movement[Move[1] + 2, Move[2] + 2] == 2) // x2
                             {
                                 return;
                                 //    MessageBox.Show("16");
                                 //    tempRow = Move[1];
                                 //     tempCol = Move[2];
                             }
                             else if (Movement[Move[1] + 1, Move[2] + 1] + Movement[Move[1] + 3, Move[2] + 3] == 2) // x2
                             {
                                 return;
                                 //   MessageBox.Show("17");

                                 //   tempRow = Move[1];
                                 //  tempCol = Move[2];
                             }
                             else if (Movement[Move[1] + 2, Move[2] + 2] + Movement[Move[1] + 3, Move[2] + 3] == 2) // x2
                             {
                                 //    MessageBox.Show("18");
                                 return;
                                 //   tempRow = Move[1];
                                 //    tempCol = Move[2];
                             }
                             else
                             {
                                 tempRow = 0;
                                 tempCol = 0;
                             }
                         }
                         else if (keepDoing == false)
                         {
                             tempRow = 0;
                             tempCol = 0;
                         }

                         // way 7
                         /////////////////////////////////
                         m = Move[1]; n = Move[2];
                         keepDoing = true;
                         countt = 0;
                         for (n = Move[2]; n < Move[2] + 5; ++n)
                         {
                             if (n > 22)
                             {
                                 keepDoing = false;
                                 break;
                             }
                             if (Movement[m, n] == -1)
                             {
                                 keepDoing = false;
                                 break;
                             }

                             else if (Movement[m, n] == 1)
                             {
                                 countt++;
                             }
                             if (countt >= 3)
                             {
                                 keepDoing = false;
                             }
                         }

                         if (keepDoing == true)
                         {
                             if (Movement[Move[1], Move[2] + 1] + Movement[Move[1], Move[2] + 2] == 2) // x2
                             {
                                 //     MessageBox.Show("19");
                                 return;
                                 //    tempRow = Move[1];
                                 //    tempCol = Move[2];
                             }
                             else if (Movement[Move[1], Move[2] + 1] + Movement[Move[1], Move[2] + 3] == 2) // x2
                             {
                                 //       MessageBox.Show("20");
                                 return;
                                 //     tempRow = Move[1];
                                 //    tempCol = Move[2];
                             }
                             else if (Movement[Move[1], Move[2] + 2] + Movement[Move[1], Move[2] + 3] == 2) // x2
                             {
                                 // MessageBox.Show("21");
                                 return;
                                 // tempRow = Move[1];
                                 //  tempCol = Move[2];
                             }
                             else
                             {
                                 tempRow = 0;
                                 tempCol = 0;
                             }
                         }
                         else if (keepDoing == false)
                         {
                             tempRow = 0;
                             tempCol = 0;
                         }

                         // way 8
                         //////////////////////////
                         m = Move[1]; n = Move[2];
                         keepDoing = true;
                         countt = 0;
                         for (m = Move[1]; m > Move[1] - 5; --m)
                         {
                             if (m < 1)
                             {
                                 keepDoing = false;
                                 break;
                             }
                             if (n > 22)
                             {
                                 keepDoing = false;
                                 break;
                             }
                             if (Movement[m, n] == -1)
                             {
                                 keepDoing = false;
                                 break;
                             }
                             else if (Movement[m, n] == 1)
                             {
                                 countt++;
                             }
                             if (countt >= 3)
                             {
                                 keepDoing = false;
                             }
                             n++;
                         }

                         if (keepDoing == true)
                         {
                             if (Movement[Move[1] - 1, Move[2] + 1] + Movement[Move[1] - 2, Move[2] + 2] == 2) // x2
                             {
                                 return;
                                 //  MessageBox.Show("22");
                                 //  tempRow = Move[1];
                                 //  tempCol = Move[2];
                             }
                             else if (Movement[Move[1] - 1, Move[2] + 1] + Movement[Move[1] - 3, Move[2] + 3] == 2) // x2
                             {
                                 return;
                                 //     MessageBox.Show("23");

                                 //   tempRow = Move[1];
                                 //   tempCol = Move[2];
                             }
                             else if (Movement[Move[1] - 2, Move[2] + 2] + Movement[Move[1] - 3, Move[2] + 3] == 2) // x2
                             {
                                 //      MessageBox.Show("24");
                                 return;
                                 //  tempRow = Move[1];
                                 //  tempCol = Move[2];
                             }
                             else
                             {
                                 tempRow = 0;
                                 tempCol = 0;
                             }
                         }
                         else if (keepDoing == false)
                         {
                             tempRow = 0;
                             tempCol = 0;
                         }

                        

                     }
                 }


             Move[1] = tempRow;
             Move[2] = tempCol;

         }
        // x3 sequen e
         double x3Times_ByRowLevel5(int[] Move)
        {
            int tempRow = 0;
            int tempCol = 0;
            double tempMark = 0;
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 2; columnAIMove <= 18; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2] +
                                Movement[rowAIMove, columnAIMove + 3];
                    //Movement[rowAIMove, columnAIMove + 4];
                    if (score == 3)
                    {
                        Move[1] = rowAIMove;
                        Move[2] = columnAIMove;
                        for (int i = columnAIMove; i < columnAIMove + 5 - 1; ++i)
                        {
                            if (Movement[rowAIMove, i] == 0)
                            {
                                Move[1] = rowAIMove;
                                Move[2] = i;
                                break;
                            }
                        }
                        double xMark = 0;
                        for (int z = Move[2]; z <= Move[2] + 4; z++)
                        {
                            //  if (z > Move[2]) x++;
                            if (z > 22)
                            {
                                continue;
                            }
                            if (Movement[Move[1], z] == 1)
                            {
                                //xMark += 3;
                                xMark += 9;
                            }
                            else if (Movement[Move[1], z] == -1)
                            {
                                //    MessageBox.Show("Hello");
                              //  xMark -= 6;
                                xMark -= 24;
                                break;
                            }
                        }

                        for (int z = Move[2]; z > Move[2] - 5; --z)
                        {
                            if (z < 1)
                            {
                                continue;
                            }
                            if (Movement[Move[1], z] == 1)
                            {
                                xMark += 9;
                            }
                            else if (Movement[Move[1], z] == -1)
                            {
                                xMark -= 24; break;
                            }
                        }
                      
                        ////////////////////////
                        if (tempMark < xMark)
                        {
                            tempRow = Move[1];
                            tempCol = Move[2];
                            tempMark = xMark;
                        }

                    }//end of if-statement score==3
                } // end for loop ColumnOfAI
            } // end for rowOfAI

            Move[1] = tempRow;
            Move[2] = tempCol;
            return tempMark;
        }
         double x3Times_ByColumn_Level5(int[] Move)
         {
             int tempRow = 0; int tempCol = 0;
             double tempMark = 0;
             int rowAIMove = 1;
             int columnAIMove = 1;
             int score = 0;
             for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
             {
                 for (rowAIMove = 2; rowAIMove <= 13; ++rowAIMove)
                 {
                     score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove] +
                             Movement[rowAIMove + 2, columnAIMove] +
                             Movement[rowAIMove + 3, columnAIMove];
                     //  Movement[rowAIMove + 4, columnAIMove];
                     if (score == 3) // there is one move that we can win the game
                     {
                         double xMark = 0;
                         if (rowAIMove == 14)
                         {
                             if (Movement[13, columnAIMove] == 0)
                             {
                                 Move[1] = 13;
                                 Move[2] = columnAIMove;
                                 tempRow = Move[1];
                                 tempCol = Move[2];
                                 tempMark = 2;
                             }
                         }
                         else if (rowAIMove == 13)
                         {
                             if (Movement[13, columnAIMove] == 0)
                             {
                                 Move[1] = 13;
                                 Move[2] = columnAIMove;
                                 tempRow = Move[1];
                                 tempCol = Move[2];
                                 tempMark = 2;
                             }
                             else if (Movement[12, columnAIMove] == 0)
                             {
                                 Move[1] = 12;
                                 Move[2] = columnAIMove;
                                 tempRow = Move[1];
                                 tempCol = Move[2];
                                 tempMark = 2;
                             }
                         }
                         else if (rowAIMove == 2)
                         {
                             if (Movement[5, columnAIMove] == 0)
                             {
                                 Move[1] = 5;
                                 Move[2] = columnAIMove;
                                 tempRow = Move[1];
                                 tempCol = Move[2];
                                 tempMark = 2;
                             }
                         }
                         else
                         {
                             for (int j = rowAIMove; j <= rowAIMove + 5 - 1; ++j)
                             {
                                 if (j > 17) continue;
                                 if (Movement[j, columnAIMove] == 0)
                                 {
                                     Move[1] = j;
                                     Move[2] = columnAIMove;
                                     break;
                                 }
                             }
                             //--------
                         }

                         for (int z = Move[1]; z > Move[1] - 4 - 1; --z) // down row
                         {
                             if (z < 1) continue;
                             if (Movement[z, Move[2]] == 1)
                             {
                                 xMark += 9;
                             }
                             else if (Movement[z, Move[2]] == -1)
                             {
                                 xMark -= 24;
                                 break;
                             }
                         }
                         for (int z = Move[1]; z <= Move[1] + 4 + 1; z++) // up row
                         {
                             if (z > 17) continue;
                             if (Movement[z, Move[2]] == 1)
                             {
                                 xMark += 9;
                             }
                             else if (Movement[z, Move[2]] == -1)
                             {
                                 xMark -= 24; break;
                             }
                         }

                         if (tempMark < xMark)
                         {
                             tempRow = Move[1];
                             tempCol = Move[2];
                             tempMark = xMark;
                         }

                     }//end of if statements: score==3
                 }
             }
             Move[1] = tempRow;
             Move[2] = tempCol;
             return tempMark;
         }
         double x3Times_ByCross1_ColumnAndRowIncrease_Level5(int[] Move)
         {
             int tempRow = 0;
             int tempCol = 0;
             double tempMark = 0;
             int rowAIMove = 1;
             int columnAIMove = 1;
             int score = 0;
             for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                 for (columnAIMove = 1 + 1; columnAIMove <= 18; columnAIMove++)
                 {
                     score = Movement[rowAIMove, columnAIMove] +
                              Movement[rowAIMove + 1, columnAIMove + 1] +
                              Movement[rowAIMove + 2, columnAIMove + 2] +
                              Movement[rowAIMove + 3, columnAIMove + 3];
                     // Movement[rowAIMove + 4, columnAIMove + 4];
                     if (score == 3)
                     {
                         if (rowAIMove == 12 && columnAIMove == 17)
                         {
                             if (Movement[11, 16] == 0)
                             {
                                 tempRow = 11;
                                 tempCol = 16;

                                 Move[1] = 11;
                                 Move[2] = 16;
                                 tempMark = 2;
                             }

                         }
                         else if (rowAIMove == 1 && columnAIMove == 18)// it is next to the wall
                         {
                             tempRow = 0;
                             tempCol = 0;

                             Move[1] = 0;
                             Move[2] = 0;
                             tempMark = 0;
                         }
                         else
                         {

                             int i = rowAIMove;
                             int j = columnAIMove;
                             for (i = rowAIMove; i <= rowAIMove + 5 - 1; i++)
                             {
                                 if (i > 17) continue;
                                 if (j > 22) continue;
                                 if (Movement[i, j] == 0)
                                 {
                                     Move[1] = i;
                                     Move[2] = j;
                                     break;
                                 }
                                 j++;
                             }

                             double xCross1 = 0;
                             int c = Move[2];
                             int r = Move[1];
                             for (r = Move[1]; r < Move[1] + 5; ++r)
                             {
                                 if (r > 17) continue;
                                 if (c > 22) continue;

                                 if (Movement[r, c] == 1)
                                 {
                                     xCross1 += 9;
                                 }
                                 else if (Movement[r, c] == -1)
                                 {
                                     xCross1 -= 24; break;
                                 }
                                 c++;
                             }

                             c = Move[2];
                             for (r = Move[1]; r > Move[1] - 5; --r)
                             {
                                 if (r < 1) continue;
                                 if (c < 1) continue;

                                 if (Movement[r, c] == 1)
                                 {
                                     xCross1 += 9;
                                 }
                                 else if (Movement[r, c] == -1)
                                 {
                                     xCross1 -= 24; break;
                                 }

                                 c--;
                             }

                             if (tempMark < xCross1)
                             {
                                 tempRow = Move[1];
                                 tempCol = Move[2];
                                 tempMark = xCross1;
                             }

                         }// end of else
                     } // end of if condition: score ==3

                 } // end of two main for-loops
             Move[1] = tempRow;
             Move[2] = tempCol;
             return tempMark;
         }

         double x3Times_ByCross2_ColumnAndRowDecrease_Level5(int[] Move)
         {
             int tempRow = 0;
             int tempCol = 0;
             double tempMark = 0;
             int rowAIMove = 1;
             int columnAIMove = 1;
             int score = 0;

             for (rowAIMove = 17; rowAIMove > 3; --rowAIMove)
                 for (columnAIMove = 1; columnAIMove <= 18 + 1; ++columnAIMove)
                 {
                     score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove - 1, columnAIMove + 1] +
                             Movement[rowAIMove - 2, columnAIMove + 2] +
                             Movement[rowAIMove - 3, columnAIMove + 3];
                     //  Movement[rowAIMove - 4, columnAIMove + 4];
                     if (score == 3) // there is one move that we can win the game
                     {
                         int bestMove_row = rowAIMove;
                         int i = rowAIMove;
                         int j = columnAIMove;
                         if (rowAIMove == 17 && columnAIMove == 1)
                         {
                             tempRow = 0;
                             tempCol = 0;
                             tempMark = 0;
                         }
                         else
                         {
                             for (j = columnAIMove; j <= columnAIMove + 5 - 1; j++)
                             {
                                 if (Movement[i, j] == 0)
                                 {
                                     // we made it. Yeah.

                                     Move[1] = i;
                                     Move[2] = j;
                                     break;
                                 }
                                 i--;
                             }
                             double xCross2 = 0;
                             int c = Move[2];
                             int r = Move[1];

                             for (r = Move[1]; r > Move[1] - 5; --r)// up
                             {
                                 if (r < 1)
                                 {
                                     // xCross2--;
                                     continue;
                                 }
                                 if (c > 22)
                                 {
                                     //  xCross2--;
                                     continue;
                                 }

                                 if (Movement[r, c] == 1)
                                 {
                                     xCross2 += 9;
                                 }
                                 else if (Movement[r, c] == -1)
                                 {
                                     xCross2 -= 24; break;
                                 }
                                 c++;
                             }

                             c = Move[2];
                             for (r = Move[1]; r < Move[1] + 5; ++r)// down
                             {
                                 if (r > 17)
                                 {
                                     // xCross2--;
                                     continue;
                                 }
                                 if (c < 1)
                                 {
                                     //   xCross2--;
                                     continue;
                                 }
                                 if (Movement[r, c] == 1)
                                 {
                                     xCross2 += 9;
                                 }
                                 else if (Movement[r, c] == -1)
                                 {
                                     xCross2 -= 24; break;
                                 }

                                 c--;
                             }
                             if (tempMark < xCross2)
                             {
                                 tempRow = Move[1];
                                 tempCol = Move[2];
                                 tempMark = xCross2;
                             }
                         }//end of else
                     } // end of if statement: score==3;
                 }// end of the two main for-loops
             Move[1] = tempRow;
             Move[2] = tempCol;
             return tempMark;
         }

        
        // o2 sequence
        double o2Times_ByRow_Level5(int[] Move)
        {

            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempMark = 0;
            int tempRow = 0;
            int tempCol = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2];
                    // Movement[rowAIMove, columnAIMove + 3];
                    //  Movement[rowAIMove, columnAIMove + 4];

                    if (score == -2)
                    {

                        int bestMove_Column = columnAIMove;

                        for (int i = columnAIMove; i <= columnAIMove + 5 - 1 - 1; ++i)
                        {
                            if (i > 17) continue;
                            if (Movement[rowAIMove, i] == 0)
                            {

                                Move[1] = rowAIMove;
                                Move[2] = i;

                                if (Move[2] < 22)
                                {
                                    if (Movement[Move[1], Move[2] + 1] == 1)// there is another x,  not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        // return ;
                                    }
                                }
                                if (Move[2] > 1)
                                {

                                    if (Movement[Move[1], Move[2] - 1] == 1)// there is another x, not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        // return ;
                                    }

                                }

                                break;
                            }
                            //---------
                        }

                        /******** loop for row **************/
                        int c1 = Move[2];
                        int oMark = 0;
                        int counter = 0;
                        int xSequence = 0;
                        for (c1 = Move[2]; c1 <= Move[2] + 4 + 1; c1++)
                        {
                            if (c1 > 22) continue;
                            if (Movement[Move[1], c1] == 1) // it is o
                            {
                                //  xMark -= 3;// 1; 
                                oMark -= counter;
                                break;
                            }
                            else if (Movement[Move[1], c1] == -1) // it is x
                            {
                                oMark += 2; // add  2
                                counter += 2;
                                xSequence++;
                            }
                        }// end of for loop c

                        counter = 0;
                        c1 = Move[2];
                        for (c1 = Move[2]; c1 >= Move[2] - 4 - 1; c1--)
                        {
                            if (c1 < 1) continue;
                            if (Movement[Move[1], c1] == 1) // it is o
                            {
                                // xMark -= 3;// 1; //  minus 3 to the mark
                                oMark -= counter;
                                break;

                            }
                            else if (Movement[Move[1], c1] == -1) // it is x
                            {
                                oMark += 2; //add 2
                                counter += 2;
                                xSequence++;
                            }
                        }//end of for loop c
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }

                        /*****loop mark for column*******/
                        xSequence = 0;
                        counter = 0;
                        int r2 = Move[1];
                        for (r2 = Move[1]; r2 <= Move[1] + 4 + 1; r2++)
                        {
                            if (r2 > 17) continue;
                            if (Movement[r2, Move[2]] == 1) // it is o
                            {
                                // xMark -= 3;// 1; // minus 1
                                oMark -= counter;
                                break;
                            }
                            else if (Movement[r2, Move[2]] == -1) // it is x 
                            {
                                oMark += 2; // add 2;
                                counter += 2;
                                xSequence++;
                            }
                        }
                        counter = 0;
                        r2 = Move[1];
                        for (r2 = Move[1]; r2 >= Move[1] - 4 - 1; r2--)
                        {
                            if (r2 < 1) continue;
                            if (Movement[r2, Move[2]] == 1) // it is o
                            {
                                oMark -= counter;// 1; // minus1
                                break;
                            }
                            else if (Movement[r2, Move[2]] == -1) // it is x 
                            {
                                oMark += 2; // add 2;
                                counter += 2;
                                xSequence++;
                            }
                        }
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        /***** loop for cross 1***********/
                        xSequence = 0;
                        counter = 0;
                        int r3 = Move[1];
                        int c3 = Move[2];
                        for (r3 = Move[1]; r3 <= Move[1] + 4 + 1; ++r3)
                        {
                            if (r3 > 17) continue;
                            if (c3 > 22) continue;
                            if (Movement[r3, c3] == 1) // it is o
                            {
                                oMark -= counter;// 1;
                                break;

                            }
                            else if (Movement[r3, c3] == -1) // it is x
                            {
                                oMark += 2;
                                counter += 2;
                                xSequence++;
                            }

                            c3++;
                        }

                        counter = 0;
                        r3 = Move[1];
                        c3 = Move[2];
                        for (r3 = Move[1]; r3 >= Move[1] - 4 - 1; r3--)
                        {
                            if (r3 < 1) continue;
                            if (c3 < 1) continue;

                            if (Movement[r3, c3] == 1) // it is o
                            {
                                oMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r3, c3] == -1) // it is x
                            {
                                oMark += 2;
                                counter += 2;
                                xSequence++;
                            }
                            c3--;
                        }
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }

                        /*********** loop for cross 2 **********************/
                        xSequence = 0;
                        counter = 0;
                        int r4 = Move[1];
                        int c4 = Move[2];
                        for (r4 = Move[1]; r4 <= Move[1] + 4 + 1; ++r4)
                        {
                            if (r4 > 17) continue;
                            if (c4 < 1) continue;
                            if (Movement[r4, c4] == 1) // it is o
                            {
                                oMark -= counter;// 1; // we add 2 more to the mark
                                break;
                            }
                            else if (Movement[r4, c4] == -1) // it is x
                            {
                                oMark += 2; // we minus mark only 1
                                counter += 2;
                                xSequence++;
                            }

                            c4--;
                        }

                        counter = 0;
                        r4 = Move[1];
                        c4 = Move[2];
                        for (r4 = Move[1]; r4 >= Move[1] - 4 - 1; r4--)
                        {
                            if (r4 < 1) continue;
                            if (c4 > 22) continue;

                            if (Movement[r4, c4] == 1) // it is o
                            {
                                oMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r4, c4] == -1) // it is x
                            {
                                oMark += 2;
                                counter += 2;
                                xSequence++;
                            }
                            c4++;
                        }
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }
                        xSequence = 0;

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        if (tempMark < oMark)
                        {

                            tempMark = oMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }

                    }// end of if
                } // end for loop ColumnOfAI

            } // end for rowOfAI 

            Move[1] = tempRow;
            Move[2] = tempCol;

            if (Move[2] < 5)
            {
                if (Movement[Move[1], 5] == 1)
                {
                    Move[1] = 0;
                    Move[2] = 0;
                    tempMark = 0;
                    return 0;
                }

            }
            if (Move[2] > 18)
            {
                if (Movement[Move[1], 18] == 1)
                {
                    Move[1] = 0;
                    Move[2] = 0;
                    tempMark = 0;
                    return 0;
                }
            }







            return tempMark;
        }
        double o2Times_ByColumn_Level5(int[] Move)
        {

            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempRow = 0;
            int tempCol = 0;
            int tempMark = 0;
            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13 + 1 + 1; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove];
                    //  Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == -2) // there is one move that we can win the game
                    {
                        for (int j = rowAIMove; j <= rowAIMove + 5 - 1 - 1; ++j)
                        {
                            if (j > 22) continue;
                            if (Movement[j, columnAIMove] == 0)
                            {

                                Move[1] = j;
                                Move[2] = columnAIMove;
                                if (Move[1] < 17)
                                {
                                    if (Movement[Move[1] + 1, Move[2]] == 1)// there is another x, we are not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        tempMark = 0;
                                    }
                                }
                                if (Move[1] > 1)
                                {
                                    if (Movement[Move[1] - 1, Move[2]] == 1)// there is another x, we are not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        tempMark = 0;
                                    }

                                }

                                break;
                            }
                        }// end of -for loop j


                        /******** loop for row **************/
                        int c1 = Move[2];
                        int oMark = 0;
                        int counter = 0;
                        int xSequence = 0;
                        for (c1 = Move[2]; c1 <= Move[2] + 4 + 1; c1++)
                        {
                            if (c1 > 22) continue;
                            if (Movement[Move[1], c1] == 1) // it is o
                            {
                                //  xMark -= 3;// 1; 
                                oMark -= counter;
                                break;
                            }
                            else if (Movement[Move[1], c1] == -1) // it is x
                            {
                                oMark += 2; // add  2
                                counter += 2;
                                xSequence++;
                            }
                        }// end of for loop c

                        counter = 0;
                        c1 = Move[2];
                        for (c1 = Move[2]; c1 >= Move[2] - 4 - 1; c1--)
                        {
                            if (c1 < 1) continue;
                            if (Movement[Move[1], c1] == 1) // it is o
                            {
                                // xMark -= 3;// 1; //  minus 3 to the mark
                                oMark -= counter;
                                break;

                            }
                            else if (Movement[Move[1], c1] == -1) // it is x
                            {
                                oMark += 2; //add 2
                                counter += 2;
                                xSequence++;
                            }
                        }//end of for loop c
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }

                        /*****loop mark for column*******/
                        xSequence = 0;
                        counter = 0;
                        int r2 = Move[1];
                        for (r2 = Move[1]; r2 <= Move[1] + 4 + 1; r2++)
                        {
                            if (r2 > 17) continue;
                            if (Movement[r2, Move[2]] == 1) // it is o
                            {
                                // xMark -= 3;// 1; // minus 1
                                oMark -= counter;
                                break;
                            }
                            else if (Movement[r2, Move[2]] == -1) // it is x 
                            {
                                oMark += 2; // add 2;
                                counter += 2;
                                xSequence++;
                            }
                        }
                        counter = 0;
                        r2 = Move[1];
                        for (r2 = Move[1]; r2 >= Move[1] - 4 - 1; r2--)
                        {
                            if (r2 < 1) continue;
                            if (Movement[r2, Move[2]] == 1) // it is o
                            {
                                oMark -= counter;// 1; // minus1
                                break;
                            }
                            else if (Movement[r2, Move[2]] == -1) // it is x 
                            {
                                oMark += 2; // add 2;
                                counter += 2;
                                xSequence++;
                            }
                        }
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        /***** loop for cross 1***********/
                        xSequence = 0;
                        counter = 0;
                        int r3 = Move[1];
                        int c3 = Move[2];
                        for (r3 = Move[1]; r3 <= Move[1] + 4 + 1; ++r3)
                        {
                            if (r3 > 17) continue;
                            if (c3 > 22) continue;
                            if (Movement[r3, c3] == 1) // it is o
                            {
                                oMark -= counter;// 1;
                                break;

                            }
                            else if (Movement[r3, c3] == -1) // it is x
                            {
                                oMark += 2;
                                counter += 2;
                                xSequence++;
                            }

                            c3++;
                        }

                        counter = 0;
                        r3 = Move[1];
                        c3 = Move[2];
                        for (r3 = Move[1]; r3 >= Move[1] - 4 - 1; r3--)
                        {
                            if (r3 < 1) continue;
                            if (c3 < 1) continue;

                            if (Movement[r3, c3] == 1) // it is o
                            {
                                oMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r3, c3] == -1) // it is x
                            {
                                oMark += 2;
                                counter += 2;
                                xSequence++;
                            }
                            c3--;
                        }
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }

                        /*********** loop for cross 2 **********************/
                        xSequence = 0;
                        counter = 0;
                        int r4 = Move[1];
                        int c4 = Move[2];
                        for (r4 = Move[1]; r4 <= Move[1] + 4 + 1; ++r4)
                        {
                            if (r4 > 17) continue;
                            if (c4 < 1) continue;
                            if (Movement[r4, c4] == 1) // it is o
                            {
                                oMark -= counter;// 1; // we add 2 more to the mark
                                break;
                            }
                            else if (Movement[r4, c4] == -1) // it is x
                            {
                                oMark += 2; // we minus mark only 1
                                counter += 2;
                                xSequence++;
                            }

                            c4--;
                        }

                        counter = 0;
                        r4 = Move[1];
                        c4 = Move[2];
                        for (r4 = Move[1]; r4 >= Move[1] - 4 - 1; r4--)
                        {
                            if (r4 < 1) continue;
                            if (c4 > 22) continue;

                            if (Movement[r4, c4] == 1) // it is o
                            {
                                oMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r4, c4] == -1) // it is x
                            {
                                oMark += 2;
                                counter += 2;
                                xSequence++;
                            }
                            c4++;
                        }
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }
                        xSequence = 0;

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        if (tempMark < oMark)
                        {

                            tempMark = oMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }

                         
                    }// end of if condition : score ==-2
                }
            }
            Move[1] = tempRow;
            Move[2] = tempCol;
            if (Move[1] == 1)
            {
                if (Movement[Move[1] + 3, Move[2]] == 0)
                {
                    Move[1] += 3;
                }

            }



            if (Move[1] < 5)
            {
                if (Movement[5, Move[2]] == 1)
                {
                    Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                }

            }
            if (Move[1] > 13)
            {
                if (Movement[13, Move[2]] == 1)
                {
                    Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                }
            }



            return tempMark;
        }
        double o2Times_ByCross1_ColumnAndRowIncrease_Level5(int[] Move)
        {


            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempMark = 0;
            int tempRow = 0;
            int tempCol = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2];
                    // Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == -2)
                    {

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1; i++)
                        {
                            if (i > 17) continue;
                            if (j > 22) continue;
                            if (Movement[i, j] == 0)
                            {

                                Move[1] = i;
                                Move[2] = j;
                                if ((Move[1] < 17 && Move[2] < 22) && (Movement[Move[1] + 1, Move[2] + 1] == 1))// there is another x, we are not going to make another o
                                {


                                    //  MessageBox.Show("Ryan AN");

                                    Move[1] = 0;
                                    Move[2] = 0;

                                }
                                if ((Move[1] > 1 && Move[2] > 1) && (Movement[Move[1] - 1, Move[2] - 1] == 1))// there is another x, we are not going to make another o
                                {

                                    //  MessageBox.Show("Pheakdey AN");

                                    Move[1] = 0;
                                    Move[2] = 0;

                                }
                                break;
                            }
                            j++;
                        }// end of for loop i


                        /******** loop for row **************/
                        int c1 = Move[2];
                        int oMark = 0;
                        int counter = 0;
                        int xSequence = 0;
                        for (c1 = Move[2]; c1 <= Move[2] + 4 + 1; c1++)
                        {
                            if (c1 > 22) continue;
                            if (Movement[Move[1], c1] == 1) // it is o
                            {
                                //  xMark -= 3;// 1; 
                                oMark -= counter;
                                break;
                            }
                            else if (Movement[Move[1], c1] == -1) // it is x
                            {
                                oMark += 2; // add  2
                                counter += 2;
                                xSequence++;
                            }
                        }// end of for loop c

                        counter = 0;
                        c1 = Move[2];
                        for (c1 = Move[2]; c1 >= Move[2] - 4 - 1; c1--)
                        {
                            if (c1 < 1) continue;
                            if (Movement[Move[1], c1] == 1) // it is o
                            {
                                // xMark -= 3;// 1; //  minus 3 to the mark
                                oMark -= counter;
                                break;

                            }
                            else if (Movement[Move[1], c1] == -1) // it is x
                            {
                                oMark += 2; //add 2
                                counter += 2;
                                xSequence++;
                            }
                        }//end of for loop c
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }

                        /*****loop mark for column*******/
                        xSequence = 0;
                        counter = 0;
                        int r2 = Move[1];
                        for (r2 = Move[1]; r2 <= Move[1] + 4 + 1; r2++)
                        {
                            if (r2 > 17) continue;
                            if (Movement[r2, Move[2]] == 1) // it is o
                            {
                                // xMark -= 3;// 1; // minus 1
                                oMark -= counter;
                                break;
                            }
                            else if (Movement[r2, Move[2]] == -1) // it is x 
                            {
                                oMark += 2; // add 2;
                                counter += 2;
                                xSequence++;
                            }
                        }
                        counter = 0;
                        r2 = Move[1];
                        for (r2 = Move[1]; r2 >= Move[1] - 4 - 1; r2--)
                        {
                            if (r2 < 1) continue;
                            if (Movement[r2, Move[2]] == 1) // it is o
                            {
                                oMark -= counter;// 1; // minus1
                                break;
                            }
                            else if (Movement[r2, Move[2]] == -1) // it is x 
                            {
                                oMark += 2; // add 2;
                                counter += 2;
                                xSequence++;
                            }
                        }
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        /***** loop for cross 1***********/
                        xSequence = 0;
                        counter = 0;
                        int r3 = Move[1];
                        int c3 = Move[2];
                        for (r3 = Move[1]; r3 <= Move[1] + 4 + 1; ++r3)
                        {
                            if (r3 > 17) continue;
                            if (c3 > 22) continue;
                            if (Movement[r3, c3] == 1) // it is o
                            {
                                oMark -= counter;// 1;
                                break;

                            }
                            else if (Movement[r3, c3] == -1) // it is x
                            {
                                oMark += 2;
                                counter += 2;
                                xSequence++;
                            }

                            c3++;
                        }

                        counter = 0;
                        r3 = Move[1];
                        c3 = Move[2];
                        for (r3 = Move[1]; r3 >= Move[1] - 4 - 1; r3--)
                        {
                            if (r3 < 1) continue;
                            if (c3 < 1) continue;

                            if (Movement[r3, c3] == 1) // it is o
                            {
                                oMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r3, c3] == -1) // it is x
                            {
                                oMark += 2;
                                counter += 2;
                                xSequence++;
                            }
                            c3--;
                        }
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }

                        /*********** loop for cross 2 **********************/
                        xSequence = 0;
                        counter = 0;
                        int r4 = Move[1];
                        int c4 = Move[2];
                        for (r4 = Move[1]; r4 <= Move[1] + 4 + 1; ++r4)
                        {
                            if (r4 > 17) continue;
                            if (c4 < 1) continue;
                            if (Movement[r4, c4] == 1) // it is o
                            {
                                oMark -= counter;// 1; // we add 2 more to the mark
                                break;
                            }
                            else if (Movement[r4, c4] == -1) // it is x
                            {
                                oMark += 2; // we minus mark only 1
                                counter += 2;
                                xSequence++;
                            }

                            c4--;
                        }

                        counter = 0;
                        r4 = Move[1];
                        c4 = Move[2];
                        for (r4 = Move[1]; r4 >= Move[1] - 4 - 1; r4--)
                        {
                            if (r4 < 1) continue;
                            if (c4 > 22) continue;

                            if (Movement[r4, c4] == 1) // it is o
                            {
                                oMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r4, c4] == -1) // it is x
                            {
                                oMark += 2;
                                counter += 2;
                                xSequence++;
                            }
                            c4++;
                        }
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }
                        xSequence = 0;

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        if (tempMark < oMark)
                        {

                            tempMark = oMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }


                    }// end of if sta. score==-2
                }// enf of the 2 main for loops
            Move[1] = tempRow;
            Move[2] = tempCol;
            if (Move[1] == 1)
            {
                if (Movement[5, Move[2] + 4] == 1)
                {
                    Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                }

            }



            if (Move[2] < 5)
            {
                int step = 5 - Move[2];
                if (Move[1] + step <= 17)
                {
                    if (Movement[Move[1] + step, 5] == 1)// there is x
                    {
                        Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                    }
                }
            }

            if (Move[2] > 17)
            {
                int step = Move[2] - 17;
                if (Move[1] + step <= 17)//row <=17
                {
                    if (Movement[Move[1] + step, 17] == 1)// there is x
                    {
                        Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                    }
                }
            }


            return tempMark;
        }
        double o2Times_ByCross2_ColumnAndRowDecrease_Level5(int[] Move)
        {

            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            int tempRow = 0;
            int tempCol = 0;
            int tempMark = 0;
            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2];
                    // Movement[rowAIMove - 3, columnAIMove + 3];
                    //Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == -2) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;

                        int i = rowAIMove;
                        int j = columnAIMove;

                        for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1; i++)
                        {
                            if (j >= 23) continue;
                            if (i >= 18) continue;

                            if (Movement[i, j] == 0)
                            {
                                // we made it. Yeah.

                                Move[1] = i;
                                Move[2] = j;
                                if (Move[1] > 1 && Move[2] < 22 && (Movement[Move[1] - 1, Move[2] + 1] == 1))// there is another x, we are not going to make another o
                                {
                                    Move[1] = 0;
                                    Move[2] = 0;

                                }
                                else if ((Move[1] < 17 && Move[2] > 1) && (Movement[Move[1] + 1, Move[2] - 1] == 1))// there is another x, we are not going to make another o
                                {

                                    Move[1] = 0;
                                    Move[2] = 0;

                                }
                                break;
                            }
                            j--;
                        }// end of for loop  :i


                        /******** loop for row **************/
                        int c1 = Move[2];
                        int oMark = 0;
                        int counter = 0;
                        int xSequence = 0;
                        for (c1 = Move[2]; c1 <= Move[2] + 4 + 1; c1++)
                        {
                            if (c1 > 22) continue;
                            if (Movement[Move[1], c1] == 1) // it is o
                            {
                                //  xMark -= 3;// 1; 
                                oMark -= counter;
                                break;
                            }
                            else if (Movement[Move[1], c1] == -1) // it is x
                            {
                                oMark += 2; // add  2
                                counter += 2;
                                xSequence++;
                            }
                        }// end of for loop c

                        counter = 0;
                        c1 = Move[2];
                        for (c1 = Move[2]; c1 >= Move[2] - 4 - 1; c1--)
                        {
                            if (c1 < 1) continue;
                            if (Movement[Move[1], c1] == 1) // it is o
                            {
                                // xMark -= 3;// 1; //  minus 3 to the mark
                                oMark -= counter;
                                break;

                            }
                            else if (Movement[Move[1], c1] == -1) // it is x
                            {
                                oMark += 2; //add 2
                                counter += 2;
                                xSequence++;
                            }
                        }//end of for loop c
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }

                        /*****loop mark for column*******/
                        xSequence = 0;
                        counter = 0;
                        int r2 = Move[1];
                        for (r2 = Move[1]; r2 <= Move[1] + 4 + 1; r2++)
                        {
                            if (r2 > 17) continue;
                            if (Movement[r2, Move[2]] == 1) // it is o
                            {
                                // xMark -= 3;// 1; // minus 1
                                oMark -= counter;
                                break;
                            }
                            else if (Movement[r2, Move[2]] == -1) // it is x 
                            {
                                oMark += 2; // add 2;
                                counter += 2;
                                xSequence++;
                            }
                        }
                        counter = 0;
                        r2 = Move[1];
                        for (r2 = Move[1]; r2 >= Move[1] - 4 - 1; r2--)
                        {
                            if (r2 < 1) continue;
                            if (Movement[r2, Move[2]] == 1) // it is o
                            {
                                oMark -= counter;// 1; // minus1
                                break;
                            }
                            else if (Movement[r2, Move[2]] == -1) // it is x 
                            {
                                oMark += 2; // add 2;
                                counter += 2;
                                xSequence++;
                            }
                        }
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        /***** loop for cross 1***********/
                        xSequence = 0;
                        counter = 0;
                        int r3 = Move[1];
                        int c3 = Move[2];
                        for (r3 = Move[1]; r3 <= Move[1] + 4 + 1; ++r3)
                        {
                            if (r3 > 17) continue;
                            if (c3 > 22) continue;
                            if (Movement[r3, c3] == 1) // it is o
                            {
                                oMark -= counter;// 1;
                                break;

                            }
                            else if (Movement[r3, c3] == -1) // it is x
                            {
                                oMark += 2;
                                counter += 2;
                                xSequence++;
                            }

                            c3++;
                        }

                        counter = 0;
                        r3 = Move[1];
                        c3 = Move[2];
                        for (r3 = Move[1]; r3 >= Move[1] - 4 - 1; r3--)
                        {
                            if (r3 < 1) continue;
                            if (c3 < 1) continue;

                            if (Movement[r3, c3] == 1) // it is o
                            {
                                oMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r3, c3] == -1) // it is x
                            {
                                oMark += 2;
                                counter += 2;
                                xSequence++;
                            }
                            c3--;
                        }
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }

                        /*********** loop for cross 2 **********************/
                        xSequence = 0;
                        counter = 0;
                        int r4 = Move[1];
                        int c4 = Move[2];
                        for (r4 = Move[1]; r4 <= Move[1] + 4 + 1; ++r4)
                        {
                            if (r4 > 17) continue;
                            if (c4 < 1) continue;
                            if (Movement[r4, c4] == 1) // it is o
                            {
                                oMark -= counter;// 1; // we add 2 more to the mark
                                break;
                            }
                            else if (Movement[r4, c4] == -1) // it is x
                            {
                                oMark += 2; // we minus mark only 1
                                counter += 2;
                                xSequence++;
                            }

                            c4--;
                        }

                        counter = 0;
                        r4 = Move[1];
                        c4 = Move[2];
                        for (r4 = Move[1]; r4 >= Move[1] - 4 - 1; r4--)
                        {
                            if (r4 < 1) continue;
                            if (c4 > 22) continue;

                            if (Movement[r4, c4] == 1) // it is o
                            {
                                oMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r4, c4] == -1) // it is x
                            {
                                oMark += 2;
                                counter += 2;
                                xSequence++;
                            }
                            c4++;
                        }
                        if (xSequence == 1)
                        {
                            oMark -= counter;
                        }
                        xSequence = 0;

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        if (tempMark < oMark)
                        {

                            tempMark = oMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }

                         
                    } // end of if statements : score ==-2
                }//end of the 2 main for loops

            Move[1] = tempRow;
            Move[2] = tempCol;

            if (Move[2] < 5)
            {
                int step = 5 - Move[2];
                if (Move[1] - step > 0)
                {
                    if (Movement[Move[1] - step, 5] == 1)
                    {
                        Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                    }
                }
            }
            if (Move[2] > 18)
            {
                int step = Move[2] - 18;
                if (Move[1] + step <= 22)
                {
                    if (Movement[Move[1] + step, 18] == 1)
                    {
                        Move[1] = 0; Move[2] = 0; tempMark = 0; return tempMark;
                    }
                }
            }


            return tempMark;
        }
        // x2 sequence
        double x2Times_ByRow_Level5(int[] Move)
        {

            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempMark = 0;
            int tempRow = 0;
            int tempCol = 0;
            for (rowAIMove = 1; rowAIMove <= 17; ++rowAIMove)
            {
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                                Movement[rowAIMove, columnAIMove + 1] +
                                Movement[rowAIMove, columnAIMove + 2];
                    // Movement[rowAIMove, columnAIMove + 3];
                    //  Movement[rowAIMove, columnAIMove + 4];

                    if (score == 2)
                    {
                        int bestMove_Column = columnAIMove;

                        for (int i = columnAIMove; i <= columnAIMove + 5 - 1 - 1; ++i)
                        {
                            if (Movement[rowAIMove, i] == 0)
                            {

                                Move[1] = rowAIMove;
                                Move[2] = i;


                                if (Move[2] < 22)
                                {
                                    if (Movement[Move[1], Move[2] + 1] == -1)// there is another p,  not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        // return ;
                                    }
                                }
                                if (Move[2] > 1)
                                {

                                    if (Movement[Move[1], Move[2] - 1] == -1)// there is another o, not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        // return ;
                                    }

                                }
                                break;
                            }
                            //---------
                        }
                        /******** loop for row **************/
                        int c1 = Move[2];
                        int xMark = 0;
                        int counter = 0;
                        int xSequence = 0;
                        for (c1 = Move[2]; c1 <= Move[2] + 4 + 1; c1++)
                        {
                            if (c1 > 22) continue;
                            if (Movement[Move[1], c1] == -1) // it is o
                            {
                              //  xMark -= 3;// 1; 
                                xMark -= counter;
                                break;
                            }
                            else if (Movement[Move[1], c1] == 1) // it is x
                            {
                                xMark += 2; // add  2
                                counter += 3;
                                xSequence++;
                            }
                        }// end of for loop c

                        counter = 0;
                        c1 = Move[2];
                        for (c1 = Move[2]; c1 >= Move[2] - 4 - 1; c1--)
                        {
                            if (c1 < 1) continue;
                            if (Movement[Move[1], c1] == -1) // it is o
                            {
                               // xMark -= 3;// 1; //  minus 3 to the mark
                                xMark -= counter;
                                break;

                            }
                            else if (Movement[Move[1], c1] == 1) // it is x
                            {
                                xMark += 2; //add 2
                                counter += 3;
                                xSequence++;
                            }
                        }//end of for loop c
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }

                        /*****loop mark for column*******/
                        xSequence = 0;
                        counter = 0;
                       int r2 = Move[1];
                        for (r2 = Move[1]; r2 <= Move[1] + 4 + 1; r2++)
                        {
                            if (r2 > 17) continue;
                            if (Movement[r2, Move[2]] == -1) // it is o
                            {
                               // xMark -= 3;// 1; // minus 1
                                xMark -= counter;
                                break;
                            }
                            else if (Movement[r2, Move[2]] == 1) // it is x 
                            {
                                xMark += 2; // add 2;
                                counter += 3;
                                xSequence++;
                            }
                        }
                        counter = 0;
                        r2 = Move[1];
                        for (r2 = Move[1]; r2 >= Move[1] - 4 - 1; r2--)
                        {
                            if (r2 < 1) continue;
                            if (Movement[r2, Move[2]] == -1) // it is o
                            {
                                xMark -= counter;// 1; // minus1
                                break;
                            }
                            else if (Movement[r2, Move[2]] == 1) // it is x 
                            {
                                xMark += 2; // add 2;
                                counter += 3;
                                xSequence++;
                            }
                        }
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        /***** loop for cross 1***********/
                        xSequence = 0;
                        counter = 0;
                        int r3 = Move[1];
                        int c3 = Move[2];
                        for (r3= Move[1]; r3 <= Move[1] + 4 + 1; ++r3)
                        {
                            if (r3 > 17) continue;
                            if (c3 > 22) continue;
                            if (Movement[r3, c3] == -1) // it is o
                            {
                                xMark -= counter ;// 1;
                                break;

                            }
                            else if (Movement[r3, c3] == 1) // it is x
                            {
                                xMark += 2;
                                counter += 3;
                                xSequence++;
                            }

                            c3++;
                        }
                      
                        counter = 0;
                        r3= Move[1];
                        c3 = Move[2];
                        for (r3 = Move[1]; r3 >= Move[1] - 4 - 1; r3--)
                        {
                            if (r3 < 1) continue;
                            if (c3 < 1) continue;

                            if (Movement[r3, c3] == -1) // it is o
                            {
                                xMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r3, c3] == 1) // it is x
                            {
                                xMark += 2;
                                counter += 3;
                                xSequence++;
                            }
                            c3--;
                        }
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }

                        /*********** loop for cross 2 **********************/
                        xSequence = 0;
                        counter = 0;
                        int r4 = Move[1];
                        int c4 = Move[2];
                        for (r4 = Move[1]; r4 <= Move[1] + 4 + 1; ++r4)
                        {
                            if (r4 > 17) continue;
                            if (c4 < 1) continue;
                            if (Movement[r4, c4] == -1) // it is o
                            {
                                xMark -= counter;// 1; // we add 2 more to the mark
                                break;
                            }
                            else if (Movement[r4, c4] == 1) // it is x
                            {
                                xMark += 2; // we minus mark only 1
                                counter += 3;
                                xSequence++;
                            }

                            c4--;
                        }
                        
                        counter = 0;
                        r4 = Move[1];
                        c4 = Move[2];
                        for (r4 = Move[1]; r4 >= Move[1] - 4 - 1; r4--)
                        {
                            if (r4 < 1) continue;
                            if (c4 > 22) continue;

                            if (Movement[r4, c4] == -1) // it is o
                            {
                                xMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r4, c4] == 1) // it is x
                            {
                                xMark += 2;
                                counter += 3;
                                xSequence++;
                            }
                            c4 ++;
                        }
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }
                        xSequence = 0;

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        if (tempMark < xMark)
                        {

                            tempMark = xMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }

                    }// end of if statement score==2
                } // end for loop ColumnOfAI

            } // end for rowOfAI 
            Move[1] = tempRow;
            Move[2] = tempCol;
            //MessageBox.Show(Move[1].ToString());
           // MessageBox.Show(Move[2].ToString());
          //  MessageBox.Show(tempMark.ToString()+"T");
            return tempMark;

        }
        double x2Times_ByColumn_Level5(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempRow = 0;
            int tempCol = 0;
            int tempMark = 0;
            for (columnAIMove = 1; columnAIMove <= 22; columnAIMove++)
            {
                for (rowAIMove = 1; rowAIMove <= 13 + 1 + 1; ++rowAIMove)
                {

                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove + 1, columnAIMove] +
                            Movement[rowAIMove + 2, columnAIMove];
                    //  Movement[rowAIMove + 3, columnAIMove];
                    //  Movement[rowAIMove + 4, columnAIMove];
                    if (score == 2) // there is one move that we can win the game
                    {
                        for (int j = rowAIMove; j <= rowAIMove + 5 - 1 - 1; ++j)
                        {
                            if (Movement[j, columnAIMove] == 0)
                            {

                                Move[1] = j;
                                Move[2] = columnAIMove;
                                if (Move[1] < 17)
                                {
                                    if (Movement[Move[1] + 1, Move[2]] == -1)// there is another o, not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        tempMark = 0;
                                    }
                                }
                                if (Move[1] > 1)
                                {
                                    if (Movement[Move[1] - 1, Move[2]] == -1)// there is another o,  not going to make another o
                                    {
                                        Move[1] = 0;
                                        Move[2] = 0;
                                        tempMark = 0;
                                    }

                                }

                                break;
                            }
                        }// end of -for loop j
                        /******** loop for row **************/
                        int c1 = Move[2];
                        int xMark = 0;
                        int counter = 0;
                        int xSequence = 0;
                        for (c1 = Move[2]; c1 <= Move[2] + 4 + 1; c1++)
                        {
                            if (c1 > 22) continue;
                            if (Movement[Move[1], c1] == -1) // it is o
                            {
                                //  xMark -= 3;// 1; 
                                xMark -= counter;
                                break;
                            }
                            else if (Movement[Move[1], c1] == 1) // it is x
                            {
                                xMark += 2; // add  2
                                counter += 3;
                                xSequence++;
                            }
                        }// end of for loop c

                        counter = 0;
                        c1 = Move[2];
                        for (c1 = Move[2]; c1 >= Move[2] - 4 - 1; c1--)
                        {
                            if (c1 < 1) continue;
                            if (Movement[Move[1], c1] == -1) // it is o
                            {
                                // xMark -= 3;// 1; //  minus 3 to the mark
                                xMark -= counter;
                                break;

                            }
                            else if (Movement[Move[1], c1] == 1) // it is x
                            {
                                xMark += 2; //add 2
                                counter += 3;
                                xSequence++;
                            }
                        }//end of for loop c
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }

                        /*****loop mark for column*******/
                        xSequence = 0;
                        counter = 0;
                        int r2 = Move[1];
                        for (r2 = Move[1]; r2 <= Move[1] + 4 + 1; r2++)
                        {
                            if (r2 > 17) continue;
                            if (Movement[r2, Move[2]] == -1) // it is o
                            {
                                // xMark -= 3;// 1; // minus 1
                                xMark -= counter;
                                break;
                            }
                            else if (Movement[r2, Move[2]] == 1) // it is x 
                            {
                                xMark += 2; // add 2;
                                counter += 3;
                                xSequence++;
                            }
                        }
                        counter = 0;
                        r2 = Move[1];
                        for (r2 = Move[1]; r2 >= Move[1] - 4 - 1; r2--)
                        {
                            if (r2 < 1) continue;
                            if (Movement[r2, Move[2]] == -1) // it is o
                            {
                                xMark -= counter;// 1; // minus1
                                break;
                            }
                            else if (Movement[r2, Move[2]] == 1) // it is x 
                            {
                                xMark += 2; // add 2;
                                counter += 3;
                                xSequence++;
                            }
                        }
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        /***** loop for cross 1***********/
                        xSequence = 0;
                        counter = 0;
                        int r3 = Move[1];
                        int c3 = Move[2];
                        for (r3 = Move[1]; r3 <= Move[1] + 4 + 1; ++r3)
                        {
                            if (r3 > 17) continue;
                            if (c3 > 22) continue;
                            if (Movement[r3, c3] == -1) // it is o
                            {
                                xMark -= counter;// 1;
                                break;

                            }
                            else if (Movement[r3, c3] == 1) // it is x
                            {
                                xMark += 2;
                                counter += 3;
                                xSequence++;
                            }

                            c3++;
                        }

                        counter = 0;
                        r3 = Move[1];
                        c3 = Move[2];
                        for (r3 = Move[1]; r3 >= Move[1] - 4 - 1; r3--)
                        {
                            if (r3 < 1) continue;
                            if (c3 < 1) continue;

                            if (Movement[r3, c3] == -1) // it is o
                            {
                                xMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r3, c3] == 1) // it is x
                            {
                                xMark += 2;
                                counter += 3;
                                xSequence++;
                            }
                            c3--;
                        }
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }

                        /*********** loop for cross 2 **********************/
                        xSequence = 0;
                        counter = 0;
                        int r4 = Move[1];
                        int c4 = Move[2];
                        for (r4 = Move[1]; r4 <= Move[1] + 4 + 1; ++r4)
                        {
                            if (r4 > 17) continue;
                            if (c4 < 1) continue;
                            if (Movement[r4, c4] == -1) // it is o
                            {
                                xMark -= counter;// 1; // we add 2 more to the mark
                                break;
                            }
                            else if (Movement[r4, c4] == 1) // it is x
                            {
                                xMark += 2; // we minus mark only 1
                                counter += 3;
                                xSequence++;
                            }

                            c4--;
                        }

                        counter = 0;
                        r4 = Move[1];
                        c4 = Move[2];
                        for (r4 = Move[1]; r4 >= Move[1] - 4 - 1; r4--)
                        {
                            if (r4 < 1) continue;
                            if (c4 > 22) continue;

                            if (Movement[r4, c4] == -1) // it is o
                            {
                                xMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r4, c4] == 1) // it is x
                            {
                                xMark += 2;
                                counter += 3;
                                xSequence++;
                            }
                            c4++;
                        }
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }
                        xSequence = 0;

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        if (tempMark < xMark)
                        {
                            tempMark = xMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }

                    }// end of if condition : score ==-2
                }
            }
            Move[1] = tempRow;
            Move[2] = tempCol;
            return tempMark;
        }
        double x2Times_ByCross1_ColumnAndRowIncrease_Level5(int[] Move)
        {
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            int tempMark = 0;
            int tempRow = 0;
            int tempCol = 0;

            for (rowAIMove = 1; rowAIMove <= 13; rowAIMove++)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; columnAIMove++)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                             Movement[rowAIMove + 1, columnAIMove + 1] +
                             Movement[rowAIMove + 2, columnAIMove + 2];
                    // Movement[rowAIMove + 3, columnAIMove + 3];
                    // Movement[rowAIMove + 4, columnAIMove + 4];
                    if (score == 2)
                    {

                        int i = rowAIMove;
                        int j = columnAIMove;
                        for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1; i++)
                        {
                            if (Movement[i, j] == 0)
                            {

                                Move[1] = i;
                                Move[2] = j;
                                if ((Move[1] < 17 && Move[2] < 22) && (Movement[Move[1] + 1, Move[2] + 1] == -1))// there is another o,  not going to make another x
                                {


                                    //  MessageBox.Show("Ryan AN");

                                    Move[1] = 0;
                                    Move[2] = 0;

                                }
                                if ((Move[1] > 1 && Move[2] > 1) && (Movement[Move[1] - 1, Move[2] - 1] == -1))// there is another o,not going to make another x
                                {

                                    //  MessageBox.Show("Pheakdey AN");

                                    Move[1] = 0;
                                    Move[2] = 0;

                                }
                                break;
                            }
                            j++;
                        }// end of for loop i
                        /******** loop for row **************/
                        int c1 = Move[2];
                        int xMark = 0;
                        int counter = 0;
                        int xSequence = 0;
                        for (c1 = Move[2]; c1 <= Move[2] + 4 + 1; c1++)
                        {
                            if (c1 > 22) continue;
                            if (Movement[Move[1], c1] == -1) // it is o
                            {
                                //  xMark -= 3;// 1; 
                                xMark -= counter;
                                break;
                            }
                            else if (Movement[Move[1], c1] == 1) // it is x
                            {
                                xMark += 2; // add  2
                                counter += 3;
                                xSequence++;
                            }
                        }// end of for loop c

                        counter = 0;
                        c1 = Move[2];
                        for (c1 = Move[2]; c1 >= Move[2] - 4 - 1; c1--)
                        {
                            if (c1 < 1) continue;
                            if (Movement[Move[1], c1] == -1) // it is o
                            {
                                // xMark -= 3;// 1; //  minus 3 to the mark
                                xMark -= counter;
                                break;

                            }
                            else if (Movement[Move[1], c1] == 1) // it is x
                            {
                                xMark += 2; //add 2
                                counter += 3;
                                xSequence++;
                            }
                        }//end of for loop c
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }

                        /*****loop mark for column*******/
                        xSequence = 0;
                        counter = 0;
                        int r2 = Move[1];
                        for (r2 = Move[1]; r2 <= Move[1] + 4 + 1; r2++)
                        {
                            if (r2 > 17) continue;
                            if (Movement[r2, Move[2]] == -1) // it is o
                            {
                                // xMark -= 3;// 1; // minus 1
                                xMark -= counter;
                                break;
                            }
                            else if (Movement[r2, Move[2]] == 1) // it is x 
                            {
                                xMark += 2; // add 2;
                                counter += 3;
                                xSequence++;
                            }
                        }
                        counter = 0;
                        r2 = Move[1];
                        for (r2 = Move[1]; r2 >= Move[1] - 4 - 1; r2--)
                        {
                            if (r2 < 1) continue;
                            if (Movement[r2, Move[2]] == -1) // it is o
                            {
                                xMark -= counter;// 1; // minus1
                                break;
                            }
                            else if (Movement[r2, Move[2]] == 1) // it is x 
                            {
                                xMark += 2; // add 2;
                                counter += 3;
                                xSequence++;
                            }
                        }
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        /***** loop for cross 1***********/
                        xSequence = 0;
                        counter = 0;
                        int r3 = Move[1];
                        int c3 = Move[2];
                        for (r3 = Move[1]; r3 <= Move[1] + 4 + 1; ++r3)
                        {
                            if (r3 > 17) continue;
                            if (c3 > 22) continue;
                            if (Movement[r3, c3] == -1) // it is o
                            {
                                xMark -= counter;// 1;
                                break;

                            }
                            else if (Movement[r3, c3] == 1) // it is x
                            {
                                xMark += 2;
                                counter += 3;
                                xSequence++;
                            }

                            c3++;
                        }

                        counter = 0;
                        r3 = Move[1];
                        c3 = Move[2];
                        for (r3 = Move[1]; r3 >= Move[1] - 4 - 1; r3--)
                        {
                            if (r3 < 1) continue;
                            if (c3 < 1) continue;

                            if (Movement[r3, c3] == -1) // it is o
                            {
                                xMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r3, c3] == 1) // it is x
                            {
                                xMark += 2;
                                counter += 3;
                                xSequence++;
                            }
                            c3--;
                        }
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }

                        /*********** loop for cross 2 **********************/
                        xSequence = 0;
                        counter = 0;
                        int r4 = Move[1];
                        int c4 = Move[2];
                        for (r4 = Move[1]; r4 <= Move[1] + 4 + 1; ++r4)
                        {
                            if (r4 > 17) continue;
                            if (c4 < 1) continue;
                            if (Movement[r4, c4] == -1) // it is o
                            {
                                xMark -= counter;// 1; // we add 2 more to the mark
                                break;
                            }
                            else if (Movement[r4, c4] == 1) // it is x
                            {
                                xMark += 2; // we minus mark only 1
                                counter += 3;
                                xSequence++;
                            }

                            c4--;
                        }

                        counter = 0;
                        r4 = Move[1];
                        c4 = Move[2];
                        for (r4 = Move[1]; r4 >= Move[1] - 4 - 1; r4--)
                        {
                            if (r4 < 1) continue;
                            if (c4 > 22) continue;

                            if (Movement[r4, c4] == -1) // it is o
                            {
                                xMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r4, c4] == 1) // it is x
                            {
                                xMark += 2;
                                counter += 3;
                                xSequence++;
                            }
                            c4++;
                        }
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }
                        xSequence = 0;

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        if (tempMark < xMark)
                        {
                            tempMark = xMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }


                    }// end of if sta. score==-2
                }// enf of the 2 main for loops

            Move[1] = tempRow;
            Move[2] = tempCol;
            return tempMark;
        }
        double x2Times_ByCross2_ColumnAndRowDecrease_Level5(int[] Move)
        {

            int rowAIMove = 17;
            int columnAIMove = 22;
            int score = 0;
            int tempRow = 0;
            int tempCol = 0;
            int tempMark = 0;
            // MessageBox.Show("Hello girl");
            for (rowAIMove = 17; rowAIMove >= 5; --rowAIMove)
                for (columnAIMove = 1; columnAIMove <= 18 + 1 + 1; ++columnAIMove)
                {
                    score = Movement[rowAIMove, columnAIMove] +
                            Movement[rowAIMove - 1, columnAIMove + 1] +
                            Movement[rowAIMove - 2, columnAIMove + 2];
                    // Movement[rowAIMove - 3, columnAIMove + 3];
                    //Movement[rowAIMove - 4, columnAIMove + 4];


                    if (score == 2) // there is one move that we can win the game
                    {
                        int bestMove_row = rowAIMove;
                        int i = rowAIMove;
                        int j = columnAIMove;

                        if (Move[1] > 1 && Move[2] < 22 && (Movement[Move[1] - 1, Move[2] + 1] == -1))
                        {
                            Move[1] = 0;
                            Move[2] = 0;

                        }
                        else if ((Move[1] < 17 && Move[2] > 1) && (Movement[Move[1] + 1, Move[2] - 1] == -1))
                        {

                            Move[1] = 0;
                            Move[2] = 0;

                        }
                        else
                        {
                            for (i = rowAIMove; i <= rowAIMove + 5 - 1 - 1; i++)
                            {
                                if (i > 17) continue;
                                if (j > 22) continue;
                                if (Movement[i, j] == 0)
                                {
                                    // we made it. Yeah.

                                    Move[1] = i;
                                    Move[2] = j;

                                    break;
                                }
                                j--;
                            }// end of for loop  :i
                        }
                        /******** loop for row **************/
                        int c1 = Move[2];
                        int xMark = 0;
                        int counter = 0;
                        int xSequence = 0;
                        for (c1 = Move[2]; c1 <= Move[2] + 4 + 1; c1++)
                        {
                            if (c1 > 22) continue;
                            if (Movement[Move[1], c1] == -1) // it is o
                            {
                                //  xMark -= 3;// 1; 
                                xMark -= counter;
                                break;
                            }
                            else if (Movement[Move[1], c1] == 1) // it is x
                            {
                                xMark += 2; // add  2
                                counter += 3;
                                xSequence++;
                            }
                        }// end of for loop c

                        counter = 0;
                        c1 = Move[2];
                        for (c1 = Move[2]; c1 >= Move[2] - 4 - 1; c1--)
                        {
                            if (c1 < 1) continue;
                            if (Movement[Move[1], c1] == -1) // it is o
                            {
                                // xMark -= 3;// 1; //  minus 3 to the mark
                                xMark -= counter;
                                break;

                            }
                            else if (Movement[Move[1], c1] == 1) // it is x
                            {
                                xMark += 2; //add 2
                                counter += 3;
                                xSequence++;
                            }
                        }//end of for loop c
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }

                        /*****loop mark for column*******/
                        xSequence = 0;
                        counter = 0;
                        int r2 = Move[1];
                        for (r2 = Move[1]; r2 <= Move[1] + 4 + 1; r2++)
                        {
                            if (r2 > 17) continue;
                            if (Movement[r2, Move[2]] == -1) // it is o
                            {
                                // xMark -= 3;// 1; // minus 1
                                xMark -= counter;
                                break;
                            }
                            else if (Movement[r2, Move[2]] == 1) // it is x 
                            {
                                xMark += 2; // add 2;
                                counter += 3;
                                xSequence++;
                            }
                        }
                        counter = 0;
                        r2 = Move[1];
                        for (r2 = Move[1]; r2 >= Move[1] - 4 - 1; r2--)
                        {
                            if (r2 < 1) continue;
                            if (Movement[r2, Move[2]] == -1) // it is o
                            {
                                xMark -= counter;// 1; // minus1
                                break;
                            }
                            else if (Movement[r2, Move[2]] == 1) // it is x 
                            {
                                xMark += 2; // add 2;
                                counter += 3;
                                xSequence++;
                            }
                        }
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        /***** loop for cross 1***********/
                        xSequence = 0;
                        counter = 0;
                        int r3 = Move[1];
                        int c3 = Move[2];
                        for (r3 = Move[1]; r3 <= Move[1] + 4 + 1; ++r3)
                        {
                            if (r3 > 17) continue;
                            if (c3 > 22) continue;
                            if (Movement[r3, c3] == -1) // it is o
                            {
                                xMark -= counter;// 1;
                                break;

                            }
                            else if (Movement[r3, c3] == 1) // it is x
                            {
                                xMark += 2;
                                counter += 3;
                                xSequence++;
                            }

                            c3++;
                        }

                        counter = 0;
                        r3 = Move[1];
                        c3 = Move[2];
                        for (r3 = Move[1]; r3 >= Move[1] - 4 - 1; r3--)
                        {
                            if (r3 < 1) continue;
                            if (c3 < 1) continue;

                            if (Movement[r3, c3] == -1) // it is o
                            {
                                xMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r3, c3] == 1) // it is x
                            {
                                xMark += 2;
                                counter += 3;
                                xSequence++;
                            }
                            c3--;
                        }
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }

                        /*********** loop for cross 2 **********************/
                        xSequence = 0;
                        counter = 0;
                        int r4 = Move[1];
                        int c4 = Move[2];
                        for (r4 = Move[1]; r4 <= Move[1] + 4 + 1; ++r4)
                        {
                            if (r4 > 17) continue;
                            if (c4 < 1) continue;
                            if (Movement[r4, c4] == -1) // it is o
                            {
                                xMark -= counter;// 1; // we add 2 more to the mark
                                break;
                            }
                            else if (Movement[r4, c4] == 1) // it is x
                            {
                                xMark += 2; // we minus mark only 1
                                counter += 3;
                                xSequence++;
                            }

                            c4--;
                        }

                        counter = 0;
                        r4 = Move[1];
                        c4 = Move[2];
                        for (r4 = Move[1]; r4 >= Move[1] - 4 - 1; r4--)
                        {
                            if (r4 < 1) continue;
                            if (c4 > 22) continue;

                            if (Movement[r4, c4] == -1) // it is o
                            {
                                xMark -= counter;// 1; 
                                break;
                            }
                            else if (Movement[r4, c4] == 1) // it is x
                            {
                                xMark += 2;
                                counter += 3;
                                xSequence++;
                            }
                            c4++;
                        }
                        if (xSequence == 1)
                        {
                            xMark -= counter;
                        }
                        xSequence = 0;

                        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                        if (tempMark < xMark)
                        {
                            tempMark = xMark;
                            tempRow = Move[1];
                            tempCol = Move[2];
                        }

                    } // end of if statements : score ==-2
                }//end of the 2 main for loops
            Move[1] = tempRow;
            Move[2] = tempCol;

            return tempMark;
        }

        double x2and3TwoWay(int[] best)
        {

            int tempRow = 0;
            int tempCol = 0;
            double tempMark = 0;
            int rowAIMove = 1;
            int columnAIMove = 1;
            int score = 0;
            for (int i = 1; i <= totalRow; ++i)
            {
                for (int j = 1; j <= totalColumn; ++j)
                {



                    //  tempRow = i;
                    //   tempCol = j;

                    if (Movement[i, j] == 1)
                    {
                        continue;
                    }
                    else if (Movement[i, j] == -1)
                    {
                        continue;
                    }
                    else if (Movement[i, j] == 0)
                    {
                        best[1] = i;
                        best[2] = j;
                    }


                    //loop for row 
                    int c1 = best[2];
                    double oMark = 0;
                    double xMark = 0;
                    int r2 = best[1] + 1;
                    int r3 = best[1] + 1;
                    int c3 = best[2] + 1;
                    int r4 = best[1] + 1;
                    int c4 = best[2] - 1;

                    int sequence = 0;
                    int counter = 0;

                    //>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    for (c1 = best[2] + 1; c1 <= best[2] + 4 + 1; c1++)
                    {
                        if (c1 > 22) continue;

                        if (Movement[best[1], c1] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[best[1], c1] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                            break;
                        }



                    }// end of for loop c

                    if (sequence == 1)
                    {
                        xMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;


                    for (c1 = best[2] - 1; c1 >= best[2] - 5; c1--)
                    {
                        if (c1 > 22) continue;
                        if (c1 < 1) continue;

                        if (Movement[best[1], c1] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[best[1], c1] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                            break;
                        }



                    }// end of for loop c

                    if (sequence == 1)
                    {
                        xMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;


                    //****loop mark for column******
                    for (r2 = best[1] + 1; r2 <= best[1] + 4 + 1; r2++)
                    {
                        if (r2 > 17) continue;
                        if (Movement[r2, best[2]] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[r2, best[2]] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (sequence == 1)
                    {
                        xMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;



                    r2 = best[1];
                    for (r2 = best[1]; r2 >= best[1] - 4 - 1; r2--)
                    {
                        if (r2 < 1) continue;
                        if (Movement[r2, best[2]] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[r2, best[2]] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (sequence == 1)
                    {
                        xMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;

                    //////////// loop for cross 1
                    for (r3 = best[1] + 1; r3 <= best[1] + 4 + 1; ++r3)
                    {
                        if (r3 > 17) continue;
                        if (c3 > 22) continue;
                        if (Movement[r3, c3] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[r3, c3] == -1) // it is x
                        {
                            xMark -= 5;
                            break;

                        }
                        else
                        {
                            break;
                        }

                        c3++;
                    }

                    if (sequence == 1)
                    {
                        xMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;




                    r3 = best[1] - 1;
                    c3 = best[2] - 1;
                    for (r3 = best[1] - 1; r3 >= best[1] - 4 - 1; r3--)
                    {
                        if (r3 < 1) continue;
                        if (c3 < 1) continue;

                        if (Movement[r3, c3] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[r3, c3] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                            break;
                        }
                        c3--;
                    }
                    if (sequence == 1)
                    {
                        xMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;

                    /////////////loop for cross 2 

                    for (r4 = best[1] + 1; r4 <= best[1] + 4 + 1; ++r4)
                    {
                        if (r4 > 17) continue;
                        if (c4 < 1) continue;
                        if (c4 > 22) continue;
                        if (Movement[r4, c4] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[r4, c4] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                            break;
                        }
                        c4--;
                    }
                    if (sequence == 1)
                    {
                        xMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;



                    r4 = best[1] - 1;
                    c4 = best[2] + 1;
                    for (r4 = best[1] - 1; r4 >= best[1] - 4 - 1; r4--)
                    {
                        if (r4 < 1) continue;
                        if (c4 > 22) continue;

                        if (Movement[r4, c4] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[r4, c4] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                            break;
                        }
                        c4++;
                    }
                    if (sequence == 1)
                    {
                        xMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;



                    double decide = oMark + xMark;


                    if (tempMark < decide)
                    {
                        score++;
                        tempMark = decide;
                        tempRow = best[1];
                        tempCol = best[2];
                        //MessageBox.Show(tempRow.ToString());
                        // MessageBox.Show(tempCol.ToString());
                    }





                } // end for
                } // end for










            return 0;
        }
            

        public void StrategyLevel5()
        {
          //  MessageBox.Show("Iron man");
            int[] best = new int[3];
            //============================================================
            /* 1 draw and win */
            //--------------------------------------------------
            DrawAndWin_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                int rowAIMove = best[1];
                int columnAIMove = best[2];

                //MessageBox.Show("we made it");
                Osymbol(best[1], best[2]);

                defend[rowAIMove, columnAIMove] = 1;
                Movement[rowAIMove, columnAIMove] = -1;

                WinByRow(rowAIMove);
                best = null; // remove an object, or array
                isDraw = false;

                return;
            }

            //------------------------------------------------
            DrawAndWin_ByColumn(best);

            if ((best[1] != 0) && (best[2] != 0))
            {
                int rowAIMove = best[1];
                int columnAIMove = best[2];
                Osymbol(best[1], best[2]);

                defend[rowAIMove, columnAIMove] = 1;
                Movement[rowAIMove, columnAIMove] = -1;

                WinByColumn(columnAIMove);

                best = null; // remove an object, or array
                isDraw = false;

                return;
            }
            //----------------------------------------------------
            DrawWin_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);
                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;

                WinByCross1_ColumnAndRowIncrease();
                best = null; // remove an object, or array
                isDraw = false;

                return;
            }
            //  DrawAndWin_ByRow();


            //   MessageBox.Show(" hi");

            // DetectWinner();
            //------------------------------------------------------
            DrawWin_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                int rowAIMove = best[1];
                int columnAIMove = best[2];

                Graphics playerGraphic;
                playerGraphic = this.CreateGraphics();
                Pen penAI;
                int a = columnAIMove * 40 - 20;
                int b = rowAIMove * 40 - 20;
                Rectangle myRectangle = new Rectangle();
                penAI = new Pen(Color.Red, 3);
                playerGraphic = this.CreateGraphics();
                this.Show();
                myRectangle.X = a - 20 + 10 - 5;
                myRectangle.Y = b - 20 + 5;
                myRectangle.Width = 30;
                myRectangle.Height = 30;
                playerGraphic.DrawEllipse(penAI, myRectangle);
                defend[rowAIMove, columnAIMove] = 1;
                Movement[rowAIMove, columnAIMove] = -1;

                WinByCross2_ColumnAndRowDecrease();
                best = null; // remove an object, or array
                isDraw = false;

                return;
            }
            //========================================================================================================
            /* 2 draw if there is X 4 times in sequence */


            //-----------2.1 : For row!
            x4Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //-----------2.2 : For column!
            x4Times_ByColumn(best);

            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //----------2.3 : For cross_1 
            x4Times_ByCross1_ColumnAndRowIncrease(best);

            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //----------2.4 : For cross_2
            x4Times_ByCross2_ColumnAndRowDecrease(best);


            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }

            //// extra add....
            x3TimesAbsolute_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
              //  MessageBox.Show("Extra add. Row");
                Osymbol(best[1], best[2]);
                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            x3TimesAbsolte_ByCol(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
               // MessageBox.Show("Extra add. Col");

                Osymbol(best[1], best[2]);
                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
          x3TimesAbsolute_ByCross1(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
               // MessageBox.Show("Extra add. C1");

                Osymbol(best[1], best[2]);
                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
          //  x3TimesAbsolute_ByCross2(best);
            x3TimesAbsolutely_byC2(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
              //  MessageBox.Show("Extra add. C2");

                Osymbol(best[1], best[2]);
                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            

            /* 3. draw if there is O 3 times in sequence */
            //--------- 3.1 . For row

            o3Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);
                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------------ 3.2 : For column
            o3Times_ByColumn(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------------- 3.3 : for cross_1
            o3Times_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------------- 3.4 : for cross_2
            o3Times_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            double tempScore = 0;
            int tempRow = 0;
            int tempCol = 0;
            double x3ByRow = x3Times_ByRowLevel5(best);

            //  MessageBox.Show("1//"+x3ByRow.ToString());
          //  label1.Text = x3ByRow.ToString();
            if (best[1] != 0 && best[2] != 0)
            {

                tempScore = x3ByRow;
                tempRow = best[1];
                tempCol = best[2];
            }

            double x3ByCol = x3Times_ByColumn_Level5(best);
            //  MessageBox.Show("2//"+x3ByCol.ToString());
          //  label2.Text = x3ByCol.ToString();

            if (best[1] != 0 && best[2] != 0 && tempScore < x3ByCol)
            {
                tempScore = x3ByCol;
                tempRow = best[1];
                tempCol = best[2];
            }
            double x3ByCross1 = x3Times_ByCross1_ColumnAndRowIncrease_Level5(best);
            //   MessageBox.Show("x3Cr1=" + x3ByCross1.ToString());
            //   MessageBox.Show("3//"+x3ByCross1.ToString());
           // label3.Text = x3ByCross1.ToString();

            if (best[1] != 0 && best[2] != 0 && tempScore < x3ByCross1)
            {
                tempScore = x3ByCross1;
                tempRow = best[1];
                tempCol = best[2];
            }

            double x3ByCross2 = x3Times_ByCross2_ColumnAndRowDecrease_Level5(best);
            //   MessageBox.Show("4//"+x3ByCross2.ToString());
         //   label4.Text = x3ByCross2.ToString();

            if (best[1] != 0 && best[2] != 0 && tempScore < x3ByCross2)
            {
                tempScore = x3ByCross2;
                tempRow = best[1];
                tempCol = best[2];
            }

            //----
            double o2ByRow = o2Times_ByRow_Level5(best);
            // MessageBox.Show("o2Row=" + o2ByRow.ToString());
           //    MessageBox.Show("5//"+o2ByRow.ToString());
        //    label5.Text = o2ByRow.ToString();

            if ((best[1] != 0) && (best[2] != 0) && (tempScore < o2ByRow))
            {
                tempScore = o2ByRow;
                tempRow = best[1];
                tempCol = best[2];
            }
            double o2ByCol = o2Times_ByColumn_Level5(best);
            //  MessageBox.Show("6//"+o2ByCol.ToString());
        //    label6.Text = o2ByCol.ToString();

            if (best[1] != 0 && best[2] != 0 && tempScore < o2ByCol)
            {
                tempScore = o2ByCol;
                tempRow = best[1];
                tempCol = best[2];
            }
            double o2ByCross1 = o2Times_ByCross1_ColumnAndRowIncrease_Level5(best);
           //    MessageBox.Show("7//"+o2ByCross1.ToString());
        //    label7.Text = o2ByCross1.ToString();

            if (best[1] != 0 && best[2] != 0 && tempScore < o2ByCross1)
            {
                tempScore = o2ByCross1;
                tempRow = best[1];
                tempCol = best[2];
            }
            double o2ByCross2 = o2Times_ByCross2_ColumnAndRowDecrease_Level5(best);
           //   MessageBox.Show("8//"+o2ByCross2.ToString());
        //    label8.Text = o2ByCross2.ToString();

            if (best[1] != 0 && best[2] != 0 && tempScore < o2ByCross2)
            {
                tempScore = o2ByCross2;
                tempRow = best[1];
                tempCol = best[2];
            }
            //-----
            double x2Byrow = x2Times_ByRow_Level5(best);
            //  MessageBox.Show("9//"+x2Byrow.ToString());
        //    label9.Text = x2Byrow.ToString();

            if (best[1] != 0 && best[2] != 0 && tempScore < x2Byrow)
            {
                tempScore = x2Byrow;
                tempRow = best[1];
                tempCol = best[2];
            }


            double x2ByCol = x2Times_ByColumn_Level5(best);
           //    MessageBox.Show("10//"+x2ByCol.ToString());
        //    label10.Text = x2ByCol.ToString();

            if (best[1] != 0 && best[2] != 0 && tempScore < x2ByCol)
            {
                tempScore = x2ByCol;
                tempRow = best[1];
                tempCol = best[2];
            }
           double x2ByCross1 = x2Times_ByCross1_ColumnAndRowIncrease_Level5(best);
           //    MessageBox.Show("11//"+x2ByCross1.ToString());
          //  label11.Text = x2ByCross1.ToString();

            if (best[1] != 0 && best[2] != 0 && tempScore < x2ByCross1)
            {
                tempScore = x2ByCross1;
                tempRow = best[1];
                tempCol = best[2];
            }
            double x2ByCross2 = x2Times_ByCross2_ColumnAndRowDecrease_Level5(best);
         //     MessageBox.Show("12//"+x2ByCross2.ToString());
          //  label12.Text = x2ByCross2.ToString();

            if (best[1] != 0 && best[2] != 0 && tempScore < x2ByCross2)
            {
                tempScore = x2ByCross2;
                tempRow = best[1];
                tempCol = best[2];
            }
            
            
            //      <<<<<<  Decide  >>>>>>>>>
            // MessageBox.Show("final=" + tempScore.ToString());

            if ((tempScore != 0) && (tempRow != 0) && (tempCol != 0))
            {
                Osymbol(tempRow, tempCol);

                defend[tempRow, tempCol] = 1;
                Movement[tempRow, tempCol] = -1;
                best = null; // remove an object, or array
                return;
            }


            /* 7. draw if there is o 1 times in sequence */
            //--------- 7.1 For row
            o1Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------ 7.2 For column
            o1Times_ByColumn(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------- 7.3 For cross_1
            o1Times_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //----------- 7.4 For cross_2

            o1Times_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            /* 8. draw if there is x 1   times in sequence */
            //------ 8.1 For row
            x1Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------ 8.2 for column 
            x1Times_ByColumn(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------ 8.3 for Cross_1
            x1Times_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //-------- 8.4 For cross_2
            x1Times_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }



            //----- other wise, it is player O first turn . we random 
            int[] arr1 = new int[8] { 5, 6, 7, 8, 9, 10, 11, 12 };
            Random rd1 = new Random();
            int[] arr2 = new int[13] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            Random rd2 = new Random();
            int firstRow = 0;
            int randomRow = 0;

            int firstCol = 0;
            int randomCol = 0;
            do
            {

                firstRow = rd1.Next(0, 8);
                randomRow = arr1[firstRow];
                best[1] = randomRow;


                firstCol = rd2.Next(0, 13);
                randomCol = arr2[firstCol];
                best[2] = randomCol;


                if ((best[1] != 0) && (best[2] != 0) && (Movement[best[1], best[2]] == 0))
                {
                    Osymbol(best[1], best[2]);

                    defend[best[1], best[2]] = 1;
                    Movement[best[1], best[2]] = -1;
                    best = null; // remove an object, or array
                    rd1 = null;
                    rd2 = null;
                    arr1 = null;
                    arr2 = null;
                    return;
                }
            } while (true);


            // last choise 


        
        } // end of strategy Level 5


        public void StrategyLevel6()
        {
           
            int tempRow = 0;
            int tempCol = 0;
            double score = 0;
            int free = 0;
            double tempMark=0;
            int[] best = new int[3] ;


/**********************************/




            //============================================================
            /* 1 draw and win */
            //--------------------------------------------------
            DrawAndWin_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                int rowAIMove = best[1];
                int columnAIMove = best[2];

                //MessageBox.Show("we made it");
                Osymbol(best[1], best[2]);

                defend[rowAIMove, columnAIMove] = 1;
                Movement[rowAIMove, columnAIMove] = -1;

                WinByRow(rowAIMove);
                best = null; // remove an object, or array
                isDraw = false;

                return;
            }

            //------------------------------------------------
            DrawAndWin_ByColumn(best);

            if ((best[1] != 0) && (best[2] != 0))
            {
                int rowAIMove = best[1];
                int columnAIMove = best[2];
                Osymbol(best[1], best[2]);

                defend[rowAIMove, columnAIMove] = 1;
                Movement[rowAIMove, columnAIMove] = -1;

                WinByColumn(columnAIMove);

                best = null; // remove an object, or array
                isDraw = false;

                return;
            }
            //----------------------------------------------------
            DrawWin_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);
                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;

                WinByCross1_ColumnAndRowIncrease();
                best = null; // remove an object, or array
                isDraw = false;

                return;
            }
            //  DrawAndWin_ByRow();


            //   MessageBox.Show(" hi");

            // DetectWinner();
            //------------------------------------------------------
            DrawWin_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                int rowAIMove = best[1];
                int columnAIMove = best[2];

                Graphics playerGraphic;
                playerGraphic = this.CreateGraphics();
                Pen penAI;
                int a = columnAIMove * 40 - 20;
                int b = rowAIMove * 40 - 20;
                Rectangle myRectangle = new Rectangle();
                penAI = new Pen(Color.Red, 3);
                playerGraphic = this.CreateGraphics();
                this.Show();
                myRectangle.X = a - 20 + 10 - 5;
                myRectangle.Y = b - 20 + 5;
                myRectangle.Width = 30;
                myRectangle.Height = 30;
                playerGraphic.DrawEllipse(penAI, myRectangle);
                defend[rowAIMove, columnAIMove] = 1;
                Movement[rowAIMove, columnAIMove] = -1;

                WinByCross2_ColumnAndRowDecrease();
                best = null; // remove an object, or array
                isDraw = false;

                return;
            }
            //========================================================================================================
            /* 2 draw if there is X 4 times in sequence */


            //-----------2.1 : For row!
            x4Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //-----------2.2 : For column!
            x4Times_ByColumn(best);

            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //----------2.3 : For cross_1 
            x4Times_ByCross1_ColumnAndRowIncrease(best);

            if ((best[1] != 0) && (best[2] != 0))
            {

                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //----------2.4 : For cross_2
            x4Times_ByCross2_ColumnAndRowDecrease(best);


            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }

            /* 3. draw if there is O 3 times in sequence */
            //--------- 3.1 . For row

            o3Times_ByRow(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);
                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------------ 3.2 : For column
            o3Times_ByColumn(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------------- 3.3 : for cross_1
            o3Times_ByCross1_ColumnAndRowIncrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }
            //------------- 3.4 : for cross_2
            o3Times_ByCross2_ColumnAndRowDecrease(best);
            if ((best[1] != 0) && (best[2] != 0))
            {
                Osymbol(best[1], best[2]);

                defend[best[1], best[2]] = 1;
                Movement[best[1], best[2]] = -1;
                best = null; // remove an object, or array
                return;
            }






//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


            for (int i = 1; i <= totalRow; ++i)
            {
                for (int j = 1; j <= totalColumn; ++j)
                {


                   
                  //  tempRow = i;
                 //   tempCol = j;

                    if (Movement[i, j] == 1)
                    {
                        continue;
                    }
                    else if (Movement[i, j] == -1)
                    {
                        continue;
                    }
                    else if (Movement[i, j] == 0)
                    {
                        best[1] = i;
                        best[2] = j;
                    }

                 /*
                    int space = 0;

                    //1. Row
                    // 1.1 Row :: to the right
                    for (int col = j + 1; col <= totalRow; ++col)
                    {
                        if (Movement[i, j] == 1) //x 
                        {
                            score += 1;
                        }
                        else if (Movement[i, j] == -1)//o
                        {
                            score -= 1;
                        }
                        else if (Movement[i, j] == 0) // free
                        {
                            space++;
                        }

                        if (space == 2)
                        {
                            score = 0;
                            break;
                        }
                    }
                    

                    */


                    //2. Column


                    //3. Cross1


                    //4. Cross2

                    //loop for row 
                int c1 = best[2];
                    double oMark = 0;
                    double xMark = 0;
                    int r2 = best[1] + 1;
                    int r3 = best[1] + 1;
                    int c3 = best[2] + 1;
                    int r4 = best[1] + 1;
                    int c4 = best[2] - 1;

                    int sequence = 0;
                    int counter = 0;
                    for (c1 = best[2]+1; c1 <= best[2] + 4 + 1; c1++)
                    {
                        if (c1 > 22) continue;
                        if (Movement[best[1], c1] == 1) 
                        {
                            oMark -= 5;
                            break;
                        }
                        else if (Movement[best[1], c1] == -1) 
                        {
                            oMark  += 10;
                            counter += 10;
                            sequence++;
                            //MessageBox.Show("Hello world"); 
                        }
                        else
                        {
                            break;
                        }
                    }// end of for loop c

                    if (sequence == 1)
                    {
                        oMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;

                    for (c1 = best[2] -1; c1 >= best[2] -5; c1--)
                    {
                        if (c1 > 22) continue;
                        if (c1 < 1) continue;
                     
                        if (Movement[best[1], c1] == 1) 
                        {
                            oMark -= 5;
                            break;
                        }
                        else if (Movement[best[1], c1] == -1) 
                        {
                            oMark += 10; counter += 10;
                            sequence++;
                        }
                        else
                        {
                             break;
                        }
                    }// end of for loop c
                    if (sequence == 1)
                    {
                        oMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;
                    //****loop mark for column******
                    for (r2 = best[1]+1; r2 <= best[1] + 4 + 1; r2++)
                    {
                        if (r2 > 17) continue;
                        if (Movement[r2, best[2]] == 1) // it is 
                        {
                            oMark -= 5;
                            break;
                        }
                        else if (Movement[r2, best[2]] == -1) // it is 
                        {
                            oMark += 10; counter += 10;
                            sequence++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (sequence == 1)
                    {
                        oMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;


                    r2 = best[1];
                    for (r2 = best[1]; r2 >= best[1] - 4 - 1; r2--)
                    {
                        if (r2 < 1) continue;
                        if (Movement[r2, best[2]] == 1) // it is 
                        {
                            oMark -= 5;
                            break;
                        }
                        else if (Movement[r2, best[2]] == -1) // it is 
                        {
                            oMark += 10; counter += 10;
                            sequence++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (sequence == 1)
                    {
                        oMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;


                    //////////// loop for cross 1
                   for (r3 = best[1]+1; r3 <= best[1] + 4 + 1; ++r3)
                    {
                        if (r3 > 17) continue;
                        if (c3 > 22) continue;
                        if (Movement[r3, c3] == 1) // it is 
                        {
                            oMark -= 5;
                            break;
                        }
                        else if (Movement[r3, c3] == -1) // it is 
                        {
                            oMark += 10; counter += 10;
                            sequence++;

                        }
                        else
                        {
                           break;
                        }

                        c3++;
                    }
                   if (sequence == 1)
                   {
                       oMark -= counter;
                   }
                   counter = 0;
                   sequence = 0;


                    r3 = best[1]-1;
                    c3 = best[2] - 1;
                    for (r3 = best[1]-1; r3 >= best[1] - 4 - 1; r3--)
                    {
                        if (r3 < 1) continue;
                        if (c3 < 1) continue;

                        if (Movement[r3, c3] == 1) // it is 
                        {
                            oMark -= 5;
                            break;
                        }
                        else if (Movement[r3, c3] == -1) // it is 
                        {
                            oMark += 10; counter += 10;
                            sequence++;
                        }
                        else
                        {
                           break;
                        }
                        c3--;
                    }
                    if (sequence == 1)
                    {
                        oMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;
                    /////////////loop for cross 2 
                   
                   for (r4 = best[1]+1; r4 <= best[1] + 4 + 1; ++r4)
                    {
                        if (r4 > 17) continue;
                        if (c4 < 1) continue;
                        if (Movement[r4, c4] == 1) 
                        {
                            oMark -= 5;
                            break;
                        }
                        else if (Movement[r4, c4] == -1) 
                        {
                            oMark += 10; // we minus mark only 1
                            counter += 10;
                            sequence++;
                        }
                        else
                        {
                           break;
                        }
                        c4--;
                    }

                   if (sequence == 1)
                   {
                       oMark -= counter;
                   }
                   counter = 0;
                   sequence = 0;


                    r4 = best[1]-1;
                    c4 = best[2] + 1;
                    for (r4 = best[1]-1; r4 >= best[1] - 4 - 1; r4--)
                    {
                        if (r4 < 1) continue;
                        if (c4 > 22) continue;

                        if (Movement[r4, c4] == 1) // it is o
                        {
                            oMark -= 5;
                            break;
                        }
                        else if (Movement[r4, c4] == -1) // it is x
                        {
                            oMark += 10; 
                            counter += 10;
                            sequence++;
                        }
                        else
                        {
                             break;
                        }
                        c4++;
                    }

                    if (sequence == 1)
                    {
                        oMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;

                   // oMark = absoluteValue(oMark);
                    //>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                    for (c1 = best[2] + 1; c1 <= best[2] + 4 + 1; c1++)
                    {
                        if (c1 > 22) continue;

                        if (Movement[best[1], c1] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[best[1], c1] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                            break;
                        }



                    }// end of for loop c

                    if (sequence == 1)
                    {
                        xMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;


                    for (c1 = best[2] - 1; c1 >= best[2] - 5; c1--)
                    {
                        if (c1 > 22) continue;
                        if (c1 < 1) continue;

                        if (Movement[best[1], c1] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[best[1], c1] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                            break;
                        }



                    }// end of for loop c

                    if (sequence == 1)
                    {
                        xMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;


                    //****loop mark for column******
                    for (r2 = best[1] + 1; r2 <= best[1] + 4 + 1; r2++)
                    {
                        if (r2 > 17) continue;
                        if (Movement[r2, best[2]] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[r2, best[2]] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                         break;
                        }
                    }

                    if (sequence == 1)
                    {
                        xMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;



                    r2 = best[1];
                for (r2 = best[1]; r2 >= best[1] - 4 - 1; r2--)
                    {
                        if (r2 < 1) continue;
                        if (Movement[r2, best[2]] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[r2, best[2]] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }

                if (sequence == 1)
                {
                    xMark -= counter;
                }
                counter = 0;
                sequence = 0;

                    //////////// loop for cross 1
                   for (r3 = best[1] + 1; r3 <= best[1] + 4 + 1; ++r3)
                    {
                        if (r3 > 17) continue;
                        if (c3 > 22) continue;
                        if (Movement[r3, c3] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[r3, c3] == -1) // it is x
                        {
                            xMark -= 5;
                            break;

                        }
                        else
                        {
                          break;
                        }

                        c3++;
                    }

                   if (sequence == 1)
                   {
                       xMark -= counter;
                   }
                   counter = 0;
                   sequence = 0;




                    r3 = best[1] - 1;
                    c3 = best[2] - 1;
                   for (r3 = best[1] - 1; r3 >= best[1] - 4 - 1; r3--)
                    {
                        if (r3 < 1) continue;
                        if (c3 < 1) continue;

                        if (Movement[r3, c3] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[r3, c3] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                            break;
                        }
                        c3--;
                    }
                   if (sequence == 1)
                   {
                       xMark -= counter;
                   }
                   counter = 0;
                   sequence = 0;

                    /////////////loop for cross 2 

                    for (r4 = best[1] + 1; r4 <= best[1] + 4 + 1; ++r4)
                    {
                        if (r4 > 17) continue;
                        if (c4 < 1) continue;
                        if (c4 > 22) continue;
                        if (Movement[r4, c4] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[r4, c4] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                             break;
                        }
                        c4--;
                    }
                    if (sequence == 1)
                    {
                        xMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;



                    r4 = best[1] - 1;
                    c4 = best[2] + 1;
                    for (r4 = best[1] - 1; r4 >= best[1] - 4 - 1; r4--)
                    {
                        if (r4 < 1) continue;
                        if (c4 > 22) continue;

                        if (Movement[r4, c4] == 1) // it is o
                        {
                            xMark += 10; counter += 10;
                            sequence++;
                        }
                        else if (Movement[r4, c4] == -1) // it is x
                        {
                            xMark -= 5;
                            break;
                        }
                        else
                        {
                           break;
                        }
                        c4++;
                    }
                    if (sequence == 1)
                    {
                        xMark -= counter;
                    }
                    counter = 0;
                    sequence = 0;



                    double decide = oMark + xMark ;


                    if (tempMark < decide)
                    {
                        score++;
                        tempMark = decide;
                        tempRow = best[1];
                        tempCol = best[2];
                        //MessageBox.Show(tempRow.ToString());
                       // MessageBox.Show(tempCol.ToString());
                    }



                    

                }
            }
        //    MessageBox.Show(tempMark.ToString());
            best[1] = tempRow;
            best[2] = tempCol;
   
           if ((best[1] != 0) && (best[2] != 0))
            {
                int rowAIMove = best[1];
                int columnAIMove = best[2];
                Osymbol(best[1], best[2]);

                defend[rowAIMove, columnAIMove] = 1;
                Movement[rowAIMove, columnAIMove] = -1;

                WinByColumn(columnAIMove);

                best = null; // remove an object, or array
                isDraw = false;

            }
         //  MessageBox.Show("Hello girl");
         














           DetectWinner();
          


        } // end of strategy level 6

        double absoluteValue(double value)
        {
            if (value > 0)
            {
                return value;
            }
            else if (value < 0)
            {
                return (-1) * value ;
            }


            return 0;
        }

        double maxValue(double[] z)
        {
            double max = z[0];
            for (int i = 1; i <= 2; ++i)
            {
                if (z[i] > max)
                {
                    max = z[i];
                }
            }
            return max;
        }







        private void buttonNewgame_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        
            ResourceSet rs = new ResourceSet("userChoise.resx");
            string userPlay = rs.GetString("choise");
            rs.Close();

            
            //--------------------------------------------25-04-2016 Updated by Makara
            ///
            if (userPlay == "t1")
            {
                timer4.Start();//start timer

            }

                 if (userPlay == "q")
            {
              //  buttonSave.Visible = false;
                buttonSave.Enabled = false;
                labelXvictory.Text = "Player 1";
                labelOvictory.Text = "AI";
               buttonPlayerMode.Visible = true;
             //   buttonPlayerMode.Enabled = false;
                labelPlayerMode.Visible = true;


            }

            else
            {
                if (userPlay=="c1"||userPlay=="t1")
                {
                //    MessageBox.Show(isDraw.ToString());
                    
                    if (userPlay=="c1")
                    {
                        ResourceWriter rw = new ResourceWriter("ResultHighscoreRequet.resx");
                        rw.AddResource("name", labelPlayer1.Text);
                        rw.AddResource("level", singleModeLevel.ToString());
                        rw.AddResource("victory", xWin.ToString());
                        rw.AddResource("failure", oWin.ToString());
                        rw.AddResource("draw", (10 - xWin - oWin).ToString());

                        rw.Close();
                    }

                    if ((isDraw==true)&&(boardNumber>0))
                    {

                        if (MessageBox.Show("Quit, you will lose this board.", "The board is currently draw.", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            oWin++;
                            labelOvictoryCount.Text = oWin.ToString();

                            // MessageBox.Show("AN");
                        }
                        else return;
                    }

                }




                if (userPlay == "c3" || userPlay == "t3")
                {
                    labelPlusVictory.Visible = true;
                    labelPlusVictoryCount.Visible = true;
                }

                buttonPlayerMode.Visible = false;
                labelPlayerMode.Visible = false;

                labelTurn.Visible = true;
                labelTurn.BackColor = Color.Blue;
                labelTurn.Text = "Player X's turn";
                // Result
                if (boardNumber >= 10)
                {
                    this.Close();
                    // updated 2:37 25-04-16 (by Makara)

                    if (userPlay == "t1")
                    {
                        timer4.Stop();//stop timer
                        total = (h * 3600) + (m * 60) + s;

                    }
                    else if (userPlay == "t2")
                    {
                        timer4.Stop();//stop timer
                        total = (h * 3600) + (m * 60) + s;
                    }

                    else if (userPlay == "t3")
                    {
                        timer4.Stop();//stop timer
                        total = (h * 3600) + (m * 60) + s;

                    }

                    //updated by makara 26-04-2016 / 10:00PM
                    //this.Close();

                    ResourceWriter sw = new ResourceWriter("TimerResult.resx");
                    sw.AddResource("totalTime", total.ToString());

                    sw.Close();
                    //MessageBox.Show("Result");
                    FormResult formResult = new FormResult();
                    formResult.ShowDialog();
                    return;



                    //MessageBox.Show("Result");
                    FormResult formResultTime = new FormResult();
                    // MessageBox.Show(xWin.ToString());
                    // MessageBox.Show(oWin.ToString());
                    formResultTime.ShowDialog();

                    return;

                }









            }
  
        //    labelPlayerMode.Visible = true;
            buttonNewgame.Text = "New Game";

         //   buttonPlayerMode.Visible = true;

            labelResult.Visible = true;
            labelBoardTitle.Visible = true;
            labelXvictory.Visible = true;
            labelXvictoryCount.Visible = true;
            labelOvictory.Visible = true;
            labelOvictoryCount.Visible = true;
            labelBoard.Visible = true;
            

            isPlaying = true;
            DrawBoard();
            ResetBoard();
            if (boardNumber == 0)
            {
                labelBoard.Text = "1";

            }
            else
            {
                labelBoard.Text = boardNumber.ToString();
            }
        }

        private void buttonPlayerMode_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();

            if (playerMode == 2) // change it to 3 player. 
            {
                playerMode = 3;
                labelPlayerMode.Text = ("3 players");

                labelResult.Visible = true;
                labelBoardTitle.Visible = true;
                labelXvictory.Visible = true;
                labelXvictoryCount.Visible = true;
                labelOvictory.Visible = true;
                labelOvictoryCount.Visible = true;
                labelPlusVictory.Visible = true;
                labelPlusVictoryCount.Visible = true;
                labelBoard.Visible = true;
                labelBoard.Text = "1";

                labelOvictory.Text = "Player 2";
                labelPlayer3.Visible = true;
                labelPlayer3.Text = "Player 3";

                // change the score to default
                xWin = 0; oWin = 0; plusWin = 0;
                labelXvictoryCount.Text = xWin.ToString();
                labelOvictoryCount.Text = oWin.ToString();
                labelPlusVictoryCount.Text = plusWin.ToString();

                /// working with picturebox 3
                pictureBox3.Visible = true;

                Random rd = new Random();
                int picture = rd.Next(0, 16);
                //  clear = picture;
                rd = null;

                if (picture == 1)
                {
                    pictureBox3.Image = Properties.Resources._1;
                }
                else if (picture == 2)
                {
                    pictureBox3.Image = Properties.Resources._2;
                }
                else if (picture == 3)
                {
                    pictureBox3.Image = Properties.Resources._3;
                }
                else if (picture == 4)
                {
                    pictureBox3.Image = Properties.Resources._4;
                }
                else if (picture == 5)
                {
                    pictureBox3.Image = Properties.Resources._5;
                }
                else if (picture == 6)
                {
                    pictureBox3.Image = Properties.Resources._6;
                }
                else if (picture == 7)
                {
                    pictureBox3.Image = Properties.Resources._7;
                }
                else if (picture == 8)
                {
                    pictureBox3.Image = Properties.Resources._8;

                }
                else if (picture == 9)
                {
                    pictureBox3.Image = Properties.Resources._9;
                }
                else if (picture == 10)
                {
                    pictureBox3.Image = Properties.Resources._10;
                }
                else if (picture == 11)
                {
                    pictureBox3.Image = Properties.Resources._11;
                }
                else if (picture == 12)
                {
                    pictureBox3.Image = Properties.Resources._12;
                }
                else if (picture == 13)
                {
                    pictureBox3.Image = Properties.Resources._13;
                }

                else if (picture == 14)
                {
                    pictureBox3.Image = Properties.Resources._14;
                }

                else if (picture == 15)
                {
                    pictureBox3.Image = Properties.Resources._15;
                }
                else
                {
                    pictureBox3.Image = Properties.Resources._16;
                }

                //// working with picturebox2

                 rd = new Random();
                 picture = rd.Next(0, 16);
                //  clear = picture;
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

                //// working with picturebox1

                rd = new Random();
                picture = rd.Next(0, 16);
                //  clear = picture;
                rd = null;

                if (picture == 1)
                {
                    pictureBox1.Image = Properties.Resources._1;
                }
                else if (picture == 2)
                {
                    pictureBox1.Image = Properties.Resources._2;
                }
                else if (picture == 3)
                {
                    pictureBox1.Image = Properties.Resources._3;
                }
                else if (picture == 4)
                {
                    pictureBox1.Image = Properties.Resources._4;
                }
                else if (picture == 5)
                {
                    pictureBox1.Image = Properties.Resources._5;
                }
                else if (picture == 6)
                {
                    pictureBox1.Image = Properties.Resources._6;
                }
                else if (picture == 7)
                {
                    pictureBox1.Image = Properties.Resources._7;
                }
                else if (picture == 8)
                {
                    pictureBox1.Image = Properties.Resources._8;

                }
                else if (picture == 9)
                {
                    pictureBox1.Image = Properties.Resources._9;
                }
                else if (picture == 10)
                {
                    pictureBox1.Image = Properties.Resources._10;
                }
                else if (picture == 11)
                {
                    pictureBox1.Image = Properties.Resources._11;
                }
                else if (picture == 12)
                {
                    pictureBox1.Image = Properties.Resources._12;
                }
                else if (picture == 13)
                {
                    pictureBox1.Image = Properties.Resources._13;
                }

                else if (picture == 14)
                {
                    pictureBox1.Image = Properties.Resources._14;
                }

                else if (picture == 15)
                {
                    pictureBox1.Image = Properties.Resources._15;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources._16;
                }




            }
            else if (playerMode == 3)// change it to 1 player
            {
                // change the score to default
                xWin = 0; oWin = 0; plusWin = 0;
                labelXvictoryCount.Text = xWin.ToString();
                labelOvictoryCount.Text = oWin.ToString();
                labelPlusVictoryCount.Text = plusWin.ToString();


                singleModeWinner = false;
                playerMode = 1;
                labelPlayerMode.Text = ("1 player");

                labelResult.Visible = true;
                labelBoardTitle.Visible = true;
                labelXvictory.Visible = true;
                labelXvictoryCount.Visible = true;
                labelOvictory.Visible = true;
                labelOvictoryCount.Visible = true;
                labelPlusVictory.Visible = false;
                labelPlusVictoryCount.Visible = false;
                labelBoard.Visible = true;
                labelBoard.Text = "1";

                labelOvictory.Text = "AI";

               // MessageBox.Show(singleModeLevel.ToString());
                OnePlayer();
                labelPlayer3.Visible = false;
                pictureBox3.Visible = false; 
                return;
            }
            else if (playerMode == 1)// change to 2 players
            {
                // change the score to default
                xWin = 0; oWin = 0; plusWin = 0;
                labelXvictoryCount.Text = xWin.ToString();
                labelOvictoryCount.Text = oWin.ToString();
                labelPlusVictoryCount.Text = plusWin.ToString();


                playerMode = 2;
                labelPlayerMode.Text = ("2 players");

                labelResult.Visible = true;
                labelBoardTitle.Visible = true;
                labelXvictory.Visible = true;
                labelXvictoryCount.Visible = true;
                labelOvictory.Visible = true;
                labelOvictoryCount.Visible = true;
                labelPlusVictory.Visible = false;
                labelPlusVictoryCount.Visible = false;
                labelBoard.Visible = true;
                labelBoard.Text = "1";

                labelOvictory.Text = "Player 2";

                pictureBox3.Visible = false;

                labelPlayer2.Text = "Player2";
                labelPlayer3.Visible = false;


                // change the score to default
                xWin = 0; oWin = 0; plusWin = 0;
                labelXvictoryCount.Text = xWin.ToString();
                labelOvictoryCount.Text = oWin.ToString();
                labelPlusVictoryCount.Text = plusWin.ToString();


                // working with picturebox1
                Random rd = new Random();
                int picture = rd.Next(0, 16);
                //  clear = picture;
                rd = null;

                if (picture == 1)
                {
                    pictureBox1.Image = Properties.Resources._1;
                }
                else if (picture == 2)
                {
                    pictureBox1.Image = Properties.Resources._2;
                }
                else if (picture == 3)
                {
                    pictureBox1.Image = Properties.Resources._3;
                }
                else if (picture == 4)
                {
                    pictureBox1.Image = Properties.Resources._4;
                }
                else if (picture == 5)
                {
                    pictureBox1.Image = Properties.Resources._5;
                }
                else if (picture == 6)
                {
                    pictureBox1.Image = Properties.Resources._6;
                }
                else if (picture == 7)
                {
                    pictureBox3.Image = Properties.Resources._7;
                }
                else if (picture == 8)
                {
                    pictureBox1.Image = Properties.Resources._8;

                }
                else if (picture == 9)
                {
                    pictureBox1.Image = Properties.Resources._9;
                }
                else if (picture == 10)
                {
                    pictureBox1.Image = Properties.Resources._10;
                }
                else if (picture == 11)
                {
                    pictureBox1.Image = Properties.Resources._11;
                }
                else if (picture == 12)
                {
                    pictureBox1.Image = Properties.Resources._12;
                }
                else if (picture == 13)
                {
                    pictureBox1.Image = Properties.Resources._13;
                }

                else if (picture == 14)
                {
                    pictureBox1.Image = Properties.Resources._14;
                }

                else if (picture == 15)
                {
                    pictureBox1.Image = Properties.Resources._15;
                }
                else
                {
                    pictureBox1.Image = Properties.Resources._16;
                }
                /// working with picturebox 2

                 rd = new Random();
                 picture = rd.Next(0, 16);
                //  clear = picture;
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
                    pictureBox1.Image = Properties.Resources._5;
                }
                else if (picture == 6)
                {
                    pictureBox1.Image = Properties.Resources._6;
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
            
            boardNumber = 0;
            buttonPlayerMode.Visible = true;
            isPlaying = true;
            DrawBoard();
            ResetBoard();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {

            ResourceSet rs = new ResourceSet("userChoise.resx");
            string s = rs.GetString("choise");
            char c=' ';
            if (s != "")
            {
                 c = s[0];
            }
            rs.Close();

            ResourceWriter sw = new ResourceWriter("userChoise.resx");
            sw.AddResource("game", "");
            sw.AddResource("choise", c.ToString());
            sw.Close();
            
            // delete items if directory temp


            string temp = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\temp";



            try
            {
                string source1 = temp + @"\save.txt";


                string source2 = temp + @"\avatar";

                string source3 = temp + @"\avatar1";
                string source4 = temp + @"\avatar2";
                string source5 = temp + @"\avatar3";
                if (File.Exists(source1))
                    File.Delete(source1);

                if (File.Exists(source2))
                    File.Delete(source2);

                if (File.Exists(source3))
                    File.Delete(source3);

                if (File.Exists(source4))
                    File.Delete(source4);

                if (File.Exists(source5))
                    File.Delete(source5);
            }
            catch 
            {

            }






            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelPlayer2_Click(object sender, EventArgs e)
        {

        }

        private void labelPlayer3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"loadGame"))
            {
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"loadGame");
            }
            MessageBox.Show("Save successfully ", "Tic Tac Toe 5 in a row");


            string loadGamePath = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame";

            

            int counter = 1;
            // 1. search to make a new directory
            while (counter < 1000)
            {
                loadGamePath = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame" + counter.ToString();

                if (System.IO.Directory.Exists(loadGamePath))
                {
                    counter++;
                }
                else
                {
                    System.IO.Directory.CreateDirectory(loadGamePath);
                    break;
                }
            }
            //1. copy the avatars
            if (userPlay == "c1")
            {
                pictureBox2.Image.Save(loadGamePath+@"\AI");


                string save = "";
                for (int i = 1; i <= totalRow; ++i)
                {
                    for (int j = 1; j <= totalColumn; ++j)
                    {
                        if (Movement[i, j] == 1)// it is x
                        {
                            save = save + Movement[i, j].ToString();
                        }
                        else if (Movement[i, j] == -1)// it is o
                        {
                            save = save + "2";
                        }
                        else if (Movement[i, j] == 10)// it is +
                        {
                            save = save + "3";
                        }
                        else if (Movement[i, j] == 0) // is is free
                        {
                            save = save + "0";
                        }
                       // save = save + " ";
                    }
                    save = save + "\r\n";
                }

                FileStream save1 = new FileStream
                                           (loadGamePath + @"\board.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                StreamWriter fw = new StreamWriter(save1);
                fw.Write(save);
                fw.Close();

                string info = "";
                info += userPlay; // userplay
                info += "\r\n";
                info += labelPlayer1.Text; // player's name
                info += "\r\n";
                info += singleModeLevel.ToString(); // level of AI
                info += "\r\n";
                info += xWin.ToString(); // victory of player
                info += "\r\n";
                info += oWin.ToString(); // victory of AI
                info += "\r\n";
                info += boardNumber.ToString(); // current board's number
                info += "\r\n";

                FileStream save2 = new FileStream
                                          (loadGamePath + @"\info.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                StreamWriter fw2 = new StreamWriter(save2);
                fw2.Write(info);
                fw2.Close();

                string avatar = loadGamePath + @"\avatar";
                pictureBox1.Image.Save(avatar);

            }
            else if (userPlay == "c2")
            {
                string save = "";
                for (int i = 1; i <= totalRow; ++i)
                {
                    for (int j = 1; j <= totalColumn; ++j)
                    {
                        if (Movement[i, j] == 1)// it is x
                        {
                            save = save + Movement[i, j].ToString();
                        }
                        else if (Movement[i, j] == -1)// it is o
                        {
                            save = save + "2";
                        }
                        else if (Movement[i, j] == 10)// it is +
                        {
                            save = save + "3";
                        }
                        else if (Movement[i, j] == 0) // is is free
                        {
                            save = save + "0";
                        }
                        //save = save + " ";
                    }
                    save = save + "\r\n";
                }
                // save the player turn
                save += turnIn2PlayerMode.ToString();

                FileStream save1 = new FileStream
                                           (loadGamePath + @"\board.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                StreamWriter fw = new StreamWriter(save1);
                fw.Write(save);
                fw.Close();

                string info = "";
                info += userPlay; // userplay
                info += "\r\n";
                info += labelPlayer1.Text; // player1's name
                info += "\r\n";
                info += labelPlayer2.Text; // player2's name
                info += "\r\n";
                info += xWin.ToString(); // victory of player1
                info += "\r\n";
                info += oWin.ToString(); // victory of player2
                info += "\r\n";
                info += boardNumber.ToString(); // current board's number
                info += "\r\n";
                
                FileStream save2 = new FileStream
                                          (loadGamePath + @"\info.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                StreamWriter fw2 = new StreamWriter(save2);
                fw2.Write(info);
                fw2.Close();

                string avatar1 = loadGamePath + @"\avatar1";
                pictureBox1.Image.Save(avatar1);
                string avatar2 = loadGamePath + @"\avatar2";
                pictureBox2.Image.Save(avatar2);

            }
            else if (userPlay == "c3")
            {
                string save = "";
                for (int i = 1; i <= totalRow; ++i)
                {
                    for (int j = 1; j <= totalColumn; ++j)
                    {
                        if (Movement[i, j] == 1)// it is x
                        {
                            save = save + Movement[i, j].ToString();
                        }
                        else if (Movement[i, j] == -1)// it is o
                        {
                            save = save + "2";
                        }
                        else if (Movement[i, j] == 10)// it is +
                        {
                            save = save + "3";
                        }
                        else if (Movement[i, j] == 0) // is is free
                        {
                            save = save + "0";
                        }
                        //save = save + " ";
                    }
                    save = save + "\r\n";
                }
                save += turnIn3PlayerMode.ToString();

                FileStream save1 = new FileStream
                                           (loadGamePath + @"\board.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                StreamWriter fw = new StreamWriter(save1);
                fw.Write(save);
                fw.Close();

                string info = "";
                info += userPlay; // userplay
                info += "\r\n";
                info += labelPlayer1.Text; // player1's name
                info += "\r\n";
                info += labelPlayer2.Text; // player2's name
                info += "\r\n";
                info += labelPlayer3.Text; // player2's name
                info += "\r\n";
                info += xWin.ToString(); // victory of player1
                info += "\r\n";
                info += oWin.ToString(); // victory of player2
                info += "\r\n";
                info += plusWin.ToString(); //victory of player3
                info += "\r\n";
                info += boardNumber.ToString(); // current board's number

                FileStream save2 = new FileStream
                                          (loadGamePath + @"\info.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                StreamWriter fw2 = new StreamWriter(save2);
                fw2.Write(info);
                fw2.Close();

                string avatar1 = loadGamePath + @"\avatar1";
                pictureBox1.Image.Save(avatar1);
                string avatar2 = loadGamePath + @"\avatar2";
                pictureBox2.Image.Save(avatar2);
                string avatar3 = loadGamePath + @"\avatar3";
                pictureBox3.Image.Save(avatar3);
            }
            if (userPlay == "t1")
            {
                int totalTimeSave = h * 3600 + m * 60 + s;

                string save = "";
                for (int i = 1; i <= totalRow; ++i)
                {
                    for (int j = 1; j <= totalColumn; ++j)
                    {
                        if (Movement[i, j] == 1)// it is x
                        {
                            save = save + Movement[i, j].ToString();
                        }
                        else if (Movement[i, j] == -1)// it is o
                        {
                            save = save + "2";
                        }
                        else if (Movement[i, j] == 10)// it is +
                        {
                            save = save + "3";
                        }
                        else if (Movement[i, j] == 0) // is is free
                        {
                            save = save + "0";
                        }
                        // save = save + " ";
                    }
                     save = save + "\r\n";
                }
                FileStream save1 = new FileStream
                                           (loadGamePath + @"\board.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                StreamWriter fw = new StreamWriter(save1);
                fw.Write(save);
                fw.Close();

                string info = "";
                info += userPlay; // userplay
                info += "\r\n";
                info += labelPlayer1.Text; // player's name
                info += "\r\n";
                info += singleModeLevel.ToString(); // level of AI
                info += "\r\n";
                info += xWin.ToString(); // victory of player
                info += "\r\n";
                info += oWin.ToString(); // victory of AI
                info += "\r\n";
                info += boardNumber.ToString(); // current board's number
                info += "\r\n";
                info += totalTimeSave.ToString(); //time
                info += "\r\n";

                FileStream save2 = new FileStream
                                          (loadGamePath + @"\info.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                StreamWriter fw2 = new StreamWriter(save2);
                fw2.Write(info);
                fw2.Close();

                string avatar = loadGamePath + @"\avatar";
                pictureBox1.Image.Save(avatar);
            }
            else if (userPlay == "t2")
            {

            }
            else if (userPlay == "t3")
            {

            }













            return;


            /*  int[,] ex = new int[18, 23];
            // init the value
            for (int i = 1; i <= totalRow; ++i)
            {
                for (int j = 1; j <= totalColumn; ++j)
                {
                   // ex [i, j] = 0;

                }

            }
            */
            ResourceSet rs = new ResourceSet("userChoise.resx");

            string choise = rs.GetString("choise");
            string savePath = rs.GetString("game");
            rs.Close();


            //   MessageBox.Show(choise);



            string temp = AppDomain.CurrentDomain.BaseDirectory + @"\temp";
            if (choise == "c1")
            {
                string source1 = temp + @"\save.txt";
                string dest1 = savePath + @"\save.txt";
                File.Copy(source1, dest1, true);

                string source2 = temp + @"\avatar";
                string dest2 = savePath + @"\avatar";
                File.Copy(source2, dest2, true);

            }

            else if (choise == "c2")
            {
                // MessageBox.Show(savePath);

                string source1 = temp + @"\save.txt";
                string dest1 = savePath + @"\save.txt";
                File.Copy(source1, dest1, true);

                string source2 = temp + @"\avatar1";
                string dest2 = savePath + @"\avatar1";
                File.Copy(source2, dest2, true);

                string source3 = temp + @"\avatar2";
                string dest3 = savePath + @"\avatar2";
                File.Copy(source3, dest3, true);


            }

            else if (choise == "c3")
            {
                string source1 = temp + @"\save.txt";
                string dest1 = savePath + @"\save.txt";
                File.Copy(source1, dest1, true);

                string source2 = temp + @"\avatar1";
                string dest2 = savePath + @"\avatar1";
                File.Copy(source2, dest2, true);

                string source3 = temp + @"\avatar2";
                string dest3 = savePath + @"\avatar2";
                File.Copy(source3, dest3, true);

                string source4 = temp + @"\avatar3";
                string dest4 = savePath + @"\avatar3";
                File.Copy(source4, dest4, true);


            }
            else if (choise == "t1")
            {
                string source1 = temp + @"\save.txt";
                string dest1 = savePath + @"\save.txt";
                File.Copy(source1, dest1, true);

                string source2 = temp + @"\avatar";
                string dest2 = savePath + @"\avatar";
                File.Copy(source2, dest2, true);


            }
            else if (choise == "t2")
            {

                string source1 = temp + @"\save.txt";
                string dest1 = savePath + @"\save.txt";
                File.Copy(source1, dest1, true);

                string source2 = temp + @"\avatar1";
                string dest2 = savePath + @"\avatar1";
                File.Copy(source2, dest2, true);

                string source3 = temp + @"\avatar2";
                string dest3 = savePath + @"\avatar2";
                File.Copy(source3, dest3, true);

            }
            else if (choise == "t3")
            {
                string source1 = temp + @"\save.txt";
                string dest1 = savePath + @"\save.txt";
                File.Copy(source1, dest1, true);

                string source2 = temp + @"\avatar1";
                string dest2 = savePath + @"\avatar1";
                File.Copy(source2, dest2, true);

                string source3 = temp + @"\avatar2";
                string dest3 = savePath + @"\avatar2";
                File.Copy(source3, dest3, true);

                string source4 = temp + @"\avatar3";
                string dest4 = savePath + @"\avatar3";
                File.Copy(source4, dest4, true);

            }





        }

        private void FormPlayBoard_FormClosing(object sender, FormClosingEventArgs e)
        {

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
                    }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void RefreshBoard()
        {
            pictureBox1.Focus();
            buttonRefresh.Text = "Refresh";
            if (isPlaying == false) return;
            DrawBoard();

            for (int i = 1; i <= totalRow; ++i)
            {
                for (int j = 1; j <= totalColumn; ++j)
                {
                    if (Movement[i, j] == 1)
                    {
                        Xsymbol(i, j);

                    }
                    else if (Movement[i, j] == -1)
                    {
                        Osymbol(i, j);

                    }
                    else if (Movement[i, j] == 10)
                    {

                        PlusSymbol(i, j);
                    }

                }
                isDraw = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshBoard();
        }// end of function

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            s = s++;
            {
                s = s + 1;
                if (s == 60)
                {
                    m = m + 1;
                    s = 0;
                }
                if (m == 60)
                {
                    h = h + 1;
                    m = 0;
                }
            }
            string hh = Convert.ToString(h);
            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);

            label3.Text = hh;
            label4.Text = mm;
            label5.Text = ss;

        }

        private int StringToInt(string num)
        {
            try
            {
                if (num == "")
                {
                    return -1;
                }
                int theValue = 0;
                int theSize = num.Count();
                char temp = num[0];
                int time = 0;
                for (int i = 0; i < num.Count(); ++i)
                {
                    time = num.Count() - i - 1;
                    temp = num[i];
                    if (temp == '0')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 0 * thePow;
                    }
                    else if (temp == '1')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 1 * thePow;
                    }
                    else if (temp == '2')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 2 * thePow;
                    }
                    else if (temp == '3')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 3 * thePow;
                    }
                    else if (temp == '4')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 4 * thePow;
                    }
                    else if (temp == '5')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 5 * thePow;
                    }
                    else if (temp == '6')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 6 * thePow;
                    }
                    else if (temp == '7')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 7 * thePow;
                    }
                    else if (temp == '8')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 8 * thePow;
                    }
                    else if (temp == '9')
                    {
                        int thePow = 1;
                        for (int k = 1; k <= time; ++k)
                        {
                            thePow = thePow * 10;
                        }
                        theValue += 9 * thePow;
                    }
                }



                return theValue;
            }
            catch
            {
                return 0;
            }


        }







        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>






    }
}
