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
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DamageMitigation;
using Equipment;
using Stats;
namespace D3_Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            for (int i=0; i<17; i++)
            {
                offhandDualwieldOld[i] = 0;
            }
            for (int i = 0; i <= 100; i++)
            {
                paraLvl.Items.Add(i);
            }
            //kolla om en sparad fil finns från föregående session och läs in stats
            if (File.Exists(Application.StartupPath + "\\Resources\\base.d3c"))
            {
                LoadFile(new StreamReader(Application.StartupPath + "\\Resources\\base.d3c"));
                UpdateValues();
            }
            
        }
        //skapa equipment klassen
        EquipmentClass equipment = new EquipmentClass();
        //skapa stats klassen
        StatsClass stats = new StatsClass();
        //skapa mitigation klassen
        MitigationClass mitigation = new MitigationClass();
        //skapa save arrayen
        public string[] save;
        double[] offhandDualwieldOld = new double[17];
        #region Class Buttons
        //byt text på selectedClass labeln för att den ska räkna ut attributer beroende på klass senare.
        //byt bild för att förtydliga vilken klass det gäller.
        private void barbarian_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "Barbarian";/*
            maleFrame.Image = D3_Calculator.Properties.Resources.Barbarian_Male;
            femaleFrame.Image = D3_Calculator.Properties.Resources.Barbarian_Female;*/
            //visa primär attribut med *
            labelStrength.Text = "*Strength:";
            labelDexterity.Text = "Dexterity:";
            labelIntelligence.Text = "Intelligence:";
            labelVitality.Text = "Vitality";
            dualWieldCheck.Visible=true;
            //kalla på funktionen
            UpdateValues();
        }

        private void demon_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "Demon Hunter";/*
            maleFrame.Image = D3_Calculator.Properties.Resources.Demon_Hunter_Male;
            femaleFrame.Image = D3_Calculator.Properties.Resources.Demon_Hunter_Female;*/
            //visa primär attribut med *
            labelStrength.Text = "Strength:";
            labelDexterity.Text = "*Dexterity:";
            labelIntelligence.Text = "Intelligence:";
            labelVitality.Text = "Vitality";
            dualWieldCheck.Visible = true;
            //kalla på funktionen
            UpdateValues();
        }

        private void wizard_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "Wizard";/*
            maleFrame.Image = D3_Calculator.Properties.Resources.Wizard_Male;
            femaleFrame.Image = D3_Calculator.Properties.Resources.Wizard_Female;*/
            //visa primär attribut med *
            labelStrength.Text = "Strength:";
            labelDexterity.Text = "Dexterity:";
            labelIntelligence.Text = "*Intelligence:";
            labelVitality.Text = "Vitality";
            dualWieldCheck.Visible = false;
            dualWieldCheck.Checked = false;
            //kalla på funktionen
            UpdateValues();
        }

        private void witch_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "Witch Doctor";/*
            maleFrame.Image = D3_Calculator.Properties.Resources.Witch_Doctor_Male;
            femaleFrame.Image = D3_Calculator.Properties.Resources.Witch_Doctor_Female;*/
            //visa primär attribut med *
            labelStrength.Text = "Strength:";
            labelDexterity.Text = "Dexterity:";
            labelIntelligence.Text = "*Intelligence:";
            labelVitality.Text = "Vitality";
            dualWieldCheck.Visible = false;
            dualWieldCheck.Checked = false;
            //kalla på funktionen
            UpdateValues();
        }

        private void monk_Click(object sender, EventArgs e)
        {
            selectedClass.Text = "Monk";/*
            maleFrame.Image = D3_Calculator.Properties.Resources.Monk_Male;
            femaleFrame.Image = D3_Calculator.Properties.Resources.Monk_Female;*/
            //visa primär attribut med *
            labelStrength.Text = "Strength:";
            labelDexterity.Text = "*Dexterity:";
            labelIntelligence.Text = "Intelligence:";
            labelVitality.Text = "Vitality";
            dualWieldCheck.Visible = true;
            //kalla på funktionen
            UpdateValues();
        }
        #endregion
        private void levelBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //uppdatera bas stats när spelarens level ändras.
            if (levelBox.SelectedIndex < 59)
            {
                paraLvlLabel.Visible = false;
                paraLvl.Visible = false;
                paraLvl.SelectedIndex = 0;
            }
            else
            {
                paraLvlLabel.Visible = true;
                paraLvl.Visible = true;
            }
            UpdateValues();

        }
        #region functions
        public void UpdateValues()
        {
            //uppdatera alla värden
            equipment.UpdateEquipmentStats();
            #region Save Array
            //skapa tempSave arrayen för att sedan definiera save arrayen
            string[] tempSave = {
                                 equipment.amulet.allResistance.ToString(),
                                 equipment.amulet.arcaneResistance.ToString(),
                                 equipment.amulet.armor.ToString(),
                                 equipment.amulet.attackSpeed.ToString(),
                                 equipment.amulet.coldResistance.ToString(),
                                 equipment.amulet.critChance.ToString(),
                                 equipment.amulet.critDmg.ToString(),
                                 equipment.amulet.dexterity.ToString(),
                                 equipment.amulet.fireResistance.ToString(),
                                 equipment.amulet.HP.ToString(),
                                 equipment.amulet.intelligence.ToString(),
                                 equipment.amulet.lightningResistance.ToString(),
                                 equipment.amulet.maxDmg.ToString(),
                                 equipment.amulet.minDmg.ToString(),
                                 equipment.amulet.physicalResistance.ToString(),
                                 equipment.amulet.poisonResistance.ToString(),
                                 equipment.amulet.strength.ToString(),
                                 equipment.amulet.vitality.ToString(),

                                 equipment.belt.allResistance.ToString(),
                                 equipment.belt.arcaneResistance.ToString(),
                                 equipment.belt.armor.ToString(),
                                 equipment.belt.attackSpeed.ToString(),
                                 equipment.belt.coldResistance.ToString(),
                                 equipment.belt.critDmg.ToString(),
                                 equipment.belt.dexterity.ToString(),
                                 equipment.belt.fireResistance.ToString(),
                                 equipment.belt.HP.ToString(),
                                 equipment.belt.intelligence.ToString(),
                                 equipment.belt.lightningResistance.ToString(),
                                 equipment.belt.physicalResistance.ToString(),
                                 equipment.belt.poisonResistance.ToString(),
                                 equipment.belt.strength.ToString(),
                                 equipment.belt.vitality.ToString(),
                                 
                                 equipment.boots.allResistance.ToString(),
                                 equipment.boots.arcaneResistance.ToString(),
                                 equipment.boots.armor.ToString(),
                                 equipment.boots.attackSpeed.ToString(),
                                 equipment.boots.coldResistance.ToString(),
                                 equipment.boots.dexterity.ToString(),
                                 equipment.boots.fireResistance.ToString(),
                                 equipment.boots.HP.ToString(),
                                 equipment.boots.intelligence.ToString(),
                                 equipment.boots.lightningResistance.ToString(),
                                 equipment.boots.physicalResistance.ToString(),
                                 equipment.boots.poisonResistance.ToString(),
                                 equipment.boots.strength.ToString(),
                                 equipment.boots.vitality.ToString(),
                                 
                                 equipment.bracers.allResistance.ToString(),
                                 equipment.bracers.arcaneResistance.ToString(),
                                 equipment.bracers.armor.ToString(),
                                 equipment.bracers.attackSpeed.ToString(),
                                 equipment.bracers.coldResistance.ToString(),
                                 equipment.bracers.critChance.ToString(),
                                 equipment.bracers.dexterity.ToString(),
                                 equipment.bracers.fireResistance.ToString(),
                                 equipment.bracers.HP.ToString(),
                                 equipment.bracers.intelligence.ToString(),
                                 equipment.bracers.lightningResistance.ToString(),
                                 equipment.bracers.physicalResistance.ToString(),
                                 equipment.bracers.poisonResistance.ToString(),
                                 equipment.bracers.strength.ToString(),
                                 equipment.bracers.vitality.ToString(),
                                 
                                 equipment.chest.allResistance.ToString(),
                                 equipment.chest.arcaneResistance.ToString(),
                                 equipment.chest.armor.ToString(),
                                 equipment.chest.attackSpeed.ToString(),
                                 equipment.chest.coldResistance.ToString(),
                                 equipment.chest.dexterity.ToString(),
                                 equipment.chest.fireResistance.ToString(),
                                 equipment.chest.HP.ToString(),
                                 equipment.chest.intelligence.ToString(),
                                 equipment.chest.lightningResistance.ToString(),
                                 equipment.chest.physicalResistance.ToString(),
                                 equipment.chest.poisonResistance.ToString(),
                                 equipment.chest.strength.ToString(),
                                 equipment.chest.vitality.ToString(),
                                 
                                 equipment.hands.allResistance.ToString(),
                                 equipment.hands.arcaneResistance.ToString(),
                                 equipment.hands.armor.ToString(),
                                 equipment.hands.attackSpeed.ToString(),
                                 equipment.hands.coldResistance.ToString(),
                                 equipment.hands.critChance.ToString(),
                                 equipment.hands.critDmg.ToString(),
                                 equipment.hands.dexterity.ToString(),
                                 equipment.hands.fireResistance.ToString(),
                                 equipment.hands.HP.ToString(),
                                 equipment.hands.intelligence.ToString(),
                                 equipment.hands.lightningResistance.ToString(),
                                 equipment.hands.physicalResistance.ToString(),
                                 equipment.hands.poisonResistance.ToString(),
                                 equipment.hands.strength.ToString(),
                                 equipment.hands.vitality.ToString(),

                                 equipment.helm.allResistance.ToString(),
                                 equipment.helm.arcaneResistance.ToString(),
                                 equipment.helm.armor.ToString(),
                                 equipment.helm.attackSpeed.ToString(),
                                 equipment.helm.coldResistance.ToString(),
                                 equipment.helm.critChance.ToString(),
                                 equipment.helm.dexterity.ToString(),
                                 equipment.helm.fireResistance.ToString(),
                                 equipment.helm.HP.ToString(),
                                 equipment.helm.intelligence.ToString(),
                                 equipment.helm.lightningResistance.ToString(),
                                 equipment.helm.physicalResistance.ToString(),
                                 equipment.helm.poisonResistance.ToString(),
                                 equipment.helm.strength.ToString(),
                                 equipment.helm.vitality.ToString(),
                                 
                                 equipment.legs.allResistance.ToString(),
                                 equipment.legs.arcaneResistance.ToString(),
                                 equipment.legs.armor.ToString(),
                                 equipment.legs.attackSpeed.ToString(),
                                 equipment.legs.coldResistance.ToString(),
                                 equipment.legs.critChance.ToString(),
                                 equipment.legs.dexterity.ToString(),
                                 equipment.legs.fireResistance.ToString(),
                                 equipment.legs.HP.ToString(),
                                 equipment.legs.intelligence.ToString(),
                                 equipment.legs.lightningResistance.ToString(),
                                 equipment.legs.physicalResistance.ToString(),
                                 equipment.legs.poisonResistance.ToString(),
                                 equipment.legs.strength.ToString(),
                                 equipment.legs.vitality.ToString(),
                                 
                                 equipment.mainHand.attackSpeed.ToString(),
                                 equipment.mainHand.attacksPerSecond.ToString(),
                                 equipment.mainHand.critDmg.ToString(),
                                 equipment.mainHand.dexterity.ToString(),
                                 equipment.mainHand.increasedDamage.ToString(),
                                 equipment.mainHand.intelligence.ToString(),
                                 equipment.mainHand.lifeSteal.ToString(),
                                 equipment.mainHand.maxDmg.ToString(),
                                 equipment.mainHand.minDmg.ToString(),
                                 equipment.mainHand.strength.ToString(),
                                 equipment.mainHand.vitality.ToString(),
                                 
                                 equipment.offHand.allResistance.ToString(),
                                 equipment.offHand.arcaneResistance.ToString(),
                                 equipment.offHand.armor.ToString(),
                                 equipment.offHand.attackSpeed.ToString(),
                                 equipment.offHand.coldResistance.ToString(),
                                 equipment.offHand.critChance.ToString(),
                                 equipment.offHand.dexterity.ToString(),
                                 equipment.offHand.fireResistance.ToString(),
                                 equipment.offHand.HP.ToString(),
                                 equipment.offHand.intelligence.ToString(),
                                 equipment.offHand.lightningResistance.ToString(),
                                 equipment.offHand.maxDmg.ToString(),
                                 equipment.offHand.minDmg.ToString(),
                                 equipment.offHand.physicalResistance.ToString(),
                                 equipment.offHand.poisonResistance.ToString(),
                                 equipment.offHand.strength.ToString(),
                                 equipment.offHand.vitality.ToString(),

                                 equipment.ring1.allResistance.ToString(),
                                 equipment.ring1.arcaneResistance.ToString(),
                                 equipment.ring1.armor.ToString(),
                                 equipment.ring1.attackSpeed.ToString(),
                                 equipment.ring1.coldResistance.ToString(),
                                 equipment.ring1.critChance.ToString(),
                                 equipment.ring1.critDmg.ToString(),
                                 equipment.ring1.dexterity.ToString(),
                                 equipment.ring1.fireResistance.ToString(),
                                 equipment.ring1.HP.ToString(),
                                 equipment.ring1.intelligence.ToString(),
                                 equipment.ring1.lightningResistance.ToString(),
                                 equipment.ring1.maxDmg.ToString(),
                                 equipment.ring1.minDmg.ToString(),
                                 equipment.ring1.physicalResistance.ToString(),
                                 equipment.ring1.poisonResistance.ToString(),
                                 equipment.ring1.strength.ToString(),
                                 equipment.ring1.vitality.ToString(),

                                 equipment.ring2.allResistance.ToString(),
                                 equipment.ring2.arcaneResistance.ToString(),
                                 equipment.ring2.armor.ToString(),
                                 equipment.ring2.attackSpeed.ToString(),
                                 equipment.ring2.coldResistance.ToString(),
                                 equipment.ring2.critChance.ToString(),
                                 equipment.ring2.critDmg.ToString(),
                                 equipment.ring2.dexterity.ToString(),
                                 equipment.ring2.fireResistance.ToString(),
                                 equipment.ring2.HP.ToString(),
                                 equipment.ring2.intelligence.ToString(),
                                 equipment.ring2.lightningResistance.ToString(),
                                 equipment.ring2.maxDmg.ToString(),
                                 equipment.ring2.minDmg.ToString(),
                                 equipment.ring2.physicalResistance.ToString(),
                                 equipment.ring2.poisonResistance.ToString(),
                                 equipment.ring2.strength.ToString(),
                                 equipment.ring2.vitality.ToString(),

                                 equipment.shoulders.allResistance.ToString(),
                                 equipment.shoulders.arcaneResistance.ToString(),
                                 equipment.shoulders.armor.ToString(),
                                 equipment.shoulders.coldResistance.ToString(),
                                 equipment.shoulders.dexterity.ToString(),
                                 equipment.shoulders.fireResistance.ToString(),
                                 equipment.shoulders.HP.ToString(),
                                 equipment.shoulders.intelligence.ToString(),
                                 equipment.shoulders.lightningResistance.ToString(),
                                 equipment.shoulders.physicalResistance.ToString(),
                                 equipment.shoulders.poisonResistance.ToString(),
                                 equipment.shoulders.strength.ToString(),
                                 equipment.shoulders.vitality.ToString(),
                                 selectedClass.Text,
                                 levelBox.SelectedIndex.ToString(),

                                 dualWieldCheck.Checked.ToString(),
                                 equipment.dualWield.attackSpeed.ToString(),
                                 equipment.dualWield.attacksPerSecond.ToString(),
                                 equipment.dualWield.critDmg.ToString(),
                                 equipment.dualWield.dexterity.ToString(),
                                 equipment.dualWield.increasedDamage.ToString(),
                                 equipment.dualWield.intelligence.ToString(),
                                 equipment.dualWield.lifeSteal.ToString(),
                                 equipment.dualWield.maxDmg.ToString(),
                                 equipment.dualWield.minDmg.ToString(),
                                 equipment.dualWield.strength.ToString(),
                                 equipment.dualWield.vitality.ToString(),
                                 paraLvl.SelectedIndex.ToString()
                             };
            save = tempSave;
            #endregion
            stats.Update_Stats(equipment,levelBox.SelectedIndex + 1, selectedClass.Text, paraLvl.SelectedIndex);
            
            UpdateGUI();
        }
        private void UpdateGUI()
        {
            //uppdatera GUI till att visa ändringar på stats
            levelReduction.Text = "Lvl " + (levelBox.SelectedIndex + 1).ToString();
            levelReduction2.Text = "Lvl " + (levelBox.SelectedIndex + 2).ToString();
            levelReduction3.Text = "Lvl " + (levelBox.SelectedIndex + 3).ToString();
            levelReduction4.Text = "Lvl " + (levelBox.SelectedIndex + 4).ToString();
            strength.Text = stats.str.ToString();
            dexterity.Text = stats.dex.ToString();
            intelligence.Text = stats.intel.ToString();
            vitality.Text = stats.vit.ToString();
            physicalResistance.Text = stats.totalPhysResistance.ToString();
            coldResistance.Text = stats.totalColdResistance.ToString();
            fireResistance.Text = stats.totalFireResistance.ToString();
            lightningResistance.Text = stats.totalLightResistance.ToString();
            poisonResistance.Text = stats.totalPoisonResistance.ToString();
            arcaneResistance.Text = stats.totalArcaneResistance.ToString();
            armor.Text = stats.totalArmor.ToString();
            HP.Text = (stats.maxHP).ToString();
            minDmg.Text = Math.Round(stats.dualMinDmg).ToString();
            maxDmg.Text = Math.Round(stats.dualMaxDmg).ToString();
            critMin.Text = Math.Round(stats.dualMinDmg * (stats.criticalHitDamage / 100 + 1)).ToString();
            critMax.Text = Math.Round(stats.dualMaxDmg * (stats.criticalHitDamage / 100 + 1)).ToString();
            critChance.Text = stats.criticalHitChance.ToString()+"%";
            critDmg.Text = (stats.criticalHitDamage + 100).ToString()+"%";
            //life Steal, simpel uträkning
            lifeSteal.Text = Math.Round(stats.dualMinDmg * (equipment.mainHand.lifeSteal / 100 + equipment.dualWield.lifeSteal / 100)).ToString() + " - " + Math.Round(stats.dualMaxDmg * (equipment.mainHand.lifeSteal / 100 + equipment.dualWield.lifeSteal / 100)).ToString();
            //if-sats DPS
            if (dualWieldCheck.Checked == false)
            {
                DPS.Text = stats.DPS.ToString();
            }
            if (dualWieldCheck.Checked == true)
            {
                DPS.Text = stats.dualDPS.ToString();
            }
            dodgeChance.Text = (Math.Round(stats.baseDodgeChance * 100, 2)).ToString() + "%";
            //beräkna vardera reduction, var tvungen att ändra om till double då C# inte kan räkna om int till till double, utan kvoten blir ett int tal, heltal avrundat neråt, då alla tal <1, blev alla tal = 0
            #region Damage Reduction
            //beräkna värdet för samma lvl som spelaren med två doubleer
            physicalReduction.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalPhysResistance, levelBox.SelectedIndex + 1), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 1), selectedClass.Text), 2) + "%";
            coldReduction.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalColdResistance, levelBox.SelectedIndex + 1), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 1), selectedClass.Text), 2) + "%";
            fireReduction.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalFireResistance, levelBox.SelectedIndex + 1), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 1), selectedClass.Text), 2) + "%";
            lightningReduction.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalLightResistance, levelBox.SelectedIndex + 1), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 1), selectedClass.Text), 2) + "%";
            poisonReduction.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalPoisonResistance, levelBox.SelectedIndex + 1), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 1), selectedClass.Text), 2) + "%";
            arcaneReduction.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalArcaneResistance, levelBox.SelectedIndex + 1), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 1), selectedClass.Text), 2) + "%";
            //beräkna värdet för en lvl ovanför spelaren med två doubleer
            physicalReduction2.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalPhysResistance, levelBox.SelectedIndex + 2), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 2), selectedClass.Text), 2) + "%";
            coldReduction2.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalColdResistance, levelBox.SelectedIndex + 2), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 2), selectedClass.Text), 2) + "%";
            fireReduction2.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalFireResistance, levelBox.SelectedIndex + 2), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 2), selectedClass.Text), 2) + "%";
            lightningReduction2.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalLightResistance, levelBox.SelectedIndex + 2), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 2), selectedClass.Text), 2) + "%";
            poisonReduction2.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalPoisonResistance, levelBox.SelectedIndex + 2), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 2), selectedClass.Text), 2) + "%";
            arcaneReduction2.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalArcaneResistance, levelBox.SelectedIndex + 2), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 2), selectedClass.Text), 2) + "%";
            //beräkna värdet för två lvlar ovanför spelaren med två doubleer
            physicalReduction3.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalPhysResistance, levelBox.SelectedIndex + 3), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 3), selectedClass.Text), 2) + "%";
            coldReduction3.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalColdResistance, levelBox.SelectedIndex + 3), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 3), selectedClass.Text), 2) + "%";
            fireReduction3.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalFireResistance, levelBox.SelectedIndex + 3), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 3), selectedClass.Text), 2) + "%";
            lightningReduction3.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalLightResistance, levelBox.SelectedIndex + 3), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 3), selectedClass.Text), 2) + "%";
            poisonReduction3.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalPoisonResistance, levelBox.SelectedIndex + 3), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 3), selectedClass.Text), 2) + "%";
            arcaneReduction3.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalArcaneResistance, levelBox.SelectedIndex + 3), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 3), selectedClass.Text), 2) + "%";
            //beräkna värdet för tre lvlar ovanför spelaren med två doubleer
            physicalReduction4.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalPhysResistance, levelBox.SelectedIndex + 4), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 4), selectedClass.Text), 2) + "%";
            coldReduction4.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalColdResistance, levelBox.SelectedIndex + 4), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 4), selectedClass.Text), 2) + "%";
            fireReduction4.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalFireResistance, levelBox.SelectedIndex + 4), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 4), selectedClass.Text), 2) + "%";
            lightningReduction4.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalLightResistance, levelBox.SelectedIndex + 4), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 4), selectedClass.Text), 2) + "%";
            poisonReduction4.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalPoisonResistance, levelBox.SelectedIndex + 4), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 4), selectedClass.Text), 2) + "%";
            arcaneReduction4.Text = Math.Round(mitigation.TotalReduction(mitigation.ResistanceReduction(stats.totalArcaneResistance, levelBox.SelectedIndex + 4), mitigation.ArmorReduction(stats.totalArmor, levelBox.SelectedIndex + 4), selectedClass.Text), 2) + "%";
            #endregion
        }
        private void LoadFile(StreamReader load)
        {
            #region Load values
            //ladda värden från sparad fil och verkställ ändringar
            equipment.amulet.allResistance = Convert.ToInt32(load.ReadLine());
            equipment.amulet.arcaneResistance = Convert.ToInt32(load.ReadLine());
            equipment.amulet.armor = Convert.ToInt32(load.ReadLine());
            equipment.amulet.attackSpeed = Convert.ToDouble(load.ReadLine());
            //uppdatera ändringar på attack speed
            if (equipment.amulet.attackSpeed > 9)
            {
                equipment.amulet.attackSpeed = 9;
            }
            equipment.amulet.coldResistance = Convert.ToInt32(load.ReadLine());
            equipment.amulet.critChance = Convert.ToDouble(load.ReadLine());
            equipment.amulet.critDmg = Convert.ToInt32(load.ReadLine());
            equipment.amulet.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.amulet.fireResistance = Convert.ToInt32(load.ReadLine());
            equipment.amulet.HP = Convert.ToInt32(load.ReadLine());
            equipment.amulet.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.amulet.lightningResistance = Convert.ToInt32(load.ReadLine());
            equipment.amulet.maxDmg = Convert.ToInt32(load.ReadLine());
            equipment.amulet.minDmg = Convert.ToInt32(load.ReadLine());
            equipment.amulet.physicalResistance = Convert.ToInt32(load.ReadLine());
            equipment.amulet.poisonResistance = Convert.ToInt32(load.ReadLine());
            equipment.amulet.strength = Convert.ToInt32(load.ReadLine());
            equipment.amulet.vitality = Convert.ToInt32(load.ReadLine());

            equipment.belt.allResistance = Convert.ToInt32(load.ReadLine());
            equipment.belt.arcaneResistance = Convert.ToInt32(load.ReadLine());
            equipment.belt.armor = Convert.ToInt32(load.ReadLine());
            equipment.belt.attackSpeed = Convert.ToDouble(load.ReadLine());
            //uppdatera ändringar på attack speed
            if (equipment.belt.attackSpeed > 6)
            {
                equipment.belt.attackSpeed = 6;
            }
            equipment.belt.coldResistance = Convert.ToInt32(load.ReadLine());
            equipment.belt.critDmg = Convert.ToInt32(load.ReadLine());
            equipment.belt.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.belt.fireResistance = Convert.ToInt32(load.ReadLine());
            equipment.belt.HP = Convert.ToInt32(load.ReadLine());
            equipment.belt.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.belt.lightningResistance = Convert.ToInt32(load.ReadLine());
            equipment.belt.physicalResistance = Convert.ToInt32(load.ReadLine());
            equipment.belt.poisonResistance = Convert.ToInt32(load.ReadLine());
            equipment.belt.strength = Convert.ToInt32(load.ReadLine());
            equipment.belt.vitality = Convert.ToInt32(load.ReadLine());

            equipment.boots.allResistance = Convert.ToInt32(load.ReadLine());
            equipment.boots.arcaneResistance = Convert.ToInt32(load.ReadLine());
            equipment.boots.armor = Convert.ToInt32(load.ReadLine());
            equipment.boots.attackSpeed = Convert.ToDouble(load.ReadLine());
            //uppdatera ändringar på attack speed
            if (equipment.boots.attackSpeed > 6)
            {
                equipment.boots.attackSpeed = 6;
            }
            equipment.boots.coldResistance = Convert.ToInt32(load.ReadLine());
            equipment.boots.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.boots.fireResistance = Convert.ToInt32(load.ReadLine());
            equipment.boots.HP = Convert.ToInt32(load.ReadLine());
            equipment.boots.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.boots.lightningResistance = Convert.ToInt32(load.ReadLine());
            equipment.boots.physicalResistance = Convert.ToInt32(load.ReadLine());
            equipment.boots.poisonResistance = Convert.ToInt32(load.ReadLine());
            equipment.boots.strength = Convert.ToInt32(load.ReadLine());
            equipment.boots.vitality = Convert.ToInt32(load.ReadLine());

            equipment.bracers.allResistance = Convert.ToInt32(load.ReadLine());
            equipment.bracers.arcaneResistance = Convert.ToInt32(load.ReadLine());
            equipment.bracers.armor = Convert.ToInt32(load.ReadLine());
            equipment.bracers.attackSpeed = Convert.ToDouble(load.ReadLine());
            //uppdatera ändringar på attack speed
            if (equipment.bracers.attackSpeed > 7)
            {
                equipment.bracers.attackSpeed = 7;
            }
            equipment.bracers.coldResistance = Convert.ToInt32(load.ReadLine());
            equipment.bracers.critChance = Convert.ToDouble(load.ReadLine());
            equipment.bracers.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.bracers.fireResistance = Convert.ToInt32(load.ReadLine());
            equipment.bracers.HP = Convert.ToInt32(load.ReadLine());
            equipment.bracers.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.bracers.lightningResistance = Convert.ToInt32(load.ReadLine());
            equipment.bracers.physicalResistance = Convert.ToInt32(load.ReadLine());
            equipment.bracers.poisonResistance = Convert.ToInt32(load.ReadLine());
            equipment.bracers.strength = Convert.ToInt32(load.ReadLine());
            equipment.bracers.vitality = Convert.ToInt32(load.ReadLine());

            equipment.chest.allResistance = Convert.ToInt32(load.ReadLine());
            equipment.chest.arcaneResistance = Convert.ToInt32(load.ReadLine());
            equipment.chest.armor = Convert.ToInt32(load.ReadLine());
            equipment.chest.attackSpeed = Convert.ToDouble(load.ReadLine());
            //uppdatera ändringar på attack speed
            if (equipment.chest.attackSpeed > 7)
            {
                equipment.chest.attackSpeed = 7;
            }
            equipment.chest.coldResistance = Convert.ToInt32(load.ReadLine());
            equipment.chest.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.chest.fireResistance = Convert.ToInt32(load.ReadLine());
            equipment.chest.HP = Convert.ToInt32(load.ReadLine());
            equipment.chest.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.chest.lightningResistance = Convert.ToInt32(load.ReadLine());
            equipment.chest.physicalResistance = Convert.ToInt32(load.ReadLine());
            equipment.chest.poisonResistance = Convert.ToInt32(load.ReadLine());
            equipment.chest.strength = Convert.ToInt32(load.ReadLine());
            equipment.chest.vitality = Convert.ToInt32(load.ReadLine());

            equipment.hands.allResistance = Convert.ToInt32(load.ReadLine());
            equipment.hands.arcaneResistance = Convert.ToInt32(load.ReadLine());
            equipment.hands.armor = Convert.ToInt32(load.ReadLine());
            equipment.hands.attackSpeed = Convert.ToDouble(load.ReadLine());
            //uppdatera ändringar på attack speed
            if (equipment.hands.attackSpeed > 9)
            {
                equipment.hands.attackSpeed = 9;
            }
            equipment.hands.coldResistance = Convert.ToInt32(load.ReadLine());
            equipment.hands.critChance = Convert.ToDouble(load.ReadLine());
            equipment.hands.critDmg = Convert.ToInt32(load.ReadLine());
            equipment.hands.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.hands.fireResistance = Convert.ToInt32(load.ReadLine());
            equipment.hands.HP = Convert.ToInt32(load.ReadLine());
            equipment.hands.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.hands.lightningResistance = Convert.ToInt32(load.ReadLine());
            equipment.hands.physicalResistance = Convert.ToInt32(load.ReadLine());
            equipment.hands.poisonResistance = Convert.ToInt32(load.ReadLine());
            equipment.hands.strength = Convert.ToInt32(load.ReadLine());
            equipment.hands.vitality = Convert.ToInt32(load.ReadLine());

            equipment.helm.allResistance = Convert.ToInt32(load.ReadLine());
            equipment.helm.arcaneResistance = Convert.ToInt32(load.ReadLine());
            equipment.helm.armor = Convert.ToInt32(load.ReadLine());
            equipment.helm.attackSpeed = Convert.ToDouble(load.ReadLine());
            //uppdatera ändringar på attack speed
            if (equipment.helm.attackSpeed > 7)
            {
                equipment.helm.attackSpeed = 7;
            }
            equipment.helm.coldResistance = Convert.ToInt32(load.ReadLine());
            equipment.helm.critChance = Convert.ToDouble(load.ReadLine());
            equipment.helm.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.helm.fireResistance = Convert.ToInt32(load.ReadLine());
            equipment.helm.HP = Convert.ToInt32(load.ReadLine());
            equipment.helm.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.helm.lightningResistance = Convert.ToInt32(load.ReadLine());
            equipment.helm.physicalResistance = Convert.ToInt32(load.ReadLine());
            equipment.helm.poisonResistance = Convert.ToInt32(load.ReadLine());
            equipment.helm.strength = Convert.ToInt32(load.ReadLine());
            equipment.helm.vitality = Convert.ToInt32(load.ReadLine());

            equipment.legs.allResistance = Convert.ToInt32(load.ReadLine());
            equipment.legs.arcaneResistance = Convert.ToInt32(load.ReadLine());
            equipment.legs.armor = Convert.ToInt32(load.ReadLine());
            equipment.legs.attackSpeed = Convert.ToDouble(load.ReadLine());
            //uppdatera ändringar på attack speed
            if (equipment.legs.attackSpeed > 8)
            {
                equipment.legs.attackSpeed = 8;
            }
            equipment.legs.coldResistance = Convert.ToInt32(load.ReadLine());
            equipment.legs.critChance = Convert.ToDouble(load.ReadLine());
            equipment.legs.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.legs.fireResistance = Convert.ToInt32(load.ReadLine());
            equipment.legs.HP = Convert.ToInt32(load.ReadLine());
            equipment.legs.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.legs.lightningResistance = Convert.ToInt32(load.ReadLine());
            equipment.legs.physicalResistance = Convert.ToInt32(load.ReadLine());
            equipment.legs.poisonResistance = Convert.ToInt32(load.ReadLine());
            equipment.legs.strength = Convert.ToInt32(load.ReadLine());
            equipment.legs.vitality = Convert.ToInt32(load.ReadLine());

            equipment.mainHand.attackSpeed = Convert.ToDouble(load.ReadLine());
            //uppdatera ändringar på attack speed
            if (equipment.mainHand.attackSpeed > 11)
            {
                equipment.mainHand.attackSpeed = 11;
            }
            equipment.mainHand.attacksPerSecond = Convert.ToDouble(load.ReadLine());
            equipment.mainHand.critDmg = Convert.ToInt32(load.ReadLine());
            equipment.mainHand.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.mainHand.increasedDamage = Convert.ToInt32(load.ReadLine());
            equipment.mainHand.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.mainHand.lifeSteal = Convert.ToDouble(load.ReadLine());
            equipment.mainHand.maxDmg = Convert.ToInt32(load.ReadLine());
            equipment.mainHand.minDmg = Convert.ToInt32(load.ReadLine());
            equipment.mainHand.strength = Convert.ToInt32(load.ReadLine());
            equipment.mainHand.vitality = Convert.ToInt32(load.ReadLine());

            equipment.offHand.allResistance = Convert.ToInt32(load.ReadLine());
            equipment.offHand.arcaneResistance = Convert.ToInt32(load.ReadLine());
            equipment.offHand.armor = Convert.ToInt32(load.ReadLine());
            //oförändrad attack speed
            equipment.offHand.attackSpeed = Convert.ToDouble(load.ReadLine());
            equipment.offHand.coldResistance = Convert.ToInt32(load.ReadLine());
            equipment.offHand.critChance = Convert.ToDouble(load.ReadLine());
            equipment.offHand.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.offHand.fireResistance = Convert.ToInt32(load.ReadLine());
            equipment.offHand.HP = Convert.ToInt32(load.ReadLine());
            equipment.offHand.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.offHand.lightningResistance = Convert.ToInt32(load.ReadLine());
            equipment.offHand.maxDmg = Convert.ToInt32(load.ReadLine());
            equipment.offHand.minDmg = Convert.ToInt32(load.ReadLine());
            equipment.offHand.physicalResistance = Convert.ToInt32(load.ReadLine());
            equipment.offHand.poisonResistance = Convert.ToInt32(load.ReadLine());
            equipment.offHand.strength = Convert.ToInt32(load.ReadLine());
            equipment.offHand.vitality = Convert.ToInt32(load.ReadLine());

            equipment.ring1.allResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring1.arcaneResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring1.armor = Convert.ToInt32(load.ReadLine());
            equipment.ring1.attackSpeed = Convert.ToDouble(load.ReadLine());
            //uppdatera ändringar på attack speed
            if (equipment.ring1.attackSpeed > 9)
            {
                equipment.ring1.attackSpeed = 9;
            }
            equipment.ring1.coldResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring1.critChance = Convert.ToDouble(load.ReadLine());
            equipment.ring1.critDmg = Convert.ToInt32(load.ReadLine());
            equipment.ring1.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.ring1.fireResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring1.HP = Convert.ToInt32(load.ReadLine());
            equipment.ring1.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.ring1.lightningResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring1.maxDmg = Convert.ToInt32(load.ReadLine());
            equipment.ring1.minDmg = Convert.ToInt32(load.ReadLine());
            equipment.ring1.physicalResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring1.poisonResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring1.strength = Convert.ToInt32(load.ReadLine());
            equipment.ring1.vitality = Convert.ToInt32(load.ReadLine());

            equipment.ring2.allResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring2.arcaneResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring2.armor = Convert.ToInt32(load.ReadLine());
            equipment.ring2.attackSpeed = Convert.ToDouble(load.ReadLine());
            //uppdatera ändringar på attack speed
            if (equipment.ring2.attackSpeed > 9)
            {
                equipment.ring2.attackSpeed = 9;
            }
            equipment.ring2.coldResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring2.critChance = Convert.ToDouble(load.ReadLine());
            equipment.ring2.critDmg = Convert.ToInt32(load.ReadLine());
            equipment.ring2.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.ring2.fireResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring2.HP = Convert.ToInt32(load.ReadLine());
            equipment.ring2.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.ring2.lightningResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring2.maxDmg = Convert.ToInt32(load.ReadLine());
            equipment.ring2.minDmg = Convert.ToInt32(load.ReadLine());
            equipment.ring2.physicalResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring2.poisonResistance = Convert.ToInt32(load.ReadLine());
            equipment.ring2.strength = Convert.ToInt32(load.ReadLine());
            equipment.ring2.vitality = Convert.ToInt32(load.ReadLine());

            equipment.shoulders.allResistance = Convert.ToInt32(load.ReadLine());
            equipment.shoulders.arcaneResistance = Convert.ToInt32(load.ReadLine());
            equipment.shoulders.armor = Convert.ToInt32(load.ReadLine());
            equipment.shoulders.coldResistance = Convert.ToInt32(load.ReadLine());
            equipment.shoulders.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.shoulders.fireResistance = Convert.ToInt32(load.ReadLine());
            equipment.shoulders.HP = Convert.ToInt32(load.ReadLine());
            equipment.shoulders.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.shoulders.lightningResistance = Convert.ToInt32(load.ReadLine());
            equipment.shoulders.physicalResistance = Convert.ToInt32(load.ReadLine());
            equipment.shoulders.poisonResistance = Convert.ToInt32(load.ReadLine());
            equipment.shoulders.strength = Convert.ToInt32(load.ReadLine());
            equipment.shoulders.vitality = Convert.ToInt32(load.ReadLine());
            string tempClass = load.ReadLine();
            //ladda klass till tempClass för att senare kolla vilken klass funktion som ska köras
            levelBox.SelectedIndex = Convert.ToInt32(load.ReadLine());
            //ladda dual wield
            dualWieldCheck.Checked = Convert.ToBoolean(load.ReadLine());
            equipment.dualWield.attackSpeed = Convert.ToDouble(load.ReadLine());
            equipment.dualWield.attacksPerSecond = Convert.ToDouble(load.ReadLine());
            equipment.dualWield.critDmg = Convert.ToInt32(load.ReadLine());
            equipment.dualWield.dexterity = Convert.ToInt32(load.ReadLine());
            equipment.dualWield.increasedDamage = Convert.ToInt32(load.ReadLine());
            equipment.dualWield.intelligence = Convert.ToInt32(load.ReadLine());
            equipment.dualWield.lifeSteal = Convert.ToDouble(load.ReadLine());
            equipment.dualWield.maxDmg = Convert.ToInt32(load.ReadLine());
            equipment.dualWield.minDmg = Convert.ToInt32(load.ReadLine());
            equipment.dualWield.strength = Convert.ToInt32(load.ReadLine());
            equipment.dualWield.vitality = Convert.ToInt32(load.ReadLine());
            string paraString = load.ReadLine();
            if (paraString != null)
            {
                paraLvl.SelectedIndex = Convert.ToInt32(paraString);
            }
            else
            {
                paraLvl.SelectedIndex = 0;
            }
            //kolla vilken klass som sparats och kör dess klass_Click() funktion
            if (tempClass == "Barbarian")
            {
                barbarian_Click(this, null);
            }
            if (tempClass == "Monk")
            {
                monk_Click(this, null);
            }
            if (tempClass == "Witch Doctor")
            {
                witch_Click(this, null);
            }
            if (tempClass == "Wizard")
            {
                wizard_Click(this, null);
            }
            if (tempClass == "Demon Hunter")
            {
                demon_Click(this, null);
            }
            load.Close();
            #endregion
        }
        #endregion
        //skicka equipment variabeln och namnet på delen med det nya fönstret för att identifiera utrustnignen.
        #region Equipment Buttons
        private void bracerButton_Click(object sender, EventArgs e)
        {
            EquipmentForm Form = new EquipmentForm(equipment, "Bracer");
            Form.ShowDialog();
            //spara ändringar till equipment variabeln
            equipment = Form.equipment;
            UpdateValues();
        }

        private void chestButton_Click(object sender, EventArgs e)
        {
            EquipmentForm Form = new EquipmentForm(equipment, "Chest");
            Form.ShowDialog();
            //spara ändringar till equipment variabeln
            equipment = Form.equipment;
            UpdateValues();
        }

        private void mainhandButton_Click(object sender, EventArgs e)
        {
            EquipmentForm Form = new EquipmentForm(equipment, "Main Hand");
            Form.ShowDialog();
            //spara ändringar till equipment variabeln
            equipment = Form.equipment;
            UpdateValues();
        }

        private void bootsButton_Click(object sender, EventArgs e)
        {
            EquipmentForm Form = new EquipmentForm(equipment, "Boots");
            Form.ShowDialog();
            //spara ändringar till equipment variabeln
            equipment = Form.equipment;
            UpdateValues();
        }

        private void offhandButton_Click(object sender, EventArgs e)
        {
            if (dualWieldCheck.Checked == false)
            {
                EquipmentForm Form = new EquipmentForm(equipment, "Off Hand");
                Form.ShowDialog();
                //spara ändringar till equipment variabeln
                equipment = Form.equipment;
                UpdateValues();
            }
            else
            {
                EquipmentForm Form = new EquipmentForm(equipment, "Dual Wield");
                Form.ShowDialog();
                //spara ändringar till equipment variabeln
                equipment = Form.equipment;
                UpdateValues();
            }
        }

        private void ringButton1_Click(object sender, EventArgs e)
        {
            EquipmentForm Form = new EquipmentForm(equipment, "Ring 1");
            Form.ShowDialog();
            //spara ändringar till equipment variabeln
            equipment = Form.equipment;
            UpdateValues();
        }

        private void ringButton2_Click(object sender, EventArgs e)
        {
            EquipmentForm Form = new EquipmentForm(equipment, "Ring 2");
            Form.ShowDialog();
            //spara ändringar till equipment variabeln
            equipment = Form.equipment;
            UpdateValues();
        }

        private void legsButton_Click(object sender, EventArgs e)
        {
            EquipmentForm Form = new EquipmentForm(equipment, "Legs");
            Form.ShowDialog();
            //spara ändringar till equipment variabeln
            equipment = Form.equipment;
            UpdateValues();
        }

        private void beltButton_Click(object sender, EventArgs e)
        {
            EquipmentForm Form = new EquipmentForm(equipment, "Belt");
            Form.ShowDialog();
            //spara ändringar till equipment variabeln
            equipment = Form.equipment;
            UpdateValues();
        }

        private void handsButton_Click(object sender, EventArgs e)
        {
            EquipmentForm Form = new EquipmentForm(equipment, "Hands");
            Form.ShowDialog();
            //spara ändringar till equipment variabeln
            equipment = Form.equipment;
            UpdateValues();
        }

        private void amuletButton_Click(object sender, EventArgs e)
        {
            EquipmentForm Form = new EquipmentForm(equipment, "Amulet");
            Form.ShowDialog();
            //spara ändringar till equipment variabeln
            equipment = Form.equipment;
            UpdateValues();
        }

        private void helmButton_Click(object sender, EventArgs e)
        {
            EquipmentForm Form = new EquipmentForm(equipment, "Helm");
            Form.ShowDialog();
            //spara ändringar till equipment variabeln
            equipment = Form.equipment;
            UpdateValues();
        }

        private void shoulderButton_Click(object sender, EventArgs e)
        {
            EquipmentForm Form = new EquipmentForm(equipment, "Shoulders");
            Form.ShowDialog();
            //spara ändringar till equipment variabeln
            equipment = Form.equipment;
            UpdateValues();
        }
        #endregion

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFile.ShowDialog();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {
            //spara till vald plats på datorn
            File.WriteAllLines(saveFile.FileName, save);
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {
            //ladda vald fil till programmet
            LoadFile(new StreamReader(openFile.OpenFile()));
        }

        private void buttonAbility_Click(object sender, EventArgs e)
        {
            AbilitiesForm abilitiesForm = new AbilitiesForm(stats, selectedClass.Text);
            abilitiesForm.ShowDialog();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm clearForm = new ClearForm();
            clearForm.ShowDialog();
            if (clearForm.clearOK == true)
            {
                #region Clear attributes

                equipment.amulet.allResistance = 0;
                equipment.amulet.arcaneResistance = 0;
                equipment.amulet.armor = 0;
                equipment.amulet.attackSpeed = 0;
                equipment.amulet.attackSpeed = 0;
                equipment.amulet.coldResistance = 0;
                equipment.amulet.critChance = 0;
                equipment.amulet.critDmg = 0;
                equipment.amulet.dexterity = 0;
                equipment.amulet.fireResistance = 0;
                equipment.amulet.HP = 0;
                equipment.amulet.intelligence = 0;
                equipment.amulet.lightningResistance = 0;
                equipment.amulet.maxDmg = 0;
                equipment.amulet.minDmg = 0;
                equipment.amulet.physicalResistance = 0;
                equipment.amulet.poisonResistance = 0;
                equipment.amulet.strength = 0;
                equipment.amulet.vitality = 0;

                equipment.belt.allResistance = 0;
                equipment.belt.arcaneResistance = 0;
                equipment.belt.armor = 0;
                equipment.belt.attackSpeed = 0;
                equipment.belt.coldResistance = 0;
                equipment.belt.critDmg = 0;
                equipment.belt.dexterity = 0;
                equipment.belt.fireResistance = 0;
                equipment.belt.HP = 0;
                equipment.belt.intelligence = 0;
                equipment.belt.lightningResistance = 0;
                equipment.belt.physicalResistance = 0;
                equipment.belt.poisonResistance = 0;
                equipment.belt.strength = 0;
                equipment.belt.vitality = 0;

                equipment.boots.allResistance = 0;
                equipment.boots.arcaneResistance = 0;
                equipment.boots.armor = 0;
                equipment.boots.attackSpeed = 0;
                equipment.boots.coldResistance = 0;
                equipment.boots.dexterity = 0;
                equipment.boots.fireResistance = 0;
                equipment.boots.HP = 0;
                equipment.boots.intelligence = 0;
                equipment.boots.lightningResistance = 0;
                equipment.boots.physicalResistance = 0;
                equipment.boots.poisonResistance = 0;
                equipment.boots.strength = 0;
                equipment.boots.vitality = 0;

                equipment.bracers.allResistance = 0;
                equipment.bracers.arcaneResistance = 0;
                equipment.bracers.armor = 0;
                equipment.bracers.attackSpeed = 0;
                equipment.bracers.coldResistance = 0;
                equipment.bracers.critChance = 0;
                equipment.bracers.dexterity = 0;
                equipment.bracers.fireResistance = 0;
                equipment.bracers.HP = 0;
                equipment.bracers.intelligence = 0;
                equipment.bracers.lightningResistance = 0;
                equipment.bracers.physicalResistance = 0;
                equipment.bracers.poisonResistance = 0;
                equipment.bracers.strength = 0;
                equipment.bracers.vitality = 0;

                equipment.chest.allResistance = 0;
                equipment.chest.arcaneResistance = 0;
                equipment.chest.armor = 0;
                equipment.chest.attackSpeed = 0;
                equipment.chest.coldResistance = 0;
                equipment.chest.dexterity = 0;
                equipment.chest.fireResistance = 0;
                equipment.chest.HP = 0;
                equipment.chest.intelligence = 0;
                equipment.chest.lightningResistance = 0;
                equipment.chest.physicalResistance = 0;
                equipment.chest.poisonResistance = 0;
                equipment.chest.strength = 0;
                equipment.chest.vitality = 0;

                equipment.hands.allResistance = 0;
                equipment.hands.arcaneResistance = 0;
                equipment.hands.armor = 0;
                equipment.hands.attackSpeed = 0;
                equipment.hands.coldResistance = 0;
                equipment.hands.critChance = 0;
                equipment.hands.critDmg = 0;
                equipment.hands.dexterity = 0;
                equipment.hands.fireResistance = 0;
                equipment.hands.HP = 0;
                equipment.hands.intelligence = 0;
                equipment.hands.lightningResistance = 0;
                equipment.hands.physicalResistance = 0;
                equipment.hands.poisonResistance = 0;
                equipment.hands.strength = 0;
                equipment.hands.vitality = 0;

                equipment.helm.allResistance = 0;
                equipment.helm.arcaneResistance = 0;
                equipment.helm.armor = 0;
                equipment.helm.attackSpeed = 0;
                equipment.helm.coldResistance = 0;
                equipment.helm.critChance = 0;
                equipment.helm.dexterity = 0;
                equipment.helm.fireResistance = 0;
                equipment.helm.HP = 0;
                equipment.helm.intelligence = 0;
                equipment.helm.lightningResistance = 0;
                equipment.helm.physicalResistance = 0;
                equipment.helm.poisonResistance = 0;
                equipment.helm.strength = 0;
                equipment.helm.vitality = 0;

                equipment.legs.allResistance = 0;
                equipment.legs.arcaneResistance = 0;
                equipment.legs.armor = 0;
                equipment.legs.attackSpeed = 0;
                equipment.legs.coldResistance = 0;
                equipment.legs.critChance = 0;
                equipment.legs.dexterity = 0;
                equipment.legs.fireResistance = 0;
                equipment.legs.HP = 0;
                equipment.legs.intelligence = 0;
                equipment.legs.lightningResistance = 0;
                equipment.legs.physicalResistance = 0;
                equipment.legs.poisonResistance = 0;
                equipment.legs.strength = 0;
                equipment.legs.vitality = 0;

                equipment.mainHand.attackSpeed = 0;
                equipment.mainHand.attacksPerSecond = 1;
                equipment.mainHand.critDmg = 0;
                equipment.mainHand.dexterity = 0;
                equipment.mainHand.increasedDamage = 0;
                equipment.mainHand.intelligence = 0;
                equipment.mainHand.lifeSteal = 0;
                equipment.mainHand.maxDmg = 3;
                equipment.mainHand.minDmg = 2;
                equipment.mainHand.strength = 0;
                equipment.mainHand.vitality = 0;

                equipment.offHand.allResistance = 0;
                equipment.offHand.arcaneResistance = 0;
                equipment.offHand.armor = 0;
                equipment.offHand.attackSpeed = 0;
                equipment.offHand.coldResistance = 0;
                equipment.offHand.critChance = 0;
                equipment.offHand.dexterity = 0;
                equipment.offHand.fireResistance = 0;
                equipment.offHand.HP = 0;
                equipment.offHand.intelligence = 0;
                equipment.offHand.lightningResistance = 0;
                equipment.offHand.maxDmg = 0;
                equipment.offHand.minDmg = 0;
                equipment.offHand.physicalResistance = 0;
                equipment.offHand.poisonResistance = 0;
                equipment.offHand.strength = 0;
                equipment.offHand.vitality = 0;

                equipment.ring1.allResistance = 0;
                equipment.ring1.arcaneResistance = 0;
                equipment.ring1.armor = 0;
                equipment.ring1.attackSpeed = 0;
                equipment.ring1.coldResistance = 0;
                equipment.ring1.critChance = 0;
                equipment.ring1.critDmg = 0;
                equipment.ring1.dexterity = 0;
                equipment.ring1.fireResistance = 0;
                equipment.ring1.HP = 0;
                equipment.ring1.intelligence = 0;
                equipment.ring1.lightningResistance = 0;
                equipment.ring1.maxDmg = 0;
                equipment.ring1.minDmg = 0;
                equipment.ring1.physicalResistance = 0;
                equipment.ring1.poisonResistance = 0;
                equipment.ring1.strength = 0;
                equipment.ring1.vitality = 0;

                equipment.ring2.allResistance = 0;
                equipment.ring2.arcaneResistance = 0;
                equipment.ring2.armor = 0;
                equipment.ring2.attackSpeed = 0;
                equipment.ring2.coldResistance = 0;
                equipment.ring2.critChance = 0;
                equipment.ring2.critDmg = 0;
                equipment.ring2.dexterity = 0;
                equipment.ring2.fireResistance = 0;
                equipment.ring2.HP = 0;
                equipment.ring2.intelligence = 0;
                equipment.ring2.lightningResistance = 0;
                equipment.ring2.maxDmg = 0;
                equipment.ring2.minDmg = 0;
                equipment.ring2.physicalResistance = 0;
                equipment.ring2.poisonResistance = 0;
                equipment.ring2.strength = 0;
                equipment.ring2.vitality = 0;

                equipment.shoulders.allResistance = 0;
                equipment.shoulders.arcaneResistance = 0;
                equipment.shoulders.armor = 0;
                equipment.shoulders.coldResistance = 0;
                equipment.shoulders.dexterity = 0;
                equipment.shoulders.fireResistance = 0;
                equipment.shoulders.HP = 0;
                equipment.shoulders.intelligence = 0;
                equipment.shoulders.lightningResistance = 0;
                equipment.shoulders.physicalResistance = 0;
                equipment.shoulders.poisonResistance = 0;
                equipment.shoulders.strength = 0;
                equipment.shoulders.vitality = 0;
                levelBox.SelectedIndex = 0;

                equipment.dualWield.attackSpeed = 0;
                equipment.dualWield.attacksPerSecond = 1;
                equipment.dualWield.critDmg = 0;
                equipment.dualWield.dexterity = 0;
                equipment.dualWield.increasedDamage = 0;
                equipment.dualWield.intelligence = 0;
                equipment.dualWield.lifeSteal = 0;
                equipment.dualWield.maxDmg = 0;
                equipment.dualWield.minDmg = 0;
                equipment.dualWield.strength = 0;
                equipment.dualWield.vitality = 0;
                dualWieldCheck.Checked = false;
                #endregion
            }
        }

        private void dualWieldCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (dualWieldCheck.Checked == true)
            {
                offhandButton.Text = "Dual Wield";
                //ladda in gamla stats från temporär array
                equipment.dualWield.attacksPerSecond = offhandDualwieldOld[0];
                if (equipment.dualWield.attacksPerSecond < 0.7)
                {
                    equipment.dualWield.attacksPerSecond = 1;
                }
                equipment.dualWield.critDmg = (int)offhandDualwieldOld[1];
                equipment.dualWield.dexterity = (int)offhandDualwieldOld[2];
                equipment.dualWield.increasedDamage = (int)offhandDualwieldOld[3];
                equipment.dualWield.intelligence = (int)offhandDualwieldOld[4];
                equipment.dualWield.lifeSteal = offhandDualwieldOld[5];
                equipment.dualWield.maxDmg = (int)offhandDualwieldOld[6];
                equipment.dualWield.minDmg = (int)offhandDualwieldOld[7];
                equipment.dualWield.strength = (int)offhandDualwieldOld[8];
                equipment.dualWield.vitality = (int)offhandDualwieldOld[9];
                //spara gamla stats i array
                offhandDualwieldOld[0] = equipment.offHand.allResistance;
                offhandDualwieldOld[1] = equipment.offHand.arcaneResistance;
                offhandDualwieldOld[2] = equipment.offHand.armor;
                offhandDualwieldOld[3] = equipment.offHand.attackSpeed;
                offhandDualwieldOld[4] = equipment.offHand.coldResistance;
                offhandDualwieldOld[5] = equipment.offHand.critChance;
                offhandDualwieldOld[6] = equipment.offHand.dexterity;
                offhandDualwieldOld[7] = equipment.offHand.fireResistance;
                offhandDualwieldOld[8] = equipment.offHand.HP;
                offhandDualwieldOld[9] = equipment.offHand.intelligence;
                offhandDualwieldOld[10] = equipment.offHand.lightningResistance;
                offhandDualwieldOld[11] = equipment.offHand.maxDmg;
                offhandDualwieldOld[12] = equipment.offHand.minDmg;
                offhandDualwieldOld[13] = equipment.offHand.physicalResistance;
                offhandDualwieldOld[14] = equipment.offHand.poisonResistance;
                offhandDualwieldOld[15] = equipment.offHand.strength;
                offhandDualwieldOld[16] = equipment.offHand.vitality;
                //rensa offHand
                equipment.offHand.allResistance = 0;
                equipment.offHand.arcaneResistance = 0;
                equipment.offHand.armor = 0;
                equipment.offHand.attackSpeed = 0;
                equipment.offHand.coldResistance = 0;
                equipment.offHand.critChance = 0;
                equipment.offHand.dexterity = 0;
                equipment.offHand.fireResistance = 0;
                equipment.offHand.HP = 0;
                equipment.offHand.intelligence = 0;
                equipment.offHand.lightningResistance = 0;
                equipment.offHand.maxDmg = 0;
                equipment.offHand.minDmg = 0;
                equipment.offHand.physicalResistance = 0;
                equipment.offHand.poisonResistance = 0;
                equipment.offHand.strength = 0;
                equipment.offHand.vitality = 0;
                UpdateValues();
            }
            else
            {
                offhandButton.Text = "Off Hand";
                //ladda in gamla stats från array
                equipment.offHand.allResistance = (int)offhandDualwieldOld[0];
                equipment.offHand.arcaneResistance = (int)offhandDualwieldOld[1];
                equipment.offHand.armor = (int)offhandDualwieldOld[2];
                equipment.offHand.attackSpeed = offhandDualwieldOld[3];
                equipment.offHand.coldResistance = (int)offhandDualwieldOld[4];
                equipment.offHand.critChance = offhandDualwieldOld[5];
                equipment.offHand.dexterity = (int)offhandDualwieldOld[6];
                equipment.offHand.fireResistance = (int)offhandDualwieldOld[7];
                equipment.offHand.HP = (int)offhandDualwieldOld[8];
                equipment.offHand.intelligence = (int)offhandDualwieldOld[9];
                equipment.offHand.lightningResistance = (int)offhandDualwieldOld[10];
                equipment.offHand.maxDmg = (int)offhandDualwieldOld[11];
                equipment.offHand.minDmg = (int)offhandDualwieldOld[12];
                equipment.offHand.physicalResistance = (int)offhandDualwieldOld[13];
                equipment.offHand.poisonResistance = (int)offhandDualwieldOld[14];
                equipment.offHand.strength = (int)offhandDualwieldOld[15];
                equipment.offHand.vitality = (int)offhandDualwieldOld[16];
                //ladda in gamla stats i array
                offhandDualwieldOld[0] = equipment.dualWield.attacksPerSecond;
                offhandDualwieldOld[1] = equipment.dualWield.critDmg;
                offhandDualwieldOld[2] = equipment.dualWield.dexterity;
                offhandDualwieldOld[3] = equipment.dualWield.increasedDamage;
                offhandDualwieldOld[4] = equipment.dualWield.intelligence;
                offhandDualwieldOld[5] = equipment.dualWield.lifeSteal;
                offhandDualwieldOld[6] = equipment.dualWield.maxDmg;
                offhandDualwieldOld[7] = equipment.dualWield.minDmg;
                offhandDualwieldOld[8] = equipment.dualWield.strength;
                offhandDualwieldOld[9] = equipment.dualWield.vitality;
                //rensa dual-wield
                equipment.dualWield.attacksPerSecond = 0;
                equipment.dualWield.critDmg = 0;
                equipment.dualWield.dexterity = 0;
                equipment.dualWield.increasedDamage = 0;
                equipment.dualWield.intelligence = 0;
                equipment.dualWield.lifeSteal = 0;
                equipment.dualWield.maxDmg = 0;
                equipment.dualWield.minDmg = 0;
                equipment.dualWield.strength = 0;
                equipment.dualWield.vitality = 0;
                UpdateValues();
            }
        }
    }
}