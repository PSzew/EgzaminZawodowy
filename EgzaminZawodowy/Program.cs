﻿using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            bool Get()
            {
               /*
                    ************************************************************************************************************************
                    nazwa funkcji: Get()
                    opis funkcji: Funckja pobiera oraz sprawdza dane wejsciowe
                    parametry: brak
                
                    zwracany typ i opis: Zwraca bool, true jeśli dane wejsciowe są prawidłowe , false jeśli dane wejsciowe są niepoprawne.
                    autor: Paweł Szewczyk
                    ************************************************************************************************************************
                */
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
                /*
                    ************************************************************************************************************************
                    nazwa funkcji: NWD()
                    opis funkcji: Funckja wyszukuje Najwiekszy wspólny dzielnik dla a i b
                    parametry: a - jedna z liczb dla których zostanie wyszukane NWD
                    	   b - jedna z liczb dla których zostanie wyszukane NWD
                    
                    zwracany typ i opis: Zwraca int,Największy wspólny dzielnik dla liczb a i b
                    autor: Paweł Szewczyk
                    ************************************************************************************************************************
                */
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
