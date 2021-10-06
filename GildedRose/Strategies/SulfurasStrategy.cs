using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Strategies
{
    class SulfurasStrategy : IStrategy
    {
        public void Update(Item item)
        {
            if (item.SellIn == -1)
                item.SellIn = 0;
        }
    }
}
