using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonReborn
{
   class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
            Encounters.FirstEncounter();


        }



        static void Start()
        {
            Console.WriteLine("Dungeon Reborn");
            Console.WriteLine("Name:");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awake in a cold, dark cave. You feel dazed and are having trouble remembering the past");
            if (currentPlayer.name == "")
                Console.WriteLine("Having trouble remembering name");
            else
                Console.WriteLine("You can remember that your name is " + currentPlayer.name);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You wonder around in the darkness until you find a door handle. You feel some resistance as");
            Console.WriteLine("you turn the handle, but the rusty lock breaks with little effort. You see your captor");
            Console.WriteLine("standing with his back to you outside the door.");
        }






    }
       





}
