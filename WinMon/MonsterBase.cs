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
    public class MonsterBase
    {
        public string name { get; set; }
        public PictureBox frame { get; set; }
        public Image image { get; set; }
        public ProgressBar healthbar;
        public Label namedisplay;

        public MonsterBase(string name, PictureBox frame, Image image, ProgressBar healthbar, Label namedisplay)
        {
            this.name = name;
            this.frame = frame;
            this.image = image;
            this.healthbar = healthbar;
            this.namedisplay = namedisplay;
        }
        public MonsterBase(string name)
        {
            this.name = name;
        }

    }
}
