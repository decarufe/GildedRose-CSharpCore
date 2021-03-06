using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace GildedRose.Tests
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Items[0].Should().BeEquivalentTo(new Item {Name = "fixme", SellIn = 0, Quality = 0});
        }
    }
}