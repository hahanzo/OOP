using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C__lab5
{
    internal class BStringCollectionHashtable : BStringCollection
    {
        private Hashtable hashTableCollection;

        public BStringCollectionHashtable()
        {
            hashTableCollection = new Hashtable();
        }

        public BStringCollectionHashtable(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Size must be a positive integer.");
            }
            Size = size;
            hashTableCollection = new Hashtable(size);
        }

        public override void Add(BitString bitString)
        {
            if (hashTableCollection.Count >= Size)
            {
                throw new InvalidOperationException("Collection size limit exceeded.");
            }

            if (!hashTableCollection.ContainsKey(bitString.ToString()))
            {
                hashTableCollection.Add(bitString.ToString(), bitString);
            }
            else
            {
                throw new ArgumentException("Bit string already exists in the collection.");
            }
        }

        public override void Remove(BitString bitString)
        {
            hashTableCollection.Remove(bitString.ToString());
        }

        public override IEnumerable<BitString> GetCollection()
        {
            return hashTableCollection.Values.Cast<BitString>();
        }
    }
}
