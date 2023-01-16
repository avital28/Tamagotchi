using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tamagotchi.UI._5._AnimalMenu
{
    public class ViewAnimalDetails: Screen
    {
        public ViewAnimalDetails() : base("") { }

        public override void Show()
        {
            base.Show();
            string h = MainUi.a.HealthStatus;
            Console.WriteLine("Animal details:");
            Console.WriteLine("Owner's username: " + MainUi.p.Username);
            Console.WriteLine("Animal's name " + MainUi.a.Animalname);
            Console.WriteLine("Weight: " + MainUi.a.Weight);
            Console.WriteLine("HealthStatus " + h[0].ToString().ToUpper()+ h.Substring(1));
            Console.WriteLine("Birthday: " + MainUi.a.AnimalBirthday.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
            Console.WriteLine("Age: " + MainUi.a.Age);
            Console.WriteLine();
            Console.WriteLine();
            Console.CursorVisible = false;
            Thread.Sleep(1000);
            Console.WriteLine("press any key to go back");
            Console.CursorVisible = true;
            Console.ReadKey();
            Screen next4 = new AnimalActionsMenu();
            next4.Show();
            

        }
    }
}
