using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C__lab5
{
    internal class BStringCollectionSortedList : BStringCollection
    {
        private SortedList<int, BitString> sortedListCollection; 

        public BStringCollectionSortedList()
        {            
            sortedListCollection = new SortedList<int, BitString>();
        }

        public BStringCollectionSortedList(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Size must be a positive integer.");
            }
            Size = size;
            sortedListCollection = new SortedList<int, BitString>(size);
        }

        public override void Add(BitString bitString)
        {
            if (sortedListCollection.Count >= Size)
            {
                throw new InvalidOperationException("Collection size limit exceeded.");
            }

            int decimalValue = bitString.ToDecimal();
            if (!sortedListCollection.ContainsKey(decimalValue))
            {
                sortedListCollection.Add(decimalValue, bitString);
            }
            else
            {
                throw new ArgumentException("Bit string already exists in the collection.");
            }
        }

        public override void Remove(BitString bitString)
        {
            sortedListCollection.Remove(bitString.ToDecimal());
        }

        public override IEnumerable<BitString> GetCollection()
        {
            return sortedListCollection.Values;
        }

    }
}
