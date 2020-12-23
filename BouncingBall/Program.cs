using System;

namespace BouncingBall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BouncingBall(3, 0.66, 1.5)); 
            Console.WriteLine((BouncingBall(30.0, 0.66, 1.5)));
        }
        
        public static int BouncingBall(double h, double bounce, double window) 
        {
            if (bounce >= 1 || bounce <= 0 || (window >= h))
                return -1;

            var occurrence = 1;
            
            while (h > window)
            {
                h *= bounce;
                if (h > window)
                {
                    occurrence+=2;
                }
            }
            
            return occurrence;
        }
    }
}