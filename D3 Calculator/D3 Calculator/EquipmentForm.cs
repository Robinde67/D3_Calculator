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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Equipment;

namespace D3_Calculator
{
    public partial class EquipmentForm : Form
    {
        public EquipmentClass equipment;
        public EquipmentForm(EquipmentClass equipped, string eqPart)
        {
            equipment = equipped;
            InitializeComponent();
            this.Text = eqPart;
            AddBoxRanges();
            LoadEquipment();
            this.Icon = null;
        }

        private void EquipmentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveEquipment();        
            this.Close();
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //funktioner
        #region Functions
        #region Save Equipment function
        //Spara ändrad data till equipment för att hämtas av MainForm
        private void SaveEquipment()
        {
            if (this.Text == "Main Hand")
            {
                equipment.mainHand.minDmg = minDmg.SelectedIndex;
                equipment.mainHand.maxDmg = maxDmg.SelectedIndex;
                equipment.mainHand.strength = str.SelectedIndex;
                equipment.mainHand.dexterity = dex.SelectedIndex;
                equipment.mainHand.intelligence = intel.SelectedIndex;
                equipment.mainHand.vitality = vit.SelectedIndex;
                equipment.mainHand.attacksPerSecond = Math.Round(((double)APS.SelectedIndex / 100 + 0.9f), 2);
                equipment.mainHand.attackSpeed = IAS.SelectedIndex;
                equipment.mainHand.increasedDamage= increasedDmg.SelectedIndex;
                equipment.mainHand.critDmg = increasedCritDmg.SelectedIndex;
                equipment.mainHand.lifeSteal = Math.Round((double)lifeSteal.SelectedIndex / 10,1);
            }
            if (this.Text == "Off Hand")
            {
                equipment.offHand.minDmg=minDmg.SelectedIndex;
                equipment.offHand.maxDmg=maxDmg.SelectedIndex;
                equipment.offHand.strength=str.SelectedIndex;
                equipment.offHand.dexterity=dex.SelectedIndex;
                equipment.offHand.intelligence=intel.SelectedIndex;
                equipment.offHand.vitality=vit.SelectedIndex;
                equipment.offHand.attackSpeed=IAS.SelectedIndex;
                equipment.offHand.critChance=increasedCritChance.SelectedIndex/2;
                equipment.offHand.armor=armor.SelectedIndex;
                equipment.offHand.allResistance=allRes.SelectedIndex;
                equipment.offHand.physicalResistance=physRes.SelectedIndex;
                equipment.offHand.coldResistance=coldRes.SelectedIndex;
                equipment.offHand.fireResistance=fireRes.SelectedIndex;
                equipment.offHand.lightningResistance=lightRes.SelectedIndex;
                equipment.offHand.poisonResistance=poisonRes.SelectedIndex;
                equipment.offHand.arcaneResistance=arcRes.SelectedIndex;
                equipment.offHand.HP=HP.SelectedIndex;
            }
            if (this.Text == "Bracer")
            {
                equipment.bracers.strength=str.SelectedIndex;
                equipment.bracers.dexterity=dex.SelectedIndex;
                equipment.bracers.intelligence=intel.SelectedIndex;
                equipment.bracers.vitality=vit.SelectedIndex;
                equipment.bracers.attackSpeed = IAS.SelectedIndex;
                equipment.bracers.critChance = (double)increasedCritChance.SelectedIndex / 2;
                equipment.bracers.armor=armor.SelectedIndex;
                equipment.bracers.allResistance=allRes.SelectedIndex;
                equipment.bracers.physicalResistance=physRes.SelectedIndex;
                equipment.bracers.coldResistance=coldRes.SelectedIndex;
                equipment.bracers.fireResistance=fireRes.SelectedIndex;
                equipment.bracers.lightningResistance=lightRes.SelectedIndex;
                equipment.bracers.poisonResistance=poisonRes.SelectedIndex;
                equipment.bracers.arcaneResistance=arcRes.SelectedIndex;
                equipment.bracers.HP=HP.SelectedIndex;
            }
            if (this.Text == "Hands")
            {
                equipment.hands.strength=str.SelectedIndex;
                equipment.hands.dexterity=dex.SelectedIndex;
                equipment.hands.intelligence=intel.SelectedIndex;
                equipment.hands.vitality=vit.SelectedIndex;
                equipment.hands.attackSpeed=IAS.SelectedIndex;
                equipment.hands.critChance = (double)increasedCritChance.SelectedIndex / 2;
                equipment.hands.critDmg=increasedCritDmg.SelectedIndex;
                equipment.hands.armor=armor.SelectedIndex;
                equipment.hands.allResistance=allRes.SelectedIndex;
                equipment.hands.physicalResistance=physRes.SelectedIndex;
                equipment.hands.coldResistance=coldRes.SelectedIndex;
                equipment.hands.fireResistance=fireRes.SelectedIndex;
                equipment.hands.lightningResistance=lightRes.SelectedIndex;
                equipment.hands.poisonResistance=poisonRes.SelectedIndex;
                equipment.hands.arcaneResistance=arcRes.SelectedIndex;
                equipment.hands.HP=HP.SelectedIndex;
            }
            if (this.Text == "Shoulders")
            {
                equipment.shoulders.strength=str.SelectedIndex;
                equipment.shoulders.dexterity=dex.SelectedIndex;
                equipment.shoulders.intelligence=intel.SelectedIndex;
                equipment.shoulders.vitality=vit.SelectedIndex;
                equipment.shoulders.armor=armor.SelectedIndex;
                equipment.shoulders.allResistance=allRes.SelectedIndex;
                equipment.shoulders.physicalResistance=physRes.SelectedIndex;
                equipment.shoulders.coldResistance=coldRes.SelectedIndex;
                equipment.shoulders.fireResistance=fireRes.SelectedIndex;
                equipment.shoulders.lightningResistance=lightRes.SelectedIndex;
                equipment.shoulders.poisonResistance=poisonRes.SelectedIndex;
                equipment.shoulders.arcaneResistance=arcRes.SelectedIndex;
                equipment.shoulders.HP=HP.SelectedIndex;
            }
            if (this.Text == "Helm")
            {
                equipment.helm.strength=str.SelectedIndex;
                equipment.helm.dexterity=dex.SelectedIndex;
                equipment.helm.intelligence=intel.SelectedIndex;
                equipment.helm.vitality=vit.SelectedIndex;
                equipment.helm.attackSpeed=IAS.SelectedIndex;
                equipment.helm.critChance = (double)increasedCritChance.SelectedIndex / 2;
                equipment.helm.armor=armor.SelectedIndex;
                equipment.helm.allResistance=allRes.SelectedIndex;
                equipment.helm.physicalResistance=physRes.SelectedIndex;
                equipment.helm.coldResistance=coldRes.SelectedIndex;
                equipment.helm.fireResistance=fireRes.SelectedIndex;
                equipment.helm.lightningResistance=lightRes.SelectedIndex;
                equipment.helm.poisonResistance=poisonRes.SelectedIndex;
                equipment.helm.arcaneResistance=arcRes.SelectedIndex;
                equipment.helm.HP=HP.SelectedIndex;
            }
            if (this.Text == "Chest")
            {
                equipment.chest.strength=str.SelectedIndex;
                equipment.chest.dexterity=dex.SelectedIndex;
                equipment.chest.intelligence=intel.SelectedIndex;
                equipment.chest.vitality=vit.SelectedIndex;
                equipment.chest.attackSpeed=IAS.SelectedIndex;
                equipment.chest.armor=armor.SelectedIndex;
                equipment.chest.allResistance=allRes.SelectedIndex;
                equipment.chest.physicalResistance=physRes.SelectedIndex;
                equipment.chest.coldResistance=coldRes.SelectedIndex;
                equipment.chest.fireResistance=fireRes.SelectedIndex;
                equipment.chest.lightningResistance=lightRes.SelectedIndex;
                equipment.chest.poisonResistance=poisonRes.SelectedIndex;
                equipment.chest.arcaneResistance=arcRes.SelectedIndex;
                equipment.chest.HP=HP.SelectedIndex;
            }
            if (this.Text == "Belt")
            {
                equipment.belt.strength=str.SelectedIndex;
                equipment.belt.dexterity=dex.SelectedIndex;
                equipment.belt.intelligence=intel.SelectedIndex;
                equipment.belt.vitality=vit.SelectedIndex;
                equipment.belt.attackSpeed=IAS.SelectedIndex;
                equipment.belt.critDmg=increasedCritDmg.SelectedIndex;
                equipment.belt.armor=armor.SelectedIndex;
                equipment.belt.allResistance=allRes.SelectedIndex;
                equipment.belt.physicalResistance=physRes.SelectedIndex;
                equipment.belt.coldResistance=coldRes.SelectedIndex;
                equipment.belt.fireResistance=fireRes.SelectedIndex;
                equipment.belt.lightningResistance=lightRes.SelectedIndex;
                equipment.belt.poisonResistance=poisonRes.SelectedIndex;
                equipment.belt.arcaneResistance=arcRes.SelectedIndex;
                equipment.belt.HP=HP.SelectedIndex;
            }
            if (this.Text == "Legs")
            {
                equipment.legs.strength=str.SelectedIndex;
                equipment.legs.dexterity=dex.SelectedIndex;
                equipment.legs.intelligence=intel.SelectedIndex;
                equipment.legs.vitality=vit.SelectedIndex;
                equipment.legs.attackSpeed=IAS.SelectedIndex;
                equipment.legs.critChance = (double)increasedCritChance.SelectedIndex / 2;
                equipment.legs.armor=armor.SelectedIndex;
                equipment.legs.allResistance=allRes.SelectedIndex;
                equipment.legs.physicalResistance=physRes.SelectedIndex;
                equipment.legs.coldResistance=coldRes.SelectedIndex;
                equipment.legs.fireResistance=fireRes.SelectedIndex;
                equipment.legs.lightningResistance=lightRes.SelectedIndex;
                equipment.legs.poisonResistance=poisonRes.SelectedIndex;
                equipment.legs.arcaneResistance=arcRes.SelectedIndex;
                equipment.legs.HP=HP.SelectedIndex;
            }
            if (this.Text == "Boots")
            {
                equipment.boots.strength=str.SelectedIndex;
                equipment.boots.dexterity=dex.SelectedIndex;
                equipment.boots.intelligence=intel.SelectedIndex;
                equipment.boots.vitality=vit.SelectedIndex;
                equipment.boots.attackSpeed=IAS.SelectedIndex;
                equipment.boots.armor=armor.SelectedIndex;
                equipment.boots.allResistance=allRes.SelectedIndex;
                equipment.boots.physicalResistance=physRes.SelectedIndex;
                equipment.boots.coldResistance=coldRes.SelectedIndex;
                equipment.boots.fireResistance=fireRes.SelectedIndex;
                equipment.boots.lightningResistance=lightRes.SelectedIndex;
                equipment.boots.poisonResistance=poisonRes.SelectedIndex;
                equipment.boots.arcaneResistance=arcRes.SelectedIndex;
                equipment.boots.HP=HP.SelectedIndex;
            }
            if (this.Text == "Amulet")
            {
                equipment.amulet.minDmg=minDmg.SelectedIndex;
                equipment.amulet.maxDmg=maxDmg.SelectedIndex;
                equipment.amulet.strength=str.SelectedIndex;
                equipment.amulet.dexterity=dex.SelectedIndex;
                equipment.amulet.intelligence=intel.SelectedIndex;
                equipment.amulet.vitality=vit.SelectedIndex;
                equipment.amulet.attackSpeed=IAS.SelectedIndex;
                equipment.amulet.critChance = (double)increasedCritChance.SelectedIndex / 2;
                equipment.amulet.critDmg=increasedCritDmg.SelectedIndex;
                equipment.amulet.armor=armor.SelectedIndex;
                equipment.amulet.allResistance=allRes.SelectedIndex;
                equipment.amulet.physicalResistance=physRes.SelectedIndex;
                equipment.amulet.coldResistance=coldRes.SelectedIndex;
                equipment.amulet.fireResistance=fireRes.SelectedIndex;
                equipment.amulet.lightningResistance=lightRes.SelectedIndex;
                equipment.amulet.poisonResistance=poisonRes.SelectedIndex;
                equipment.amulet.arcaneResistance=arcRes.SelectedIndex;
                equipment.amulet.HP=HP.SelectedIndex;
            }
            if (this.Text == "Ring 1")
            {
                equipment.ring1.minDmg=minDmg.SelectedIndex;
                equipment.ring1.maxDmg=maxDmg.SelectedIndex;
                equipment.ring1.strength=str.SelectedIndex;
                equipment.ring1.dexterity=dex.SelectedIndex;
                equipment.ring1.intelligence=intel.SelectedIndex;
                equipment.ring1.vitality=vit.SelectedIndex;
                equipment.ring1.attackSpeed=IAS.SelectedIndex;
                equipment.ring1.critChance = (double)increasedCritChance.SelectedIndex / 2;
                equipment.ring1.critDmg=increasedCritDmg.SelectedIndex;
                equipment.ring1.armor=armor.SelectedIndex;
                equipment.ring1.allResistance=allRes.SelectedIndex;
                equipment.ring1.physicalResistance=physRes.SelectedIndex;
                equipment.ring1.coldResistance=coldRes.SelectedIndex;
                equipment.ring1.fireResistance=fireRes.SelectedIndex;
                equipment.ring1.lightningResistance=lightRes.SelectedIndex;
                equipment.ring1.poisonResistance=poisonRes.SelectedIndex;
                equipment.ring1.arcaneResistance=arcRes.SelectedIndex;
                equipment.ring1.HP=HP.SelectedIndex;
            }
            if (this.Text == "Ring 2")
            {
                equipment.ring2.minDmg=minDmg.SelectedIndex;
                equipment.ring2.maxDmg=maxDmg.SelectedIndex;
                equipment.ring2.strength=str.SelectedIndex;
                equipment.ring2.dexterity=dex.SelectedIndex;
                equipment.ring2.intelligence=intel.SelectedIndex;
                equipment.ring2.vitality=vit.SelectedIndex;
                equipment.ring2.attackSpeed=IAS.SelectedIndex;
                equipment.ring2.critChance = (double)increasedCritChance.SelectedIndex / 2;
                equipment.ring2.critDmg=increasedCritDmg.SelectedIndex;
                equipment.ring2.armor=armor.SelectedIndex;
                equipment.ring2.allResistance=allRes.SelectedIndex;
                equipment.ring2.physicalResistance=physRes.SelectedIndex;
                equipment.ring2.coldResistance=coldRes.SelectedIndex;
                equipment.ring2.fireResistance=fireRes.SelectedIndex;
                equipment.ring2.lightningResistance=lightRes.SelectedIndex;
                equipment.ring2.poisonResistance=poisonRes.SelectedIndex;
                equipment.ring2.arcaneResistance=arcRes.SelectedIndex;
                equipment.ring2.HP = HP.SelectedIndex;
            }
            if (this.Text == "Dual Wield")
            {
                equipment.dualWield.minDmg = minDmg.SelectedIndex;
                equipment.dualWield.maxDmg = maxDmg.SelectedIndex;
                equipment.dualWield.strength = str.SelectedIndex;
                equipment.dualWield.dexterity = dex.SelectedIndex;
                equipment.dualWield.intelligence = intel.SelectedIndex;
                equipment.dualWield.vitality = vit.SelectedIndex;
                equipment.dualWield.attacksPerSecond = Math.Round(((double)APS.SelectedIndex / 100 + 0.9f), 2);
                equipment.dualWield.attackSpeed = IAS.SelectedIndex;
                equipment.dualWield.increasedDamage = increasedDmg.SelectedIndex;
                equipment.dualWield.critDmg = increasedCritDmg.SelectedIndex;
                equipment.dualWield.lifeSteal = Math.Round((double)lifeSteal.SelectedIndex / 10, 1);
            }
        }
        #endregion

        #region Load Equipment function
        //ladda all sparad data från MainForm till fälten efter equipment.valdDel, sätt max värden på olika delar och dölj oanvända fält
        private void LoadEquipment()
        {
            //alla attack speed stats har blivit halverade
            if (this.Text == "Main Hand")
            {
                for (int i = 0; i <= 11; i++)
                {
                    IAS.Items.Add(i);
                }
                for (int i = 0; i <= 2000; i++)
                {
                    minDmg.Items.Add(i);
                }
                for (int i = 0; i <= 2000; i++)
                {
                    maxDmg.Items.Add(i);
                }
                for (int i = 0; i <= 170; i++)
                {
                    increasedCritDmg.Items.Add(i);
                }
                for (int i = 0; i <= 76; i++)
                {
                    //räkna ut det tillgängliga värdena på attack speed där 0.9 är lägsta och 1,75 är högsta möjliga värdet
                    //var tvungen att använda avrundning, för programmet ville göra fler doubleer än vad som borde vara där på några tal.
                    //efter patchen 20/06 är attack speed staten halverad, vilket även inkluderar hur snabbt vapnet kan vara, nuvarande högsta är 1,66
                    APS.Items.Add(Math.Round((double)i / 100 + 0.9f, 2));
                }
                for (int i = 0; i <= 30; i++)
                {
                    lifeSteal.Items.Add(Math.Round(((double)i / 10),1));
                }
                minDmg.SelectedIndex = equipment.mainHand.minDmg;
                maxDmg.SelectedIndex = equipment.mainHand.maxDmg;
                str.SelectedIndex = equipment.mainHand.strength;
                dex.SelectedIndex = equipment.mainHand.dexterity;
                intel.SelectedIndex = equipment.mainHand.intelligence;
                vit.SelectedIndex = equipment.mainHand.vitality;
                APS.SelectedIndex = (int)Math.Round(((equipment.mainHand.attacksPerSecond - 0.9f)*100),2);
                IAS.SelectedIndex = (int)equipment.mainHand.attackSpeed;
                increasedDmg.SelectedIndex = equipment.mainHand.increasedDamage;
                increasedCritDmg.SelectedIndex = equipment.mainHand.critDmg;
                lifeSteal.SelectedIndex = (int)Math.Round((equipment.mainHand.lifeSteal * 10));
                //dolda fält
                groupDefensive.Visible = false;
                HP.Visible = false;
                labelHP.Visible = false;
                increasedCritChance.Visible = false;
                labelCritChance.Visible = false;
            }
            if (this.Text == "Off Hand")
            {
                for (int i = 0; i <= 20; i++)
                {
                    //utom quivers, AKA off hand
                    IAS.Items.Add(i);
                }
                for (int i = 0; i <= 20; i++)
                {
                    increasedCritChance.Items.Add((double)i / 2);
                }
                for (int i = 0; i <= 150; i++)
                {
                    minDmg.Items.Add(i);
                }
                for (int i = 0; i <= 400; i++)
                {
                    maxDmg.Items.Add(i);
                }
                minDmg.SelectedIndex = equipment.offHand.minDmg;
                maxDmg.SelectedIndex = equipment.offHand.maxDmg;
                str.SelectedIndex = equipment.offHand.strength;
                dex.SelectedIndex = equipment.offHand.dexterity;
                intel.SelectedIndex = equipment.offHand.intelligence;
                vit.SelectedIndex = equipment.offHand.vitality;
                IAS.SelectedIndex = (int)equipment.offHand.attackSpeed;
                increasedCritChance.SelectedIndex = (int)(equipment.offHand.critChance * 2);
                armor.SelectedIndex = equipment.offHand.armor;
                allRes.SelectedIndex = equipment.offHand.allResistance;
                physRes.SelectedIndex = equipment.offHand.physicalResistance;
                coldRes.SelectedIndex = equipment.offHand.coldResistance;
                fireRes.SelectedIndex = equipment.offHand.fireResistance;
                lightRes.SelectedIndex = equipment.offHand.lightningResistance;
                poisonRes.SelectedIndex = equipment.offHand.poisonResistance;
                arcRes.SelectedIndex = equipment.offHand.arcaneResistance;
                HP.SelectedIndex = equipment.offHand.HP;
                //dolda fält
                increasedDmg.Visible = false;
                labelIDmg.Visible = false;
                APS.Visible = false;
                labelAPS.Visible = false;
                increasedCritDmg.Visible = false;
                labelCritDmg.Visible = false;
                labelLifeSteal.Visible = false;
                lifeSteal.Visible = false;
            }
            if (this.Text == "Bracer")
            {
                for (int i = 0; i <= 12; i++)
                {
                    increasedCritChance.Items.Add((double)i / 2);
                }
                for (int i = 0; i <= 7; i++)
                {
                    IAS.Items.Add(i);
                }
                str.SelectedIndex = equipment.bracers.strength;
                dex.SelectedIndex = equipment.bracers.dexterity;
                intel.SelectedIndex = equipment.bracers.intelligence;
                vit.SelectedIndex = equipment.bracers.vitality;
                IAS.SelectedIndex = (int)equipment.bracers.attackSpeed;
                increasedCritChance.SelectedIndex = (int)(equipment.bracers.critChance * 2);
                armor.SelectedIndex = equipment.bracers.armor;
                allRes.SelectedIndex = equipment.bracers.allResistance;
                physRes.SelectedIndex = equipment.bracers.physicalResistance;
                coldRes.SelectedIndex = equipment.bracers.coldResistance;
                fireRes.SelectedIndex = equipment.bracers.fireResistance;
                lightRes.SelectedIndex = equipment.bracers.lightningResistance;
                poisonRes.SelectedIndex = equipment.bracers.poisonResistance;
                arcRes.SelectedIndex = equipment.bracers.arcaneResistance;
                HP.SelectedIndex = equipment.bracers.HP;
                //dolda fält
                increasedDmg.Visible = false;
                labelIDmg.Visible = false;
                APS.Visible = false;
                labelAPS.Visible = false;
                minDmg.Visible = false;
                labelMinDmg.Visible = false;
                maxDmg.Visible = false;
                labelMaxDmg.Visible = false;
                increasedCritDmg.Visible = false;
                labelCritDmg.Visible = false;
                labelLifeSteal.Visible = false;
                lifeSteal.Visible = false;
            }
            if (this.Text == "Hands")
            {
                for (int i = 0; i <= 9; i++)
                {
                    IAS.Items.Add(i);
                }
                for (int i = 0; i <= 20; i++)
                {
                    increasedCritChance.Items.Add((double)i / 2);
                }
                for (int i = 0; i <= 50; i++)
                {
                    increasedCritDmg.Items.Add(i);
                }
                str.SelectedIndex = equipment.hands.strength;
                dex.SelectedIndex = equipment.hands.dexterity;
                intel.SelectedIndex = equipment.hands.intelligence;
                vit.SelectedIndex = equipment.hands.vitality;
                IAS.SelectedIndex = (int)equipment.hands.attackSpeed;
                increasedCritChance.SelectedIndex = (int)(equipment.hands.critChance * 2);
                increasedCritDmg.SelectedIndex= equipment.hands.critDmg;
                armor.SelectedIndex = equipment.hands.armor;
                allRes.SelectedIndex = equipment.hands.allResistance;
                physRes.SelectedIndex = equipment.hands.physicalResistance;
                coldRes.SelectedIndex = equipment.hands.coldResistance;
                fireRes.SelectedIndex = equipment.hands.fireResistance;
                lightRes.SelectedIndex = equipment.hands.lightningResistance;
                poisonRes.SelectedIndex = equipment.hands.poisonResistance;
                arcRes.SelectedIndex = equipment.hands.arcaneResistance;
                HP.SelectedIndex = equipment.hands.HP;
                //dolda fält
                increasedDmg.Visible = false;
                labelIDmg.Visible = false;
                APS.Visible = false;
                labelAPS.Visible = false;
                minDmg.Visible = false;
                labelMinDmg.Visible = false;
                maxDmg.Visible = false;
                labelMaxDmg.Visible = false;
                labelLifeSteal.Visible = false;
                lifeSteal.Visible = false;
            }
            if (this.Text == "Shoulders")
            {
                str.SelectedIndex = equipment.shoulders.strength;
                dex.SelectedIndex = equipment.shoulders.dexterity;
                intel.SelectedIndex = equipment.shoulders.intelligence;
                vit.SelectedIndex = equipment.shoulders.vitality;
                armor.SelectedIndex = equipment.shoulders.armor;
                allRes.SelectedIndex = equipment.shoulders.allResistance;
                physRes.SelectedIndex = equipment.shoulders.physicalResistance;
                coldRes.SelectedIndex = equipment.shoulders.coldResistance;
                fireRes.SelectedIndex = equipment.shoulders.fireResistance;
                lightRes.SelectedIndex = equipment.shoulders.lightningResistance;
                poisonRes.SelectedIndex = equipment.shoulders.poisonResistance;
                arcRes.SelectedIndex = equipment.shoulders.arcaneResistance;
                HP.SelectedIndex = equipment.shoulders.HP;
                //doldt fält
                groupOffensive.Visible = false;
            }
            if (this.Text == "Helm")
            {
                for (int i = 0; i <= 7; i++)
                {
                    IAS.Items.Add(i);
                }
                for (int i = 0; i <= 10; i++)
                {
                    increasedCritChance.Items.Add((double)i / 2);
                }
                str.SelectedIndex = equipment.helm.strength;
                dex.SelectedIndex = equipment.helm.dexterity;
                intel.SelectedIndex = equipment.helm.intelligence;
                vit.SelectedIndex = equipment.helm.vitality;
                IAS.SelectedIndex = (int)equipment.helm.attackSpeed;
                increasedCritChance.SelectedIndex = (int)(equipment.helm.critChance * 2);
                armor.SelectedIndex = equipment.helm.armor;
                allRes.SelectedIndex = equipment.helm.allResistance;
                physRes.SelectedIndex = equipment.helm.physicalResistance;
                coldRes.SelectedIndex = equipment.helm.coldResistance;
                fireRes.SelectedIndex = equipment.helm.fireResistance;
                lightRes.SelectedIndex = equipment.helm.lightningResistance;
                poisonRes.SelectedIndex = equipment.helm.poisonResistance;
                arcRes.SelectedIndex = equipment.helm.arcaneResistance;
                HP.SelectedIndex = equipment.helm.HP;
                //dolda fält
                increasedDmg.Visible = false;
                labelIDmg.Visible = false;
                APS.Visible = false;
                labelAPS.Visible = false;
                minDmg.Visible = false;
                labelMinDmg.Visible = false;
                maxDmg.Visible = false;
                labelMaxDmg.Visible = false;
                increasedCritDmg.Visible = false;
                labelCritDmg.Visible = false;
                labelLifeSteal.Visible = false;
                lifeSteal.Visible = false;
            }
            if (this.Text == "Chest")
            {
                for (int i = 0; i <= 7; i++)
                {
                    IAS.Items.Add(i);
                }
                str.SelectedIndex = equipment.chest.strength;
                dex.SelectedIndex = equipment.chest.dexterity;
                intel.SelectedIndex = equipment.chest.intelligence;
                vit.SelectedIndex = equipment.chest.vitality;
                IAS.SelectedIndex = (int)equipment.chest.attackSpeed;
                armor.SelectedIndex = equipment.chest.armor;
                allRes.SelectedIndex = equipment.chest.allResistance;
                physRes.SelectedIndex = equipment.chest.physicalResistance;
                coldRes.SelectedIndex = equipment.chest.coldResistance;
                fireRes.SelectedIndex = equipment.chest.fireResistance;
                lightRes.SelectedIndex = equipment.chest.lightningResistance;
                poisonRes.SelectedIndex = equipment.chest.poisonResistance;
                arcRes.SelectedIndex = equipment.chest.arcaneResistance;
                HP.SelectedIndex = equipment.chest.HP;
                //dolda fält
                increasedDmg.Visible = false;
                labelIDmg.Visible = false;
                APS.Visible = false;
                labelAPS.Visible = false;
                minDmg.Visible = false;
                labelMinDmg.Visible = false;
                maxDmg.Visible = false;
                labelMaxDmg.Visible = false;
                increasedCritChance.Visible = false;
                labelCritChance.Visible = false;
                increasedCritDmg.Visible = false;
                labelCritDmg.Visible = false;
                labelLifeSteal.Visible = false;
                lifeSteal.Visible = false;
            }
            if (this.Text == "Belt")
            {
                for (int i = 0; i <= 6; i++)
                {
                    IAS.Items.Add(i);
                }
                for (int i = 0; i <= 12; i++)
                {
                    increasedCritDmg.Items.Add(i);
                }
                str.SelectedIndex = equipment.belt.strength;
                dex.SelectedIndex = equipment.belt.dexterity;
                intel.SelectedIndex = equipment.belt.intelligence;
                vit.SelectedIndex = equipment.belt.vitality;
                IAS.SelectedIndex = (int)equipment.belt.attackSpeed;
                increasedCritDmg.SelectedIndex = equipment.belt.critDmg;
                armor.SelectedIndex = equipment.belt.armor;
                allRes.SelectedIndex = equipment.belt.allResistance;
                physRes.SelectedIndex = equipment.belt.physicalResistance;
                coldRes.SelectedIndex = equipment.belt.coldResistance;
                fireRes.SelectedIndex = equipment.belt.fireResistance;
                lightRes.SelectedIndex = equipment.belt.lightningResistance;
                poisonRes.SelectedIndex = equipment.belt.poisonResistance;
                arcRes.SelectedIndex = equipment.belt.arcaneResistance;
                HP.SelectedIndex = equipment.belt.HP;
                //dolda fält
                increasedDmg.Visible = false;
                labelIDmg.Visible = false;
                APS.Visible = false;
                labelAPS.Visible = false;
                minDmg.Visible = false;
                labelMinDmg.Visible = false;
                maxDmg.Visible = false;
                labelMaxDmg.Visible = false;
                increasedCritChance.Visible = false;
                labelCritChance.Visible = false;
                labelLifeSteal.Visible = false;
                lifeSteal.Visible = false;
            }
            if (this.Text == "Legs")
            {
                for (int i = 0; i <= 8; i++)
                {
                    IAS.Items.Add(i);
                }
                for (int i = 0; i <= 2; i++)
                {
                    increasedCritChance.Items.Add(i / 2);
                }
                str.SelectedIndex = equipment.legs.strength;
                dex.SelectedIndex = equipment.legs.dexterity;
                intel.SelectedIndex = equipment.legs.intelligence;
                vit.SelectedIndex = equipment.legs.vitality;
                IAS.SelectedIndex = (int)equipment.legs.attackSpeed;
                increasedCritChance.SelectedIndex = (int)(equipment.legs.critChance * 2);
                armor.SelectedIndex = equipment.legs.armor;
                allRes.SelectedIndex = equipment.legs.allResistance;
                physRes.SelectedIndex = equipment.legs.physicalResistance;
                coldRes.SelectedIndex = equipment.legs.coldResistance;
                fireRes.SelectedIndex = equipment.legs.fireResistance;
                lightRes.SelectedIndex = equipment.legs.lightningResistance;
                poisonRes.SelectedIndex = equipment.legs.poisonResistance;
                arcRes.SelectedIndex = equipment.legs.arcaneResistance;
                HP.SelectedIndex = equipment.legs.HP;
                //dolda fält
                increasedDmg.Visible = false;
                labelIDmg.Visible = false;
                APS.Visible = false;
                labelAPS.Visible = false;
                minDmg.Visible = false;
                labelMinDmg.Visible = false;
                maxDmg.Visible = false;
                labelMaxDmg.Visible = false;
                increasedCritDmg.Visible = false;
                labelCritDmg.Visible = false;
                labelLifeSteal.Visible = false;
                lifeSteal.Visible = false;
            }
            if (this.Text == "Boots")
            {
                for (int i = 0; i <= 6; i++)
                {
                    IAS.Items.Add(i);
                }
                str.SelectedIndex = equipment.boots.strength;
                dex.SelectedIndex = equipment.boots.dexterity;
                intel.SelectedIndex = equipment.boots.intelligence;
                vit.SelectedIndex = equipment.boots.vitality;
                IAS.SelectedIndex = (int)equipment.boots.attackSpeed;
                armor.SelectedIndex = equipment.boots.armor;
                allRes.SelectedIndex = equipment.boots.allResistance;
                physRes.SelectedIndex = equipment.boots.physicalResistance;
                coldRes.SelectedIndex = equipment.boots.coldResistance;
                fireRes.SelectedIndex = equipment.boots.fireResistance;
                lightRes.SelectedIndex = equipment.boots.lightningResistance;
                poisonRes.SelectedIndex = equipment.boots.poisonResistance;
                arcRes.SelectedIndex = equipment.boots.arcaneResistance;
                HP.SelectedIndex = equipment.boots.HP;
                //dolda fält
                increasedDmg.Visible = false;
                labelIDmg.Visible = false;
                APS.Visible = false;
                labelAPS.Visible = false;
                minDmg.Visible = false;
                labelMinDmg.Visible = false;
                maxDmg.Visible = false;
                labelMaxDmg.Visible = false;
                increasedCritChance.Visible = false;
                labelCritChance.Visible = false;
                increasedCritDmg.Visible = false;
                labelCritDmg.Visible = false;
                labelLifeSteal.Visible = false;
                lifeSteal.Visible = false;
            }
            if (this.Text == "Amulet")
            {
                for (int i = 0; i <= 9; i++)
                {
                    IAS.Items.Add(i);
                }
                for (int i = 0; i <= 18; i++)
                {
                    increasedCritChance.Items.Add((double)i / 2);
                }
                for (int i = 0; i <= 30; i++)
                {
                    minDmg.Items.Add(i);
                }
                for (int i = 0; i <= 50; i++)
                {
                    maxDmg.Items.Add(i);
                }
                for (int i = 0; i <= 65; i++)
                {
                    increasedCritDmg.Items.Add(i);
                }
                minDmg.SelectedIndex = equipment.amulet.minDmg;
                maxDmg.SelectedIndex = equipment.amulet.maxDmg;
                str.SelectedIndex = equipment.amulet.strength;
                dex.SelectedIndex = equipment.amulet.dexterity;
                intel.SelectedIndex = equipment.amulet.intelligence;
                vit.SelectedIndex = equipment.amulet.vitality;
                IAS.SelectedIndex = (int)equipment.amulet.attackSpeed;
                increasedCritChance.SelectedIndex = (int)(equipment.amulet.critChance * 2);
                increasedCritDmg.SelectedIndex= equipment.amulet.critDmg;
                armor.SelectedIndex = equipment.amulet.armor;
                allRes.SelectedIndex = equipment.amulet.allResistance;
                physRes.SelectedIndex = equipment.amulet.physicalResistance;
                coldRes.SelectedIndex = equipment.amulet.coldResistance;
                fireRes.SelectedIndex = equipment.amulet.fireResistance;
                lightRes.SelectedIndex = equipment.amulet.lightningResistance;
                poisonRes.SelectedIndex = equipment.amulet.poisonResistance;
                arcRes.SelectedIndex = equipment.amulet.arcaneResistance;
                HP.SelectedIndex = equipment.amulet.HP;
                //dolda fält
                increasedDmg.Visible = false;
                labelIDmg.Visible = false;
                APS.Visible = false;
                labelAPS.Visible = false;
                labelLifeSteal.Visible = false;
                lifeSteal.Visible = false;
            }
            if (this.Text == "Ring 1")
            {
                for (int i = 0; i <= 8; i++)
                {
                    IAS.Items.Add(i);
                }
                for (int i = 0; i <= 8; i++)
                {
                    increasedCritChance.Items.Add((double)i / 2);
                }
                for (int i = 0; i <= 30; i++)
                {
                    minDmg.Items.Add(i);
                }
                for (int i = 0; i <= 50; i++)
                {
                    maxDmg.Items.Add(i);
                }
                for (int i = 0; i <= 35; i++)
                {
                    increasedCritDmg.Items.Add(i);
                }
                minDmg.SelectedIndex = equipment.ring1.minDmg;
                maxDmg.SelectedIndex = equipment.ring1.maxDmg;
                str.SelectedIndex = equipment.ring1.strength;
                dex.SelectedIndex = equipment.ring1.dexterity;
                intel.SelectedIndex = equipment.ring1.intelligence;
                vit.SelectedIndex = equipment.ring1.vitality;
                IAS.SelectedIndex = (int)equipment.ring1.attackSpeed;
                increasedCritChance.SelectedIndex = (int)(equipment.ring1.critChance * 2);
                increasedCritDmg.SelectedIndex= equipment.ring1.critDmg;
                armor.SelectedIndex = equipment.ring1.armor;
                allRes.SelectedIndex = equipment.ring1.allResistance;
                physRes.SelectedIndex = equipment.ring1.physicalResistance;
                coldRes.SelectedIndex = equipment.ring1.coldResistance;
                fireRes.SelectedIndex = equipment.ring1.fireResistance;
                lightRes.SelectedIndex = equipment.ring1.lightningResistance;
                poisonRes.SelectedIndex = equipment.ring1.poisonResistance;
                arcRes.SelectedIndex = equipment.ring1.arcaneResistance;
                HP.SelectedIndex = equipment.ring1.HP;
                //dolda fält
                increasedDmg.Visible = false;
                labelIDmg.Visible = false;
                APS.Visible = false;
                labelAPS.Visible = false;
                labelLifeSteal.Visible = false;
                lifeSteal.Visible = false;
            }
            if (this.Text == "Ring 2")
            {
                for (int i = 0; i <= 8; i++)
                {
                    IAS.Items.Add(i);
                }
                for (int i = 0; i <= 8; i++)
                {
                    increasedCritChance.Items.Add((double)i / 2);
                }
                for (int i = 0; i <= 30; i++)
                {
                    minDmg.Items.Add(i);
                }
                for (int i = 0; i <= 50; i++)
                {
                    maxDmg.Items.Add(i);
                }
                for (int i = 0; i <= 35; i++)
                {
                    increasedCritDmg.Items.Add(i);
                }
                minDmg.SelectedIndex = equipment.ring2.minDmg;
                maxDmg.SelectedIndex = equipment.ring2.maxDmg;
                str.SelectedIndex = equipment.ring2.strength;
                dex.SelectedIndex = equipment.ring2.dexterity;
                intel.SelectedIndex = equipment.ring2.intelligence;
                vit.SelectedIndex = equipment.ring2.vitality;
                IAS.SelectedIndex = (int)equipment.ring2.attackSpeed;
                increasedCritChance.SelectedIndex = (int)(equipment.ring2.critChance * 2);
                increasedCritDmg.SelectedIndex= equipment.ring2.critDmg;
                armor.SelectedIndex = equipment.ring2.armor;
                allRes.SelectedIndex = equipment.ring2.allResistance;
                physRes.SelectedIndex = equipment.ring2.physicalResistance;
                coldRes.SelectedIndex = equipment.ring2.coldResistance;
                fireRes.SelectedIndex = equipment.ring2.fireResistance;
                lightRes.SelectedIndex = equipment.ring2.lightningResistance;
                poisonRes.SelectedIndex = equipment.ring2.poisonResistance;
                arcRes.SelectedIndex = equipment.ring2.arcaneResistance;
                HP.SelectedIndex = equipment.ring2.HP;
                //dolda fält
                increasedDmg.Visible = false;
                labelIDmg.Visible = false;
                APS.Visible = false;
                labelAPS.Visible = false;
                labelLifeSteal.Visible = false;
                lifeSteal.Visible = false;
            }
            if (this.Text == "Dual Wield")
            {
                for (int i = 0; i <= 11; i++)
                {
                    IAS.Items.Add(i);
                }
                for (int i = 0; i <= 2000; i++)
                {
                    minDmg.Items.Add(i);
                }
                for (int i = 0; i <= 2000; i++)
                {
                    maxDmg.Items.Add(i);
                }
                for (int i = 0; i <= 170; i++)
                {
                    increasedCritDmg.Items.Add((double)i);
                }
                for (int i = 0; i <= 76; i++)
                {
                    //räkna ut det tillgängliga värdena på attack speed där 0.9 är lägsta och 1,75 är högsta möjliga värdet
                    //var tvungen att använda avrundning, för programmet ville göra fler doubleer än vad som borde vara där på några tal.
                    //efter patchen 20/06 är attack speed staten halverad, vilket även inkluderar hur snabbt vapnet kan vara, nuvarande högsta är 1,66
                    APS.Items.Add(Math.Round((double)i / 100 + 0.9f, 2));
                }
                for (int i = 0; i <= 30; i++)
                {
                    lifeSteal.Items.Add(Math.Round(((double)i / 10), 1));
                }
                minDmg.SelectedIndex = equipment.dualWield.minDmg;
                maxDmg.SelectedIndex = equipment.dualWield.maxDmg;
                str.SelectedIndex = equipment.dualWield.strength;
                dex.SelectedIndex = equipment.dualWield.dexterity;
                intel.SelectedIndex = equipment.dualWield.intelligence;
                vit.SelectedIndex = equipment.dualWield.vitality;
                APS.SelectedIndex = (int)Math.Round(((equipment.dualWield.attacksPerSecond - 0.9f) * 100), 2);
                IAS.SelectedIndex = (int)equipment.dualWield.attackSpeed;
                increasedDmg.SelectedIndex = equipment.dualWield.increasedDamage;
                increasedCritDmg.SelectedIndex = equipment.dualWield.critDmg;
                lifeSteal.SelectedIndex = (int)Math.Round((equipment.dualWield.lifeSteal * 10));
                //dolda fält
                groupDefensive.Visible = false;
                HP.Visible = false;
                labelHP.Visible = false;
                increasedCritChance.Visible = false;
                labelCritChance.Visible = false;
            }
        }
        #endregion

        #region Addrange function
        //lägg till ranges på Dropboxarna med generella max värden
        private void AddBoxRanges()
        {
            for (int i = 0; i <= 400; i++)
            {
                str.Items.Add(i);
            }
            for (int i = 0; i <= 400; i++)
            {
                dex.Items.Add(i);
            }
            for (int i = 0; i <= 400; i++)
            {
                intel.Items.Add(i);
            }
            for (int i = 0; i <= 400; i++)
            {
                vit.Items.Add(i);
            }
            for (int i = 0; i <= 50; i++)
            {
                increasedDmg.Items.Add(i);
            }
            for (int i = 0; i <= 2000; i++)
            {
                armor.Items.Add(i);
            }
            for (int i = 0; i <= 80; i++)
            {
                allRes.Items.Add(i);
            }
            for (int i = 0; i <= 60; i++)
            {
                physRes.Items.Add(i);
            }
            for (int i = 0; i <= 60; i++)
            {
                coldRes.Items.Add(i);
            }
            for (int i = 0; i <= 60; i++)
            {
                fireRes.Items.Add(i);
            }
            for (int i = 0; i <= 60; i++)
            {
                lightRes.Items.Add(i);
            }
            for (int i = 0; i <= 60; i++)
            {
                poisonRes.Items.Add(i);
            }
            for (int i = 0; i <= 60; i++)
            {
                arcRes.Items.Add(i);
            }
            for (int i = 0; i <= 27; i++)
            {
                HP.Items.Add(i);
            }
        }
        #endregion

        #endregion
    }
}
