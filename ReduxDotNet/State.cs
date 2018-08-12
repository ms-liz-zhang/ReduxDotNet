using ReduxDotNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReduxDotNet
{
    public class State<T> : IState<T>
    {
        public T Value { get; set; }
    }
}
