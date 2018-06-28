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
        public void AddShouldNotThrowException()
        {
            // Arrange
            var col = new NonGenericCollection();

            // Act
            col.Add("test string");

            // Assert
            // if we reach here, the test is successful
        }

        [Fact]
        public void DumbLongestShouldReturnLongest()
        {
            // Arrange
            var col = new NonGenericCollection();
            var items = new List<string>
            {
                "a", "ab", "abc", "Nick Escalona", "12345"
            };
            var expected = "Nick Escalona";
            col.AddMany(items);

            // Act
            var actual = col.DumbLongest();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
