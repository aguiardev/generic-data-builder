using System;

namespace ConsoleApp.Test
{
    public class DataBuilder<T>
    {
        private readonly T _data;

        public DataBuilder()
        {
            _data = (T)Activator.CreateInstance(typeof(T));
        }

        public DataBuilder<T> Set(Action<T> action)
        {
            action(_data);

            return this;
        }

        public T Build()
        {
            return _data;
        }
    }
}
