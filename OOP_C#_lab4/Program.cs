using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

public interface ISerializable
{
    void SerializeToTxt(string directoryPath, string fileName);
    void DeserializeFromTxt(string filePath);
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

        Console.WriteLine("\nbitString1:" + bitStrings[0].ToString());
        Console.WriteLine("bitString2:" + bitStrings[1].ToString());
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

        // Creating a BitString object
        BitString bitString = new BitString("1010");

        // Serialization to Txt
        string txtDirectory = "C:\\Project\\OOP_C#_lab4\\data";
        string txtFileName = "bitStringTxt";
        bitString.SerializeToTxt(txtDirectory, txtFileName);
        Console.WriteLine("\nBitString serialized to Txt file: " + Path.Combine(txtDirectory, txtFileName + ".txt"));

        // Deserialization from Txt
        BitString deserializedBitStringFromTxt = new BitString();
        deserializedBitStringFromTxt.DeserializeFromTxt(Path.Combine(txtDirectory, txtFileName + ".txt"));
        Console.WriteLine("BitString deserialized from Txt file: " + deserializedBitStringFromTxt);

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


