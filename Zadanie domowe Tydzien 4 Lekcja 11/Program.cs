using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_domowe_Tydzien_4_Lekcja_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                try
                {
                
                    Console.WriteLine("Wprowadz jakas liczbe calkowita:");
                    var number = int.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Wprowadziles liczbe parzysta");
                    }
                   
                    else
                    {
                        Console.WriteLine("Wprowadziles liczbe nieparzysta");
                    }
                
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message); ;
                }
                finally
                { 
                    Console.ReadLine(); 
                }
               
            
            
        }
    }
}
