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

    public static void DoRandomWhile()
    {
        Random random = new Random();
        int current = random.Next(1, 11);
        
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
        Random random = new Random();
        int healthHero = 10;
        int heroAttack = random.Next(1, 11);
        int healthMonster = 10;
        int monsterAttack = random.Next(1, 11);
        bool gameIsActive = true;

        while (gameIsActive)
        {
            healthMonster -= heroAttack;
            Console.WriteLine("Hero attacked monster for: {0}HP, {1}HP remain!",heroAttack, healthMonster);
            heroAttack = random.Next(1, 11);

            if (healthMonster > 0)
            {
                healthHero -= monsterAttack;
                Console.WriteLine("Monster attacked hero for: {0}HP, {1}HP remain!",monsterAttack,healthHero);
                monsterAttack = random.Next(1, 11);
            }

            if (healthMonster <= 0)
            {
                Console.WriteLine("Hero wins !");
                gameIsActive = false;
            }else if (healthHero <= 0)
            {
                Console.WriteLine("Monster wins!");
                gameIsActive = false;
            }
        }
        
        Console.WriteLine("Game ended !");
    }
}