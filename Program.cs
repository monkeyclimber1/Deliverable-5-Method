namespace Deliverable_5_Method
{
    internal class Program
    {
              
        static int sum(int[] Array)
        {
            int MySum = Array.Sum();

            return MySum;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer number between 5 and 15: ");
                int input = int.Parse(Console.ReadLine());

                if (input >= 5 & input <= 15)
                {
                    int[] MyArray = random_array(input);

                    Console.Write("The elements in the random array are: ");

                    foreach (int i in MyArray)
                    {
                        Console.Write(i + " ");
                    }

                    Console.WriteLine("\nThe sum is: " + sum(MyArray));
                }
                else
                {
                    Console.WriteLine("Please enter an integer within the range 5 and 15");
                }

            }
            catch
            {
                Console.WriteLine("Enter an integer data type");

            }

        }
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }

            return MyArray;
        }
    }
}


