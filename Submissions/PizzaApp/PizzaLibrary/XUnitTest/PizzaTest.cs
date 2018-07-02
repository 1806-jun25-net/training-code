using System;
using Xunit;
using PizzaLibrary;

namespace XUnitTest
{
    public class PizzaTest
    {
        [Fact]
        public void Test()
        {
          
           Assert.True(Pizza.stringTest("aaaa"));
            
        }
    }
}
