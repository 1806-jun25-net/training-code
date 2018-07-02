using System;
using System.Collections.Generic;
using System.Text;
using LINQDemo.Library;
using Xunit;

namespace LINQDemo.Testing
{
    public class NonGenericCollectionTest
    {
        //Annotation/attribute
        [Fact]
        public void AddShouldNotThrowException()
        {
            //Arrange
            var ngc = new NonGenericCollection();
            //Act
            ngc.Add("test");
            //Assert
            //(no exception will be thrown)
        }

        [Fact]
        public void ExtensionMethodIsEmptyShouldSayEmpty()
        {
            var col = new NonGenericCollection();
            var actual = col.IsEmpty();
        }

        [Fact]
        public void CountainsShouldThrowExceptionForNull()
        {
            var col = new NonGenericCollection();
            Assert.Throws<ArgumentNullException>(
                () => col.Contains(null));
        }


        [Fact]
        public void LongestShouldReturnLongest()
        {
            var ngc = new NonGenericCollection();
            var items = new List<string> { "one", "four", "three" };
            ngc.AddMany(items);
            var actual = ngc.DumbLongest();
            var expected = "three";
            Assert.Equal(expected, actual);
        }
    }
}
