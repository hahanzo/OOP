using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C__lab5
{
    internal class BitString : StringBase, IComparable<BitString>
    {
        private bool isSigned;

        public BitString()
        {
            isSigned = false;
        }

        public BitString(string str) : base(str)
        {
            IsValidBitString(str);
            isSigned = false;
        }

        public BitString(string str, bool signed) : base(str)
        {
            IsValidBitString(str);
            isSigned = signed;
        }

        public override string ToString()
        {
            return new string(characters);
        }

        public int ToDecimal()
        {
            int result = 0;
            int startIndex = this.IsSigned() ? 1 : 0;
            bool isNegative = this.IsSigned() && characters[0] == '1';

            for (int i = startIndex; i < length; i++)
            {
                if (characters[i] == '1')
                {
                    result += (int)Math.Pow(2, length - i - 1);
                }
            }

            if (isNegative)
            {
                result = -result;
            }

            return result;
        }

        public override byte GetLength()
        {
            return length;
        }

        public void GetOnesComplement()
        {
            for (int i = 0; i < length; i++)
            {
                characters[i] = (characters[i] == '0') ? '1' : '0';
            }
        }

        public void GetTwosComplement()
        {
            GetOnesComplement();
            characters = BitString.Add(this, new BitString("1")).characters;
            isSigned = true;
        }

        public bool IsSigned()
        {
            return isSigned;
        }

        public static bool IsValidBitString(string str)
        {
            foreach (char c in str)
            {
                if (c != '0' && c != '1')
                {
                    throw new ArgumentException("Enter valid bit string.");
                }
            }
            return true;
        }

        public override void Clear()
        {
            characters = new char[0];
            length = 0;
        }

        public int CompareTo(BitString other)
        {
            if (other == null)
                return 1;

            BitString otherBitString = other as BitString;
            if (otherBitString != null)
                return ToString().CompareTo(other.ToString());
            else
                throw new ArgumentException("Object is not a BitString");
        }

        public void SerializeToTxt(string directoryPath, string fileName)
        {
            string filePath = Path.Combine(directoryPath, fileName + ".txt");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(this.ToString()); // Write the BitString content to the text file
            }
        }

        public void DeserializeFromTxt(string filePath)
        {
            // Read the content of the text file
            string content;
            using (StreamReader reader = new StreamReader(filePath))
            {
                content = reader.ReadToEnd();
            }

            // Reconstruct the BitString object from the content
            this.characters = content.ToCharArray();
            this.length = (byte)content.Length;
        }

        public static BitString Add(BitString first, BitString second)
        {
            if (first.IsSigned() != second.IsSigned())
            {
                throw new InvalidOperationException("Cannot add a signed number with an unsigned number.");
            }

            bool isSigned = first.IsSigned();

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

            return new BitString(result, isSigned);
        }
    }
}
