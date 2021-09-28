using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_HUD_v1._1
{
    class Program
    {
        static int health;
        static int points;
        static int lives;

        static void ShowHUD()
        {
            Console.WriteLine("Health = " + health);
            Console.WriteLine("Points = " + points);
            Console.WriteLine("Lives = " + lives);
        }
        static void TakeDamage(int damage)
        {
            health = health - damage;
        }
        static void HealDamage(int HealDamage)
        {
            health = health + HealDamage;
        }
        static void GainPoints(int GainPoints)
        {
            points = points + GainPoints;
        }
        static void LosePoints(int LosePoints)
        {
            points = points - LosePoints;
        }
        static void Death(int Death)
        {
            lives = lives - Death;
        }
        static void Main(string[] args)
        {
            health = 100;
            points = 0;
            lives = 3;
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("DoomGuy killed 2 imps for 200 points");
            Console.WriteLine();
            GainPoints(200);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("DoomGuy killed 1 Zombie Men for 100 points");
            Console.WriteLine("But he was hit for 15 health");
            Console.WriteLine();
            GainPoints(100);
            TakeDamage(15);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("A wall opens to reveal a hellknight and 4 imps");
            Console.WriteLine("The demons were killed for 800 points");
            Console.WriteLine("Taking 45 damage");
            Console.WriteLine();
            GainPoints(800);
            TakeDamage(45);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("DoomGuy finds a hidden area that has a zombie man + 100 points");
            Console.WriteLine("And healthpack + 50 HP");
            Console.WriteLine();
            GainPoints(100);
            HealDamage(50);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("There was an archvile behind you");
            Console.WriteLine("DoomGuy could not kill him in time and exsplodes");
            Console.WriteLine();
            LosePoints(1200);
            TakeDamage(90);
            Death(1);
            ShowHUD();





            Console.ReadKey(true);
        }
    }
}

