/*
   Copyright 2012 Robin Holmgren
    
   This program is free software: you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation, either version 3 of the License, or
   (at your option) any later version.

   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Damage
{
    public class DamageClass
    {
        //minimum skada
        public double minDamage(double minDamage, int primaryAttribute, int skillDamageIncrease)
        {
            return minDamage * (1 + (double)primaryAttribute / 100) * (1 + (double)skillDamageIncrease / 100);
        }
        //maximum skada
        public double maxDamage(double maxDamage, int primaryAttribute, int skillDamageIncrease)
        {
            return maxDamage * (1 + (double)primaryAttribute / 100) * (1 + (double)skillDamageIncrease / 100);
        }
        //beräkna DPS och återge ett double värde
        public double DPS(double avgDamage, int primaryAttribute, int skillDamageIncrease, double attackSpeed, double criticalChance, int criticalDamage)
        {
            return avgDamage * ((double)primaryAttribute / 100 + 1) * (1 + (double)skillDamageIncrease / 100) * (((double)criticalChance / 100) * ((double)criticalDamage / 100) + 1) * attackSpeed;
        }
    }
}
