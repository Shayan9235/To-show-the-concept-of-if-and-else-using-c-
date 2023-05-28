internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("hello dude");
        
        Console.WriteLine("enter a number between 1-10: ");
        int number;
        if(int.TryParse(Console.ReadLine(),out number))
        {
            if(number >=1 && number <= 10)
            {
                Console.WriteLine("valid");

            }
            else
            {
                Console.WriteLine("invalid");
            }
            

        }
        else
        {
            Console.WriteLine("invalid");
        }

    }
}