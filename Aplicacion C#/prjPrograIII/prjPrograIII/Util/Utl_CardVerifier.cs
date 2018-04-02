using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Util
{
    static class Utl_CardVerifier
    {
            public static bool LuhnCheck(this string cardNumber)
            {
                return LuhnCheck(cardNumber.Select(c => c - '0').ToArray());
            }

            private static bool LuhnCheck(this int[] digits)
            {
                return GetCheckValue(digits) == 0;
            }

            private static int GetCheckValue(int[] digits)
            {
                return digits.Select((d, i) => i % 2 == digits.Length % 2 ? ((2 * d) % 10) + d / 5 : d).Sum() % 10;
            }
                
    }
}
