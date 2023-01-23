using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV3
{
    internal class GameCharacter
    {
        public int health;
        public string name;



        public GameCharacter(int health, string name) 
        {
            this.health = health;
            this.name = name;
        }

        public void TakeDamage(int hp)
        {
            health -= hp;
            if (health < 0) health = 0;
        }

        public void Heal(int hp)
        {
            health += hp;
            if (health > 100) health = 100;
        }

        public void ShowStats()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + health);           
            
        }
    }

    
}
