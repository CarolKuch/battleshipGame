﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Battleship
    {
        public int length;
        public string ownerName;
        private Point[] myLocation;
        private bool isDestroyed = false;

        public Battleship(int length)
        {
            this.length = length;
            Console.WriteLine(length);
        }
        
    }
}