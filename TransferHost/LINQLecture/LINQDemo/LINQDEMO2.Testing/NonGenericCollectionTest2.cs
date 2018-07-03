using LINQDemo.Library;
using System;
using System.Collections.Generic;
using Xunit;

namespace LINQDEMO2.Testing
{
    public class NonGenericCollectionTest2
    {
        [Fact]//TEST 1
        public void AddShouldNotThrowEception()
        {
            //arrange
            var col = new NonGenericCollection();

            //act
            col.Add("test string");
            string[] arrbol = new string[] { "hello", "how", "you", "is", "?" };
            col.AddMany(arrbol);
            foreach (var p in col.list)//using **r.list** to access list directly
            {
                Console.WriteLine(p);//printing list of... list
            }

            //assert
            //if we reach this point, test is successful
        }

        [Fact]
        //TEST 2
        public void DumbLongestSHouldReturnLongest()
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
            var actual = col.Longest();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("123",new string[] {"12", "123"})]
        [InlineData(null, new string[] { })]
        [InlineData("12345", new string[] { "12", "12345" })]
        public void DumbbLongestSHouldReturnLongest(string expected, string[] data)
        {
            // Arrange
            var col = new NonGenericCollection();

             
            col.AddMany(data);

            // Act
            var actual = col.Longest();

            // Assert
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<Object[]> GetTestData()//use method instead of inline for ease of use/efficiency/reduces code duplication
        {
           yield return new object[]  { new string[] { "asdf" } };
          //  yield return new object[] { new string[] { "asdf" } };//can use array too
           // yield return new object[] { "asdf" ,"asdfas"};
            //yield return new object[] { };
        }

        [Theory]
        [MemberData (nameof(GetTestData))]
        public void AddManySHouldNotThrowException(string[] data)
        {
            var col = new NonGenericCollection();
            col.AddMany(data);
            //if no exception thrown, success
        }

        //OF DAY 2

          [Fact]
          public void ExtensionMethodIsEmptyShouldStayEMpty()
        {
            var col = new NonGenericCollection();
            // var actual = col.IsEmpty();
            Assert.True(col.IsEmpty());
            
        }

        [Fact]
        public void ContainsSHouldThrowExceptionForNull()
        {
            var col = new NonGenericCollection();
            Assert.Throws<ArgumentNullException>(() =>
                    col.Contains(null));
        }


        //example to refer to during project
        //we should think of making methods in tester before
        //imlementing them straight into code
        [Fact]
        //TEST 3
        public void ThirdAlphabeticalShouldReturnCorrectly()
        {
            //Arrange
            // Arrange
            var col = new NonGenericCollection();
            var items = new List<string>
            {
                "a", "abc", "ab","Nick Escalona", "12345"
            };
            var expected = "ab";
            col.AddMany(items);


            //Act
            var actual=col.ThirdAlphabetical();
            //Assert
            Assert.Equal(expected,actual);
        }

    }
}
