using System;
using System.Collections.Generic;
using System.Text;

namespace ReduxDotNet.Interfaces
{
    public interface IKeyState<T> : IState
    {
        IState Get(T key);
        void Set(T key, IState state);
        IKeyState<T> ShallowCopy();
    }
}
