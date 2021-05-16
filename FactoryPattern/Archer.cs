using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Archer:Soldier
    {
        public Archer()
        {
            Name = "Archer Queen";
            HP = 500;
            Damage = 100;
                
        }
    }
}
