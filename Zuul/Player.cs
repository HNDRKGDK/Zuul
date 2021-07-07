using System;
using System.Collections.Generic;
using System.Text;

namespace Zuul
{
    class Player
    {
        public Room CurrentRoom { get; set; }

        private int health;

        public Player()
        {
            health = 100;
        }
        
        public void Damage(int amount)
        {
           
            health -= amount;
        }

        public bool isAlive()
        {
            return health > 0;
        }

        public int statusH()
        {
            return health;
        }
    }
}
