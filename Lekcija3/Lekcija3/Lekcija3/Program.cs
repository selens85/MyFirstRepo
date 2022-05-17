// See https://aka.ms/new-console-template for more information

using Lekcija3;

Claas1 kaspars = new Claas1("Kaspars");

 
kaspars.Age = 37;
kaspars.IsMale = true;

string kasparsName = kaspars.Name;

Console.WriteLine($"I have created with name: {kasparsName}");

kaspars.Greeting();

kaspars.Call("222222");


Claas1 person = new Claas1("Kiki");


person.Age = 33;
person.IsMale = false;

person.Greeting();

person.Call("333333333");


Console.WriteLine();
Console.WriteLine("===============================");
Console.WriteLine();


string name = "Kaspars";
string nameToChange = name;
nameToChange = "1111111111";

Console.WriteLine($"Name is: {name}");
Console.WriteLine($"Name to change is: {nameToChange}");


Claas1 person2 = new Claas1("Artis");
person2.Age = 40;

Claas1 personToChange = person2;
personToChange.Age = 55;

Console.WriteLine($"Person age: {person2.Age}");
Console.WriteLine($"Person to change age: {personToChange.Age}");
