using System;
using System.Threading.Tasks;

namespace DungeonReborn
{
	class Encounters
	{
		static Random rand = new Random();
		//Encounter Generic



		//Encounters
		public static void FirstEncounter()
		{
			Console.WriteLine("You throw open the door and grab a metal sword while charging towards your captor");
			Console.WriteLine("He turns...");
			Console.ReadKey();
			Combat(false, "Human Rogue", 1, 4);

		}


		//Encounter Tools
		public static void Combat(bool random, string name, int power, int health)
		{
			string n = "";
			int p = 0;
			int h = 0;
			if (random)
			{


		    }
			else
			{

				n = name;
				p = power;
				h = health;

			}
			while (h > 0)
			{
				Console.Clear();
				Console.WriteLine(n);
				Console.WriteLine(p + "/" + h);
				Console.WriteLine("=====================");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("|  (R)un   (H)eal   ");
                Console.WriteLine("=====================");
                Console.WriteLine(" Potions: "+Program.currentPlayer.potion+"  Health: "+Program.currentPlayer.health);
				string input = Console.ReadLine();
				if(input.ToLower() == "a"||input.ToLower() == "attack")
				{
					//Attack
					Console.WriteLine("with haste you explode forward, your sword appears as if its on fire! As you pass, the " + n + " strikes you as you pass ");
					int damage = p - Program.currentPlayer.armorValue;
					if (damage < 0)
						damage = 0;
					int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1,4);
					

					Console.WriteLine("You lose " + damage + "health and deal " + attack + "damage");
					Program.currentPlayer.health -= damage;
					h -= attack;

				}
				else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    Console.WriteLine("As the " + n + " prepares to strike, you ready your sword in a defensive stance");
                    int damage = (p/4) - Program.currentPlayer.armorValue;
					if (damage < 0)
						damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4)/2;


                    Console.WriteLine("You lose " + damage + "health and deal " + attack + "damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;

                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
					//Run
					if(rand.Next(0, 2) == 0)
					{
						Console.WriteLine("As yiu sprint away from the " + n + ", its strike catches you in the back, sending you sprawling onto the ground");
						int damage = p - Program.currentPlayer.armorValue;
						if (damage < 0)
							damage = 0;
						Console.WriteLine("You lose " + damage + " health and are unable to escape.");
						Console.ReadKey();

					}
					else
					{
						Console.WriteLine("You use your evasive skills to evade the " + n + " and you successfully escape!");
						Console.ReadKey();
						//go to store

					}

                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal
					if(Program.currentPlayer.potion == 0)
					{
						Console.WriteLine("As you desperatly grasp for a potion in your bag, you realize you dont have any");
						int damage = p - Program.currentPlayer.armorValue;
						if (damage < 0)
							damage = 0;
						Console.WriteLine("The"+n+" strikes you with a mighty blow and you lose "+damage+" health!");
					}
					else
					{
						Console.WriteLine("You reach into your bag and pull out a glowing, green glass. You take a much needed drink.");
						int potionV = 5;
						Console.WriteLine("You gain " + potionV + " health");
						Program.currentPlayer.health += potionV;

					}
					Console.ReadKey();


                }
				Console.ReadKey();


            }

		}
		
		
		      

		
		

		
		
	}
}

