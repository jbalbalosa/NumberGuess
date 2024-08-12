int num1 = 0;
int num2 = 0;

Console.WriteLine("Guess a whole number");
Console.WriteLine("Number 1:*");
Console.Write("Enter a Number 2:");

if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal!");
}
else 
{
    Console.WriteLine("Numbers aren't equal");
}

Console.ReadLine();