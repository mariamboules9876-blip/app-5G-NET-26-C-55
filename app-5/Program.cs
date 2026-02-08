namespace app_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part1




            //            using System;

            //enum DayOfWeekEnum
            //        {
            //            Saturday,
            //            Sunday,
            //            Monday,
            //            Tuesday,
            //            Wednesday,
            //            Thursday,
            //            Friday
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                Console.Write("Enter a day number (0-6): ");
            //                int number = int.Parse(Console.ReadLine());

            //                if (number < 0 || number > 6)
            //                {
            //                    Console.WriteLine("Invalid input");
            //                    return;
            //                }

            //                DayOfWeekEnum day = (DayOfWeekEnum)number;
            //                Console.WriteLine("Day: " + day);

            //                switch (day)
            //                {
            //                    case DayOfWeekEnum.Saturday:
            //                    case DayOfWeekEnum.Friday:
            //                        Console.WriteLine("It's the Weekend");
            //                        break;

            //                    default:
            //                        Console.WriteLine("It's a Workday");
            //                        break;
            //                }
            //            }
            //        }




            //Part2-Q1


//            using System;

//class Program
//        {
//            static void Main()
//            {
//                Console.Write("Enter array size: ");
//                int size = int.Parse(Console.ReadLine());

//                int[] numbers = new int[size];
//                int sum = 0;

//                for (int i = 0; i < size; i++)
//                {
//                    Console.Write($"Enter element [{i}]: ");
//                    numbers[i] = int.Parse(Console.ReadLine());
//                    sum += numbers[i];
//                }

//                int max = numbers[0];
//                int min = numbers[0];

//                for (int i = 1; i < size; i++)
//                {
//                    if (numbers[i] > max)
//                        max = numbers[i];

//                    if (numbers[i] < min)
//                        min = numbers[i];
//                }

//                double average = (double)sum / size;

//                Console.WriteLine("Sum = " + sum);
//                Console.WriteLine("Average = " + average);
//                Console.WriteLine("Max = " + max);
//                Console.WriteLine("Min = " + min);

//                Console.Write("Reverse = ");
//                for (int i = size - 1; i >= 0; i--)
//                {
//                    Console.Write(numbers[i] + " ");
//                }
//            }
//        }


    }
}
}
