using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tamagotchi.UI;

namespace Tamagotchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MainUi app = new MainUi(new WelcomeScreen());
            app.Start();
            Console.ReadKey();
        }
    }
}
