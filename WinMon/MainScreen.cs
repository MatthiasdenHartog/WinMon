using System;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;

namespace WinMon
{
    public partial class MainScreen : Form
    {
        private Main main;
        public MainScreen(Main main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {

        }
        private void MainScreen_Resize(object sender, EventArgs e)
        {
            main.combatScreen.Size = main.CurrentScreen.Size;
            //main.combatScreen.btn_attack.Width = (main.combatScreen.Width / 8);
            //main.combatScreen.btn_attack.Height = (main.combatScreen.Height / 9);
            //main.combatScreen.btn_attack.Anchor = AnchorStyles.Top;
            //main.combatScreen.btn_attack.Anchor = AnchorStyles.Left;
            //main.combatScreen.btn_defend.Width = (main.combatScreen.Width / 8);
            //main.combatScreen.btn_defend.Height = (main.combatScreen.Height / 9);
            //main.combatScreen.btn_defend.Anchor = AnchorStyles.Top;
            //main.combatScreen.btn_defend.Anchor = AnchorStyles.Right;
            //main.combatScreen.btn_openBag.Width = (main.combatScreen.Width / 8);
            //main.combatScreen.btn_openBag.Height = (main.combatScreen.Height / 9);
            //main.combatScreen.btn_openBag.Anchor = AnchorStyles.Bottom;
            //main.combatScreen.btn_openBag.Anchor = AnchorStyles.Left;
            //main.combatScreen.btn_changeMon.Width = (main.combatScreen.Width / 8);
            //main.combatScreen.btn_changeMon.Height = (main.combatScreen.Height / 9);
            //main.combatScreen.btn_changeMon.Anchor = AnchorStyles.Bottom;
            //main.combatScreen.btn_changeMon.Anchor = AnchorStyles.Right;



            //main.combatScreen.panel2.Location = new Point(main.combatScreen.Width- (main.combatScreen.panel2.Width+125), main.combatScreen.Height - (main.combatScreen.panel2.Height + 75));
            //main.combatScreen.Scale(1);
            //main.combatScreen.panel2.Size = new Size(main.combatScreen.Width / 3, main.combatScreen.Height / 4);

        }
    }
}
