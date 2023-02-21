//temp <= 0 - Feezing cold
//temp >= 0 and temp < 10 - Cold
//temp >= 10 and < 15 - Chilly
// temp >= 15 and < 20 - Warm
//temp >= 20 and < 30 - Hot
//temp >=30 - Boiling hot

using System.Runtime.CompilerServices;

Console.WriteLine("Enter your temperature: ");
int temp = int.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("Boiling Hot");
}
else if (temp < 30 && temp >= 20)
{
    Console.WriteLine("Hot");
}
else if (temp < 20 && temp >= 15)
{
    Console.WriteLine("Warm");
}
else if (temp < 15 && temp >= 10)
{
    Console.WriteLine("Chilly");
}
else if (temp < 10 && temp > 0)
{
    Console.WriteLine("Cold");
}
else
{
    Console.WriteLine("Freezing cold");
}