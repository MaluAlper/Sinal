using System;

namespace Sinal
{
    class Program
    {
     
     // Leia um número inteiro e exiba "Negativo", "Zero" ou "Positivo", conforme o caso.
        static void Main(string[] args)
        {
            string n1;
            int numeropositivo;
           


            Console.WriteLine("Digite um numero");
            n1=Console.ReadLine();
            numeropositivo = Int32.Parse(n1);
            if (numeropositivo==0){
            Console.WriteLine ("Digite outro valor alem do zero para prosseguir");
            }
            else
            {
                 if (numeropositivo>0)
            {
            Console.WriteLine ("positivo");
            } 
            else 
            {
            Console.WriteLine ("negativo");
            }
          }
        }
    }
}

