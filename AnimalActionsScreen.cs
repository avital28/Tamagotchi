using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._4._AnimalCreation
{
    public class AnimalActionsScreen: Screen
    {
        private IAction a;
        public AnimalActionsScreen (IAction b, string title): base (title)
        {
            a = b;
        }

        public override void Show()
        {
            base.Show();
            a.Act();

        }

    }
}
