using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;
using Tamagotchi.UI._1;

namespace Tamagotchi.UI
{
    public class MenuScreen:Screen
    {
        List<MenuItem> screens;

        public MenuScreen(List<MenuItem> screens) : base("welcome to the menu screen, please choose your next action")
        {
            this.screens = screens;
        }

        public MenuScreen(string a) : base(a)
        {
            screens = new List<MenuItem>();
        }


        public void AddItem(string n, Screen s)
        {
            screens.Add(new MenuItem(n, s));
        }
        public override void Show()
        {
            int choice;
            base.Show();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" ".PadLeft(40));
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("please choose one of the following options");
            Console.WriteLine();
            Console.ResetColor();
            for (int i = 0; i < screens.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {screens[i].ItemName} ");
            }
            while (!(int.TryParse(Console.ReadLine(), out choice)))
            {
                Console.WriteLine("invalid choice, please try again");
            }

            while (!(choice > 0 && choice <= screens.Count))
            {
                Console.WriteLine("please choose again");
                while (!(int.TryParse(Console.ReadLine(), out choice))) { }
            }
            screens[choice - 1].Show();
          

            

            



        }
    }
}
