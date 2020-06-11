using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Exemplo com Boxing:
            int x = 20;
            object obj = x;
            Console.WriteLine($"Note que a variável obj vale: {obj}");
            Console.WriteLine();

            string str = "Adriano de Assis Lima";
            object obj1 = str;
            Console.WriteLine($"Note que a variável obj1 vale: {obj1}");
            Console.WriteLine();

            // Exemplo com Inboxing:
            // Converter um tipo referencia para valor compativel tem q usar Casting:

            int y = (int)obj; // Aplicacao do Casting
            

            Console.WriteLine($"Conversão de um objeto tipo referência para um objeto tipo valor: {y}");
    
        }
    }
}
