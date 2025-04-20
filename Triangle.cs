namespace ProblemSolving3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the height of the triangle: ");
            int height = int.Parse(Console.ReadLine());

            for (int row = 1; row <= height; row++)
            {
                for (int space = 0; space < (height - row) * 2; space++)
                {
                    Console.Write(" ");
                }

                // Print numbers increasing to the middle (powers of 2)
                int value = 1;
                for (int i = 1; i <= row; i++)
                {
                    Console.Write(value + " ");
                    value *= 2;
                }

                // Print numbers decreasing after the middle
                value /= 2; // Step back to the previous value
                for (int i = 1; i < row; i++)
                {
                    value /= 2;
                    Console.Write(value + " ");
                }

                Console.WriteLine();
            }

        }

    }
}


 
                                                                                                                                                                                              // Console.Write(value + " "); } // سطر جديد بعد كل صف Console.WriteLine(); } } }