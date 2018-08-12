using System;
using System.Collections.Generic;
using System.Text;

namespace ReduxDotNet.Interfaces
{
    public interface IReducer<TState, TAction> where TState : IState where TAction : IAction
    {
        TState Reduce(TState state, TAction action);
    }
}
