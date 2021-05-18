using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fredley_GOL
{
    class GOLCell
    {
        // Creates rectangle variable
        private Rectangle rect;

        // Integer to keep track of whether the cell is alive or dead
        private int isAlive;

        // Integer to count the cells around the cell you want
        private int cellCount;

        // Integer to keep the age
        private int age;

        // Integer to determine what happens with a cell
        private int futureState;

        public Rectangle Rect { get => rect; set => rect = value; }
        public int IsAlive { get => isAlive; set => isAlive = value; }
        public int CellCount { get => cellCount; set => cellCount = value; }
        public int Age { get => age; set => age = value; }
        public int FutureState { get => futureState; set => futureState = value; }

        public GOLCell()
        {
            // Creates the rectangle object
            rect = new Rectangle();

            // 0 means dead 1 means alive
            isAlive = 0;

            // 0 means there are no alive cells around the targetted cell
            cellCount = 0;

            // 0 = Yellow
            // 1 = Green
            // 2 = Blue
            // 3 = Magenta
            // 4+ = Red
            age = 0;

            futureState = 0;
        }
    }
}
