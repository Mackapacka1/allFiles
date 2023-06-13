using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AdventureGame
{
    public class Enemy : Character
    {
        public Enemy(int at, int def, int hp)
        {
            AT = at;
            DF = def;
            HP = hp;
            //int xposition = map[];

        }
        public override void Draw()
        {
            if (HP <= 0)
            {
                Console.WriteLine("o");
            }
            else
            {
                Console.Write("0");
            }
        }
    }
}
