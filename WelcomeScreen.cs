using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//using System.Drawing.Color FromArgb (int alpha, int red, int green, int blue);

namespace Tamagotchi.UI
{
    public class WelcomeScreen:Screen
    {
        public WelcomeScreen() : base(" ")
        {
        }
         
        

        public override void Show()
        {
            base.Show();

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(@"
╦ ╦┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐  ┌┬┐┌─┐   ┌┬┐┬ ┬┌─┐                  __O__
║║║├┤ │  │  │ ││││├┤    │ │ │    │ ├─┤├┤                  '     '
╚╩╝└─┘┴─┘└─┘└─┘┴ ┴└─┘   ┴ └─┘    ┴ ┴ ┴└─┘               '         '
╔╦╗┌─┐┌┬┐┌─┐┌─┐┌─┐┌┬┐┌─┐┬ ┬┬                           .'         '.
 ║ ├─┤│││├─┤│ ┬│ │ │ │  ├─┤│                          .  _________  .
 ╩ ┴ ┴┴ ┴┴ ┴└─┘└─┘ ┴ └─┘┴ ┴┴                          : |   .-.   | :
┌─┐┌─┐┌┬┐┌─┐┬                                        :  |  ( - )  |  :
│ ┬├─┤│││├┤ │                                        :  |   "" ""   |  :
└─┘┴ ┴┴ ┴└─┘o                                        :  |_________|  :
                                                      |             |
                                                      '   O     O   '
                                                       ',    O    ,'
                                                         '.......'
                                                               
                                                                  
");

            Console.ResetColor();
            System.Threading.Thread.Sleep(700);
            Console.WriteLine();
            Console.WriteLine("press any key to continue");
            Console.CursorVisible = true;
            Console.ReadKey();
            Screen next = new MainMenuScreen();
            next.Show();

        }

    }
}

