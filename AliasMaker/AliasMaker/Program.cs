// Copyright © Krzysztof Oflus 2020. All rights reserved.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliasMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            DisableConsoleEdit dce = new DisableConsoleEdit();
            MenuHandler mh = new MenuHandler();

            dce.DisableEdit();
            mh.MainMenu();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
