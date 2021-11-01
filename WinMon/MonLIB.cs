using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinMon;

namespace WinMon
{
    class MonLIB
    {
        MonsterBase Poofer = new MonsterBase("Poofer", new PictureBox(), Image.FromFile(@".\enemyskin.gif"), new ProgressBar(), new Label());
        MonsterBase Blütense = new MonsterBase("Blütense", new PictureBox(), Image.FromFile(@".\flowmonfrnt.gif"), new ProgressBar(), new Label());
        MonsterBase Jumpy = new MonsterBase("Jumpy", new PictureBox(), Image.FromFile(@".\jumpyfrnt.gif"), new ProgressBar(), new Label());
        MonsterBase monster0 = new MonsterBase("1", new PictureBox(), Image.FromFile(@".\1.png"), new ProgressBar(), new Label());
        MonsterBase monster1 = new MonsterBase("2", new PictureBox(), Image.FromFile(@".\2.png"), new ProgressBar(), new Label());
        MonsterBase monster2 = new MonsterBase("3", new PictureBox(), Image.FromFile(@".\3.png"), new ProgressBar(), new Label());
        MonsterBase monster3 = new MonsterBase("4", new PictureBox(), Image.FromFile(@".\4.png"), new ProgressBar(), new Label());
        MonsterBase monster4 = new MonsterBase("5", new PictureBox(), Image.FromFile(@".\5.png"), new ProgressBar(), new Label());
        MonsterBase monster5 = new MonsterBase("6", new PictureBox(), Image.FromFile(@".\6.png"), new ProgressBar(), new Label());
    }
}
