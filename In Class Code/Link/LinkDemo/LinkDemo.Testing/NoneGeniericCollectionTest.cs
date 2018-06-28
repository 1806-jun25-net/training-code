using System;
using System.Collections.Generic;
using System.Text;



namespace LinkDemo.Testing
{
    class NoneGeniericCollectionTest
    {
        public void AddShouldNotThrowException()
        {
            // Arrange 
            var col = new NoneGeniericCollectionTest();
            var items = new List<string>
            {
                "a", "ab"
            };
            col.Addmany(items);
            //Act 
            var actual = col.Longest();

            //Assert

        }
    }
}
