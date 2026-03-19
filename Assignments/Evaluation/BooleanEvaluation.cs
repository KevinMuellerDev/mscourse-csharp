using System;

namespace MSCourse.Assignments.Evaluation;

public static class BooleanEvaluation
{
    public static void BooleanExpression()
    {
        var sentence = "This is a sentence about a fox that lives in the wild";
        var myValue = " A";

        Console.WriteLine("a" == "A");
        Console.WriteLine("a" == "a");
        Console.WriteLine("a" == myValue.Trim().ToLower());
        Console.WriteLine(myValue != "a");
        Console.WriteLine($"The word \"Fox\" is in the sentence: {sentence.ToLower().Contains("fox")}");
    }

    public static void CoinFlip()
    {
        var coin = new Random();
        var coinValue = coin.Next(0, 2);
        Console.WriteLine($"The coin landed on:{(coinValue == 0 ? "Head" : "Tails")} Value:{coinValue}");
    }

    public static void BusinessRules()
    {
        var permission = "Admin|Manager";
        var level = 55;

        if (level > 55)
            Console.WriteLine("Welcome Super Admin user.");
        else if (permission.Contains("Admin") && level <= 55)
            Console.WriteLine("Welcome Admin user.");
        else if (permission.Contains("Manager") && level >= 20)
            Console.WriteLine("Contact an Admin for access.");
        else if (permission.Contains("Manager") && level < 20)
            Console.WriteLine("You do not have sufficient Privileges");
        else
            Console.WriteLine("You do not have sufficient Privileges");
    }

    public static void RefactorVariableScope()
    {
        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        var total = 0;
        var found = false;

        foreach (var number in numbers)
        {
            total += number;
            if (number == 42)
                found = true;
        }

        if (found)
            Console.WriteLine("Set contains 42");

        Console.WriteLine($"Total: {total}");
    }

    public static void SwitchChallengeSku()
    {
        // SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
        var sku = "01-MN-L";

        var product = sku.Split('-');

        var type = "";
        var color = "";
        var size = "";

        switch (product[0])
        {
            case "01":
                type = "Sweat shirt";
                break;
            case "02":
                type = "T-Shirt";
                break;
            case "03":
                type = "Sweat pants";
                break;
            default:
                type = "Other";
                break;
        }

        switch (product[1])
        {
            case "BL":
                color = "Black";
                break;
            case "MN":
                color = "Maroon";
                break;
            default:
                color = "White";
                break;
        }

        switch (product[2])
        {
            case "S":
                size = "Small";
                break;
            case "M":
                size = "Medium";
                break;
            case "L":
                size = "Large";
                break;
            default:
                size = "One Size Fits All";
                break;
        }

        Console.WriteLine($"Product: {size} {color} {type}");
    }
}