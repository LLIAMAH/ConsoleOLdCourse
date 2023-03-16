using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOLdCourse.Classes
{
    public class BitView
    {
        private readonly int _data;
        private readonly BitArray _array;

        public BitView(int data)
        {
            this._data = data;
            this._array = new BitArray(new int[] { this._data });
        }

        public override string ToString()
        {
            return $"{PrintBits(this._array)}:[0x{this._data:x8}]:({this._data})";
        }

        private static string PrintBits(BitArray data)
        {
            var result = new StringBuilder();
            for (var i = 31; i >= 0; i--)
            {
                if ((i + 1) % 8 == 0)
                    result.Append(' ');
                result.Append(data[i] ? "1" : "0");
            }

            return result.ToString().Trim();
        }

        public BitView BitwiseAnd(BitView secondValue)
        {
            var result = this._data & secondValue._data;
            return new BitView(result);
        }

        public BitView BitwiseOr(BitView secondValue)
        {
            var result = this._data | secondValue._data;
            return new BitView(result);
        }

        public BitView BitwiseXor(BitView secondValue)
        {
            var result = this._data ^ secondValue._data;
            return new BitView(result);
        }

        public BitView BitwiseComplement()
        {
            var result = ~this._data;
            return new BitView(result);
        }
    }
}
