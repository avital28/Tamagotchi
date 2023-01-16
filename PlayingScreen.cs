using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._6._Activities.playing
{
    public class PlayingScreen: Screen
    {
        private IPlay a;

        public PlayingScreen(IPlay a, string title): base(title)
        {
            this.a = a;
        }

        public override void Show()
        {
            base.Show();
            a.Play();
        }
    }
}
