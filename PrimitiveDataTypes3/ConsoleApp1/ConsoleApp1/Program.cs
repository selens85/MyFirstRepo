// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;


string greeting = "Hello, World my name is Kaspars with variabble";
int number = 10;
double decimalNumber = 15.78;
char simbol = 'm';
bool answer = false;


Console.WriteLine(greeting);
Console.WriteLine(number);
Console.WriteLine(decimalNumber);
Console.WriteLine(simbol);
Console.WriteLine(answer);  


Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();


int num1 = 5;
int num2 = 2;

int sum = num1 + num2;
int diff = num1 - num2;
int multiply = num1 * num2;
double divide = num1 / (double)num2;
int leftAfter = num1 % num2;

num1++;
num2--;

Console.WriteLine(sum);
Console.WriteLine(diff);
Console.WriteLine(multiply);
Console.WriteLine(divide);
Console.WriteLine(leftAfter);
Console.WriteLine(num1);
Console.WriteLine(num2);


Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();


int num3 = 9;
int num4 = 9;


bool isEqual = num3 == num4;
bool isNotEqual = num3 != num4;
bool isLarger = num3 > num4;
bool isSmaller = num3 < num4;
bool isLargerEqual = num3 >= num4;
bool isSmallerEqual = num3 <= num4;


Console.WriteLine(isEqual);
Console.WriteLine(isNotEqual);
Console.WriteLine(isLarger);
Console.WriteLine(isSmaller);
Console.WriteLine(isSmallerEqual);
Console.WriteLine(isSmallerEqual);



Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();


bool isTrue = true;
bool isFalse = false;

bool isBoth = isTrue && isFalse;
bool isEitherOne = isTrue || isFalse;
bool converted = !isTrue;

Console.WriteLine(isBoth);
Console.WriteLine(isEitherOne);
Console.WriteLine(converted);


Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();



int num5 = 5;
int num6 = 6;


num5 += 2;
Console.WriteLine(num5);

num5 -= 2;
Console.WriteLine(num5);



Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();



// 1. Pajautāt lietotāja ievadi
Console.WriteLine("Ievadi savu vārdu?");

// 2. Sagaidīt lietotāja ievadi
string userName = Console.ReadLine();

// 3. Sasveicināties ar lietotāju uzmantojot vi;na vārdu
string userGreeting = "Sveiks " + userName + "!";
Console.WriteLine(userGreeting);

//1.Pautāt lietotājam ievadīt skaitli
 Console.WriteLine("Lūdzu ievadi skaitli");

//2.Sagaidīt lietotāja skaitļa ievadi
 string userNumberText = Console.ReadLine();
int usernumber = int.Parse(userNumberText);

//3.Formatētā tekstā izvadīt lietotāja skaitli palielināt par 2
 int result = usernumber + 2;
Console.WriteLine("Tavs skaitlis palielināts par 2: " + result);



int x = -4;
int y = 9;

int absoluteNumber = Math.Abs(x);
int largest = Math.Max(x, y);
int smaller = Math.Min(x, y);

double toRound = 45.856;
double rounded = Math.Round(toRound, 2);



Console.WriteLine(absoluteNumber); 
Console.WriteLine(largest); 
Console.WriteLine(smaller);
Console.WriteLine(rounded);




Console.WriteLine();
Console.WriteLine("===========================================");
Console.WriteLine();



string name = "Kaspars";
int age = 40;


Console.WriteLine("Sveiks " + name + " sveiciens dzimšanas dienā tavos " + age + " gados!");
Console.WriteLine($"Sveiks {name} sveiciens dzimšanas dienā tavos {age} gados!");











