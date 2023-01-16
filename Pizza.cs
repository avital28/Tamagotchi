using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.Actions
{
    public class Pizza:Food, IFeed
    {
        public Pizza() 
        {
            calories = 450;
            hungerlevelaffect = 3;
        }
        public void Feed() { Console.WriteLine("well fed"); activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "feeding", "Pizza", MainUi.a.Age, MainUi.a.LifeCycle)); Back(); }

    }
}
