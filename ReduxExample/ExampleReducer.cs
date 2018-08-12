using ReduxDotNet;
using ReduxDotNet.Interfaces;
using System;

namespace ReduxExample
{
    public class ExampleReducer : BaseReducer<ExampleState<int>, ExampleAction>
    {
        public override ExampleState<int> Reduce(ExampleState<int> state, ExampleAction action)
        {
            var nextState = new ExampleState<int>();
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
