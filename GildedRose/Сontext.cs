using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseKata.Strategies;
using GildedRoseKata.Utils;

namespace GildedRoseKata
{
    public class Сontext
    {
        private readonly Item _item;
        private IStrategy strategy;

        public Сontext(Item item)
        {
            _item = item;
        }
       

        public Item Update()
        {

            bool isUpdateNeeded = _item.ValidateIsUpdateNeeded();

            if (!isUpdateNeeded)
                return _item;

            if (_item.SellIn >= 0) _item.SellIn--;

            strategy = GetStrategy(_item.Name);

            strategy.Update(_item);

            return _item;
        }

        private IStrategy GetStrategy(string itemName)
        {
            switch (itemName)
            {
                case "Aged Brie":
                    return new AgedBrieStrategy();
                case "Sulfuras, Hand of Ragnaros":
                    return new SulfurasStrategy();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BacktagePassesStrategy();
                case "Conjured Mana Cake":
                    return new ConjureStrategy();
                default:
                    return new StandartStrategy();
            }
    }

}
