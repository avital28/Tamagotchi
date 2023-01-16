using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tamagotchi.Actions;

namespace Tamagotchi.Data
{
    public class Data
    {
      
       
        private static List<Player> playerlist = new List<Player>();
        private static List<Animal> animallist = new List<Animal>();

        //Console.OutputEncoding = Encoding.UTF8;
        public static void AddPlayer()
        {
            DateTime b1 = Convert.ToDateTime("12/1/2006");
            playerlist.Add(new Player("Yali", "Eldar", "Yali12", "123", "female", b1));
            DateTime b2 = DateTime.ParseExact("20/5/1976", "dd/M/yyyy", CultureInfo.InvariantCulture);
            playerlist.Add(new Player("Tal", "Simon", "Talsi", "abc", "male", b2));
        }

        public static void AddAnimal()
        {
            animallist.Add(new Animal("Kitty", "Yali12", 0, "healthy"));
            animallist.Add(new Animal("oliver", "Talsi", 0, "healthy"));
        }

        public static Player Login(string username, string password)
        {
            return playerlist.FirstOrDefault(p => p.Username == username && p.Password == password);

        }

        public static Animal AnimalLogin(string owner, string animalname)
        {
            return animallist.FirstOrDefault(a => a.Owner == owner && a.Animalname == animalname);
        }

        public static void Register(Player P1)
        {
            Player newplayer = playerlist.FirstOrDefault(p => p.Username == p.Username);
            if (newplayer == null)
            {
                playerlist.Add(P1);
            }
        }
    }
}
