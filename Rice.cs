using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.Actions
{
    public class Rice: Food, IFeed
    {
        public Rice() 
        {
            calories = 270;
            hungerlevelaffect = 2;
        }
        public void Feed() { Console.WriteLine("well fed"); activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "feeding", "Rice", MainUi.a.Age, MainUi.a.LifeCycle)); Back(); }

    }
}
