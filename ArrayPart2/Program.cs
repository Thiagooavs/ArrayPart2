using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ArrayPart2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
            Console.Write("Informe quantos números irá digitar: ");

            int max = int.Parse(Console.ReadLine());
            int[] n = new int[max];

            int min ;
            int maxi;
            

            Console.Write("Digite o 1° número: ");
                n[0] = int.Parse(Console.ReadLine());
              
                    min = n[0];
                    maxi = n[0];
                

            Console.Clear();
           
            for (int i = 1; i < max; i++) 
            {


                Console.Write("Digite o " + (i+1) + "° número: ");
                n[i] = int.Parse(Console.ReadLine());

                if (n[i] < min)
                {
                    min = n[i];
                }
                else if (n[i] > maxi)
                {
                    maxi = n[i];
                }
                Console.Clear();

            }
            Console.Write("Os números foram:");

            for (int j = 0; j < max; j++)
            {
                Console.Write(" " + n[j]);    
            }

            Console.WriteLine(" ");
            Console.WriteLine("o menor valor foi: " + min);
            Console.WriteLine("o maior valor foi: " + maxi);
            Console.ReadKey();
        }
    }
}
