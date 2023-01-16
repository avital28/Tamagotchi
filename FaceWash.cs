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
    public class FaceWash:ActivityArchiveScreen, IClean
    {
        public FaceWash() { }

        public void Clean()
        {
            Console.WriteLine("face has been successfully washed");
            activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "cleaning", "face wash", MainUi.a.Age, MainUi.a.LifeCycle));
            Console.CursorVisible = false;
            Thread.Sleep(1000);
            Console.WriteLine("press any key to go back to the activities menu");
            Console.CursorVisible = true;
            Console.ReadKey();
            Screen next = new CleaningMenu();
            next.Show();    
        }
    }
}
