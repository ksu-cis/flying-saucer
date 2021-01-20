/*
 * Author: Nathan Bean
 * File name: Size.cs
 * Purpose: To unit test the size enumeration
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TheFlyingSaucer.Data.Enums;

namespace TheFlyingSaucer.DataTests.Enums
{
    /// <summary>
    /// A class contianing unit tests for the Size enumeration
    /// </summary>
    public class SizeTests
    {
        [Theory]
        [InlineData("Small")]
        [InlineData("Medium")]
        [InlineData("Large")]
        public void HasExpectedAttributes(string expected)
        {
            Assert.Contains(Enum.GetNames(typeof(Size)), actual => actual == expected);
        }

        [Fact]
        public void HasThreeAttributes()
        {
            Assert.Equal(3, Enum.GetNames(typeof(Size)).Length);
        }
    }
}
