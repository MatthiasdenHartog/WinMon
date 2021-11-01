using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMon
{
    public class Main
    {
        public MainScreen CurrentScreen;
        public Player player = new Player();
        public CombatScreen combatScreen;
        public Battle battle;

        public Main()
        {
            setupCombatScreen();
        }
        public void setCurrentScreen(Form form)
        {
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Text = "";
            form.TopLevel = false;
            form.TopMost = true;

            try
            {
                Form f = (Form)CurrentScreen.Controls[0];
                f = null;
            }
            catch (Exception)
            { }

            CurrentScreen.Controls.Add(form);
            form.Size = CurrentScreen.Size;
            form.Show();
            CurrentScreen.Controls.SetChildIndex(form, 0);
            form.BringToFront();
            form.Refresh();
        }
        public void setupCombatScreen()
        {

            CurrentScreen = new MainScreen(this);
            setCombatScreen();
            battle = new Battle(this);
            battle.Participants.Add(this.player.OwnedMonsters[0]);
            battle.asyncStartRound();

        }
        public void setCombatScreen()
        {
            combatScreen = new CombatScreen(this);
            setCurrentScreen(combatScreen);
        }
    }
}
