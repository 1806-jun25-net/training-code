﻿using LINQDemo.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LINQDemo.Testing
{
    public class NonGenericCollectionTest
    {
        [Fact] //must be placed to run a test
        public void AddShouldNotThrowException()
        {
            //Arrange
            var col = new NonGenericCollection();

            //Act
            col.Add("test string");

            //Assert

        }

        [Theory] //a test that takes a parameter
        [InlineData("1234", new string[] { "12", "1234" })] //used in conjunction with Theory, holds data to test
        [InlineData(null, new string[] { })]
        [InlineData("asdas", new string[] { "12", "1234", "asdas" })]
        public void DumbLongestShouldReturnLongest(string expected, string[] data)
        {
            //Arrange
            var col = new NonGenericCollection();
            col.AddMany(data);

            //var items = new List<string>
            //{
            //    "a", "ab" , "abc", "Wayne", "12345"
            //};
            //var expected = "Wayne";

            //Act
            var actual = col.DumbLongest();

            //Assert
            Assert.Equal(expected, actual);
        }

        //similary to InlineData but can be reused by other testing methods
        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new string[] { "asdf" } };
            yield return new object[] { new string[] { "asdf", "hello" } };
            yield return new object[] { new string[] { } };
            //use yield when you want to return data from a collection
            //used like an array but code is stacked instead of all in one place
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void AddManyShouldNotThrowException(string[] data)
        {
            var col = new NonGenericCollection();
            col.AddMany(data);
            //if no exception thrown, then success
        }

        //test the extension method
        [Fact]
        public void ExtensionMethodIsEmptyShouldSayEmpty()
        {
            var col = new NonGenericCollection();
            Assert.True(col.IsEmpty());
        }

        [Fact]
        public void ContainsShouldThrowExceptionForNull()
        {
            var col = new NonGenericCollection();
            Assert.Throws<ArgumentNullException>(
                "item", () => col.Contains(null));
        }

        //returns the 3rd entry after sorting alphabetically
        [Fact]
        public void ThirdAlphabeticalShouldReturnCorrectly()
        {
            //Arrange
            var col = new NonGenericCollection();
            var items = new List<string>
            {
                "a", "ab", "abc", "Wayne", "12345"
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
