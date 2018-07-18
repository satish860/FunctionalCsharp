using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using static FunctionalLibrary.Functional;

namespace FunctionalLibrary.Tests
{
    public class OptionFuntionalTests
    {
        [Fact]
        public void ShouldBeAbleCreateOptionWithSomeValue()
        {
            Option<string> value = "satish";
            Option<string> value2 = None();
            value.HasValue.Should().BeTrue();
            value2.HasValue.Should().BeFalse();
        }

        [Fact]
        public void ShouldBeAbleToCreateOptionsWithNoneValue()
        {
           // Option<string> emptyValue = Option.None;
        }
    }
}
