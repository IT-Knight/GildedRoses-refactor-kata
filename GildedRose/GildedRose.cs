using System;
using System.Collections.Generic;
using System.Linq;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            this.Items = Items.Select(item => FactoryСontext.Update(item)).ToList();
            

            //    foreach (var item in Items)
            //{
            //    FactoryСontext.Update(item);
            //}

        }
    }
}
