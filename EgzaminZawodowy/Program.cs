using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            bool Get()
            {
                Console.Write("Podaj a: ");
                if(!Int32.TryParse(Console.ReadLine(),out a))
                {
                    return false;
                }
                Console.Clear();
                Console.Write("Podaj b: ");
                if (!Int32.TryParse(Console.ReadLine(), out b))
                {
                    return false;
                }
                return true;
            }
            int NWD(int A , int B)
            {
                while(A != B)
                {
                    if (A > B)
                        A -= B;
                    else
                        B -= A;                   
                }
                return A;
            }
            if(Get())
            {
                Console.WriteLine("NWD: "+NWD(a,b)); 
            }
            else
                Console.WriteLine("Podano nie prawidłowe dane!");
            
            
        }
    }
}