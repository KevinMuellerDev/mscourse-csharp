using System;
namespace MSCourse.Assignments.DataTypes;

public class DataTypes
{
    public static void MinMax()
    {
        Console.WriteLine("Signed integral types:");
        
        Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}\n");
        
        Console.WriteLine("Unsigned integral types:");
        Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
    }

    public static void FloatingIntegrals()
    {
        Console.WriteLine("");
        Console.WriteLine($"Floating point types:");
        Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue}");
        Console.WriteLine($"double : {double.MinValue} to {double.MaxValue}");
        Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");
    }

    public static void ConvertStringToNumeric()
    {
        string first = "12";
        string second = "43";

        int result = int.Parse(first) + int.Parse(second);
        
        Console.WriteLine(result);
    }

    public static void TryParsing()
    {
        string value = "bad";
        int result = 0;

        if (int.TryParse(value,out result))
        {
            Console.WriteLine($"Measurement: {result}");
        }
        else
        {
            Console.WriteLine($"Unable to report the measurement.");
        }
        if(result>0)
            Console.WriteLine($"Measurement (w/ Offset) {50 + result}");
    }

    public static void ValuesArray()
    {
        string[] values = { "12,3", "45", "ABC", "11", "DEF"};
        string message = "";
        float result = 0;

        foreach (var item in values)
        {
            float dummy = 0;
            if (float.TryParse(item, out dummy))
            {
                result += dummy;
            }
            else
            {
                message += item;
            }
            Console.WriteLine(result);
        }
        Console.WriteLine($"Message : {message}");
        Console.WriteLine($"Total   : {result}");
    }

    public static void ConvertChallenge()
    {
        int value1 = 11;
        decimal value2 = 6.2m;
        float value3 = 4.3f;

        // Your code here to set result1
        // Hint: You need to round the result to nearest integer (don't just truncate)
        int result1 = Convert.ToInt32(value1) / Convert.ToInt32(value2);
        Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

        // Your code here to set result2
        decimal result2 = Convert.ToDecimal(value2) / Convert.ToDecimal(value3);
        Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

        // Your code here to set result3
        float result3 = Convert.ToSingle(value3) / Convert.ToSingle(value1);
        Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
    }
}