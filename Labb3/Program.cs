namespace Labb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Case 1

            //int number = 2;

            //if (number > 3)
            //{
            //    Console.WriteLine("Talet är större än tre")
            //}
            //elseif(number < 3)
            //{
            //    Console.WriteLine("Talet är mindre än tre");
            //}

            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre"); // missing semicolon
            }
            else if (number < 3) // missing space in else if
{
                Console.WriteLine("Talet är mindre än tre");
            }
            else // if the number is exactly three
            {
                Console.WriteLine("Talet är tre");
            }

            // Case 2

            //for (int i = 1; i < 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 1; i <= 100; i++) // added a equal sign so it stop when i is over 100
            {
                Console.WriteLine(i);
            }

            // Case 3

            //for (int i = 1; i <= 5; i)
            //{
            //    for (int j = 1; j <= i; j)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 1; i <= 5; i++) // added ++ in the end of eche for statment so it counts its iterations
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            //Case 4

            //int i = 1;
            //while (i <= 5)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write();
            //    }

            //    Console.WriteLine();
            //    i++;
            //}

            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i); // added i so it outputs rows of numbers that increses by 1 for every row
                }

                Console.WriteLine();
                i++;
            }

            //Case 5

            //int i = 1;

            //switch (i)
            //{
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Two");
            //        break;
            //    default:
            //        Console.WriteLine("Other");
            //        break;
            //}

            int i = 1;

            switch (i)
            {
                case 1:
                    break; // added break so the switch method ends
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }

            //Case 6

            //int i = 10;

            //if (i = 5)
            //{
            //    Console.WriteLine("i är 5");
            //}

            int i = 10;

            if (i == 5) // you half to put 2 equal signs for it to ba a equal operator
            {
                Console.WriteLine("i är 5");
            }
        }
    }
}
