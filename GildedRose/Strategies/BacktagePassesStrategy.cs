using GildedRoseKata.Strategies;
using GildedRoseKata.Utils;

namespace GildedRoseKata.Strategies
{
    public class BacktagePassesStrategy : IStrategy
    {
        private readonly AgedBrieStrategy agedBrieStrategy = new AgedBrieStrategy();

        public void Update(Item item)
        {
            if (item.SellIn > 10)
                agedBrieStrategy.Update(item);
            else if (item.SellIn <= 10 && item.Quality < 50)
                item.Quality += 2;
            else if (item.Quality <= 5 && item.Quality < 50)
                item.Quality += 3;
            
            if (item.SellIn == -1)
                item.Quality = 0;

            if (item.Quality > 50)
                item.Quality = 50;
            
        }
    }
}