using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.UI;
using Tamagotchi.UI._5._AnimalMenu;

namespace Tamagotchi.Actions
{
    public class Food : ActivityArchiveScreen
    {
        protected int calories;
        protected int hungerlevelaffect;

        public void Back()
        {
            Console.WriteLine("press any key to go back to the animal action menu");
            Console.ReadKey();
            Screen next = new AnimalActionsMenu();
            next.Show();
        }
    }
}
