using System;
using System.Collections.Generic;
using System.Text;
using ReduxDotNet.Interfaces;

namespace ReduxDotNet
{
    public abstract class BaseReducer<TState, TAction> : IReducer<TState, TAction> where TState : IState where TAction : IAction
    {
        public abstract TState Reduce(TState state, TAction action);

        public override string ToString()
        {
            return GetType().ToString();
        }
    }
}
