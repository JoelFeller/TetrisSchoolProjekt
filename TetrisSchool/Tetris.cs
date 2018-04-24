using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;

namespace TetrisSchool
{
    /// Main form for the Tetris game
    public partial class Tetris : Form
    {
        private bool playing { get; set; }
        private static int cellSize = 31;
        private static int numRows = 18;
        private static int numCols = 10;
        private int baseTickInterval = 500;
        private int currentTickInterval;
        private int highScore;
        //private int currentLevel;
        private Board board;
        private KeyboardInput input = new KeyboardInput();
        private Dictionary<string, Cell> boardCells = new Dictionary<string, Cell>();
        
        /// Default contructor for the Tetris class
        public Tetris()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.highScore = 0;
            this.textBoxHighScore.Text = this.highScore.ToString();
            this.currentTickInterval = this.baseTickInterval;
            this.board = new Board();
            this.drawBackgroundBoard();
            
        }
        
        /// Draws the empty Tetris board
        private void drawBackgroundBoard()
        {
            foreach (KeyValuePair<string, Cell> c in boardCells)
            {
                c.Value.Dispose();
            }
            boardCells.Clear();

            for ( int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    Cell cell = new Cell(row, col);
                    cell.Parent = gameGrid;
                    cell.Top = row * cellSize;
                    cell.Left = col * cellSize;
                    boardCells.Add(cellKey(row, col), cell);
                }
            }    
        }
        
        /// Creates a string value from 2 int
        private string cellKey(int reihe, int spalte)
        {
            return reihe.ToString() + ", " + spalte.ToString();
        }
        
        /// Starts the game
        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.reset();
        }
        
        /// Resets the game
        private void reset()
        {
            this.resetTextFields();
            this.board = new Board();
            //this.currentLevel = board.currentLevel;
            this.playing = true;
            this.gameTick.Interval = this.baseTickInterval;
            this.gameTick.Enabled = true;            
        }

        private void resetTextFields()
        {
            this.textBoxScore.Text = "0";
            this.textBoxRowsCompleted.Text = "0";
            this.labelGameOver.Text = "";
        }
        
        /// Game timer
        private void gameTick_Tick(object sender, EventArgs e)
        {
            if (playing)
            {
                buttonStart.Enabled = false;
                if (!board.tick())
                    this.gameOver();
                this.updateGameBoard();
                this.updateTextFields();
                //this.checkLevelUp();
            }
        }
        
        /// Updates the different text fields in the game
        private void updateTextFields()
        {
            this.textBoxScore.Text = this.board.score.ToString();
            this.textBoxRowsCompleted.Text = this.board.reiheBeendet.ToString();         
        }
        
        /// Checks for level up and increases the game speed
        //private void checkLevelUp()
        //{
        //    if (this.board.currentLevel > this.currentLevel)
        //    {
        //        this.currentLevel = this.board.currentLevel;
        //        
        //        double newinterval = this.tickTimer.Interval;
        //        newinterval *= 0.75;
        //        this.tickTimer.Interval = (int)newinterval;
        //        this.currentTickInterval = this.tickTimer.Interval;
        //    }
        //}
        
        /// Increases the game level and speed when the Home key is pressed
        //private void increaseGameLevel()
        //{
        //    this.board.currentLevel++;
        //}
        
        /// Redraws the board from its current state
        private void updateGameBoard()
        {
            Cell cell;
            for ( int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    boardCells.TryGetValue(cellKey(row, col), out cell);
                    cell.cellColor = board.grid[row, col];
                }
            }
            Block block = board.momentanerBlock;
            for (int row = 0; row < block.momBlock.GetLength(0); row++)
            {
                for (int col = 0; col < block.momBlock.GetLength(1); col++)
                {
                    Coordinate c = new Coordinate(col, row);
                    c = block.toBoardCoord(c);
                    if (block.momBlock[row, col] && c.x >= 0 && c.x < numCols && c.y < numRows)
                    {
                        boardCells.TryGetValue(cellKey(c.y, c.x), out cell);

                        cell.cellColor = block.blockColor;
                    }
                }
            }
        }
        
        /// Takes the appropriate actions when the game is over
        private void gameOver()
        {
            buttonStart.Enabled = true;
            labelGameOver.Visible = true;
            this.gameTick.Enabled = false;
            this.playing = false;
            if (this.board.score > this.highScore)
            {
                this.highScore = this.board.score;
                this.textBoxHighScore.Text = this.board.score.ToString();
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tetris_KeyUp(object sender, KeyEventArgs e)
        {
            if (playing)
            {
                if (input.spaceKeyPressed)
                {
                    board.lowerCurrentBlock();
                }
                if (input.leftKeyPressed)
                {
                    board.moveCurrentBlockLeft();
                }
                if (input.rightKeyPressed)
                {
                    board.moveCurrentBlockRight();
                }
                if (input.upKeyPressed)
                {
                    board.dreheMomBlockUhrzeiger();
                }
                if (input.downKeyPressed)
                {
                    board.dreheMomBlockGegenUhrzeiger();
                }
                if (input.escKeyPressed)
                {
                    Application.Exit();
                }
                this.updateGameBoard();
            }     
            input.evaluateKey(e.KeyCode, false);
        }

        private void Tetris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (playing)
            {
                if (input.spaceKeyPressed)
                {
                    board.lowerCurrentBlock();
                    e.Handled = true;
                    this.updateGameBoard();
                }   
            }
        }

        private void Tetris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && playing)
                input.evaluateKey(e.KeyCode, true); e.Handled = true;
        }

        private void Tetris_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }
        
        /// Processes the different keys used to play the game
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {            
            switch (keyData)
            {
                //case Keys.Home:
                    //this.increaseGameLevel();
                    //return true;
                case (Keys.S):
                    this.reset();
                    return true;
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    input.evaluateKey(keyData, true);
                    return true;
            } 
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
