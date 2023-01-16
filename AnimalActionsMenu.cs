using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.UI._4._AnimalCreation;

namespace Tamagotchi.UI._5._AnimalMenu
{
    public class AnimalActionsMenu : MenuScreen
    {
        public AnimalActionsMenu () : base ("animal menu screen")
        {
            AddItem("activity history", new ActivityArchiveScreen());
            AddItem("change animal's name", new ChangeAnimalDetails());
            AddItem("view details", new ViewAnimalDetails());
            AddItem("activity menu", new ActivityMenu());

        }
    }
}
