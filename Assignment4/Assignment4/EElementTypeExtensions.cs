using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public enum EElementType { Fire, Water, Wind, Earth };

    public static class ElementTypeExtensions
    {
        public static int GetCounter(this EElementType type1, EElementType type2)
        {
            if (type1 == EElementType.Fire && type2 == EElementType.Wind)
            {
                return 1;
            }
            else if (type1 == EElementType.Fire && type2 == EElementType.Water || type2 == EElementType.Earth)
            {
                return 0;
            }

            if (type1 == EElementType.Water && type2 == EElementType.Fire)
            {
                return 1;
            }
            else if (type1 == EElementType.Water && type2 == EElementType.Wind)
            {
                return 0;
            }

            if (type1 == EElementType.Earth && type2 == EElementType.Fire)
            {
                return 1;
            }
            else if (type1 == EElementType.Earth && type2 == EElementType.Wind)
            {
                return 0;
            }

            if (type1 == EElementType.Wind && type2 == EElementType.Earth || type2 == EElementType.Water)
            {
                return 1;
            }
            else if (type1 == EElementType.Wind && type2 == EElementType.Fire)
            {
                return 0;
            }
            return -1;
        }
    }
}
