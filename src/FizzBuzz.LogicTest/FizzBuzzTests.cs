using FizzBuzzGame;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzz.LogicTest
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzzLogic _sut;
        public FizzBuzzTests()
        {
            _sut = new FizzBuzzLogic(); 
        }

        [Fact]  
        public void If_number_is_devided_to_15_say_FizzBuzz()
        {
            var number = 30;
            var expected = _sut.FizzBuzz(number);
            expected.Should().Be("FizzBuzz");
        }

        [Fact]
        public void If_number_is_devided_to_3_say_Fizz()
        {
            var number = 9;
            var expected = _sut.FizzBuzz(number);
            expected.Should().Be("Fizz");
        }

    }
}
