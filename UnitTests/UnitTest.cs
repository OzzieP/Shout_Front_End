using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {
            int a = 5;
            int b = 10;

            Assert.Equal(15, a + b);
        }
    }
}
