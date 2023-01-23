using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Health system V3" + " Now using inheritance");

            GameCharacter gameCharacter = new GameCharacter(100, "jeremy");
            Player player = new Player(100,100,3,1,0,"Jeremy985");
            Enemy enemy = new Enemy(50, "rat");


            Console.WriteLine();
            player.ShowStats();
            player.TakeDamage(30);
            Console.WriteLine();
            player.ShowStats();
            player.Heal(100);
            Console.WriteLine();
            player.ShowStats();
            Console.WriteLine();
            enemy.ShowStats();
            enemy.TakeDamage(10);
            Console.WriteLine();
           
            enemy.ShowStats();


            Console.ReadKey(true);
        }
    }
}
