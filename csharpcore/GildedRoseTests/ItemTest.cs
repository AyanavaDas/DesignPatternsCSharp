using GildedRoseKata;
using System.Collections.Generic;
using Xunit;

namespace GildedRoseTests
{
    public class ItemTest
    {
        [Fact]
        public void ItemModelTest()
        {
            var items = new Item();

            Assert.Equal(null, items.Name); 
            Assert.Equal(0, items.SellIn);
            Assert.Equal(0, items.Quality);
        }
    }
}
