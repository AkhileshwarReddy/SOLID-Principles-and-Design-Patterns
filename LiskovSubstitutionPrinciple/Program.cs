﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            #if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
            #endif
        }
    }
}