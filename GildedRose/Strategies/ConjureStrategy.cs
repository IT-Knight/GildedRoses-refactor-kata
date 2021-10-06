using GildedRoseKata.Strategies;

namespace GildedRoseKata
{
    public class ConjureStrategy : IStrategy
    {
        private readonly StandartStrategy standartStrategy = new StandartStrategy();

        public void Update(Item item)
        {
                standartStrategy.Update(item);
                standartStrategy.Update(item);
        }
        
    }
}