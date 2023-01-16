using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._1
{
    public class ViewDetails: Screen, Idetails
    {
        public ViewDetails() : base("") { }
        public void Details()
        {
            string gender = MainUi.p.Gender;
            Console.WriteLine("player details:");
            Console.WriteLine("First name: "+MainUi.p.Firstname);
            Console.WriteLine("Last name: " + MainUi.p.Lastname);
            Console.WriteLine("Username: " + MainUi.p.Username);
            Console.WriteLine("Password " + MainUi.p.Password);
            Console.WriteLine("Birthday: " + MainUi.p.Birthday.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
            Console.WriteLine("Gender: " + gender[0].ToString().ToUpper() +gender.Substring(1));
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("press any key to go back to the player - animal menu");
            Console.ReadKey();
            Screen next2 = new PlayerDetailsMenu();
            next2.Show();

        }

    }
}
