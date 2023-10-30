using System;

namespace week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("Enter a comma seperated list of numbers that you want to sort in ascending order!");
                string input = Console.ReadLine();
                string[] numberStrings = input.Split(',');
                // i wanted for user to be able enter an integer and doubles as well
                //integers and doubles are not initialized,
                //which means all elements in these arrays are initialized to their default values
                //(0 for integers and 0.0 for doubles). This is why i was seing seeing 0,
                //system.collections.generic solved this problem
                var integers = new System.Collections.Generic.List<int>();
                var doubles = new System.Collections.Generic.List<double>();
                bool isValidInput = true;

                for (int i = 0; i < numberStrings.Length; i++)
                {
                    if (double.TryParse(numberStrings[i].Trim(), out double doubleNumber))
                    {
                        doubles.Add(doubleNumber);
                    }
                    //i need to right down same Parse but now for Int only
                    else if (int.TryParse(numberStrings[i].Trim(), out int intNumber))
                    {
                        integers.Add(intNumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter numbers only,or try to remove coma at the end");
                        isValidInput = false;
                        break;

                    }
                }
                if (isValidInput)
                {
                    integers.Sort();
                    doubles.Sort();

                   
                    //i had two of this code for sortedDoubles and sortedIntegers,but it was showing me two outputs,
                    //so i decided to delete sortedIntegers, and now its showing me only one ouput
                    string sortedDoubles = string.Join(",", doubles);
                    Console.WriteLine("Sorted array in ascending order:" + sortedDoubles);

                }
                Console.WriteLine("Would you like to continue (Y = yes, N = no)");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye!");
            Console.ReadKey();

        }

    }
}
