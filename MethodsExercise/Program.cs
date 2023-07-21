using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for short story, press 2 for operators");
            string pick = Console.ReadLine();
            if (pick == "1")
            {
                ShortStory();
            }
            else
            {
                Console.WriteLine(Add(10, 6, 5, 123, 0));
                Console.WriteLine(Subtract(82, 22, 36));
                Console.WriteLine(Multiply(2, 5, 3));
                Console.WriteLine(Divide(200, 10, 5));
            }
        }

        public static void ShortStory ()
        {
            Console.WriteLine("Welcome to the Day at the Mall interactive story. Who is coming to our mall today?");
            string name = Console.ReadLine();

            Console.WriteLine("What is the city of the mall would you like to be in today?");
            string city = Console.ReadLine();

            Console.WriteLine($"Hello {name}! What is your favorite store in the mall?");
            string favStore = Console.ReadLine();

            Console.WriteLine("How many hours do you want to spend in the mall today?");
            string hours = Console.ReadLine();

            Console.WriteLine($"And lastly, {name}, in your {hours} hours at the mall you will inevitably get hungry. Where would you like to eat?");
            string foodPlace = Console.ReadLine();

            Console.WriteLine($"\nIt was a hot summer day in sunny {city}. {name} and their friends went to the mall to get some relief from the hot weather and kill some time.");
            Console.WriteLine($"They started off going to {favStore}, {name}'s favorite store. They looked around, but didn't end up finding anyting they would like.");
            Console.WriteLine($"After wandering around a couple more stores they got hungry and decided to get some food at {foodPlace}");
            Console.WriteLine($"It seems they lost track of time bacause in going to {favStore} and after eating at {foodPlace} they ended up spending {hours} hours at the mall! They had to leave, but they had so much fun.");
            Console.WriteLine("Thank you for coming to the interactive mall story. Have a great day!");
        }
        public static double Add(params double[] numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public static double Subtract(params double[] numbers)
        {
            double difference = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                difference -= numbers[i + 1];
            }
            return difference;
        }
        public static double Multiply(params double[] numbers)
        {
            double product = 1;
            foreach (double number in numbers)
            {
                product *= number;
            }
            return product;
        }
        public static double Divide(params double[] numbers)
        {
            double quotient = numbers[0];
            for (int i = 0; i < numbers.Length-1; i++)
            {
                quotient /= numbers[i+1];
            }
            return quotient;
        }
    }
}
