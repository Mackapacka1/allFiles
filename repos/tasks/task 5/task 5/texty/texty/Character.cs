using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    public abstract class Character : GameObject

    {
        protected int AT;
        protected int DF;
        protected int HP;

        public bool IsAlive()
        {

            if (HP == 0 || HP < 0) { return false; }
            else { return true; }
        }

    }
}
