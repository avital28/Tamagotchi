using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._6._Activities.Cleaning
{
    public class CleaningScreen: Screen
    {
        private IClean c;

        public CleaningScreen (IClean c, string title): base (title)
        {
            this.c = c;
        }

        public override void Show()
        {
            base.Show();
            c.Clean();
        }
    }
}
