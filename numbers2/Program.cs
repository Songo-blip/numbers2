using System;

namespace Numbers
{
    class Program
    {

        private static int BiggestNumber(int[] numbers)

        {
            int i;
            int max = numbers[0];
            for (i = 1; i < numbers.Length; i++)
            if (numbers[i] > max)
                max = numbers[i];

            return (max); 
        }
                   
         static void Main(string[] args)
         { 
            int[] mynumbers = { 2, 1, 7, 4, 9, 5 };

            int biggest = BiggestNumber(mynumbers);

          
                Console.WriteLine("biggest number is" + biggest);
         }
    }

}
             


