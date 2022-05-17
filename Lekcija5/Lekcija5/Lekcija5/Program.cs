

int[] numsShort = { 3, 14, 5, 6, 8, 14 };
int[] nums = new int[3];

nums[0] = 25;
nums[1] = 15;
nums[2] = 5;
int first = nums[0];

int lastElementIndex = nums.Length - 1;
int last = nums[lastElementIndex];

Console.WriteLine($"first value : {first}");
Console.WriteLine($"Last value: {last}");


Console.WriteLine();
Console.WriteLine("=====================================================");
Console.WriteLine();

for (int i = 0; i < numsShort.Length; i++)
{
    int num = numsShort[i];

    Console.WriteLine($"Num in short {num}");
}

Console.WriteLine("=====================================================");




    Console.WriteLine("=====================================================");

    int iterator = 0;
    while (iterator < numsShort.Length)
    {
        int num = numsShort[iterator];

        Console.WriteLine($"Num in short {num}");
        iterator++;
}
Console.WriteLine("=====================================================");


bool couldParse;
int number;

do
{
    Console.WriteLine("Lūdzu ievadi skaitli?");

    string userInput = Console.ReadLine();

    couldParse = int.TryParse(userInput, out number);

} while (!couldParse);

Console.WriteLine($"You entered {number}");
