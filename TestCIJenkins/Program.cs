﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCIJenkins
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAjoutClasse t = new TestAjoutClasse();
            Console.WriteLine(t.GetMessage());
            Console.ReadKey();
        }
    }
}
