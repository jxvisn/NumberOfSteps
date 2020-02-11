using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfSteps
{
    class Program
    {
        static void Main(string[] args)
        {

            //First we need some Input
            Console.WriteLine("Give us an input: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var originalInput = input;
            //Then we need to evaluate that input

            var numberOfSteps = 0; // We need to keep track of the number of steps it takes to solve

            while (input != 0)
            {

                if(input % 2 == 0)
                {
                    // Then the number is an even number and we need to divide by two
                    input = input / 2;
                    numberOfSteps++;

                } else if (input % 2 != 0)
                {
                    // Then this must be an odd number, subtract one to make it even
                    input = input - 1;
                    numberOfSteps++;

                }

            }
            //Number is equal to 0 we are done evaluating
            Console.WriteLine("Your Original Input Was: " + originalInput);
            Console.WriteLine("Number of steps to solve: " + numberOfSteps);
            //Then we need to give the output

        }
    }
}
