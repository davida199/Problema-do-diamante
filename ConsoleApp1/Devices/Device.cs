﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Device
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDoc(string doc);
    }
}
