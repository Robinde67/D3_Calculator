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
using Equipment;
using Damage;

namespace Stats
{
    public class StatsClass
    {
        DamageClass Damage = new DamageClass();
        //HP variabler, baseHP är den HP man får från vitality, samma med baseDodge från dexterity
        double HP;
        public int maxHP
        {
            get
            {
                return (int)HP;
            }
        }
        int baseHP;
        //attribut variabler
        #region Attributes
        int baseStrength;
        int strength;
        public int str
        {
            get
            {
                return strength;
            }
        }
        int baseDexterity;
        int dexterity;
        public int dex
        {
            get
            {
                return dexterity;
            }
        }
        int baseIntelligence;
        int intelligence;
        public int intel
        {
            get
            {
                return intelligence;
            }
        }
        int baseVitality;
        int vitality;
        public int vit
        {
            get
            {
                return vitality;
            }
        }
        #endregion
        //offensiva variabler
        #region Offensive
        public double minDmg;
        public double maxDmg;
        public double DPS;
        public double dualMinDmg;
        public double dualMaxDmg;
        public double dualDPS;
        double baseCritChance = 5;
        double critChance;
        public double criticalHitChance
        {
            get
            {
                return critChance;
            }
        }
        int baseCritDamage = 50;
        int critDamage;
        public int criticalHitDamage
        {
            get
            {
                return critDamage;
            }
        }
        public int skillDamage;

        #endregion
        //defensiva variabler
        #region Defensive
        int armor;
        public int totalArmor
        {
            get
            {
                return armor;
            }
        }
        #region Resistance
        double baseResistance;
        int allResistance;
        int physicalResistance;
        public int totalPhysResistance
        {
            get
            {
                return physicalResistance;
            }
        }
        int coldResistance;
        public int totalColdResistance
        {
            get
            {
                return coldResistance;
            }
        }
        int fireResistance;
        public int totalFireResistance
        {
            get
            {
                return fireResistance;
            }
        }
        int lightningResistance;
        public int totalLightResistance
        {
            get
            {
                return lightningResistance;
            }
        }
        int poisonResistance;
        public int totalPoisonResistance
        {
            get
            {
                return poisonResistance;
            }
        }
        int arcaneResistance;
        public int totalArcaneResistance
        {
            get
            {
                return arcaneResistance;
            }
        }
        #endregion
        double baseDodge;
        public double baseDodgeChance
        {
            get
            {
                return baseDodge;
            }
        }
        #endregion
        private void Update_BaseStats(int charLevel, string charClass, int paragonLevel)
        {
            //Barbarian har strength som primär stat
            if (charClass == "Barbarian")
            {
                baseStrength = 7 + charLevel * 3 + paragonLevel * 3;
                baseDexterity = 7 + charLevel * 1 + paragonLevel * 1;
                baseIntelligence = 7 + charLevel * 1 + paragonLevel * 1;
                baseVitality = 7 + charLevel * 2 + paragonLevel * 2;
            }
            //Wizard och Witch Doctor har intelligence som primär stat
            if (charClass == "Wizard" || charClass == "Witch Doctor")
            {
                baseStrength = 7 + charLevel * 1 + paragonLevel * 1;
                baseDexterity = 7 + charLevel * 1 + paragonLevel * 1;
                baseIntelligence = 7 + charLevel * 3 + paragonLevel * 3;
                baseVitality = 7 + charLevel * 2 + paragonLevel * 2;
            }
            //Demon Hunter och Monk har dexterity som primär stat
            if (charClass == "Demon Hunter" || charClass == "Monk")
            {
                baseStrength = 7 + charLevel * 1 + paragonLevel * 1;
                baseDexterity = 7 + charLevel * 3 + paragonLevel * 3;
                baseIntelligence = 7 + charLevel * 1 + paragonLevel * 1;
                baseVitality = 7 + charLevel * 2 + paragonLevel * 2;
            }

        }
        public void Update_Stats(EquipmentClass equipment, int charLevel, string charClass, int paragonLevel)
        {
            Update_BaseStats(charLevel, charClass, paragonLevel);
            //
            strength = baseStrength + equipment.strength;
            dexterity = baseDexterity + equipment.dexterity;
            intelligence = baseIntelligence + equipment.intelligence;
            vitality = baseVitality + equipment.vitality;
            critChance = baseCritChance + equipment.critChance;
            critDamage = baseCritDamage + equipment.critDmg;
            //baseHP formulan
            #region baseHP Formula
            if (charLevel <= 35)
            {
                baseHP = vitality * 10 + 36 + 4 * charLevel;
            }
            else
            {
                baseHP = vitality * (charLevel - 25) + (36 + 4 * charLevel);
            }
            #endregion
            //baseDodge formeln
            #region baseDodge Formula
            //räknas ut men visas inte på skärm, än
            if (true)
            {
                int tempDexterity = dexterity;
                if (tempDexterity >= 100)
                {
                    tempDexterity -= 100;
                    if (tempDexterity >= 400)
                    {
                        tempDexterity -= 400;
                        if (tempDexterity >= 500)
                        {
                            tempDexterity -= 500;
                            baseDodge = tempDexterity * 0.0001 + 0.3;
                        }
                        else
                        {
                            baseDodge = tempDexterity * 0.0002 + 0.2;
                        }
                    }
                    else
                    {
                        baseDodge = tempDexterity * 0.00025 + 0.1;
                    }
                }
                else
                {
                    baseDodge = tempDexterity * 0.001;
                }
            }
            #endregion
            //base armor och resistance
            armor = strength + equipment.armor;
            baseResistance = 0.1 * intelligence;
            //alla resistancer
            allResistance = (int)baseResistance + equipment.allRes;
            physicalResistance = allResistance + equipment.physRes;
            coldResistance = allResistance + equipment.coldRes;
            fireResistance = allResistance + equipment.fireRes;
            lightningResistance = allResistance + equipment.lightRes;
            poisonResistance = allResistance + equipment.poiRes;
            arcaneResistance = allResistance + equipment.arcRes;
            //totala HPn
            HP = (int)Math.Round(baseHP * ((decimal)equipment.HP / 100 + 1));
            //bas skada plus primary attribut på klasserna
            if (charClass == "Barbarian")
            {
                maxDmg = Damage.maxDamage(equipment.maxDmg, strength, skillDamage);
                minDmg = Damage.minDamage(equipment.minDmg, strength, skillDamage);
                DPS = Math.Round(Damage.DPS(equipment.avgDmg, strength, skillDamage, equipment.attacksPerSecond, critChance, critDamage), 2);
                dualMaxDmg = Damage.maxDamage(equipment.dualMaxDmg, strength, skillDamage);
                dualMinDmg = Damage.minDamage(equipment.dualMinDmg, strength, skillDamage);
                dualDPS = Math.Round(Damage.DPS(equipment.dualAvgDmg, strength, skillDamage, equipment.dualAttacksPerSecond, critChance, critDamage), 2);
            }
            if (charClass == "Demon Hunter" || charClass == "Monk")
            {
                maxDmg = Damage.maxDamage(equipment.maxDmg, dexterity, skillDamage);
                minDmg = Damage.minDamage(equipment.minDmg, dexterity, skillDamage);
                DPS = Math.Round(Damage.DPS(equipment.avgDmg, dexterity, skillDamage, equipment.attacksPerSecond, critChance, critDamage), 2);
                dualMaxDmg = Damage.maxDamage(equipment.dualMaxDmg, dexterity, skillDamage);
                dualMinDmg = Damage.minDamage(equipment.dualMinDmg, dexterity, skillDamage);
                dualDPS = Math.Round(Damage.DPS(equipment.dualAvgDmg, dexterity, skillDamage, equipment.dualAttacksPerSecond, critChance, critDamage), 2);
            }
            if (charClass == "Wizard" || charClass == "Witch Doctor")
            {
                maxDmg = Damage.maxDamage(equipment.maxDmg, intelligence, skillDamage);
                minDmg = Damage.minDamage(equipment.minDmg, intelligence, skillDamage);
                DPS = Math.Round(Damage.DPS(equipment.avgDmg, intelligence, skillDamage, equipment.attacksPerSecond, critChance, critDamage), 2);
                dualMaxDmg = Damage.maxDamage(equipment.dualMaxDmg, intelligence, skillDamage);
                dualMinDmg = Damage.minDamage(equipment.dualMinDmg, intelligence, skillDamage);
                dualDPS = Math.Round(Damage.DPS(equipment.dualAvgDmg, intelligence, skillDamage, equipment.dualAttacksPerSecond, critChance, critDamage),2);
            }
        }
    }
}
