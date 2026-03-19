using System;

namespace MSCourse.Assignments.Loops;

public static class Loops
{
    public static void ForLoopTask()
    {
        string[] names = ["Alex", "Eddie", "David", "Michael"];
        for (var i = 0; i < names.Length; i++)
            if (names[i] == "David")
                names[i] = "Sammy";

        foreach (var name in names) Console.WriteLine(name);
    }

    public static void FizzBuzz()
    {
        for (var i = 0; i <= 100; i++)
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("{0} FizzBuzz", i);
            else if (i % 3 == 0)
                Console.WriteLine("{0} Fizz", i);
            else if (i % 5 == 0)
                Console.WriteLine("{0} Buzz", i);
            else
                Console.WriteLine(i);
    }

    public static void DoRandomWhile()
    {
        var random = new Random();
        int current;

        do
        {
            current = random.Next(1, 11);
            if (current >= 8) continue;

            Console.WriteLine(current);
        } while (current != 7);


        /*while (current >=3)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }*/

        Console.WriteLine($"Last number: {current}");
    }

    public static void GameAssignment()
    {
        var random = new Random();
        var healthHero = 10;
        var heroAttack = random.Next(1, 11);
        var healthMonster = 10;
        var monsterAttack = random.Next(1, 11);
        var gameIsActive = true;

        while (gameIsActive)
        {
            healthMonster -= heroAttack;
            Console.WriteLine("Hero attacked monster for: {0}HP, {1}HP remain!", heroAttack, healthMonster);
            heroAttack = random.Next(1, 11);

            if (healthMonster > 0)
            {
                healthHero -= monsterAttack;
                Console.WriteLine("Monster attacked hero for: {0}HP, {1}HP remain!", monsterAttack, healthHero);
                monsterAttack = random.Next(1, 11);
            }

            if (healthMonster <= 0)
            {
                Console.WriteLine("Hero wins !");
                gameIsActive = false;
            }
            else if (healthHero <= 0)
            {
                Console.WriteLine("Monster wins!");
                gameIsActive = false;
            }
        }

        Console.WriteLine("Game ended !");
    }

    public static void UserInput()
    {
        string? readResult;
        var validEntry = false;

        Console.WriteLine("Enter a string:");

        do
        {
            readResult = Console.ReadLine();

            if (readResult == null)
                continue;

            if (readResult.Length >= 3)
                validEntry = true;
            else
                Console.WriteLine("Your input is invalid, please try again");
        } while (!validEntry);

        Console.WriteLine("Your input was: {0}", readResult);
    }

    public static void Assignment1()
    {
        string? readInput;
        var inputValue = 0;
        bool isNumeric;
        var inputAccepted = false;

        Console.WriteLine("Provide a value between 5 and 10");

        do
        {
            readInput = Console.ReadLine();
            if (readInput == null) continue;

            isNumeric = int.TryParse(readInput, out inputValue);

            if (!isNumeric)
            {
                Console.WriteLine("You have to insert a numeric value!");
                continue;
            }

            if (inputValue < 5 || inputValue > 10)
            {
                Console.WriteLine("You have to Provide a value between 5 and 10!");
                continue;
            }

            inputAccepted = true;
        } while (!inputAccepted);

        Console.WriteLine("Your value {0} has been accepted", inputValue);
    }

    public static void Assignment2()
    {
        string? readInput;
        var isAccepted = false;

        do
        {
            Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

            readInput = Console.ReadLine();
            if (string.IsNullOrEmpty(readInput))
            {
                Console.WriteLine("You have to provide a role!");
                continue;
            }

            readInput = readInput.Trim().ToLower();

            if (readInput != "administrator" && readInput != "manager" && readInput != "user")
            {
                Console.WriteLine($"The role name that you entered, \"{readInput}\" is not valid.");
                continue;
            }

            isAccepted = true;
        } while (!isAccepted);

        Console.WriteLine($"Your input value ({readInput}) has been accepted.");
    }

    public static void Assignment3()
    {
        string[] myStrings =
            { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

        foreach (var myString in myStrings)
        {
            var index = myString.IndexOf(".", StringComparison.Ordinal);
            var usedString = myString;
            string mySentence;

            while (index != -1)
            {
                mySentence = usedString.Remove(index);
                usedString = usedString.Substring(index + 1).TrimStart();
                index = usedString.IndexOf(".", StringComparison.Ordinal);
                Console.WriteLine(mySentence);
            }

            mySentence = usedString.Trim();
            Console.WriteLine(mySentence);
        }
    }
}