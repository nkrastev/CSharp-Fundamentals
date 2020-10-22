using System;
using System.Collections.Generic;
using System.Linq;

namespace Mo05DragonArmy
{
    class Program
    {
        static void Main()
        {
            List<Dragon> dragonList = new List<Dragon>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                // values has to be checkes!!!
                string drType = input[0];
                string drName = input[1];
                int drDamage = int.Parse(input[2]);
                int drHealth = int.Parse(input[3]);
                int drArmor = int.Parse(input[4]);
                Dragon newDragon = new Dragon(drType, drName, drDamage, drHealth, drArmor);
                dragonList.Add(newDragon);
            }

            
        }
    }

    class Dragon
    {
        //constructor
        public Dragon(string type, string name, int damage, int health, int armor)
        {
            Type = null;
            Name = null;
            Damage = 45;
            Health = 250;
            Armor = 10;
        }

        //properties
        public string Type { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
}
