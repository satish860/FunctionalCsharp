using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Unit = System.ValueTuple;

namespace FunctionalLibrary.Tests
{
    public class ActionExtensionTests
    {
        [Fact]
        public void ShouldBeAbleToGetMakeAActionToFuntion()
        {
            Action action = () => { };
            Func<Unit> func = action.ToFunc();
        }

        [Fact]
        public void ShouldBeAbleToMakeFunctionFromActionForGeneric()
        {
            Action<string> action = (str) => { };
            Func<string,Unit> func = action.ToFunc();
        }
    }
}
