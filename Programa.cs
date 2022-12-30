using System;
using System.Globalization;

namespace SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo:");
            
            string nome = Console.ReadLine();
            
            Console.WriteLine("Quantos quartos tem em sua casa?");
            
            int quartos = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Entre com o preço de um produto:");
            
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura (na mesma linha) ");

            string[] vet = Console.ReadLine().Split(' ');

            string ultimoNome = vet[0];

            int idade = int.Parse(vet[1]);

            double altura = double.Parse(vet[2]);


            Console.WriteLine("Dados:");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
