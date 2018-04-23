using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisSchool
{
    class Board
    {
        private static int anzReihe = 18;
        private static int anzSpalte = 10;
        public int[,] grid = new int[anzReihe, anzSpalte];
        public int boardColor;
        public int reiheBeendet { get; set; }
        //public int currentLevel { get; set; }
        public int score { get; set; }
        public Block currentBlock;
        public Coordinate coord;

        public Board()
        {
            this.reiheBeendet = 0;
            //this.currentLevel = 1;
            this.score = 0;
            this.currentBlock = new Block();
            this.coord = new Coordinate(0, 0);
            this.colorCodeBoard();
        }

        /// <summary>
        /// board timer
        /// </summary>
        public bool tick()
        {
            if (this.currentBlock.currBlock == null || !this.canDrop())
            {
                this.spawnNeueBlock();
                return this.isFirstMovePossible();
            }
            this.lowerCurrentBlock();
            this.checkFullRows();
            return true;
        }

        /// <summary>
        /// spawn the next tetromino 
        /// </summary>
        private void spawnNeueBlock()
        {
            // lock the last falling block where it fell
            this.lockLastBlock();
            this.currentBlock.getNextBlock();
        }

        //private void maybeUpdateLevel()
        //{
        //    if (this.reiheBeendet % 10 == 0)
        //    {
        //        //this.currentLevel++;
        //    }
        //}

        public bool isFirstMovePossible()
        {
            if (this.canDrop())
                return true;
            return false;
        }

        public void lowerCurrentBlock()
        {
            if (this.canDrop())
                this.currentBlock.y++;
        }

        /// <summary>
        /// Lock the last played block into position once it is done moving
        /// </summary>
        private void lockLastBlock()
        {
            if (currentBlock.currBlock != null)
            {
                Coordinate c = null;
                int dim = 4;

                for (int row = 0; row < dim; row++)
                {
                    for (int col = 0; col < dim; col++)
                    {
                        if (currentBlock.currBlock[row, col])
                        {
                            c = currentBlock.toBoardCoord(new Coordinate(col, row));
                            this.grid[c.y, c.x] = currentBlock.blockColor;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Move the current block left if possible
        /// </summary>
        public void moveCurrentBlockLeft()
        {
            if (this.canMoveSideWays(true))
                this.currentBlock.x--;
        }

        /// <summary>
        /// Moves the current block right if possible
        /// </summary>
        public void moveCurrentBlockRight()
        {
            if (this.canMoveSideWays(false))
                this.currentBlock.x++;
        }

        /// <summary>
        /// rotate the current block counter clockwise if possible
        /// </summary>
        public void rotateCurrentBlockCounterClockwise()
        {
            if (this.canRotate(false))
                this.currentBlock.rotateCounterClockwise();
        }

        /// <summary>
        /// rotate the current block clockwise if possible
        /// </summary>
        public void rotateCurrentBlockClockwise()
        {
            if (this.canRotate(true))
                this.currentBlock.rotateClockwise();
        }

        /// <summary>
        /// Returns true if the current block can move sideways else false
        /// </summary>
        /// <param name="left"></param>
        /// <returns></returns>
        private bool canMoveSideWays(bool left)
        {
            bool isMoveable = true;
            Block whenMoved = currentBlock.Clone();
            if (left)
                whenMoved.x--;
            else
                whenMoved.x++;

            if (!canBeThere(whenMoved))
                isMoveable = false;

            return isMoveable;
        }

        /// <summary>
        /// Returns true if the current block can rotate else false
        /// </summary>
        /// <param name="clockwise"></param>
        /// <returns></returns>
        private bool canRotate(bool clockwise)
        {
            bool isRotatable = true;
            Block whenRotated = currentBlock.Clone();

            if (clockwise)
                whenRotated.rotateClockwise();
            else
                whenRotated.rotateCounterClockwise();

            if (!canBeThere(whenRotated))
                isRotatable = false;

            return isRotatable;
        }

        /// <summary>
        /// Returns true if the current block can drop one row down else false
        /// </summary>
        /// <returns></returns>
        private bool canDrop()
        {
            bool canDrop = true;
            Block ifDropped = currentBlock.Clone();
            ifDropped.y++;

            if (!canBeThere(ifDropped))
                canDrop = false;
            return canDrop;
        }

        /// <summary>
        /// Returns true if the current block is allowed to make its next move else false
        /// </summary>
        /// <param name="ablock"></param>
        /// <returns></returns>
        private bool canBeThere(Block ablock)
        {
            bool isMoveable = true;
            int dim = 4;

            for (int row = 0; row < dim; row++)
            {
                for (int col = 0; col < dim; col++)
                {
                    if (ablock.currBlock[row, col])
                    {
                        Coordinate c = ablock.toBoardCoord(new Coordinate(col, row));
                        if (isOccupiedCell(c) || c.x >= numCols || c.x < 0 || c.y >= numRows)
                            isMoveable = false;
                    }
                }
            }
            return isMoveable;
        }

        /// <summary>
        /// Returns true if a cell is occupied otherwise false
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private bool isOccupiedCell(Coordinate c)
        {
            if (c.x < numCols && c.x >= 0 && c.y < numRows && c.y >= 0 && this.grid[c.y, c.x] == this.boardColor)
                return false;
            return true;
        }

        /// <summary>
        /// Check all the board rows for completion
        /// </summary>
        private void checkFullRows()
        {
            int numCompleted = 0;
            int rowPoints = this.currentLevel * 100;
            int rowBonus = this.currentLevel * 50;
            for (int row = 0; row < numRows; row++)
            {
                if (this.isFullRow(row))
                {
                    this.removeRow(row);
                    numCompleted++;
                }
            }
            if (numCompleted > 0)
            {
                this.score += numCompleted * rowPoints + ((numCompleted - 1) * rowBonus);
                this.updateRowsAndLevel(numCompleted);
            }
        }

        private void updateRowsAndLevel(int numCompleted)
        {
            for (int i = 0; i < numCompleted; i++)
            {
                this.rowsCompleted++;
                if (this.rowsCompleted % 10 == 0)
                    this.currentLevel++;
            }
        }

        /// <summary>
        /// Check if a row is full
        /// </summary>
        /// <param name="currentRow"></param>
        private bool istReiheVoll(int currentRow)
        {
            for (int spalte = 0; spalte < anzSpalte; spalte++)
            {
                if (this.grid[currentRow, spalte] == this.boardColor)
                    return false;
            }
            return true;
        }

        
        private void removeRow(int removedRow)
        {
            for (int reihe = removedRow; reihe > 0; reihe--)
            {
                for (int col = 0; col < anzSpalte; col++)
                {
                    if (reihe - 1 <= 0)
                        this.grid[reihe, col] = this.boardColor;
                    else
                        this.grid[reihe, col] = this.grid[reihe - 1, col];
                }
            }
        }

        /// <summary>
        /// Gives the empty board its basic color
        /// </summary>
        private void colorCodeBoard()
        {
            this.boardColor = Convert.ToInt32("FF4682B4", 16);
            for (int i = 0; i < anzReihe; i++)
            {
                for (int j = 0; j < anzSpalte; j++)
                {
                    grid[i, j] = this.boardColor;
                }
            }
        }

    }
}
