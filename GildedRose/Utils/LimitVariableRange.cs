using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Utils
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

        public static int LimitSellInRange(this int sellIn)
        {
            if (sellIn >= 0)
            {
                return sellIn;
            }
            return 0;
        }
    }
}
