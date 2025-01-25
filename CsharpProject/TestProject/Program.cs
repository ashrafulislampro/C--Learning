Random random = new Random();
int current = 0;
int hero = 10;
int monster = 10;
do
{

    current = random.Next(1, 11);
    monster -= current;
    Console.WriteLine($"Monster health : {monster} , Damage health : {current}");

    if (monster <= 0)
    {
        Console.WriteLine("\nHero Win!\n");
        break;
    }

    current = random.Next(1, 11);
    hero -= current;
    Console.WriteLine($"Hero health : {hero}, Damage health : {current}");

    if (hero <= 0)
    {
        Console.WriteLine("\nMonster Win!\n");
        break;
    }

} while (hero > 0 && monster > 0);
