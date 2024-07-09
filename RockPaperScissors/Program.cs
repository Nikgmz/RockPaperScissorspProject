Console.WriteLine("Choose:");
Console.WriteLine("[r]ock [p]aper [s]cissors");
char input = char.Parse(Console.ReadLine());
List<char> computer = new List<char>{'r','p','s'};
Random rand = new Random();
int index =  rand.Next(0,3);
char opponent = computer[index];

if (opponent == 'r')
{
    Console.WriteLine("The computer chose Rock");
    if (input == 'r')
    {
        Console.WriteLine("Draw");
    }
    else if (input == 's')
    {
        Console.WriteLine("Rock wins");
    }
    else if (input == 'p')
    {
        Console.WriteLine("Paper wins");
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}
else if (opponent == 's')
{
    Console.WriteLine("The computer chose Scissors");
    if (input == 'r')
    {
        Console.WriteLine("Rock wins");
    }
    else if (input == 's')
    {
        Console.WriteLine("Draw");
    }
    else if (input == 'p')
    {
        Console.WriteLine("Scissors win");
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}
else
{
    Console.WriteLine("The computer chose Paper");
    if (input == 'r')
    {
        Console.WriteLine("Paper wins");
    }
    else if (input == 's')
    {
        Console.WriteLine("Scissors win");
    }
    else if (input == 'p')
    {
        Console.WriteLine("Draw");
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}
