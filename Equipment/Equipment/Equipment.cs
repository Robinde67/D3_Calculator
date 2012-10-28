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

namespace Equipment
{
    public class EquipmentClass
    {
        //utrustnings klasser och default värden
        #region Equipment parts
        public class Chest
        {
            public int strength = 0;
            public int dexterity = 0;
            public int intelligence = 0;
            public int vitality = 0;
            public int armor = 0;
            public int allResistance = 0;
            public int physicalResistance = 0;
            public int coldResistance = 0;
            public int fireResistance = 0;
            public int lightningResistance = 0;
            public int poisonResistance = 0;
            public int arcaneResistance = 0;
            public double attackSpeed = 0;
            public int HP = 0;
        }
        public class Bracers
        {
            public int strength = 0;
            public int dexterity = 0;
            public int intelligence = 0;
            public int vitality = 0;
            public int armor = 0;
            public int allResistance = 0;
            public int physicalResistance = 0;
            public int coldResistance = 0;
            public int fireResistance = 0;
            public int lightningResistance = 0;
            public int poisonResistance = 0;
            public int arcaneResistance = 0;
            public double attackSpeed = 0;
            public double critChance = 0;
            public int HP = 0;
        }
        public class Hands
        {
            public int strength = 0;
            public int dexterity = 0;
            public int intelligence = 0;
            public int vitality = 0;
            public int armor = 0;
            public int allResistance = 0;
            public int physicalResistance = 0;
            public int coldResistance = 0;
            public int fireResistance = 0;
            public int lightningResistance = 0;
            public int poisonResistance = 0;
            public int arcaneResistance = 0;
            public double attackSpeed = 0;
            public double critChance=0;
            public int critDmg = 0;
            public int HP = 0;
        }
        public class Ring
        {
            public int strength = 0;
            public int dexterity = 0;
            public int intelligence = 0;
            public int vitality = 0;
            public int armor = 0;
            public int allResistance = 0;
            public int physicalResistance = 0;
            public int coldResistance = 0;
            public int fireResistance = 0;
            public int lightningResistance = 0;
            public int poisonResistance = 0;
            public int arcaneResistance = 0;
            public double attackSpeed = 0;
            public int minDmg = 0;
            public int maxDmg = 0;
            public double critChance = 0;
            public int critDmg = 0;
            public int HP = 0;
        }
        public class Helm
        {
            public int strength = 0;
            public int dexterity = 0;
            public int intelligence = 0;
            public int vitality = 0;
            public int armor = 0;
            public int allResistance = 0;
            public int physicalResistance = 0;
            public int coldResistance = 0;
            public int fireResistance = 0;
            public int lightningResistance = 0;
            public int poisonResistance = 0;
            public int arcaneResistance = 0;
            public double attackSpeed = 0;
            public double critChance = 0;
            public int HP = 0;
        }
        public class Shoulders
        {
            public int strength = 0;
            public int dexterity = 0;
            public int intelligence = 0;
            public int vitality = 0;
            public int armor = 0;
            public int allResistance = 0;
            public int physicalResistance = 0;
            public int coldResistance = 0;
            public int fireResistance = 0;
            public int lightningResistance = 0;
            public int poisonResistance = 0;
            public int arcaneResistance = 0;
            public int HP = 0;
        }
        public class Belt
        {
            public int strength = 0;
            public int dexterity = 0;
            public int intelligence = 0;
            public int vitality = 0;
            public int armor = 0;
            public int allResistance = 0;
            public int physicalResistance = 0;
            public int coldResistance = 0;
            public int fireResistance = 0;
            public int lightningResistance = 0;
            public int poisonResistance = 0;
            public int arcaneResistance = 0;
            public double attackSpeed = 0;
            public int critDmg = 0;
            public int HP = 0;
        }
        public class Legs
        {
            public int strength = 0;
            public int dexterity = 0;
            public int intelligence = 0;
            public int vitality = 0;
            public int armor = 0;
            public int allResistance = 0;
            public int physicalResistance = 0;
            public int coldResistance = 0;
            public int fireResistance = 0;
            public int lightningResistance = 0;
            public int poisonResistance = 0;
            public int arcaneResistance = 0;
            public double attackSpeed = 0;
            public double critChance = 0;
            public int HP = 0;
        }
        public class Boots
        {
            public int strength = 0;
            public int dexterity = 0;
            public int intelligence = 0;
            public int vitality = 0;
            public int armor = 0;
            public int allResistance = 0;
            public int physicalResistance = 0;
            public int coldResistance = 0;
            public int fireResistance = 0;
            public int lightningResistance = 0;
            public int poisonResistance = 0;
            public int arcaneResistance = 0;
            public double attackSpeed = 0;
            public int HP = 0;
        }
        public class MainHand
        {
            public int strength = 0;
            public int dexterity = 0;
            public int intelligence = 0;
            public int vitality = 0;
            public double attackSpeed = 0;
            public double attacksPerSecond = 1;
            public int increasedDamage = 0;
            public int minDmg = 2;
            public int maxDmg = 3;
            public int critDmg = 0;
            public double lifeSteal = 0;
        }
        public class OffHand
        {
            public int strength = 0;
            public int dexterity = 0;
            public int intelligence = 0;
            public int vitality = 0;
            public int armor = 0;
            public int allResistance = 0;
            public int physicalResistance = 0;
            public int coldResistance = 0;
            public int fireResistance = 0;
            public int lightningResistance = 0;
            public int poisonResistance = 0;
            public int arcaneResistance = 0;
            public double attackSpeed = 0;
            public int minDmg = 0;
            public int maxDmg = 0;
            public double critChance = 0;
            public int HP = 0;
        }
        public class Amulet
        {
            public int strength = 0;
            public int dexterity = 0;
            public int intelligence = 0;
            public int vitality = 0;
            public int armor = 0;
            public int allResistance = 0;
            public int physicalResistance = 0;
            public int coldResistance = 0;
            public int fireResistance = 0;
            public int lightningResistance = 0;
            public int poisonResistance = 0;
            public int arcaneResistance = 0;
            public double attackSpeed = 0;
            public int minDmg = 0;
            public int maxDmg = 0;
            public double critChance = 0;
            public int critDmg = 0;
            public int HP = 0;
        }
        public class DualWield
        {
            public int strength = 0;
            public int dexterity = 0;
            public int intelligence = 0;
            public int vitality = 0;
            public double attackSpeed = 0;
            public double attacksPerSecond = 0;
            public int increasedDamage = 0;
            public int minDmg = 0;
            public int maxDmg = 0;
            public int critDmg = 0;
            public double lifeSteal = 0;
        }
        #endregion
        //skapa subklasserna per default när Equipment klassen skapas
        public Chest chest = new Chest();
        public Bracers bracers = new Bracers();
        public Hands hands = new Hands();
        public Ring ring1 = new Ring();
        public Ring ring2 = new Ring();
        public Helm helm = new Helm();
        public Shoulders shoulders = new Shoulders();
        public Belt belt = new Belt();
        public Legs legs = new Legs();
        public Boots boots = new Boots();
        public MainHand mainHand = new MainHand();
        public OffHand offHand = new OffHand();
        public Amulet amulet = new Amulet();
        public DualWield dualWield = new DualWield();
        //variabler att spara totala stats i
        public int armor = 0;
        public int strength = 0;
        public int dexterity = 0;
        public int intelligence = 0;
        public int vitality = 0;
        public double minDmg = 0;
        public double maxDmg = 0;
        public double avgDmg = 0;
        public double attacksPerSecond = 0;
        public int allRes = 0;
        public int physRes = 0;
        public int coldRes = 0;
        public int fireRes = 0;
        public int lightRes = 0;
        public int poiRes = 0;
        public int arcRes = 0;
        public int HP = 0;
        public int critDmg = 0;
        public double critChance = 0;
        public double dualMinDmg = 0;
        public double dualMaxDmg = 0;
        public double dualAvgDmg = 0;
        public double dualAttacksPerSecond = 0;

        //funktion att beräkna alla stats
        #region Update Total Equipment Stats
        public void UpdateEquipmentStats()
        {
            //addera samtliga
            armor = helm.armor + chest.armor + belt.armor + legs.armor + boots.armor + ring1.armor + ring2.armor + amulet.armor + bracers.armor + hands.armor + shoulders.armor + offHand.armor;
            strength = helm.strength + chest.strength + belt.strength + legs.strength + boots.strength + ring1.strength + ring2.strength + amulet.strength + bracers.strength + hands.strength + shoulders.strength + mainHand.strength + offHand.strength + dualWield.strength;
            dexterity = helm.dexterity + chest.dexterity + belt.dexterity + legs.dexterity + boots.dexterity + ring1.dexterity + ring2.dexterity + amulet.dexterity + bracers.dexterity + hands.dexterity + shoulders.dexterity + mainHand.dexterity + offHand.dexterity + dualWield.dexterity;
            intelligence = helm.intelligence + chest.intelligence + belt.intelligence + legs.intelligence + boots.intelligence + ring1.intelligence + ring2.intelligence + amulet.intelligence + bracers.intelligence + hands.intelligence + shoulders.intelligence + mainHand.intelligence + offHand.intelligence + dualWield.intelligence;
            vitality = helm.vitality + chest.vitality + belt.vitality + legs.vitality + boots.vitality + ring1.vitality + ring2.vitality + amulet.vitality + bracers.vitality + hands.vitality + shoulders.vitality + mainHand.vitality + offHand.vitality + dualWield.vitality;

            //addera samtliga
            allRes = helm.allResistance + chest.allResistance + belt.allResistance + legs.allResistance + boots.allResistance + ring1.allResistance + ring2.allResistance + amulet.allResistance + bracers.allResistance + hands.allResistance + shoulders.allResistance + offHand.allResistance;
            physRes = helm.physicalResistance + chest.physicalResistance + belt.physicalResistance + legs.physicalResistance + boots.physicalResistance + ring1.physicalResistance + ring2.physicalResistance + amulet.physicalResistance + bracers.physicalResistance + hands.physicalResistance + shoulders.physicalResistance + offHand.physicalResistance;
            coldRes = helm.coldResistance + chest.coldResistance + belt.coldResistance + legs.coldResistance + boots.coldResistance + ring1.coldResistance + ring2.coldResistance + amulet.coldResistance + bracers.coldResistance + hands.coldResistance + shoulders.coldResistance + offHand.coldResistance;
            fireRes = helm.fireResistance + chest.fireResistance + belt.fireResistance + legs.fireResistance + boots.fireResistance + ring1.fireResistance + ring2.fireResistance + amulet.fireResistance + bracers.fireResistance + hands.fireResistance + shoulders.fireResistance + offHand.fireResistance;
            lightRes = helm.lightningResistance + chest.lightningResistance + belt.lightningResistance + legs.lightningResistance + boots.lightningResistance + ring1.lightningResistance + ring2.lightningResistance + amulet.lightningResistance + bracers.lightningResistance + hands.lightningResistance + shoulders.lightningResistance + offHand.lightningResistance;
            poiRes = helm.poisonResistance + chest.poisonResistance + belt.poisonResistance + legs.poisonResistance + boots.poisonResistance + ring1.poisonResistance + ring2.poisonResistance + amulet.poisonResistance + bracers.poisonResistance + hands.poisonResistance + shoulders.poisonResistance + offHand.poisonResistance;
            arcRes = helm.arcaneResistance + chest.arcaneResistance + belt.arcaneResistance + legs.arcaneResistance + boots.arcaneResistance + ring1.arcaneResistance + ring2.arcaneResistance + amulet.arcaneResistance + bracers.arcaneResistance + hands.arcaneResistance + shoulders.arcaneResistance + offHand.arcaneResistance;
            HP = helm.HP + chest.HP + belt.HP + legs.HP + boots.HP + ring1.HP + ring2.HP + amulet.HP + bracers.HP + hands.HP + shoulders.HP + offHand.HP;
            critChance = helm.critChance + legs.critChance + ring1.critChance + ring2.critChance + amulet.critChance + bracers.critChance + hands.critChance + offHand.critChance;
            critDmg = belt.critDmg + ring1.critDmg + ring2.critDmg + amulet.critDmg + hands.critDmg + mainHand.critDmg + dualWield.critDmg;

            //här är den del som var fel i min orginal beräkning, spelet har redan avrundat dessa tre
            //jag ska återrunda dem till sitt orginalvärde och tillbaks till doublevärdet som är det spelet faktiskt räknar på
            if (dualWield.minDmg == 0 && dualWield.maxDmg == 0)
            {
                minDmg = Math.Round((double)mainHand.minDmg / ((double)mainHand.increasedDamage / 100 + 1)) * ((double)mainHand.increasedDamage / 100 + 1) + (double)(ring1.minDmg + ring2.minDmg + amulet.minDmg + offHand.minDmg);
                maxDmg = Math.Round((double)mainHand.maxDmg / ((double)mainHand.increasedDamage / 100 + 1)) * ((double)mainHand.increasedDamage / 100 + 1) + (double)(ring1.maxDmg + ring2.maxDmg + amulet.maxDmg + offHand.maxDmg);
                avgDmg = (minDmg + maxDmg) / 2;
                dualMinDmg = minDmg;
                dualMaxDmg = maxDmg;
                dualAvgDmg = avgDmg;
            }
            else
            {
                minDmg = Math.Round((double)mainHand.minDmg / ((double)mainHand.increasedDamage / (double)100 + (double)1)) * ((double)mainHand.increasedDamage / (double)100 + (double)1) + (double)(ring1.minDmg + ring2.minDmg + amulet.minDmg);
                maxDmg = Math.Round((double)mainHand.maxDmg / ((double)mainHand.increasedDamage / (double)100 + (double)1)) * ((double)mainHand.increasedDamage / (double)100 + (double)1) + (double)(ring1.maxDmg + ring2.maxDmg + amulet.maxDmg);
                avgDmg = (minDmg + maxDmg) / 2;
                dualMinDmg = (minDmg + (Math.Round((double)dualWield.minDmg / ((double)dualWield.increasedDamage / (double)100 + (double)1)) * ((double)dualWield.increasedDamage / (double)100 + (double)1) + (double)(ring1.minDmg + ring2.minDmg + amulet.minDmg))) / 2;
                dualMaxDmg = (maxDmg + (Math.Round((double)dualWield.maxDmg / ((double)dualWield.increasedDamage / (double)100 + (double)1)) * ((double)dualWield.increasedDamage / (double)100 + (double)1) + (double)(ring1.maxDmg + ring2.maxDmg + amulet.maxDmg))) / 2;
                dualAvgDmg = (dualMinDmg + dualMaxDmg) / 2;
            }
            //bakar in attacks per second som spelet visar(oavrundat) direkt, jag kommer inte behöva räkna på bas vapen- eller bonus-farten något.
            if (dualWield.attacksPerSecond == 0)
            {
                attacksPerSecond = (Math.Round(mainHand.attacksPerSecond / (mainHand.attackSpeed / 100 + 1), 2) * (mainHand.attackSpeed / 100 + 1)) * ((helm.attackSpeed + chest.attackSpeed + belt.attackSpeed + legs.attackSpeed + boots.attackSpeed + ring1.attackSpeed + ring2.attackSpeed + amulet.attackSpeed + bracers.attackSpeed + hands.attackSpeed + offHand.attackSpeed) / 100 + 1);
                dualAttacksPerSecond = attacksPerSecond;
            }
                //dual wield attack speeds
            else
            {
                attacksPerSecond = (Math.Round(mainHand.attacksPerSecond / (mainHand.attackSpeed / (double)100 + (double)1), 2) * (mainHand.attackSpeed / (double)100 + (double)1)) * ((helm.attackSpeed + chest.attackSpeed + belt.attackSpeed + legs.attackSpeed + boots.attackSpeed + ring1.attackSpeed + ring2.attackSpeed + amulet.attackSpeed + bracers.attackSpeed + hands.attackSpeed + (double)15) / (double)100 + (double)1);
                dualAttacksPerSecond =Math.Round(2/(1/(attacksPerSecond)+1/((Math.Round(dualWield.attacksPerSecond / (dualWield.attackSpeed / (double)100 + (double)1), 2) * (dualWield.attackSpeed / (double)100 + (double)1)) * ((helm.attackSpeed + chest.attackSpeed + belt.attackSpeed + legs.attackSpeed + boots.attackSpeed + ring1.attackSpeed + ring2.attackSpeed + amulet.attackSpeed + bracers.attackSpeed + (double)15) / (double)100 + (double)1))),3);
            }
        }
        #endregion
    }
}
