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
            double z = 0;
            while(z<1E10)
            {
                double pi = 0;
                for(int i=0; i<1E6; i++)
                {
                    Random rnd = new Random();
                    int x = rnd.Next(-r, r);
                    int y = rnd.Next(-r, r);
                    double d = x*x + y*y;
                    if(d < r*r)
                    {
                        circle++;
                    }
                    total++;
                    pi = 4 * (circle/total);
                }
                Console.WriteLine(pi);
                z++;
            }
        }
    }
}
