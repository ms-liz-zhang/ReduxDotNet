﻿using ReduxDotNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReduxExample
{ 
    public class ExampleAction : IAction
    {
        public string Type { get; set; }
        public int Data { get; set; }
    }
}
