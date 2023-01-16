using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi.Actions
{
    public class Activity
    {
        public string Owner { get; set; }
        public string AnimalName { get; set; }    
        
        public string Action { get; set; }  
        public string ActionKind { get; set; }  
        public int Age { get; set; }
        public string Lifecycle { get; set; }

        public Activity(string owner, string animalname, string activity, string activitykind, int age, string lifecycle)
        {
            Owner = owner;
            AnimalName = animalname;
            Action = activity;
            ActionKind =activitykind;
            Age = age;  
            Lifecycle = lifecycle;  
        }
    }
}
