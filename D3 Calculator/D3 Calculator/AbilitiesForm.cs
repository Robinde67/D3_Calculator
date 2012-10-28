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
using Stats;

namespace D3_Calculator
{
    public partial class AbilitiesForm : Form
    {
        string selectedClass;
        StatsClass stats;
        //eftersom jag inte orkar göra alla variabler public eller fixa en get property på varenda en av dem, flyttar jag dem från Ability klassen hit och tar bort ability klassen
        //så......många.........variabler!
        #region Barbarian
        //barbarians abilities text, tog mig nästan 3 timmar att färdigställa allt det här
        string bash1_1 = "Brutally smash an enemy for ";
        double bash1dmg = 1.65f;
        string bash1_2 = " damage with a 20% chance to Knockback.";
        string bash2 = "Instead of Knockback, each hit has a 35% chance to Stun the target for 1.5 seconds.";
        string bash3_1 = "Add 2 reverberations that cause ";
        double bash3dmg = 0.25f;
        string bash3_2 = " damage per strike. Removes the chance for Knockback.";
        string bash4 = "Increases the damage of your skills by 6% for 5 seconds after using Bash. This effect stacks up to 3 times.";
        string bash5 = "Generate 6 additional Fury per attack.";
        string bash6_1 = "Cause a shockwave that inflicts ";
        double bash6dmg = 0.38f;
        string bash6_2 = " damage to enemies in a 26 yard line behind the targeted enemy.";

        string hoA1_1 = "Call forth a massive hammer to smash enemies directly in front of you for ";
        double hoA1dmg = 3.25f;
        string hoA1_2 = " damage. Hammer of the Ancients has a 5% increased Critical Hit Chance. ";
        string hoA2_1 = "Create a shockwave that deals ";
        double hoA2dmg = 2.75f;
        string hoA2_2 = " damage to all enemies within 22 yards in front of you.";
        string hoA3_1 = "Strike a smaller area for ";
        double hoA3dmg = 4.06f;
        string hoA3_2 = " damage.";
        string hoA4 = "Create a tremor at the point of impact for 2 seconds that slows the movement speed of enemies by 60%.";
        string hoA5 = "Whenever you kill an enemy with Hammer of the Ancients every other enemy within 10 yards is stunned for 3 seconds.";
        string hoA6 = "Whenever you kill an enemy with Hammer of the Ancients every other enemy within 10 yards is stunned for 3 seconds.";

        string cleave1_1 = "Swing your weapon in a wide arc to deal ";
        double cleave1dmg = 1.40f;
        string cleave1_2 = " weapon damage to all enemies caught in the swing. ";
        string cleave2_1 = "Enemies slain by Cleave explode, causing ";
        double cleave2dmg = 0.85f;
        string cleave2_2 = " weapon damage to all other enemies within 8 yards.";
        string cleave3 = "Generate 3 additional Fury per enemy hit.";
        string cleave4_1 = "On Critical Hits, knock enemies back 9 yards and inflict ";
        double cleave4dmg = 0.60f;
        string cleave4_2 = " weapon damage to enemies where they land.";
        string cleave5_1 = "Increase damage to ";
        double cleave5dmg = 1.75f;
        string cleave5_2 = " weapon damage.";
        string cleave6 = "Enemies cleaved have their movement speed reduced by 80% for 1 second.";

        string stomp1 = "Smash the ground, stunning all enemies within 12 yards for 4 seconds. ";
        string stomp2 = "Enemies in the area have their movement speed slowed by 60% for 3 seconds after they recover from being stunned.";
        string stomp3 = "Increase the area of effect to 24 yards. Enemies are pulled closer before the strike lands.";
        string stomp4_1 = "Enemies in the area also take ";
        double stomp4dmg = 0.76f;
        string stomp4_2 = " damage.";
        string stomp5 = "Increase Fury gained to 30.";
        string stomp6_1 = "Enemies are knocked back 9 yards and inflict ";
        double stomp6dmg = 0.55f;
        string stomp6_2 = "damage to enemies in the landing area.";

        string rend1_1 = "A sweeping strike causes all nearby enemies to Bleed for ";
        double rend1dmg = 7f;
        string rend1_2 = " damage as Physical over 5 seconds. ";
        string rend2 = "Increase the range of Rend to hit all enemies within 17 yards.";
        string rend3 = "Gain 9% of the damage done by Rend as Life.";
        string rend4_1 = "Increase damage to ";
        double rend4dmg = 9.04f;
        string rend4_2 = " damage as Physical over 5 seconds.";
        string rend5 = "Increase bleeding duration to 5 seconds.";
        string rend6_1 = "Enemies killed while bleeding cause all enemies within 10 yards to begin bleeding for ";
        double rend6dmg = 1f;
        string rend6_2 = " damage as Physical over 5 seconds.";

        string leap1_1 = "Leap into the air, dealing ";
        double leap1dmg = 0.85f;
        string leap1_2 = " damage to all enemies within 8 yards of your destination and slowing their movement speed by 60% for 3 seconds. ";
        string leap2_1 = "Gain ";
        double leap2armor = 4f;
        string leap2_2 = " Armor for 4 seconds after landing.";
        string leap3 = "Jump into the air with such great force that enemies within 8 yards of the origin of the jump are also slowed by 60% for 3 seconds.";
        string leap4 = "Send enemies hurtling away from where you land.";
        string leap5 = "Shockwaves burst forth from the ground increasing the radius of effect to 16 yards and pulling affected enemies towards you.";
        string leap6 = "Land with such force that enemies have a 100% chance to be stunned for 3 seconds.";

        string spear1_1 = "Throw a spear to pull an enemy back to you, briefly slowing the target's movement by 60%, rooting them in place for 1.5 seconds and dealing ";
        double spear1dmg = 1.85f;
        string spear1_2 = " damage. ";
        string spear2 = "Throw 3 spears. Each spear will pull back the enemy that it hits.";
        string spear3 = "Increases Fury gained to 30.";
        string spear4 = "Gain Life equal to 60% of the damage inflicted.";
        string spear5 = "Pierce through multiple enemies in a straight line and drag them all back.";
        string spear6_1 = "Enemies hit with Ancient Spear are pulled in the opposite direction and damage is increased to ";
        double spear6dmg = 2.13f;
        string spear6_2 = " damage.";

        string frenzy1_1 = "Swing for ";
        double frenzyDmg = 1.1f;
        string frenzy1_2 = " damage. Frenzy attack speed increases by 15% with each swing. This effect can stack up to 5 times for a total bonus of 75% attack speed. ";
        string frenzy2_1 = "Each strike has a 25% chance to throw a piercing axe at a nearby enemy that deals ";
        string frenzy2_2 = " damage to all enemies in its path.";
        string frenzy3_1 = "Killing an enemy with Frenzy heals you for ";
        double frenzy3HP = 0.08f;
        string frenzy3_2 = "Life over 6 seconds.";
        string frenzy4 = "While under the effects of Frenzy, you gain 15% increased movement speed.";
        string frenzy5 = "Add a 20% chance to call down a bolt of lightning from above, stunning your target for 1.5 seconds.";
        string frenzy6 = "Each Frenzy effect also increases your damage by 4%.";

        string slam1_1 = "Slam the ground and cause a wave of destruction that deals ";
        double slam1dmg = 2.4f;
        string slam1_2 = " damage and Knockback to targets in a 45 yard arc. ";
        string slam2 = "Add a 70% chance of stunning enemies for 1.5 seconds.";
        string slam3_1 = "Increase damage to ";
        double slam3dmg = 2.88f;
        string slam3_2 = " damage and increases Knockback distance by 100%.";
        string slam4_1 = "The ground continues to shudder after the intitial strike, damaging enemies in the area for ";
        double slam4dmg = 0.30f;
        string slam4_2 = " damage.";
        string slam5 = "Reduce Fury cost to 15 Fury.";
        string slam6_1 = "Focus the seismic shockwaves along a narrow path to inflict ";
        double slam6dmg = 3.4f;
        string slam6_2 = " damage to targets along a 42 yard path.";

        string revenge1_1 = "Inflict ";
        double revenge1dmg = 2.2f;
        double revenge1HP = 0.05f;
        string revenge1_2 = " damage to all nearby enemies. You heal ";
        string revenge1_3 = " Life for each enemy hit. ";
        string revenge2_1 = "Gain 5 Fury and heal for ";
        double revenge2HP = 0.08f;
        string revenge2_2 = " Life for each enemy hit.";
        string revenge3 = "After using Revenge, your Critical Hit Chance is increased by 10% for 12 seconds.";
        string revenge4_1 = "Increase damage to ";
        double revenge4dmg = 2.86f;
        string revenge4_2 = " damage.";
        string revenge5 = "Knocks enemies back 24 yards whenever Revenge is used.";
        string revenge6 = "Increases the chance Revenge will become active to 30% each time you are hit by an attack.";

        string weaponThrow1_1 = "Hurl a throwing weapon at an enemy for ";
        double weaponThrow1dmg = 1.3f;
        string weaponThrow1_2 = " damage and Slow the movement of the enemy by 60% for 1.5 seconds. ";
        string weaponThrow2_1 = "Increase thrown weapon damage to ";
        double weaponThrow2dmg = 1.69f;
        string weaponThrow2_2 = " damage.";
        string weaponThrow3 = "Cause the weapon to ricochet and hit up to 3 targets within 20 yards of each other.";
        string weaponThrow4 = "Hurl a hammer with a 50% chance to Stun the target for 2 seconds.";
        string weaponThrow5 = "Aim for the head, gaining a 20% chance of causing your target to be Confused and attack other enemies for 6 seconds.";
        string weaponThrow6_1 = "Expend all remaining Fury to throw a corpse which inflicts an additional ";
        double weaponThrow6dmg = 0.03f;
        string weaponThrow6_2 = " damage for each point of Fury expended to all enemies within 12 yards of the target.";

        string sprint1 = "Increase movement speed by 40% for 3 seconds. ";
        string sprint2 = "Increases Dodge Chance by 12% while sprinting.";
        string sprint3_1 = "Tornadoes rage in your wake, each one inflicting ";
        double sprint3dmg = 0.60f;
        string sprint3_2 = " damage.";
        string sprint4 = "Increases the movement speed bonus to 50% for 5 seconds.";
        string sprint5_1 = "Slams through enemies, knocking them back and inflicting ";
        double sprint5dmg = 0.25f;
        string sprint5_2 = " damage.";
        string sprint6 = "Increase the movement speed of allies within 50 yards by 20% for 3 seconds.";

        string shout1 = "Shout with great ferocity, reducing damage done by enemies within 25 yards by 20% for 15 seconds. ";
        string shout2 = "Affected enemies also have their movement speed reduced by 30%.";
        string shout3 = "Affected enemies also have their attack speed reduced by 15% for 5 seconds.";
        string shout4 = "Enemies are badly shaken and have a 15% chance to drop additional treasure.";
        string shout5 = "Affected enemies are also taunted to attack you for 3 seconds.";
        string shout6 = "Enemies are severely demoralized. Each enemy has a 35% chance to flee for 2.5 seconds.";

        string earthquake1_1 = "Shake the ground violently, dealing ";
        double earthquake1dmg = 20f;
        string earthquake1_2 = " damage as Fire over 8 seconds to all enemies within 18 yards. ";
        string earthquake2_1 = "Secondary tremors follow your movement and inflict ";
        double earthquake2dmg = 0.65f;
        string earthquake2_2 = "2 damage as Fire.";
        string earthquake3 = "Creates an icy patch, causing Earthquake's damage to turn Cold and Slow the movement of enemies by 80%.";
        string earthquake4 = "Removes the Fury cost and reduces the cooldown to 105 seconds.";
        string earthquake5_1 = "Secondary tremors knock enemies back and inflict ";
        double earthquake5dmg = 0.65f;
        string earthquake5_2 = " damage as Fire.";
        string earthquake6_1 = "Project secondary tremors up to 12 yards ahead of you that inflict ";
        double earthquake6dmg = 0.65f;
        string earthquake6_2 = " damage as Fire.";

        string whirlwind1_1 = "Deliver multiple attacks to everything in your path for ";
        double whirlwind1dmg = 1.45f;
        string whirlwind1_2 = " damage. ";
        string whirlwind2_1 = "Generate harsh tornadoes that inflict";
        double whirlwind2dmg = 0.40f;
        string whirlwind2_2 = " damage to enemies in their path.";
        string whirlwind3 = "Allows you to move at your movement speed while using Whirlwind.";
        string whirlwind4_1 = "Critical Hits restore ";
        double whirlwind4HP = 0.01f;
        string whirlwind4_2 = " Life.";
        string whirlwind5 = "Gain 1 Fury for every enemy struck.";
        string whirlwind6_1 = "Turns Whirlwind into a torrent of magma that inflicts ";
        double whirlwind6dmg = 1.88f;
        string whirlwind6_2 = " damage as Fire.";

        string charge1_1 = "Rush forward knocking back enemies and inflicting ";
        double charge1dmg = 1.95f;
        string charge1_2 = " damage to enemies along the path of the charge. ";
        string charge2_1 = "Increase damage at the destination to ";
        double charge2dmg = 2.83f;
        string charge2_2 = " damage.";
        string charge3 = "Cooldown is reduced by 2 seconds for every target hit. This effect can reduce the cooldown by up to 10 seconds.";
        string charge4 = "Generate 8 additional Fury for each target hit while charging.";
        string charge5 = "Any targets who are critically hit by Furious Charge will be stunned for 2.5 seconds.";
        string charge6_1 = "Regain ";
        double charge6dmg = 0.08f;
        string charge6_2 = " Life for each target hit by Furious Charge.";

        string rage1 = "Enter a rage which increases damage by 15% and Critical Hit Chance by 3% for 30 seconds. ";
        string rage2 = "Increase damage bonus to 30%";
        string rage3 = "While under the effects of Battle Rage, Critical Hits have a chance to increase the duration of Battle Rage by 2 seconds.";
        string rage4 = "While under the effects of Battle Rage, Critical Hits have up to a 5% chance to cause enemies to drop additional health globes.";
        string rage5 = "While under the effects of Battle Rage, Critical Hits have a chance to generate 15 additional Fury.";
        string rage6 = "While under the effects of Battle Rage, Critical Hits have a chance to cause an explosion of blood dealing 20% of the damage done to all other nearby enemies.";

        string ignorePain1 = "Reduces all damage taken by 65% for 5 seconds. ";
        string ignorePain2_1 = "When activated, Knockback all enemies within 12 yards and deal ";
        double ignorePain2dmg = 0.5f;
        string ignorePain2_2 = " damage to them.";
        string ignorePain3 = "Increases duration to 7 seconds.";
        string ignorePain4 = "While Ignore Pain is active, gain 20% of all damage dealt as Life.";
        string ignorePain5 = "Extend the effect to nearby allies, reducing damage taken by 65% for 5 seconds.";
        string ignorePain6_1 = "Reflects 50% of ignored damage back at the enemy. Reflected damage cannot exceed ";
        string ignorePain6_2 = ".";

        string ancients1_1 = "Summon the ancient Barbarians Talic, Korlic, and Madawc to fight alongside you for 15 seconds. Each deals ";
        double ancients1dmg = 0.6f;
        string ancients1_2 = " damage per swing in addition to bonus abilities.\nTalic uses the Whirlwind skill.\nKorlic uses the Cleave skill.\nMadawc uses the Weapon Throw skill.";
        string ancients2_1 = "The Ancients inflict ";
        double ancients2dmg = 0.66f;
        string ancients2_2 = " damage with each attack and have 100% additional Armor.";
        string ancients3 = "Increase duration to 20 seconds.";
        string ancients4_1 = "Korlic gains the skill Furious Charge which deals ";
        double ancients4dmg = 2f;
        string ancients4_2 = " damage to all enemies in a line.";
        string ancients5_1 = "Madawc gains the skill Seismic Slam which deals ";
        double ancients5dmg = 1.8f;
        string ancients5_2 = " damage to enemies in an arc.";
        string ancients6_1 = "Talic gains the skill Leap which deals ";
        double ancients6dmg = 2.5f;
        string ancients6_2 = " damage to enemies in the area of the leap.";

        string overpower1_1 = "Deal ";
        double overpower1dmg = 1.65f;
        string overpower1_2 = " damage to all targets within 9 yards. Landing a Critical Hit has a chance to lower the cooldown by 1 second. ";
        string overpower2_1 = "Throw up to 3 axes at nearby enemies which inflict ";
        double overpower2dmg = 0.5f;
        string overpower2_2 = " damage each.";
        string overpower3 = "Your Critical Hit Chance is increased by 10% for 6 seconds.";
        string overpower4_1 = "Reflect 30% of incoming melee damage for 4 seconds after Overpower is activated. Reflected damage cannot exceed ";
        string overpower4_2 = ".";
        string overpower5 = "Generate 12 Fury for each enemy hit by Overpower.";
        string overpower6_1 = "Heal ";
        double overpower6HP = 0.08f;
        string overpower6_2 = " Life for every enemy hit.";

        string warCry1 = "Unleash a rallying cry to increase Armor for you and all allies within 50 yards by 20% for 60 seconds. ";
        string warCry2 = "Increases the Armor bonus to 40%.";
        string warCry3 = "Increases Fury gained to 60.";
        string warCry4 = "Increases maximum Life by 10% and regenerates 310 Life per second while affected by War Cry.";
        string warCry5 = "War Cry also grants a 15% bonus to Dodge Chance.";
        string warCry6 = "All of your resistances are increased by 50% while affected by War Cry.";

        string wrath1 = "Enter a berserker rage which raises several attributes for 15 seconds.\nCritical Hit Chance: 10%\nAttack Speed: 25%\nDodge Chance: 20%\nMovement Speed: 20%";
        string wrath2_1 = "Activating Wrath of the Berserker knocks back all enemies within 12 yards and deals ";
        double wrath2dmg = 4.3f;
        string wrath2_2 = " damage to them.";
        string wrath3 = "While active your damage is also increased by 100%.";
        string wrath4_1 = "While Wrath of the Berserker is active, Critical Hits have a chance to cause an eruption of blood dealing ";
        double wrath4dmg = 1.55f;
        string wrath4_2 = " damage to enemies within 15 yards.";
        string wrath5 = "Increases bonus to Dodge Chance to 60%.";
        string wrath6 = "Every 25 Fury gained while Wrath of the Berserker is active adds 1 second to the duration of the effect.";
        #endregion
        #region Demon Hunter
        //Jag fick hjälp med den här som med Monk
        //tog bara en knapp halvtimma att dela upp alla eftersom han redan delat upp alla som hade "x% weapon damage" så jag bara behövde dela upp och fixa doubles
        string hungeringArrow1_1 = "Fire a magically imbued arrow that seeks out targets for ";
        double hungeringArrow1dmg = 1.15f;
        string hungeringArrow1_2 = " damage and has a 35% chance to pierce through targets.";
        string hungeringArrow2 = "Increase the chance for the arrow to pierce to 50%.";
        string hungeringArrow3_1 = "Light the arrow on fire, dealing ";
        double hungeringArrow3dmg = 0.35f;
        string hungeringArrow3_2 = " additional damage as Fire over 3 seconds.";
        string hungeringArrow4 = "If the arrow successfully pierces the first target, the arrow splits into 3 arrows.";
        string hungeringArrow5 = "Each consecutive pierce increases the damage of the arrow by 70%.";
        string hungeringArrow6_1 = "Successful Critical Hits cause a burst of bone to explode from the target, dealing ";
        double hungeringArrow6dmg = 0.5f;
        string hungeringArrow6_2 = " damage to enemies in that area.";

        string impale1_1 = "Impale a target for ";
        double impale1dmg = 2.65f;
        string impale1_2 = " damage.";
        string impale2 = "Impale has a 65% chance to knock the target back and Stun it for 1.5 seconds.";
        string impale3_1 = "Your target will also Bleed for ";
        double impale3dmg = 2.2f;
        string impale3_2 = " damage as Physical over 2 seconds.";
        string impale4 = "The knife will pierce through all enemies in a straight line.";
        string impale5_1 = "After the initial throw, release multiple blades centered on you, dealing ";
        double impale5dmg = 0.75f;
        string impale5_2 = " damage to all enemies within 10 yards.";
        string impale6 = "Critical Hits cause 100% additional damage.";

        string entanglingShot1_1 = "Imbue an arrow with shadow energy that deals ";
        double entanglingShot1dmg = 0.75f;
        string entanglingShot1_2 = " damage and entangles up to 2 enemies, slowing their movement by 60% for 2 seconds.";
        string entanglingShot2 = "Hit up to 4 targets.";
        string entanglingShot3_1 = "Strike targets with electrified chains that do an additional ";
        double entanglingShot3dmg = 0.18f;
        string entanglingShot3_2 = " damage per second as Lightning for 2 seconds.";
        string entanglingShot4 = "Increase the movement slow duration to 4 seconds.";
        string entanglingShot5 = "Increase the Hatred generated to 6 per shot.";
        string entanglingShot6 = "Gain 6% of the damage dealt as Life.";

        string caltrops1 = "Lay a trap of caltrops on the ground that activates when an enemy approaches. Once sprung, the caltrops Slow the movement of enemies within 12 yards by 60%. This trap lasts 6 seconds.";
        string caltrops2 = "Increase the slowing amount to 80%.";
        string caltrops3 = "When the trap is sprung, all enemies in the area are immobilized for 2 seconds.";
        string caltrops4_1 = "Enemies in the area also take ";
        double caltrops4dmg = 0.45f;
        string caltrops4_2 = " damage.";
        string caltrops5 = "Reduces the cost of Caltrops to 4 Discipline.";
        string caltrops6 = "Become empowered while standing in the area of effect, gaining an additional 10% Critical Hit Chance with all attacks.";

        string rapidFire1_1 = "Rapidly fire for ";
        double rapidFire1dmg = 2.76f;
        string rapidFire1_2 = " damage as Physical.";
        string rapidFire2 = "Reduces the initial Hatred cost to 5, and ignites your arrows, causing them to deal Fire damage.";
        string rapidFire3 = "Slows the movement of affected targets by 80% for 1 second.";
        string rapidFire4_1 = "While channeling Rapid Fire, launch 3 homing rockets every second. Each rocket deals ";
        double rapidFire4dmg = 0.35f;
        string rapidFire4_2 = " damage as Physical to nearby targets.";
        string rapidFire5 = "Fire poison arrows that have a 40% chance to pierce through enemies.";
        string rapidFire6_1 = "Rapidly fire grenades that explode for ";
        double rapidFire6dmg = 3.45f;
        string rapidFire6_2 = " damage as Fire to all enemies within a 4 yard radius.";

        string smokeScreen1 = "Vanish behind a wall of smoke, becoming momentarily invisible for 1 seconds.";
        string smokeScreen2 = "Gain 35% movement speed when activated.";
        string smokeScreen3 = "Increase the duration of the effect to 1.5 seconds.";
        string smokeScreen4 = "While invisible you gain 12 Hatred per second.";
        string smokeScreen5 = "Reduce the cost to 12 Discipline.";
        string smokeScreen6_1 = "Leave behind a cloud of gas that deals ";
        double smokeScreen6dmg = 7f;
        string smokeScreen6_2 = " damage as Physical to enemies in the area over 5 seconds.";

        string vault1 = "Tumble acrobatically 35 yards.";
        string vault2_1 = "As you travel, shoot arrows for ";
        double vault2dmg = 0.75f;
        string vault2_2 = " damage at nearby targets.";
        string vault3 = "All enemies within 8 yards of your destination are knocked back and stunned for 1.5 seconds.";
        string vault4 = "After using Vault, your next Vault within 6 seconds has its Discipline cost reduced by 50%.";
        string vault5 = "Removes the Discipline cost but adds a 15 second cooldown.";
        string vault6_1 = "Ignite with fire dealing ";
        double vault6dmg = 15f;
        string vault6_2 = " damage over 3 seconds as Fire to everything along your path.";

        string bolaShot1_1 = "Shoot out an explosive bola that wraps itself around its target. After 1 second, the bola explodes dealing ";
        double bolaShot1dmg1 = 1.6f;
        string bolaShot1_2 = " damage as Fire to the target and an additional ";
        double bolaShot1dmg2 = 1.1f;
        string bolaShot1_3 = " damage as Fire to all other targets within 7 yards.";
        string bolaShot2 = "Increase the explosion radius to 14 yards.";
        string bolaShot3_1 = "When the bola explodes, it deals ";
        double bolaShot3dmg = 1.6f;
        string bolaShot3_2 = " damage as Lightning and has a 35% chance to Stun the primary target for 1.5 seconds.";
        string bolaShot4_1 = "Shoot 3 bolas that each deal ";
        double bolaShot4dmg = 1.6f;
        string bolaShot4_2 = " damage as Poison. The bolas no longer explode for area damage to nearby targets.";
        string bolaShot5 = "When the bola explodes, you have a 15% chance to gain 2 Discipline.";
        string bolaShot6_1 = "Augment the bola to deal ";
        double bolaShot6dmg1 = 2.16f;
        string bolaShot6_2 = " damage as Arcane to the target and ";
        double bolaShot6dmg2 = 1.54f;
        string bolaShot6_3 = " damage as Arcane to all other targets within 7 yards, but increases the explosion delay to 2 seconds.";

        string chakram1_1 = "Fire a swirling Chakram that does ";
        double chakram1dmg = 1.7f;
        string chakram1_2 = " damage as Physical to enemies along its path.";
        string chakram2_1 = "A second Chakram mirrors the first. Each Chakram deals ";
        double chakram2dmg = 1.14f;
        string chakram2_2 = " damage as Physical.";
        string chakram3_1 = "The Chakram follows a slow curve, dealing ";
        double chakram3dmg = 2.3f;
        string chakram3_2 = " damage as Poison to enemies along the path.";
        string chakram4_1 = "The Chakram spirals out from the targeted location dealing ";
        double chakram4dmg = 1.87f;
        string chakram4_2 = " damage as Arcane to enemies along the path.";
        string chakram5_1 = "The Chakram path turns into a loop, dealing ";
        double chakram5dmg = 2.3f;
        string chakram5_2 = " damage as Lightning to enemies along the path.";
        string chakram6_1 = "Surround yourself with spinning Chakrams for 120 seconds, dealing ";
        double chakram6dmg = 0.34f;
        string chakram6_2 = " damage per second as Physical to nearby enemies.";

        string preparation1 = "Instantly restore all Discipline.";
        string preparation2 = "Increase maximum Discipline by 10 for 5 seconds when using Preparation.";
        string preparation3 = "Restore all Hatred for 25 Discipline. Preparation has no cooldown.";
        //osäker på om den menar att den helar 60% av max HP, eller om den ger 60% av nuvarande HP, låter det stå kvar som det är.
        string preparation4 = "Gain 60% Life after using Preparation.";
        string preparation5 = "Gain 45 Discipline over 15 seconds instead of restoring it immediately.";
        string preparation6 = "There is a 30% chance that Preparation's cooldown will not be triggered.";

        string evasiveFire1_1 = "Shoot for ";
        double evasiveFire1dmg = 1.3f;
        string evasiveFire1_2 = " damage. If an enemy is in front of you at close range, you will also backflip away 15 yards.";
        string evasiveFire2_1 = "Shoot exploding bolts that also deal ";
        double evasiveFire2dmg = 0.3f;
        string evasiveFire2_2 = " damage as Fire to all enemies within 6 yards of the primary target.";
        string evasiveFire3_1 = "Whenever a backflip is triggered, leave a poison bomb behind that explodes for ";
        double evasiveFire3dmg = 0.45f;
        string evasiveFire3_2 = " damage as Poison in a 12 yard radius after 1.2 seconds. Turns Evasive Fire into Poison damage.";
        string evasiveFire4_1 = "Shoot a spread of bolts that hit up to 3 targets for ";
        double evasiveFire4dmg = 1.3f;
        string evasiveFire4_2 = " damage each.";
        string evasiveFire5 = "Increase the distance of the backflip to 30 yards.";
        string evasiveFire6 = "Reduces the cost of the backflip to 2 Discipline. Turns Evasive Fire into Lightning damage.";

        string grenades1_1 = "Throw out three grenades that explode for ";
        double grenades1dmg = 0.95f;
        string grenades1_2 = " damage as Fire each.";
        string grenades2 = "Increases Hatred generation to 6 Hatred.";
        string grenades3_1 = "Throw cluster grenades that deal ";
        double grenades3dmg = 1.12f;
        string grenades3_2 = " damage as Fire over an 8 yard radius.";
        string grenades4_1 = "Throw a single grenade that deals ";
        double grenades4dmg = 1.24f;
        string grenades4_2 = " damage as Fire.";
        string grenades5 = "Hurl grenades that have a 25% chance to Stun enemies for 1.5 seconds.";
        string grenades6_1 = "Throw gas grenades that explode for ";
        double grenades6dmg1 = 0.95f;
        string grenades6_2 = " damage as Poison and leave a cloud that deals an additional ";
        double grenades6dmg2 = 0.25f;
        string grenades6_3 = " damage per second as Poison for 3 seconds to enemies who stand in the area.";

        string shadowPower1 = "Draw in the power of the shadows, gaining 20% of all damage done as Life for 3 seconds.";
        string shadowPower2 = "Gain an additional 4 Hatred per second while Shadow Power is active.";
        string shadowPower3 = "Increases damage done as Life to 30%.";
        string shadowPower4 = "Decreases the Discipline cost to 12.";
        string shadowPower5 = "Reduce incoming damage by 65% while Shadow Power is active.";
        string shadowPower6 = "Gain 40% bonus to movement speed while Shadow Power is active.";

        string companion1_1 = "Summon a raven companion. Your raven companion will periodically peck at enemies for ";
        double companion1dmg = 0.3f;
        string companion1_2 = " damage as Physical.";
        string companion2 = "Summon a spider instead of a raven. The spider's attacks also Slow the movement of enemies by 60% for 2 seconds.";
        string companion3 = "Summon a bat instead of a raven. The bat grants you 3 Hatred per second.";
        string companion4 = "Summon a boar instead of a raven. The boar's attacks hit all enemies in an area.";
        string companion5 = "Summon ferrets instead of a raven. The ferrets collect gold for you and increase gold found on monsters by 10%.";
        string companion6_1 = "Summon a wolf for 25 seconds instead of a raven. The wolf attacks for ";
        double companion6dmg = 0.6f;
        string companion6_2 = " damage as Physical.";

        string fanOfKnives1_1 = "Throw knives out in a spiral around you, doing ";
        double fanOfKnives1dmg = 3.2f;
        string fanOfKnives1_2 = " damage to all enemies within 10 yards of you. Your knives will also Slow the movement of enemies by 60% for 2 seconds.";
        string fanOfKnives2 = "Increase the amount enemies are slowed to 80% for 2 seconds.";
        string fanOfKnives3_1 = "Surround yourself with whirling blades that deal ";
        double fanOfKnives3dmg = 4.64f;
        string fanOfKnives3_2 = " damage to all enemies if you are struck in the next 10 seconds.";
        string fanOfKnives4 = "Increase the radius to damage all enemies within 20 yards.";
        string fanOfKnives5 = "Imbue your knives with a 65% chance to Stun enemies for 2 seconds.";
        string fanOfKnives6_1 = "Throw long-range knives that deal ";
        double fanOfKnives6dmg = 0.7f;
        string fanOfKnives6_2 = " damage to 5 additional targets.";

        string spikeTrap1_1 = "Lay a trap that arms after 1.2 seconds and triggers when an enemy approaches. The trap does ";
        double spikeTrap1dmg = 2.75f;
        string spikeTrap1_2 = " damage to all enemies within 8 yards. You can have a maximum of 3 Spike Traps active at one time.";
        string spikeTrap2 = "Increase the maximum number of traps that can be out simultaneously to 6.";
        string spikeTrap3_1 = "Plant a bomb on an enemy rather than on the ground. If the target dies within 30 seconds, the bomb explodes dealing ";
        double spikeTrap3dmg = 4.04f;
        string spikeTrap3_2 = " damage to all enemies within 8 yards.";
        string spikeTrap4_1 = "Increases the arming time to 2 seconds but increases damage to ";
        double spikeTrap4dmg = 3.71f;
        string spikeTrap4_2 = " damage.";
        string spikeTrap5_1 = "When the trap is triggered it releases a pulse of lightning that will bounce to up to 3 enemies for ";
        double spikeTrap5dmg = 2.75f;
        string spikeTrap5_2 = " damage as Lightning.";
        string spikeTrap6 = "Simultaneously place all 3 traps.";

        string strafe1_1 = "Shoot at random nearby enemies for ";
        double strafe1dmg = 1.56f;
        string strafe1_2 = " damage while moving at 65% of normal movement speed.";
        string strafe2 = "Increases your attack speed by 20% when using Strafe.";
        string strafe3 = "Movement speed increased to 100% of normal running speed while strafing.";
        string strafe4 = "Throw out knives rather than arrows that do an extra 100% damage on successful Critical Hits.";
        string strafe5_1 = "In addition to regular firing, fire off homing rockets for ";
        double strafe5dmg = 0.6f;
        string strafe5_2 = " damage as Fire.";
        string strafe6_1 = "Throw out bouncy grenades that explode for ";
        double strafe6dmg = 1.87f;
        string strafe6_2 = " damage to targets within 9 yards.";

        string elementalArrow1_1 = "Shoot a fire arrow that deals ";
        double elementalArrow1dmg = 1.55f;
        string elementalArrow1_2 = " damage as Fire to all targets it passes through.";
        string elementalArrow2_1 = "Fire a slow-moving arrow that electrocutes enemies along its path for ";
        double elementalArrow2dmg = 1.55f;
        string elementalArrow2_2 = " damage as Lightning.";
        string elementalArrow3_1 = "Fire a frost arrow that splits into multiple arrows after hitting its target, dealing ";
        double elementalArrow3dmg = 1.7f;
        string elementalArrow3_2 = " damage as Cold. Affected enemies have their movement speed slowed by 60% for 1 second.";
        string elementalArrow4 = "Grants a 40% chance to shoot a skull that will Fear affected enemies for 1.5 seconds.";
        string elementalArrow5 = "Fire electrified bolts that Stun enemies for 1.5 seconds on a Critical Hit.";
        string elementalArrow6_1 = "Shadow tentacles deal ";
        double elementalArrow6dmg = 1.55f;
        string elementalArrow6_2 = " damage to enemies along its path and return 3% of damage dealt as Life for you.";

        string markedForDeath1 = "Marks an enemy. The marked enemy will take 12% additional damage for the next 30 seconds.";
        string markedForDeath2 = "When the target is killed, the ability spreads to 2 other nearby targets. This effect can chain repeatedly.";
        string markedForDeath3 = "Mark an area on the ground 12 yards wide for 15 seconds. Enemies in the area take 12% additional damage.";
        string markedForDeath4 = "An additional 12% of damage done to the target is also divided among all enemies within 20 yards.";
        string markedForDeath5 = "Attacks you make against the marked target generate 3 Hatred.";
        string markedForDeath6 = "Heal attackers for 1% of the damage done to the marked target.";

        string multishot1_1 = "Fire a massive volley of arrows dealing ";
        double multishot1dmg = 1.65f;
        string multishot1_2 = " damage to all enemies in the area.";
        string multishot2_1 = "Cost reduced to 15 Hatred. Deals ";
        double multishot2dmg = 1.65f;
        string multishot2_2 = " damage as Lightning.";
        string multishot3_1 = "Every time you fire, generate a shock pulse that damages nearby enemies for ";
        double multishot3dmg = 0.65f;
        string multishot3_2 = " damage as Arcane.";
        string multishot4 = "Every enemy hit grants 1 Discipline.";
        string multishot5_1 = "Increase the damage of Multishot to ";
        double multishot5dmg = 2.15f;
        string multishot5_2 = " damage.";
        string multishot6_1 = "Every use also fires 3 rockets at nearby enemies that deal ";
        double multishot6dmg = 0.6f;
        string multishot6_2 = " damage as Fire each.";

        string sentry1_1 = "Drop a turret on the ground. The turret begins firing at nearby enemies for ";
        double sentry1dmg = 0.55f;
        string sentry1_2 = " damage. Lasts 30 seconds.";
        string sentry2_1 = "The turret will also fire homing rockets aimed at random nearby targets for ";
        double sentry2dmg = 0.08f;
        string sentry2_2 = " damage as Fire.";
        string sentry3 = "Increases duration of the turret to 40 seconds.";
        string sentry4_1 = "Create a tether between you and the Sentry that does ";
        double sentry4dmg = 0.8f;
        string sentry4_2 = " damage every second to every enemy it touches.";
        string sentry5 = "Heals nearby allies for 1% of their maximum Life per second.";
        string sentry6 = "The turret also creates a shield that reduces damage taken by allies by 15%.";

        string clusterArrow1_1 = "Fire a cluster arrow that explodes for ";
        double clusterArrow1dmg1 = 2.25f;
        string clusterArrow1_2 = " damage as Fire into a series of additional miniature bombs that explode for ";
        double clusterArrow1dmg2 = 1f;
        string clusterArrow1_3 = " damage as Fire each.";
        string clusterArrow2 = "Enemies hit by grenades have a 55% chance to be stunned for 2 seconds and changes the damage to Physical.";
        string clusterArrow3_1 = "Instead of releasing grenades, shoots up to 3 rockets at nearby enemies dealing ";
        double clusterArrow3dmg = 1.75f;
        string clusterArrow3_2 = " damage as Physical each.";
        string clusterArrow4_1 = "Instead of releasing grenades, the cluster releases shadow energy that deals ";
        double clusterArrow4dmg = 1.65f;
        string clusterArrow4_2 = " damage as Physical to nearby enemies. You will gain 4% of the damage done as Life.";
        string clusterArrow5_1 = "Launch the cluster through the air, dropping bombs in a straight line that each explode for ";
        double clusterArrow5dmg = 2.3f;
        string clusterArrow5_2 = " damage as Fire.";
        string clusterArrow6_1 = "Increases the damage of the explosion at the impact location to ";
        double clusterArrow6dmg = 3.04f;
        string clusterArrow6_2 = " damage as Fire.";

        string rainOfVengeance1_1 = "Fire a massive volley of arrows around you. Arrows fall from the sky dealing ";
        double rainOfVengeance1dmg = 7.15f;
        string rainOfVengeance1_2 = " damage over 12 seconds to all enemies in the area.";
        string rainOfVengeance2_1 = "Launch a massive volley of guided arrows that rain down on enemies for ";
        double rainOfVengeance2dmg = 7.92;
        string rainOfVengeance2_2 = " damage over 12 seconds.";
        string rainOfVengeance3_1 = "Summon 20 Shadow Beasts to drop bombs on enemies, dealing ";
        double rainOfVengeance3dmg = 2.45f;
        string rainOfVengeance3_2 = " damage each.";
        string rainOfVengeance4_1 = "Summon a wave of 10 Shadow Beasts to tear across the ground, knocking back enemies and dealing ";
        double rainOfVengeance4dmg = 1.2f;
        string rainOfVengeance4_2 = " damage each.";
        string rainOfVengeance5_1 = "Summon a Shadow Beast that drops grenades from the sky over 15 seconds dealing ";
        double rainOfVengeance5dmg = 33f;
        string rainOfVengeance5_2 = " damage.";
        string rainOfVengeance6_1 = "A group of 8 Shadow Beasts plummet from the sky at a targeted location dealing ";
        double rainOfVengeance6dmg = 1f;
        string rainOfVengeance6_2 = " damage each and stunning enemies for 2 seconds.";

        //en till easter egg ;)
        string theBigBangTheory1 = "Sheldon harasses you about your science skills for 10 minutes.";
        string theBigBangTheory2 = "Raj talkes to you for 5 minutes making you really uncomfortable. Unless of course there's a female near, in which case he will stay silent.";
        string theBigBangTheory3 = "Penny want you to go get her TV from her old boyfriend. You return an hour later without any pants.";
        string theBigBangTheory4 = "Leonard needs his asthma medicine. You have to get it at his apartment.";
        string theBigBangTheory5 = "Howard accidently fires a model rocket at you. Run. Now.";
        string theBigBangTheory6 = "Sheldon accidently pisses of a judge and is put in jail. You need to get him out before sundown.";
        #endregion
        #region Monk
        //fick hjälp att fixa med texten på dessa, han lämna mig en easter egg på slutet också, måste fortfarande dela på texten
        //men underlättar att inte behöva tabba upp och ner för att klistra in texten
        string fistsOfThunder1_1 = "Unleash a series of extremely fast punches that deal ";
        double fistsOfThunder1dmg = 1.1f;
        string fistsOfThunder1_2 = " damage as Lightning. Every third hit deals damage to all enemies in front of you and knocks them back a short distance.";
        string fistsOfThunder2_1 = "Teleport to the target and release an electric shockwave with every punch that hits all enemies within 6 yards of your primary target for ";
        double fistsOfThunder2dmg = 0.35f;
        string fistsOfThunder2_2 = " damage as Lightning.";
        string fistsOfThunder3 = "Increases your chance to Dodge by 16% for 2 seconds.";
        string fistsOfThunder4_1 = "Your primary target is charged with static electricity for 5 seconds and takes ";
        double fistsOfThunder4dmg = 0.37f;
        string fistsOfThunder4_2 = " damage as Lightning when you attack other enemies with Fists of Thunder.";
        string fistsOfThunder5 = "Critical Hits generate an additional 15 Spirit.";
        string fistsOfThunder6_1 = "Every third punch releases chain lightning instead of knocking enemies back. Each lightning strike inflicts ";
        double fistsOfThunder6dmg = 0.73f;
        string fistsOfThunder6_2 = " damage as Lightning.";

        string lashingTailKick1_1 = "Unleash a deadly roundhouse kick that knocks enemies back and deals ";
        double lashingTailKick1dmg = 2.35f;
        string lashingTailKick1_2 = " damage.";
        string lashingTailKick2_1 = "Release a torrent of fire that burns nearby enemies for ";
        double lashingTailKick2dmg = 2.58f;
        string lashingTailKick2_2 = " damage as Fire and causes Knockback.";
        string lashingTailKick3 = "Increases Knockback distance by 150% and slows the movement speed of struck enemies by 60% for 2 seconds.";
        string lashingTailKick4_1 = "Hurl a column of fire that burns through enemies, causing ";
        double lashingTailKick4dmg = 2.94f;
        string lashingTailKick4_2 = " damage as Fire and causes Knockback.";
        string lashingTailKick5 = "Enemies have a 50% chance to be stunned for 1.5 seconds instead of being knocked back.";
        string lashingTailKick6 = "Attack enemies at long range, slowing the movement speed of affected targets by 80% for 2 seconds.";

        string deadlyReach1_1 = "Project lines of pure force over a short distance for ";
        double deadlyReach1dmg = 1.1f;
        string deadlyReach1_2 = " damage. Every third hit extends 25 yards.";
        string deadlyReach2 = "Increases the area of effect of the second and third strikes.";
        string deadlyReach3 = "The third strike increases your Armor by 50% for 4 seconds.";
        string deadlyReach4_1 = "The third strike is replaced with an attack that will hit up to 6 nearby enemies within 15 yards for ";
        double deadlyReach4dmg = 1.7f;
        string deadlyReach4_2 = " damage as Lightning.";
        string deadlyReach5 = "Critical Hits generate an additional 10 Spirit.";
        string deadlyReach6 = "The third strike increases the damage of all attacks by 18% for 30 seconds.";

        string blindingFlash1 = "Create a flash of light that blinds all enemies within 20 yards for 3 seconds. Elite enemies recover faster, but suffer a 30% chance to miss with attacks.";
        string blindingFlash2 = "Increases the duration enemies are blinded to 4 seconds.";
        string blindingFlash3 = "Blinded enemies have a 25% chance to attack each other.";
        string blindingFlash4 = "6 seconds after using Blinding Flash, a second flash of light will blind enemies within 20 yards for 0.5 seconds.";
        string blindingFlash5 = "Increases the chance elite enemies will miss attacks to 60%.";
        string blindingFlash6_1 = "For 3 seconds after using Blinding Flash, all of your attacks are empowered to deal ";
        double blindingFlash6dmg = 0.3f;
        string blindingFlash6_2 = " additional damage as Holy.";

        string tempestRush1_1 = "Charge directly through your enemies, knocking them back and hobbling them, slowing their movement by 60% for 2 seconds. Also deals ";
        double tempestRush1dmg = 0.5f;
        string tempestRush1_2 = " damage while running.";
        string tempestRush2 = "Reduces the channeling cost of Tempest Rush to 8 Spirit.";
        string tempestRush3 = "Increases the movement speed of Tempest Rush by 25%.";
        string tempestRush4 = "Increases the potency of the hobbling effect, slowing enemy movement by 80%.";
        string tempestRush5 = "Reduces damage taken while running by 25%.";
        string tempestRush6 = "Enemies knocked back have their damage reduced by 20% for the duration of the effect.";

        string breathOfHeaven1 = "A blast of divine energy heals you and all allies within 12 yards for 6202 - 7442 Life.";
        string breathOfHeaven2_1 = "Breath of Heaven also sears enemies for ";
        double breathOfHeaven2dmg = 0.8f;
        string breathOfHeaven2_2 = " damage as Holy.";
        string breathOfHeaven3 = "Increases the healing power of Breath of Heaven to 8063 - 9675 Life.";
        string breathOfHeaven4 = "Breath of Heaven increases the damage of your attacks by 15% for 45 seconds.";
        string breathOfHeaven5 = "Gain 6 additional Spirit from Spirit generating attacks for 5 seconds after using Breath of Heaven.";
        string breathOfHeaven6 = "Enemies exposed to Breath of Heaven run away in Fear for 1.5 seconds.";

        string dashingStrike1_1 = "Quickly dash at the targeted enemy or location, striking for ";
        double dashingStrike1dmg = 1.6f;
        string dashingStrike1_2 = " damage and rooting the target for 1 second.";
        string dashingStrike2 = "After striking an enemy, your movement speed is increased 25% for 3 seconds.";
        string dashingStrike3 = "Perform a flying kick that has a 60% chance to Stun your target for 1.5 seconds.";
        string dashingStrike4 = "Reduces the cost of Dashing Strike to 10 Spirit.";
        string dashingStrike5 = "Launch yourself through the air and slow all enemies along your path by 60% for 2 seconds.";
        string dashingStrike6 = "Receive a 20% increased chance to Dodge for 3 seconds.";

        string cripplingWave1_1 = "Unleash a series of large sweeping attacks that cause ";
        double cripplingWave1dmg = 1.1f;
        string cripplingWave1_2 = " damage to all enemies in front of you. Every third hit damages all enemies around you and dazes them, slowing their movement speed by 30% and attack speed by 20% for 3 seconds.";
        string cripplingWave2_1 = "Increase damage to ";
        double cripplingWave2dmg = 1.43f;
        string cripplingWave2_2 = " damage.";
        string cripplingWave3 = "Enemies hit by Crippling Wave inflict 20% less damage for 3 seconds.";
        string cripplingWave4 = "Critical Hits generate an additional 5 Spirit.";
        string cripplingWave5 = "The range of Crippling Wave's third strike is increased to 17 yards and the effect of the movement speed reduction is increased to 60%.";
        string cripplingWave6 = "Enemies hit by Crippling Wave take 10% additional damage from all attacks for 3 seconds.";

        string waveOfLight1_1 = "Focuses a wave of light that crushes enemies for ";
        double waveOfLight1dmg1 = 3.9f;
        string waveOfLight1_2 = " damage as Holy, followed by an additional ";
        double waveOfLight1dmg2 = 0.45f;
        string waveOfLight1_3 = " damage as Holy to all enemies in a line.";
        string waveOfLight2_1 = "Increases damage of the initial strike to ";
        double waveOfLight2dmg = 5.66f;
        string waveOfLight2_2 = " damage as Holy.";
        string waveOfLight3_1 = "Release bursts of energy that deal ";
        double waveOfLight3dmg = 4.3f;
        string waveOfLight3_2 = " damage as Holy to nearby enemies.";
        string waveOfLight4 = "Reduces the cost of Wave of Light to 40 Spirit.";
        string waveOfLight5 = "Critical Hits Stun enemies for 3 seconds.";
        string waveOfLight6_1 = "Summon an ancient pillar that deals ";
        double waveOfLight6dmg = 2.8f;
        string waveOfLight6_2 = " damage followed by an additional ";
        string waveOfLight6_3 = " damage after 2 seconds.";

        string explodingPalm1_1 = "Cause a target to Bleed for ";
        double explodingPalm1dmg = 7.45f;
        string explodingPalm1_2 = " damage as Physical over 9 seconds. If the target dies while bleeding, it explodes and deals 30% of the target's maximum Life as Physical damage to all nearby enemies.";
        string explodingPalm2 = "Also causes the target to take 12% additional damage for 3 seconds.";
        string explodingPalm3 = "If the target explodes after bleeding, gain 5 Spirit for each enemy caught in the blast.";
        string explodingPalm4 = "Also reduces your target's movement speed by 80%.";
        string explodingPalm5_1 = "Increases the duration of the Bleed effect to deal ";
        double explodingPalm5dmg = 7.45f;
        string explodingPalm5_2 = " damage as Physical over 15 seconds.";
        string explodingPalm6_1 = "Instead of bleeding, the target will burn for ";
        double explodingPalm6dmg1 = 2.5f;
        string explodingPalm6_2 = " damage as Fire over 3 seconds. If the target dies while burning, it explodes causing all nearby enemies to burn for ";
        double explodingPalm6dmg2 = 0.6f;
        string explodingPalm6_3 = " damage as Fire over 3 seconds. This effect can happen multiple times.";

        string cycloneStrike1_1 = "Pull all enemies within 24 yards towards you, followed by a furious blast of energy that deals ";
        double cycloneStrike1dmg = 1f;
        string cycloneStrike1_2 = " damage as Holy.";
        string cycloneStrike2 = "Reduces the Spirit cost of Cyclone Strike to 30 Spirit.";
        string cycloneStrike3 = "Increases the distance enemies will be pulled towards you to 34 yards.";
        string cycloneStrike4 = "Changes the blast into an explosion of fire that has a 35% chance to Fear enemies for 1.5 seconds.";
        string cycloneStrike5 = "After using Cyclone Strike, gain a 20% chance to dodge attacks for 3 seconds.";
        string cycloneStrike6 = "Cyclone Strike heals you and all allies within 24 yards for 1240 Life.";

        string wayOfTheHundredFists1_1 = "Unleash a rapid series of punches that strikes enemies for ";
        double wayOfTheHundredFists1dmg = 1.4f;
        string wayOfTheHundredFists1_2 = " damage.";
        string wayOfTheHundredFists2 = "Increases the number of hits in the second strike from 7 to 10.";
        string wayOfTheHundredFists3 = "Critical Hits increase your attack speed and movement speed by 5% for 5 seconds. This effect can stack up to 3 times.";
        string wayOfTheHundredFists4_1 = "Affected targets will take an additional ";
        double wayOfTheHundredFists4dmg = 1f;
        string wayOfTheHundredFists4_2 = " damage per second as Holy over 5 seconds. Also adds a short dash to the first strike.";
        string wayOfTheHundredFists5 = "Every activation of the skill has a 15% chance to generate 15 additional Spirit.";
        string wayOfTheHundredFists6_1 = "The third strike generates a wave of wind that deals ";
        double wayOfTheHundredFists6dmg = 2.5f;
        string wayOfTheHundredFists6_2 = " damage as Physical to enemies directly ahead of you.";

        string serenity1 = "You are enveloped in a protective shield that absorbs all incoming damage for 3 seconds and grants immunity to all control impairing effects.";
        string serenity2 = "When activated, Serenity heals you for 6202 - 7752 Life.";
        string serenity3_1 = "When Serenity ends, the shield explodes, dealing 30% of the damage absorbed by Serenity as Holy damage to enemies within 20 yards. The damage to each enemy cannot exceed ";
        double serenity3HP = 1f;
        string serenity3_2 = ".";
        string serenity4 = "Extends the protective shield to allies within 45 yards for 1 seconds, and makes them immune to control impairing effects like Slow and Frozen.";
        string serenity5 = "Increases the duration of Serenity to 4 seconds.";
        string serenity6_1 = "While Serenity is active, 50% of all projectiles and melee attacks are reflected back at the attacker. Reflected damage cannot exceed ";
        string serenity6_2 = ".";

        string sevenSidedStrike1_1 = "Dash rapidly between nearby enemies, dealing ";
        double sevenSidedStrike1dmg = 17.77f;
        string sevenSidedStrike1_2 = " damage over 7 hits.";
        string sevenSidedStrike2_1 = "Teleport to the target, increasing damage done to ";
        double sevenSidedStrike2dmg = 23.09f;
        string sevenSidedStrike2_2 = " damage over 7 strikes.";
        string sevenSidedStrike3 = "Increases the number of strikes to 9.";
        string sevenSidedStrike4 = "Enemies hit by Seven-Sided Strike have a 25% chance to be stunned for 7 seconds by each hit.";
        string sevenSidedStrike5 = "Reduces the cooldown of Seven-Sided Strike to 23 seconds.";
        string sevenSidedStrike6_1 = "Each strike explodes, dealing ";
        double sevenSidedStrike6dmg = 2.54f;
        string sevenSidedStrike6_2 = " damage as Holy in a 7 yard radius around the target.";

        string mantraOfEvasion1 = "Recite a Mantra that grants you and your allies within 40 yards a 15% chance to dodge attacks for 3 minutes. For 3 seconds after activation, a second effect grants an additional 15% chance to dodge attacks.";
        string mantraOfEvasion2 = "Mantra of Evasion also increases Armor by 20%.";
        string mantraOfEvasion3 = "When you or an ally under the effect of Mantra of Evasion is reduced below 25% Life, a shield of protection forms around that target, reducing damage taken by 80% for 3 seconds. Each target can be protected at most once every 90 seconds by this effect.";
        string mantraOfEvasion4 = "Mantra of Evasion also increases movement speed by 5%.";
        string mantraOfEvasion5 = "Mantra of Evasion also reduces the duration of all control impairing effects like Slow or Frozen by 20%.";
        string mantraOfEvasion6_1 = "Successfully dodging an attack has a chance to create a burst of flame dealing ";
        double mantraOfEvasion6dmg = 0.35f;
        string mantraOfEvasion6_2 = " damage as Fire to all nearby enemies.";

        string mantraOfRetribution1 = "Recite a Mantra that causes you and your allies within 40 yards to reflect melee damage back at enemies, dealing Holy damage equal to 40% of the damage sustained. The effect lasts for 3 minutes. For 3 seconds after activation, the effect on you increases to 80% of the damage sustained. Damage is capped based on the maximum Life of the target";
        string mantraOfRetribution2 = "Increases the amount of damage reflected by the Mantra to 60%. The Mantra will now reflect ranged damage as well as melee damage.";
        string mantraOfRetribution3 = "Increases attack speed for you and your allies by 8%.";
        string mantraOfRetribution4 = "When taking damage from the Mantra of Retribution, enemies have a 10% chance to be stunned for 2 seconds.";
        string mantraOfRetribution5 = "When reflecting damage done to you, Mantra of Retribution has a chance to restore 3 Spirit.";
        string mantraOfRetribution6_1 = "An attacker that is damaged by Mantra of Retribution has a 30% chance to suffer a feedback blast, dealing ";
        double mantraOfRetribution6dmg = 0.45f;
        string mantraOfRetribution6_2 = " damage as Holy to itself and nearby enemies.";

        string sweepingWind1_1 = "Surround yourself in a vortex that continuously deals ";
        double sweepingWind1dmg1 = 0.15f;
        string sweepingWind1_2 = " damage to all enemies within 10 yards. The vortex lasts 6 seconds and is refreshed each time you strike an enemy with a melee attack. Landing a Critical Hit has a chance to increase the vortex effect up to 2 times for a total of ";
        double sweepingWind1dmg2 = 0.45f;
        string sweepingWind1_3 = " damage.";
        string sweepingWind2 = "Increases the duration of the vortex to 20 seconds.";
        string sweepingWind3_1 = "Intensify the vortex, increasing the damage per stack to ";
        double sweepingWind3dmg1 = 0.2f;
        string sweepingWind3_2 = " damage. This increases the damage with 3 stacks to ";
        double sweepingWind3dmg2 = 0.6f;
        string sweepingWind3_3 = " damage.";
        string sweepingWind4 = "Increases the radius of the vortex to 14 yards and changes the damage dealt to Fire.";
        string sweepingWind5 = "As long as your vortex is at the maximum stack count, you gain 3 Spirit per second.";
        string sweepingWind6_1 = "While your vortex is at the maximum stack count, Critical Hits have a chance to spawn a lightning tornado that periodically electrocutes nearby enemies for ";
        double sweepingWind6dmg = 0.2f;
        string sweepingWind6_2 = " damage as Lightning. Each spawned lightning tornado lasts 3 seconds.";

        string innerSanctuary1 = "Create a runic circle of protection on the ground for 5 seconds that cannot be passed by enemies.";
        string innerSanctuary2 = "You and your allies standing in the area of effect of Inner Sanctuary regenerate 1550 Life per second.";
        string innerSanctuary3 = "When Inner Sanctuary expires, it becomes sanctified ground for 6 seconds, slowing the movement of all enemies that move through it by 60%.";
        string innerSanctuary4 = "Increases the duration of Inner Sanctuary to 7 seconds.";
        string innerSanctuary5 = "You and your allies standing in the area of effect of Inner Sanctuary take 35% less damage.";
        string innerSanctuary6 = "You and your allies standing in the area of effect of Inner Sanctuary deal 10% additional damage.";

        string mysticAlly1_1 = "Summon a mystic ally to fight alongside you until it is destroyed. The ally deals ";
        double mysticAlly1dmg = 0.4f;
        string mysticAlly1_2 = " damage as Physical per swing.";
        string mysticAlly2_1 = "Imbue the ally with the essence of water. The ally gains the ability to perform a wave attack that deals ";
        double mysticAlly2dmg = 1.2f;
        string mysticAlly2_2 = " damage as Physical and slows the movement of affected targets by 30% for 2 seconds.";
        string mysticAlly3_1 = "Imbue the ally with the essence of fire. The ally gains the ability to unleash a flaming kick for 80% weapon damage as Fire plus an additional ";
        double mysticAlly3dmg = 0.4f;
        string mysticAlly3_2 = " damage per second as Fire for 2 seconds to all enemies in a straight line.";
        string mysticAlly4_1 = "Imbue the ally with the essence of air. Every attack made by the ally has a 2% chance to generate 100 Spirit for you. In addition, the ally is surrounded in a torrent of wind that deals ";
        double mysticAlly4dmg = 0.1f;
        string mysticAlly4_2 = " damage per second as Physical to all nearby enemies.";
        string mysticAlly5_1 = "Imbue the ally with the essence of life. When the ally dies, it has a 50% chance to be reborn after 5 seconds. In addition, the physical damage of the ally's basic attack is increased to ";
        double mysticAlly5dmg = 0.44f;
        string mysticAlly5_2 = " damage per swing.";
        string mysticAlly6_1 = "Imbue the ally with the essence of earth. Maximum Life for you and the ally is increased by 10%. The ally also gains the ability to create a wave of earth, dealing ";
        double mysticAlly6dmg = 0.6f;
        string mysticAlly6_2 = " damage as Physical to a single enemy and forcing that enemy to attack the ally for 3 seconds.";

        string mantraOfHealing1 = "Recite a Mantra that causes you and your allies within 40 yards to gain increased Life regeneration by 310 Life per second. The Mantra lasts 3 minutes. For 3 seconds after activation, Mantra of Healing shrouds you and your allies with a mystical shield that absorbs up to 930 damage.";
        string mantraOfHealing2 = "Increases the Life regeneration granted by Mantra of Healing to 620 Life per second.";
        string mantraOfHealing3 = "Mantra of Healing also regenerates 3 Spirit per second.";
        string mantraOfHealing4 = "Mantra of Healing also heals 186 Life when hitting an enemy.";
        string mantraOfHealing5 = "Mantra of Healing also increases Vitality by 10%.";
        string mantraOfHealing6 = "Mantra of Healing also increases resistances to all damage types by 20%.";

        string mantraOfConviction1 = "Recite a Mantra that causes all enemies within 20 yards of you to take 12% additional damage. The Mantra lasts 3 minutes. For 3 seconds after activation, the effect is increased to 24% additional damage.";
        string mantraOfConviction2 = "Increases the strength of Mantra of Conviction so that enemies take 24% additional damage and 48% for the first 3 seconds.";
        string mantraOfConviction3 = "Enemies affected by Mantra of Conviction deal 10% less damage.";
        string mantraOfConviction4 = "Slows the movement of enemies within 20 yards by 30%.";
        string mantraOfConviction5 = "You and your allies have a 30% chance to be healed for 279 - 341 Life when using melee attacks on an enemy under the effects of Mantra of Conviction.";
        string mantraOfConviction6_1 = "Enemies affected by Mantra of Conviction take ";
        double mantraOfConviction6dmg = 0.12f;
        string mantraOfConviction6_2 = " damage per second as Holy.";

        string naggingAunt1 = "You will be forced to attend church every sunday for the next year";
        string naggingAunt2 = "A thief steals your aunts car while you had borrowed it, and you will never hear the end of it";
        string naggingAunt3 = "You need to clean out your aunts basement.";
        string naggingAunt4 = "Your aunt tell you to stop playing on your computer and mow her lawn instead.";
        string naggingAunt5 = "Five guys robbed your aunt. You will be called to court as a witness";
        string naggingAunt6 = "Theres a badger in your aunts garage. You need to chase it out, but the only protection you have is a sheet of paper, and your only weapon is a breadstick. run. now.";
        #endregion
        #region Witch Doctor
        //jag fick hjälp av en annan vän med de första 10 på Witch doctor, sparade in en hel timme.
        string poisonDart1_1 = "Shoot a deadly Poison Dart that deals ";
        double poisonDart1dmg1 = 1f;
        string poisonDart1_2 = " damage as Poison and an additional ";
        double poisonDart1dmg2 = 0.4f;
        string poisonDart1_3 = " damage as Poison over 2 seconds.";
        string poisonDart2_1 = "Shoot 3 Poison Darts that deal ";
        double poisonDart2dmg = 0.6f;
        string poisonDart2_2 = " damage as Poison each.";
        string poisonDart3 = "Toxins in the Poison Dart reduce the target's movement speed by 60% for 2 seconds.";
        string poisonDart4 = "Gain 29 Mana every time a Poison Dart hits an enemy.";
        string poisonDart5_1 = "Ignite the dart so that it deals ";
        double poisonDart5dmg = 1.8f;
        string poisonDart5_2 = " damage as Fire at once.";
        string poisonDart6 = "Transform your Poison Dart into a snake that has a 30% chance to Stun the enemy for 1.5 seconds.";

        string graspDead1_1 = "Ghoulish hands reach out from the ground, slowing enemy movement by 60% and dealing ";
        double graspDead1dmg = 3.2f;
        string graspDead1_2 = " damage as Physical over 8 seconds. ";
        string graspDead2 = "Increases the Slow amount to 80%.";
        string graspDead3_1 = "Increases the damage done to ";
        double graspDead3dmg = 0.26f;
        string graspDead3_2 = " damage as Physical.";
        string graspDead4 = "Enemies who die while in the area of Grasp of the Dead have a 10% chance to produce a health globe.";
        string graspDead5 = "Reduces the cooldown of Grasp of the Dead to 6 seconds.";
        string graspDead6_1 = "Corpses fall from the sky, dealing ";
        double graspDead6dmg = 0.8f;
        string graspDead6_2 = " damage as Physical over 8 seconds to nearby enemies.";

        string corpseSpiders1_1 = "Throw a jar with 4 spiders that attack nearby enemies for ";
        double corpseSpiders1dmg = 0.16f;
        string corpseSpiders1_2 = " damage as Physical before dying.";
        string corpseSpiders2_1 = "Summon jumping spiders that leap up to 25 yards to reach their target and attack for ";
        double corpseSpiders2dmg = 0.19f;
        string corpseSpiders2_2 = " damage as Physical.";
        string corpseSpiders3_1 = "Summon a spider queen that births spiderlings, dealing ";
        double corpseSpiders3dmg = 6.3f;
        string corpseSpiders3_2 = " damage over 15 seconds as Poison to enemies in the area.\nYou may only have one spider queen summoned at a time.";
        string corpseSpiders4 = "Summon widowmaker spiders that return 3 Mana to you per hit.";
        string corpseSpiders5 = "Summon paralyzing spiders that have a 25% chance to Slow enemies' movement by 60% with every attack.";
        string corpseSpiders6_1 = "Summon fire spiders that deal ";
        double corpseSpiders6dmg = 0.21f;
        string corpseSpiders6_2 = " damage as Fire.";

        string summonDogs1_1 = "Summon 3 Zombie Dogs from the depths to fight by your side. Each dog deals ";
        double summonDogs1dmg = 0.09f;
        string summonDogs1_2 = " damage as Physical per hit.";
        string summonDogs2_1 = "Your Zombie Dogs gain an infectious bite that deals ";
        double summonDogs2dmg = 0.09f;
        string summonDogs2_2 = " damage as Poison over 3 seconds.";
        string summonDogs3 = "Your Zombie Dogs have a 15% chance to leave behind a health globe when they die.";
        string summonDogs4 = "Your Zombie Dogs absorb 10% of all damage done to you.";
        string summonDogs5_1 = "Your Zombie Dogs burst into flames, burning nearby enemies for ";
        double summonDogs5dmg = 0.02f;
        string summonDogs5_2 = " damage as Fire.";
        string summonDogs6 = "Your Zombie Dogs heal 50% of the damage they deal as Life divided evenly between themselves and you.";

        string fireBats1_1 = "Call forth a swarm of fiery bats to burn enemies in front of you for ";
        double fireBats1dmg = 1.8f;
        string fireBats1_2 = " damage as Fire. ";
        string fireBats2_1 = "Summon fewer but larger bats that travel up to 40 yards and hit for ";
        double fireBats2dmg = 2.2f;
        string fireBats2_2 = " damage as Fire.";
        string fireBats3 = "Gain 2.5% of damage done by the bats as Life.";
        string fireBats4_1 = "Diseased bats fly towards the enemy and infect them. Damage is slow at first, but can increase over time to a maximum of ";
        double fireBats4dmg = 2.270f;
        string fireBats4_2 = " damage as Poison.";
        string fireBats5_1 = "Rapidly summon bats that seek out nearby enemies for ";
        double fireBats5dmg = 3.5f;
        string fireBats5_2 = " damage as Fire.";
        string fireBats6_1 = "Call forth a swirl of bats that damage nearby enemies for ";
        double fireBats6dmg = 1.95f;
        string fireBats6_2 = " damage as Fire. The damage of the bats increases by 20% every second, up to a maximum of 100%.";

        string horrify1 = "Don a spectral mask that horrifies all enemies within 12 yards, causing them to run in Fear for 4 seconds.";
        string horrify2 = "Increases the duration horrified enemies run in Fear to 6 seconds.";
        string horrify3 = "Increases movement speed by 20% for 4 seconds after casting Horrify.";
        string horrify4 = "Increases the radius of Horrify to 24 yards.";
        string horrify5 = "Gain 100% additional Armor for 8 seconds after casting Horrify.";
        string horrify6 = "Gain 27 Mana for every horrified enemy.";

        string soulHarvest1 = "Feed on the life force of up to 5 enemies within 16 yards. Gain 130 Intelligence for each affected enemy. This effect lasts 30 seconds.";
        string soulHarvest2 = "Gain 26 Mana for every enemy harvested.";
        string soulHarvest3 = "Gain 237 Life for every enemy harvested.";
        string soulHarvest4 = "Reduces the movement speed of harvested enemies by 80% for 3 seconds.";
        string soulHarvest5 = "Increase the duration of Soul Harvest's effect to 60 seconds.";
        string soulHarvest6_1 = "Harvested enemies also take ";
        double soulHarvest6dmg = 2.3f;
        string soulHarvest6_2 = " damage as Physical.";

        string plagueToads1_1 = "Release a handful of toads that deal ";
        double plagueToads1dmg = 1.3f;
        string plagueToads1_2 = " damage as Poison to enemies they come in contact with.";
        string plagueToads2_1 = "Mutate to fire bullfrogs that explode for ";
        double plagueToads2dmg = 1.69f;
        string plagueToads2_2 = " damage as Fire.";
        string plagueToads3_1 = "Summon a giant toad that swallows enemies whole for up to 5 seconds, digesting for ";
        double plagueToads3dmg = 0.2f;
        string plagueToads3_2 = " damage per second as Physical. Adds a 5 second cooldown to Plague of Toads.";
        string plagueToads4_1 = "Cause toads to rain from the sky that deal ";
        double plagueToads4dmg = 1.3f;
        string plagueToads4_2 = " damage as Poison to enemies in the area over 2 seconds.";
        string plagueToads5_1 = "Mutate to yellow frogs that deal ";
        double plagueToads5dmg = 1.3f;
        string plagueToads5_2 = " damage as Poison and have a 15% chance to Confuse affected enemies for 4 seconds.";
        string plagueToads6 = "Removes the Mana cost of Plague of Toads.";

        string haunt1_1 = "Haunt an enemy with a spirit, dealing ";
        double haunt1dmg = 5.75f;
        string haunt1_2 = " damage as Arcane over 12 seconds. If the target dies, the spirit will haunt another nearby enemy.";
        string haunt2 = "The spirit returns 155 Life per second.";
        string haunt3_1 = "Summon a vengeful spirit that does ";
        double haunt3dmg = 2.88f;
        string haunt3_2 = " damage as Arcane over 2 seconds.";
        string haunt4 = "If there are no targets left, the spirit will linger for up to 10 seconds looking for new enemies.";
        string haunt5 = "Slow the movement of haunted targets by 30%.";
        string haunt6 = "The spirit returns 10.2 Mana per second.";

        string sacrifice1_1 = "Banish your Zombie Dogs and cause them to explode, each dealing ";
        double sacrifice1dmg = 2.75f;
        string sacrifice1_2 = " damage as Physical to all enemies within 12 yards.";
        string sacrifice2 = "Ichor erupts from the corpses of the Zombie Dogs and Slows enemies by 60% for 8 seconds.";
        string sacrifice3 = "Each Zombie Dog you sacrifice has a 35% chance to resurrect as a new Zombie Dog.";
        string sacrifice4 = "Regain 294 Mana for each Zombie Dog you sacrifice.";
        string sacrifice5 = "Gain 6202 Life for each Zombie Dog you sacrifice.";
        string sacrifice6 = "Each sacrificed Zombie Dog increases your damage by 5% for 30 seconds.";

        string zombieCharger1_1 = "Call forth a reckless, suicidal zombie that deals ";
        double zombieCharger1dmg = 2.05f;
        string zombieCharger1_2 = " damage as Poison to all enemies in its path before decomposing. ";
        string zombieCharger2_1 = "The Zombie Charger leaves behind a cloud of noxious vapors that deals ";
        double zombieCharger2dmg = 2.4f;
        string zombieCharger2_2 = " damage over 3 seconds as Poison to enemies caught in it.";
        string zombieCharger3_1 = "If the Zombie Charger kills any enemies, it will reanimate and charge nearby enemies for ";
        double zombieCharger3dmg = 2.05f;
        string zombieCharger3_2 = " damage as Poison. This effect can repeat up to 2 times.";
        string zombieCharger4_1 = "Summon 3 Zombie Chargers that each deal ";
        double zombieCharger4dmg = 1.15f;
        string zombieCharger4_2 = " damage as Poison.";
        string zombieCharger5_1 = "Summon an explosive Zombie Dog that streaks toward your target before exploding, dealing ";
        double zombieCharger5dmg = 2.36f;
        string zombieCharger5_2 = " damage as Fire to all enemies within 9 yards.";
        string zombieCharger6_1 = "Summon zombie bears that stampede towards your target. Each bear deals ";
        double zombieCharger6dmg = 2.36f;
        string zombieCharger6_2 = " damage as Poison to enemies in the area.";

        string spiritWalk1_1 = "Leave your physical body and enter the spirit realm for 2 seconds. While in the spirit realm, your movement is unhindered.\n\nYour link to the spirit realm will end if your physical body sustains ";
        double spiritWalk1HP = 0.5f;
        string spiritWalk1_2 = " Life in damage. ";
        string spiritWalk2 = "Increases the duration of Spirit Walk to 3 seconds.";
        string spiritWalk3 = "Gain 15% of your maximum Mana every second while Spirit Walk is active.";
        string spiritWalk4_1 = "When Spirit Walk ends, your physical body erupts for ";
        double spiritWalk4dmg = 3.1f;
        string spiritWalk4_2 = " damage as Fire to all enemies within 10 yards.";
        string spiritWalk5_1 = "Damage enemies you walk through in spirit form for ";
        double spiritWalk5dmg = 4.5f;
        string spiritWalk5_2 = " damage over 2 seconds as Physical.";
        string spiritWalk6_1 = "Gain ";
        double spiritWalk6HP = 0.07f;
        string spiritWalk6_2 = " Life every second while Spirit Walk.";

        string spiritBarrage1_1 = "Bombard a target with a spirit blast that deals ";
        double spiritBarrage1dmg = 2.3f;
        string spiritBarrage1_2 = " damage as Physical. ";
        string spiritBarrage2 = "Gain 44 Mana every time Spirit Barrage hits.";
        string spiritBarrage3_1 = "An additional 3 spirits seek out other targets and deal ";
        double spiritBarrage3dmg = 0.65f;
        string spiritBarrage3_2 = " damage as Physical.";
        string spiritBarrage4_1 = "Summon a spectre for 5 seconds that deals ";
        double spiritBarrage4dmg = 0.45f;
        string spiritBarrage4_2 = " damage as Physical to all enemies within 10 yards.";
        string spiritBarrage5 = "Regain 3% of damage dealt with Spirit Barrage as Life.";
        string spiritBarrage6_1 = "Summon a spectre for 20 seconds that hovers over you, unleashing spirit bolts at nearby enemies for ";
        double spiritBarrage6dmg = 16.67f;
        string spiritBarrage6_2 = " damage as Physical over the duration.";

        string gargantuan1_1 = "Summon a Gargantuan zombie to fight for you. The Gargantuan attacks for ";
        double gargantuan1dmg = 1f;
        string gargantuan1_2 = " damage as Physical. ";
        string gargantuan2_1 = "The Gargantuan gains the Cleave ability, allowing its attacks to hit multiple targets for ";
        double gargantuan2dmg = 1.3f;
        string gargantuan2_2 = " damage as Physical.";
        string gargantuan3 = "When the Gargantuan encounters an elite enemy or is near 5 enemies, it enrages for 15 seconds gaining:\n20% movement speed\n35% attack speed\n200% Physical damage\nThis effect cannot occur more than once every 120 seconds.";
        string gargantuan4_1 = "Summon a more powerful Gargantuan that only lasts for 15 seconds. The Gargantuan's fists burn with fire, dealing ";
        double gargantuan4dmg = 1.1f;
        string gargantuan4_2 = " damage as Fire and knocking enemies back.";
        string gargantuan5_1 = "The Gargantuan is surrounded by a poison cloud that deals ";
        double gargantuan5dmg = 0.15f;
        string gargantuan5_2 = " damage as Poison per second to nearby enemies.";
        string gargantuan6_1 = "The Gargantuan gains the ability to periodically slam enemies, dealing ";
        double gargantuan6dmg = 2f;
        string gargantuan6_2 = " damage as Physical and stunning them for 3 seconds.";

        string fireBomb1_1 = "Lob an explosive skull that deals ";
        double fireBomb1dmg = 1.1f;
        string fireBomb1_2 = " damage as Fire to all enemies within 8 yards. ";
        string fireBomb2 = "Rather than exploding for area damage, each Firebomb can bounce to up to 6 additional targets. Damage is reduced by 15% per bounce.";
        string fireBomb3 = "Allows the skull to bounce up to 2 times.";
        string fireBomb4_1 = "The explosion creates a pool of fire that deals ";
        double fireBomb4dmg = 0.36f;
        string fireBomb4_2 = " damage over 3 seconds as Fire";
        string fireBomb5_1 = "Create a column of flame that spews fire at the closest enemy for ";
        double fireBomb5dmg = 6.4f;
        string fireBomb5_2 = " damage as Fire over 6 seconds. \nOnly one column can be summoned at a time.";
        string fireBomb6_1 = "In addition to the base explosion, the skull creates a larger blast that deals an additional ";
        double fireBomb6dmg = 0.2f;
        string fireBomb6_2 = " damage as Fire to all enemies within 28 yards.";

        string locustSwarm1_1 = "Unleash a plague of locusts that swarms an enemy, dealing ";
        double locustSwarm1dmg = 3.6f;
        string locustSwarm1_2 = " damage as Poison over 8 seconds. The locusts will jump to additional nearby enemies. ";
        string locustSwarm2 = "Locust Swarm has a 100% chance to jump to two additional targets instead of one.";
        string locustSwarm3 = "Gain 37 Mana for every enemy affected by the swarm.";
        string locustSwarm4 = "Increases the duration of the swarm to 10 seconds.";
        string locustSwarm5_1 = "Enemies killed by Locust Swarm leave behind a cloud of locusts that deal ";
        double locustSwarm5dmg = 0.25f;
        string locustSwarm5_2 = " damage as Poison. This cloud of locusts lingers for 3 seconds.";
        string locustSwarm6_1 = "Engulf the target with burning locusts that deal ";
        double locustSwarm6dmg = 4.68f;
        string locustSwarm6_2 = " damage as Fire over 8 seconds.";

        string acidCloud1_1 = "Cause acid to rain down, dealing an initial ";
        double acidCloud1dmg1 = 1.15f;
        string acidCloud1_2 = " damage as Poison, followed by ";
        double acidCloud1dmg2 = 1.5f;
        string acidCloud1_3 = " damage as Poison over 3 seconds to enemies who remain in the area. ";
        string acidCloud2 = "Increases the initial area of effect of Acid Cloud to 24 yards.";
        string acidCloud3_1 = "The acid on the ground forms into a slime that irradiates nearby enemies for ";
        double acidCloud3dmg = 0.5f;
        string acidCloud3_2 = " damage as Poison. The slime dissipates after 5 seconds.";
        string acidCloud4 = "Increases the duration of the acid pools left behind to 6 seconds.";
        string acidCloud5_1 = "Spit a cloud of acid that inflicts ";
        double acidCloud5dmg1 = 1.26f;
        string acidCloud5_2 = " damage as Poison, followed by ";
        double acidCloud5dmg2 = 1.65f;
        string acidCloud5_3 = " damage as Poison to enemies who remain in the area.";
        string acidCloud6_1 = "Raise a corpse from the ground that explodes for ";
        double acidCloud6dmg = 2.3f;
        string acidCloud6_2 = " damage as Poison to enemies in the area.";

        string hex1 = "Summon a Fetish Shaman for 12 seconds that will hex enemies into chickens. Hexed enemies are unable to perform offensive actions and take 10% additional damage. ";
        string hex2 = "The Fetish Shaman will periodically heal allies for 1861 Life.";
        string hex3 = "Hexed targets take 20% additional damage.";
        string hex4_1 = "Transform into an angry chicken for up to 5 seconds that can explode for ";
        double hex4dmg = 2.15f;
        string hex4_2 = " damage as Physical to all enemies within 12 yards.";
        string hex5_1 = "Hex causes the target to Bleed for ";
        double hex5dmg = 0.12f;
        string hex5_2 = " damage as Physical.";
        string hex6_1 = "Hexed targets explode when killed, dealing ";
        double hex6dmg = 1.35f;
        string hex6_2 = " damage as Poison to all enemies within 8 yards.";

        string massConfusion1 = "Incite paranoia in enemies, confusing them and causing some to fight for you for 12 seconds. ";
        string massConfusion2 = "Reduces the cooldown of Mass Confusion to 45 seconds.";
        string massConfusion3 = "Enemies killed while Confused have a 50% chance of spawning a Zombie Dog.";
        string massConfusion4 = "Up to 6 enemies who aren't Confused are Stunned for 3 seconds.";
        string massConfusion5 = "All enemies in the area of Mass Confusion take 20% additional damage for 12 seconds.";
        string massConfusion6_1 = "Amid the confusion, a giant spirit rampages through enemies, dealing ";
        double massConfusion6dmg = 0.22f;
        string massConfusion6_2 = " damage per second as Physical to enemies it passes through.";

        string voodoo1 = "Conjure a Fetish that begins a ritual dance that increases the attack speed and movement speed of all nearby allies by 20% for 20 seconds. ";
        string voodoo2 = "Increases the duration of the ritual to 30 seconds.";
        string voodoo3 = "The ritual restores 123 Mana per second while standing in the ritual area.";
        string voodoo4 = "The Fetish increases the damage of all nearby allies by 30%.";
        string voodoo5 = "The ritual heals all nearby allies for 5% of their maximum Life per second.";
        string voodoo6 = "Enemies who die in the ritual area have a 50% chance to resurrect as a Zombie Dog.";

        string zombieWall1_1 = "Raise a line of zombies from the ground that attacks nearby enemies for ";
        double zombieWall1dmg = 8f;
        string zombieWall1_2 = " damage as Physical over 5 seconds. ";
        string zombieWall2 = "Increases the width of the Wall of Zombies.";
        string zombieWall3 = "Your Wall of Zombies will Slow the movement of enemies by 60% for 5 seconds.";
        string zombieWall4_1 = "Up to 3 zombies will emerge from the ground and attack nearby enemies for ";
        double zombieWall4dmg = 0.25f;
        string zombieWall4_2 = " damage as Physical per attack.";
        string zombieWall5_1 = "Summon a tower of zombies that falls over, dealing ";
        double zombieWall5dmg = 7.65f;
        string zombieWall5_2 = " damage as Physical to any enemies it hits and knocks them back.";
        string zombieWall6_1 = "Zombies crawl out of the ground and run in all directions, dealing ";
        double zombieWall6dmg = 4.45f;
        string zombieWall6_2 = " damage as Physical to nearby enemies.";

        string fetishArmy1_1 = "Summon an army of dagger-wielding Fetishes to fight by your side for 20 seconds. The Fetishes attack for ";
        double fetishArmy1dmg = 0.2f;
        string fetishArmy1_2 = " damage as Physical.";
        string fetishArmy2_1 = "Each Fetish deals ";
        double fetishArmy2dmg = 2.5f;
        string fetishArmy2_2 = " damage as Physical to any nearby enemy as it is summoned.";
        string fetishArmy3 = "Decreases the cooldown of Fetish Army to 90 seconds.";
        string fetishArmy4 = "Increases number of dagger-wielding Fetishes summoned by 3.";
        string fetishArmy5_1 = "Summon an additional 2 Fetish casters who breathe fire in a cone in front of them that deals ";
        double fetishArmy5dmg = 0.15f;
        string fetishArmy5_2 = " damage as Fire.";
        string fetishArmy6_1 = "Summon an additional 2 Hunter Fetishes that shoot blowdarts at enemies, dealing ";
        double fetishArmy6dmg = 0.2f;
        string fetishArmy6_2 = " damage as Poison.";
        #endregion
        #region Wizard
        //Wizards abilities
        string magicMissile1_1 = "Launch a missile of magic energy, causing ";
        double magicMissile1dmg = 1.1f;
        string magicMissile1_2 = " damage as Arcane.";
        string magicMissile2_1 = "Increases the damage of Magic Missile to ";
        double magicMissile2dmg = 1.43f;
        string magicMissile2_2 = " damage as Arcane.";
        string magicMissile3_1 = "Fire 3 missiles that each deal ";
        double magicMissile3dmg = 0.5f;
        string magicMissile3_2 = " damage as Arcane.";
        string magicMissile4 = "Missiles have a 70% chance to pierce through their target and hit additional enemies.";
        string magicMissile5 = "Whenever Magic Missile hits a target you gain 4 Arcane Power.";
        string magicMissile6_1 = "Missiles track the nearest enemy and their damage is increased to ";
        double magicMissile6dmg = 1.21f;
        string magicMissile6_2 = " damage as Arcane.";

        string frostRay1_1 = "Project a beam of frozen ice that blasts ";
        double frostRay1dmg = 2.15f;
        string frostRay1_2 = " damage as Cold to the first enemy it hits, slowing the target's movement by 30% for 3 seconds. ";
        string frostRay2 = "Increase the amount the target's movement is slowed to 60% for 3 seconds.";
        string frostRay3_1 = "Using continuously on a single target increases damage over 1.5 seconds to inflict a maximum of ";
        double frostRay3dmg = 2.8f;
        string frostRay3_2 = " damage as Cold";
        string frostRay4 = "Reduce casting cost to 12 Arcane Power.";
        string frostRay5_1 = "Create a swirling storm around you, dealing ";
        double frostRay5dmg = 2.15f;
        string frostRay5_2 = " damage as Cold to all enemies caught within it.";
        string frostRay6_1 = "Enemies killed with Ray of Frost leave behind a patch of ice that deals ";
        double frostRay6dmg = 1.94f;
        string frostRay6_2 = " damage as Cold to enemies moving through it over 3 seconds.";

        string shockPulse1_1 = "Release a medium range pulse of 3 unpredictable charges of electricity that deal ";
        double shockPulse1dmg = 1.05f;
        string shockPulse1_2 = " damage as Lightning. ";
        string shockPulse2_1 = "Slain enemies explode, dealing ";
        double shockPulse2dmg = 0.7f;
        string shockPulse2_2 = " damage as Lightning to every enemy within 10 yards.";
        string shockPulse3_1 = "Cast bolts of fire that each deal ";
        double shockPulse3dmg = 1.52f;
        string shockPulse3_2 = " damage as Fire.";
        string shockPulse4_1 = "Merge the bolts in a a single giant orb that oscillates forward dealing ";
        double shockPulse4dmg = 1.05f;
        string shockPulse4_2 = " damage as Lightning to everything it hits.";
        string shockPulse5 = "Every target hit by a pulse restores 3 Arcane Power.";
        string shockPulse6_1 = "Conjure a being of lightning that drifts forward, electrocuting nearby enemies for ";
        double shockPulse6dmg = 0.37f;
        string shockPulse6_2 = " damage as Lightning.";

        string frostNova1 = "Blast nearby enemies with an explosion of ice and freeze them for 3 seconds. ";
        string frostNova2 = "A frozen enemy that is killed has a 50% chance of releasing another Frost Nova.";
        string frostNova3 = "Reduce cooldown of Frost Nova to 9 seconds.";
        string frostNova4_1 = "Frost Nova no longer freezes enemies, but instead leaves behind a mist of frost that deals ";
        double frostNova4dmg = 1.6f;
        string frostNova4_2 = " damage as Cold over 8 seconds.";
        string frostNova5 = "If Frost Nova hits at least 5 targets, you gain a 15% bonus to Critical Hit Chance for 12 seconds.";
        string frostNova6 = "Enemies take 15% more damage while frozen or chilled by Frost Nova.";

        string arcaneOrb1_1 = "Hurl an orb of pure energy that explodes when it hits, dealing ";
        double arcaneOrb1dmg = 1.75f;
        string arcaneOrb1_2 = " damage as Arcane to all enemies within 10 yards. ";
        string arcaneOrb2_1 = "Increase the damage of the explosion to deal ";
        double arcaneOrb2dmg = 2.28f;
        string arcaneOrb2_2 = " damage as Arcane.";
        string arcaneOrb3_1 = "Create 4 Arcane Orbs that orbit you, exploding for ";
        double arcaneOrb3dmg = 0.7f;
        string arcaneOrb3_2 = " damage as Arcane when enemies get close.";
        string arcaneOrb4_1 = "Modify the orb to deal ";
        double arcaneOrb4dmg = 1.75f;
        string arcaneOrb4_2 = " damage as Arcane to all enemies within 20 yards.";
        string arcaneOrb5 = "Reduce casting cost to 20 Arcane Power.";
        string arcaneOrb6 = "The orb will pierce through targets, damaging any enemy it passes through.";

        string diamondSkin1 = "Transform your skin to diamond for 6 seconds, absorbing up to 10853 damage from incoming attacks. ";
        string diamondSkin2 = "Increases the maximum amount of damage absorbed to 21707 damage.";
        string diamondSkin3 = "Reduces Arcane Power cost of all spells by 7 while Diamond Skin is active.";
        string diamondSkin4 = "Reflects 100% of damage absorbed back at the attacker. Up to a mximum of 10853.";
        string diamondSkin5 = "Increases the duration of Diamond Skin to 9 seconds.";
        string diamondSkin6_1 = "When Diamond Skin wears off, diamond shards explode in all directions dealing ";
        double diamondSkin6dmg = 2.1f;
        string diamondSkin6_2 = " damage as Physical to nearby enemies.";

        string forceWave1_1 = "Discharge a wave of pure energy that repels projectiles and knocks back nearby enemies. This also slows the movement of enemies by 60% and deals ";
        double forceWave1dmg = 2f;
        string forceWave1_2 = " damage as Physical. ";
        string forceWave2 = "Increases the distance enemies are knocked back and Stuns all affected enemies for 2 seconds.";
        string forceWave3 = "Reduce casting cost to 15 Arcane Power and the cooldown is reduced to 12 seconds.";
        string forceWave4_1 = "Increases damage to ";
        double forceWave4dmg = 2.6f;
        string forceWave4_2 = " damage as Physical, but reduces Knockback.";
        string forceWave5 = "Enemies caught in the Wave of Force have a 100% chance to be randomly teleported.";
        string forceWave6_1 = "Enemies hit have a 40% chance to cause a smaller Wave of Force that deals ";
        double forceWave6dmg = 1f;
        string forceWave6_2 = " damage as Physical and knocks back enemies caught in its wake.";

        string spectralBlade1_1 = "Summon a spectral blade that strikes all enemies in your path for ";
        double spectralBlade1dmg = 1.35f;
        string spectralBlade1_2 = " damage. ";
        string spectralBlade2_1 = "Enemies hit by the blade will Bleed for an additional ";
        double spectralBlade2dmg = 0.35f;
        string spectralBlade2_2 = " damage over 3 seconds.";
        string spectralBlade3 = "Hits Slow the movement speed of enemies by 80% for 1 second.";
        string spectralBlade4 = "Every enemy hit grants 3 Arcane Power.";
        string spectralBlade5 = "Whenever the blades do critical damage, you are healed for 8% of the damage done.";
        string spectralBlade6 = "Extends the reach of Spectral Blade to 20 yards.";

        string arcaneTorrent1_1 = "Hurl a barrage of arcane projectiles that deal ";
        double arcaneTorrent1dmg = 2.1f;
        string arcaneTorrent1_2 = " damage as Arcane to all enemies near the impact location. ";
        string arcaneTorrent2 = "Targets hit by Arcane Torrent become disrupted for 6 seconds, causing them to take 15% additional damage from any attacks that deal Arcane damage.";
        string arcaneTorrent3_1 = "Unleash a torrent of power beyond your control. You no longer direct where the projectiles go, but their damage is increased to ";
        double arcaneTorrent3dmg = 6.7f;
        string arcaneTorrent3_2 = " damage as Arcane.";
        string arcaneTorrent4_1 = "Instead of firing projectiles, lay Arcane mines that arm after 2 seconds. These mines explode when an enemy approaches, dealing ";
        double arcaneTorrent4dmg = 1.8f;
        string arcaneTorrent4_2 = " damage as Arcane. Enemies caught in the explosion have their movement and attack speeds reduced by 30% for 3 seconds.";
        string arcaneTorrent5 = "Every missile hit has a 2% chance to leave behind a Power Stone that grants Arcane Power when picked up.";
        string arcaneTorrent6_1 = "Enemies killed by Arcane Torrent have a 100% chance to fire a new missile at a nearby enemy dealing ";
        double arcaneTorrent6dmg = 2.1f;
        string arcaneTorrent6_2 = " damage as Arcane.";

        string twister1_1 = "Unleash a twister of pure energy that deals ";
        double twister1dmg = 3.6f;
        string twister1_2 = " damage as Arcane over 6 seconds to everything in its path. ";
        string twister2 = "Reduces casting cost of Energy Twister to 20 Arcane Power.";
        string twister3_1 = "Increases the damage of Energy Twister to ";
        double twister3dmg = 4.68f;
        string twister3_2 = " damage as Arcane.";
        string twister4_1 = "When two Energy Twisters collide, they merge into a tornado with increased area of effect that causes ";
        double twister4dmg = 3.6f;
        string twister4_2 = " damage as Arcane over 6 seconds.";
        string twister5_1 = "Twisters no longer travel but spin in place, dealing ";
        double twister5dmg = 2.52f;
        string twister5_2 = " damage as Arcane over 6 seconds to everything caught in them.";
        string twister6_1 = "Casting Energy Twister grants you a Wind Charge. You can store up to 3 Wind Charges at a time. Casting a Signature spell releases all Wind Charges as a giant Energy Twister that deals ";
        double twister6dmg = 0.75f;
        string twister6_2 = " damage as Arcane per Wind Charge.";

        string iceArmor1 = "Surround yourself in a barrier of ice. Melee attackers are either Chilled or Frozen for 2 seconds. Lasts 120 seconds.";
        string iceArmor2 = "Lower the temperature of the air around you. Nearby enemies are chilled, slowing their movement speed by 30%.";
        string iceArmor3 = "Whenever you are struck by a melee attack, your Armor is increased by 30% for 30 seconds. This effect can stack up to 3 times.";
        string iceArmor4_1 = "Melee attackers also take ";
        double iceArmor4dmg = 1.3f;
        string iceArmor4_2 = " damage as Cold.";
        string iceArmor5_1 = "Melee attacks have a 25% chance to create a Frost Nova centered on the attacker, dealing ";
        double iceArmor5dmg = 0.75f;
        string iceArmor5_2 = " damage as Cold.";
        string iceArmor6_1 = "A whirling storm of ice builds around you that deals ";
        double iceArmor6dmg = 0.30f;
        string iceArmor6_2 = " damage as Cold over 3 seconds after casting Ice Armor.";

        string electrocute1_1 = "Lightning arcs from your fingertips, dealing ";
        double electrocute1dmg = 0.9f;
        string electrocute1_2 = " damage as Lightning. The lightning can jump, hitting up to 2 additional enemies. ";
        string electrocute2 = "Increases the maximum number of enemies that can be electrocuted to 15.";
        string electrocute3_1 = "Critical Hits release 4 charged bolts in random directions, dealing ";
        double electrocute3dmg = 0.55f;
        string electrocute3_2 = " damage as Lightning to any targets hit.";
        string electrocute4_1 = "Create streaks of lightning that pierce through targets, hitting all enemies for ";
        double electrocute4dmg = 0.86f;
        string electrocute4_2 = " damage as Lightning.";
        string electrocute5 = "Gain 4 Arcane Power for every enemy hit by Electrocute.";
        string electrocute6_1 = "Blast a cone of lightning that causes ";
        double electrocute6dmg = 1.15f;
        string electrocute6_2 = " damage as Lightning to all affected targets.";

        string slowTime1 = "Invoke a bubble of warped time and space for 8 seconds, reducing enemy attack speed by 20% and movement speed by 30%. This bubble also slows the movement of enemy projectiles by 90%. ";
        string slowTime2 = "Slow Time effects cling to enemies for 3 seconds after they have left the bubble.";
        string slowTime3 = "Enemies caught in the bubble of warped time take 20% more damage.";
        string slowTime4 = "Reduces the area Slow Time affects to 10 yards, but increases the potency of the movement speed reduction to 80%.";
        string slowTime5 = "Reduces the cooldown of Slow Time to 16 seconds.";
        string slowTime6 = "Time is sped up for any allies standing in the area, increasing their attack speed by 10%.";

        string stormArmor1_1 = "Bathe yourself in electrical energy, shocking ranged and melee attackers for ";
        double stormArmor1dmg = 0.7f;
        string stormArmor1_2 = " damage as Lightning. Lasts 120 seconds.";
        string stormArmor2_1 = "Whenever you are hit, you have a chance to be enveloped with a lightning shield for 6 seconds that shocks nearby enemies for ";
        double stormArmor2dmg = 0.5f;
        string stormArmor2_2 = " damage as Lightning.";
        string stormArmor3 = "Reduce the Arcane Power cost of all skills by 3 while Storm Armor is active.";
        string stormArmor4_1 = "Increase the damage of the shock to ";
        double stormArmor4dmg = 0.91f;
        string stormArmor4_2 = " damage as Lightning.";
        string stormArmor5 = "Increases your movement speed by 25% for 3 seconds whenever you are hit by melee or ranged attacks.";
        string stormArmor6_1 = "Critical Hits have a chance to electrocute a nearby enemy for ";
        double stormArmor6dmg = 0.35f;
        string stormArmor6_2 = " damage as Lightning.";

        string blast1_1 = "Gather an infusion of energy around you that explodes after 1.5 seconds, causing ";
        double blast1dmg = 2.25f;
        string blast1_2 = " damage as Physical to all enemies within 12 yards. ";
        string blast2 = "Reduces the casting cost of Explosive Blast to 10 Arcane Power.";
        string blast3_1 = "Explosive Blast detonates from the point it was originally cast after 2.5 seconds for ";
        double blast3dmg = 3.15f;
        string blast3_2 = " damage as Physical.";
        string blast4_1 = "Immediately release the energy of Explosive Blast for ";
        double blast4dmg = 2.25f;
        string blast4_2 = " damage as Physical.";
        string blast5_1 = "Increases the explosion radius to 18 yards for ";
        double blast5dmg = 2.25f;
        string blast5_2 = " damage as Physical.";
        string blast6_1 = "A chain of 3 consecutive explosions cascade off you, each causing ";
        double blast6dmg = 0.97f;
        string blast6_2 = " damage as Physical.";

        string magicWeapon1 = "Imbue your weapon with magical energy, granting it 10% increased damage. Lasts 5 minutes. ";
        string magicWeapon2_1 = "Attacks have a chance to cause lightning to arc to 3 nearby enemies, dealing ";
        double magicWeapon2dmg = 0.1f;
        string magicWeapon2_2 = " damage as Lightning.";
        string magicWeapon3 = "Increases the damage bonus of Magic Weapon to 15% damage, and gives up to a 2% chance to Knockback any enemies hit.";
        string magicWeapon4 = "Attacks have a chance to restore 1 Arcane Power.";
        string magicWeapon5_1 = "Attacks poison enemies, dealing ";
        double magicWeapon5dmg = 0.15f;
        string magicWeapon5_2 = " damage as Poison over 3 seconds.";
        string magicWeapon6 = "Attacks recover 1.5% of damage caused as Life.";

        string disintegrate1_1 = "Thrust a beam of pure energy forward, dealing ";
        double disintegrate1dmg = 1.55f;
        string disintegrate1_2 = " damage as Arcane and disintegrating enemies it kills. ";
        string disintegrate2 = "Increase the width of the beam allowing it to hit more enemies.";
        string disintegrate3_1 = "When casting the beam you become charged with energy that spits out at nearby enemies doing ";
        double disintegrate3dmg = 0.4f;
        string disintegrate3_2 = " damage as Arcane.";
        string disintegrate4_1 = "Enemies killed by the beam have a 35% chance to explode causing ";
        double disintegrate4dmg = 3.95f;
        string disintegrate4_2 = " damage as Arcane to all enemies within 8 yards.";
        string disintegrate5_1 = "The beam fractures into a short-ranged cone that deals ";
        double disintegrate5dmg = 1.78f;
        string disintegrate5_2 = " damage as Arcane.";
        string disintegrate6_1 = "Damage increases slowly over time to inflict a maximum of ";
        double disintegrate6dmg = 2.02f;
        string disintegrate6_2 = " damage as Arcane.";

        string hydra1_1 = "Summon a multi-headed Hydra for 15 seconds that attacks enemies with bolts of fire dealing ";
        double hydra1dmg = 0.28f;
        string hydra1_2 = " damage as Fire. You may only have one Hydra active at a time. ";
        string hydra2_1 = "Summon an Arcane Hydra that spits Arcane Orbs, which explode on impact, causing ";
        double hydra2dmg = 0.60f;
        string hydra2_2 = " damage as Arcane to enemies near the explosion.";
        string hydra3_1 = "Summon a Lightning Hydra that electrocutes enemies for ";
        double hydra3dmg = 0.64f;
        string hydra3_2 = " damage as Lightning.";
        string hydra4_1 = "Summon a poison breathing Hydra that leaves a pool of acid that causes ";
        double hydra4dmg = 0.18f;
        string hydra4_2 = " damage per second as Poison to enemies who remain in the pool.";
        string hydra5_1 = "Summon a Frost Hydra that breathes a cone of frost, causing ";
        double hydra5dmg = 0.36f;
        string hydra5_2 = " damage as Cold to all enemies in the cone.";
        string hydra6_1 = "Summon a Mammoth Hydra that breathes a river of flame at nearby enemies, dealing ";
        double hydra6dmg = 0.67f;
        string hydra6_2 = " damage per second as Fire to enemies caught on the burning ground.";

        string familiar1_1 = "Summon a companion that will attack your targets for ";
        double familiar1dmg = 0.2f;
        string familiar1_2 = " damage as Arcane. This companion cannot be targeted or damaged by enemies and lasts for 5 minutes. ";
        string familiar2 = "Summon a fiery Familiar that increases the damage of all attacks by 12% while Familiar is active.";
        string familiar3 = "Summon a lightning Familiar whose projectiles have a 100% chance to pierce through enemies.";
        string familiar4_1 = "Summon a protective Familiar. When you are below ";
        double familiar4HP = 0.35f;
        string familiar4_2 = " Life the Familiar will fully absorb damage from 1 attack every 6 seconds.";
        string familiar5 = "While the Familiar is active, you regenerate 2 Arcane Power per second.";
        string familiar6_1 = "The Familiar's projectiles explode on impact, dealing ";
        double familiar6dmg = 0.2f;
        string familiar6_2 = " damage as Arcane to all enemies within 6 yards.";

        string teleport1 = "Teleport through the ether to the selected location up to 35 yards away. ";
        string teleport2 = "For 4 seconds after you Teleport, you will take 30% less damage.";
        string teleport3 = "After casting Teleport, there is a 1 second delay before the cooldown begins, allowing you to Teleport again.";
        string teleport4 = "Casting Teleport again within 8 seconds will instantly return you to your original location.";
        string teleport5 = "Summon 2 decoys for 8 seconds after teleporting.";
        string teleport6_1 = "Casts a low power Wave of Force upon arrival, dealing ";
        double teleport6dmg = 2.65f;
        string teleport6_2 = " damage as Physical to all nearby enemies.";

        string meteor1_1 = "Summon an immense Meteor that plummets from the sky, causing ";
        double meteor1dmg1 = 2.6f;
        string meteor1_2 = " damage as Fire to all enemies it crashes into. The ground it hits is scorched with molten fire that deals ";
        double meteor1dmg2 = 0.6f;
        string meteor1_3 = " damage as Fire over 3 seconds. ";
        string meteor2_1 = "Increases the damage of the Meteor impact to ";
        double meteor2dmg1 = 3.9f;
        string meteor2_2 = " weapon damage as Fire and the molten fire to ";
        double meteor2dmg2 = 0.9f;
        string meteor2_3 = " damage as Fire over 3 seconds.";
        string meteor3 = "Reduces the casting cost of Meteor to 35 Arcane Power. And changes the damage dealt to Arcane.";
        string meteor4_1 = "Unleash a volley of 7 smaller Meteors that each strike for ";
        double meteor4dmg = 1.04f;
        string meteor4_2 = " damage as Fire.";
        string meteor5_1 = "Transforms the Meteor to ice that deals ";
        double meteor5dmg1 = 3.12f;
        string meteor5_2 = " damage as Cold. The impact site is covered in a freezing mist that deals ";
        double meteor5dmg2 = 0.72f;
        string meteor5_3 = " damage as Cold and Slows enemy movement by 60% over 3 seconds.";
        string meteor6 = "If the initial impact of the Meteor causes a Critical Hit, the molten fire duration is increased to 8 seconds.";

        string mirror1 = "Summon 2 illusionary duplicates of yourself that last for 7 seconds and have 25% of your Life. The images may cast some of the same spells as you, but those spells deal no damage. ";
        string mirror2 = "Increase the Life of your Mirror Images to 100% of your own.";
        string mirror3 = "Summon 5 Mirror Images that have 25% of your Life each.";
        string mirror4 = "When a Mirror Image is destroyed, it explodes, doing 45% weapon damage as Physical and has a 50% chance to Stun for 2 seconds.";
        string mirror5 = "The duration of your Mirror Images is increased to 10 seconds and their Life is increased to 29% of your Life.";
        string mirror6 = "Spells cast by your Mirror Images will do 10% of the damage of your own spells.";

        string blizzard1_1 = "Call down shards of ice to pelt an area, dealing ";
        double blizzard1dmg = 2.1f;
        string blizzard1_2 = " damage as Cold to all enemies in the area over 6 seconds. Multiple casts in the same area do not stack. ";
        string blizzard2 = "After the Blizzard ends, the ground is covered in a low lying mist for 3 seconds that Slows the movement speed of enemies by 60%.";
        string blizzard3 = "Enemies caught in the Blizzard have a 20% chance to be Frozen for 3 seconds.";
        string blizzard4 = "Reduces the casting cost of Blizzard to 20 Arcane Power.";
        string blizzard5_1 = "Increases the size of Blizzard to cover 22 yards, dealing ";
        double blizzard5dmg = 2.1f;
        string blizzard5_2 = " damage as Cold over 6 seconds.";
        string blizzard6_1 = "Increases the duration of Blizzard to deal ";
        double blizzard6dmg = 2.8f;
        string blizzard6_2 = " damage as Cold over 8 seconds.";

        string energyArmor1 = "Focus your energies, increasing your Armor by 65% but decreasing your maximum Arcane Power by 20. Lasts 120 seconds.";
        string energyArmor2 = "You have a chance to gain 4 Arcane Power whenever you are hit by a ranged or melee attack.";
        string energyArmor3 = "Increases your chance to critically hit by 5% while Energy Armor is active.";
        string energyArmor4 = "Rather than decreasing your maximum Arcane Power, Energy Armor increases it by 20 while it is active.";
        string energyArmor5_1 = "While Energy Armor is active, incoming attacks that would deal more than ";
        double energyArmor5HP = 0.35f;
        string energyArmor5_2 = " Damage is absorbed, up to a maximum of ";
        string energyArmor5_3 = " Damage absorbed";
        string energyArmor6 = "Increases all of your resistances by 40% while Energy Armor is active.";

        string archon1 = "Transform into a being of pure Arcane energy for 15 seconds. While in Archon form, your normal abilities are replaced by powerful Archon abilities, and your Armor and resistances are increased by 40%. Every enemy killed while in Archon form adds 1 second to the duration of Archon. ";
        string archon2_1 = "An explosion erupts around you when you transform, causing ";
        double archon2dmg = 16f;
        string archon2_2 = " damage as Arcane to all enemies within 15 yards.";
        string archon3 = "Archon form can now cast Teleport with a cooldown of 10 seconds.";
        string archon4 = "Decreases the cooldown of Archon to 100 seconds.";
        string archon5 = "Archon form can cast Slow Time that lasts for 15 seconds.";
        string archon6 = "Increases the damage of all Archon abilities by 25%.";
        #endregion

        public AbilitiesForm(StatsClass derivedStats, string derivedClass)
        {
            selectedClass = derivedClass;
            stats = derivedStats;
            InitializeComponent();
            LoadProperties();
        }
        //all kod på alla 400+ abilities inte så mycket annat att säga...
        private void ability1_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Bash";
                abilityRune1.Text = bash1_1 + Math.Round(stats.minDmg * bash1dmg).ToString() + "-" + Math.Round(stats.maxDmg * bash1dmg).ToString() + bash1_2;
                abilityRune2.Text = bash2;
                abilityRune3.Text = bash3_1 + Math.Round(stats.minDmg * bash3dmg).ToString() + "-" + Math.Round(stats.maxDmg * bash3dmg).ToString() + bash3_2;
                abilityRune4.Text = bash4;
                abilityRune5.Text = bash5;
                abilityRune6.Text = bash6_1 + Math.Round(stats.minDmg * bash6dmg).ToString() + "-" + Math.Round(stats.maxDmg * bash6dmg).ToString() + bash6_2;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Hungering Arrow";
                abilityRune1.Text = hungeringArrow1_1 + Math.Round(stats.minDmg * hungeringArrow1dmg).ToString() + "-" + Math.Round(stats.maxDmg * hungeringArrow1dmg).ToString() + hungeringArrow1_2;
                abilityRune2.Text = hungeringArrow2;
                abilityRune3.Text = hungeringArrow3_1 + Math.Round(stats.minDmg * hungeringArrow3dmg).ToString() + "-" + Math.Round(stats.maxDmg * hungeringArrow3dmg).ToString() + hungeringArrow3_2;
                abilityRune4.Text = hungeringArrow4;
                abilityRune5.Text = hungeringArrow5;
                abilityRune6.Text = hungeringArrow6_1 + Math.Round(stats.minDmg * hungeringArrow6dmg).ToString() + "-" + Math.Round(stats.maxDmg * hungeringArrow6dmg).ToString() + hungeringArrow6_2;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Fists of Thunder";
                abilityRune1.Text = fistsOfThunder1_1 + Math.Round(stats.minDmg * fistsOfThunder1dmg).ToString() + "-" + Math.Round(stats.maxDmg * fistsOfThunder1dmg).ToString() + fistsOfThunder1_2;
                abilityRune2.Text = fistsOfThunder2_1 + Math.Round(stats.minDmg * fistsOfThunder2dmg).ToString() + "-" + Math.Round(stats.maxDmg * fistsOfThunder2dmg).ToString() + fistsOfThunder2_2;
                abilityRune3.Text = fistsOfThunder3;
                abilityRune4.Text = fistsOfThunder4_1 + Math.Round(stats.minDmg * fistsOfThunder4dmg).ToString() + "-" + Math.Round(stats.maxDmg * fistsOfThunder4dmg).ToString() + fistsOfThunder4_2;
                abilityRune5.Text = fistsOfThunder5;
                abilityRune6.Text = fistsOfThunder6_1 + Math.Round(stats.minDmg * fistsOfThunder6dmg).ToString() + "-" + Math.Round(stats.maxDmg * fistsOfThunder6dmg).ToString() + fistsOfThunder6_2;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Poison Dart";
                abilityRune1.Text = poisonDart1_1 + Math.Round(stats.minDmg * poisonDart1dmg1).ToString() + "-" + Math.Round(stats.maxDmg * poisonDart1dmg1).ToString() + poisonDart1_2 + Math.Round(stats.minDmg * poisonDart1dmg2).ToString() + "-" + Math.Round(stats.maxDmg * poisonDart1dmg2) + poisonDart1_3;
                abilityRune2.Text = poisonDart2_1 + Math.Round(stats.minDmg * poisonDart2dmg).ToString() + "-" + Math.Round(stats.maxDmg * poisonDart2dmg).ToString() + poisonDart2_2;
                abilityRune3.Text = poisonDart3;
                abilityRune4.Text = poisonDart4;
                abilityRune5.Text = poisonDart5_1 + Math.Round(stats.minDmg * poisonDart5dmg).ToString() + "-" + Math.Round(stats.maxDmg * poisonDart5dmg).ToString() + poisonDart5_2;
                abilityRune6.Text = poisonDart6;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Magic Missile";
                abilityRune1.Text = magicMissile1_1 + Math.Round(stats.minDmg * magicMissile1dmg).ToString() + "-" + Math.Round(stats.maxDmg * magicMissile1dmg).ToString() + magicMissile1_2;
                abilityRune2.Text = magicMissile2_1 + Math.Round(stats.minDmg * magicMissile2dmg).ToString() + "-" + Math.Round(stats.maxDmg * magicMissile2dmg).ToString() + magicMissile2_2;
                abilityRune3.Text = magicMissile3_1 + Math.Round(stats.minDmg * magicMissile3dmg).ToString() + "-" + Math.Round(stats.maxDmg * magicMissile3dmg).ToString() + magicMissile3_2;
                abilityRune4.Text = magicMissile4;
                abilityRune5.Text = magicMissile5;
                abilityRune6.Text = magicMissile6_1 + Math.Round(stats.minDmg * magicMissile6dmg).ToString() + "-" + Math.Round(stats.maxDmg * magicMissile6dmg).ToString() + magicMissile6_2;
            }
            #endregion
        }

        private void ability2_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Cleave";
                abilityRune1.Text = cleave1_1 + Math.Round(stats.minDmg * cleave1dmg).ToString() + "-" + Math.Round(stats.maxDmg * cleave1dmg).ToString() + cleave1_2;
                abilityRune2.Text = cleave2_1 + Math.Round(stats.minDmg * cleave2dmg).ToString() + "-" + Math.Round(stats.maxDmg * cleave2dmg).ToString() + cleave2_2;
                abilityRune3.Text = cleave3;
                abilityRune4.Text = cleave4_1 + Math.Round(stats.minDmg * cleave4dmg).ToString() + "-" + Math.Round(stats.maxDmg * cleave4dmg).ToString() + cleave4_2;
                abilityRune5.Text = cleave5_1 + Math.Round(stats.minDmg * cleave5dmg).ToString() + "-" + Math.Round(stats.maxDmg * cleave5dmg).ToString() + cleave5_2;
                abilityRune6.Text = cleave6;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Entangling Shot";
                abilityRune1.Text = entanglingShot1_1 + Math.Round(stats.minDmg * entanglingShot1dmg).ToString() + "-" + Math.Round(stats.maxDmg * entanglingShot1dmg).ToString() + entanglingShot1_2;
                abilityRune2.Text = entanglingShot2;
                abilityRune3.Text = entanglingShot3_1 + Math.Round(stats.minDmg * entanglingShot3dmg).ToString() + "-" + Math.Round(stats.maxDmg * entanglingShot3dmg).ToString() + entanglingShot3_2;
                abilityRune4.Text = entanglingShot4;
                abilityRune5.Text = entanglingShot5;
                abilityRune6.Text = entanglingShot6;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Deadly Reach";
                abilityRune1.Text = deadlyReach1_1 + Math.Round(stats.minDmg * deadlyReach1dmg).ToString() + "-" + Math.Round(stats.maxDmg * deadlyReach1dmg).ToString() + deadlyReach1_2;
                abilityRune2.Text = deadlyReach2;
                abilityRune3.Text = deadlyReach3;
                abilityRune4.Text = deadlyReach4_1 + Math.Round(stats.minDmg * deadlyReach4dmg).ToString() + "-" + Math.Round(stats.maxDmg * deadlyReach4dmg).ToString() + deadlyReach4_2;
                abilityRune5.Text = deadlyReach5;
                abilityRune6.Text = deadlyReach6;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Corpse Spiders";
                abilityRune1.Text = corpseSpiders1_1 + Math.Round(stats.minDmg * corpseSpiders1dmg).ToString() + "-" + Math.Round(stats.maxDmg * corpseSpiders1dmg).ToString() + corpseSpiders1_2;
                abilityRune2.Text = corpseSpiders2_1 + Math.Round(stats.minDmg * corpseSpiders2dmg).ToString() + "-" + Math.Round(stats.maxDmg * corpseSpiders2dmg).ToString() + corpseSpiders2_2;
                abilityRune3.Text = corpseSpiders3_1 + Math.Round(stats.minDmg * corpseSpiders3dmg).ToString() + "-" + Math.Round(stats.maxDmg * corpseSpiders3dmg).ToString() + corpseSpiders3_2;
                abilityRune4.Text = corpseSpiders4;
                abilityRune5.Text = corpseSpiders5;
                abilityRune6.Text = corpseSpiders6_1 + Math.Round(stats.minDmg * corpseSpiders6dmg).ToString() + "-" + Math.Round(stats.maxDmg * corpseSpiders6dmg).ToString() + corpseSpiders6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Shock Pulse";
                abilityRune1.Text = shockPulse1_1 + Math.Round(stats.minDmg * shockPulse1dmg).ToString() + "-" + Math.Round(stats.maxDmg * shockPulse1dmg).ToString() + shockPulse1_2;
                abilityRune2.Text = shockPulse2_1 + Math.Round(stats.minDmg * shockPulse2dmg).ToString() + "-" + Math.Round(stats.maxDmg * shockPulse2dmg).ToString() + shockPulse2_2;
                abilityRune3.Text = shockPulse3_1 + Math.Round(stats.minDmg * shockPulse3dmg).ToString() + "-" + Math.Round(stats.maxDmg * shockPulse3dmg).ToString() + shockPulse3_2;
                abilityRune4.Text = shockPulse4_1 + Math.Round(stats.minDmg * shockPulse4dmg).ToString() + "-" + Math.Round(stats.maxDmg * shockPulse4dmg).ToString() + shockPulse4_2;
                abilityRune5.Text = shockPulse5;
                abilityRune6.Text = shockPulse6_1 + Math.Round(stats.minDmg * shockPulse6dmg).ToString() + "-" + Math.Round(stats.maxDmg * shockPulse6dmg).ToString() + shockPulse6_2;
            }
            #endregion
        }

        private void ability3_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Frenzy";
                abilityRune1.Text = frenzy1_1 + Math.Round(stats.minDmg * frenzyDmg).ToString() + "-" + Math.Round(stats.maxDmg * frenzyDmg).ToString() + frenzy1_2;
                abilityRune2.Text = frenzy2_1 + Math.Round(stats.minDmg * frenzyDmg).ToString() + "-" + Math.Round(stats.maxDmg * frenzyDmg).ToString() + frenzy2_2;
                abilityRune3.Text = frenzy3_1 + Math.Round(stats.maxHP * frenzy3HP).ToString() + frenzy3_2;
                abilityRune4.Text = frenzy4;
                abilityRune5.Text = frenzy5;
                abilityRune6.Text = frenzy6;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Bola Shot";
                abilityRune1.Text = bolaShot1_1 + Math.Round(stats.minDmg * bolaShot1dmg1).ToString() + "-" + Math.Round(stats.maxDmg * bolaShot1dmg1).ToString() + bolaShot1_2 + Math.Round(stats.minDmg * bolaShot1dmg2) + "-" + Math.Round(stats.maxDmg * bolaShot1dmg2) + bolaShot1_3;
                abilityRune2.Text = bolaShot2;
                abilityRune3.Text = bolaShot3_1 + Math.Round(stats.minDmg * bolaShot3dmg).ToString() + "-" + Math.Round(stats.maxDmg * bolaShot3dmg).ToString() + bolaShot3_2;
                abilityRune4.Text = bolaShot4_1 + Math.Round(stats.minDmg * bolaShot4dmg).ToString() + "-" + Math.Round(stats.maxDmg * bolaShot4dmg).ToString() + bolaShot4_2;
                abilityRune5.Text = bolaShot5;
                abilityRune6.Text = bolaShot6_1 + Math.Round(stats.minDmg * bolaShot6dmg1).ToString() + "-" + Math.Round(stats.maxDmg * bolaShot6dmg1).ToString() + bolaShot6_2 + Math.Round(stats.minDmg * bolaShot6dmg2) + "-" + Math.Round(stats.maxDmg * bolaShot6dmg2) + bolaShot6_3;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Crippling Wave";
                abilityRune1.Text = cripplingWave1_1 + Math.Round(stats.minDmg * cripplingWave1dmg).ToString() + "-" + Math.Round(stats.maxDmg * cripplingWave1dmg).ToString() + cripplingWave1_2;
                abilityRune2.Text = cripplingWave2_1 + Math.Round(stats.minDmg * cripplingWave2dmg).ToString() + "-" + Math.Round(stats.maxDmg * cripplingWave2dmg).ToString() + cripplingWave2_2;
                abilityRune3.Text = cripplingWave3;
                abilityRune4.Text = cripplingWave4;
                abilityRune5.Text = cripplingWave5;
                abilityRune6.Text = cripplingWave6;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Plague of Toads";
                abilityRune1.Text = plagueToads1_1 + Math.Round(stats.minDmg * plagueToads1dmg).ToString() + "-" + Math.Round(stats.maxDmg * plagueToads1dmg).ToString() + plagueToads1_2;
                abilityRune2.Text = plagueToads2_1 + Math.Round(stats.minDmg * plagueToads2dmg).ToString() + "-" + Math.Round(stats.maxDmg * plagueToads2dmg).ToString() + plagueToads2_2;
                abilityRune3.Text = plagueToads3_1 + Math.Round(stats.minDmg * plagueToads3dmg).ToString() + "-" + Math.Round(stats.maxDmg * plagueToads3dmg).ToString() + plagueToads3_2;
                abilityRune4.Text = plagueToads4_1 + Math.Round(stats.minDmg * plagueToads4dmg).ToString() + "-" + Math.Round(stats.maxDmg * plagueToads4dmg).ToString() + plagueToads4_2;
                abilityRune5.Text = plagueToads5_1 + Math.Round(stats.minDmg * plagueToads5dmg).ToString() + "-" + Math.Round(stats.maxDmg * plagueToads5dmg).ToString() + plagueToads5_2;
                abilityRune6.Text = plagueToads6;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Spectral Blades";
                abilityRune1.Text = spectralBlade1_1 + Math.Round(stats.minDmg * spectralBlade1dmg).ToString() + "-" + Math.Round(stats.maxDmg * spectralBlade1dmg).ToString() + spectralBlade1_2;
                abilityRune2.Text = spectralBlade2_1 + Math.Round(stats.minDmg * spectralBlade2dmg).ToString() + "-" + Math.Round(stats.maxDmg * spectralBlade2dmg).ToString() + spectralBlade2_2;
                abilityRune3.Text = spectralBlade3;
                abilityRune4.Text = spectralBlade4;
                abilityRune5.Text = spectralBlade5;
                abilityRune6.Text = spectralBlade6;
            }
            #endregion
        }

        private void ability4_MouseEnter(object sender, EventArgs e)
        {
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Grenades";
                abilityRune1.Text = grenades1_1 + Math.Round(stats.minDmg * grenades1dmg).ToString() + "-" + Math.Round(stats.maxDmg * grenades1dmg).ToString() + grenades1_2;
                abilityRune2.Text = grenades2;
                abilityRune3.Text = grenades3_1 + Math.Round(stats.minDmg * grenades3dmg).ToString() + "-" + Math.Round(stats.maxDmg * grenades3dmg).ToString() + grenades3_2;
                abilityRune4.Text = grenades4_1 + Math.Round(stats.minDmg * grenades4dmg).ToString() + "-" + Math.Round(stats.maxDmg * grenades4dmg).ToString() + grenades4_2;
                abilityRune5.Text = grenades5;
                abilityRune6.Text = grenades6_1 + Math.Round(stats.minDmg * grenades6dmg1).ToString() + "-" + Math.Round(stats.maxDmg * grenades6dmg1).ToString() + grenades6_2 + Math.Round(stats.minDmg * grenades6dmg2).ToString() + "-" + Math.Round(stats.maxDmg * grenades6dmg2).ToString() + grenades6_3;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Way of the Hundred Fists";
                abilityRune1.Text = wayOfTheHundredFists1_1 + Math.Round(stats.minDmg * wayOfTheHundredFists1dmg).ToString() + "-" + Math.Round(stats.maxDmg * wayOfTheHundredFists1dmg).ToString() + wayOfTheHundredFists1_2;
                abilityRune2.Text = wayOfTheHundredFists2;
                abilityRune3.Text = wayOfTheHundredFists3;
                abilityRune4.Text = wayOfTheHundredFists4_1 + Math.Round(stats.minDmg * wayOfTheHundredFists4dmg).ToString() + "-" + Math.Round(stats.maxDmg * wayOfTheHundredFists4dmg).ToString() + wayOfTheHundredFists4_2;
                abilityRune5.Text = wayOfTheHundredFists5;
                abilityRune6.Text = wayOfTheHundredFists6_1 + Math.Round(stats.minDmg * wayOfTheHundredFists6dmg).ToString() + "-" + Math.Round(stats.maxDmg * wayOfTheHundredFists6dmg).ToString() + wayOfTheHundredFists6_2;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Fire Bomb";
                abilityRune1.Text = fireBomb1_1 + Math.Round(stats.minDmg * fireBomb1dmg).ToString() + "-" + Math.Round(stats.maxDmg * fireBomb1dmg).ToString() + fireBomb1_2;
                abilityRune2.Text = fireBomb2;
                abilityRune3.Text = fireBomb3;
                abilityRune4.Text = fireBomb4_1 + Math.Round(stats.minDmg * fireBomb4dmg).ToString() + "-" + Math.Round(stats.maxDmg * fireBomb4dmg).ToString() + fireBomb4_2;
                abilityRune5.Text = fireBomb5_1 + Math.Round(stats.minDmg * fireBomb5dmg).ToString() + "-" + Math.Round(stats.maxDmg * fireBomb5dmg).ToString() + fireBomb5_2;
                abilityRune6.Text = fireBomb6_1 + Math.Round(stats.minDmg * fireBomb6dmg).ToString() + "-" + Math.Round(stats.maxDmg * fireBomb6dmg).ToString() + fireBomb6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Electrocute";
                abilityRune1.Text = electrocute1_1 + Math.Round(stats.minDmg * electrocute1dmg).ToString() + "-" + Math.Round(stats.maxDmg * electrocute1dmg).ToString() + electrocute1_2;
                abilityRune2.Text = electrocute2;
                abilityRune3.Text = electrocute3_1 + Math.Round(stats.minDmg * electrocute3dmg).ToString() + "-" + Math.Round(stats.maxDmg * electrocute3dmg).ToString() + electrocute3_2;
                abilityRune4.Text = electrocute4_1 + Math.Round(stats.minDmg * electrocute4dmg).ToString() + "-" + Math.Round(stats.maxDmg * electrocute4dmg).ToString() + electrocute4_2;
                abilityRune5.Text = electrocute5;
                abilityRune6.Text = electrocute6_1 + Math.Round(stats.minDmg * electrocute6dmg).ToString() + "-" + Math.Round(stats.maxDmg * electrocute6dmg).ToString() + electrocute6_2;
            }
            #endregion
        }

        private void ability6_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Hammer of the Ancients";
                abilityRune1.Text = hoA1_1 + Math.Round(stats.minDmg * hoA1dmg).ToString() + "-" + Math.Round(stats.maxDmg * hoA1dmg).ToString() + hoA1_2;
                abilityRune2.Text = hoA2_1 + Math.Round(stats.minDmg * hoA2dmg).ToString() + "-" + Math.Round(stats.maxDmg * hoA2dmg).ToString() + hoA2_2;
                abilityRune3.Text = hoA3_1 + Math.Round(stats.minDmg * hoA3dmg).ToString() + "-" + Math.Round(stats.maxDmg * hoA3dmg).ToString() + hoA3_2;
                abilityRune4.Text = hoA4;
                abilityRune5.Text = hoA5;
                abilityRune6.Text = hoA6;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Impale";
                abilityRune1.Text = impale1_1 + Math.Round(stats.minDmg * impale1dmg).ToString() + "-" + Math.Round(stats.maxDmg * impale1dmg).ToString() + impale1_2;
                abilityRune2.Text = impale2;
                abilityRune3.Text = impale3_1 + Math.Round(stats.minDmg * impale3dmg).ToString() + "-" + Math.Round(stats.maxDmg * impale3dmg).ToString() + impale3_2;
                abilityRune4.Text = impale4;
                abilityRune5.Text = impale5_1 + Math.Round(stats.minDmg * impale5dmg).ToString() + "-" + Math.Round(stats.maxDmg * impale5dmg).ToString() + impale5_2;
                abilityRune6.Text = impale6;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Lashing Tail Kick";
                abilityRune1.Text = lashingTailKick1_1 + Math.Round(stats.minDmg * lashingTailKick1dmg).ToString() + "-" + Math.Round(stats.maxDmg * lashingTailKick1dmg).ToString() + lashingTailKick1_2;
                abilityRune2.Text = lashingTailKick2_1 + Math.Round(stats.minDmg * lashingTailKick2dmg).ToString() + "-" + Math.Round(stats.maxDmg * lashingTailKick2dmg).ToString() + lashingTailKick2_2;
                abilityRune3.Text = lashingTailKick3;
                abilityRune4.Text = lashingTailKick4_1 + Math.Round(stats.minDmg * lashingTailKick4dmg).ToString() + "-" + Math.Round(stats.maxDmg * lashingTailKick4dmg).ToString() + lashingTailKick4_2;
                abilityRune5.Text = lashingTailKick5;
                abilityRune6.Text = lashingTailKick6;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Grasp of the Dead";
                abilityRune1.Text = graspDead1_1 + Math.Round(stats.minDmg * graspDead1dmg).ToString() + "-" + Math.Round(stats.maxDmg * graspDead1dmg).ToString() + graspDead1_2;
                abilityRune2.Text = graspDead2;
                abilityRune3.Text = graspDead3_1 + Math.Round(stats.minDmg * graspDead3dmg).ToString() + "-" + Math.Round(stats.maxDmg * graspDead3dmg).ToString() + graspDead3_2;
                abilityRune4.Text = graspDead4;
                abilityRune5.Text = graspDead5;
                abilityRune6.Text = graspDead6_1 + Math.Round(stats.minDmg * graspDead6dmg).ToString() + "-" + Math.Round(stats.maxDmg * graspDead6dmg).ToString() + graspDead6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Ray of Frost";
                abilityRune1.Text = frostRay1_1 + Math.Round(stats.minDmg * frostRay1dmg).ToString() + "-" + Math.Round(stats.maxDmg * frostRay1dmg).ToString() + frostRay1_2;
                abilityRune2.Text = frostRay2;
                abilityRune3.Text = frostRay3_1 + Math.Round(stats.minDmg * frostRay3dmg).ToString() + "-" + Math.Round(stats.maxDmg * frostRay3dmg).ToString() + frostRay3_2;
                abilityRune4.Text = frostRay4;
                abilityRune5.Text = frostRay5_1 + Math.Round(stats.minDmg * frostRay5dmg).ToString() + "-" + Math.Round(stats.maxDmg * frostRay5dmg).ToString() + frostRay5_2;
                abilityRune6.Text = frostRay6_1 + Math.Round(stats.minDmg * frostRay6dmg).ToString() + "-" + Math.Round(stats.maxDmg * frostRay6dmg).ToString() + frostRay6_2;
            }
            #endregion
        }

        private void ability7_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Rend";
                abilityRune1.Text = rend1_1 + Math.Round(stats.minDmg * rend1dmg).ToString() + "-" + Math.Round(stats.maxDmg * rend1dmg).ToString() + rend1_2;
                abilityRune2.Text = rend2;
                abilityRune3.Text = rend3;
                abilityRune4.Text = rend4_1 + Math.Round(stats.minDmg * rend4dmg).ToString() + "-" + Math.Round(stats.maxDmg * rend4dmg).ToString() + rend4_2;
                abilityRune5.Text = rend5;
                abilityRune6.Text = rend6_1 + Math.Round(stats.minDmg * rend6dmg).ToString() + "-" + Math.Round(stats.maxDmg * rend6dmg).ToString() + rend6_2;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Rapid Fire";
                abilityRune1.Text = rapidFire1_1 + Math.Round(stats.minDmg * rapidFire1dmg).ToString() + "-" + Math.Round(stats.maxDmg * rapidFire1dmg).ToString() + rapidFire1_2;
                abilityRune2.Text = rapidFire2;
                abilityRune3.Text = rapidFire3;
                abilityRune4.Text = rapidFire4_1 + Math.Round(stats.minDmg * rapidFire4dmg).ToString() + "-" + Math.Round(stats.maxDmg * rapidFire4dmg).ToString() + rapidFire4_2;
                abilityRune5.Text = rapidFire5;
                abilityRune6.Text = rapidFire6_1 + Math.Round(stats.minDmg * rapidFire6dmg).ToString() + "-" + Math.Round(stats.maxDmg * rapidFire6dmg).ToString() + rapidFire6_2;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Tempest Rush";
                abilityRune1.Text = tempestRush1_1 + Math.Round(stats.minDmg * tempestRush1dmg).ToString() + "-" + Math.Round(stats.maxDmg * tempestRush1dmg).ToString() + tempestRush1_2;
                abilityRune2.Text = tempestRush2;
                abilityRune3.Text = tempestRush3;
                abilityRune4.Text = tempestRush4;
                abilityRune5.Text = tempestRush5;
                abilityRune6.Text = tempestRush6;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Firebats";
                abilityRune1.Text = fireBats1_1 + Math.Round(stats.minDmg * fireBats1dmg).ToString() + "-" + Math.Round(stats.maxDmg * fireBats1dmg).ToString() + fireBats1_2;
                abilityRune2.Text = fireBats2_1 + Math.Round(stats.minDmg * fireBats2dmg).ToString() + "-" + Math.Round(stats.maxDmg * fireBats2dmg).ToString() + fireBats2_2;
                abilityRune3.Text = fireBats3;
                abilityRune4.Text = fireBats4_1 + Math.Round(stats.minDmg * fireBats4dmg).ToString() + "-" + Math.Round(stats.maxDmg * fireBats4dmg).ToString() + fireBats4_2;
                abilityRune5.Text = fireBats5_1 + Math.Round(stats.minDmg * fireBats5dmg).ToString() + "-" + Math.Round(stats.maxDmg * fireBats5dmg).ToString() + fireBats5_2;
                abilityRune6.Text = fireBats6_1 + Math.Round(stats.minDmg * fireBats6dmg).ToString() + "-" + Math.Round(stats.maxDmg * fireBats6dmg).ToString() + fireBats6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Arcane Orb";
                abilityRune1.Text = arcaneOrb1_1 + Math.Round(stats.minDmg * arcaneOrb1dmg).ToString() + "-" + Math.Round(stats.maxDmg * arcaneOrb1dmg).ToString() + arcaneOrb1_2;
                abilityRune2.Text = arcaneOrb2_1 + Math.Round(stats.minDmg * arcaneOrb2dmg).ToString() + "-" + Math.Round(stats.maxDmg * arcaneOrb2dmg).ToString() + arcaneOrb2_2;
                abilityRune3.Text = arcaneOrb3_1 + Math.Round(stats.minDmg * arcaneOrb3dmg).ToString() + "-" + Math.Round(stats.maxDmg * arcaneOrb3dmg).ToString() + arcaneOrb3_2;
                abilityRune4.Text = arcaneOrb4_1 + Math.Round(stats.minDmg * arcaneOrb4dmg).ToString() + "-" + Math.Round(stats.maxDmg * arcaneOrb4dmg).ToString() + arcaneOrb4_2;
                abilityRune5.Text = arcaneOrb5;
                abilityRune6.Text = arcaneOrb6;
            }
            #endregion
        }

        private void ability8_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Seismic Slam";
                abilityRune1.Text = slam1_1 + Math.Round(stats.minDmg * slam1dmg).ToString() + "-" + Math.Round(stats.maxDmg * slam1dmg).ToString() + slam1_2;
                abilityRune2.Text = slam2;
                abilityRune3.Text = slam3_1 + Math.Round(stats.minDmg * slam3dmg).ToString() + "-" + Math.Round(stats.maxDmg * slam3dmg).ToString() + slam3_2;
                abilityRune4.Text = slam4_1 + Math.Round(stats.minDmg * slam4dmg).ToString() + "-" + Math.Round(stats.maxDmg * slam4dmg).ToString() + slam4_2;
                abilityRune5.Text = slam5;
                abilityRune6.Text = slam6_1 + Math.Round(stats.minDmg * slam6dmg).ToString() + "-" + Math.Round(stats.maxDmg * slam6dmg).ToString() + slam6_2;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Chakram";
                abilityRune1.Text = chakram1_1 + Math.Round(stats.minDmg * chakram1dmg).ToString() + "-" + Math.Round(stats.maxDmg * chakram1dmg).ToString() + chakram1_2;
                abilityRune2.Text = chakram2_1 + Math.Round(stats.minDmg * chakram2dmg).ToString() + "-" + Math.Round(stats.maxDmg * chakram2dmg).ToString() + chakram2_2;
                abilityRune3.Text = chakram3_1 + Math.Round(stats.minDmg * chakram3dmg).ToString() + "-" + Math.Round(stats.maxDmg * chakram3dmg).ToString() + chakram3_2;
                abilityRune4.Text = chakram4_1 + Math.Round(stats.minDmg * chakram4dmg).ToString() + "-" + Math.Round(stats.maxDmg * chakram4dmg).ToString() + chakram4_2;
                abilityRune5.Text = chakram5_1 + Math.Round(stats.minDmg * chakram5dmg).ToString() + "-" + Math.Round(stats.maxDmg * chakram5dmg).ToString() + chakram5_2;
                abilityRune6.Text = chakram6_1 + Math.Round(stats.minDmg * chakram6dmg).ToString() + "-" + Math.Round(stats.maxDmg * chakram6dmg).ToString() + chakram6_2;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Wave of Light";
                abilityRune1.Text = waveOfLight1_1 + Math.Round(stats.minDmg * waveOfLight1dmg1).ToString() + "-" + Math.Round(stats.maxDmg * waveOfLight1dmg1).ToString() + waveOfLight1_2 + Math.Round(stats.minDmg * waveOfLight1dmg2).ToString() + "-" + Math.Round(stats.maxDmg * waveOfLight1dmg2).ToString() + waveOfLight1_3;
                abilityRune2.Text = waveOfLight2_1 + Math.Round(stats.minDmg * waveOfLight2dmg).ToString() + "-" + Math.Round(stats.maxDmg * waveOfLight2dmg).ToString() + waveOfLight2_2;
                abilityRune3.Text = waveOfLight3_1 + Math.Round(stats.minDmg * waveOfLight3dmg).ToString() + "-" + Math.Round(stats.maxDmg * waveOfLight3dmg).ToString() + waveOfLight3_2;
                abilityRune4.Text = waveOfLight4;
                abilityRune5.Text = waveOfLight5;
                abilityRune6.Text = waveOfLight6_1 + Math.Round(stats.minDmg * waveOfLight6dmg).ToString() + "-" + Math.Round(stats.maxDmg * waveOfLight6dmg).ToString() + waveOfLight6_2 + Math.Round(stats.minDmg * waveOfLight6dmg).ToString() + "-" + Math.Round(stats.maxDmg * waveOfLight6dmg).ToString() + waveOfLight6_3;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Haunt";
                abilityRune1.Text = haunt1_1 + Math.Round(stats.minDmg * haunt1dmg).ToString() + "-" + Math.Round(stats.maxDmg * haunt1dmg).ToString() + haunt1_2;
                abilityRune2.Text = haunt2;
                abilityRune3.Text = haunt3_1 + Math.Round(stats.minDmg * haunt3dmg).ToString() + "-" + Math.Round(stats.maxDmg * haunt3dmg).ToString() + haunt3_2;
                abilityRune4.Text = haunt4;
                abilityRune5.Text = haunt5;
                abilityRune6.Text = haunt6;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Arcane torrent";
                abilityRune1.Text = arcaneTorrent1_1 + Math.Round(stats.minDmg * arcaneTorrent1dmg).ToString() + "-" + Math.Round(stats.maxDmg * arcaneTorrent1dmg).ToString() + arcaneTorrent1_2;
                abilityRune2.Text = arcaneTorrent2;
                abilityRune3.Text = arcaneTorrent3_1 + Math.Round(stats.minDmg * arcaneTorrent3dmg).ToString() + "-" + Math.Round(stats.maxDmg * arcaneTorrent3dmg).ToString() + arcaneTorrent3_2;
                abilityRune4.Text = arcaneTorrent4_1 + Math.Round(stats.minDmg * arcaneTorrent4dmg).ToString() + "-" + Math.Round(stats.maxDmg * arcaneTorrent4dmg).ToString() + arcaneTorrent4_2;
                abilityRune5.Text = arcaneTorrent5;
                abilityRune6.Text = arcaneTorrent6_1 + Math.Round(stats.minDmg * arcaneTorrent6dmg).ToString() + "-" + Math.Round(stats.maxDmg * arcaneTorrent6dmg).ToString() + arcaneTorrent6_2;
            }
            #endregion
        }

        private void ability9_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Whirlwind";
                abilityRune1.Text = whirlwind1_1 + Math.Round(stats.minDmg * whirlwind1dmg).ToString() + "-" + Math.Round(stats.maxDmg * whirlwind1dmg).ToString() + whirlwind1_2;
                abilityRune2.Text = whirlwind2_1 + Math.Round(stats.minDmg * whirlwind2dmg).ToString() + "-" + Math.Round(stats.maxDmg * whirlwind2dmg).ToString() + whirlwind2_2;
                abilityRune3.Text = whirlwind3;
                abilityRune4.Text = whirlwind4_1 + Math.Round(stats.maxHP * whirlwind4HP).ToString() + whirlwind4_2;
                abilityRune5.Text = whirlwind5;
                abilityRune6.Text = whirlwind6_1 + Math.Round(stats.minDmg * whirlwind6dmg).ToString() + "-" + Math.Round(stats.maxDmg * whirlwind6dmg).ToString() + whirlwind6_2;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Elemental Arrow";
                abilityRune1.Text = elementalArrow1_1 + Math.Round(stats.minDmg * elementalArrow1dmg).ToString() + "-" + Math.Round(stats.maxDmg * elementalArrow1dmg).ToString() + elementalArrow1_2;
                abilityRune2.Text = elementalArrow2_1 + Math.Round(stats.minDmg * elementalArrow2dmg).ToString() + "-" + Math.Round(stats.maxDmg * elementalArrow2dmg).ToString() + elementalArrow2_2;
                abilityRune3.Text = elementalArrow3_1 + Math.Round(stats.minDmg * elementalArrow3dmg).ToString() + "-" + Math.Round(stats.maxDmg * elementalArrow3dmg).ToString() + elementalArrow3_2;
                abilityRune4.Text = elementalArrow4;
                abilityRune5.Text = elementalArrow5;
                abilityRune6.Text = elementalArrow6_1 + Math.Round(stats.minDmg * elementalArrow6dmg).ToString() + "-" + Math.Round(stats.maxDmg * elementalArrow6dmg).ToString() + elementalArrow6_2;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Locust Swarm";
                abilityRune1.Text = locustSwarm1_1 + Math.Round(stats.minDmg * locustSwarm1dmg).ToString() + "-" + Math.Round(stats.maxDmg * locustSwarm1dmg).ToString() + locustSwarm1_2;
                abilityRune2.Text = locustSwarm2;
                abilityRune3.Text = locustSwarm3;
                abilityRune4.Text = locustSwarm4;
                abilityRune5.Text = locustSwarm5_1 + Math.Round(stats.minDmg * locustSwarm5dmg).ToString() + "-" + Math.Round(stats.maxDmg * locustSwarm5dmg).ToString() + locustSwarm5_2;
                abilityRune6.Text = locustSwarm6_1 + Math.Round(stats.minDmg * locustSwarm6dmg).ToString() + "-" + Math.Round(stats.maxDmg * locustSwarm6dmg).ToString() + locustSwarm6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Disintegrate";
                abilityRune1.Text = disintegrate1_1 + Math.Round(stats.minDmg * disintegrate1dmg).ToString() + "-" + Math.Round(stats.maxDmg * disintegrate1dmg).ToString() + disintegrate1_2;
                abilityRune2.Text = disintegrate2;
                abilityRune3.Text = disintegrate3_1 + Math.Round(stats.minDmg * disintegrate3dmg).ToString() + "-" + Math.Round(stats.maxDmg * disintegrate3dmg).ToString() + disintegrate3_2;
                abilityRune4.Text = disintegrate4_1 + Math.Round(stats.minDmg * disintegrate4dmg).ToString() + "-" + Math.Round(stats.maxDmg * disintegrate4dmg).ToString() + disintegrate4_2;
                abilityRune5.Text = disintegrate5_1 + Math.Round(stats.minDmg * disintegrate5dmg).ToString() + "-" + Math.Round(stats.maxDmg * disintegrate5dmg).ToString() + disintegrate5_2;
                abilityRune6.Text = disintegrate6_1 + Math.Round(stats.minDmg * disintegrate6dmg).ToString() + "-" + Math.Round(stats.maxDmg * disintegrate6dmg).ToString() + disintegrate6_2;
            }
            #endregion
        }

        private void ability11_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Ground Stomp";
                abilityRune1.Text = stomp1;
                abilityRune2.Text = stomp2;
                abilityRune3.Text = stomp3;
                abilityRune4.Text = stomp4_1 + Math.Round(stats.minDmg * stomp4dmg).ToString() + "-" + Math.Round(stats.maxDmg * stomp4dmg).ToString() + stomp4_2;
                abilityRune5.Text = stomp5;
                abilityRune6.Text = stomp6_1 + Math.Round(stats.minDmg * stomp6dmg).ToString() + "-" + Math.Round(stats.maxDmg * stomp6dmg).ToString() + stomp6_2;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Caltrops";
                abilityRune1.Text = caltrops1;
                abilityRune2.Text = caltrops2;
                abilityRune3.Text = caltrops3;
                abilityRune4.Text = caltrops4_1 + Math.Round(stats.minDmg * caltrops4dmg).ToString() + "-" + Math.Round(stats.maxDmg * caltrops4dmg).ToString() + caltrops4_2;
                abilityRune5.Text = caltrops5;
                abilityRune6.Text = caltrops6;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Blinding Flash";
                abilityRune1.Text = blindingFlash1;
                abilityRune2.Text = blindingFlash2;
                abilityRune3.Text = blindingFlash3;
                abilityRune4.Text = blindingFlash4;
                abilityRune5.Text = blindingFlash5;
                abilityRune6.Text = blindingFlash6_1 + Math.Round(stats.minDmg * blindingFlash6dmg).ToString() + "-" + Math.Round(stats.maxDmg * blindingFlash6dmg).ToString() + blindingFlash6_2;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Summon Zombie Dogs";
                abilityRune1.Text = summonDogs1_1 + Math.Round(stats.minDmg * summonDogs1dmg).ToString() + "-" + Math.Round(stats.maxDmg * summonDogs1dmg).ToString() + summonDogs1_2;
                abilityRune2.Text = summonDogs2_1 + Math.Round(stats.minDmg * summonDogs2dmg).ToString() + "-" + Math.Round(stats.maxDmg * summonDogs2dmg).ToString() + summonDogs2_2;
                abilityRune3.Text = summonDogs3;
                abilityRune4.Text = summonDogs4;
                abilityRune5.Text = summonDogs5_1 + Math.Round(stats.minDmg * summonDogs5dmg).ToString() + "-" + Math.Round(stats.maxDmg * summonDogs5dmg).ToString() + summonDogs5_2;
                abilityRune6.Text = summonDogs6;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Frost Nova";
                abilityRune1.Text = frostNova1;
                abilityRune2.Text = frostNova2;
                abilityRune3.Text = frostNova3;
                abilityRune4.Text = frostNova4_1 + Math.Round(stats.minDmg * frostNova4dmg).ToString() + "-" + Math.Round(stats.maxDmg * frostNova4dmg).ToString() + frostNova4_2;
                abilityRune5.Text = frostNova5;
                abilityRune6.Text = frostNova6;
            }
            #endregion
        }

        private void ability12_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Leap";
                abilityRune1.Text = leap1_1 + Math.Round(stats.minDmg * leap1dmg).ToString() + "-" + Math.Round(stats.maxDmg * leap1dmg).ToString() + leap1_2;
                abilityRune2.Text = leap2_1 + Math.Round(stats.totalArmor * leap2armor).ToString() + leap2_2;
                abilityRune3.Text = leap3;
                abilityRune4.Text = leap4;
                abilityRune5.Text = leap5;
                abilityRune6.Text = leap6;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Smoke Screen";
                abilityRune1.Text = smokeScreen1;
                abilityRune2.Text = smokeScreen2;
                abilityRune3.Text = smokeScreen3;
                abilityRune4.Text = smokeScreen4;
                abilityRune5.Text = smokeScreen5;
                abilityRune6.Text = smokeScreen6_1 + Math.Round(stats.minDmg * smokeScreen6dmg).ToString() + "-" + Math.Round(stats.maxDmg * smokeScreen6dmg).ToString() + smokeScreen6_2;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Breath of Heaven";
                abilityRune1.Text = breathOfHeaven1;
                abilityRune2.Text = breathOfHeaven2_1 + Math.Round(stats.minDmg * breathOfHeaven2dmg).ToString() + "-" + Math.Round(stats.maxDmg * breathOfHeaven2dmg).ToString() + breathOfHeaven2_2;
                abilityRune3.Text = breathOfHeaven3;
                abilityRune4.Text = breathOfHeaven4;
                abilityRune5.Text = breathOfHeaven5;
                abilityRune6.Text = breathOfHeaven6;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Horrify";
                abilityRune1.Text = horrify1;
                abilityRune2.Text = horrify2;
                abilityRune3.Text = horrify3;
                abilityRune4.Text = horrify4;
                abilityRune5.Text = horrify5;
                abilityRune6.Text = horrify6;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Diamond Skin";
                abilityRune1.Text = diamondSkin1;
                abilityRune2.Text = diamondSkin2;
                abilityRune3.Text = diamondSkin3;
                abilityRune4.Text = diamondSkin4;
                abilityRune5.Text = diamondSkin5;
                abilityRune6.Text = diamondSkin6_1 + Math.Round(stats.minDmg * diamondSkin6dmg).ToString() + "-" + Math.Round(stats.maxDmg * diamondSkin6dmg).ToString() + diamondSkin6_2;
            }
            #endregion
        }

        private void ability13_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Sprint";
                abilityRune1.Text = sprint1;
                abilityRune2.Text = sprint2;
                abilityRune3.Text = sprint3_1 + Math.Round(stats.minDmg * sprint3dmg).ToString() + "-" + Math.Round(stats.maxDmg * sprint3dmg).ToString() + sprint3_2;
                abilityRune4.Text = sprint4;
                abilityRune5.Text = sprint5_1 + Math.Round(stats.minDmg * sprint5dmg).ToString() + "-" + Math.Round(stats.maxDmg * sprint5dmg).ToString() + sprint5_2;
                abilityRune6.Text = sprint6;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Shadow Power";
                abilityRune1.Text = shadowPower1;
                abilityRune2.Text = shadowPower2;
                abilityRune3.Text = shadowPower3;
                abilityRune4.Text = shadowPower4;
                abilityRune5.Text = shadowPower5;
                abilityRune6.Text = shadowPower6;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Serenity";
                abilityRune1.Text = serenity1;
                abilityRune2.Text = serenity2;
                abilityRune3.Text = serenity3_1 + Math.Round(stats.maxHP * serenity3HP).ToString() + serenity3_2;
                abilityRune4.Text = serenity4;
                abilityRune5.Text = serenity5;
                abilityRune6.Text = serenity6_1+stats.maxHP+serenity6_2;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Spirit Walk";

                abilityRune1.Text = spiritWalk1_1 + Math.Round(stats.maxHP * spiritWalk1HP).ToString() + spiritWalk1_2;
                abilityRune2.Text = spiritWalk2;
                abilityRune3.Text = spiritWalk3;
                abilityRune4.Text = spiritWalk4_1 + Math.Round(stats.minDmg * spiritWalk4dmg).ToString() + "-" + Math.Round(stats.maxDmg * spiritWalk4dmg).ToString() + spiritWalk4_2;
                abilityRune5.Text = spiritWalk5_1 + Math.Round(stats.minDmg * spiritWalk5dmg).ToString() + "-" + Math.Round(stats.maxDmg * spiritWalk5dmg).ToString() + spiritWalk5_2;
                abilityRune6.Text = spiritWalk6_1 + Math.Round(stats.maxHP * spiritWalk6HP).ToString() + spiritWalk6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Slow Time";
                abilityRune1.Text = slowTime1;
                abilityRune2.Text = slowTime2;
                abilityRune3.Text = slowTime3;
                abilityRune4.Text = slowTime4;
                abilityRune5.Text = slowTime5;
                abilityRune6.Text = slowTime6;
            }
            #endregion
        }

        private void ability14_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Ignore Pain";
                abilityRune1.Text = ignorePain1;
                abilityRune2.Text = ignorePain2_1 + Math.Round(stats.minDmg * ignorePain2dmg).ToString() + "-" + Math.Round(stats.maxDmg * ignorePain2dmg).ToString() + ignorePain2_2;
                abilityRune3.Text = ignorePain3;
                abilityRune4.Text = ignorePain4;
                abilityRune5.Text = ignorePain5;
                abilityRune6.Text = ignorePain6_1 + stats.maxHP + ignorePain6_2;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Inner Sanctuary";
                abilityRune1.Text = innerSanctuary1;
                abilityRune2.Text = innerSanctuary2;
                abilityRune3.Text = innerSanctuary3;
                abilityRune4.Text = innerSanctuary4;
                abilityRune5.Text = innerSanctuary5;
                abilityRune6.Text = innerSanctuary6;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Hex";
                abilityRune1.Text = hex1;
                abilityRune2.Text = hex2;
                abilityRune3.Text = hex3;
                abilityRune4.Text = hex4_1 + Math.Round(stats.minDmg * hex4dmg).ToString() + "-" + Math.Round(stats.maxDmg * hex4dmg).ToString() + hex4_2;
                abilityRune5.Text = hex5_1 + Math.Round(stats.minDmg * hex5dmg).ToString() + "-" + Math.Round(stats.maxDmg * hex5dmg).ToString() + hex5_2;
                abilityRune6.Text = hex6_1 + Math.Round(stats.minDmg * hex6dmg).ToString() + "-" + Math.Round(stats.maxDmg * hex6dmg).ToString() + hex6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Teleport";
                abilityRune1.Text = teleport1;
                abilityRune2.Text = teleport2;
                abilityRune3.Text = teleport3;
                abilityRune4.Text = teleport4;
                abilityRune5.Text = teleport5;
                abilityRune6.Text = teleport6_1 + Math.Round(stats.minDmg * teleport6dmg).ToString() + "-" + Math.Round(stats.maxDmg * teleport6dmg).ToString() + teleport6_2;
            }
            #endregion
        }

        private void ability16_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Ancient Spear";
                abilityRune1.Text = spear1_1 + Math.Round(stats.minDmg * spear1dmg).ToString() + "-" + Math.Round(stats.maxDmg * spear1dmg).ToString() + spear1_2;
                abilityRune2.Text = spear2;
                abilityRune3.Text = spear3;
                abilityRune4.Text = spear4;
                abilityRune5.Text = spear5;
                abilityRune6.Text = spear6_1 + Math.Round(stats.minDmg * spear6dmg).ToString() + "-" + Math.Round(stats.maxDmg * spear6dmg).ToString() + spear6_2;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Vault";
                abilityRune1.Text = vault1;
                abilityRune2.Text = vault2_1 + Math.Round(stats.minDmg * vault2dmg).ToString() + "-" + Math.Round(stats.maxDmg * vault2dmg).ToString() + vault2_2;
                abilityRune3.Text = vault3;
                abilityRune4.Text = vault4;
                abilityRune5.Text = vault5;
                abilityRune6.Text = vault6_1 + Math.Round(stats.minDmg * vault6dmg).ToString() + "-" + Math.Round(stats.maxDmg * vault6dmg).ToString() + vault6_2;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Dashing Strike";
                abilityRune1.Text = dashingStrike1_1 + Math.Round(stats.minDmg * dashingStrike1dmg).ToString() + "-" + Math.Round(stats.maxDmg * dashingStrike1dmg).ToString() + dashingStrike1_2;
                abilityRune2.Text = dashingStrike2;
                abilityRune3.Text = dashingStrike3;
                abilityRune4.Text = dashingStrike4;
                abilityRune5.Text = dashingStrike5;
                abilityRune6.Text = dashingStrike6;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Soul Harvest";
                abilityRune1.Text = soulHarvest1;
                abilityRune2.Text = soulHarvest2;
                abilityRune3.Text = soulHarvest3;
                abilityRune4.Text = soulHarvest4;
                abilityRune5.Text = soulHarvest5;
                abilityRune6.Text = soulHarvest6_1 + Math.Round(stats.minDmg * soulHarvest6dmg).ToString() + "-" + Math.Round(stats.maxDmg * soulHarvest6dmg).ToString() + soulHarvest6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Wave of Force";
                abilityRune1.Text = forceWave1_1 + Math.Round(stats.minDmg * forceWave1dmg).ToString() + "-" + Math.Round(stats.maxDmg * forceWave1dmg).ToString() + forceWave1_2;
                abilityRune2.Text = forceWave2;
                abilityRune3.Text = forceWave3;
                abilityRune4.Text = forceWave4_1 + Math.Round(stats.minDmg * forceWave4dmg).ToString() + "-" + Math.Round(stats.maxDmg * forceWave4dmg).ToString() + forceWave4_2;
                abilityRune5.Text = forceWave5;
                abilityRune6.Text = forceWave6_1 + Math.Round(stats.minDmg * forceWave6dmg).ToString() + "-" + Math.Round(stats.maxDmg * forceWave6dmg).ToString() + forceWave6_2;
            }
            #endregion
        }

        private void ability17_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Revenge";
                abilityRune1.Text = revenge1_1 + Math.Round(stats.minDmg * revenge1dmg).ToString() + "-" + Math.Round(stats.maxDmg * revenge1dmg).ToString() + revenge1_2 + Math.Round(stats.maxHP * revenge1HP).ToString() + revenge1_3;
                abilityRune2.Text = revenge2_1 + Math.Round(stats.maxHP * revenge2HP).ToString() + revenge2_2;
                abilityRune3.Text = revenge3;
                abilityRune4.Text = revenge4_1 + Math.Round(stats.minDmg * revenge4dmg).ToString() + "-" + Math.Round(stats.maxDmg * revenge4dmg).ToString() + revenge4_2;
                abilityRune5.Text = revenge5;
                abilityRune6.Text = revenge6;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Preparation";
                abilityRune1.Text = preparation1;
                abilityRune2.Text = preparation2;
                abilityRune3.Text = preparation3;
                abilityRune4.Text = preparation4;
                abilityRune5.Text = preparation5;
                abilityRune6.Text = preparation6;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Exploding Palm";
                abilityRune1.Text = explodingPalm1_1 + Math.Round(stats.minDmg * explodingPalm1dmg).ToString() + "-" + Math.Round(stats.maxDmg * explodingPalm1dmg).ToString() + explodingPalm1_2;
                abilityRune2.Text = explodingPalm2;
                abilityRune3.Text = explodingPalm3;
                abilityRune4.Text = explodingPalm4;
                abilityRune5.Text = explodingPalm5_1 + Math.Round(stats.minDmg * explodingPalm5dmg).ToString() + "-" + Math.Round(stats.maxDmg * explodingPalm5dmg).ToString() + explodingPalm5_2;
                abilityRune6.Text = explodingPalm6_1 + Math.Round(stats.minDmg * explodingPalm6dmg1).ToString() + "-" + Math.Round(stats.maxDmg * explodingPalm6dmg1).ToString() + explodingPalm6_2 + Math.Round(stats.minDmg * explodingPalm6dmg2).ToString() + "-" + Math.Round(stats.maxDmg * explodingPalm6dmg2).ToString() + explodingPalm6_3;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Sacrifice";
                abilityRune1.Text = sacrifice1_1 + Math.Round(stats.minDmg * sacrifice1dmg).ToString() + "-" + Math.Round(stats.maxDmg * sacrifice1dmg).ToString() + sacrifice1_2;
                abilityRune2.Text = sacrifice2;
                abilityRune3.Text = sacrifice3;
                abilityRune4.Text = sacrifice4;
                abilityRune5.Text = sacrifice5;
                abilityRune6.Text = sacrifice6;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Energy Twister";
                abilityRune1.Text = twister1_1 + Math.Round(stats.minDmg * twister1dmg).ToString() + "-" + Math.Round(stats.maxDmg * twister1dmg).ToString() + twister1_2;
                abilityRune2.Text = twister2;
                abilityRune3.Text = twister3_1 + Math.Round(stats.minDmg * twister3dmg).ToString() + "-" + Math.Round(stats.maxDmg * twister3dmg).ToString() + twister3_2;
                abilityRune4.Text = twister4_1 + Math.Round(stats.minDmg * twister4dmg).ToString() + "-" + Math.Round(stats.maxDmg * twister4dmg).ToString() + twister4_2;
                abilityRune5.Text = twister5_1 + Math.Round(stats.minDmg * twister5dmg).ToString() + "-" + Math.Round(stats.maxDmg * twister5dmg).ToString() + twister5_2;
                abilityRune6.Text = twister6_1 + Math.Round(stats.minDmg * twister6dmg).ToString() + "-" + Math.Round(stats.maxDmg * twister6dmg).ToString() + twister6_2;
            }
            #endregion
        }

        private void ability18_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Furious Charge";
                abilityRune1.Text = charge1_1 + Math.Round(stats.minDmg * charge1dmg).ToString() + "-" + Math.Round(stats.maxDmg * charge1dmg).ToString() + charge1_2;
                abilityRune2.Text = charge2_1 + Math.Round(stats.minDmg * charge2dmg).ToString() + "-" + Math.Round(stats.maxDmg * charge2dmg).ToString() + charge2_2;
                abilityRune3.Text = charge3;
                abilityRune4.Text = charge4;
                abilityRune5.Text = charge5;
                abilityRune6.Text = charge6_1 + Math.Round(stats.minDmg * charge6dmg).ToString() + "-" + Math.Round(stats.maxDmg * charge6dmg).ToString() + charge6_2;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Companion";
                abilityRune1.Text = companion1_1 + Math.Round(stats.minDmg * companion1dmg).ToString() + "-" + Math.Round(stats.maxDmg * companion1dmg).ToString() + companion1_2;
                abilityRune2.Text = companion2;
                abilityRune3.Text = companion3;
                abilityRune4.Text = companion4;
                abilityRune5.Text = companion5;
                abilityRune6.Text = companion6_1 + Math.Round(stats.minDmg * companion6dmg).ToString() + "-" + Math.Round(stats.maxDmg * companion6dmg).ToString() + companion6_2;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Sweeping Wind";
                abilityRune1.Text = sweepingWind1_1 + Math.Round(stats.minDmg * sweepingWind1dmg1).ToString() + "-" + Math.Round(stats.maxDmg * sweepingWind1dmg1).ToString() + sweepingWind1_2 + Math.Round(stats.minDmg * sweepingWind1dmg2).ToString() + "-" + Math.Round(stats.maxDmg * sweepingWind1dmg2).ToString() + sweepingWind1_3;
                abilityRune2.Text = sweepingWind2;
                abilityRune3.Text = sweepingWind3_1 + Math.Round(stats.minDmg * sweepingWind3dmg1).ToString() + "-" + Math.Round(stats.maxDmg * sweepingWind3dmg1).ToString() + sweepingWind3_2 + Math.Round(stats.minDmg * sweepingWind3dmg2).ToString() + "-" + Math.Round(stats.maxDmg * sweepingWind3dmg2).ToString() + sweepingWind3_3;
                abilityRune4.Text = sweepingWind4;
                abilityRune5.Text = sweepingWind5;
                abilityRune6.Text = sweepingWind6_1 + Math.Round(stats.minDmg * sweepingWind6dmg).ToString() + "-" + Math.Round(stats.maxDmg * sweepingWind6dmg).ToString() + sweepingWind6_2;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Mass Confusion";
                abilityRune1.Text = massConfusion1;
                abilityRune2.Text = massConfusion2;
                abilityRune3.Text = massConfusion3;
                abilityRune4.Text = massConfusion4;
                abilityRune5.Text = massConfusion5;
                abilityRune6.Text = massConfusion6_1 + Math.Round(stats.minDmg * massConfusion6dmg).ToString() + "-" + Math.Round(stats.maxDmg * massConfusion6dmg).ToString() + massConfusion6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Hydra";
                abilityRune1.Text = hydra1_1 + Math.Round(stats.minDmg * hydra1dmg).ToString() + "-" + Math.Round(stats.maxDmg * hydra1dmg).ToString() + hydra1_2;
                abilityRune2.Text = hydra2_1 + Math.Round(stats.minDmg * hydra2dmg).ToString() + "-" + Math.Round(stats.maxDmg * hydra2dmg).ToString() + hydra2_2;
                abilityRune3.Text = hydra3_1 + Math.Round(stats.minDmg * hydra3dmg).ToString() + "-" + Math.Round(stats.maxDmg * hydra3dmg).ToString() + hydra3_2;
                abilityRune4.Text = hydra4_1 + Math.Round(stats.minDmg * hydra4dmg).ToString() + "-" + Math.Round(stats.maxDmg * hydra4dmg).ToString() + hydra4_2;
                abilityRune5.Text = hydra5_1 + Math.Round(stats.minDmg * hydra5dmg).ToString() + "-" + Math.Round(stats.maxDmg * hydra5dmg).ToString() + hydra5_2;
                abilityRune6.Text = hydra6_1 + Math.Round(stats.minDmg * hydra6dmg).ToString() + "-" + Math.Round(stats.maxDmg * hydra6dmg).ToString() + hydra6_2;
            }
            #endregion
        }

        private void ability19_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Overpower";
                abilityRune1.Text = overpower1_1 + Math.Round(stats.minDmg * overpower1dmg).ToString() + "-" + Math.Round(stats.maxDmg * overpower1dmg).ToString() + overpower1_2;
                abilityRune2.Text = overpower2_1 + Math.Round(stats.minDmg * overpower2dmg).ToString() + "-" + Math.Round(stats.maxDmg * overpower2dmg).ToString() + overpower2_2;
                abilityRune3.Text = overpower3;
                abilityRune4.Text = overpower4_1 + stats.maxHP + overpower4_2;
                abilityRune5.Text = overpower5;
                abilityRune6.Text = overpower6_1 + Math.Round(stats.maxHP * overpower6HP).ToString() + overpower6_2;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Marked for Death";
                abilityRune1.Text = markedForDeath1;
                abilityRune2.Text = markedForDeath2;
                abilityRune3.Text = markedForDeath3;
                abilityRune4.Text = markedForDeath4;
                abilityRune5.Text = markedForDeath5;
                abilityRune6.Text = markedForDeath6;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Meteor";
                abilityRune1.Text = meteor1_1 + Math.Round(stats.minDmg * meteor1dmg1).ToString() + "-" + Math.Round(stats.maxDmg * meteor1dmg1).ToString() + meteor1_2 + Math.Round(stats.minDmg * meteor1dmg2).ToString() + "-" + Math.Round(stats.maxDmg * meteor1dmg2).ToString() + meteor1_3;
                abilityRune2.Text = meteor2_1 + Math.Round(stats.minDmg * meteor2dmg1).ToString() + "-" + Math.Round(stats.maxDmg * meteor2dmg1).ToString() + meteor2_2 + Math.Round(stats.minDmg * meteor2dmg2).ToString() + "-" + Math.Round(stats.maxDmg * meteor2dmg2).ToString() + meteor2_3;
                abilityRune3.Text = meteor3;
                abilityRune4.Text = meteor4_1 + Math.Round(stats.minDmg * meteor4dmg).ToString() + "-" + Math.Round(stats.maxDmg * meteor4dmg).ToString() + meteor4_2;
                abilityRune5.Text = meteor5_1 + Math.Round(stats.minDmg * meteor5dmg1).ToString() + "-" + Math.Round(stats.maxDmg * meteor5dmg1).ToString() + meteor5_2 + Math.Round(stats.minDmg * meteor5dmg2).ToString() + "-" + Math.Round(stats.maxDmg * meteor5dmg2).ToString() + meteor5_3;
                abilityRune6.Text = meteor6;
            }
            #endregion
        }

        private void ability20_MouseEnter(object sender, EventArgs e)
        {
            //den enda klassen som har 5 abilities i något träd
            if (selectedClass == "Wizard")
            {
                label1.Text = "Blizzard";
                abilityRune1.Text = blizzard1_1 + Math.Round(stats.minDmg * blizzard1dmg).ToString() + "-" + Math.Round(stats.maxDmg * blizzard1dmg).ToString() + blizzard1_2;
                abilityRune2.Text = blizzard2;
                abilityRune3.Text = blizzard3;
                abilityRune4.Text = blizzard4;
                abilityRune5.Text = blizzard5_1 + Math.Round(stats.minDmg * blizzard5dmg).ToString() + "-" + Math.Round(stats.maxDmg * blizzard5dmg).ToString() + blizzard5_2;
                abilityRune6.Text = blizzard6_1 + Math.Round(stats.minDmg * blizzard6dmg).ToString() + "-" + Math.Round(stats.maxDmg * blizzard6dmg).ToString() + blizzard6_2;
            }
        }

        private void ability21_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Weapon Throw";
                abilityRune1.Text = weaponThrow1_1 + Math.Round(stats.minDmg * weaponThrow1dmg).ToString() + "-" + Math.Round(stats.maxDmg * weaponThrow1dmg).ToString() + weaponThrow1_2;
                abilityRune2.Text = weaponThrow2_1 + Math.Round(stats.minDmg * weaponThrow2dmg).ToString() + "-" + Math.Round(stats.maxDmg * weaponThrow2dmg).ToString() + weaponThrow2_2;
                abilityRune3.Text = weaponThrow3;
                abilityRune4.Text = weaponThrow4;
                abilityRune5.Text = weaponThrow5;
                abilityRune6.Text = weaponThrow6_1 + Math.Round(stats.minDmg * weaponThrow6dmg).ToString() + "-" + Math.Round(stats.maxDmg * weaponThrow6dmg).ToString() + weaponThrow6_2;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Evasive Fire";
                abilityRune1.Text = evasiveFire1_1 + Math.Round(stats.minDmg * evasiveFire1dmg).ToString() + "-" + Math.Round(stats.maxDmg * evasiveFire1dmg).ToString() + evasiveFire1_2;
                abilityRune2.Text = evasiveFire2_1 + Math.Round(stats.minDmg * evasiveFire2dmg).ToString() + "-" + Math.Round(stats.maxDmg * evasiveFire2dmg).ToString() + evasiveFire2_2;
                abilityRune3.Text = evasiveFire3_1 + Math.Round(stats.minDmg * evasiveFire3dmg).ToString() + "-" + Math.Round(stats.maxDmg * evasiveFire3dmg).ToString() + evasiveFire3_2;
                abilityRune4.Text = evasiveFire4_1 + Math.Round(stats.minDmg * evasiveFire4dmg).ToString() + "-" + Math.Round(stats.maxDmg * evasiveFire4dmg).ToString() + evasiveFire4_2;
                abilityRune5.Text = evasiveFire5;
                abilityRune6.Text = evasiveFire6;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Cyclone Strike";
                abilityRune1.Text = cycloneStrike1_1 + Math.Round(stats.minDmg * cycloneStrike1dmg).ToString() + "-" + Math.Round(stats.maxDmg * cycloneStrike1dmg).ToString() + cycloneStrike1_2;
                abilityRune2.Text = cycloneStrike2;
                abilityRune3.Text = cycloneStrike3;
                abilityRune4.Text = cycloneStrike4;
                abilityRune5.Text = cycloneStrike5;
                abilityRune6.Text = cycloneStrike6;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Zombie Charger";
                abilityRune1.Text = zombieCharger1_1 + Math.Round(stats.minDmg * zombieCharger1dmg).ToString() + "-" + Math.Round(stats.maxDmg * zombieCharger1dmg).ToString() + zombieCharger1_2;
                abilityRune2.Text = zombieCharger2_1 + Math.Round(stats.minDmg * zombieCharger2dmg).ToString() + "-" + Math.Round(stats.maxDmg * zombieCharger2dmg).ToString() + zombieCharger2_2;
                abilityRune3.Text = zombieCharger3_1 + Math.Round(stats.minDmg * zombieCharger3dmg).ToString() + "-" + Math.Round(stats.maxDmg * zombieCharger3dmg).ToString() + zombieCharger3_2;
                abilityRune4.Text = zombieCharger4_1 + Math.Round(stats.minDmg * zombieCharger4dmg).ToString() + "-" + Math.Round(stats.maxDmg * zombieCharger4dmg).ToString() + zombieCharger4_2;
                abilityRune5.Text = zombieCharger5_1 + Math.Round(stats.minDmg * zombieCharger5dmg).ToString() + "-" + Math.Round(stats.maxDmg * zombieCharger5dmg).ToString() + zombieCharger5_2;
                abilityRune6.Text = zombieCharger6_1 + Math.Round(stats.minDmg * zombieCharger6dmg).ToString() + "-" + Math.Round(stats.maxDmg * zombieCharger6dmg).ToString() + zombieCharger6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Ice Armor";
                abilityRune1.Text = iceArmor1;
                abilityRune2.Text = iceArmor2;
                abilityRune3.Text = iceArmor3;
                abilityRune4.Text = iceArmor4_1 + Math.Round(stats.minDmg * iceArmor4dmg).ToString() + "-" + Math.Round(stats.maxDmg * iceArmor4dmg).ToString() + iceArmor4_2;
                abilityRune5.Text = iceArmor5_1 + Math.Round(stats.minDmg * iceArmor5dmg).ToString() + "-" + Math.Round(stats.maxDmg * iceArmor5dmg).ToString() + iceArmor5_2;
                abilityRune6.Text = iceArmor6_1 + Math.Round(stats.minDmg * iceArmor6dmg).ToString() + "-" + Math.Round(stats.maxDmg * iceArmor6dmg).ToString() + iceArmor6_2;
            }
            #endregion
        }

        private void ability22_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Threatening Shout";
                abilityRune1.Text = shout1;
                abilityRune2.Text = shout2;
                abilityRune3.Text = shout3;
                abilityRune4.Text = shout4;
                abilityRune5.Text = shout5;
                abilityRune6.Text = shout6;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Fan of Knives";
                abilityRune1.Text = fanOfKnives1_1 + Math.Round(stats.minDmg * fanOfKnives1dmg).ToString() + "-" + Math.Round(stats.maxDmg * fanOfKnives1dmg).ToString() + fanOfKnives1_2;
                abilityRune2.Text = fanOfKnives2;
                abilityRune3.Text = fanOfKnives3_1 + Math.Round(stats.minDmg * fanOfKnives3dmg).ToString() + "-" + Math.Round(stats.maxDmg * fanOfKnives3dmg).ToString() + fanOfKnives3_2;
                abilityRune4.Text = fanOfKnives4;
                abilityRune5.Text = fanOfKnives5;
                abilityRune6.Text = fanOfKnives6_1 + Math.Round(stats.minDmg * fanOfKnives6dmg).ToString() + "-" + Math.Round(stats.maxDmg * fanOfKnives6dmg).ToString() + fanOfKnives6_2;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Seven-Sided Strike";
                abilityRune1.Text = sevenSidedStrike1_1 + Math.Round(stats.minDmg * sevenSidedStrike1dmg).ToString() + "-" + Math.Round(stats.maxDmg * sevenSidedStrike1dmg).ToString() + sevenSidedStrike1_2;
                abilityRune2.Text = sevenSidedStrike2_1 + Math.Round(stats.minDmg * sevenSidedStrike2dmg).ToString() + "-" + Math.Round(stats.maxDmg * sevenSidedStrike2dmg).ToString() + sevenSidedStrike2_2;
                abilityRune3.Text = sevenSidedStrike3;
                abilityRune4.Text = sevenSidedStrike4;
                abilityRune5.Text = sevenSidedStrike5;
                abilityRune6.Text = sevenSidedStrike6_1 + Math.Round(stats.minDmg * sevenSidedStrike6dmg).ToString() + "-" + Math.Round(stats.maxDmg * sevenSidedStrike6dmg).ToString() + sevenSidedStrike6_2;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Spirit Barrage";
                abilityRune1.Text = spiritBarrage1_1 + Math.Round(stats.minDmg * spiritBarrage1dmg).ToString() + "-" + Math.Round(stats.maxDmg * spiritBarrage1dmg).ToString() + spiritBarrage1_2;
                abilityRune2.Text = spiritBarrage2;
                abilityRune3.Text = spiritBarrage3_1 + Math.Round(stats.minDmg * spiritBarrage3dmg).ToString() + "-" + Math.Round(stats.maxDmg * spiritBarrage3dmg).ToString() + spiritBarrage3_2;
                abilityRune4.Text = spiritBarrage4_1 + Math.Round(stats.minDmg * spiritBarrage4dmg).ToString() + "-" + Math.Round(stats.maxDmg * spiritBarrage4dmg).ToString() + spiritBarrage4_2;
                abilityRune5.Text = spiritBarrage5;
                abilityRune6.Text = spiritBarrage6_1 + Math.Round(stats.minDmg * spiritBarrage6dmg).ToString() + "-" + Math.Round(stats.maxDmg * spiritBarrage6dmg).ToString() + spiritBarrage6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Storm Armor";
                abilityRune1.Text = stormArmor1_1 + Math.Round(stats.minDmg * stormArmor1dmg).ToString() + "-" + Math.Round(stats.maxDmg * stormArmor1dmg).ToString() + stormArmor1_2;
                abilityRune2.Text = stormArmor2_1 + Math.Round(stats.minDmg * stormArmor2dmg).ToString() + "-" + Math.Round(stats.maxDmg * stormArmor2dmg).ToString() + stormArmor2_2;
                abilityRune3.Text = stormArmor3;
                abilityRune4.Text = stormArmor4_1 + Math.Round(stats.minDmg * stormArmor4dmg).ToString() + "-" + Math.Round(stats.maxDmg * stormArmor4dmg).ToString() + stormArmor4_2;
                abilityRune5.Text = stormArmor5;
                abilityRune6.Text = stormArmor6_1 + Math.Round(stats.minDmg * stormArmor6dmg).ToString() + "-" + Math.Round(stats.maxDmg * stormArmor6dmg).ToString() + stormArmor6_2;
            }
            #endregion
        }

        private void ability23_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Battle Rage";
                abilityRune1.Text = rage1;
                abilityRune2.Text = rage2;
                abilityRune3.Text = rage3;
                abilityRune4.Text = rage4;
                abilityRune5.Text = rage5;
                abilityRune6.Text = rage6;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Spike Trap";
                abilityRune1.Text = spikeTrap1_1 + Math.Round(stats.minDmg * spikeTrap1dmg).ToString() + "-" + Math.Round(stats.maxDmg * spikeTrap1dmg).ToString() + spikeTrap1_2;
                abilityRune2.Text = spikeTrap2;
                abilityRune3.Text = spikeTrap3_1 + Math.Round(stats.minDmg * spikeTrap3dmg).ToString() + "-" + Math.Round(stats.maxDmg * spikeTrap3dmg).ToString() + spikeTrap3_2;
                abilityRune4.Text = spikeTrap4_1 + Math.Round(stats.minDmg * spikeTrap4dmg).ToString() + "-" + Math.Round(stats.maxDmg * spikeTrap4dmg).ToString() + spikeTrap4_2;
                abilityRune5.Text = spikeTrap5_1 + Math.Round(stats.minDmg * spikeTrap5dmg).ToString() + "-" + Math.Round(stats.maxDmg * spikeTrap5dmg).ToString() + spikeTrap5_2;
                abilityRune6.Text = spikeTrap6;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Mystic Ally";
                abilityRune1.Text = mysticAlly1_1 + Math.Round(stats.minDmg * mysticAlly1dmg).ToString() + "-" + Math.Round(stats.maxDmg * mysticAlly1dmg).ToString() + mysticAlly1_2;
                abilityRune2.Text = mysticAlly2_1 + Math.Round(stats.minDmg * mysticAlly2dmg).ToString() + "-" + Math.Round(stats.maxDmg * mysticAlly2dmg).ToString() + mysticAlly2_2;
                abilityRune3.Text = mysticAlly3_1 + Math.Round(stats.minDmg * mysticAlly3dmg).ToString() + "-" + Math.Round(stats.maxDmg * mysticAlly3dmg).ToString() + mysticAlly3_2;
                abilityRune4.Text = mysticAlly4_1 + Math.Round(stats.minDmg * mysticAlly4dmg).ToString() + "-" + Math.Round(stats.maxDmg * mysticAlly4dmg).ToString() + mysticAlly4_2;
                abilityRune5.Text = mysticAlly5_1 + Math.Round(stats.minDmg * mysticAlly5dmg).ToString() + "-" + Math.Round(stats.maxDmg * mysticAlly5dmg).ToString() + mysticAlly5_2;
                abilityRune6.Text = mysticAlly6_1 + Math.Round(stats.minDmg * mysticAlly6dmg).ToString() + "-" + Math.Round(stats.maxDmg * mysticAlly6dmg).ToString() + mysticAlly6_2;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Acid Cloud";
                abilityRune1.Text = acidCloud1_1 + Math.Round(stats.minDmg * acidCloud1dmg1).ToString() + "-" + Math.Round(stats.maxDmg * acidCloud1dmg1).ToString() + acidCloud1_2 + Math.Round(stats.minDmg * acidCloud1dmg2).ToString() + "-" + Math.Round(stats.maxDmg * acidCloud1dmg2).ToString() + acidCloud1_3;
                abilityRune2.Text = acidCloud2;
                abilityRune3.Text = acidCloud3_1 + Math.Round(stats.minDmg * acidCloud3dmg).ToString() + "-" + Math.Round(stats.maxDmg * acidCloud3dmg).ToString() + acidCloud3_2;
                abilityRune4.Text = acidCloud4;
                abilityRune5.Text = acidCloud5_1 + Math.Round(stats.minDmg * acidCloud5dmg1).ToString() + "-" + Math.Round(stats.maxDmg * acidCloud5dmg1).ToString() + acidCloud5_2 + Math.Round(stats.minDmg * acidCloud5dmg2).ToString() + "-" + Math.Round(stats.maxDmg * acidCloud5dmg2).ToString() + acidCloud5_3;
                abilityRune6.Text = acidCloud6_1 + Math.Round(stats.minDmg * acidCloud6dmg).ToString() + "-" + Math.Round(stats.maxDmg * acidCloud6dmg).ToString() + acidCloud6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Magic Weapon";
                abilityRune1.Text = magicWeapon1;
                abilityRune2.Text = magicWeapon2_1 + Math.Round(stats.minDmg * magicWeapon2dmg).ToString() + "-" + Math.Round(stats.maxDmg * magicWeapon2dmg).ToString() + magicWeapon2_2;
                abilityRune3.Text = magicWeapon3;
                abilityRune4.Text = magicWeapon4;
                abilityRune5.Text = magicWeapon5_1 + Math.Round(stats.minDmg * magicWeapon5dmg).ToString() + "-" + Math.Round(stats.maxDmg * magicWeapon5dmg).ToString() + magicWeapon5_2;
                abilityRune6.Text = magicWeapon6;
            }
            #endregion
        }

        private void ability24_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "War Cry";
                abilityRune1.Text = warCry1;
                abilityRune2.Text = warCry2;
                abilityRune3.Text = warCry3;
                abilityRune4.Text = warCry4;
                abilityRune5.Text = warCry5;
                abilityRune6.Text = warCry6;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Sentry";
                abilityRune1.Text = sentry1_1 + Math.Round(stats.minDmg * sentry1dmg).ToString() + "-" + Math.Round(stats.maxDmg * sentry1dmg).ToString() + sentry1_2;
                abilityRune2.Text = sentry2_1 + Math.Round(stats.minDmg * sentry2dmg).ToString() + "-" + Math.Round(stats.maxDmg * sentry2dmg).ToString() + sentry2_2;
                abilityRune3.Text = sentry3; ;
                abilityRune4.Text = sentry4_1 + Math.Round(stats.minDmg * sentry4dmg).ToString() + "-" + Math.Round(stats.maxDmg * sentry4dmg).ToString() + sentry4_2;
                abilityRune5.Text = sentry5;
                abilityRune6.Text = sentry6;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Wall of Zombies";
                abilityRune1.Text = zombieWall1_1 + Math.Round(stats.minDmg * zombieWall1dmg).ToString() + "-" + Math.Round(stats.maxDmg * zombieWall1dmg).ToString() + zombieWall1_2;
                abilityRune2.Text = zombieWall2;
                abilityRune3.Text = zombieWall3;
                abilityRune4.Text = zombieWall4_1 + Math.Round(stats.minDmg * zombieWall4dmg).ToString() + "-" + Math.Round(stats.maxDmg * zombieWall4dmg).ToString() + zombieWall4_2;
                abilityRune5.Text = zombieWall5_1 + Math.Round(stats.minDmg * zombieWall5dmg).ToString() + "-" + Math.Round(stats.maxDmg * zombieWall5dmg).ToString() + zombieWall5_2;
                abilityRune6.Text = zombieWall6_1 + Math.Round(stats.minDmg * zombieWall6dmg).ToString() + "-" + Math.Round(stats.maxDmg * zombieWall6dmg).ToString() + zombieWall6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Familiar";
                abilityRune1.Text = familiar1_1 + Math.Round(stats.minDmg * familiar1dmg).ToString() + "-" + Math.Round(stats.maxDmg * familiar1dmg).ToString() + familiar1_2;
                abilityRune2.Text = familiar2;
                abilityRune3.Text = familiar3;
                abilityRune4.Text = familiar4_1 + Math.Round(stats.maxHP * familiar4HP).ToString() + familiar4_2;
                abilityRune5.Text = familiar5;
                abilityRune6.Text = familiar6_1 + Math.Round(stats.minDmg * familiar6dmg).ToString() + "-" + Math.Round(stats.maxDmg * familiar6dmg).ToString() + familiar6_2;
            }
            #endregion
        }

        private void ability25_MouseEnter(object sender, EventArgs e)
        {
            //åter igen den ända som har 5 i något ability träd
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Energy Armor";
                abilityRune1.Text = energyArmor1;
                abilityRune2.Text = energyArmor2;
                abilityRune3.Text = energyArmor3;
                abilityRune4.Text = energyArmor4;
                abilityRune5.Text = energyArmor5_1 + Math.Round(stats.maxHP * energyArmor5HP).ToString() + energyArmor5_2 + stats.maxHP + energyArmor5_3;
                abilityRune6.Text = energyArmor6;
            }
            #endregion
        }

        private void ability26_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Earthquake";
                abilityRune1.Text = earthquake1_1 + Math.Round(stats.minDmg * earthquake1dmg).ToString() + "-" + Math.Round(stats.maxDmg * earthquake1dmg).ToString() + earthquake1_2;
                abilityRune2.Text = earthquake2_1 + Math.Round(stats.minDmg * earthquake2dmg).ToString() + "-" + Math.Round(stats.maxDmg * earthquake2dmg).ToString() + earthquake2_2;
                abilityRune3.Text = earthquake3;
                abilityRune4.Text = earthquake4;
                abilityRune5.Text = earthquake5_1 + Math.Round(stats.minDmg * earthquake5dmg).ToString() + "-" + Math.Round(stats.maxDmg * earthquake5dmg).ToString() + earthquake5_2;
                abilityRune6.Text = earthquake6_1 + Math.Round(stats.minDmg * earthquake6dmg).ToString() + "-" + Math.Round(stats.maxDmg * earthquake6dmg).ToString() + earthquake6_2;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Strafe";
                abilityRune1.Text = strafe1_1 + Math.Round(stats.minDmg * strafe1dmg).ToString() + "-" + Math.Round(stats.maxDmg * strafe1dmg).ToString() + strafe1_2;
                abilityRune2.Text = strafe2;
                abilityRune3.Text = strafe3;
                abilityRune4.Text = strafe4;
                abilityRune5.Text = strafe5_1 + Math.Round(stats.minDmg * strafe5dmg).ToString() + "-" + Math.Round(stats.maxDmg * strafe5dmg).ToString() + strafe5_2;
                abilityRune6.Text = strafe6_1 + Math.Round(stats.minDmg * strafe6dmg).ToString() + "-" + Math.Round(stats.maxDmg * strafe6dmg).ToString() + strafe6_2;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Mantra of Evasion";
                abilityRune1.Text = mantraOfEvasion1;
                abilityRune2.Text = mantraOfEvasion2;
                abilityRune3.Text = mantraOfEvasion3;
                abilityRune4.Text = mantraOfEvasion4;
                abilityRune5.Text = mantraOfEvasion5;
                abilityRune6.Text = mantraOfEvasion6_1 + Math.Round(stats.minDmg * mantraOfEvasion6dmg).ToString() + "-" + Math.Round(stats.maxDmg * mantraOfEvasion6dmg).ToString() + mantraOfEvasion6_2;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Gargantuan";
                abilityRune1.Text = gargantuan1_1 + Math.Round(stats.minDmg * gargantuan1dmg).ToString() + "-" + Math.Round(stats.maxDmg * gargantuan1dmg).ToString() + gargantuan1_2;
                abilityRune2.Text = gargantuan2_1 + Math.Round(stats.minDmg * gargantuan2dmg).ToString() + "-" + Math.Round(stats.maxDmg * gargantuan2dmg).ToString() + gargantuan2_2;
                abilityRune3.Text = gargantuan3;
                abilityRune4.Text = gargantuan4_1 + Math.Round(stats.minDmg * gargantuan4dmg).ToString() + "-" + Math.Round(stats.maxDmg * gargantuan4dmg).ToString() + gargantuan4_2;
                abilityRune5.Text = gargantuan5_1 + Math.Round(stats.minDmg * gargantuan5dmg).ToString() + "-" + Math.Round(stats.maxDmg * gargantuan5dmg).ToString() + gargantuan5_2;
                abilityRune6.Text = gargantuan6_1 + Math.Round(stats.minDmg * gargantuan6dmg).ToString() + "-" + Math.Round(stats.maxDmg * gargantuan6dmg).ToString() + gargantuan6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Explosive Blast";
                abilityRune1.Text = blast1_1 + Math.Round(stats.minDmg * blast1dmg).ToString() + "-" + Math.Round(stats.maxDmg * blast1dmg).ToString() + blast1_2;
                abilityRune2.Text = blast2;
                abilityRune3.Text = blast3_1 + Math.Round(stats.minDmg * blast3dmg).ToString() + "-" + Math.Round(stats.maxDmg * blast3dmg).ToString() + blast3_2;
                abilityRune4.Text = blast4_1 + Math.Round(stats.minDmg * blast4dmg).ToString() + "-" + Math.Round(stats.maxDmg * blast4dmg).ToString() + blast4_2;
                abilityRune5.Text = blast5_1 + Math.Round(stats.minDmg * blast5dmg).ToString() + "-" + Math.Round(stats.maxDmg * blast5dmg).ToString() + blast5_2;
                abilityRune6.Text = blast6_1 + Math.Round(stats.minDmg * blast6dmg).ToString() + "-" + Math.Round(stats.maxDmg * blast6dmg).ToString() + blast6_2;
            }
            #endregion
        }

        private void ability27_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Call of the Ancients";
                abilityRune1.Text = ancients1_1 + Math.Round(stats.minDmg * ancients1dmg).ToString() + "-" + Math.Round(stats.maxDmg * ancients1dmg).ToString() + ancients1_2;
                abilityRune2.Text = ancients2_1 + Math.Round(stats.minDmg * ancients2dmg).ToString() + "-" + Math.Round(stats.maxDmg * ancients2dmg).ToString() + ancients2_2;
                abilityRune3.Text = ancients3;
                abilityRune4.Text = ancients4_1 + Math.Round(stats.minDmg * ancients4dmg).ToString() + "-" + Math.Round(stats.maxDmg * ancients4dmg).ToString() + ancients4_2;
                abilityRune5.Text = ancients5_1 + Math.Round(stats.minDmg * ancients5dmg).ToString() + "-" + Math.Round(stats.maxDmg * ancients5dmg).ToString() + ancients5_2;
                abilityRune6.Text = ancients6_1 + Math.Round(stats.minDmg * ancients6dmg).ToString() + "-" + Math.Round(stats.maxDmg * ancients6dmg).ToString() + ancients6_2;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Multishot";
                abilityRune1.Text = multishot1_1 + Math.Round(stats.minDmg * multishot1dmg).ToString() + "-" + Math.Round(stats.maxDmg * multishot1dmg).ToString() + multishot1_2;
                abilityRune2.Text = multishot2_1 + Math.Round(stats.minDmg * multishot2dmg).ToString() + "-" + Math.Round(stats.maxDmg * multishot2dmg).ToString() + multishot2_2;
                abilityRune3.Text = multishot3_1 + Math.Round(stats.minDmg * multishot3dmg).ToString() + "-" + Math.Round(stats.maxDmg * multishot3dmg).ToString() + multishot3_2;
                abilityRune4.Text = multishot4;
                abilityRune5.Text = multishot5_1 + Math.Round(stats.minDmg * multishot5dmg).ToString() + "-" + Math.Round(stats.maxDmg * multishot5dmg).ToString() + multishot5_2;
                abilityRune6.Text = multishot6_1 + Math.Round(stats.minDmg * multishot6dmg).ToString() + "-" + Math.Round(stats.maxDmg * multishot6dmg).ToString() + multishot6_2;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Mantra of Retribution";

                abilityRune1.Text = mantraOfRetribution1;
                abilityRune2.Text = mantraOfRetribution2;
                abilityRune3.Text = mantraOfRetribution3;
                abilityRune4.Text = mantraOfRetribution4;
                abilityRune5.Text = mantraOfRetribution5;
                abilityRune6.Text = mantraOfRetribution6_1 + Math.Round(stats.minDmg * mantraOfRetribution6dmg).ToString() + "-" + Math.Round(stats.maxDmg * mantraOfRetribution6dmg).ToString() + mantraOfRetribution6_2;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Big Bag Voodoo";
                abilityRune1.Text = voodoo1;
                abilityRune2.Text = voodoo2;
                abilityRune3.Text = voodoo3;
                abilityRune4.Text = voodoo4;
                abilityRune5.Text = voodoo5;
                abilityRune6.Text = voodoo6;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Mirror Image";
                abilityRune1.Text = mirror1;
                abilityRune2.Text = mirror2;
                abilityRune3.Text = mirror3;
                abilityRune4.Text = mirror4;
                abilityRune5.Text = mirror5;
                abilityRune6.Text = mirror6;
            }
            #endregion
        }

        private void ability28_MouseEnter(object sender, EventArgs e)
        {
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                label1.Text = "Wrath of the Berserker";
                abilityRune1.Text = wrath1;
                abilityRune2.Text = wrath2_1 + Math.Round(stats.minDmg * wrath2dmg).ToString() + "-" + Math.Round(stats.maxDmg * wrath2dmg).ToString() + wrath2_2;
                abilityRune3.Text = wrath3;
                abilityRune4.Text = wrath4_1 + Math.Round(stats.minDmg * wrath4dmg).ToString() + "-" + Math.Round(stats.maxDmg * wrath4dmg).ToString() + wrath4_2;
                abilityRune5.Text = wrath5;
                abilityRune6.Text = wrath6;
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Cluster Arrow";
                abilityRune1.Text = clusterArrow1_1 + Math.Round(stats.minDmg * clusterArrow1dmg1).ToString() + "-" + Math.Round(stats.maxDmg * clusterArrow1dmg1).ToString() + clusterArrow1_2 + Math.Round(stats.minDmg * clusterArrow1dmg2).ToString() + "-" + Math.Round(stats.maxDmg * clusterArrow1dmg2).ToString() + clusterArrow1_3;
                abilityRune2.Text = clusterArrow2;
                abilityRune3.Text = clusterArrow3_1 + Math.Round(stats.minDmg * clusterArrow3dmg).ToString() + "-" + Math.Round(stats.maxDmg * clusterArrow3dmg).ToString() + clusterArrow3_2;
                abilityRune4.Text = clusterArrow4_1 + Math.Round(stats.minDmg * clusterArrow4dmg).ToString() + "-" + Math.Round(stats.maxDmg * clusterArrow4dmg).ToString() + clusterArrow4_2;
                abilityRune5.Text = clusterArrow5_1 + Math.Round(stats.minDmg * clusterArrow5dmg).ToString() + "-" + Math.Round(stats.maxDmg * clusterArrow5dmg).ToString() + clusterArrow5_2;
                abilityRune6.Text = clusterArrow6_1 + Math.Round(stats.minDmg * clusterArrow6dmg).ToString() + "-" + Math.Round(stats.maxDmg * clusterArrow6dmg).ToString() + clusterArrow6_2;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Mantra of Healing";
                abilityRune1.Text = mantraOfHealing1;
                abilityRune2.Text = mantraOfHealing2;
                abilityRune3.Text = mantraOfHealing3;
                abilityRune4.Text = mantraOfHealing4;
                abilityRune5.Text = mantraOfHealing5;
                abilityRune6.Text = mantraOfHealing6;
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                label1.Text = "Fetish Army";
                abilityRune1.Text = fetishArmy1_1 + Math.Round(stats.minDmg * fetishArmy1dmg).ToString() + "-" + Math.Round(stats.maxDmg * fetishArmy1dmg).ToString() + fetishArmy1_2;
                abilityRune2.Text = fetishArmy2_1 + Math.Round(stats.minDmg * fetishArmy2dmg).ToString() + "-" + Math.Round(stats.maxDmg * fetishArmy2dmg).ToString() + fetishArmy2_2;
                abilityRune3.Text = fetishArmy3;
                abilityRune4.Text = fetishArmy4;
                abilityRune5.Text = fetishArmy5_1 + Math.Round(stats.minDmg * fetishArmy5dmg).ToString() + "-" + Math.Round(stats.maxDmg * fetishArmy5dmg).ToString() + fetishArmy5_2;
                abilityRune6.Text = fetishArmy6_1 + Math.Round(stats.minDmg * fetishArmy6dmg).ToString() + "-" + Math.Round(stats.maxDmg * fetishArmy6dmg).ToString() + fetishArmy6_2;
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                label1.Text = "Archon";
                abilityRune1.Text = archon1;
                abilityRune2.Text = archon2_1 + Math.Round(stats.minDmg * archon2dmg).ToString() + "-" + Math.Round(stats.maxDmg * archon2dmg).ToString() + archon2_2;
                abilityRune3.Text = archon3;
                abilityRune4.Text = archon4;
                abilityRune5.Text = archon5;
                abilityRune6.Text = archon6;
            }
            #endregion
        }

        private void ability29_MouseEnter(object sender, EventArgs e)
        {
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                label1.Text = "Rain of Vengeance";
                abilityRune1.Text = rainOfVengeance1_1 + Math.Round(stats.minDmg * rainOfVengeance1dmg).ToString() + "-" + Math.Round(stats.maxDmg * rainOfVengeance1dmg).ToString() + rainOfVengeance1_2;
                abilityRune2.Text = rainOfVengeance2_1 + Math.Round(stats.minDmg * rainOfVengeance2dmg).ToString() + "-" + Math.Round(stats.maxDmg * rainOfVengeance2dmg).ToString() + rainOfVengeance2_2;
                abilityRune3.Text = rainOfVengeance3_1 + Math.Round(stats.minDmg * rainOfVengeance3dmg).ToString() + "-" + Math.Round(stats.maxDmg * rainOfVengeance3dmg).ToString() + rainOfVengeance3_2;
                abilityRune4.Text = rainOfVengeance4_1 + Math.Round(stats.minDmg * rainOfVengeance4dmg).ToString() + "-" + Math.Round(stats.maxDmg * rainOfVengeance4dmg).ToString() + rainOfVengeance4_2;
                abilityRune5.Text = rainOfVengeance5_1 + Math.Round(stats.minDmg * rainOfVengeance5dmg).ToString() + "-" + Math.Round(stats.maxDmg * rainOfVengeance5dmg).ToString() + rainOfVengeance5_2;
                abilityRune6.Text = rainOfVengeance6_1 + Math.Round(stats.minDmg * rainOfVengeance6dmg).ToString() + "-" + Math.Round(stats.maxDmg * rainOfVengeance6dmg).ToString() + rainOfVengeance6_2;
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                label1.Text = "Mantra of Conviction";

                abilityRune1.Text = mantraOfConviction1;
                abilityRune2.Text = mantraOfConviction2;
                abilityRune3.Text = mantraOfConviction3;
                abilityRune4.Text = mantraOfConviction4;
                abilityRune5.Text = mantraOfConviction5;
                abilityRune6.Text = mantraOfConviction6_1 + Math.Round(stats.minDmg * mantraOfConviction6dmg).ToString() + "-" + Math.Round(stats.maxDmg * mantraOfConviction6dmg).ToString() + mantraOfConviction6_2;
            }
            #endregion
        }

        private void LoadProperties()
        {
            //ladda bilderna beroende på klass
            #region Barbarian
            if (selectedClass == "Barbarian")
            {
                /*
                ability1.Image = D3_Calculator.Properties.Resources.Bash;
                ability2.Image = D3_Calculator.Properties.Resources.Cleave;
                ability3.Image = D3_Calculator.Properties.Resources.Frenzy;
                ability6.Image = D3_Calculator.Properties.Resources.Hammer_of_the_Ancients;
                ability7.Image = D3_Calculator.Properties.Resources.Rend;
                ability7.Image = D3_Calculator.Properties.Resources.Seismic_Slam;
                ability8.Image = D3_Calculator.Properties.Resources.Whirlwind;
                groupAction1.Text = "Defensive";
                ability11.Image = D3_Calculator.Properties.Resources.Ground_Stomp;
                ability12.Image = D3_Calculator.Properties.Resources.Leap;
                ability13.Image = D3_Calculator.Properties.Resources.Sprint;
                ability14.Image = D3_Calculator.Properties.Resources.Ignore_Pain;
                groupAction2.Text = "Might";
                ability16.Image = D3_Calculator.Properties.Resources.Ancient_Spear;
                ability17.Image = D3_Calculator.Properties.Resources.Revenge;
                ability18.Image = D3_Calculator.Properties.Resources.Furious_Charge;
                ability19.Image = D3_Calculator.Properties.Resources.Overpower;
                groupAction3.Text = "Tactics";
                ability21.Image = D3_Calculator.Properties.Resources.Weapon_Throw;
                ability22.Image = D3_Calculator.Properties.Resources.Threatening_Shout;
                ability23.Image = D3_Calculator.Properties.Resources.Battle_Rage;
                ability24.Image = D3_Calculator.Properties.Resources.War_Cry;
                groupAction4.Text = "Rage";
                ability26.Image = D3_Calculator.Properties.Resources.Earthquake;
                ability27.Image = D3_Calculator.Properties.Resources.Call_of_the_Ancients;
                ability28.Image = D3_Calculator.Properties.Resources.Wrath_of_the_Berserker;*/
            }
            #endregion
            #region Demon Hunter
            if (selectedClass == "Demon Hunter")
            {
                /*
                //Primary
                ability1.Image = D3_Calculator.Properties.Resources.Hungering_Arrow;
                ability2.Image = D3_Calculator.Properties.Resources.Entangling_Shot;
                ability3.Image = D3_Calculator.Properties.Resources.Bola_Shot;
                ability4.Image = D3_Calculator.Properties.Resources.Grenades;
                //Secondary
                ability6.Image = D3_Calculator.Properties.Resources.Impale;
                ability7.Image = D3_Calculator.Properties.Resources.Rapid_Fire;
                ability8.Image = D3_Calculator.Properties.Resources.Chakram;
                ability9.Image = D3_Calculator.Properties.Resources.Elemental_Arrow;
                groupAction1.Text = "Defensive";
                ability11.Image = D3_Calculator.Properties.Resources.Caltrops;
                ability12.Image = D3_Calculator.Properties.Resources.Smoke_Screen;
                ability13.Image = D3_Calculator.Properties.Resources.Shadow_Power;
                groupAction2.Text = "Hunting";
                ability16.Image = D3_Calculator.Properties.Resources.Vault;
                ability17.Image = D3_Calculator.Properties.Resources.Preparation;
                ability18.Image = D3_Calculator.Properties.Resources.Companion;
                ability19.Image = D3_Calculator.Properties.Resources.Marked_for_Death;
                groupAction3.Text = "Devices";
                ability21.Image = D3_Calculator.Properties.Resources.Evasive_Fire;
                ability22.Image = D3_Calculator.Properties.Resources.Fan_of_Knives;
                ability23.Image = D3_Calculator.Properties.Resources.Spike_Trap;
                ability24.Image = D3_Calculator.Properties.Resources.Sentry;
                groupAction4.Text = "Archery";
                ability26.Image = D3_Calculator.Properties.Resources.Strafe;
                ability27.Image = D3_Calculator.Properties.Resources.Multishot;
                ability28.Image = D3_Calculator.Properties.Resources.Cluster_Arrow;
                ability29.Image = D3_Calculator.Properties.Resources.Rain_of_Vengeance;*/
            }
            #endregion
            #region Monk
            if (selectedClass == "Monk")
            {
                /*
                //Primary
                ability1.Image = D3_Calculator.Properties.Resources.Fists_of_Thunder;
                ability2.Image = D3_Calculator.Properties.Resources.Deadly_Reach;
                ability3.Image = D3_Calculator.Properties.Resources.Crippling_Wave;
                ability4.Image = D3_Calculator.Properties.Resources.Way_of_the_Hundred_Fists;
                //Secondary
                ability6.Image = D3_Calculator.Properties.Resources.Lashing_Tail_Kick;
                ability7.Image = D3_Calculator.Properties.Resources.Tempest_Rush;
                ability8.Image = D3_Calculator.Properties.Resources.Wave_of_Light;
                groupAction1.Text = "Defensive";
                ability11.Image = D3_Calculator.Properties.Resources.Blinding_Flash;
                ability12.Image = D3_Calculator.Properties.Resources.Breath_of_Heaven;
                ability13.Image = D3_Calculator.Properties.Resources.Serenity;
                ability14.Image = D3_Calculator.Properties.Resources.Inner_Sanctuary;
                groupAction2.Text = "Techniques";
                ability16.Image = D3_Calculator.Properties.Resources.Dashing_Strike;
                ability17.Image = D3_Calculator.Properties.Resources.Exploding_Palm;
                ability18.Image = D3_Calculator.Properties.Resources.Sweeping_Wind;
                groupAction3.Text = "Focus";
                ability21.Image = D3_Calculator.Properties.Resources.Cyclone_Strike;
                ability22.Image = D3_Calculator.Properties.Resources.Seven_Sided_Strike;
                ability23.Image = D3_Calculator.Properties.Resources.Mystic_Ally;
                groupAction4.Text = "Mantras";
                ability26.Image = D3_Calculator.Properties.Resources.Mantra_of_Evasion;
                ability27.Image = D3_Calculator.Properties.Resources.Mantra_of_Retribution;
                ability28.Image = D3_Calculator.Properties.Resources.Mantra_of_Healing;
                ability29.Image = D3_Calculator.Properties.Resources.Mantra_of_Conviction;*/
            }
            #endregion
            #region Witch Doctor
            if (selectedClass == "Witch Doctor")
            {
                /*
                //primary
                ability1.Image = D3_Calculator.Properties.Resources.Poison_Dart;
                ability2.Image = D3_Calculator.Properties.Resources.Corpse_Spiders;
                ability3.Image = D3_Calculator.Properties.Resources.Plague_of_Toads;
                ability4.Image = D3_Calculator.Properties.Resources.Firebomb;
                //secondary
                ability6.Image = D3_Calculator.Properties.Resources.Grasp_of_the_Dead;
                ability7.Image = D3_Calculator.Properties.Resources.Firebats;
                ability8.Image = D3_Calculator.Properties.Resources.Haunt;
                ability9.Image = D3_Calculator.Properties.Resources.Locust_Swarm;
                groupAction1.Text = "Defensive";
                ability11.Image = D3_Calculator.Properties.Resources.Summon_Zombie_Dogs;
                ability12.Image = D3_Calculator.Properties.Resources.Horrify;
                ability13.Image = D3_Calculator.Properties.Resources.Spirit_Walk;
                ability14.Image = D3_Calculator.Properties.Resources.Hex;
                groupAction2.Text = "Terror";
                ability16.Image = D3_Calculator.Properties.Resources.Soul_Harvest;
                ability17.Image = D3_Calculator.Properties.Resources.Sacrifice;
                ability18.Image = D3_Calculator.Properties.Resources.Mass_Confusion;
                groupAction3.Text = "Decay";
                ability21.Image = D3_Calculator.Properties.Resources.Zombie_Charger;
                ability22.Image = D3_Calculator.Properties.Resources.Spirit_Barrage;
                ability23.Image = D3_Calculator.Properties.Resources.Acid_Cloud;
                ability24.Image = D3_Calculator.Properties.Resources.Wall_of_Zombies;
                groupAction4.Text = "Voodoo";
                ability26.Image = D3_Calculator.Properties.Resources.Gargantuan;
                ability27.Image = D3_Calculator.Properties.Resources.Big_Bad_Voodoo;
                ability28.Image = D3_Calculator.Properties.Resources.Fetish_Army;*/
            }
            #endregion
            #region Wizard
            if (selectedClass == "Wizard")
            {
                /*
                //Primary
                ability1.Image = D3_Calculator.Properties.Resources.Magic_Missile;
                ability2.Image = D3_Calculator.Properties.Resources.Shock_Pulse;
                ability3.Image = D3_Calculator.Properties.Resources.Spectral_Blade;
                ability4.Image = D3_Calculator.Properties.Resources.Electrocute;
                //Secondary
                ability6.Image = D3_Calculator.Properties.Resources.Ray_of_Frost;
                ability7.Image = D3_Calculator.Properties.Resources.Arcane_Orb;
                ability8.Image = D3_Calculator.Properties.Resources.Arcane_Torrent;
                ability9.Image = D3_Calculator.Properties.Resources.Disintegrate;
                groupAction1.Text = "Defensive";
                ability11.Image = D3_Calculator.Properties.Resources.Frost_Nova;
                ability12.Image = D3_Calculator.Properties.Resources.Diamond_Skin;
                ability13.Image = D3_Calculator.Properties.Resources.Slow_Time;
                ability14.Image = D3_Calculator.Properties.Resources.Teleport;
                groupAction2.Text = "Force";
                ability16.Image = D3_Calculator.Properties.Resources.Wave_of_Force;
                ability17.Image = D3_Calculator.Properties.Resources.Energy_Twister;
                ability18.Image = D3_Calculator.Properties.Resources.Hydra;
                ability19.Image = D3_Calculator.Properties.Resources.Meteor;
                ability20.Image = D3_Calculator.Properties.Resources.Blizzard;
                groupAction3.Text = "Conjuration";
                ability21.Image = D3_Calculator.Properties.Resources.Ice_Armor;
                ability22.Image = D3_Calculator.Properties.Resources.Storm_Armor;
                ability23.Image = D3_Calculator.Properties.Resources.Magic_Weapon;
                ability24.Image = D3_Calculator.Properties.Resources.Familiar;
                ability25.Image = D3_Calculator.Properties.Resources.Energy_Armor;
                groupAction4.Text = "Mastery";
                ability26.Image = D3_Calculator.Properties.Resources.Explosive_Blast;
                ability27.Image = D3_Calculator.Properties.Resources.Mirror_Image;
                ability28.Image = D3_Calculator.Properties.Resources.Archon;*/
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Easter Egg";
            abilityRune1.Text = naggingAunt1;
            abilityRune2.Text = naggingAunt2;
            abilityRune3.Text = naggingAunt3;
            abilityRune4.Text = naggingAunt4;
            abilityRune5.Text = naggingAunt5;
            abilityRune6.Text = naggingAunt6;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Easter Egg";
            abilityRune1.Text = theBigBangTheory1;
            abilityRune2.Text = theBigBangTheory2;
            abilityRune3.Text = theBigBangTheory3;
            abilityRune4.Text = theBigBangTheory4;
            abilityRune5.Text = theBigBangTheory5;
            abilityRune6.Text = theBigBangTheory6;
        }

    }
}