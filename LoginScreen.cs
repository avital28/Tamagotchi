using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.UI
{
    public class LoginScreen:Screen
    {
        public LoginScreen() : base("Welcome to the login screen, please enter your username and password")
        {

        }

        public override void Show()
        {
            base.Show();

            Console.WriteLine("please enter your username and password");
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            MainUi.p = Data.Data.Login(username, password);
            while (MainUi.p == null)
            {
                Console.WriteLine("login failed, please try again");
                username = Console.ReadLine();
                password = Console.ReadLine();
                MainUi.p = Data.Data.Login(username, password);
            }
            Console.WriteLine("login was successful");
            Screen next2 = new PlayerAnimalMenu();
            next2.Show();   
            Console.ReadKey();
            


        }
    }
}
