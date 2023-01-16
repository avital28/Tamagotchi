using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class Player
    {
        private string firstname;
        private string lastname;
        public string Firstname { get { return firstname; } set { if (value[0] < 'A' || value[0] > 'Z') throw new Exception("First name must start with a capital letter"); else firstname = value; } }
        public string Lastname { get { return lastname; } set { if (value[0] < 'A' || value[0] > 'Z') throw new Exception("Last name must start with a capital letter"); else lastname = value; } }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }

        public Player (string firstname, string lastname, string username, string password, string gender, DateTime birthday)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Password = password;
            Gender = gender;
            Birthday = birthday;
        }


        
        



    }
}
