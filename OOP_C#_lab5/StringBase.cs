using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C__lab5
{
    internal class StringBase : ICloneable, IComparable<StringBase>
    {
        protected char[] characters;
        protected byte length;

        public StringBase()
        {
            characters = new char[0];
            length = 0;
        }

        public StringBase(string str)
        {
            characters = str.ToCharArray();
            length = (byte)characters.Length;
        }

        public StringBase(char character)
        {
            characters = new char[] { character };
            length = 1;
        }

        public virtual byte GetLength()
        {
            return length;
        }

        public virtual void Clear()
        {
            characters = new char[0];
            length = 0;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(StringBase other)
        {
            if (other == null)
                return 1;

            StringBase otherStringBase = other as StringBase;
            if (otherStringBase != null)
                return ToString().CompareTo(other.ToString());
            else
                throw new ArgumentException("Object is not a StringBase");
        }
    }
}
