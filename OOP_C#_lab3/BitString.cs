using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C__lab3
{
    internal class BitString : StringBase
    {
        public BitString(string str) : base(str)
        {
            IsValidBitString(str);
        }

        public override string ToString()
        {
            return new string(characters);
        }

        public int ToDecimal()
        {
            int result = 0;
            for (int i = 0; i < length; i++)
            {
                if (characters[i] == '1')
                    result += (int)Math.Pow(2, length - i - 1);
            }
            return result;
        }

        public override byte GetLength()
        {
            return base.GetLength();
        }

        public override void Clear()
        {
            base.Clear();
        }

        public static bool IsValidBitString(string str)
        {
            foreach (char c in str)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        public void ChangeSign()
        {
            bool carry = true;
            for (int i = length - 1; i >= 0; i--)
            {
                if (characters[i] == '1' && carry)
                {
                    characters[i] = '0';
                }
                else if (characters[i] == '0' && carry)
                {
                    characters[i] = '1';
                    carry = false;
                }
            }
        }

        public static BitString Add(BitString first, BitString second)
        {
            string result = "";
            int carry = 0;

            int maxLength = Math.Max(first.GetLength(), second.GetLength());

            for (int i = maxLength - 1, j = first.GetLength() - 1, k = second.GetLength() - 1; i >= 0; i--, j--, k--)
            {
                int sum = carry;

                if (j >= 0)
                    sum += first.characters[j] - '0';

                if (k >= 0)
                    sum += second.characters[k] - '0';

                result = (sum % 2) + result;

                carry = sum / 2;
            }

            if (carry == 1)
            {
                result = "1" + result;
            }

            return new BitString(result);
        }

        public bool Equals(BitString other)
        {
            if (length != other.GetLength())
                return false;

            for (int i = 0; i < length; i++)
            {
                if (characters[i] != other.characters[i])
                    return false;
            }

            return true;
        }
    }
}
