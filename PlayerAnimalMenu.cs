using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.UI._1;
using Tamagotchi.UI._4._AnimalCreation;

namespace Tamagotchi.UI
{
    public class PlayerAnimalMenu: MenuScreen
    {
        public PlayerAnimalMenu() : base ("player - animal menu")
        {
            AddItem("change / view player details", new PlayerAnimalScreen(new PlayerScreen(), "player details"));
            AddItem("main menu animal", new PlayerAnimalScreen(new AnimalScreen(), "animal"));

        }
    }
}
