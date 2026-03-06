using System;

namespace MSCourse.Assignments;

public class CallMethods {
    public static void RandomDice()
    {
        Random dice = new Random();
        int roll = dice.Next(1, 7);
        Console.WriteLine(roll);
    }
}