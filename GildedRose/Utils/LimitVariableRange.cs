using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Utils
{
    public static class LimitVariableRange
    {
        public static int LimitQualityRange(this int quality)
        {
            if (quality >= 0)
            {
                if (quality <= 50)
                {
                    return quality;
                }

                return 50;
            }

            return 0;
        }

        public static int LimitSellInRange(this int sellIn)  //No need, controlled at start.
        {
            return (sellIn >= -1) ? sellIn : -1;
        }
    }
}
