using System;

namespace MSCourse.Assignments.Methods;

public static class CallMethods {
    public static void RandomDice()
    {
        Random dice = new Random();
        int roll = dice.Next(1, 7);
        Console.WriteLine(roll);
    }

    public static void OverloadedDice()
    {
        Random dice = new Random();
        int roll1 = dice.Next();
        int roll2 = dice.Next(101);
        int roll3 = dice.Next(50,101);
        
        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");
    }

    public static int GetMaxAssignment(int val1, int val2)
    {
        int firstValue = val1;
        int secondValue = val2;
        int largerValue = Math.Max(firstValue, secondValue);

        return largerValue;
    }

    //Dice Roll Logic
    public static int DiceRoll()
    {
        Random dice = new Random();
        
        int roll1 = dice.Next(1,7);
        int roll2 = dice.Next(1,7);
        int roll3 = dice.Next(1,7);

        int total = roll1 + roll2 + roll3;
        
        // Check for Doubles or Triples
        if (HasDoubles(roll1, roll2, roll3) && !HasTriples(roll1, roll2, roll3))
        {
            Console.WriteLine("Your rolled doubles! +2 bonus to total!");
            total += 2;
        }
        else if (HasTriples(roll1, roll2, roll3))
        {
            Console.WriteLine("You rolled triples! +6 bonus to total");
            total += 6;
        }
        
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
        return total;
    }
    
    //Helper method to decide if has doubles
    private static bool HasDoubles(int roll1, int roll2, int roll3)
    {
        if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
        {
            return true;
        }
        return false;
    }
    
    //Helper method to decide if has triples
    private static bool HasTriples(int roll1, int roll2, int roll3)
    {
        if ((roll1 == roll2) && (roll2 == roll3))
        {
            return true;
        }
        return false;
    }
    
    
}