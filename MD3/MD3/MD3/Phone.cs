

namespace MD3
{
    public class Phone
    {
    public double Size { get; set; }
    public string MadeBy { get; set; }
    public string Model { get; set; }

    public void Call()
        { 
            Console.WriteLine("Calling");
        }
    public void Sms()
        {
            Console.WriteLine("Sms sent");
        }
    }
}
