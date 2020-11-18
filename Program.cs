using System;

namespace Avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {
             //Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

            Console.Write("Avalie nosso atendimento com uma nota de 0 à 10: ");
            int nota = int.Parse(Console.ReadLine());
            // int nota = 0;
            while(nota > 10){
                Console.WriteLine("Por favor, insira uma nota válida!");
                Console.WriteLine("  ");
                Console.Write("Avalie nosso atendimento com uma nota de 0 à 10: ");
                nota = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("Obrigado pela avaliação!");
        }
    }
}
