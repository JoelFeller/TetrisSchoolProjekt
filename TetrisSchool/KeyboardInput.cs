using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisSchool
{
    class KeyboardInput
    {
        public bool upKeyPressed { get; set; }
        public bool downKeyPressed { get; set; }
        public bool rightKeyPressed { get; set; }
        public bool leftKeyPressed { get; set; }
        public bool spaceKeyPressed { get; set; }
        public bool escKeyPressed { get; set; }

        public KeyboardInput()
        {
            upKeyPressed = false;
            downKeyPressed = false;
            rightKeyPressed = false;
            leftKeyPressed = false;
            escKeyPressed = false;
        }
        public void evaluateKey(Keys key, Boolean pressed)
        {
            if (key == Keys.Left)
            {
                leftKeyPressed = pressed;
            }
            else if (key == Keys.Right)
            {
                rightKeyPressed = pressed;
            }
            else if (key == Keys.Down)
            {
                downKeyPressed = pressed;
            }
            else if (key == Keys.Up)
            {
                upKeyPressed = pressed;
            }
            else if (key == Keys.Space)
            {
                spaceKeyPressed = pressed;
            }
            else if (key == Keys.Escape)
            {
                escKeyPressed = pressed;
            }
        }
    }
}
