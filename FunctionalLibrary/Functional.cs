using Option;
using System;
using System.Collections.Generic;
using System.Text;
using Unit = System.ValueTuple;

namespace FunctionalLibrary
{
    public static partial class Functional
    {
        public static Unit Unit() => new Unit();
        public static None None() => Option.None.Default;

        public static Some<T> Some<T>(T value)
            => new Some<T>(value);
    }

    

   


}
