Random randomDays = new();

int daysUntilExpiration = randomDays.Next(0, 31);

if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration <= 5)
    {
        Console.WriteLine(
            $"Your subscription expires in {daysUntilExpiration} days.\n Renew now and save 10%!"
        );
    }
    else if (daysUntilExpiration == 1)
    {
        Console.WriteLine("Your subscription expires tomorrow! Renew now to avoid interruption.");
    }

    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else
{
    Console.WriteLine(
        $"Your subscription expires in {daysUntilExpiration} days. Renew now to continue enjoying our services!"
    );
}
