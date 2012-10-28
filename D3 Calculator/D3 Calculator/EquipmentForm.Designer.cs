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
    partial class EquipmentForm
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
            this.labelArmor = new System.Windows.Forms.Label();
            this.labelAllRes = new System.Windows.Forms.Label();
            this.labelPhysRes = new System.Windows.Forms.Label();
            this.labelColdRes = new System.Windows.Forms.Label();
            this.labelFireRes = new System.Windows.Forms.Label();
            this.labelLightRes = new System.Windows.Forms.Label();
            this.labelPoiRes = new System.Windows.Forms.Label();
            this.labelCritDmg = new System.Windows.Forms.Label();
            this.labelArcRes = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelStr = new System.Windows.Forms.Label();
            this.labelDex = new System.Windows.Forms.Label();
            this.labelInt = new System.Windows.Forms.Label();
            this.labelVit = new System.Windows.Forms.Label();
            this.armor = new System.Windows.Forms.ComboBox();
            this.allRes = new System.Windows.Forms.ComboBox();
            this.arcRes = new System.Windows.Forms.ComboBox();
            this.poisonRes = new System.Windows.Forms.ComboBox();
            this.lightRes = new System.Windows.Forms.ComboBox();
            this.fireRes = new System.Windows.Forms.ComboBox();
            this.coldRes = new System.Windows.Forms.ComboBox();
            this.physRes = new System.Windows.Forms.ComboBox();
            this.labelMinDmg = new System.Windows.Forms.Label();
            this.labelMaxDmg = new System.Windows.Forms.Label();
            this.labelAPS = new System.Windows.Forms.Label();
            this.labelIAS = new System.Windows.Forms.Label();
            this.labelIDmg = new System.Windows.Forms.Label();
            this.labelCritChance = new System.Windows.Forms.Label();
            this.labelLifeSteal = new System.Windows.Forms.Label();
            this.minDmg = new System.Windows.Forms.ComboBox();
            this.maxDmg = new System.Windows.Forms.ComboBox();
            this.IAS = new System.Windows.Forms.ComboBox();
            this.lifeSteal = new System.Windows.Forms.ComboBox();
            this.increasedDmg = new System.Windows.Forms.ComboBox();
            this.APS = new System.Windows.Forms.ComboBox();
            this.increasedCritChance = new System.Windows.Forms.ComboBox();
            this.increasedCritDmg = new System.Windows.Forms.ComboBox();
            this.groupOffensive = new System.Windows.Forms.GroupBox();
            this.groupDefensive = new System.Windows.Forms.GroupBox();
            this.groupAttribute = new System.Windows.Forms.GroupBox();
            this.vit = new System.Windows.Forms.ComboBox();
            this.intel = new System.Windows.Forms.ComboBox();
            this.HP = new System.Windows.Forms.ComboBox();
            this.dex = new System.Windows.Forms.ComboBox();
            this.str = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.discardButton = new System.Windows.Forms.Button();
            this.groupOffensive.SuspendLayout();
            this.groupDefensive.SuspendLayout();
            this.groupAttribute.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelArmor
            // 
            this.labelArmor.AutoSize = true;
            this.labelArmor.Location = new System.Drawing.Point(79, 27);
            this.labelArmor.Name = "labelArmor";
            this.labelArmor.Size = new System.Drawing.Size(37, 13);
            this.labelArmor.TabIndex = 0;
            this.labelArmor.Text = "Armor:";
            // 
            // labelAllRes
            // 
            this.labelAllRes.AutoSize = true;
            this.labelAllRes.Location = new System.Drawing.Point(39, 54);
            this.labelAllRes.Name = "labelAllRes";
            this.labelAllRes.Size = new System.Drawing.Size(77, 13);
            this.labelAllRes.TabIndex = 6;
            this.labelAllRes.Text = "All Resistance:";
            // 
            // labelPhysRes
            // 
            this.labelPhysRes.AutoSize = true;
            this.labelPhysRes.Location = new System.Drawing.Point(11, 81);
            this.labelPhysRes.Name = "labelPhysRes";
            this.labelPhysRes.Size = new System.Drawing.Size(105, 13);
            this.labelPhysRes.TabIndex = 7;
            this.labelPhysRes.Text = "Physical Resistance:";
            // 
            // labelColdRes
            // 
            this.labelColdRes.AutoSize = true;
            this.labelColdRes.Location = new System.Drawing.Point(29, 110);
            this.labelColdRes.Name = "labelColdRes";
            this.labelColdRes.Size = new System.Drawing.Size(87, 13);
            this.labelColdRes.TabIndex = 8;
            this.labelColdRes.Text = "Cold Resistance:";
            // 
            // labelFireRes
            // 
            this.labelFireRes.AutoSize = true;
            this.labelFireRes.Location = new System.Drawing.Point(33, 135);
            this.labelFireRes.Name = "labelFireRes";
            this.labelFireRes.Size = new System.Drawing.Size(83, 13);
            this.labelFireRes.TabIndex = 9;
            this.labelFireRes.Text = "Fire Resistance:";
            // 
            // labelLightRes
            // 
            this.labelLightRes.AutoSize = true;
            this.labelLightRes.Location = new System.Drawing.Point(7, 162);
            this.labelLightRes.Name = "labelLightRes";
            this.labelLightRes.Size = new System.Drawing.Size(109, 13);
            this.labelLightRes.TabIndex = 10;
            this.labelLightRes.Text = "Lightning Resistance:";
            // 
            // labelPoiRes
            // 
            this.labelPoiRes.AutoSize = true;
            this.labelPoiRes.Location = new System.Drawing.Point(18, 189);
            this.labelPoiRes.Name = "labelPoiRes";
            this.labelPoiRes.Size = new System.Drawing.Size(98, 13);
            this.labelPoiRes.TabIndex = 11;
            this.labelPoiRes.Text = "Poison Resistance:";
            // 
            // labelCritDmg
            // 
            this.labelCritDmg.AutoSize = true;
            this.labelCritDmg.Location = new System.Drawing.Point(7, 189);
            this.labelCritDmg.Name = "labelCritDmg";
            this.labelCritDmg.Size = new System.Drawing.Size(139, 13);
            this.labelCritDmg.TabIndex = 13;
            this.labelCritDmg.Text = "Critical Damage Increase %:";
            // 
            // labelArcRes
            // 
            this.labelArcRes.AutoSize = true;
            this.labelArcRes.Location = new System.Drawing.Point(16, 216);
            this.labelArcRes.Name = "labelArcRes";
            this.labelArcRes.Size = new System.Drawing.Size(100, 13);
            this.labelArcRes.TabIndex = 14;
            this.labelArcRes.Text = "Arcane Resistance:";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(282, 27);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(36, 13);
            this.labelHP.TabIndex = 16;
            this.labelHP.Text = "HP %:";
            // 
            // labelStr
            // 
            this.labelStr.AutoSize = true;
            this.labelStr.Location = new System.Drawing.Point(7, 27);
            this.labelStr.Name = "labelStr";
            this.labelStr.Size = new System.Drawing.Size(50, 13);
            this.labelStr.TabIndex = 17;
            this.labelStr.Text = "Strength:";
            // 
            // labelDex
            // 
            this.labelDex.AutoSize = true;
            this.labelDex.Location = new System.Drawing.Point(6, 68);
            this.labelDex.Name = "labelDex";
            this.labelDex.Size = new System.Drawing.Size(51, 13);
            this.labelDex.TabIndex = 18;
            this.labelDex.Text = "Dexterity:";
            // 
            // labelInt
            // 
            this.labelInt.AutoSize = true;
            this.labelInt.Location = new System.Drawing.Point(126, 27);
            this.labelInt.Name = "labelInt";
            this.labelInt.Size = new System.Drawing.Size(64, 13);
            this.labelInt.TabIndex = 19;
            this.labelInt.Text = "Intelligence:";
            // 
            // labelVit
            // 
            this.labelVit.AutoSize = true;
            this.labelVit.Location = new System.Drawing.Point(150, 68);
            this.labelVit.Name = "labelVit";
            this.labelVit.Size = new System.Drawing.Size(40, 13);
            this.labelVit.TabIndex = 20;
            this.labelVit.Text = "Vitality:";
            // 
            // armor
            // 
            this.armor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.armor.FormattingEnabled = true;
            this.armor.Location = new System.Drawing.Point(122, 19);
            this.armor.Name = "armor";
            this.armor.Size = new System.Drawing.Size(54, 21);
            this.armor.TabIndex = 29;
            // 
            // allRes
            // 
            this.allRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allRes.FormattingEnabled = true;
            this.allRes.Location = new System.Drawing.Point(122, 46);
            this.allRes.Name = "allRes";
            this.allRes.Size = new System.Drawing.Size(43, 21);
            this.allRes.TabIndex = 30;
            // 
            // arcRes
            // 
            this.arcRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arcRes.FormattingEnabled = true;
            this.arcRes.Location = new System.Drawing.Point(122, 208);
            this.arcRes.Name = "arcRes";
            this.arcRes.Size = new System.Drawing.Size(43, 21);
            this.arcRes.TabIndex = 31;
            // 
            // poisonRes
            // 
            this.poisonRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.poisonRes.FormattingEnabled = true;
            this.poisonRes.Location = new System.Drawing.Point(122, 181);
            this.poisonRes.Name = "poisonRes";
            this.poisonRes.Size = new System.Drawing.Size(43, 21);
            this.poisonRes.TabIndex = 32;
            // 
            // lightRes
            // 
            this.lightRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lightRes.FormattingEnabled = true;
            this.lightRes.Location = new System.Drawing.Point(122, 154);
            this.lightRes.Name = "lightRes";
            this.lightRes.Size = new System.Drawing.Size(43, 21);
            this.lightRes.TabIndex = 33;
            // 
            // fireRes
            // 
            this.fireRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fireRes.FormattingEnabled = true;
            this.fireRes.Location = new System.Drawing.Point(122, 127);
            this.fireRes.Name = "fireRes";
            this.fireRes.Size = new System.Drawing.Size(43, 21);
            this.fireRes.TabIndex = 34;
            // 
            // coldRes
            // 
            this.coldRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coldRes.FormattingEnabled = true;
            this.coldRes.Location = new System.Drawing.Point(122, 100);
            this.coldRes.Name = "coldRes";
            this.coldRes.Size = new System.Drawing.Size(43, 21);
            this.coldRes.TabIndex = 35;
            // 
            // physRes
            // 
            this.physRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.physRes.FormattingEnabled = true;
            this.physRes.Location = new System.Drawing.Point(122, 73);
            this.physRes.Name = "physRes";
            this.physRes.Size = new System.Drawing.Size(43, 21);
            this.physRes.TabIndex = 36;
            // 
            // labelMinDmg
            // 
            this.labelMinDmg.AutoSize = true;
            this.labelMinDmg.Location = new System.Drawing.Point(52, 27);
            this.labelMinDmg.Name = "labelMinDmg";
            this.labelMinDmg.Size = new System.Drawing.Size(94, 13);
            this.labelMinDmg.TabIndex = 1;
            this.labelMinDmg.Text = "Minimum Damage:";
            // 
            // labelMaxDmg
            // 
            this.labelMaxDmg.AutoSize = true;
            this.labelMaxDmg.Location = new System.Drawing.Point(49, 54);
            this.labelMaxDmg.Name = "labelMaxDmg";
            this.labelMaxDmg.Size = new System.Drawing.Size(97, 13);
            this.labelMaxDmg.TabIndex = 2;
            this.labelMaxDmg.Text = "Maximum Damage:";
            // 
            // labelAPS
            // 
            this.labelAPS.AutoSize = true;
            this.labelAPS.Location = new System.Drawing.Point(41, 135);
            this.labelAPS.Name = "labelAPS";
            this.labelAPS.Size = new System.Drawing.Size(105, 13);
            this.labelAPS.TabIndex = 3;
            this.labelAPS.Text = "Attacks Per Second:";
            // 
            // labelIAS
            // 
            this.labelIAS.AutoSize = true;
            this.labelIAS.Location = new System.Drawing.Point(10, 81);
            this.labelIAS.Name = "labelIAS";
            this.labelIAS.Size = new System.Drawing.Size(136, 13);
            this.labelIAS.TabIndex = 4;
            this.labelIAS.Text = "Increased Attack Speed %:";
            // 
            // labelIDmg
            // 
            this.labelIDmg.AutoSize = true;
            this.labelIDmg.Location = new System.Drawing.Point(35, 110);
            this.labelIDmg.Name = "labelIDmg";
            this.labelIDmg.Size = new System.Drawing.Size(111, 13);
            this.labelIDmg.TabIndex = 5;
            this.labelIDmg.Text = "Increased Damage %:";
            // 
            // labelCritChance
            // 
            this.labelCritChance.AutoSize = true;
            this.labelCritChance.Location = new System.Drawing.Point(10, 162);
            this.labelCritChance.Name = "labelCritChance";
            this.labelCritChance.Size = new System.Drawing.Size(136, 13);
            this.labelCritChance.TabIndex = 12;
            this.labelCritChance.Text = "Critical Chance Increase %:";
            // 
            // labelLifeSteal
            // 
            this.labelLifeSteal.AutoSize = true;
            this.labelLifeSteal.Location = new System.Drawing.Point(81, 216);
            this.labelLifeSteal.Name = "labelLifeSteal";
            this.labelLifeSteal.Size = new System.Drawing.Size(65, 13);
            this.labelLifeSteal.TabIndex = 15;
            this.labelLifeSteal.Text = "Life Steal %:";
            // 
            // minDmg
            // 
            this.minDmg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minDmg.FormattingEnabled = true;
            this.minDmg.Location = new System.Drawing.Point(152, 19);
            this.minDmg.Name = "minDmg";
            this.minDmg.Size = new System.Drawing.Size(53, 21);
            this.minDmg.TabIndex = 21;
            // 
            // maxDmg
            // 
            this.maxDmg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maxDmg.FormattingEnabled = true;
            this.maxDmg.Location = new System.Drawing.Point(152, 46);
            this.maxDmg.Name = "maxDmg";
            this.maxDmg.Size = new System.Drawing.Size(53, 21);
            this.maxDmg.TabIndex = 22;
            // 
            // IAS
            // 
            this.IAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IAS.FormattingEnabled = true;
            this.IAS.Location = new System.Drawing.Point(152, 73);
            this.IAS.Name = "IAS";
            this.IAS.Size = new System.Drawing.Size(53, 21);
            this.IAS.TabIndex = 23;
            // 
            // lifeSteal
            // 
            this.lifeSteal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lifeSteal.FormattingEnabled = true;
            this.lifeSteal.Location = new System.Drawing.Point(152, 208);
            this.lifeSteal.Name = "lifeSteal";
            this.lifeSteal.Size = new System.Drawing.Size(53, 21);
            this.lifeSteal.TabIndex = 24;
            // 
            // increasedDmg
            // 
            this.increasedDmg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.increasedDmg.FormattingEnabled = true;
            this.increasedDmg.Location = new System.Drawing.Point(152, 100);
            this.increasedDmg.Name = "increasedDmg";
            this.increasedDmg.Size = new System.Drawing.Size(53, 21);
            this.increasedDmg.TabIndex = 25;
            // 
            // APS
            // 
            this.APS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.APS.FormattingEnabled = true;
            this.APS.Location = new System.Drawing.Point(152, 127);
            this.APS.Name = "APS";
            this.APS.Size = new System.Drawing.Size(53, 21);
            this.APS.TabIndex = 26;
            // 
            // increasedCritChance
            // 
            this.increasedCritChance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.increasedCritChance.FormattingEnabled = true;
            this.increasedCritChance.Location = new System.Drawing.Point(152, 154);
            this.increasedCritChance.Name = "increasedCritChance";
            this.increasedCritChance.Size = new System.Drawing.Size(53, 21);
            this.increasedCritChance.TabIndex = 27;
            // 
            // increasedCritDmg
            // 
            this.increasedCritDmg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.increasedCritDmg.FormattingEnabled = true;
            this.increasedCritDmg.Location = new System.Drawing.Point(152, 181);
            this.increasedCritDmg.Name = "increasedCritDmg";
            this.increasedCritDmg.Size = new System.Drawing.Size(53, 21);
            this.increasedCritDmg.TabIndex = 28;
            // 
            // groupOffensive
            // 
            this.groupOffensive.Controls.Add(this.increasedCritDmg);
            this.groupOffensive.Controls.Add(this.increasedCritChance);
            this.groupOffensive.Controls.Add(this.APS);
            this.groupOffensive.Controls.Add(this.increasedDmg);
            this.groupOffensive.Controls.Add(this.lifeSteal);
            this.groupOffensive.Controls.Add(this.IAS);
            this.groupOffensive.Controls.Add(this.maxDmg);
            this.groupOffensive.Controls.Add(this.minDmg);
            this.groupOffensive.Controls.Add(this.labelLifeSteal);
            this.groupOffensive.Controls.Add(this.labelCritDmg);
            this.groupOffensive.Controls.Add(this.labelCritChance);
            this.groupOffensive.Controls.Add(this.labelIDmg);
            this.groupOffensive.Controls.Add(this.labelIAS);
            this.groupOffensive.Controls.Add(this.labelAPS);
            this.groupOffensive.Controls.Add(this.labelMaxDmg);
            this.groupOffensive.Controls.Add(this.labelMinDmg);
            this.groupOffensive.Location = new System.Drawing.Point(12, 12);
            this.groupOffensive.Name = "groupOffensive";
            this.groupOffensive.Size = new System.Drawing.Size(223, 247);
            this.groupOffensive.TabIndex = 37;
            this.groupOffensive.TabStop = false;
            this.groupOffensive.Text = "Offensive";
            // 
            // groupDefensive
            // 
            this.groupDefensive.Controls.Add(this.physRes);
            this.groupDefensive.Controls.Add(this.coldRes);
            this.groupDefensive.Controls.Add(this.fireRes);
            this.groupDefensive.Controls.Add(this.lightRes);
            this.groupDefensive.Controls.Add(this.poisonRes);
            this.groupDefensive.Controls.Add(this.arcRes);
            this.groupDefensive.Controls.Add(this.allRes);
            this.groupDefensive.Controls.Add(this.armor);
            this.groupDefensive.Controls.Add(this.labelArcRes);
            this.groupDefensive.Controls.Add(this.labelPoiRes);
            this.groupDefensive.Controls.Add(this.labelLightRes);
            this.groupDefensive.Controls.Add(this.labelFireRes);
            this.groupDefensive.Controls.Add(this.labelColdRes);
            this.groupDefensive.Controls.Add(this.labelPhysRes);
            this.groupDefensive.Controls.Add(this.labelAllRes);
            this.groupDefensive.Controls.Add(this.labelArmor);
            this.groupDefensive.Location = new System.Drawing.Point(241, 12);
            this.groupDefensive.Name = "groupDefensive";
            this.groupDefensive.Size = new System.Drawing.Size(195, 247);
            this.groupDefensive.TabIndex = 38;
            this.groupDefensive.TabStop = false;
            this.groupDefensive.Text = "Defensive";
            // 
            // groupAttribute
            // 
            this.groupAttribute.Controls.Add(this.vit);
            this.groupAttribute.Controls.Add(this.intel);
            this.groupAttribute.Controls.Add(this.HP);
            this.groupAttribute.Controls.Add(this.labelHP);
            this.groupAttribute.Controls.Add(this.labelVit);
            this.groupAttribute.Controls.Add(this.dex);
            this.groupAttribute.Controls.Add(this.labelInt);
            this.groupAttribute.Controls.Add(this.str);
            this.groupAttribute.Controls.Add(this.labelDex);
            this.groupAttribute.Controls.Add(this.labelStr);
            this.groupAttribute.Location = new System.Drawing.Point(12, 265);
            this.groupAttribute.Name = "groupAttribute";
            this.groupAttribute.Size = new System.Drawing.Size(405, 98);
            this.groupAttribute.TabIndex = 39;
            this.groupAttribute.TabStop = false;
            this.groupAttribute.Text = "Attributes";
            // 
            // vit
            // 
            this.vit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vit.FormattingEnabled = true;
            this.vit.Location = new System.Drawing.Point(196, 60);
            this.vit.Name = "vit";
            this.vit.Size = new System.Drawing.Size(49, 21);
            this.vit.TabIndex = 5;
            // 
            // intel
            // 
            this.intel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intel.FormattingEnabled = true;
            this.intel.Location = new System.Drawing.Point(196, 19);
            this.intel.Name = "intel";
            this.intel.Size = new System.Drawing.Size(49, 21);
            this.intel.TabIndex = 3;
            // 
            // HP
            // 
            this.HP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HP.FormattingEnabled = true;
            this.HP.Location = new System.Drawing.Point(324, 19);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(49, 21);
            this.HP.TabIndex = 2;
            // 
            // dex
            // 
            this.dex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dex.FormattingEnabled = true;
            this.dex.Location = new System.Drawing.Point(63, 60);
            this.dex.Name = "dex";
            this.dex.Size = new System.Drawing.Size(49, 21);
            this.dex.TabIndex = 1;
            // 
            // str
            // 
            this.str.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.str.FormattingEnabled = true;
            this.str.Location = new System.Drawing.Point(63, 19);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(49, 21);
            this.str.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 370);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 23);
            this.saveButton.TabIndex = 40;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // discardButton
            // 
            this.discardButton.Location = new System.Drawing.Point(145, 369);
            this.discardButton.Name = "discardButton";
            this.discardButton.Size = new System.Drawing.Size(112, 23);
            this.discardButton.TabIndex = 41;
            this.discardButton.Text = "Discard Changes";
            this.discardButton.UseVisualStyleBackColor = true;
            this.discardButton.Click += new System.EventHandler(this.discardButton_Click);
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 393);
            this.ControlBox = false;
            this.Controls.Add(this.discardButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupAttribute);
            this.Controls.Add(this.groupDefensive);
            this.Controls.Add(this.groupOffensive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EquipmentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.EquipmentForm_Load);
            this.groupOffensive.ResumeLayout(false);
            this.groupOffensive.PerformLayout();
            this.groupDefensive.ResumeLayout(false);
            this.groupDefensive.PerformLayout();
            this.groupAttribute.ResumeLayout(false);
            this.groupAttribute.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelArmor;
        private System.Windows.Forms.Label labelAllRes;
        private System.Windows.Forms.Label labelPhysRes;
        private System.Windows.Forms.Label labelColdRes;
        private System.Windows.Forms.Label labelFireRes;
        private System.Windows.Forms.Label labelLightRes;
        private System.Windows.Forms.Label labelPoiRes;
        private System.Windows.Forms.Label labelCritDmg;
        private System.Windows.Forms.Label labelArcRes;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelStr;
        private System.Windows.Forms.Label labelDex;
        private System.Windows.Forms.Label labelInt;
        private System.Windows.Forms.Label labelVit;
        private System.Windows.Forms.ComboBox armor;
        private System.Windows.Forms.ComboBox allRes;
        private System.Windows.Forms.ComboBox arcRes;
        private System.Windows.Forms.ComboBox poisonRes;
        private System.Windows.Forms.ComboBox lightRes;
        private System.Windows.Forms.ComboBox fireRes;
        private System.Windows.Forms.ComboBox coldRes;
        private System.Windows.Forms.ComboBox physRes;
        private System.Windows.Forms.Label labelMinDmg;
        private System.Windows.Forms.Label labelMaxDmg;
        private System.Windows.Forms.Label labelAPS;
        private System.Windows.Forms.Label labelIAS;
        private System.Windows.Forms.Label labelIDmg;
        private System.Windows.Forms.Label labelCritChance;
        private System.Windows.Forms.Label labelLifeSteal;
        private System.Windows.Forms.ComboBox minDmg;
        private System.Windows.Forms.ComboBox maxDmg;
        private System.Windows.Forms.ComboBox IAS;
        private System.Windows.Forms.ComboBox lifeSteal;
        private System.Windows.Forms.ComboBox increasedDmg;
        private System.Windows.Forms.ComboBox APS;
        private System.Windows.Forms.ComboBox increasedCritChance;
        private System.Windows.Forms.ComboBox increasedCritDmg;
        private System.Windows.Forms.GroupBox groupOffensive;
        private System.Windows.Forms.GroupBox groupDefensive;
        private System.Windows.Forms.GroupBox groupAttribute;
        private System.Windows.Forms.ComboBox vit;
        private System.Windows.Forms.ComboBox intel;
        private System.Windows.Forms.ComboBox HP;
        private System.Windows.Forms.ComboBox dex;
        private System.Windows.Forms.ComboBox str;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button discardButton;
    }
}