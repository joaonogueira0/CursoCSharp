﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterface.Domain
{
    internal class Vehicle
    {
        public string Model { get; set; }
        public Vehicle(string model)
        {
            Model = model;
        }
    }
}