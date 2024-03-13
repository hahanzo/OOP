using System;
using System.IO;
using System.Runtime.CompilerServices;

public interface ISerializable
{
    void Serialize(string fileName);
    void Deserialize(string fileName);
}

public class StringBase : ICloneable, IComparable<StringBase>
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

public class BitString : StringBase, IComparable<BitString>, ISerializable
{
    private bool isSigned;

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
                return false;
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

    public void Serialize(string fileName)
    {
        string serializedString = this.ToString();
        File.WriteAllText(fileName, serializedString);
    }

    public void Deserialize(string fileName)
    {
        string serializedString = File.ReadAllText(fileName);
        this.characters = serializedString.ToCharArray();
        this.length = (byte)this.characters.Length;
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

class Program
{
    static void Main(string[] args)
    {
        // Creating an array of BitString objects
        BitString[] bitStrings = new BitString[4];
        bitStrings[0] = new BitString("1010");
        bitStrings[1] = new BitString("1100");
        bitStrings[2] = (BitString)bitStrings[0].Clone();
        bitStrings[3] = (BitString)bitStrings[1].Clone();

        // Displaying the initial array
        Console.WriteLine("Initial array:");
        foreach (var bitStr in bitStrings)
        {
            Console.WriteLine(bitStr);
        }

        // Sorting the array
        Array.Sort(bitStrings);

        // Displaying the sorted array
        Console.WriteLine("\nSorted array:");
        foreach (var bitStr in bitStrings)
        {
            Console.WriteLine(bitStr);
        }

        // Comparing the first two objects in the array
        int result = bitStrings[0].CompareTo(bitStrings[1]);

        if (result < 0)
        {
            Console.WriteLine("\nbitString1 is less than bitString2");
        }
        else if (result > 0)
        {
            Console.WriteLine("\nbitString1 is greater than bitString2");
        }
        else
        {
            Console.WriteLine("\nbitString1 is equal to bitString2");
        }

        // Creating a new BitString object
        BitString bitString = new BitString("00001111");

        // Serializing and deserializing
        string fileName = "serialized_bitstring.txt";
        bitString.Serialize(fileName);
        Console.WriteLine("\nBitString serialized to file " + fileName);

        BitString deserializedBitString = new BitString("");
        deserializedBitString.Deserialize(fileName);
        Console.WriteLine("BitString deserialized from file: " + deserializedBitString);

        BitString bitString1 = new BitString("0001",true);
        Console.WriteLine("\nBinary number:" + bitString1.ToString());

        BitString bitString2 = new BitString("0001");
        bitString2.GetTwosComplement();
        
        Console.WriteLine("Changed sign:" + bitString2.ToString());

        Console.WriteLine("\nAdd " + bitString1.ToString() + 
            " and " + bitString2.ToString() + ":" + BitString.Add(bitString1,bitString2));

        Console.WriteLine("\nBinary: " + bitString1.ToString() + " Deciaml: " + bitString1.ToDecimal());       
        Console.WriteLine("Binary: " + BitString.Add(bitString1, bitString2) + 
            " Deciaml: " + BitString.Add(bitString1, bitString2).ToDecimal());

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}


