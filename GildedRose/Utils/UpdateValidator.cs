using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Utils
{
    public static class UpdateValidator
    {
        public static bool ValidateIsUpdateNeeded(this Item item)
        {
            if (item.SellIn > -1)
                return true;
            else if (item.SellIn == -1 && item.Quality == 80)
                return true;
            else
                return false;
        }
    }
}
