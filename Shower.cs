using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._6._Activities.Cleaning.CleaningKinds
{
    public class Shower : ActivityArchiveScreen, IClean
    {
        public Shower ()  { }
        public void Clean()
        {
            Console.WriteLine("your animal has been cleaned");
            activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "cleaning", "shower", MainUi.a.Age, MainUi.a.LifeCycle));
            Console.CursorVisible = false;
            Thread.Sleep(1000);
            Console.WriteLine("press any key to go back to the activities menu");
            Console.CursorVisible = true;
            Console.ReadKey();
            Screen next = new ActivityMenu();
            next.Show();

        }
    }
}
    

