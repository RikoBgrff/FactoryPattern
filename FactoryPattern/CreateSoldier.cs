using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
   static class CreateSoldier
    {
        public static Soldier GetSoldier(string SoldierType)
        {
            if (SoldierType == "S")
            {
                return new Archer();
            }
             if (SoldierType == "A")
            {
                return new Swordsman();
            }
            if (SoldierType == "C")
            {
                return new Cannon();
            }
            return null;
        }
    }
}
