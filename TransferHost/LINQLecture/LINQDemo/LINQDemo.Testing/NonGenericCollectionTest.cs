using LINQDemo.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace LINQDemo.Testing
{
    public class NonGenericCollectionTest
    {
        [Fact]
        public void AddShouldNotThrowEception()
        {
            //arrange
            var col = new NonGenericCollection();

            //act
            col.Add("test string");

            //assert
        }

        //[Fact]
        //public void DumbLongestSHouldReturnLongest()
        //{

        //}
    }
}
