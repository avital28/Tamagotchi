using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.UI._1
{
    public class PlayerDetailsMenu:MenuScreen
    {
        public PlayerDetailsMenu (): base ("player details screen")
        {
            AddItem("View player details", new PlayerScreen(new ViewDetails(), "view player details"));
            AddItem("Change player details", new PlayerScreen(new ChangeDetailsScreen(), "change details"));
            AddItem("go back to the player animal menu", new PlayerAnimalMenu());
        }
    }
}
