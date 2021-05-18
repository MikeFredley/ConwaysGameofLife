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

/********************************************************************
 Michael Fredley
 CIS 244 Dr. Strausser
 The Game Of Life
 Creates and removes cells depending on a certain set of rules
 to simulate how life may grow and decay
*********************************************************************/

namespace Fredley_GOL
{
    public partial class GOLBoard : Form
    {
        // Class level variables 
        private Graphics gr;
        private Pen pen;
        private Brush brush;
        public Random gen;

        public const int RECT_HEIGHT = 20;
        public const int RECT_WIDTH = 20;
        public const int ROWS = 42;
        public const int COLS = 62;
        private int aliveCells, deadCells, yellowCells, blueCells, greenCells, magentaCells, redCells, genNum;

        private GOLCell[,] board;

        public GOLBoard()
        {
            InitializeComponent();
            // Creates graphics on the panel
            gr = panGrid.CreateGraphics();

            // Instantiates the pen and makes it black
            pen = new Pen(System.Drawing.Color.Black);

            // Creates the fill color for the rectangle
            brush = new SolidBrush(Color.White);

            // Instantiates the 2D array with the amount of rows and columns
            board = new GOLCell[ROWS, COLS];
            gen = new Random();
        }

        /*********************************************
         * This section deals with counting the cells
         * and determining their futurestate and age
         * *******************************************/

        // Generates random ones and zeros
        // If it is one it is alive
        // If it is zero it is not alive
        public int randomCellLife()
        {
            return gen.Next(0, 2);
        }

        // Determines how many cells are alive around a given cell
        private void cellCount()
        {
            for (int i = 1; i < ROWS - 1; i++)
            {
                for (int j = 1; j < COLS - 1; j++)
                {
                    board[i, j].CellCount = board[i - 1, j - 1].IsAlive + board[i - 1, j].IsAlive + board[i - 1, j + 1].IsAlive +
                            board[i, j - 1].IsAlive + board[i, j + 1].IsAlive + board[i + 1, j - 1].IsAlive +
                            board[i + 1, j].IsAlive + board[i + 1, j + 1].IsAlive;
                }
            }
            for (int i = 1; i < ROWS - 1; i++)
            {
                for (int j = 1; j < COLS - 1; j++)
                {
                    // This will change the future state and whether or not a cell is alive depending on how many are around it
                    determineCellLife(i, j);
                }
            }
        }

        /**************************************************
         * Determines the futurestate and age of the cell
         * depending on the count
         * *************************************************/

        public void determineCellLife(int i, int j)
        {
            // If the cell is 2 or 3 it will age
            if (board[i,j].IsAlive==1 && (board[i, j].CellCount == 2 || board[i, j].CellCount == 3))
            {
                board[i, j].FutureState = 1;
            }
            else if (board[i,j].IsAlive==1 && (board[i,j].CellCount < 2 || board[i,j].CellCount > 3))  // If the cell has more than 3 or less than 2 it will die
            {
                board[i, j].FutureState = 2;
            }
            // If the cell is dead and has 3 around it it will be born
            else if (board[i, j].IsAlive == 0 && board[i, j].CellCount == 3)
            {
                board[i, j].FutureState = 3;
            }

            // Changes the age and whether or not it is alive depending on its future state
            switch (board[i, j].FutureState)
            {
                case 1:
                    board[i, j].Age += 1;
                    break;
                case 2:
                    board[i, j].IsAlive = 0;
                    board[i, j].Age = -1;
                    break;
                case 3:
                    board[i, j].IsAlive = 1;
                    board[i, j].Age = 0;
                    break;
            }

            // I was having bugs so I added this if statement to double check the age of dead cells
            if (board[i, j].IsAlive == 0)
            {
                board[i, j].Age = -1;
            }
            board[i, j].FutureState = 0;  
        }

        /****************************************
         * Counts which cells are alive and dead
         * and how many of each color
         * **************************************/


        // This counts the amount of different cells within the grid
        public void countCells()
        {
            for(int i = 1; i < ROWS - 1; i++)
            {
                for (int j = 1; j < COLS - 1; j++)
                {
                    // Counts the total alive and dead cells
                    if (board[i,j].IsAlive == 0)
                    {
                        deadCells++;
                    }
                    else
                    {
                        aliveCells++;
                    }
                    // Counts the alive cells depending on age
                    if (board[i,j].Age == 0 && board[i,j].IsAlive == 1)
                    {
                        yellowCells++;
                    }
                    else if(board[i,j].Age == 1)
                    {
                        greenCells++;
                    }
                    else if(board[i,j].Age == 2)
                    {
                        blueCells++;
                    }
                    else if (board[i,j].Age == 3)
                    {
                        magentaCells++;
                    }
                    else
                    {
                        if (board[i,j].IsAlive == 1)
                        {
                            redCells++;
                        } 
                    }
                    // Updates labels
                    lblAlive.Text = "Alive: " + aliveCells;
                    lblYellow.Text = "Yellow Cells: " + yellowCells;
                    lblGreen.Text = "Green Cells: " + greenCells;
                    lblBlue.Text = "Blue Cells: " + blueCells;
                    lblMagenta.Text = "Magenta Cells: " + magentaCells;
                    lblRed.Text = "Red Cells: " + redCells;
                    lblDead.Text = "Dead: " + deadCells;
                    lblGeneration.Text = "Generation: " + genNum;
                }
            }
        }

        /********************************************
         * Creates a blank or random grid
         * depending on the true and false parameter
         * ******************************************/

        public void createGrid(bool genRandom)
        {
            int alive;
            // Nested for loops to navigate the 2D array
            for(int i = 0; i < ROWS; i++)
            {
                for(int j = 0; j < COLS; j++)
                {
                    // Creates a rectangle
                    Rectangle aRectangle = new Rectangle(j * RECT_WIDTH, i * RECT_HEIGHT, RECT_WIDTH, RECT_HEIGHT);

                    // Makes the rectangle color to the color set on the brush
                    gr.FillRectangle(brush, aRectangle);

                    // Draws the rectangle with the outline color of the pen
                    gr.DrawRectangle(pen, aRectangle);

                    if (genRandom == false)
                    {
                        alive = 0;
                    }
                    else
                    {
                        alive = randomCellLife();
                    }

                    // Creates GOLCell object
                    board[i, j] = new GOLCell();

                    // Add the GOLCell object to the 2D Array
                    board[i, j].Rect = aRectangle;
                    board[i, j].IsAlive = alive;
                    

                    
                }
            }
        }

        /******************************************
         * Method to update the grid of different
         * colors depending on the age of the cell
         * ****************************************/

        // Updates the grid of new cells after every time it calculates
        public void updateGrid()
        {
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush magentaBrush = new SolidBrush(Color.Magenta);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            // Clears Grid
            panGrid.Controls.Clear();

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                  
                    if (board[i, j].IsAlive == 0)
                    {
                        gr.FillRectangle(whiteBrush, board[i,j].Rect);
                    }
                    else
                    {
                        // Changes the color depending on the age of the cell
                        switch (board[i, j].Age)
                        {
                  
                            case 0:
                                gr.FillRectangle(yellowBrush, board[i, j].Rect);
                                break;
                            case 1:
                                gr.FillRectangle(greenBrush, board[i, j].Rect);
                                break;
                            case 2:
                                gr.FillRectangle(blueBrush, board[i, j].Rect);
                                break;
                            case 3:
                                gr.FillRectangle(magentaBrush, board[i, j].Rect);
                                break;
                            case 4:
                                gr.FillRectangle(redBrush, board[i, j].Rect);
                                break;
                        }
                    }

                    //Draws rectangle
                    gr.DrawRectangle(pen, board[i, j].Rect);

                }
            }
            countCells();
            // Resets the counts back to 0
            aliveCells = 0;
            deadCells = 0;
            yellowCells = 0;
            greenCells = 0;
            blueCells = 0;
            magentaCells = 0;
            redCells = 0;
        }

        private void btnShowGrid_Click(object sender, EventArgs e)
        {
          // Calls create grid method and creates empty grid
           createGrid(false);
        }

        /**********************************************
       * Methods and buttons for inserting the 
       * pulsar, beacon, and infinite growth shapes
       * ********************************************/


        // Method to create a pulsar shape in the middle of the grid
        private void Pulsar()
        {
            // Pulsar array
            int[,] pulsar = new int[13, 13] { {0,0,1,1,1,0,0,0,1,1,1,0,0},
                                              {0,0,0,0,0,0,0,0,0,0,0,0,0},
                                              {1,0,0,0,0,1,0,1,0,0,0,0,1},
                                              {1,0,0,0,0,1,0,1,0,0,0,0,1},
                                              {1,0,0,0,0,1,0,1,0,0,0,0,1},
                                              {0,0,1,1,1,0,0,0,1,1,1,0,0},
                                              {0,0,0,0,0,0,0,0,0,0,0,0,0},
                                              {0,0,1,1,1,0,0,0,1,1,1,0,0},
                                              {1,0,0,0,0,1,0,1,0,0,0,0,1},
                                              {1,0,0,0,0,1,0,1,0,0,0,0,1},
                                              {1,0,0,0,0,1,0,1,0,0,0,0,1},
                                              {0,0,0,0,0,0,0,0,0,0,0,0,0},
                                              {0,0,1,1,1,0,0,0,1,1,1,0,0}
            };
            // calls the creategrid method to create a fresh grid
            createGrid(false);

            // Uses the pulsar array to set the isalive variable in the board to 1 or 0 depending on position
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (pulsar[i, j] == 1)
                    {
                        board[i + 15, j + 25].IsAlive = 1;
                        board[i + 15, j + 25].Age = 0;


                    }
                    else
                    {
                        board[i + 15, j + 25].IsAlive = 0;
                        board[i + 15, j + 25].Age = -1;
                    }
                }
            }
            // Calls updategrid method to add the updated board cells onto the board
            updateGrid();
        }

        // Method to create the beacon shape within the board
        private void Beacon()
        {
            // Beacon array
            int[,] beacon = new int[4, 4] { {1,1,0,0},
                                            {1,1,0,0},
                                            {0,0,1,1},
                                            {0,0,1,1}
            };
            // calls the creategrid method to create a fresh grid
            createGrid(false);

            // Uses the beacon array to set the isalive variable in the board to 1 or 0 depending on position
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (beacon[i, j] == 1)
                    {
                        board[i + 20, j + 35].IsAlive = 1;
                    }
                    else
                    {
                        board[i + 20, j + 35].IsAlive = 0;
                    }
                }
            }
            // Calls updategrid method to add the updated board cells onto the board
            updateGrid();
        }

        // Method for the infinite growth taste
        private void InfGrowth()
        {
            int[,] growth = new int[1, 29] { { 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 } };

            createGrid(false);

            // Reads growth array
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    if (growth[i, j] == 1)
                    {
                        board[i + 20, j + 20].IsAlive = 1;
                    }
                    else
                    {
                        board[i + 20, j + 20].IsAlive = 0;
                    }
                }
            }
            updateGrid();
        }

        // Pulsar button
        private void btnPulsar_Click(object sender, EventArgs e)
        {
            genNum = 0;
            Pulsar();
            btnStart.Enabled = true;
            txtTime.Enabled = true;
            btnSave.Enabled = true;
        }

        // Infinite growth button
        private void btnGrowth_Click(object sender, EventArgs e)
        {
            genNum = 0;
            InfGrowth();
            btnStart.Enabled = true;
            txtTime.Enabled = true;
            btnSave.Enabled = true;
        }

        // Beacon button
        private void btnBeacon_Click(object sender, EventArgs e)
        {
            genNum = 0;
            Beacon();
            btnStart.Enabled = true;
            txtTime.Enabled = true;
            btnSave.Enabled = true;
        }

        /********************************
         * Button and method to save
         *         a file
         * ******************************/
  
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        // Save method
        private void Save()
        {

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save Your File";
            saveDialog.Filter = "Text File | *.txt";

            // Checks 
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveDialog.OpenFile());

                // Writes whether or not the cell is alive into a file
                for (int i = 0; i < ROWS; i++)
                {
                    for (int j = 0; j < COLS; j++)
                    {
                        writer.Write(board[i, j].IsAlive + " ");
                    }
                    writer.WriteLine();
                }
                writer.Close();
            }
        }

        /*******************************************
         *  Area to load a file that has been saved
         *  into the program
         * ****************************************/

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Loadfile();
        }

        // Method to load a file
        private void Loadfile()
        {
            OpenFileDialog loadDialog = new OpenFileDialog();
            loadDialog.Title = "Load a File";
            loadDialog.Filter = "Text File | *.txt";
            if (loadDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(loadDialog.OpenFile());
                createGrid(false);

                // Reads each line of the file and changes whether or not the cell is alive
                int row = 0;
                while (!reader.EndOfStream)
                {
                   
                    string readLine = reader.ReadLine();
                    string[] text = readLine.Split(' ');

                    for (int j = 0; j < (text.Length-1); j++)
                    {
                        
                        board[row, j].IsAlive = int.Parse(text[j]);
                        board[row, j].Age = 0;
                        board[row, j].FutureState = 0;
                    }
                    row++;
                }
                updateGrid();
            }
        }

        /*************************************
         * Method that handles hovering over
         * the grid to see your coordinates
         * **********************************/

        private void panGrid_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoord.Text = String.Format("I: {1}; J: {0}", e.X / RECT_WIDTH, e.Y / RECT_HEIGHT);
        }

      

        /*********************************
         * Everything that has to do with
         * the start button is below this
         * ******************************/

        private void btnStart_Click(object sender, EventArgs e)
        {
            getTime();   
        }

        // Gets the number value out of the textbox to start the program
        private void getTime()
        {
            int num = 0;
            string number = txtTime.Text;

            bool check = int.TryParse(number, out num);

            if (number == "" || check == false)
            {
                MessageBox.Show("Please enter a valid number.");
            }
            else
            {
                // Runs the program the amount of specified times in the textbox 
                for (int k = 0; k < num; k++)
                {
                    lstTest.Items.Clear();
                    // Counts number of generations
                    genNum++;
                    cellCount();
                    updateGrid();
                }
            }
        }

        /************************
         * button for generating
         * a random grid
         * *******************/
         private void btGenRandom_Click(object sender, EventArgs e)
        {
            // Creates grid with randomly generated cells
            createGrid(true);

            // Resets the counts back to 0
            aliveCells = 0;
            deadCells = 0;
            yellowCells = 0;
            greenCells = 0;
            blueCells = 0;
            magentaCells = 0;
            redCells = 0;
            
            // Updates the grid with the random alive cells
            updateGrid();

            // Enables the start button textbox and save button
            btnStart.Enabled = true;
            txtTime.Enabled = true;
            btnSave.Enabled = true;
        }
    }
}
