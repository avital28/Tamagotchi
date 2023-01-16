using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._6._Activities.playing.Games
{
    public class Jumpingrope: Games, IPlay
    {
        public Jumpingrope() { }

        public void Play()
        {
            { Console.WriteLine("nice game"); activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "playing", "jumping rope", MainUi.a.Age, MainUi.a.LifeCycle)); Back(); }
        }

    }
}
