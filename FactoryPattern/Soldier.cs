using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Soldier
    {
        public int HP { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacking and damaging {Damage} points");
        }
        public void Defend()
        {
            Console.WriteLine($"{Name} defending and has health {HP} points");
        }
    }
}
