using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace WinMon
{
    public partial class CombatScreen : Form
    {
        public Monster yourMonster;
        public Monster enemyMonster;
        private Main main;
        public Player player;
        public Task[] tasks;
        public bool screenShown = false;
        public Player SavePlayer;
        public Panel pnl_resultScreen;
        public CombatScreen(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.player = main.player;
            this.SavePlayer = player.clonePlayer();


            yourMonster = player.OwnedMonsters[0];
            yourMonster.cs = this;
            lbl_Round.Location = new Point(panel1.Width / 2 - lbl_Round.Width / 2);
        }

        private void Combat_Load(object sender, EventArgs e)
        {
            setHUD();
            setYourInterface();
            fillMonList();
        }
        public async void setYourInterface()
        {
            PictureBox yourPB = new PictureBox();
            yourPB.Location = new Point(195, 270);
            yourPB.Size = new Size(225, 300);
            yourPB.Anchor = AnchorStyles.Bottom;
            yourPB.BackColor = Color.Transparent;
            yourPB.Image = yourMonster.image;
            this.Controls.Add(yourMonster.frame);

            yourMonster.healthbar.Minimum = 0;
            yourMonster.healthbar.Maximum = Convert.ToInt32(yourMonster.MaxHP);
            yourMonster.healthbar.Value = Convert.ToInt32(yourMonster.HP);
            yourMonster.healthbar.Size = new Size(225, 15);
            yourMonster.healthbar.Location = new Point(yourMonster.frame.Location.X, yourMonster.frame.Location.Y - yourMonster.healthbar.Height);
            yourMonster.healthbar.Anchor = AnchorStyles.Bottom;
            yourMonster.healthbar.Style = ProgressBarStyle.Continuous;
            yourMonster.healthbar.BackColor = Color.White;
            changePBColour(yourMonster, yourMonster.healthbar);
            this.Controls.Add(yourMonster.healthbar);

            yourMonster.namedisplay.Text = yourMonster.name;
            yourMonster.namedisplay.Size = new Size(225, 15);
            yourMonster.namedisplay.Location = new Point(yourMonster.healthbar.Location.X, yourMonster.healthbar.Location.Y - yourMonster.namedisplay.Height);
            yourMonster.namedisplay.Anchor = AnchorStyles.Bottom;
            yourMonster.namedisplay.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(yourMonster.namedisplay);
        }
        public void setEnemyInterface()
        {
            enemyMonster.frame = new PictureBox();
            enemyMonster.frame.Location = new Point(595, 70);
            enemyMonster.frame.Size = new Size(225, 300);
            enemyMonster.frame.Anchor = AnchorStyles.Right;
            enemyMonster.frame.Anchor = AnchorStyles.Top;
            enemyMonster.frame.Image = enemyMonster.image;
            this.Controls.Add(enemyMonster.frame);

            enemyMonster.healthbar.Minimum = 0;
            enemyMonster.healthbar.Maximum = Convert.ToInt32(enemyMonster.MaxHP);
            enemyMonster.healthbar.Value = Convert.ToInt32(enemyMonster.HP);
            enemyMonster.healthbar.Size = new Size(225, 15);
            enemyMonster.healthbar.Location = new Point(enemyMonster.frame.Location.X, enemyMonster.frame.Location.Y - enemyMonster.healthbar.Height);
            enemyMonster.healthbar.Anchor = AnchorStyles.Right;
            enemyMonster.healthbar.Anchor = AnchorStyles.Top;
            enemyMonster.healthbar.Style = ProgressBarStyle.Continuous;
            enemyMonster.healthbar.BackColor = Color.White;
            changePBColour(enemyMonster, enemyMonster.healthbar);
            this.Controls.Add(enemyMonster.healthbar);

            enemyMonster.namedisplay.Text = enemyMonster.name;
            enemyMonster.namedisplay.Size = new Size(225, 15);
            enemyMonster.namedisplay.Location = new Point(enemyMonster.healthbar.Location.X, enemyMonster.healthbar.Location.Y - enemyMonster.namedisplay.Height);
            enemyMonster.namedisplay.Anchor = AnchorStyles.Right;
            enemyMonster.namedisplay.Anchor = AnchorStyles.Top;
            enemyMonster.namedisplay.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(enemyMonster.namedisplay);

        }
        public void setHUD()
        {
            setEnemyInterface();
            setYourInterface();
            chatterBox.Anchor = AnchorStyles.Left;
            btn_attack.Text = "Angreifen \n" + yourMonster.availAmountAtk + @"\" + yourMonster.amountAtk;
            btn_defend.Text = "Verteidigen \n" + yourMonster.availAmountDef + @"\" + yourMonster.amountDef;
            btn_openBag.Text = "Heilen \n" + yourMonster.availAmountHeal + @"\" + yourMonster.amountHeal;
            pnl_monList.Hide();
            lbl_Round.Anchor = AnchorStyles.Top;
        }
        public void updateCombatDisplay()
        {
            if (yourMonster.availAmountAtk > 0) { btn_attack.Enabled = true; } else { btn_attack.Enabled = false; }
            btn_attack.Text = "Angreifen \n" + yourMonster.availAmountAtk + @"\" + yourMonster.amountAtk;
            if (yourMonster.availAmountDef > 0) { btn_defend.Enabled = true; } else { btn_defend.Enabled = false; }
            btn_defend.Text = "Verteidigen \n" + yourMonster.availAmountDef + @"\" + yourMonster.amountDef;
            if (yourMonster.availAmountHeal > 0) { btn_openBag.Enabled = true; } else { btn_openBag.Enabled = false; }
            btn_openBag.Text = "Heilen \n" + yourMonster.availAmountHeal + @"\" + yourMonster.amountHeal;
            yourMonster.isBlocking = false;
            enemyMonster.isBlocking = false;
            if (yourMonster.HP < 0)
            {
                yourMonster.HP = 0;
            }
            if (enemyMonster.HP < 0)
            {
                enemyMonster.HP = 0;
            }
            yourMonster.healthbar.Value = Convert.ToInt32(yourMonster.HP);
            changePBColour(yourMonster, yourMonster.healthbar);
            enemyMonster.healthbar.Value = Convert.ToInt32(enemyMonster.HP);
            changePBColour(enemyMonster, enemyMonster.healthbar);
            yourMonster.namedisplay.Text = yourMonster.name;
            enemyMonster.namedisplay.Text = enemyMonster.name;

        }
        public void removeInterface()
        {
            this.Controls.Remove(yourMonster.healthbar);
            this.Controls.Remove(yourMonster.frame);
            this.Controls.Remove(yourMonster.namedisplay);
        }
        public void changePBColour(Monster monster, ProgressBar p)
        {
            if (monster.HP >= monster.MaxHP / 2) { p.ForeColor = Color.LimeGreen; }
            if (monster.HP < monster.MaxHP / 2) { p.ForeColor = Color.Gold; };
            if (monster.HP <= monster.MaxHP / 10) { p.ForeColor = Color.Red; };
        }
        public async Task evaluator(Monster monster1, Monster monster2)
        {
            if (monster1.decidedAction == 0 || monster2.decidedAction == 0)
            {
                if (monster1.decidedAction == monster2.decidedAction)
                {
                    if (monster1.Speed != monster2.Speed)
                    {
                        Monster m1 = main.battle.Participants.First(x => x.Speed == main.battle.Participants.Max(y => y.Speed));
                        Monster m2 = main.battle.Participants.Find(x => x.Speed < main.battle.Participants.Max(y => y.Speed));

                        chatterBoxChatteringAttack(m1, m2);
                        chatterBoxChatteringAttack(m2, m1);
                    }
                    if (monster1.Speed == monster2.Speed)
                    {
                        Random random = new Random();
                        int i = random.Next(0, 2);
                        switch (i)
                        {
                            case 0:
                                chatterBoxChatteringAttack(monster1, monster2);
                                chatterBoxChatteringAttack(monster2, monster1);
                                break;
                            case 1:
                                chatterBoxChatteringAttack(monster2, monster1);
                                chatterBoxChatteringAttack(monster1, monster2);
                                break;
                        }
                    }
                }
                if (monster1.decidedAction == 1 || monster2.decidedAction == 1)
                {
                    Monster m1 = main.battle.Participants.First(x => x.decidedAction == 1);
                    await asyncChatterBoxChatteringDefense(m1);
                    Monster m2 = main.battle.Participants.First(x => x.decidedAction == 0);
                    chatterBoxChatteringAttack(m2, m1);
                }
                if (monster1.decidedAction == 2 || monster2.decidedAction == 2)
                {
                    Monster m1 = main.battle.Participants.First(x => x.decidedAction == 2);
                    await asyncChatterBoxChatteringHealing(m1);
                    Monster m2 = main.battle.Participants.First(x => x.decidedAction == 0);
                    chatterBoxChatteringAttack(m2, m1);
                }
                if (monster1.decidedAction == 3 || monster2.decidedAction == 3)
                {
                    Monster m1 = main.battle.Participants.First(x => x.decidedAction == 3);
                    await asyncChatterBoxChatteringSwitch(m1);
                    Monster m2 = main.battle.Participants.First(x => x.decidedAction == 0);

                    chatterBoxChatteringAttack(m2, m1);
                }
            }
            if (monster1.decidedAction == 1 || monster2.decidedAction == 1)
            {
                if (monster1.decidedAction == monster2.decidedAction)
                {
                    await asyncChatterBoxChatteringDefense(monster1);
                    await asyncChatterBoxChatteringDefense(monster2);
                }
                if (monster1.decidedAction == 2 || monster2.decidedAction == 2)
                {
                    Monster m1 = main.battle.Participants.First(x => x.decidedAction == 1);
                    await asyncChatterBoxChatteringDefense(m1);
                    Monster m2 = main.battle.Participants.First(x => x.decidedAction == 2);
                    await asyncChatterBoxChatteringHealing(m2);
                }
                if (monster1.decidedAction == 3 || monster2.decidedAction == 3)
                {
                    Monster m1 = main.battle.Participants.First(x => x.decidedAction == 3);
                    await asyncChatterBoxChatteringSwitch(m1);
                    Monster m2 = main.battle.Participants.First(x => x.decidedAction == 1);
                    await asyncChatterBoxChatteringDefense(m2);
                }
            }
            if (monster1.decidedAction == 2 || monster2.decidedAction == 2)
            {
                if (monster1.decidedAction == monster2.decidedAction)
                {
                    await asyncChatterBoxChatteringHealing(monster1);
                    await asyncChatterBoxChatteringHealing(monster2);
                }
                if (monster1.decidedAction == 3 || monster2.decidedAction == 3)
                {
                    Monster m1 = main.battle.Participants.First(x => x.decidedAction == 3);
                    await asyncChatterBoxChatteringSwitch(m1);
                    Monster m2 = main.battle.Participants.First(x => x.decidedAction == 2);
                    await asyncChatterBoxChatteringHealing(m2);
                }
            }
            if (monster1.decidedAction == 3 && monster2.decidedAction == 3)
            {
                await asyncChatterBoxChatteringSwitch(monster1);
                await asyncChatterBoxChatteringSwitch(monster2);
            }
            monster1.decidedAction = -1;
            monster2.decidedAction = -1;
        }
        public void btn_attack_Click(object sender, EventArgs e)
        {
            yourMonster.decidedAction = 0;
            main.battle.currentRound.m1Decided = true;
            yourMonster.availAmountAtk--;
            updateCombatDisplay();
        }
        public void btn_defend_Click(object sender, EventArgs e)
        {
            yourMonster.decidedAction = 1;
            yourMonster.availAmountDef--;
            main.battle.currentRound.m1Decided = true;
        }
        public void btn_openBag_Click(object sender, EventArgs e)
        {
            yourMonster.decidedAction = 2;
            main.battle.currentRound.m1Decided = true;
            yourMonster.availAmountHeal--;
            updateCombatDisplay();
        }
        public void getEnemyDecision()
        {   // switch unmöglich aufgrund von variable
            if (enemyMonster.HP <= enemyMonster.MaxHP / 9) { enemyMonster.decidedAction = 2; }
            if (enemyMonster.HP <= enemyMonster.MaxHP / 2) { enemyMonster.decidedAction = 1; }
            if (enemyMonster.HP >= enemyMonster.MaxHP / 2) { enemyMonster.decidedAction = 0; }
            enemyMonster.decidedAction = 0;
            main.battle.currentRound.m2Decided = true;

        }
        public void chatterBoxChatteringAttack(Monster attacker, Monster target)
        {
            chatterBox.AppendText(attacker.name + " greift an \n");


            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                int x = rnd.Next(0, target.frame.Width - 10);
                int y = rnd.Next(0, target.frame.Height - 10);
                PictureBox pb = new PictureBox();
                pb.Image = Image.FromFile(@".\hit.gif");
                pb.Location = new Point(x, y);
                pb.Anchor = target.frame.Anchor;
                pb.Parent = target.frame;
                pb.BackColor = Color.Transparent;
                target.frame.Controls.Add(pb);
                target.frame.Controls.Remove(pb);
            }
            attacker.attack(target);
            chatterBox.AppendText(attacker.name + " verursacht " + Math.Round(attacker.dealtDamage) + " Schaden \n");
        }
        public async Task asyncChatterBoxChatteringDefense(Monster m1)
        {
            chatterBox.AppendText(m1.name + " verteidigt sich \n");
            await Task.Delay(500);
            m1.defend();
            await Task.Delay(1000);
        }
        public async Task asyncChatterBoxChatteringHealing(Monster m1)
        {
            chatterBox.AppendText(m1.name + " heilt sich \n");
            await Task.Delay(500);
            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                int x = rnd.Next(10, m1.frame.Width - 10);
                int y = rnd.Next(10, m1.frame.Height - 10);
                PictureBox pb = new PictureBox();
                pb.Image = Image.FromFile(@".\heal.gif");
                pb.Location = new Point(x, y);
                pb.Anchor = m1.frame.Anchor;
                pb.Parent = m1.frame;
                pb.BackColor = Color.Transparent;
                m1.frame.Controls.Add(pb);
                await Task.Delay(1500);
                m1.frame.Controls.Remove(pb);
            }
            m1.heal();
            m1.decidedAction = 2;
            await Task.Delay(1000);
        }
        public async Task asyncChatterBoxChatteringSwitch(Monster m1)
        {
            chatterBox.AppendText(main.player.Name + " wechselt sein Mon aus \n");
            m1.decidedAction = 3;
            await Task.Delay(500);
        }
        public void showResultScreen()
        {
            buildResultScreen();
        }
        public void buildResultScreen()
        {
            if (yourMonster.HP <= 0)
            {
                pnl_resultScreen = new Panel();
                this.Controls.Add(pnl_resultScreen);

                pnl_resultScreen.Size = this.Size;
                pnl_resultScreen.BackColor = Color.LightCoral;
                pnl_resultScreen.BringToFront();

                Button btn_Restart = new Button();
                pnl_resultScreen.Controls.Add(btn_Restart);
                btn_Restart.Left = (pnl_resultScreen.Width - btn_Restart.Width) / 2;
                btn_Restart.Top = (pnl_resultScreen.Height - btn_Restart.Height) / 2;
                btn_Restart.Click += new EventHandler(btn_Restart_Click);

            }
        }
        public void deactivateResultScreen()
        {
            this.Controls.Remove(pnl_resultScreen);
        }
        public void btn_Restart_Click(object sender, EventArgs e)
        {
            main.combatScreen.player = main.combatScreen.SavePlayer;
        }
        public void fillMonList()
        {
            int i = 0;
            //   pnl_monList.Controls[0] = btn_mon1;
            tlP_monPanel.Controls.Add(btn_mon1);
            tlP_monPanel.Controls.Add(btn_mon2);
            tlP_monPanel.Controls.Add(btn_mon3);
            tlP_monPanel.Controls.Add(btn_mon4);
            tlP_monPanel.Controls.Add(btn_mon5);
            tlP_monPanel.Controls.Add(btn_mon6);
            foreach (Button button in tlP_monPanel.Controls)
            {
                tlP_monPanel.Controls[i].Text = player.OwnedMonsters[i].name;
                i++;
            }
        }
        public void animateMonList()
        {

            Util.Animate(pnl_monList, Util.Effect.Slide, 500, 360);
        }
        private void btn_changeMon_Click(object sender, EventArgs e)
        {
            animateMonList();
        }
        private void changeConfirmed(Monster m1)
        {
            m1.decidedAction = 3;
        }
        private void btn_mon1_Click(object sender, EventArgs e)
        {
            yourMonster.decidedAction = 3;
            main.battle.currentRound.m1Decided = true;
            removeInterface();
            yourMonster = player.OwnedMonsters[0];
            setYourInterface();
        }
        private void btn_mon2_Click(object sender, EventArgs e)
        {
            yourMonster.decidedAction = 3;
            main.battle.currentRound.m1Decided = true;
            removeInterface();
            yourMonster = player.OwnedMonsters[1];
            setYourInterface();
        }
        private void btn_mon3_Click(object sender, EventArgs e)
        {
            yourMonster.decidedAction = 3;
            main.battle.currentRound.m1Decided = true;
            removeInterface();
            yourMonster = player.OwnedMonsters[2];
            setYourInterface();
        }
        private void btn_mon4_Click(object sender, EventArgs e)
        {
            yourMonster.decidedAction = 3;
            main.battle.currentRound.m1Decided = true;
            removeInterface();
            yourMonster = player.OwnedMonsters[3];
            setYourInterface();
        }
        private void btn_mon5_Click(object sender, EventArgs e)
        {
            yourMonster.decidedAction = 3;
            main.battle.currentRound.m1Decided = true;
            removeInterface();
            yourMonster = player.OwnedMonsters[4];
            setYourInterface();
        }
        private void btn_mon6_Click(object sender, EventArgs e)
        {
            yourMonster.decidedAction = 3;
            main.battle.currentRound.m1Decided = true;
            removeInterface();
            yourMonster = player.OwnedMonsters[5];
            setYourInterface();
        }
    }
}
