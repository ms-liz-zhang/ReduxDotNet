using System;


namespace ReduxDotNet.Interfaces
{
    public interface IListener<T>
    {
        void Invoke(IState<T> state);
    }
}
