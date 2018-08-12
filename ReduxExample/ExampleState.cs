using ReduxDotNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReduxExample
{
    public class ExampleState<T> : IState
    {
       public T Value { get; set; }
    }
}
