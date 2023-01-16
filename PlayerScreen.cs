using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;
using Tamagotchi.UI._1;

namespace Tamagotchi.UI
{
    public class PlayerScreen : Screen, IPlayerAnimal, Idetails
    {
        private Idetails details;
        public PlayerScreen() :base (" ") { }
        public PlayerScreen (Idetails a, string title): base (title)
        {
            details = a;

        }
        public void Details() { }
        public void PlayerAnimal()
        {
            base.Show();
            Screen a = new PlayerDetailsMenu();
            a.Show();
        }

        public override void Show()
        {
            base.Show();
            details.Details();
        }
    }
}
