using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;
using Tamagotchi.UI;

namespace Tamagotchi.Actions
{
    public class FeedingScreen : Screen, IAction
    {
        public void Act()
        { 
          Screen a=new FeedingMenu();
          a.Show();
        }

        private IFeed feed;

        public FeedingScreen(): base (" ") { }
        public FeedingScreen(IFeed a, string title) : base(title)
        {
            feed = a;

        }

        public override void Show()
        {
            base.Show();
            feed.Feed();
        }
    }
}
