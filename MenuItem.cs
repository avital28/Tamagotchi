using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.UI
{
    public class MenuItem
    {
        public string ItemName { get; set; }
        public Screen Screen { get; set; }

        public MenuItem(string itemName, Screen screen)
        {
            ItemName = itemName;
            Screen = screen;
        }

        public void Show()
        {
            Screen.Show();
        }
    }
}
