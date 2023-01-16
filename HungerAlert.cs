using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.UI;

namespace Tamagotchi.Events
{
    public static class HungerAlert
    {
        public  static async void PrintAlert (object sender, EventArgs a)
        {
            if (sender is Animal)
            {
                Animal d = (Animal)sender;
                int hunger = d.HungerLevel;
                while (hunger < 5)
                {
                    await Task.Delay(10);
                    MainUi.a.HungerLevel++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (MainUi.a.HungerLevel == 3)
                        Console.WriteLine($"You haven't fed your animal in a while, and its current hunger level is at {MainUi.a.HungerLevel}, would you like to feed it now?");
                    else if (MainUi.a.HungerLevel == 4)
                        Console.WriteLine("Your animal's hunger level is getting dangerously low, press 1 to be transfered to the feeding screen?");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Screen n = new FeedingMenu();
                        n.Show();
                    }
                }
            }
            
        }
    }
}
