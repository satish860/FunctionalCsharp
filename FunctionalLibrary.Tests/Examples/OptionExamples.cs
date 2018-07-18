using System;
using System.Collections.Generic;
using System.Text;
using static FunctionalLibrary.Functional;
using System.Linq;

namespace FunctionalLibrary.Tests.Examples
{
    public static class OptionExamples
    {
        public static Option<T> Parse<T>(this string s) where T : struct
        {
            T value = default(T);
            if (Enum.TryParse<T>(s, out value))
            {
                return Some(value);
            }
            return None();

        }



    }


}
