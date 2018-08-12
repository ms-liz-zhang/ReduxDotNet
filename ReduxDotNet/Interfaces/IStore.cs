using System;
using System.Collections.Generic;
using System.Text;

namespace ReduxDotNet.Interfaces
{
    interface IStore<T, TAction> where TAction : IAction
    {
        void Subscribe(Action<IState<T>> listener);
        void Unsubscribe(Action<IState<T>> listener);
        void Dispatch(TAction action);
    }
}
