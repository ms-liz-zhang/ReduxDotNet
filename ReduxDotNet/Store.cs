using ReduxDotNet.Interfaces;
using System;
using System.Collections.Generic;

namespace ReduxDotNet
{
    public class Store<TState, TAction> : IStore<TState, TAction> where TState : IState where TAction : IAction
    {
        private TState _state;
        private List<Action<TState>> _listeners;
        private IReducer<TState, TAction> _reducer;

        public Store(TState initialState, IReducer<TState, TAction> reducer)
        {
            _listeners = new List<Action<TState>>();
            _state = initialState;
            _reducer = reducer;
        }
        
        public void Subscribe(Action<TState> listener)
        {
            _listeners.Add(listener);
        }

        public void Unsubscribe(Action<TState> listener)
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