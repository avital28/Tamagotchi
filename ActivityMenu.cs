using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.UI._6._Activities.Cleaning;
using Tamagotchi.UI._6._Activities.playing;

namespace Tamagotchi.UI
{
    public class ActivityMenu :MenuScreen
    {
        public ActivityMenu() : base("actions screen")
        {
            AddItem("Feeding", new FeedingMenu());
            AddItem("Cleaning", new CleaningMenu());
            AddItem("Playing", new PlayingMenu());
        }
    }
}
