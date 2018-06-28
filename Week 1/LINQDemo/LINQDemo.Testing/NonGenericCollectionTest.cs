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

        [Theory]
        public void DumbLongestShouldReturnLongest(string expected, string[]data)
        {
            // Arrange
            var col = new NonGenericCollection();
            col.AddMany(data);
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

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new string[] { "asdf" } };
            yield return new object[] { new string[] { "asdf", "asdfas" } };
            yield return new object[] { new string[] { } };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void AddManyShouldNotThrowException(string[] data)
        {
            var col = new NonGenericCollection();
            col.AddMany(data);
        }

     

        [Fact]
        public void ThirdAlphabeticalShouldReturnCorrectly()
        {

            //Arrange
            var col = new NonGenericCollection();
            var items = new List<string>
            {
                "a", "abc", "ab", "Nick Escalona", "12345"
            };
            var expected = "ab";
            col.AddMany(items);


            //Act
            var actual = col.ThirdAlphabetical();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
