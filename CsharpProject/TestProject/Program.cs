/* Random Dice */
Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;

/* Condition */

if (total >= 14)
{
    Console.WriteLine("You Win!!");
}
else
{
    Console.WriteLine("You Lose!!");
}

if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll2))
{
    Console.WriteLine("You rolled doubles!");
    total += 2;
}
if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples!");
    total += 6;
}

Console.WriteLine($"Dice Roll :{roll1} + {roll2} + {roll3} = {total}.");

// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("sassy");
// Console.WriteLine(result);

// if (message.Contains("lazy"))
// {
//     Console.WriteLine("What does the fox say?");
// } else
// {
//    Console.WriteLine("Nothing to see here.");
// }
