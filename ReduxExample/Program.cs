using ReduxDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReduxExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialState = new ExampleState<int>();
            var store = new Store<ExampleState<int>, ExampleAction>(initialState, new ExampleReducer());

            store.Subscribe((state) =>
            {
                Console.WriteLine("Total is");
                Console.WriteLine(state.Value);
            });

            while (true)
            {
                Console.WriteLine("Input integer");
                var input = Convert.ToInt32(Console.ReadLine());

                var action = new ExampleAction();

                action.Type = "Add";
                action.Data = input;

                store.Dispatch(action);
 
            }
        }
    }
}
