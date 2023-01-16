using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.UI._6._Activities.playing.Games;

namespace Tamagotchi.UI._6._Activities.playing
{
    public class PlayingMenu:MenuScreen
    {
        public PlayingMenu() : base ("")
        {
            AddItem("Ball", new PlayingScreen(new Ball(), ""));
            AddItem("Jumping rope", new PlayingScreen(new Ball(), ""));
            AddItem("Ping Pong", new PlayingScreen(new Ball(), ""));
        }
    }
}
