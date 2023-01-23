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
        public int exp;
        public int level;


        public Player(int health, int shield, int lives,int level,int exp, string name) : base (health,name)
        {
            this.shield = shield;
            this.lives = lives;
            this.level = level;
            this.exp = exp;
        }

        public new void ShowStats()
        {
            base.ShowStats();
            Console.WriteLine("Shields: " + shield);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Exp: " + exp);

        }
    }
}
