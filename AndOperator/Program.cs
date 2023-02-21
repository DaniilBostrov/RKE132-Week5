//Math >= 90; Biology >= 90; Chem >=90;

int math, biology, chemistry;

Console.WriteLine("Enter your math result: ");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result: ");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("enter your Chemistry result: ");
chemistry= Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congradulations you have got accepted!");
}
else
{ 
    Console.WriteLine("Your application can not be approved.");
}

