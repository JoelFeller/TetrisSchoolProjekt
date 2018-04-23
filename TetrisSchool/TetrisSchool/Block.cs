﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisSchool
{
    class Block
    {
        private Int32[] setzeFarbe;
        public Block()
        {
            this.bestimmeForm();
            this.setzeFarbe = this.getSetzeFarbe();
            this.getNextBlock();
        }

        private void bestimmeForm()
         {
            
            bool[,] geradeLinie = new bool[4, 4] { { false, true, false, false }, { false, true, false, false }, { false, true, false, false }, { false, true, false, false } };
            bool[,] linkerBlitz = new bool[4, 4] { { false, false, false, false }, { true, true, false, false }, { false, true, true, false }, { false, false, false, false } };
            bool[,] rechterBlitz = new bool[4, 4] { { false, false, false, false }, { false, false, true, true }, { false, true, true, false }, { false, false, false, false } };
            bool[,] dreieck = new bool[4, 4] { { false, false, true, false }, { false, true, true, false }, { false, false, true, false }, { false, false, false, false } };
            bool[,] rechtesL = new bool[4, 4] { { false, false, false, false }, { false, true, true, false }, { false, false, true, false }, { false, false, true, false } };
            bool[,] linkesL = new bool[4, 4] { { false, false, false, false }, { false, true, true, false }, { false, true, false, false }, { false, true, false, false } };
            bool[,] viereck = new bool[4, 4] { { false, false, false, false }, { false, true, true, false }, { false, true, true, false }, { false, false, false, false } };
 
            
            for (int i = 0; i<numShape; i++)
                blockConfig[i] = new bool[4, 4];
            
            
            blockConfig[0] = geradeLinie;
            blockConfig[1] = linkerBlitz;
            blockConfig[2] = rechterBlitz;
            blockConfig[3] = dreieck;
            blockConfig[4] = rechtesL;
            blockConfig[5] = linkesL;
            blockConfig[6] = viereck;
            
        }

        private Int32[] getSetzeFarbe()
        {
            Int32 blau = Convert.ToInt32("0xFF3F47CC", 16);
            Int32 gelb = Convert.ToInt32("0xFFFFFF01", 16);
            Int32 gruen = Convert.ToInt32("0xFF00FF01", 16);
            Int32 violet = Convert.ToInt32("0xFFA349A3", 16);
            Int32 rot = Convert.ToInt32("0xFFED1B24", 16);
            Int32 orange = Convert.ToInt32("0xFFFF7F26", 16);
            Int32 hellblau = Convert.ToInt32("0xFF60CEFF", 16);
            
            Int32[] set = { blau, gelb, gruen, violet, rot, orange, hellblau };
 
            return set;
        }
}
}