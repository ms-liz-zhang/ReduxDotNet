using ReduxDotNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReduxDotNet
{
    public class BaseKeyState<T> : IKeyState<T>
    {
        private Dictionary<T, IState> _dictionary;

        public BaseKeyState(Dictionary<T, IState> dictionary)
        {
            _dictionary = dictionary;
        }

        public BaseKeyState()
        {
            _dictionary = new Dictionary<T, IState>();
        }

        public IState Get(T key)
        {
            return _dictionary[key];
        }

        public void Set(T key, IState state)
        {
            _dictionary[key] = state;
        }

        public IKeyState<T> ShallowCopy()
        {
            var shallowCopy = new Dictionary<T, IState>(_dictionary);

            return new BaseKeyState<T>(_dictionary);
        }
    }
}
