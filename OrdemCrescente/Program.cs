using System;

namespace OrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;


            Console.WriteLine("Ordenando valores:");
            Console.WriteLine("Digite o primeiro número: ");
             num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
             num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
             num3 = Int32.Parse(Console.ReadLine());

            int guarda = 0;

            if (num1 > num2)
            {
                guarda = num1;
                num1 = num2;
                num2 = guarda;


            }
            if (num1 > num3)
            {
                guarda = num1;
                num1 = num3;
                num3 = guarda;



            }
            if (num2 > num3)
            {
                guarda = num2;
                num2 = num3;
                num3 = guarda;

            }

            else
            {
                Console.WriteLine(" A ordem crescente é :" + num1 + " , " + num2 + " , " + num3);
            }
                
            
            
            
            
            
            Console.ReadKey();

            

            




            

            


           
            

        }
    }
}
