using System;
using System.Collections.Generic;
using System.Text;
using Unit = System.ValueTuple;
using static FunctionalLibrary.Functional;

namespace FunctionalLibrary
{
    public static class ActionExtensions
    {
        public static Func<Unit> ToFunc(this Action action)
            => () =>
            {
                action();
                return Unit();
            };

        public static Func<T,Unit> ToFunc<T>(this Action<T> action)
           => (value) =>
           {
               action(value);
               return Unit();
           };
    }
}
