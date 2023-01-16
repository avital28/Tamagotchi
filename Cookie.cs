using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.Actions
{
    public class Cookie : Food, IFeed
    {
        public Cookie() 
        {
            calories = 300;
            hungerlevelaffect= 1;   
        }
        public void Feed() 
        { Console.WriteLine("well fed"); 

          activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "feeding", "cookie", MainUi.a.Age, MainUi.a.LifeCycle));
            Back();

        
        }

    }
}
