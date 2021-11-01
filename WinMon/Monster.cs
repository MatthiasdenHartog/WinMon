using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMon
{
    public class Monster : MonsterBase
    {
        public bool isBlocking = false;
        public int decidedAction = -1;
        public CombatScreen cs;
        public double dealtDamage { get; set; }
        public double HP { get; set; }
        public double MaxHP { get; set; }
        public double Speed { get; set; }
        public double Strength { get; set; }
        public double Defense { get; set; }
        public double EP { get; set; }
        public double MaxEP { get; set; }
        public int amountAtk { get; set; }
        public int amountDef { get; set; }
        public int amountHeal { get; set; }
        public int availAmountAtk { get; set; }
        public int availAmountDef { get; set; }
        public int availAmountHeal { get; set; }
        public int Level { get; set; }

        public Monster(string name, double hP, double maxHP, double speed, double strength, double defense, double eP, double maxEP, int amountAtk, int amountDef, int amountHeal, int availAmountAtk, int availAmountDef, int availAmountHeal, int level) : base(name)
        {
            this.HP = hP;
            MaxHP = maxHP;
            Speed = speed;
            Strength = strength;
            Defense = defense;
            EP = eP;
            MaxEP = maxEP;
            this.amountAtk = amountAtk;
            this.amountDef = amountDef;
            this.amountHeal = amountHeal;
            this.availAmountAtk = availAmountAtk;
            this.availAmountDef = availAmountDef;
            this.availAmountHeal = availAmountHeal;
            Level = level;

        }

        public Monster initWildMon()
        {
            Monster result;

            return result;
        }
        public Monster clone()
        {
            Monster monsterClone = new Monster(this.name,this.HP, MaxHP, Speed, Strength, Defense, EP, MaxEP, amountAtk, availAmountAtk, amountDef, availAmountDef, amountHeal, availAmountHeal, Level);

            return monsterClone;
        }
        public void attack(Monster target)
        {
            if (HP > 0)
            {
                if (target.isBlocking == false)
                {
                    dealtDamage = Strength * (100 / (100 + target.Defense));
                    target.HP -= dealtDamage;
                    target.healthbar.Value = Convert.ToInt32(target.HP);
                }
                else { dealtDamage = 0; }
            }
        }
        public void defend()
        {
            isBlocking = true;
        }
        public void heal()
        {
            HP = MaxHP;
            healthbar.Value = Convert.ToInt32(HP);
        }
        public async void LevelUp()
        {
            EP = EP - MaxEP;
            MaxEP += 2;
            TextBox levelBox = new TextBox();
            levelBox.Location = new Point(frame.Location.X + frame.Width, frame.Location.Y);
            levelBox.Multiline = true;
            levelBox.MaxLength = 4;
            levelBox.Size = new Size(130, 65);
            cs.Controls.Add(levelBox);
            levelBox.AppendText("Level:              " + Level + "->" + (Level += 1) + "\n");
            levelBox.AppendText("Max Health:    " + Math.Round(MaxHP) + "->" + Math.Round(MaxHP += 1) + "\n");
            levelBox.AppendText("Health:            " + Math.Round(HP) + "->" + Math.Round(HP += 1) + "\n");
            levelBox.AppendText("Strength:         " + Math.Round(Strength) + "->" + Math.Round(Strength += 1) + "\n");
            await Task.Delay(3000);
            cs.Controls.Remove(levelBox);
        }
        public void gainEP(Monster loser)
        {
            EP += loser.EP;
            if (EP == MaxEP)
            {
                LevelUp();
            }
            if (EP >= MaxEP)
            {
                while (EP >= MaxEP)
                {
                    double e = EP - MaxEP;
                    LevelUp();
                    EP = e;
                }
            }
        }
    }
}
