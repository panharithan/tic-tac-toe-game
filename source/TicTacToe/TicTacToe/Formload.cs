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
    public partial class Formload : Form
    {


        const int lengthOfBoard = 880;
        const int heighOfBoard = 680;
        const int lengthOfGrid = 40;
        const int totalRow = heighOfBoard / lengthOfGrid;
        const int totalColumn = lengthOfBoard / lengthOfGrid;
        int x, y;
        bool isPlaying = false;

        int[,] Movement = new int[18, totalColumn + 1]; // we will now use zero-indexes
        int[,] defend = new int[18, totalColumn + 1];



        //---------------------------------------
        public Formload()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string loadGamePath = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame";


            int counter = 1;
         
                loadGamePath = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame" + counter.ToString();
                string save = "";
                if (System.IO.Directory.Exists(loadGamePath))
                {
                    loadGamePath += @"\info.txt";
                   // MessageBox.Show(loadGamePath);
                   // return;
                 /*   string[] st = new string [4];
                    for (int i=0;i<4;++i)
                    {


                    StreamReader sr = new StreamReader(loadGamePath);
                    st[i] = sr.ReadLine();
                    textBox1.Text = save;
                    sr.Close();
                    }


                    MessageBox.Show(st[2]);
                    */
                     string f = loadGamePath;

                    // 1
                    // Declare new List.
                    List<string> lines = new List<string>();

                    // 2
                    // Use using StreamReader for disposing.
                    using (StreamReader r = new StreamReader(f))
                    {
                        // 3
                        // Use while != null pattern for loop
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            // 4
                            // Insert logic here.
                            // ...
                            // "line" is a line in the file. Add it to our List.
                            lines.Add(line);
                        }
                    }
                    MessageBox.Show(lines.Count().ToString());
                    // 5
                    // Print out all the lines.
                    foreach (string s in lines)
                    {
                        //Console.WriteLine(s);
                        //MessageBox.Show(s);
                    }

                    return;
                }
                else
                {
                    System.IO.Directory.CreateDirectory(loadGamePath);
                }

                char[] grid = new char[ totalColumn * totalRow + 1] ;


                int p = 0;
                int c = 0;

                for (p = 1; p <= totalRow * totalColumn; p++)
                {
                    grid[p] = save[p - 1];


                }
             //   MessageBox.Show(grid[2].ToString());



                for (p = 1; p <= totalRow * totalColumn; p++)
                {

                   /* int m = p % totalColumn;
                    int n = p / totalColumn;
                 //   if (m > 17) continue;
                 //   if (n > 22) continue;
                    if (grid[p] == '0')
                    {
                        Movement[m, n] = 0;
                        defend[m, n] = 0;
                    }
                    else if (grid[p] == '1')
                    {
                        Movement[m, n] = 1;
                        defend[m, n] = 0;

                    }
                    else if (grid[p] == '2')
                    {
                    //    MessageBox.Show("Hello girl");
                        Movement[m, n] = -1;
                        defend[m, n] = 1;
                    }
                    else if (grid[p] == '3')
                    {
                        Movement[m, n] = 10;
                        defend[m, n] = 1;
                    }
                    else
                    {
                        //  MessageBox.Show("hello " + p.ToString());
                        break;
                    }




                    */
                    int remain = p % totalColumn ;




                    if (remain != 0)
                    {
                        c++;

                        int r = 1 + remain;
                       // if (r > 17) continue;
                       // int c = p - ((p % totalRow) * totalRow);

                        if (grid[p] == '0')
                        {
                            Movement[r, c] = 0;
                            defend[r, c] = 0;
                        }
                        else if (grid[p] == '1')
                        {
                            Movement[r, c] = 1;
                            defend[r, c] = 0;

                        }
                        else if (grid[p] == '2')
                        {

                            Movement[r, c] = -1;
                            defend[r, c] = 1;
                        }
                        else if (grid[p] == '3')
                        {
                            Movement[r, c] = 10;
                            defend[r, c] = 1;
                        }
                        else
                        {
                          //  MessageBox.Show("hello " + p.ToString());
                            break;
                        }
                    }
                    else if (remain==0)
                    {
                        int r = p % totalColumn;
                         c = totalColumn;

                         if (grid[p] == '0')
                        {
                            Movement[r, c] = 0;
                            defend[r, c] = 0;
                        }
                         else if (grid[p] == '1')
                        {
                          //  MessageBox.Show("h " + p.ToString());

                            Movement[r, c] = 1;
                            defend[r, c] = 0;

                        }
                         else if ( grid[p] == '2')
                        {
                          //  MessageBox.Show("h " + p.ToString());


                            Movement[r, c] = -1;
                            defend[r, c] = 1;
                        }
                        else if (grid[p]  == '3')
                        {
                          //  MessageBox.Show("h " + p.ToString());

                            Movement[r, c] = 10;
                            defend[r, c] = 1;
                        }
                        else
                        {
                          //  MessageBox.Show("hello " + p.ToString());

                            break;
                        }


                        c = 0;

                    }




                }
                    
                    MessageBox.Show(save[2].ToString());
                    MessageBox.Show(Movement[1, 2].ToString());

                


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string loadGamePath = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame";


            int counter = 1;

            loadGamePath = AppDomain.CurrentDomain.BaseDirectory + @"loadGame\loadGame" + counter.ToString();
            string save = "";
            if (System.IO.Directory.Exists(loadGamePath))
            {
                try
                {
                    loadGamePath += @"\info.txt";
                    // MessageBox.Show(loadGamePath);
                    // return;
                    StreamReader sr = new StreamReader(loadGamePath);

                    // save = sr.ReadLine();

                    // textBox1.Text = save;
                    string[] lines = System.IO.File.ReadAllLines(loadGamePath);
                    MessageBox.Show(lines[0]);


                    sr.Close();
                }
                catch
                {
                    MessageBox.Show("Load game cannot be found");
                }




            }
            else
            {
                System.IO.Directory.CreateDirectory(loadGamePath);
            }


        }
    }
}
