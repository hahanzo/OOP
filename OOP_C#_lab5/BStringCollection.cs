using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C__lab5
{
    internal abstract class BStringCollection
    {
        int size;
        public int Size
        {
            get => size; 
            set => size = value;
        }
        public abstract void Add(BitString bitString);
        public abstract void Remove(BitString bitString);

        public abstract IEnumerable<BitString> GetCollection();
    }
}
