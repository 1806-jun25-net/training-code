using LINQDemo.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LINQDemo.Testing
{
    public class NonGenericCollectionTest
    {
        [Fact] // xUnit attribute to mark tests
        public void AddShouldNotThrowException()
        {
            // Arrange
            var col = new NonGenericCollection();

            // Act
            col.Add("test string");
            
            // Assert
            // if we reach here, the test is successful
            //Assert.True(true);

        }

        [Fact]
        public void DumbLongestShouldReturnLongest()
        {
            // Arrange
            var col = new NonGenericCollection();
            var items = new List<string>
            {
                "a", "ab", "abc", "C.Coronado", "12345"
            };
            var expected = "C.Coronado";
            col.AddMany(items);
            
            // Act
            var actual = col.DumbLongest();

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
