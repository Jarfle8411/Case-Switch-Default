using System;

using System.Diagnostics;

using System.Collections.Generic;

using System.Linq;

using System.Text;



namespace ReturnAValueMethod
{

    class Program
    {

        static void Main(string[] args)
        {

            string[] explanation = {"\n\n*****************************", 

                                    "This program will perform a simple", 

                                    "mathematical calculation (+,-,*, /).", 

                                    "You will be asked to povide two numbers.", 

                                    "The number will be set to a funtion to process", 

                                    "the calculation.  The outcome of the result will", 

                                    "be displayed for you viewing.", 

                                    "helpful link (return value):   http://www.dotnetperls.com/return", 

                                    "Helpful line (switch case ):   http://www.dotnetperls.com/case", 

                                    "*****************************\n\n" 

                                   };

            foreach (string val in explanation)
            {

                Console.WriteLine(val);

            }





            string KeepGoing;

            do
            {

                Console.WriteLine("Continue this operation (enter n to exit) ? : ");

                KeepGoing = Console.ReadLine();



                Console.Write("Enter a numbers : ");

                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter a second number : ");

                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter which math operation to perform : ");

                string mathOp = Console.ReadLine();





                double calculation = performMath(num1, num2, mathOp);

                Console.WriteLine("{0} {1} {2} = {3}", num1, mathOp, num2, calculation);

            } while (KeepGoing != "n");

        }



        static double performMath(double n1, double n2, string op)
        {

            string math = op;

            switch (math)
            {

                case ("+"):
                    { // Addition operation 

                        double add = n1 + n2;

                        return add;



                    }





                case "-":



                    // substration operation 

                    double sub = n1 - n2;

                    return sub;









                case "*":



                    // multiplicaion operation 

                    double mul = n1 * n2;

                    return mul;







                case "/":



                    // division 

                    double div = n1 / n2;

                    return div;







                default:



                    double answer = 0000000.00;

                    string error = "error";

                    Console.WriteLine("Can not perfor the operation");

                    Console.WriteLine("You entered the following information");

                    Console.WriteLine("{0} {1} {2} = {3}", n1, math, n2, error);

                    return answer;









            }









        }

    }

}



