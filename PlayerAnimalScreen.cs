using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._1
{
    public class PlayerAnimalScreen: Screen
    {
        private IPlayerAnimal pa;

        public PlayerAnimalScreen (IPlayerAnimal b, string title): base (title)
        {
            pa = b;    
        }

        public override void Show()
        {
            base.Show();
            pa.PlayerAnimal();
        }
    }
}
