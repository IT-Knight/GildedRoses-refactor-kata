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

            if (_item.SellIn >= 0) _item.SellIn--;

            switch (_item.Name)
            {
                case "Aged Brie":
                    strategy = new AgedBrieStrategy();
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    if (_item.SellIn < 0) 
                        _item.SellIn = 0;
                    return _item;
                case "Backstage passes to a TAFKAL80ETC concert":
                    strategy = new BacktagePassesStrategy();
                    break;
                case "Conjured Mana Cake":
                    strategy = new ConjureStrategy();
                    break;
                default:
                    strategy = new StandartStrategy();
                    break;

            }


            return _item;
        }


    }

}
