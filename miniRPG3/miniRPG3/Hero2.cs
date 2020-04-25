using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniRPG3
{
    class Hero2
    {
        private string name;
        public int HP;
        private int damage;
        public string Name
        {
            get { return name; }
        }
        public Hero2(string name, int hp, int _dmg)
        {
            name = "Hero2";
            HP = 304;
            damage = 946;
        }
        
        public void Info()
        {
            Console.WriteLine($"Имя:{name}");
            Console.WriteLine($"НР:{HP}");
            Console.WriteLine($"Урон:{damage}");
        }
        public int SetDamage()
        {
            
                Random randomGenerator = new Random();
                int rd = randomGenerator.Next(damage - (int)(0.1 * damage), damage + (int)(0.1 * damage + 1));
                return rd;
            
        }
        public void GetDamage(int _inputDmg)
        {
            HP -= _inputDmg;
            if (HP < 0)
            {
                HP = 0;
            }
        }
        
    }
}
