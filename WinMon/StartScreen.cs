using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinMon
{
    public partial class StartScreen : Form
    {
        private Main main;
        public StartScreen(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.setCombatScreen();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            main.setCombatScreen();
        }
    }
}
