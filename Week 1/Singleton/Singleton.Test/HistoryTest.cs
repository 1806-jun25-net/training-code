using Singleton.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Singleton.Test
{
    public class HistoryTest
    {
        [Fact]
        public void OutdatedShouldReturnFalseIfRecentRecord()
        {
            var history = new History();
            history.Record();
            Assert.False(history.IsOutdated());
        }

        [Fact]
        public void OutdatedShouldReturnTrueIfNoRecentRecord()
        {
            var history = new History();
            TimeProvider.Current = new TwoHoursAgoProvider();
            history.Record();
            TimeProvider.ResetToDefaultInstance();

            Assert.True(history.IsOutdated());
        }
    }
}
