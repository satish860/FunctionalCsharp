using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static FunctionalLibrary.Functional;
using FluentAssertions;

namespace FunctionalLibrary.Tests
{
    public class UnitFunctionalTests
    {
        [Fact]
        public void ShouldBeAbleToCreateUnitType()
        {
            Unit().Should().NotBeNull();
        }
    }
}
