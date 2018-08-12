using System;
using System.Collections.Generic;
using System.Text;

namespace ReduxDotNet.Interfaces
{
    public interface IReducer<T, TAction> where TAction : IAction
    {
        IState<T> Reduce(IState<T> state, TAction action);
    }
}
