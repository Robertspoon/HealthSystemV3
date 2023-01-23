using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV3
{
    internal class Player : GameCharacter
    {
        public int shield;
        public int lives;


        public Player(int health, int shield, int lives, string name) : base (health,name)
        {
            this.shield = shield;
            this.lives = lives;
        }

        public void PlayerStats()
        {
            ShowStat();
            Console.WriteLine("Shields: " + shield);
            Console.WriteLine("Lives: " + lives);

        }
    }
}
