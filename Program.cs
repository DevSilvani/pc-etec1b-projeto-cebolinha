using System;

namespace pc_etec1b_projeto_cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "";
            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine();
            Console.Clear();
            frase = frase.Replace('r', 'l');
            frase = frase.Replace('R', 'L');
            Console.WriteLine("Como o cebolinha diria: "+frase);
            Console.ReadKey();
        }
    }
}
