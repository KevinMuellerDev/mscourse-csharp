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
}