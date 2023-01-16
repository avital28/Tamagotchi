using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.UI._4._AnimalCreation
{
    public class AnimalMainMenu:MenuScreen
    {
        public AnimalMainMenu() : base ("animal main menu")
        {
            AddItem("register", new AnimalCreationScreen());
            AddItem("login", new AnimalLoginScreen());
        }
    }
}
