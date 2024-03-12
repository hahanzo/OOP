using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C__lab3
{
    internal class StringBase
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
    }
}
