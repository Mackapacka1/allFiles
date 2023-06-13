using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    public class Player : Character
    {
        public int XPosition;
        public int YPosition;
        public override void Draw()
        {
            Console.Write("x");
        }
        public void Move(int x, int y, Room[,] map)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            map[yPosition, xPosition].RemoveGameObject(this);
            xPosition += x;
            yPosition += y;

        }
    }
}
