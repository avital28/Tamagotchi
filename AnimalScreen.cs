using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;
using Tamagotchi.UI._1;

namespace Tamagotchi.UI._4._AnimalCreation
{
    public class AnimalScreen : Screen, IPlayerAnimal
    {
        public AnimalScreen() : base("") { }
        public void PlayerAnimal()
        {
            base.Show();
            Screen a = new AnimalMainMenu();
            a.Show();
        }

    }
}
