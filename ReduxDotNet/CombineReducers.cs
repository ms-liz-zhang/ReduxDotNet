using ReduxDotNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReduxDotNet
{
    public class CombineReducers<TState, TAction> : IReducer<TState, TAction> where TState : IKeyState<String> where TAction : IAction
    {
        private List<IReducer<IState, TAction>> _reducers;

        public CombineReducers(params IReducer<IState, TAction>[] reducers)
        {
            _reducers = new List<IReducer<IState, TAction>>(reducers);
        }

        public TState Reduce(TState state, TAction action)
        {
            var nextState = state.ShallowCopy();

            foreach (var reducer in _reducers)
            {
                var stateAtKey = nextState.Get(reducer.ToString());
                nextState.Set(reducer.ToString(), reducer.Reduce(stateAtKey, action));
            }

            return (TState)nextState;
        }
    }
}
