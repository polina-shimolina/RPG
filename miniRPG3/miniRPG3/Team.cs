using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniRPG3
{
    class Team
    {
        enum ComputerNames
        {
            name1,
            name2,
            name3

        }
        public string Name;
        public Hero1 hero1;
        public Hero2 hero2;
        public Hero3 hero3;
        public bool Alive;
        public Team()
        {
            PrintTeam();
            Hero1 hero1 = new Hero1();
            Hero2 hero2 = new Hero2();
            Hero3 hero3 = new Hero3();
        }
        public void CreateTeam()
        {
            Console.WriteLine("Придумай название своей команды:");
            Name = Console.ReadLine();
        }
        
        void AliveHeroes()
        {
            
            if ((hero1.HP == 0) && (hero2.HP == 0) && (hero3.HP == 0)){
                Alive = false;
            } else {
                Alive = true;
            }
        }
        public void PrintTeam()
        {
            Console.WriteLine(Name);
            hero1.Info();
            hero2.Info();
            hero3.Info();
        }

    }
}
