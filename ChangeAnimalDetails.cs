using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.UI._1;

namespace Tamagotchi.UI._5._AnimalMenu
{
    public class ChangeAnimalDetails : Screen
    {
        public ChangeAnimalDetails() : base("") { }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("please enter the new name you would like to give your animal");
            string name = Console.ReadLine();
            MainUi.a.Animalname = name; 
            Console.WriteLine("Your details have been sucssesfully updated, press any key to go back to the player menu");
            Console.ReadKey();
            Screen next2 = new PlayerDetailsMenu();
            next2.Show();
        }
    }
}
