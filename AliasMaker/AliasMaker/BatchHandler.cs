// Copyright © Krzysztof Oflus 2020. All rights reserved.
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AliasMaker
{
    internal class BatchHandler
    {
        private readonly string _windowsPath = "C:\\Windows";

        public string Name { get; set; }
        public string Path { get; set; }
        
        public void CreateAlias()
        {
            string batchFileContent =
                "@echo off\n" +
                $"\"{Path}\" %*";
            string filePath = _windowsPath + @"\" + Name + ".bat";
            
            File.WriteAllText(filePath, batchFileContent);
        }
    }
}
