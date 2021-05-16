using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Swordsman press 'S' for Archer press 'A' for Cannon press 'C':");
            string selection = Console.ReadLine();
            Soldier soldier = CreateSoldier.GetSoldier(selection);
            
            soldier?.Attack();
            soldier?.Defend();
        }
    }
}
