using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;
using Tamagotchi.UI;

namespace Tamagotchi.Actions
{
    public class FeedingMenu :MenuScreen, IAction
    {
        public void Act() { }
        public FeedingMenu (): base ("feeding menu")
        {
            AddItem("Cookie", new FeedingScreen(new Cookie(), "cookie"));
            AddItem("Rice", new FeedingScreen(new Rice(), "rice"));
            AddItem("Pizza", new FeedingScreen(new Pizza(), "pizza"));
        }
        
    }
}
