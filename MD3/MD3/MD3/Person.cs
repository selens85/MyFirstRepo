

namespace MD3
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirhtDate { get; set; }
        public string Hobby { get; set; }
        public string Gender { get; set; }

        public void Greeting()
        {
            Console.WriteLine($" Hello, my name is {Name} {Surname} and I am male - {Gender} my hobby is {Hobby} and my age is {BirhtDate}");
        }
       
    }
}
