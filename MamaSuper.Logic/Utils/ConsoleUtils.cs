﻿using System;

namespace MamaSuper.Logic.Utils
{
    public static class ConsoleUtils
    {
        /// <summary>
        /// Prints an output then returns the user input
        /// </summary>
        public static string GetInputAfterOutput(string output)
        {
            Console.WriteLine(output);
            return Console.ReadLine();
        }
    }
}