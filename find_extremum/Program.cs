using System;

namespace find_extremum
{
    // bisection method

    class Program
    {
        public static double derivative_f(double x)
        {
            double result;
            result = 12*(1 - Math.Pow(x, 3) - Math.Pow(x, 5));
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("for f(x) = 12x - 3x^4 - 2x^6 function");
            Console.Write("please enter the first element of the control range: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("please enter the second element of the control range: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a < b)
            {
                double epsilon = 0.00001;
                int count = 1;
                double x;
                do
                {
                    x = (a + b) / 2;

                    Console.WriteLine("\niteration " + count + "\na[" + count + "]=" + a + "\nb[" + count + "]=" + b + "\nx[" + count + "]=" + x);

                    double control = derivative_f(x);
                    if (control < 0)
                    {
                        b = x;
                        count++;
                    }
                    else if (control > 0)
                    {
                        a = x;
                        count++;
                    }
                    else //control = 0 we have found the extremum point
                    {
                        break;
                    }
                }
                while (epsilon < b - a);
                if(epsilon > b - a)
                {
                    x = (a + b) / 2;
                    Console.WriteLine("\niteration " + count + "\nwe can't find the exact x so we assume that x[" + count + "]=" + x);
                }
            }
            else
            {
                Console.WriteLine("You entered an invalid range!");
            }
            Console.ReadKey();
        }
    }
}
