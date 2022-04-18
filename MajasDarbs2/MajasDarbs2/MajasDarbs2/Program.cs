// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;


Console.WriteLine("Kā Tevi sauc?");
string userName = Console.ReadLine();
string userInput = "Sveiks " + userName + "!";
Console.WriteLine(userInput);

Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();

Console.WriteLine("Kāds ir Tavs vecums");
int userAge = int.Parse(Console.ReadLine());
int ageNextYear = userAge + 1;
Console.WriteLine("Nākamgad Tev paliks " + ageNextYear);

Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();

Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi trešo skaitli");
int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi ceturto skaitli");
int fourthNumber = int.Parse(Console.ReadLine());

int firstMaxNumber = Math.Max(firstNumber, secondNumber);
int secondMaxNumber = Math.Max(thirdNumber, fourthNumber);
int maxNumber = Math.Max(firstMaxNumber, secondMaxNumber);

Console.WriteLine("Lielākais skaitlis ir: " + maxNumber);

Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();

Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstDigit = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondDigit = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi trešo skaitli");
int thirdDigit = int.Parse(Console.ReadLine());

int firstMinNumber = Math.Min(firstDigit, secondDigit);
int secondMinNumber = Math.Min(firstMinNumber, thirdDigit);
int minNumber = Math.Min(firstMinNumber, secondMinNumber);

Console.WriteLine("Mazākais skaitlis ir: " + minNumber);

Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();

Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstFigure = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondFigure = int.Parse(Console.ReadLine());

int result = firstFigure % secondFigure;
Console.WriteLine("Dalījuma atlikums ir: " + result);

Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();

Console.WriteLine("Ldzu ievadi slaitli");
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;
Console.WriteLine("Skaitlis ir pāra skaitlis: " + isEven);

Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();

Console.WriteLine("Lūdzu, ievadiet pirmās malas garumu");
double firstSide = double.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu ievadiet otrās malas garumu");
double secondSide = double.Parse(Console.ReadLine());

double area = firstSide * secondSide;
double rounded = Math.Round(area, 2);
Console.WriteLine("Tasnstūra laukums ir: " + rounded);

Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();

Console.WriteLine("Lūdzu, ievadi trijstūra malas garumu");
int triangleSide = int.Parse(Console.ReadLine());

int triangleArea = triangleSide * triangleSide / 2;
Console.WriteLine("Trijstūra laukums ir: " + triangleArea);

Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();

Console.WriteLine($"Sveiks {userName}, Tavs vecums ir {userAge}.");