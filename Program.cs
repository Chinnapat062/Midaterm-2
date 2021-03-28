using System;

namespace ข้อ_2_กลางภาค
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int x=a,y=a;
            Console.Write("input num a,b :")
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            while (x != y)
            {
                if(x<y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }    
            }
            Console.WriteLine(x);
        }   
    }
}
