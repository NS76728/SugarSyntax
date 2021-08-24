using System;

namespace SugarSyntaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;    //changed int to var

            // changed the if statment to a Ternary Operator


            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} greater than or equal to nine"; 

            // added interpolation to response 

            Console.WriteLine(response);
        }
    }
}
