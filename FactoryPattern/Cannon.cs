using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Cannon:Soldier
    {
        public Cannon()
        {
            Name = "Crazy Cannon";
            HP = 300;
            Damage = 100;
        }

    }
}
