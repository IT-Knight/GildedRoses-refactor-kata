using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseKata.Utils;

namespace GildedRoseKata.Strategies
{
    class AgedBrieStrategy : IStrategy
    {
        public void Update(Item item)
        {

            if (item.SellIn >= 0)
                item.Quality++;

            if (item.SellIn == -1 && item.Quality < 50)
            {
                item.Quality += 2;
                item.Quality.LimitQualityRange();
            }

            
            
        }
    }
}
