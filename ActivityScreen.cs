using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI
{
    public class ActivityScreen:Screen, IAction
    {
        public ActivityScreen() : base("") { }
        public void Act()
        {
            Screen next3 = new ActivityMenu();
            next3.Show();
        }
    }
}
