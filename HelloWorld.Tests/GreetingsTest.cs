using System;
using Xunit;
using HelloWorld;

namespace HelloWorld.Tests
{
    public class GreetingTests
    {
        [Fact]
        public void Greet_ReturnsHelloWorld()
        {
            var expected = "Hello, World!";
            var actual = Program.Greet();
            Assert.Equal(expected, actual);
        }
    }
}
