using ReduxDotNet;
using ReduxDotNet.Interfaces;
using System;

namespace ConsoleApp1
{
    public class ExampleReducer : IReducer<int, ExampleAction>
    {
        public IState<int> Reduce(IState<int> state, ExampleAction action)
        {
            var nextState = new State<int>();
            nextState.Value = state.Value;

            switch(action.Type)
            {
                case "Add":
                    nextState.Value += action.Data;
                    return nextState;
                default:
                    return nextState;
            }
        }
    }
}
