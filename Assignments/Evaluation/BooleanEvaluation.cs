using System;
namespace MSCourse.Assignments.Evaluation;

public static class BooleanEvaluation
{
    public static void BooleanExpression()
    {
        string sentence = "This is a sentence about a fox that lives in the wild";
        string myValue = " A";
        
        Console.WriteLine("a" == "A");
        Console.WriteLine("a" == "a");
        Console.WriteLine("a" == myValue.Trim().ToLower());
        Console.WriteLine(myValue != "a");
        Console.WriteLine($"The word \"Fox\" is in the sentence: {sentence.ToLower().Contains("fox")}");
    }

    public static void CoinFlip()
    {
        Random coin = new Random();
        int coinValue = coin.Next(0, 2);
        Console.WriteLine($"The coin landed on:{(coinValue == 0 ? "Head" : "Tails")} Value:{coinValue}");
    }
}