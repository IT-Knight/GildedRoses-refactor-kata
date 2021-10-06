using GildedRoseKata.Strategies;
using GildedRoseKata.Utils;

namespace GildedRoseKata
{
    public class StandartStrategy : IStrategy
    {
        public void Update(Item item)
        {

            if (item.SellIn >= 0)
                item.Quality--;

            if (item.SellIn == -1 && item.Quality > 0)
                item.Quality -= 2;
            
        }
    }
}