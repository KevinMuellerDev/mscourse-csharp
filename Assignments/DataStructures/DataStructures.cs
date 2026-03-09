using System;
using System.Linq;

namespace MSCourse.Assignments.DataStructures;

public static class DataStructures
{
    public static void ArrayStructure()
    {
        string[] fraudulentOrderIDs = ["A123", "B456", "C789"];
        
        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";
        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
        
        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
    }

    public static void ArraySum()
    {
        int[] inventory = { 200, 450, 700, 175, 250 };
        int sum = 0;
        int bin = 0;
        
        foreach (var items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        Console.WriteLine($"We have {sum} items in inventory.");
    }

    public static void FraudulentIdAssignment()
    {
        string[] ids = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
        int fraudulentSum = 0;

        foreach (var id in ids)
        {
            if (id.StartsWith("B"))
            {
                Console.WriteLine(id);
                fraudulentSum++;
            }
        }

        Console.WriteLine($"From {ids.Length} ids {fraudulentSum} have been detected as fraudulent.");
    }

    /*
     * This code takes a string which converts it to a char array,
     * which then gets reversed.
     * Next the code checks how often the char 'o' is present and saves it to the variable x.
     * At the end the reversed char Array is converted back into a string and the result is printed.
     */
    public static void CodeStructure()
    {
        const string originalMessage = "The quick brown fox jumps over the lazy dog.";
        
        var charMessage = originalMessage.ToCharArray();
        Array.Reverse(charMessage);
        
        var x = charMessage.Count(i => i == 'o');

        var newMessage = new String(charMessage);
        
        Console.WriteLine(newMessage);
        Console.WriteLine($"'o' appears {x} times.");
    }
}