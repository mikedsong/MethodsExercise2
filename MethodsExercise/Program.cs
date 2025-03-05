using System.Threading.Channels;

namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favBand = Console.ReadLine();
            
            Console.WriteLine($"one day, {userName} was walking through the woods while wearing a {favColor} t-shirt. {userName} saw a {favAnimal} listening to {favBand}");
        }

        static void Main(string[] args)
        {
            Madlib();
        }
    }
}
