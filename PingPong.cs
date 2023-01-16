using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._6._Activities.playing.Games
{
    public class PingPong : Games, IPlay
    {
        public PingPong() { }
        public void Play()
        {
            { Console.WriteLine("nice game"); activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "playing", "ping - pong", MainUi.a.Age, MainUi.a.LifeCycle)); Back(); }
        }


    }
}
