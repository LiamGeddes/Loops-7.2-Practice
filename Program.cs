namespace Loops_7._2_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMMING TASK 1 - TEN TIMES");
            Console.Write("What is your favourite food? ");
            string food = Console.ReadLine();

            for (int i = 0; i <= 10; i = i +1)
            {
                Console.WriteLine(i + ". " + food + " is delicious.");
            }
            Console.WriteLine();

            //TASK 2

            Console.WriteLine("PROGRAMMING TASK 2 - COUNTING MACHINE");
            Console.Write("What do you want me to count to? ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= number; i = i +1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            

            //TASK 3
            Console.WriteLine("PROGRAMMING TASK 3 - COUNTING MACHINE REVISED");

            Console.Write("Count from: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Count to: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.Write("Count by: ");
            int count = Convert.ToInt32(Console.ReadLine());

            if (count <= 0)
            {
                Console.WriteLine("Error: Count by must be greater than 0.");
            }
            else
            {
                for (int i = start; i <= end; i = i + count)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();


            //TASK 4

            Console.WriteLine("TOPIC 7.2 - FOR LOOPS");
            Console.WriteLine("Type in a message, and I'll display it 10 times");
            Console.Write("Message: ");
            string message = Console.ReadLine();

            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine(i + ". " + message);
            }

            Console.WriteLine();





            Console.WriteLine("COUNT BY TWOS");

            for (int i = 2; i <= 10; i = i + 2)
            {
                Console.WriteLine(i + ". " + message);
            }
            Console.ReadLine();
        }
    }
}
