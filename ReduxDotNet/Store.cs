using ReduxDotNet.Interfaces;
using System;
using System.Collections.Generic;

namespace ReduxDotNet
{
    public class Store<T, TAction> : IStore<T, TAction> where TAction : IAction
    {
        private IState<T> _state;
        private List<Action<IState<T>>> _listeners;
        private IReducer<T, TAction> _reducer;

        public Store(IState<T> initialState, IReducer<T, TAction> reducer)
        {
            _listeners = new List<Action<IState<T>>>();
            _state = initialState;
            _reducer = reducer;
        }
        
        public void Subscribe(Action<IState<T>> listener)
        {
            _listeners.Add(listener);
        }

        public void Unsubscribe(Action<IState<T>> listener)
        {
            _listeners.Remove(listener);
        }

        public void Dispatch(TAction action)
        {
            _state = _reducer.Reduce(_state, action);

            foreach(var listener in _listeners)
            {
                listener.Invoke(_state);
            }
        }
    }
}