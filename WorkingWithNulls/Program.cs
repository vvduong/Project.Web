﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithNulls
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();

            player.Name = "Sarah";

            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
