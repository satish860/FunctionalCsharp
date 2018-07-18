using System;
using System.Collections.Generic;
using System.Text;
using Option;
using static FunctionalLibrary.Functional;

namespace FunctionalLibrary
{
    public struct Option<T> : IEquatable<Option.None>, IEquatable<Option<T>>
    {
        readonly T Value;

        internal Option(T value)
        {
            this.Value = value;
            this.HasValue = true;
        }
        public bool HasValue { get; }

        public bool Equals(None other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Option<T> other)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Option<T>(T value)
        {
            if (value == null)
                return None();
            return Some(value);
        }
        
        public R Match<R>(Func<R> None,Func<T,R> Some)
        {
            return this.HasValue ? Some(this.Value) : None();
        }

        public static implicit operator Option<T>(Option.Some<T> some)
         => new Option<T>(some.Value);


        public static implicit operator Option<T>(Option.None _)
         => new Option<T>();

    }
}

namespace Option
{
    public struct None
    {
        internal static readonly None Default = new None();
    }

    public struct Some<T>
    {
        internal T Value { get; }

        internal Some(T value)
        {
            if (value == null)
                throw new ArgumentNullException();
            Value = value;
        }
    }
}