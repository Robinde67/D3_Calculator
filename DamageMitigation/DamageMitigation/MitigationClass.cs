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

namespace DamageMitigation
{
    public class MitigationClass
    {
        //för in armor och återge ett double värde för vidare beräkning eller omräkning i procent.
        public double ArmorReduction(double armor, double charLevel)
        {
            return armor/(armor + 50 * charLevel);
        }
        //för in resistance och återge ett double värde för vidare beräkning eller omräkning i procent.
        public double ResistanceReduction(double resistance, double charLevel)
        {
            return resistance / (resistance + 5 * charLevel);
        }
        //beräkna total damage reduction och återge i procent 
        public double TotalReduction(double resistanceReduction, double armorReduction, string charClass)
        {
            double damageReductionPercentage;
            //om klassen är Barbarian eller Monk får dem 30% extra damage reduction
            if (charClass == "Barbarian" || charClass == "Monk")
            {
                double damageLeft = 0.70 * (1 - armorReduction) * (1 - resistanceReduction);
                double damageReduction = 1 - damageLeft;
                damageReductionPercentage = (double)(damageReduction * 100);
            }
            // alla andra klasser får 0% extra
            else
            {
                double damageLeft = 1*(1 - armorReduction) * (1 - resistanceReduction);
                double damageReduction = 1 - damageLeft;
                damageReductionPercentage = (double)(damageReduction * 100);
            }
            return damageReductionPercentage;
        }
    }
}
