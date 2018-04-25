using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisSchool
{
    [Serializable]
    class Board
    {
        private static int anzReihe = 18;
        private static int anzSpalte = 10;
        public int[,] grid = new int[anzReihe, anzSpalte];
        public int boardFarbe;
        public int reiheBeendet { get; set; }
        //public int currentLevel { get; set; }
        public int score { get; set; }
        public Block momentanerBlock;
        public Block alterBlock;
        public Coordinate coord;
        public bool istTNT;

        public Board()
        {
            this.reiheBeendet = 0;
            //this.currentLevel = 1;
            this.score = 0;
            this.momentanerBlock = new Block();
            this.coord = new Coordinate(0, 0);
            this.colorCodeBoard();
        }
        
        /// Timer for the game
        public bool tick()
        {
            //if (this.momentanerBlock.momBlock == null || !this.canDrop() || this.momentanerBlock.momBlock != alteBlock)
            //{
            //    this.spawnNeueBlock();
            //    return this.isFirstMovePossible();
            //}
            if (this.momentanerBlock.momBlock == null || !this.canDrop())
            {
                this.spawnNeueBlock();
                return this.isFirstMovePossible();
            }
            this.lowerCurrentBlock();
            this.checkFullRows();
            return true;
        }
        

        /// spawn the next Tetromino
        private void spawnNeueBlock()
        { 
                this.placeLastBlock();
                this.momentanerBlock.holeNaechsterBlock();
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
            {
                return true;
            }
            return false;
        }

        public void lowerCurrentBlock()
         {
            if (this.canDrop())
            {
                this.momentanerBlock.y++;
            }
        }
        
        private void placeLastBlock()
        {
            if (momentanerBlock.momBlock != null)
            {
                Coordinate c = null;
                int dim = 4;

                for (int reihe = 0; reihe < dim; reihe++)
                {
                    for (int spalte = 0; spalte < dim; spalte++)
                    {
                        if (momentanerBlock.momBlock[reihe, spalte])
                        {
                            c = momentanerBlock.toBoardCoord(new Coordinate(spalte, reihe));
                            this.grid[c.y, c.x] = momentanerBlock.blockColor;
                        }

                        //tnt block part
                        if (momentanerBlock.momBlock == momentanerBlock.blockConfig[7])
                        {
                            entferneReihe(reihe);
                        }
                    }
                }
            }
        }
        
        /// Move the current block left if possible
        public void bewegeMomBlockLinks()
        {
            if (this.canMoveSideWays(true))
            {
                this.momentanerBlock.x--;
            }
        }
        
        /// Moves the current block right if possible
        public void bewegeMomBlockRechts()
        {
            if (this.canMoveSideWays(false))
            {
                this.momentanerBlock.x++;
            }
        }
        /// If possible, rotate the current block clockwise
        public void dreheMomBlockUhrzeiger()
        {
            if (this.canRotate(true))
            {
                this.momentanerBlock.drehenUhrzeiger();
            }
        }
        /// If possible, rotate the current block counter clockwise
        public void dreheMomBlockGegenUhrzeiger()
        {
            if (this.canRotate(false))
            {
                this.momentanerBlock.drehenGegenUhrzeiger();
            }
        }
        
        /// Returns true if the current block can move sideways else false
        private bool canMoveSideWays(bool left)
        {
            bool bewegbar = true;
            Block whenMoved = momentanerBlock.Clone();
            if (left)
            {
                whenMoved.x--;
            }
            else
            {
                whenMoved.x++;
            }

            if (!canBeThere(whenMoved))
            {
                bewegbar = false;
            }
            return bewegbar;
        }
        
        /// Returns true if the current block can rotate else false
        private bool canRotate(bool uhrzeiger)
        {
            bool drehbar = true;
            //if block is tnt
            if(momentanerBlock.momBlock == momentanerBlock.blockConfig[7] || momentanerBlock.momBlock == momentanerBlock.blockConfig[6])
            {
                drehbar = false;
            }
            Block whenRotated = momentanerBlock.Clone();

            if (uhrzeiger)
            {
                whenRotated.drehenUhrzeiger();
            }
            else
            {
                whenRotated.drehenGegenUhrzeiger();
            }

            if (!canBeThere(whenRotated))
            {
                drehbar = false;
            }

            return drehbar;
        }
        
        /// Returns true if the current block can still go deeper else false
        private bool canDrop()
        {
            bool canDrop = true;
            Block ifDropped = momentanerBlock.Clone();
            ifDropped.y++;

            if (!canBeThere(ifDropped))
            {
                canDrop = false;
            }
            return canDrop;
        }

        /// Returns true if the current block is still moveable else false
        /// Return true wenn der Teil noch bewegbar ist sonst false
        private bool canBeThere(Block ablock)
        {
            bool bewegbar = true;
            int dim = 4;

            for (int reihe = 0; reihe < dim; reihe++)
            {
                for (int spalte = 0; spalte < dim; spalte++)
                {
                    if (ablock.momBlock[reihe, spalte])
                    {
                        Coordinate c = ablock.toBoardCoord(new Coordinate(spalte, reihe));
                        if (isOccupiedCell(c) || c.x >= anzSpalte || c.x < 0 || c.y >= anzReihe)
                        {
                            bewegbar = false;
                        }
                    }
                }
            }
            return bewegbar;
        }
        
        /// Returns true if a cell is already there otherwise false
        private bool isOccupiedCell(Coordinate c)
        {
            if (c.x < anzSpalte && c.x >= 0 && c.y < anzReihe && c.y >= 0 && this.grid[c.y, c.x] == this.boardFarbe)
            {
                return false;
            }
            return true;
        }
        
        /// Checks every single board row if there are full rows
        private void checkFullRows()
        {
            int anzVolleReihe = 0;
            //int rowPoints = this.currentLevel * 100;
            //int rowBonus = this.currentLevel * 50;
            for (int reihe = 0; reihe < anzReihe; reihe++)
            {
                if (this.istReiheVoll(reihe))
                {
                    this.entferneReihe(reihe);
                    anzVolleReihe++;
                }
            }
            if (anzVolleReihe > 0)
            {
                this.score += anzVolleReihe + (anzVolleReihe - 1);
                this.updateRows(anzVolleReihe);
            }
        }

        private void updateRows(int anzVolleReihe)
        {
            for (int i = 0; i < anzVolleReihe; i++)
            {
                this.reiheBeendet++;
                //if (this.reiheBeendet % 10 == 0)
                //{
                //    this.currentLevel++;
                //
                //}
            }
        }

        /// Check if a row is full
        private bool istReiheVoll(int momReihe)
        {
            for (int spalte = 0; spalte < anzSpalte; spalte++)
            {
                if (this.grid[momReihe, spalte] == this.boardFarbe)
                {
                    return false;
                }
            }
            return true;
        }

        
        private void entferneReihe(int entfernteReihe)
        {
            for (int reihe = entfernteReihe; reihe > 0; reihe--)
            {
                for (int spalte = 0; spalte < anzSpalte; spalte++)
                {
                    if (reihe - 1 <= 0)
                    {
                        this.grid[reihe, spalte] = this.boardFarbe;
                    }
                    else
                    {
                        this.grid[reihe, spalte] = this.grid[reihe - 1, spalte];
                    }
                }
            }
        }


        /// Gives the deactivated board a color
        /// " It looks like it turned on"
        private void colorCodeBoard()
        {
            this.boardFarbe = Convert.ToInt32("FFFFFFFF", 16);
            for (int i = 0; i < anzReihe; i++)
            {
                for (int j = 0; j < anzSpalte; j++)
                {
                    grid[i, j] = this.boardFarbe;
                }
            }
        }
    }
}
