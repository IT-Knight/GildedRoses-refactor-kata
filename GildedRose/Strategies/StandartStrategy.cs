using GildedRoseKata.Strategies;

namespace GildedRoseKata
{
    internal class StandartStrategy : IStrategy
    {
        public void Update(Item item)
        {
            item.Quality--;
            
        }
    }
}