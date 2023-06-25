using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace ConsoleAppCore.Classes
{
    public enum DiceFacet
    {
        D2 = 2,
        D3 = 3,
        D4 = 4,
        D6 = 6,
        D8 = 8,
        D10 = 10,
        D12 = 12,
        D20 = 20,
        D100 = 100
    }

    public static class Dice
    {
        private static Random _random = new Random();

        public static int Roll(DiceFacet facet)
        {
            int result = 0;
            switch (facet)
            {
                case DiceFacet.D2:
                    result = _random.Next(0, 2) + 1;
                    break;
                case DiceFacet.D3:
                    result = _random.Next(0, 3) + 1;
                    break;
                case DiceFacet.D4:
                    result = _random.Next(0, 4) + 1;
                    break;
                case DiceFacet.D6:
                    result = _random.Next(0, 6) + 1;
                    break;
                case DiceFacet.D8:
                    result = _random.Next(0, 8) + 1;
                    break;
                case DiceFacet.D10:
                    result = _random.Next(0, 10) + 1;
                    break;
                case DiceFacet.D12:
                    result = _random.Next(0, 12) + 1;
                    break;
                case DiceFacet.D20:
                    result = _random.Next(0, 20) + 1;
                    break;
                case DiceFacet.D100:
                    result = _random.Next(0, 100) + 1;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(facet), facet, null);
            }

            Log(facet, result);
            return result;


            //if (facet == DiceFacet.D2)
            //{
            //    return 2;

            //} else if (facet == DiceFacet.D3)
            //{
            //    return 3;

            //}else if (facet == DiceFacet.D4)
            //{

            //}
            //else if (facet == DiceFacet.D6)
            //{

            //}
            //else if (facet == DiceFacet.D8)
            //{

            //}
            //else if (facet == DiceFacet.D10)
            //{

            //}
            //else if (facet == DiceFacet.D12)
            //{

            //}
            //else if (facet == DiceFacet.D20)
            //{

            //}
            //else if (facet == DiceFacet.D100)
            //{

            //}
            //else
            //{

            //}



        }

        public static int Roll1(DiceFacet facet)
        {
            switch (facet)
            {
                case DiceFacet.D2:
                {
                    var result = _random.Next(0, 2) + 1;
                    Log(facet, result);
                    return result;
                }
                case DiceFacet.D3:
                {
                    var result = _random.Next(0, 3) + 1;
                    Log(facet, result);
                    return result;
                }
                case DiceFacet.D4:
                {
                    var result = _random.Next(0, 4) + 1;
                    Log(facet, result);
                    return result;
                }
                case DiceFacet.D6:
                {
                    var result = _random.Next(0, 6) + 1;
                    Log(facet, result);
                    return result;
                }
                case DiceFacet.D8:
                {
                    var result = _random.Next(0, 8) + 1;
                    Log(facet, result);
                    return result;
                }
                case DiceFacet.D10:
                {
                    var result = _random.Next(0, 10) + 1;
                    Log(facet, result);
                    return result;
                }
                case DiceFacet.D12:
                {
                    var result = _random.Next(0, 12) + 1;
                    Log(facet, result);
                    return result;
                }
                case DiceFacet.D20:
                {
                    var result = _random.Next(0, 20) + 1;
                    Log(facet, result);
                    return result;
                }
                case DiceFacet.D100:
                {
                    var result = _random.Next(0, 100) + 1;
                    Log(facet, result);
                    return result;
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(facet), facet, null);
            }
        }

        public static int Roll2(DiceFacet facet)
        {
            var result = _random.Next(0, (int)facet) + 1;
            Log(facet, result);
            return result;
        }

        private static void Log(DiceFacet facet, int result)
        {
            Console.WriteLine($"Roll [{facet}]: {result}");
        }
    }
}
