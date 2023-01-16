using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._1
{
    public class ChangeDetailsScreen:Screen, Idetails
    {
        public ChangeDetailsScreen() : base("") { }
        public void Details()
        {
            Console.WriteLine("Please enter the serial number of the player detail you would like to change");
            string gender = MainUi.p.Gender;
            Console.WriteLine("Current player details:");
            Console.WriteLine("1- First name: " + MainUi.p.Firstname);
            Console.WriteLine("2- Last name: " + MainUi.p.Lastname);
            Console.WriteLine("3- Username: " + MainUi.p.Username);
            Console.WriteLine("4- Password " + MainUi.p.Password);
            Console.WriteLine("5- Birthday: " + MainUi.p.Birthday);
            Console.WriteLine("6- Gender: " + gender[0].ToString().ToUpper() + gender.Substring(1));
            Console.WriteLine();
            Console.WriteLine();
            int choice = int.Parse(Console.ReadLine());
            while (choice>=6 && choice<=0)
            {
                Console.WriteLine("please re- enter your choice");
                choice = int.Parse(Console.ReadLine());
            }

                Console.WriteLine("please enter your desired value");
                string newvalue = Console.ReadLine();
            switch (choice)
            {
                case 1:
                    MainUi.p.Firstname= newvalue;
                    break;
                case 2:
                    MainUi.p.Lastname = newvalue;
                    break;
                case 3:
                    MainUi.p.Username = newvalue;
                    break;
                case 4:
                    MainUi.p.Password = newvalue;
                    break;
                case 5:
                    DateTime n = DateTime.Parse(newvalue);
                    MainUi.p.Birthday = n;
                    break;
                case 6:
                    MainUi.p.Gender = newvalue;
                    break;
            }
            Console.WriteLine("Your details have been sucssesfully updated, press any key to go back to the player menu");
            Console.ReadKey();
            Screen next2 = new PlayerDetailsMenu();
            next2.Show();
        }







        //Console.WriteLine("Current player details:");
        //Dictionary<string, string> PlayerDetails = new Dictionary<string, string>();
        //PlayerDetails.Add("1" , "Firstname");
        //PlayerDetails.Add("2" ,"Lastname" );
        //PlayerDetails.Add("3" ,"Username" );
        //PlayerDetails.Add("4",  "Password" );
        //PlayerDetails.Add("5" ,"Birthday");
        //PlayerDetails.Add("6", "Gender");
        //string[] currentdetails = { MainUi.p.Firstname, MainUi.p.Lastname, MainUi.p.Username, MainUi.p.Password, MainUi.p.Birthday.ToString(), MainUi.p.Gender };
        //for (int i = 0; i < PlayerDetails.Count; i++)
        //{
        //    Console.WriteLine(PlayerDetails.ElementAt(i).Key + " - " + PlayerDetails.ElementAt(i).Value + ": "+ currentdetails[i]);
        //}

        //int choice = int.Parse(Console.ReadLine());
        //string t = PlayerDetails.ElementAt(choice).Value;
        //MainUi.p.t

    }


        

        


    }


