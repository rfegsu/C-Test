using System;

namespace EstimatePi
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 200;
            double total = 0;
            double circle = 0;
            Random rnd = new Random();
            double d;
            int x;
            int y;
            double pi = 0;
            double recDiff=0;
            double diff = 0;
            double recPi = 0;

            int user_input;
            Console.WriteLine("How many times would you like to loop?");
            user_input = Convert.ToInt32(Console.ReadLine());
            for(int z=0; z<user_input; z++)
            {
                for(int i=0; i<10000; i++)
                {
                    x = rnd.Next(-r, r);
                    y = rnd.Next(-r, r);
                    d = x*x + y*y;
                    if(d < r*r)
                    {
                        circle++;
                    }
                    total++;
                    pi = 4 * (circle/total);
                    recDiff = Math.Abs(Math.PI - recPi);
                    diff = Math.Abs(Math.PI - pi);

                    if(diff < recDiff)
                    {
                        recDiff = diff;
                        recPi = pi;
                        Console.WriteLine("New record: {0}", recPi);
                    }
                }
            }
            Console.WriteLine("Actual value of PI: {0}", Math.PI);
        }
    }
}
