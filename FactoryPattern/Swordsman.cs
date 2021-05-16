using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Swordsman:Soldier
    {
        public Swordsman()
        {
            Name = "Barbarian King";
            HP = 600;
            Damage = 150;

        }

    }
}
