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

namespace D3_Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectedClass = new System.Windows.Forms.Label();
            this.barbarian = new System.Windows.Forms.Button();
            this.demon = new System.Windows.Forms.Button();
            this.wizard = new System.Windows.Forms.Button();
            this.witch = new System.Windows.Forms.Button();
            this.monk = new System.Windows.Forms.Button();
            this.labelSelected = new System.Windows.Forms.Label();
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.groupAttributes = new System.Windows.Forms.GroupBox();
            this.HP = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.armor = new System.Windows.Forms.Label();
            this.labelArmor = new System.Windows.Forms.Label();
            this.vitality = new System.Windows.Forms.Label();
            this.intelligence = new System.Windows.Forms.Label();
            this.dexterity = new System.Windows.Forms.Label();
            this.strength = new System.Windows.Forms.Label();
            this.labelVitality = new System.Windows.Forms.Label();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this.labelDexterity = new System.Windows.Forms.Label();
            this.labelStrength = new System.Windows.Forms.Label();
            this.DPS = new System.Windows.Forms.Label();
            this.labelDPS = new System.Windows.Forms.Label();
            this.groupDefensive = new System.Windows.Forms.GroupBox();
            this.dodgeChance = new System.Windows.Forms.Label();
            this.labelDodge = new System.Windows.Forms.Label();
            this.arcaneResistance = new System.Windows.Forms.Label();
            this.poisonResistance = new System.Windows.Forms.Label();
            this.lightningResistance = new System.Windows.Forms.Label();
            this.fireResistance = new System.Windows.Forms.Label();
            this.coldResistance = new System.Windows.Forms.Label();
            this.physicalResistance = new System.Windows.Forms.Label();
            this.labelArcane = new System.Windows.Forms.Label();
            this.labelPoison = new System.Windows.Forms.Label();
            this.labelLightning = new System.Windows.Forms.Label();
            this.labelFire = new System.Windows.Forms.Label();
            this.labelCold = new System.Windows.Forms.Label();
            this.labelPhysical = new System.Windows.Forms.Label();
            this.helmButton = new System.Windows.Forms.Button();
            this.shoulderButton = new System.Windows.Forms.Button();
            this.chestButton = new System.Windows.Forms.Button();
            this.amuletButton = new System.Windows.Forms.Button();
            this.bracerButton = new System.Windows.Forms.Button();
            this.handsButton = new System.Windows.Forms.Button();
            this.beltButton = new System.Windows.Forms.Button();
            this.ringButton1 = new System.Windows.Forms.Button();
            this.legsButton = new System.Windows.Forms.Button();
            this.ringButton2 = new System.Windows.Forms.Button();
            this.offhandButton = new System.Windows.Forms.Button();
            this.bootsButton = new System.Windows.Forms.Button();
            this.mainhandButton = new System.Windows.Forms.Button();
            this.reductionGroup = new System.Windows.Forms.GroupBox();
            this.arcaneReduction4 = new System.Windows.Forms.Label();
            this.poisonReduction4 = new System.Windows.Forms.Label();
            this.lightningReduction4 = new System.Windows.Forms.Label();
            this.fireReduction4 = new System.Windows.Forms.Label();
            this.coldReduction4 = new System.Windows.Forms.Label();
            this.physicalReduction4 = new System.Windows.Forms.Label();
            this.levelReduction4 = new System.Windows.Forms.Label();
            this.levelReduction3 = new System.Windows.Forms.Label();
            this.levelReduction2 = new System.Windows.Forms.Label();
            this.levelReduction = new System.Windows.Forms.Label();
            this.arcaneReduction3 = new System.Windows.Forms.Label();
            this.poisonReduction3 = new System.Windows.Forms.Label();
            this.lightningReduction3 = new System.Windows.Forms.Label();
            this.fireReduction3 = new System.Windows.Forms.Label();
            this.physicalReduction3 = new System.Windows.Forms.Label();
            this.coldReduction3 = new System.Windows.Forms.Label();
            this.arcaneReduction2 = new System.Windows.Forms.Label();
            this.arcaneReduction = new System.Windows.Forms.Label();
            this.poisonReduction2 = new System.Windows.Forms.Label();
            this.poisonReduction = new System.Windows.Forms.Label();
            this.lightningReduction2 = new System.Windows.Forms.Label();
            this.lightningReduction = new System.Windows.Forms.Label();
            this.fireReduction2 = new System.Windows.Forms.Label();
            this.fireReduction = new System.Windows.Forms.Label();
            this.physicalReduction2 = new System.Windows.Forms.Label();
            this.coldReduction2 = new System.Windows.Forms.Label();
            this.labelPoisReduct = new System.Windows.Forms.Label();
            this.labelLightReduct = new System.Windows.Forms.Label();
            this.physicalReduction = new System.Windows.Forms.Label();
            this.labelArcReduct = new System.Windows.Forms.Label();
            this.coldReduction = new System.Windows.Forms.Label();
            this.labelFireReduct = new System.Windows.Forms.Label();
            this.labelColdReduct = new System.Windows.Forms.Label();
            this.labelPhysReduct = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dualWieldCheck = new System.Windows.Forms.CheckBox();
            this.groupOffensive = new System.Windows.Forms.GroupBox();
            this.labelLifeSteal = new System.Windows.Forms.Label();
            this.lifeSteal = new System.Windows.Forms.Label();
            this.labelCritChance = new System.Windows.Forms.Label();
            this.critMax = new System.Windows.Forms.Label();
            this.maxDmg = new System.Windows.Forms.Label();
            this.labelCritMin = new System.Windows.Forms.Label();
            this.labelCritMax = new System.Windows.Forms.Label();
            this.critDmg = new System.Windows.Forms.Label();
            this.critChance = new System.Windows.Forms.Label();
            this.labelCritDmg = new System.Windows.Forms.Label();
            this.critMin = new System.Windows.Forms.Label();
            this.labelMaxDmg = new System.Windows.Forms.Label();
            this.minDmg = new System.Windows.Forms.Label();
            this.labelMinDmg = new System.Windows.Forms.Label();
            this.groupActive = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.buttonAbility = new System.Windows.Forms.Button();
            this.femaleFrame = new System.Windows.Forms.PictureBox();
            this.maleFrame = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.paraLvlLabel = new System.Windows.Forms.Label();
            this.paraLvl = new System.Windows.Forms.ComboBox();
            this.groupAttributes.SuspendLayout();
            this.groupDefensive.SuspendLayout();
            this.reductionGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupOffensive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.femaleFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maleFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedClass
            // 
            this.selectedClass.AutoSize = true;
            this.selectedClass.Location = new System.Drawing.Point(48, 39);
            this.selectedClass.Name = "selectedClass";
            this.selectedClass.Size = new System.Drawing.Size(52, 13);
            this.selectedClass.TabIndex = 0;
            this.selectedClass.Text = "Barbarian";
            // 
            // barbarian
            // 
            this.barbarian.Location = new System.Drawing.Point(12, 12);
            this.barbarian.Name = "barbarian";
            this.barbarian.Size = new System.Drawing.Size(75, 23);
            this.barbarian.TabIndex = 1;
            this.barbarian.Text = "Barbarian";
            this.barbarian.UseVisualStyleBackColor = true;
            this.barbarian.Click += new System.EventHandler(this.barbarian_Click);
            // 
            // demon
            // 
            this.demon.Location = new System.Drawing.Point(93, 12);
            this.demon.Name = "demon";
            this.demon.Size = new System.Drawing.Size(88, 23);
            this.demon.TabIndex = 2;
            this.demon.Text = "Demon Hunter";
            this.demon.UseVisualStyleBackColor = true;
            this.demon.Click += new System.EventHandler(this.demon_Click);
            // 
            // wizard
            // 
            this.wizard.Location = new System.Drawing.Point(187, 12);
            this.wizard.Name = "wizard";
            this.wizard.Size = new System.Drawing.Size(75, 23);
            this.wizard.TabIndex = 3;
            this.wizard.Text = "Wizard";
            this.wizard.UseVisualStyleBackColor = true;
            this.wizard.Click += new System.EventHandler(this.wizard_Click);
            // 
            // witch
            // 
            this.witch.Location = new System.Drawing.Point(268, 12);
            this.witch.Name = "witch";
            this.witch.Size = new System.Drawing.Size(87, 23);
            this.witch.TabIndex = 4;
            this.witch.Text = "Witch Doctor";
            this.witch.UseVisualStyleBackColor = true;
            this.witch.Click += new System.EventHandler(this.witch_Click);
            // 
            // monk
            // 
            this.monk.Location = new System.Drawing.Point(361, 12);
            this.monk.Name = "monk";
            this.monk.Size = new System.Drawing.Size(79, 23);
            this.monk.TabIndex = 5;
            this.monk.Text = "Monk";
            this.monk.UseVisualStyleBackColor = true;
            this.monk.Click += new System.EventHandler(this.monk_Click);
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(9, 39);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(35, 13);
            this.labelSelected.TabIndex = 6;
            this.labelSelected.Text = "Class:";
            // 
            // levelBox
            // 
            this.levelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.levelBox.Location = new System.Drawing.Point(51, 56);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(39, 21);
            this.levelBox.TabIndex = 9;
            this.levelBox.SelectedIndexChanged += new System.EventHandler(this.levelBox_SelectedIndexChanged);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(9, 64);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(36, 13);
            this.labelLevel.TabIndex = 10;
            this.labelLevel.Text = "Level:";
            // 
            // groupAttributes
            // 
            this.groupAttributes.Controls.Add(this.HP);
            this.groupAttributes.Controls.Add(this.labelHP);
            this.groupAttributes.Controls.Add(this.armor);
            this.groupAttributes.Controls.Add(this.labelArmor);
            this.groupAttributes.Controls.Add(this.vitality);
            this.groupAttributes.Controls.Add(this.intelligence);
            this.groupAttributes.Controls.Add(this.dexterity);
            this.groupAttributes.Controls.Add(this.strength);
            this.groupAttributes.Controls.Add(this.labelVitality);
            this.groupAttributes.Controls.Add(this.labelIntelligence);
            this.groupAttributes.Controls.Add(this.labelDexterity);
            this.groupAttributes.Controls.Add(this.labelStrength);
            this.groupAttributes.Location = new System.Drawing.Point(12, 135);
            this.groupAttributes.Name = "groupAttributes";
            this.groupAttributes.Size = new System.Drawing.Size(121, 113);
            this.groupAttributes.TabIndex = 11;
            this.groupAttributes.TabStop = false;
            this.groupAttributes.Text = "Attributes";
            // 
            // HP
            // 
            this.HP.AutoSize = true;
            this.HP.Location = new System.Drawing.Point(53, 93);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(13, 13);
            this.HP.TabIndex = 30;
            this.HP.Text = "0";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(6, 93);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(25, 13);
            this.labelHP.TabIndex = 11;
            this.labelHP.Text = "HP:";
            // 
            // armor
            // 
            this.armor.AutoSize = true;
            this.armor.Location = new System.Drawing.Point(53, 81);
            this.armor.Name = "armor";
            this.armor.Size = new System.Drawing.Size(19, 13);
            this.armor.TabIndex = 10;
            this.armor.Text = "10";
            // 
            // labelArmor
            // 
            this.labelArmor.AutoSize = true;
            this.labelArmor.Location = new System.Drawing.Point(6, 80);
            this.labelArmor.Name = "labelArmor";
            this.labelArmor.Size = new System.Drawing.Size(37, 13);
            this.labelArmor.TabIndex = 8;
            this.labelArmor.Text = "Armor:";
            // 
            // vitality
            // 
            this.vitality.AutoSize = true;
            this.vitality.Location = new System.Drawing.Point(81, 55);
            this.vitality.Name = "vitality";
            this.vitality.Size = new System.Drawing.Size(13, 13);
            this.vitality.TabIndex = 7;
            this.vitality.Text = "9";
            // 
            // intelligence
            // 
            this.intelligence.AutoSize = true;
            this.intelligence.Location = new System.Drawing.Point(81, 42);
            this.intelligence.Name = "intelligence";
            this.intelligence.Size = new System.Drawing.Size(13, 13);
            this.intelligence.TabIndex = 6;
            this.intelligence.Text = "8";
            // 
            // dexterity
            // 
            this.dexterity.AutoSize = true;
            this.dexterity.Location = new System.Drawing.Point(81, 29);
            this.dexterity.Name = "dexterity";
            this.dexterity.Size = new System.Drawing.Size(13, 13);
            this.dexterity.TabIndex = 5;
            this.dexterity.Text = "8";
            // 
            // strength
            // 
            this.strength.AutoSize = true;
            this.strength.Location = new System.Drawing.Point(81, 16);
            this.strength.Name = "strength";
            this.strength.Size = new System.Drawing.Size(31, 13);
            this.strength.TabIndex = 4;
            this.strength.Text = "9999";
            // 
            // labelVitality
            // 
            this.labelVitality.AutoSize = true;
            this.labelVitality.Location = new System.Drawing.Point(6, 55);
            this.labelVitality.Name = "labelVitality";
            this.labelVitality.Size = new System.Drawing.Size(40, 13);
            this.labelVitality.TabIndex = 3;
            this.labelVitality.Text = "Vitality:";
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.Location = new System.Drawing.Point(6, 42);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(64, 13);
            this.labelIntelligence.TabIndex = 2;
            this.labelIntelligence.Text = "Intelligence:";
            // 
            // labelDexterity
            // 
            this.labelDexterity.AutoSize = true;
            this.labelDexterity.Location = new System.Drawing.Point(6, 29);
            this.labelDexterity.Name = "labelDexterity";
            this.labelDexterity.Size = new System.Drawing.Size(51, 13);
            this.labelDexterity.TabIndex = 1;
            this.labelDexterity.Text = "Dexterity:";
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Location = new System.Drawing.Point(6, 16);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(54, 13);
            this.labelStrength.TabIndex = 0;
            this.labelStrength.Text = "*Strength:";
            // 
            // DPS
            // 
            this.DPS.AutoSize = true;
            this.DPS.Location = new System.Drawing.Point(53, 113);
            this.DPS.Name = "DPS";
            this.DPS.Size = new System.Drawing.Size(13, 13);
            this.DPS.TabIndex = 11;
            this.DPS.Text = "0";
            // 
            // labelDPS
            // 
            this.labelDPS.AutoSize = true;
            this.labelDPS.Location = new System.Drawing.Point(6, 113);
            this.labelDPS.Name = "labelDPS";
            this.labelDPS.Size = new System.Drawing.Size(32, 13);
            this.labelDPS.TabIndex = 9;
            this.labelDPS.Text = "DPS:";
            // 
            // groupDefensive
            // 
            this.groupDefensive.Controls.Add(this.dodgeChance);
            this.groupDefensive.Controls.Add(this.labelDodge);
            this.groupDefensive.Controls.Add(this.arcaneResistance);
            this.groupDefensive.Controls.Add(this.poisonResistance);
            this.groupDefensive.Controls.Add(this.lightningResistance);
            this.groupDefensive.Controls.Add(this.fireResistance);
            this.groupDefensive.Controls.Add(this.coldResistance);
            this.groupDefensive.Controls.Add(this.physicalResistance);
            this.groupDefensive.Controls.Add(this.labelArcane);
            this.groupDefensive.Controls.Add(this.labelPoison);
            this.groupDefensive.Controls.Add(this.labelLightning);
            this.groupDefensive.Controls.Add(this.labelFire);
            this.groupDefensive.Controls.Add(this.labelCold);
            this.groupDefensive.Controls.Add(this.labelPhysical);
            this.groupDefensive.Location = new System.Drawing.Point(12, 254);
            this.groupDefensive.Name = "groupDefensive";
            this.groupDefensive.Size = new System.Drawing.Size(121, 125);
            this.groupDefensive.TabIndex = 12;
            this.groupDefensive.TabStop = false;
            this.groupDefensive.Text = "Defensive";
            // 
            // dodgeChance
            // 
            this.dodgeChance.AutoSize = true;
            this.dodgeChance.Location = new System.Drawing.Point(81, 104);
            this.dodgeChance.Name = "dodgeChance";
            this.dodgeChance.Size = new System.Drawing.Size(33, 13);
            this.dodgeChance.TabIndex = 14;
            this.dodgeChance.Text = "100%";
            // 
            // labelDodge
            // 
            this.labelDodge.AutoSize = true;
            this.labelDodge.Location = new System.Drawing.Point(6, 104);
            this.labelDodge.Name = "labelDodge";
            this.labelDodge.Size = new System.Drawing.Size(42, 13);
            this.labelDodge.TabIndex = 13;
            this.labelDodge.Text = "Dodge:";
            // 
            // arcaneResistance
            // 
            this.arcaneResistance.AutoSize = true;
            this.arcaneResistance.Location = new System.Drawing.Point(81, 81);
            this.arcaneResistance.Name = "arcaneResistance";
            this.arcaneResistance.Size = new System.Drawing.Size(13, 13);
            this.arcaneResistance.TabIndex = 12;
            this.arcaneResistance.Text = "0";
            // 
            // poisonResistance
            // 
            this.poisonResistance.AutoSize = true;
            this.poisonResistance.Location = new System.Drawing.Point(81, 68);
            this.poisonResistance.Name = "poisonResistance";
            this.poisonResistance.Size = new System.Drawing.Size(13, 13);
            this.poisonResistance.TabIndex = 11;
            this.poisonResistance.Text = "0";
            // 
            // lightningResistance
            // 
            this.lightningResistance.AutoSize = true;
            this.lightningResistance.Location = new System.Drawing.Point(81, 55);
            this.lightningResistance.Name = "lightningResistance";
            this.lightningResistance.Size = new System.Drawing.Size(13, 13);
            this.lightningResistance.TabIndex = 9;
            this.lightningResistance.Text = "0";
            // 
            // fireResistance
            // 
            this.fireResistance.AutoSize = true;
            this.fireResistance.Location = new System.Drawing.Point(81, 42);
            this.fireResistance.Name = "fireResistance";
            this.fireResistance.Size = new System.Drawing.Size(13, 13);
            this.fireResistance.TabIndex = 8;
            this.fireResistance.Text = "0";
            // 
            // coldResistance
            // 
            this.coldResistance.AutoSize = true;
            this.coldResistance.Location = new System.Drawing.Point(81, 29);
            this.coldResistance.Name = "coldResistance";
            this.coldResistance.Size = new System.Drawing.Size(13, 13);
            this.coldResistance.TabIndex = 7;
            this.coldResistance.Text = "0";
            // 
            // physicalResistance
            // 
            this.physicalResistance.AutoSize = true;
            this.physicalResistance.Location = new System.Drawing.Point(81, 16);
            this.physicalResistance.Name = "physicalResistance";
            this.physicalResistance.Size = new System.Drawing.Size(13, 13);
            this.physicalResistance.TabIndex = 6;
            this.physicalResistance.Text = "0";
            // 
            // labelArcane
            // 
            this.labelArcane.AutoSize = true;
            this.labelArcane.Location = new System.Drawing.Point(6, 81);
            this.labelArcane.Name = "labelArcane";
            this.labelArcane.Size = new System.Drawing.Size(44, 13);
            this.labelArcane.TabIndex = 5;
            this.labelArcane.Text = "Arcane:";
            // 
            // labelPoison
            // 
            this.labelPoison.AutoSize = true;
            this.labelPoison.Location = new System.Drawing.Point(6, 68);
            this.labelPoison.Name = "labelPoison";
            this.labelPoison.Size = new System.Drawing.Size(42, 13);
            this.labelPoison.TabIndex = 4;
            this.labelPoison.Text = "Poison:";
            // 
            // labelLightning
            // 
            this.labelLightning.AutoSize = true;
            this.labelLightning.Location = new System.Drawing.Point(6, 55);
            this.labelLightning.Name = "labelLightning";
            this.labelLightning.Size = new System.Drawing.Size(53, 13);
            this.labelLightning.TabIndex = 3;
            this.labelLightning.Text = "Lightning:";
            // 
            // labelFire
            // 
            this.labelFire.AutoSize = true;
            this.labelFire.Location = new System.Drawing.Point(6, 42);
            this.labelFire.Name = "labelFire";
            this.labelFire.Size = new System.Drawing.Size(27, 13);
            this.labelFire.TabIndex = 2;
            this.labelFire.Text = "Fire:";
            // 
            // labelCold
            // 
            this.labelCold.AutoSize = true;
            this.labelCold.Location = new System.Drawing.Point(6, 29);
            this.labelCold.Name = "labelCold";
            this.labelCold.Size = new System.Drawing.Size(31, 13);
            this.labelCold.TabIndex = 1;
            this.labelCold.Text = "Cold:";
            // 
            // labelPhysical
            // 
            this.labelPhysical.AutoSize = true;
            this.labelPhysical.Location = new System.Drawing.Point(6, 16);
            this.labelPhysical.Name = "labelPhysical";
            this.labelPhysical.Size = new System.Drawing.Size(49, 13);
            this.labelPhysical.TabIndex = 0;
            this.labelPhysical.Text = "Physical:";
            // 
            // helmButton
            // 
            this.helmButton.Location = new System.Drawing.Point(85, 12);
            this.helmButton.Name = "helmButton";
            this.helmButton.Size = new System.Drawing.Size(48, 50);
            this.helmButton.TabIndex = 14;
            this.helmButton.Text = "Helm";
            this.helmButton.UseVisualStyleBackColor = true;
            this.helmButton.Click += new System.EventHandler(this.helmButton_Click);
            // 
            // shoulderButton
            // 
            this.shoulderButton.Location = new System.Drawing.Point(28, 30);
            this.shoulderButton.Name = "shoulderButton";
            this.shoulderButton.Size = new System.Drawing.Size(47, 69);
            this.shoulderButton.TabIndex = 15;
            this.shoulderButton.Text = "Shoul-ders";
            this.shoulderButton.UseVisualStyleBackColor = true;
            this.shoulderButton.Click += new System.EventHandler(this.shoulderButton_Click);
            // 
            // chestButton
            // 
            this.chestButton.Location = new System.Drawing.Point(82, 68);
            this.chestButton.Name = "chestButton";
            this.chestButton.Size = new System.Drawing.Size(56, 83);
            this.chestButton.TabIndex = 16;
            this.chestButton.Text = "Chest";
            this.chestButton.UseVisualStyleBackColor = true;
            this.chestButton.Click += new System.EventHandler(this.chestButton_Click);
            // 
            // amuletButton
            // 
            this.amuletButton.Location = new System.Drawing.Point(148, 49);
            this.amuletButton.Name = "amuletButton";
            this.amuletButton.Size = new System.Drawing.Size(38, 38);
            this.amuletButton.TabIndex = 17;
            this.amuletButton.Text = "Amu-let";
            this.amuletButton.UseVisualStyleBackColor = true;
            this.amuletButton.Click += new System.EventHandler(this.amuletButton_Click);
            // 
            // bracerButton
            // 
            this.bracerButton.Location = new System.Drawing.Point(165, 108);
            this.bracerButton.Name = "bracerButton";
            this.bracerButton.Size = new System.Drawing.Size(47, 68);
            this.bracerButton.TabIndex = 18;
            this.bracerButton.Text = "Bracer";
            this.bracerButton.UseVisualStyleBackColor = true;
            this.bracerButton.Click += new System.EventHandler(this.bracerButton_Click);
            // 
            // handsButton
            // 
            this.handsButton.Location = new System.Drawing.Point(10, 108);
            this.handsButton.Name = "handsButton";
            this.handsButton.Size = new System.Drawing.Size(46, 67);
            this.handsButton.TabIndex = 19;
            this.handsButton.Text = "Hands";
            this.handsButton.UseVisualStyleBackColor = true;
            this.handsButton.Click += new System.EventHandler(this.handsButton_Click);
            // 
            // beltButton
            // 
            this.beltButton.Location = new System.Drawing.Point(82, 161);
            this.beltButton.Name = "beltButton";
            this.beltButton.Size = new System.Drawing.Size(57, 23);
            this.beltButton.TabIndex = 20;
            this.beltButton.Text = "Belt";
            this.beltButton.UseVisualStyleBackColor = true;
            this.beltButton.Click += new System.EventHandler(this.beltButton_Click);
            // 
            // ringButton1
            // 
            this.ringButton1.Location = new System.Drawing.Point(17, 187);
            this.ringButton1.Name = "ringButton1";
            this.ringButton1.Size = new System.Drawing.Size(32, 32);
            this.ringButton1.TabIndex = 21;
            this.ringButton1.Text = "O";
            this.ringButton1.UseVisualStyleBackColor = true;
            this.ringButton1.Click += new System.EventHandler(this.ringButton1_Click);
            // 
            // legsButton
            // 
            this.legsButton.Location = new System.Drawing.Point(88, 190);
            this.legsButton.Name = "legsButton";
            this.legsButton.Size = new System.Drawing.Size(44, 68);
            this.legsButton.TabIndex = 22;
            this.legsButton.Text = "Legs";
            this.legsButton.UseVisualStyleBackColor = true;
            this.legsButton.Click += new System.EventHandler(this.legsButton_Click);
            // 
            // ringButton2
            // 
            this.ringButton2.Location = new System.Drawing.Point(172, 188);
            this.ringButton2.Name = "ringButton2";
            this.ringButton2.Size = new System.Drawing.Size(30, 30);
            this.ringButton2.TabIndex = 23;
            this.ringButton2.Text = "O";
            this.ringButton2.UseVisualStyleBackColor = true;
            this.ringButton2.Click += new System.EventHandler(this.ringButton2_Click);
            // 
            // offhandButton
            // 
            this.offhandButton.Location = new System.Drawing.Point(165, 229);
            this.offhandButton.Name = "offhandButton";
            this.offhandButton.Size = new System.Drawing.Size(47, 103);
            this.offhandButton.TabIndex = 24;
            this.offhandButton.Text = "Off hand";
            this.offhandButton.UseVisualStyleBackColor = true;
            this.offhandButton.Click += new System.EventHandler(this.offhandButton_Click);
            // 
            // bootsButton
            // 
            this.bootsButton.Location = new System.Drawing.Point(88, 263);
            this.bootsButton.Name = "bootsButton";
            this.bootsButton.Size = new System.Drawing.Size(43, 68);
            this.bootsButton.TabIndex = 25;
            this.bootsButton.Text = "Boots";
            this.bootsButton.UseVisualStyleBackColor = true;
            this.bootsButton.Click += new System.EventHandler(this.bootsButton_Click);
            // 
            // mainhandButton
            // 
            this.mainhandButton.Location = new System.Drawing.Point(9, 229);
            this.mainhandButton.Name = "mainhandButton";
            this.mainhandButton.Size = new System.Drawing.Size(47, 102);
            this.mainhandButton.TabIndex = 26;
            this.mainhandButton.Text = "Main hand";
            this.mainhandButton.UseVisualStyleBackColor = true;
            this.mainhandButton.Click += new System.EventHandler(this.mainhandButton_Click);
            // 
            // reductionGroup
            // 
            this.reductionGroup.Controls.Add(this.arcaneReduction4);
            this.reductionGroup.Controls.Add(this.poisonReduction4);
            this.reductionGroup.Controls.Add(this.lightningReduction4);
            this.reductionGroup.Controls.Add(this.fireReduction4);
            this.reductionGroup.Controls.Add(this.coldReduction4);
            this.reductionGroup.Controls.Add(this.physicalReduction4);
            this.reductionGroup.Controls.Add(this.levelReduction4);
            this.reductionGroup.Controls.Add(this.levelReduction3);
            this.reductionGroup.Controls.Add(this.levelReduction2);
            this.reductionGroup.Controls.Add(this.levelReduction);
            this.reductionGroup.Controls.Add(this.arcaneReduction3);
            this.reductionGroup.Controls.Add(this.poisonReduction3);
            this.reductionGroup.Controls.Add(this.lightningReduction3);
            this.reductionGroup.Controls.Add(this.fireReduction3);
            this.reductionGroup.Controls.Add(this.physicalReduction3);
            this.reductionGroup.Controls.Add(this.coldReduction3);
            this.reductionGroup.Controls.Add(this.arcaneReduction2);
            this.reductionGroup.Controls.Add(this.arcaneReduction);
            this.reductionGroup.Controls.Add(this.poisonReduction2);
            this.reductionGroup.Controls.Add(this.poisonReduction);
            this.reductionGroup.Controls.Add(this.lightningReduction2);
            this.reductionGroup.Controls.Add(this.lightningReduction);
            this.reductionGroup.Controls.Add(this.fireReduction2);
            this.reductionGroup.Controls.Add(this.fireReduction);
            this.reductionGroup.Controls.Add(this.physicalReduction2);
            this.reductionGroup.Controls.Add(this.coldReduction2);
            this.reductionGroup.Controls.Add(this.labelPoisReduct);
            this.reductionGroup.Controls.Add(this.labelLightReduct);
            this.reductionGroup.Controls.Add(this.physicalReduction);
            this.reductionGroup.Controls.Add(this.labelArcReduct);
            this.reductionGroup.Controls.Add(this.coldReduction);
            this.reductionGroup.Controls.Add(this.labelFireReduct);
            this.reductionGroup.Controls.Add(this.labelColdReduct);
            this.reductionGroup.Controls.Add(this.labelPhysReduct);
            this.reductionGroup.Location = new System.Drawing.Point(377, 248);
            this.reductionGroup.Name = "reductionGroup";
            this.reductionGroup.Size = new System.Drawing.Size(296, 114);
            this.reductionGroup.TabIndex = 27;
            this.reductionGroup.TabStop = false;
            this.reductionGroup.Text = "Damage Reduction";
            // 
            // arcaneReduction4
            // 
            this.arcaneReduction4.AutoSize = true;
            this.arcaneReduction4.Location = new System.Drawing.Point(250, 94);
            this.arcaneReduction4.Name = "arcaneReduction4";
            this.arcaneReduction4.Size = new System.Drawing.Size(27, 13);
            this.arcaneReduction4.TabIndex = 50;
            this.arcaneReduction4.Text = "99%";
            // 
            // poisonReduction4
            // 
            this.poisonReduction4.AutoSize = true;
            this.poisonReduction4.Location = new System.Drawing.Point(250, 81);
            this.poisonReduction4.Name = "poisonReduction4";
            this.poisonReduction4.Size = new System.Drawing.Size(27, 13);
            this.poisonReduction4.TabIndex = 49;
            this.poisonReduction4.Text = "99%";
            // 
            // lightningReduction4
            // 
            this.lightningReduction4.AutoSize = true;
            this.lightningReduction4.Location = new System.Drawing.Point(250, 68);
            this.lightningReduction4.Name = "lightningReduction4";
            this.lightningReduction4.Size = new System.Drawing.Size(27, 13);
            this.lightningReduction4.TabIndex = 48;
            this.lightningReduction4.Text = "99%";
            // 
            // fireReduction4
            // 
            this.fireReduction4.AutoSize = true;
            this.fireReduction4.Location = new System.Drawing.Point(250, 55);
            this.fireReduction4.Name = "fireReduction4";
            this.fireReduction4.Size = new System.Drawing.Size(27, 13);
            this.fireReduction4.TabIndex = 47;
            this.fireReduction4.Text = "99%";
            // 
            // coldReduction4
            // 
            this.coldReduction4.AutoSize = true;
            this.coldReduction4.Location = new System.Drawing.Point(250, 42);
            this.coldReduction4.Name = "coldReduction4";
            this.coldReduction4.Size = new System.Drawing.Size(27, 13);
            this.coldReduction4.TabIndex = 46;
            this.coldReduction4.Text = "99%";
            // 
            // physicalReduction4
            // 
            this.physicalReduction4.AutoSize = true;
            this.physicalReduction4.Location = new System.Drawing.Point(250, 29);
            this.physicalReduction4.Name = "physicalReduction4";
            this.physicalReduction4.Size = new System.Drawing.Size(42, 13);
            this.physicalReduction4.TabIndex = 45;
            this.physicalReduction4.Text = "99.99%";
            // 
            // levelReduction4
            // 
            this.levelReduction4.AutoSize = true;
            this.levelReduction4.Location = new System.Drawing.Point(250, 16);
            this.levelReduction4.Name = "levelReduction4";
            this.levelReduction4.Size = new System.Drawing.Size(36, 13);
            this.levelReduction4.TabIndex = 44;
            this.levelReduction4.Text = "Lvl 63";
            // 
            // levelReduction3
            // 
            this.levelReduction3.AutoSize = true;
            this.levelReduction3.Location = new System.Drawing.Point(202, 16);
            this.levelReduction3.Name = "levelReduction3";
            this.levelReduction3.Size = new System.Drawing.Size(36, 13);
            this.levelReduction3.TabIndex = 43;
            this.levelReduction3.Text = "Lvl 62";
            // 
            // levelReduction2
            // 
            this.levelReduction2.AutoSize = true;
            this.levelReduction2.Location = new System.Drawing.Point(154, 16);
            this.levelReduction2.Name = "levelReduction2";
            this.levelReduction2.Size = new System.Drawing.Size(36, 13);
            this.levelReduction2.TabIndex = 42;
            this.levelReduction2.Text = "Lvl 61";
            // 
            // levelReduction
            // 
            this.levelReduction.AutoSize = true;
            this.levelReduction.Location = new System.Drawing.Point(106, 16);
            this.levelReduction.Name = "levelReduction";
            this.levelReduction.Size = new System.Drawing.Size(36, 13);
            this.levelReduction.TabIndex = 41;
            this.levelReduction.Text = "Lvl 60";
            // 
            // arcaneReduction3
            // 
            this.arcaneReduction3.AutoSize = true;
            this.arcaneReduction3.Location = new System.Drawing.Point(202, 94);
            this.arcaneReduction3.Name = "arcaneReduction3";
            this.arcaneReduction3.Size = new System.Drawing.Size(27, 13);
            this.arcaneReduction3.TabIndex = 40;
            this.arcaneReduction3.Text = "99%";
            // 
            // poisonReduction3
            // 
            this.poisonReduction3.AutoSize = true;
            this.poisonReduction3.Location = new System.Drawing.Point(202, 81);
            this.poisonReduction3.Name = "poisonReduction3";
            this.poisonReduction3.Size = new System.Drawing.Size(27, 13);
            this.poisonReduction3.TabIndex = 39;
            this.poisonReduction3.Text = "99%";
            // 
            // lightningReduction3
            // 
            this.lightningReduction3.AutoSize = true;
            this.lightningReduction3.Location = new System.Drawing.Point(202, 68);
            this.lightningReduction3.Name = "lightningReduction3";
            this.lightningReduction3.Size = new System.Drawing.Size(27, 13);
            this.lightningReduction3.TabIndex = 38;
            this.lightningReduction3.Text = "99%";
            // 
            // fireReduction3
            // 
            this.fireReduction3.AutoSize = true;
            this.fireReduction3.Location = new System.Drawing.Point(202, 55);
            this.fireReduction3.Name = "fireReduction3";
            this.fireReduction3.Size = new System.Drawing.Size(27, 13);
            this.fireReduction3.TabIndex = 37;
            this.fireReduction3.Text = "99%";
            // 
            // physicalReduction3
            // 
            this.physicalReduction3.AutoSize = true;
            this.physicalReduction3.Location = new System.Drawing.Point(202, 30);
            this.physicalReduction3.Name = "physicalReduction3";
            this.physicalReduction3.Size = new System.Drawing.Size(42, 13);
            this.physicalReduction3.TabIndex = 35;
            this.physicalReduction3.Text = "99.99%";
            // 
            // coldReduction3
            // 
            this.coldReduction3.AutoSize = true;
            this.coldReduction3.Location = new System.Drawing.Point(202, 42);
            this.coldReduction3.Name = "coldReduction3";
            this.coldReduction3.Size = new System.Drawing.Size(27, 13);
            this.coldReduction3.TabIndex = 36;
            this.coldReduction3.Text = "99%";
            // 
            // arcaneReduction2
            // 
            this.arcaneReduction2.AutoSize = true;
            this.arcaneReduction2.Location = new System.Drawing.Point(154, 94);
            this.arcaneReduction2.Name = "arcaneReduction2";
            this.arcaneReduction2.Size = new System.Drawing.Size(27, 13);
            this.arcaneReduction2.TabIndex = 34;
            this.arcaneReduction2.Text = "99%";
            // 
            // arcaneReduction
            // 
            this.arcaneReduction.AutoSize = true;
            this.arcaneReduction.Location = new System.Drawing.Point(106, 94);
            this.arcaneReduction.Name = "arcaneReduction";
            this.arcaneReduction.Size = new System.Drawing.Size(27, 13);
            this.arcaneReduction.TabIndex = 11;
            this.arcaneReduction.Text = "99%";
            // 
            // poisonReduction2
            // 
            this.poisonReduction2.AutoSize = true;
            this.poisonReduction2.Location = new System.Drawing.Point(154, 81);
            this.poisonReduction2.Name = "poisonReduction2";
            this.poisonReduction2.Size = new System.Drawing.Size(27, 13);
            this.poisonReduction2.TabIndex = 33;
            this.poisonReduction2.Text = "99%";
            // 
            // poisonReduction
            // 
            this.poisonReduction.AutoSize = true;
            this.poisonReduction.Location = new System.Drawing.Point(106, 81);
            this.poisonReduction.Name = "poisonReduction";
            this.poisonReduction.Size = new System.Drawing.Size(27, 13);
            this.poisonReduction.TabIndex = 10;
            this.poisonReduction.Text = "99%";
            // 
            // lightningReduction2
            // 
            this.lightningReduction2.AutoSize = true;
            this.lightningReduction2.Location = new System.Drawing.Point(154, 68);
            this.lightningReduction2.Name = "lightningReduction2";
            this.lightningReduction2.Size = new System.Drawing.Size(27, 13);
            this.lightningReduction2.TabIndex = 32;
            this.lightningReduction2.Text = "99%";
            // 
            // lightningReduction
            // 
            this.lightningReduction.AutoSize = true;
            this.lightningReduction.Location = new System.Drawing.Point(106, 68);
            this.lightningReduction.Name = "lightningReduction";
            this.lightningReduction.Size = new System.Drawing.Size(27, 13);
            this.lightningReduction.TabIndex = 9;
            this.lightningReduction.Text = "99%";
            // 
            // fireReduction2
            // 
            this.fireReduction2.AutoSize = true;
            this.fireReduction2.Location = new System.Drawing.Point(154, 55);
            this.fireReduction2.Name = "fireReduction2";
            this.fireReduction2.Size = new System.Drawing.Size(27, 13);
            this.fireReduction2.TabIndex = 31;
            this.fireReduction2.Text = "99%";
            // 
            // fireReduction
            // 
            this.fireReduction.AutoSize = true;
            this.fireReduction.Location = new System.Drawing.Point(106, 55);
            this.fireReduction.Name = "fireReduction";
            this.fireReduction.Size = new System.Drawing.Size(27, 13);
            this.fireReduction.TabIndex = 8;
            this.fireReduction.Text = "99%";
            // 
            // physicalReduction2
            // 
            this.physicalReduction2.AutoSize = true;
            this.physicalReduction2.Location = new System.Drawing.Point(154, 30);
            this.physicalReduction2.Name = "physicalReduction2";
            this.physicalReduction2.Size = new System.Drawing.Size(42, 13);
            this.physicalReduction2.TabIndex = 29;
            this.physicalReduction2.Text = "99.99%";
            // 
            // coldReduction2
            // 
            this.coldReduction2.AutoSize = true;
            this.coldReduction2.Location = new System.Drawing.Point(154, 42);
            this.coldReduction2.Name = "coldReduction2";
            this.coldReduction2.Size = new System.Drawing.Size(27, 13);
            this.coldReduction2.TabIndex = 30;
            this.coldReduction2.Text = "99%";
            // 
            // labelPoisReduct
            // 
            this.labelPoisReduct.AutoSize = true;
            this.labelPoisReduct.Location = new System.Drawing.Point(6, 81);
            this.labelPoisReduct.Name = "labelPoisReduct";
            this.labelPoisReduct.Size = new System.Drawing.Size(94, 13);
            this.labelPoisReduct.TabIndex = 4;
            this.labelPoisReduct.Text = "Poison Reduction:";
            // 
            // labelLightReduct
            // 
            this.labelLightReduct.AutoSize = true;
            this.labelLightReduct.Location = new System.Drawing.Point(6, 68);
            this.labelLightReduct.Name = "labelLightReduct";
            this.labelLightReduct.Size = new System.Drawing.Size(105, 13);
            this.labelLightReduct.TabIndex = 3;
            this.labelLightReduct.Text = "Lightning Reduction:";
            // 
            // physicalReduction
            // 
            this.physicalReduction.AutoSize = true;
            this.physicalReduction.Location = new System.Drawing.Point(106, 30);
            this.physicalReduction.Name = "physicalReduction";
            this.physicalReduction.Size = new System.Drawing.Size(42, 13);
            this.physicalReduction.TabIndex = 6;
            this.physicalReduction.Text = "99.99%";
            // 
            // labelArcReduct
            // 
            this.labelArcReduct.AutoSize = true;
            this.labelArcReduct.Location = new System.Drawing.Point(6, 93);
            this.labelArcReduct.Name = "labelArcReduct";
            this.labelArcReduct.Size = new System.Drawing.Size(96, 13);
            this.labelArcReduct.TabIndex = 5;
            this.labelArcReduct.Text = "Arcane Reduction:";
            // 
            // coldReduction
            // 
            this.coldReduction.AutoSize = true;
            this.coldReduction.Location = new System.Drawing.Point(106, 42);
            this.coldReduction.Name = "coldReduction";
            this.coldReduction.Size = new System.Drawing.Size(27, 13);
            this.coldReduction.TabIndex = 7;
            this.coldReduction.Text = "99%";
            // 
            // labelFireReduct
            // 
            this.labelFireReduct.AutoSize = true;
            this.labelFireReduct.Location = new System.Drawing.Point(6, 55);
            this.labelFireReduct.Name = "labelFireReduct";
            this.labelFireReduct.Size = new System.Drawing.Size(79, 13);
            this.labelFireReduct.TabIndex = 2;
            this.labelFireReduct.Text = "Fire Reduction:";
            // 
            // labelColdReduct
            // 
            this.labelColdReduct.AutoSize = true;
            this.labelColdReduct.Location = new System.Drawing.Point(6, 42);
            this.labelColdReduct.Name = "labelColdReduct";
            this.labelColdReduct.Size = new System.Drawing.Size(83, 13);
            this.labelColdReduct.TabIndex = 1;
            this.labelColdReduct.Text = "Cold Reduction:";
            // 
            // labelPhysReduct
            // 
            this.labelPhysReduct.AutoSize = true;
            this.labelPhysReduct.Location = new System.Drawing.Point(6, 29);
            this.labelPhysReduct.Name = "labelPhysReduct";
            this.labelPhysReduct.Size = new System.Drawing.Size(101, 13);
            this.labelPhysReduct.TabIndex = 0;
            this.labelPhysReduct.Text = "Physical Reduction:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dualWieldCheck);
            this.groupBox1.Controls.Add(this.mainhandButton);
            this.groupBox1.Controls.Add(this.bootsButton);
            this.groupBox1.Controls.Add(this.offhandButton);
            this.groupBox1.Controls.Add(this.ringButton2);
            this.groupBox1.Controls.Add(this.legsButton);
            this.groupBox1.Controls.Add(this.ringButton1);
            this.groupBox1.Controls.Add(this.beltButton);
            this.groupBox1.Controls.Add(this.handsButton);
            this.groupBox1.Controls.Add(this.bracerButton);
            this.groupBox1.Controls.Add(this.amuletButton);
            this.groupBox1.Controls.Add(this.chestButton);
            this.groupBox1.Controls.Add(this.shoulderButton);
            this.groupBox1.Controls.Add(this.helmButton);
            this.groupBox1.Location = new System.Drawing.Point(139, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 341);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipment";
            // 
            // dualWieldCheck
            // 
            this.dualWieldCheck.AutoSize = true;
            this.dualWieldCheck.Location = new System.Drawing.Point(144, 26);
            this.dualWieldCheck.Name = "dualWieldCheck";
            this.dualWieldCheck.Size = new System.Drawing.Size(78, 17);
            this.dualWieldCheck.TabIndex = 35;
            this.dualWieldCheck.Text = "Dual-Wield";
            this.dualWieldCheck.UseVisualStyleBackColor = true;
            this.dualWieldCheck.CheckedChanged += new System.EventHandler(this.dualWieldCheck_CheckedChanged);
            // 
            // groupOffensive
            // 
            this.groupOffensive.Controls.Add(this.labelLifeSteal);
            this.groupOffensive.Controls.Add(this.lifeSteal);
            this.groupOffensive.Controls.Add(this.DPS);
            this.groupOffensive.Controls.Add(this.labelCritChance);
            this.groupOffensive.Controls.Add(this.critMax);
            this.groupOffensive.Controls.Add(this.labelDPS);
            this.groupOffensive.Controls.Add(this.maxDmg);
            this.groupOffensive.Controls.Add(this.labelCritMin);
            this.groupOffensive.Controls.Add(this.labelCritMax);
            this.groupOffensive.Controls.Add(this.critDmg);
            this.groupOffensive.Controls.Add(this.critChance);
            this.groupOffensive.Controls.Add(this.labelCritDmg);
            this.groupOffensive.Controls.Add(this.critMin);
            this.groupOffensive.Controls.Add(this.labelMaxDmg);
            this.groupOffensive.Controls.Add(this.minDmg);
            this.groupOffensive.Controls.Add(this.labelMinDmg);
            this.groupOffensive.Location = new System.Drawing.Point(12, 385);
            this.groupOffensive.Name = "groupOffensive";
            this.groupOffensive.Size = new System.Drawing.Size(121, 134);
            this.groupOffensive.TabIndex = 29;
            this.groupOffensive.TabStop = false;
            this.groupOffensive.Text = "Offensive";
            // 
            // labelLifeSteal
            // 
            this.labelLifeSteal.AutoSize = true;
            this.labelLifeSteal.Location = new System.Drawing.Point(6, 94);
            this.labelLifeSteal.Name = "labelLifeSteal";
            this.labelLifeSteal.Size = new System.Drawing.Size(54, 13);
            this.labelLifeSteal.TabIndex = 13;
            this.labelLifeSteal.Text = "Life Steal:";
            // 
            // lifeSteal
            // 
            this.lifeSteal.AutoSize = true;
            this.lifeSteal.Location = new System.Drawing.Point(59, 94);
            this.lifeSteal.Name = "lifeSteal";
            this.lifeSteal.Size = new System.Drawing.Size(64, 13);
            this.lifeSteal.TabIndex = 12;
            this.lifeSteal.Text = "9999 - 9999";
            // 
            // labelCritChance
            // 
            this.labelCritChance.AutoSize = true;
            this.labelCritChance.Location = new System.Drawing.Point(6, 68);
            this.labelCritChance.Name = "labelCritChance";
            this.labelCritChance.Size = new System.Drawing.Size(65, 13);
            this.labelCritChance.TabIndex = 11;
            this.labelCritChance.Text = "Crit Chance:";
            // 
            // critMax
            // 
            this.critMax.AutoSize = true;
            this.critMax.Location = new System.Drawing.Point(78, 55);
            this.critMax.Name = "critMax";
            this.critMax.Size = new System.Drawing.Size(37, 13);
            this.critMax.TabIndex = 10;
            this.critMax.Text = "99999";
            // 
            // maxDmg
            // 
            this.maxDmg.AutoSize = true;
            this.maxDmg.Location = new System.Drawing.Point(78, 28);
            this.maxDmg.Name = "maxDmg";
            this.maxDmg.Size = new System.Drawing.Size(13, 13);
            this.maxDmg.TabIndex = 9;
            this.maxDmg.Text = "0";
            // 
            // labelCritMin
            // 
            this.labelCritMin.AutoSize = true;
            this.labelCritMin.Location = new System.Drawing.Point(6, 42);
            this.labelCritMin.Name = "labelCritMin";
            this.labelCritMin.Size = new System.Drawing.Size(45, 13);
            this.labelCritMin.TabIndex = 8;
            this.labelCritMin.Text = "Crit Min:";
            // 
            // labelCritMax
            // 
            this.labelCritMax.AutoSize = true;
            this.labelCritMax.Location = new System.Drawing.Point(6, 55);
            this.labelCritMax.Name = "labelCritMax";
            this.labelCritMax.Size = new System.Drawing.Size(48, 13);
            this.labelCritMax.TabIndex = 7;
            this.labelCritMax.Text = "Crit Max:";
            // 
            // critDmg
            // 
            this.critDmg.AutoSize = true;
            this.critDmg.Location = new System.Drawing.Point(78, 81);
            this.critDmg.Name = "critDmg";
            this.critDmg.Size = new System.Drawing.Size(33, 13);
            this.critDmg.TabIndex = 6;
            this.critDmg.Text = "250%";
            // 
            // critChance
            // 
            this.critChance.AutoSize = true;
            this.critChance.Location = new System.Drawing.Point(78, 68);
            this.critChance.Name = "critChance";
            this.critChance.Size = new System.Drawing.Size(42, 13);
            this.critChance.TabIndex = 5;
            this.critChance.Text = "99.50%";
            // 
            // labelCritDmg
            // 
            this.labelCritDmg.AutoSize = true;
            this.labelCritDmg.Location = new System.Drawing.Point(6, 81);
            this.labelCritDmg.Name = "labelCritDmg";
            this.labelCritDmg.Size = new System.Drawing.Size(68, 13);
            this.labelCritDmg.TabIndex = 4;
            this.labelCritDmg.Text = "Crit Damage:";
            // 
            // critMin
            // 
            this.critMin.AutoSize = true;
            this.critMin.Location = new System.Drawing.Point(78, 42);
            this.critMin.Name = "critMin";
            this.critMin.Size = new System.Drawing.Size(13, 13);
            this.critMin.TabIndex = 3;
            this.critMin.Text = "0";
            // 
            // labelMaxDmg
            // 
            this.labelMaxDmg.AutoSize = true;
            this.labelMaxDmg.Location = new System.Drawing.Point(6, 29);
            this.labelMaxDmg.Name = "labelMaxDmg";
            this.labelMaxDmg.Size = new System.Drawing.Size(73, 13);
            this.labelMaxDmg.TabIndex = 2;
            this.labelMaxDmg.Text = "Max Damage:";
            // 
            // minDmg
            // 
            this.minDmg.AutoSize = true;
            this.minDmg.Location = new System.Drawing.Point(78, 16);
            this.minDmg.Name = "minDmg";
            this.minDmg.Size = new System.Drawing.Size(37, 13);
            this.minDmg.TabIndex = 1;
            this.minDmg.Text = "99999";
            // 
            // labelMinDmg
            // 
            this.labelMinDmg.AutoSize = true;
            this.labelMinDmg.Location = new System.Drawing.Point(6, 16);
            this.labelMinDmg.Name = "labelMinDmg";
            this.labelMinDmg.Size = new System.Drawing.Size(70, 13);
            this.labelMinDmg.TabIndex = 0;
            this.labelMinDmg.Text = "Min Damage:";
            // 
            // groupActive
            // 
            this.groupActive.Enabled = false;
            this.groupActive.Location = new System.Drawing.Point(138, 388);
            this.groupActive.Name = "groupActive";
            this.groupActive.Size = new System.Drawing.Size(535, 89);
            this.groupActive.TabIndex = 30;
            this.groupActive.TabStop = false;
            this.groupActive.Text = "Active Skills";
            this.groupActive.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(377, 42);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 29);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(377, 77);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(64, 29);
            this.loadButton.TabIndex = 32;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "d3c";
            this.saveFile.FileName = "D3 Calculator save";
            this.saveFile.Filter = "D3 Calculator|*.d3c";
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFile_FileOk);
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "d3c";
            this.openFile.FileName = "D3 Calculator save";
            this.openFile.Filter = "D3 Calculator|*.d3c";
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFile_FileOk);
            // 
            // buttonAbility
            // 
            this.buttonAbility.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAbility.Location = new System.Drawing.Point(377, 365);
            this.buttonAbility.Name = "buttonAbility";
            this.buttonAbility.Size = new System.Drawing.Size(90, 26);
            this.buttonAbility.TabIndex = 33;
            this.buttonAbility.Text = "Abilities";
            this.buttonAbility.UseVisualStyleBackColor = true;
            this.buttonAbility.Click += new System.EventHandler(this.buttonAbility_Click);
            // 
            // femaleFrame
            // 
            this.femaleFrame.Location = new System.Drawing.Point(563, 12);
            this.femaleFrame.Name = "femaleFrame";
            this.femaleFrame.Size = new System.Drawing.Size(110, 230);
            this.femaleFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.femaleFrame.TabIndex = 8;
            this.femaleFrame.TabStop = false;
            // 
            // maleFrame
            // 
            this.maleFrame.BackColor = System.Drawing.SystemColors.Control;
            this.maleFrame.Location = new System.Drawing.Point(447, 13);
            this.maleFrame.Name = "maleFrame";
            this.maleFrame.Size = new System.Drawing.Size(110, 230);
            this.maleFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maleFrame.TabIndex = 7;
            this.maleFrame.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(377, 112);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(64, 29);
            this.clearButton.TabIndex = 34;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // paraLvlLabel
            // 
            this.paraLvlLabel.AutoSize = true;
            this.paraLvlLabel.Location = new System.Drawing.Point(12, 85);
            this.paraLvlLabel.Name = "paraLvlLabel";
            this.paraLvlLabel.Size = new System.Drawing.Size(79, 13);
            this.paraLvlLabel.TabIndex = 3;
            this.paraLvlLabel.Text = "Paragon Level:";
            // 
            // paraLvl
            // 
            this.paraLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paraLvl.FormattingEnabled = true;
            this.paraLvl.Location = new System.Drawing.Point(97, 77);
            this.paraLvl.Name = "paraLvl";
            this.paraLvl.Size = new System.Drawing.Size(36, 21);
            this.paraLvl.TabIndex = 35;
            this.paraLvl.SelectedIndexChanged += new System.EventHandler(this.levelBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 531);
            this.Controls.Add(this.paraLvl);
            this.Controls.Add(this.paraLvlLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.buttonAbility);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupActive);
            this.Controls.Add(this.groupOffensive);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reductionGroup);
            this.Controls.Add(this.groupDefensive);
            this.Controls.Add(this.groupAttributes);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.femaleFrame);
            this.Controls.Add(this.maleFrame);
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.monk);
            this.Controls.Add(this.witch);
            this.Controls.Add(this.wizard);
            this.Controls.Add(this.demon);
            this.Controls.Add(this.barbarian);
            this.Controls.Add(this.selectedClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "D3 Calculator";
            this.groupAttributes.ResumeLayout(false);
            this.groupAttributes.PerformLayout();
            this.groupDefensive.ResumeLayout(false);
            this.groupDefensive.PerformLayout();
            this.reductionGroup.ResumeLayout(false);
            this.reductionGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupOffensive.ResumeLayout(false);
            this.groupOffensive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.femaleFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maleFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectedClass;
        private System.Windows.Forms.Button barbarian;
        private System.Windows.Forms.Button demon;
        private System.Windows.Forms.Button wizard;
        private System.Windows.Forms.Button witch;
        private System.Windows.Forms.Button monk;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.PictureBox maleFrame;
        private System.Windows.Forms.PictureBox femaleFrame;
        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.GroupBox groupAttributes;
        private System.Windows.Forms.Label vitality;
        private System.Windows.Forms.Label intelligence;
        private System.Windows.Forms.Label dexterity;
        private System.Windows.Forms.Label strength;
        private System.Windows.Forms.Label labelVitality;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.Label labelDexterity;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label DPS;
        private System.Windows.Forms.Label armor;
        private System.Windows.Forms.Label labelDPS;
        private System.Windows.Forms.Label labelArmor;
        private System.Windows.Forms.GroupBox groupDefensive;
        private System.Windows.Forms.Label labelArcane;
        private System.Windows.Forms.Label labelPoison;
        private System.Windows.Forms.Label labelLightning;
        private System.Windows.Forms.Label labelFire;
        private System.Windows.Forms.Label labelCold;
        private System.Windows.Forms.Label labelPhysical;
        private System.Windows.Forms.Label arcaneResistance;
        private System.Windows.Forms.Label poisonResistance;
        private System.Windows.Forms.Label lightningResistance;
        private System.Windows.Forms.Label fireResistance;
        private System.Windows.Forms.Label coldResistance;
        private System.Windows.Forms.Label physicalResistance;
        private System.Windows.Forms.Button helmButton;
        private System.Windows.Forms.Button shoulderButton;
        private System.Windows.Forms.Button chestButton;
        private System.Windows.Forms.Button amuletButton;
        private System.Windows.Forms.Button bracerButton;
        private System.Windows.Forms.Button handsButton;
        private System.Windows.Forms.Button beltButton;
        private System.Windows.Forms.Button ringButton1;
        private System.Windows.Forms.Button legsButton;
        private System.Windows.Forms.Button ringButton2;
        private System.Windows.Forms.Button offhandButton;
        private System.Windows.Forms.Button bootsButton;
        private System.Windows.Forms.Button mainhandButton;
        private System.Windows.Forms.GroupBox reductionGroup;
        private System.Windows.Forms.Label physicalReduction;
        private System.Windows.Forms.Label labelArcReduct;
        private System.Windows.Forms.Label coldReduction;
        private System.Windows.Forms.Label labelFireReduct;
        private System.Windows.Forms.Label labelColdReduct;
        private System.Windows.Forms.Label labelPhysReduct;
        private System.Windows.Forms.Label labelPoisReduct;
        private System.Windows.Forms.Label labelLightReduct;
        private System.Windows.Forms.Label arcaneReduction;
        private System.Windows.Forms.Label poisonReduction;
        private System.Windows.Forms.Label lightningReduction;
        private System.Windows.Forms.Label fireReduction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label levelReduction3;
        private System.Windows.Forms.Label levelReduction2;
        private System.Windows.Forms.Label levelReduction;
        private System.Windows.Forms.Label arcaneReduction3;
        private System.Windows.Forms.Label poisonReduction3;
        private System.Windows.Forms.Label lightningReduction3;
        private System.Windows.Forms.Label fireReduction3;
        private System.Windows.Forms.Label physicalReduction3;
        private System.Windows.Forms.Label coldReduction3;
        private System.Windows.Forms.Label arcaneReduction2;
        private System.Windows.Forms.Label poisonReduction2;
        private System.Windows.Forms.Label lightningReduction2;
        private System.Windows.Forms.Label fireReduction2;
        private System.Windows.Forms.Label physicalReduction2;
        private System.Windows.Forms.Label coldReduction2;
        private System.Windows.Forms.Label arcaneReduction4;
        private System.Windows.Forms.Label poisonReduction4;
        private System.Windows.Forms.Label lightningReduction4;
        private System.Windows.Forms.Label fireReduction4;
        private System.Windows.Forms.Label coldReduction4;
        private System.Windows.Forms.Label physicalReduction4;
        private System.Windows.Forms.Label levelReduction4;
        private System.Windows.Forms.GroupBox groupOffensive;
        private System.Windows.Forms.Label labelCritChance;
        private System.Windows.Forms.Label critMax;
        private System.Windows.Forms.Label maxDmg;
        private System.Windows.Forms.Label labelCritMin;
        private System.Windows.Forms.Label labelCritMax;
        private System.Windows.Forms.Label critDmg;
        private System.Windows.Forms.Label critChance;
        private System.Windows.Forms.Label labelCritDmg;
        private System.Windows.Forms.Label critMin;
        private System.Windows.Forms.Label labelMaxDmg;
        private System.Windows.Forms.Label minDmg;
        private System.Windows.Forms.Label labelMinDmg;
        private System.Windows.Forms.Label HP;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelLifeSteal;
        private System.Windows.Forms.Label lifeSteal;
        private System.Windows.Forms.GroupBox groupActive;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button buttonAbility;
        private System.Windows.Forms.Label labelDodge;
        private System.Windows.Forms.Label dodgeChance;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox dualWieldCheck;
        private System.Windows.Forms.Label paraLvlLabel;
        private System.Windows.Forms.ComboBox paraLvl;
    }
}

