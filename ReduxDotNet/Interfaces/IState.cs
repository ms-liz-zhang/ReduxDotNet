﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReduxDotNet.Interfaces
{
    public interface IState<T>
    {
        T Value { get; set; }
    }
}