using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_VariablesAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Variable : a name given to a storage location in memory. it can be change Exmp int age = 34
             * Constant : an immutable value. it doesnt change. We use for safety for our applications. Exmp float pi = 3.14f
             * 
             */

            // Declaring a Variables/Constants

            int number;
            int Number = 1;  // C# is case sensitive language. First variable (number) and second variable (Number) is DİFFERENT variables.
                             // you can assign value to variable while creating that, or you can assign value after creating
            var age = 34;    // This point ; if you choose use VAR keyword to creating variable, you MUST assign a VALUE while creating.

            //var name;      This cause error. it says : variables must be itinialized


            const float Pi = 3.14f;   // as same variables we can not use constant without setting a value. We  must initialized


            // İdentifiers

            // * Cannot start with a number :
            // 1number ===> wrong!  
            // oneNumber ===> right decleration!
            // first name ===> identifiers can not include white space
            // firstName ===> right! İt has to be one word.

            // * Connot be a reserved keyword :
            // int ===> you can not use as a variable name
            // @int ====> if somehow your code include a reserved keyword. You must add '@' symbol at first!


            // As a recommendation :
            // Use meaningfull variable names 
            // fn = "tony"; ===> not much meaningfull
            // firstName = "tony"; ===> this is better


            // * Naming Convention
            // Camel Case : firstName
            // Pascal Case: FirstName
            // Hungarian Notation : strFirstName  in C#, developer dont like to see this notation. Use first and second ones


            // * For Local Variables : Camel Case ;
            int numberOfChild = 4;

            // * For Constants : Pascal Case;

            const int MaxSpeed = 120;


            // * Real Numbers
            // real numbers are 3: 
            // float, decimal, and double
            // in C# default real number is double.
            // if ve use float or decimal we should use suffix
            // Float :
            float height = 4.5f;

            // Decimal : 
            decimal cost = 2.4m;

            // * Non-Primitive Types:
            // String
            Console.WriteLine();



































        }
    }
}
