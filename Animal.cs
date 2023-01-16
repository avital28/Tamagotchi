using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Events;

namespace Tamagotchi
{
    public class Animal
    {
        
        public event EventHandler<EventArgs> IsHungry;

        public event EventHandler<int> OnProgressUpdate;

        
        public string Animalname { get; set; }
        
        public DateTime LastFed { get; set; }
        public string Owner { get; set; }   
        public int Weight { get; set; } 
        public int Age { get; set; }    
        public DateTime AnimalBirthday { get; }

        public string LifeCycle { get; set; }
        public string HealthStatus { get; set; }
        public bool IsAlive { get; set; }

        public int HungerLevel { get; set; }    

        public Animal() { }
        public Animal (string animalname, string owner, int weight, string healthStatus)
        {
            Animalname = animalname;
            Owner = owner;
            Weight = weight;
            Age = 0;
            AnimalBirthday = DateTime.Now;
            IsAlive = true;
            LifeCycle = "baby";
            HealthStatus = healthStatus;
        }

        public Animal(string owner)
        {
            Owner = owner;  
            Weight= 0;
            Age= 0;
            AnimalBirthday= DateTime.Now;
            IsAlive = true;
            LifeCycle = "baby";
        }

        public void Start ()
        {
            IsHungry += HungerAlert.PrintAlert;
            IsHungry.Invoke(MainUi.a, new EventArgs());
        }

        

        
    }
}
