

namespace Lekcija3
{

    public class Claas1
    {
        public Claas1(string name)
        {

            Name = name;
            Console.WriteLine($"Creating person with name: {name}");

            
        }

        public Claas1() 
        {
            Name = "Unknown";
            Console.WriteLine("Creating Jone Doe");
        }


        public string Name { get; }

        public int Age { get; set; }

        public bool IsMale { get; set; } 


        public void Greeting()
        {
            Console.WriteLine($"Hello my name is {Name} ang my age is {Age}");
        }

        public void Call(string phoneNumber) 
        {
            Console.WriteLine($"{Name} is calling to {phoneNumber}");
        }


    }
}
