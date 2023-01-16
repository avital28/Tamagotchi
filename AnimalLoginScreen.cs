using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.UI._5._AnimalMenu;

namespace Tamagotchi.UI._4._AnimalCreation
{
    public class AnimalLoginScreen : Screen
    {
        public AnimalLoginScreen () : base("") { }
        public override async void Show()
        {
            base.Show();

            Console.WriteLine("please enter your username and animal name");
            string username = Console.ReadLine();
            string animalname = Console.ReadLine();
            MainUi.a = Data.Data.AnimalLogin(username, animalname);
            while (MainUi.a == null || MainUi.p.Username!=username)
            {
                Console.WriteLine("login failed, please try again");
                username = Console.ReadLine();
                animalname = Console.ReadLine();
                MainUi.a = Data.Data.AnimalLogin(username, animalname);
            }
            Console.WriteLine("login was successful");
            //await R();
            Screen next2 = new AnimalActionsMenu();
            next2.Show();
            Console.ReadKey();
        }

        //public static async Task R()
        //{
        //    MainUi.a.Start();
        //}

    }

}
