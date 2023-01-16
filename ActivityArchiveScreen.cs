using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;
using Tamagotchi.UI;

namespace Tamagotchi.Actions
{
    public class ActivityArchiveScreen : Screen
    {
        public ActivityArchiveScreen() : base("") { }
        public List<Activity> activitiesHistory= new List<Activity>();


        public override void Show()
        {
            Console.Clear();
            IEnumerable<Activity> currentanimalactivities = from n in activitiesHistory where n.AnimalName==MainUi.a.Animalname select n;   
            Console.WriteLine("please choose activities to view:");
            Console.WriteLine("1 - view all past activities");
            Console.WriteLine("2 - view activities sorted by animal's age ");
            Console.WriteLine("3 - view activities sorted by animal's lifecycle");
            Console.WriteLine("4 - view activities sorted by activity kind ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    PrintActivities(currentanimalactivities);
                    if (currentanimalactivities.Any()==false)
                    {
                        Console.WriteLine($"unfortunately we couldn't find any activities");
                    }
                    break;
                case 2:
                    Console.WriteLine("please enter the age you would like to sort your activities by");
                    int age = int.Parse(Console.ReadLine());
                    IEnumerable<Activity> sortedbyage = from a in currentanimalactivities where a.Age == age select a;
                    if (sortedbyage.Any()==false && age !=-1)
                    {
                        Console.WriteLine($"unfortunately we couldn't find any activities that happened when your animal's age was {age}, please enter a new value, or enter -1 to exit");
                         age = int.Parse(Console.ReadLine());
                         sortedbyage = from a in currentanimalactivities where a.Age == age select a;
                    }
                    PrintActivities(sortedbyage);
                    break;
                case 3:
                    Console.WriteLine("please enter the lifecycle you would like to sort your activities by");
                    string lifecycle = Console.ReadLine();
                    IEnumerable<Activity> sortedbylifecycle = from l in currentanimalactivities where l.Lifecycle == lifecycle select l;
                    if (sortedbylifecycle.Any()==false && lifecycle != "e")
                    {
                        Console.WriteLine($"unfortunately we couldn't find any activities that happened when your animal's lifecycle was {lifecycle}, please enter a new value, or enter e to exit");
                        lifecycle = Console.ReadLine();
                        sortedbylifecycle = from l in currentanimalactivities where l.Lifecycle == lifecycle select l;
                    }
                    PrintActivities(sortedbylifecycle);
                    break;
                case 4:
                    Console.WriteLine("please enter the activity kind you would like to sort your activities by");
                    string kind = Console.ReadLine();
                    IEnumerable<Activity> sortedbykind = from k in currentanimalactivities where k.Action == kind select k;
                    if (sortedbykind.Any()==false && kind != "e")
                    {
                        Console.WriteLine($"unfortunately we couldn't find any {kind} activities, please choose another activity kind, or enter e to exit");
                       kind = Console.ReadLine();
                       sortedbykind = from k in currentanimalactivities where k.Action == kind select k;
                    }
                    PrintActivities(sortedbykind);
                    break;



            }

        }

        public void PrintActivities (IEnumerable <Activity> a)
        {
            foreach (Activity activity in a)
            {
                Console.WriteLine("Animal's owner: " + activity.Owner);
                Console.WriteLine("Animal's name: " +activity.AnimalName);
                Console.WriteLine("Animal's age" + activity.Age);
                Console.WriteLine("Animal's Lifecycle" + activity.Lifecycle);
                Console.WriteLine("Activity: " + activity.Action);
                Console.WriteLine("Activity kind: " + activity.ActionKind);
            }
        }
    }
}
