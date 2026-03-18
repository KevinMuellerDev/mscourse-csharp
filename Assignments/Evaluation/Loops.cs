using System;

namespace MSCourse.Assignments;

public static class Loops
{
    public static void ForLoopTask()
    {
        string[] names = ["Alex", "Eddie", "David", "Michael"];
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "David")
            {
                names[i] = "Sammy";
            }
        }
        
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    public static void FizzBuzz()
    {
        for (int i = 0; i <= 100; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
            {
                Console.WriteLine("{0} FizzBuzz",i);
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("{0} Fizz",i);
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("{0} Buzz",i);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}