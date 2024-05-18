Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine($"{daysUntilExpiration} Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"{daysUntilExpiration} Your subscription expires within a day! Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine($"{daysUntilExpiration} Your subscription will expire soon. Renew now!");
}
else
{
    Console.WriteLine($"{daysUntilExpiration} Your subscription has expired.");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"\nRenew now and save {discountPercentage}%");
}

// #######################################################

// string msg = "The quick brow fox jump over the lazy dog.";
// bool result = msg.Contains("dog");
// Console.WriteLine(result);

// if (msg.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }

// #######################################################

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int roll1 = 6;
// int roll2 = 6;
// int roll3 = 6;

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3)) 
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }

//     else
//     {    
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine($"{total} You win!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine($"{total} Sorry, you lose.");
// }
// else if (total == 7)
// {
//     Console.WriteLine($"{total}Ganhou uma viajem");
// }
// else
// {
//     Console.WriteLine($"{total}You win a kitten!");
// }

// ################################################################
// Resolução

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }