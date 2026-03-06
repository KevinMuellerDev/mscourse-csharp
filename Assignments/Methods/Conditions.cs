using System;

namespace MSCourse.Assignments.Methods;

public static class Conditions
{
    public static void DiceGame()
    {
        int total = CallMethods.DiceRoll();
        Console.WriteLine(total >= 15 ? "You win!" : "Sorry, you lose.");
    }

    public static void SubscriptionRenewalRate()
    {
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        if ((daysUntilExpiration <= 10) && (daysUntilExpiration > 5))
        {
            Console.WriteLine("Your subscription will expire soon, Renew now!");
        }
        else if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1))
        {
            discountPercentage = 10;
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}!");
        }
        else if (daysUntilExpiration == 1)
        {
            discountPercentage = 20;
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}!");
        }
        else if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        

    }
}