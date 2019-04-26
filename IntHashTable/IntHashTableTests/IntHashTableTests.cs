using System;
using Xunit;

namespace IntHashTable.Tests
{
    public class IntHashTableTests
    {
        [Fact]
        public void ShouldAddIntToTable()
        {
            var hashTable = new IntHashTable();
            hashTable.Add(1);

            Assert.True(hashTable.Contains(1));
        }

        [Fact]
        public void WhenNumberNotInTable_ContainsShouldReturnFalse()
        {
            var hashTable = new IntHashTable();
            Assert.False(hashTable.Contains(0));
        }
    }
}
