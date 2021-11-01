using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMon
{
    public class Battle
    {
        public int RoundCounter { get; set; }
        public Round currentRound;
        public List<Monster> Participants = new List<Monster>();
        private CombatScreen cs;
        public Main main;
        public Battle(Main main)
        {
            this.currentRound = new Round();
            this.main = main;
            this.cs = main.combatScreen;
            Random random = new Random(DateTime.Now.Millisecond);
            int i = random.Next(0, 3);
            switch (i)
            {
                case 0:
                    main.combatScreen.enemyMonster = m1;
                    break;
                case 1:
                    main.combatScreen.enemyMonster = m2;
                    break;
                case 2:
                    main.combatScreen.enemyMonster = m3;
                    break;
            }
            Participants.Add(main.combatScreen.enemyMonster);
        }
        public class Round
        {
            public bool m1Decided = false;
            public bool m2Decided = false;
        }
        public async Task asyncStartRound()
        {
            while (monstersAlive())
            {
                await Task.Delay(100);
                main.combatScreen.updateCombatDisplay();
                main.combatScreen.getEnemyDecision();
                if (currentRound.m1Decided && currentRound.m2Decided)
                {
                    Task task = main.combatScreen.evaluator(main.combatScreen.yourMonster, main.combatScreen.enemyMonster);
                    currentRound = new Round();
                    while (!task.IsCompleted) { await Task.Delay(100); }
                    main.combatScreen.updateCombatDisplay();
                }
            }
            if (main.combatScreen.yourMonster.HP <= 0 && main.combatScreen.enemyMonster.HP >= 0)
            {
                main.combatScreen.pnl_resultScreen = new Panel();
                main.combatScreen.Controls.Add(main.combatScreen.pnl_resultScreen);

                main.combatScreen.pnl_resultScreen.Size = main.combatScreen.Size;
                main.combatScreen.pnl_resultScreen.BackColor = Color.LightCoral;
                main.combatScreen.pnl_resultScreen.BringToFront();

                Button btn_Restart = new Button();
                main.combatScreen.pnl_resultScreen.Controls.Add(btn_Restart);
                btn_Restart.Left = (main.combatScreen.pnl_resultScreen.Width - btn_Restart.Width) / 2;
                btn_Restart.Top = (main.combatScreen.pnl_resultScreen.Height - btn_Restart.Height) / 2;
                btn_Restart.Click += new EventHandler(btn_Restart_Click);
                btn_Restart.Text = "Neustarten";
            }
            if (main.combatScreen.yourMonster.HP >= 0 && main.combatScreen.enemyMonster.HP <= 0)
            {
                cs.chatterBox.AppendText(cs.yourMonster.name + " erhält " + cs.enemyMonster.EP + " Erfahrungspunkte.");
                main.combatScreen.yourMonster.gainEP(main.combatScreen.enemyMonster);

            }
        }
        public void btn_Restart_Click(object sender, EventArgs e)
        {
            main.combatScreen.player = main.combatScreen.SavePlayer;
            Monster m1 = Participants.Find(x => x.HP <= 0);
            Participants.Remove(m1);
            Monster m2 = main.combatScreen.player.OwnedMonsters.Find(x => x.name == m1.name);
            Monster m3 = m2.clone();
            Participants.Add(m3);
            main.combatScreen.yourMonster = m3;
            asyncStartRound();
            main.combatScreen.Controls.Remove(main.combatScreen.pnl_resultScreen);
        }
        public bool monstersAlive()
        {
            bool alive = true;
            foreach (Monster monster in Participants)
            {
                if (monster.HP <= 0)
                {
                    alive = false;
                }
            }
            return alive;
        }
    }
}
