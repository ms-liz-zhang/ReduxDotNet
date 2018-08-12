using System;
using System.Collections.Generic;
using System.Text;

namespace ReduxDotNet.Interfaces
{
    interface IStore<TState, TAction> where TState : IState where TAction : IAction
    {
        void Subscribe(Action<TState> listener);
        void Unsubscribe(Action<TState> listener);
        void Dispatch(TAction action);
    }
}
