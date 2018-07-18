using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using static FunctionalLibrary.Functional;
using FunctionalLibrary.Tests.Examples;
using System.Linq;

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
        public void ParseEnumIntoType()
        {
            Func<object> none = () => { return string.Empty; };
            "Friday".Parse<DayOfWeek>()
                .Match
                (
                   None: none,
                   Some: (value) => value.Should().Be(DayOfWeek.Friday)
                );
        }
    }
}
