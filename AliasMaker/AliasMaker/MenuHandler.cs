// Copyright © Krzysztof Oflus 2020. All rights reserved.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliasMaker
{
    internal class MenuHandler
    {
        private readonly string _mainMenuTemplate =
            "Alias Maker ver. 1.0.0\n" +
            "----------------------\n";

        public void MainMenu()
        {
            Console.Write(_mainMenuTemplate);
            BatchHandler bh = new BatchHandler();
            Console.Write("Type in alias name: ");
            bh.Name = Console.ReadLine();
            Console.Clear();
            Console.Write(_mainMenuTemplate);
            Console.Write("Paste full path for *.exe file\ne.g. C:\\Program Files\\Internet Explorer\\iexplorer.exe\n");
            bh.Path = Console.ReadLine();
            bh.CreateAlias();
            Success();
        }

        public void Success()
        {
            Console.Clear();
            Console.Write(_mainMenuTemplate);
            Console.Write("Alias has been created\n");
        }

    }
}
