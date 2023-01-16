using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.UI._6._Activities.Cleaning.CleaningKinds;

namespace Tamagotchi.UI._6._Activities.Cleaning
{
    public class CleaningMenu : MenuScreen
    {
        public CleaningMenu() : base ("cleaning menu")
        {
            AddItem("Shower", new CleaningScreen(new Shower(), "shower"));
        }
    }
}
