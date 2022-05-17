

using MD3;

Phone iPhone = new Phone();

iPhone.Size = 128;
iPhone.MadeBy = "Apple";
iPhone.Model = "iPhone 12";

double iPhoneSize = iPhone.Size;
Console.WriteLine($"Telefona atmiņas izmērs ir {iPhoneSize}GB");

string iPhoneMadeBy = iPhone.MadeBy;
Console.WriteLine($"Telefona ražotājs ir {iPhoneMadeBy}");

string iPhoneModel = iPhone.Model;
Console.WriteLine($"Telefona modelis ir {iPhoneModel}");

iPhone.Call();

iPhone.Sms();

Console.WriteLine();
Console.WriteLine("==========================");
Console.WriteLine();

Car Tesla = new Car();

Tesla.Brand = "Cybertruck";
Tesla.NuberPlate = "LV2022";
Tesla.Speed = 10;

Tesla.StartToDrive();

Tesla.GoFaster();

Tesla.Beep();

Tesla.SlowDown();

Tesla.Stop();

Console.WriteLine();
Console.WriteLine("==========================");
Console.WriteLine();


Product Brick = new Product(30, 15, 5);

double BrickLenght = Brick.Lenght;

Console.WriteLine($"Ķieģeļa garums ir {BrickLenght} cm");

double BrickWidth = Brick.Width;

Console.WriteLine($"Ķieģeļa platums ir {BrickWidth} cm");

double BrickWeight = Brick.Weight;

Console.WriteLine($"Ķieģeļa svars ir {BrickWeight} kg");

Console.WriteLine();
Console.WriteLine("==========================");
Console.WriteLine();


Person subject = new Person();

Console.WriteLine("Please enter youre name");

subject.Name = Console.ReadLine();

Console.WriteLine("Please enter your surname");

subject.Surname = Console.ReadLine();

Console.WriteLine("Please enter youre birht year");

string subjectBirthYear = Console.ReadLine();   

int birthYear = int.Parse(subjectBirthYear);

int BirthDate = DateTime.Now.Year - birthYear;

Console.WriteLine("What is youre hobby?");

subject.Hobby = Console.ReadLine();

Console.WriteLine("Are you a male (true or false)?");

subject.Gender = Console.ReadLine();

subject.Greeting();








