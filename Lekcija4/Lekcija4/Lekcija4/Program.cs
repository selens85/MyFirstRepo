

Console.WriteLine("Start");

Console.WriteLine("Ievadi savu vecumu");
string userAgeText = Console.ReadLine();
int age = int.Parse(userAgeText);


if (age >= 18)
{
    Console.WriteLine("Tu esi pieaugušais");
}
else if (age >= 13)
{
    Console.WriteLine("Tu esi pusaudzis");
}
else
{
    Console.WriteLine("Tu vēl esi bērns");
}


string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Tu neievadīji savu vārdu");
}
else
{
    Console.WriteLine($"Tavs vārds ir: {name}");

}

Console.WriteLine("End");


