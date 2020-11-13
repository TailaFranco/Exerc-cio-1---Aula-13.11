using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que recebe a idade da pessoa em anos e imprime o valor em: Meses, dias, horas e minutos.

            //Declaração de variavéis
            float meses;
            float dias;
            float horas;
            float minutos;

            Console.WriteLine("Digite sua idade atual em anos.");
            int idade = int.Parse(Console.ReadLine());

            meses = idade * 12;
            dias = idade * 365;
            horas = dias * 24;
            minutos = horas * 60;


           Console.WriteLine("A sua idade em meses é: "+meses+"");
           Console.WriteLine("A sua idade em dias é: "+dias+"");
           Console.WriteLine("A sua idade em horas é: "+horas+"");
           Console.WriteLine("A sua idade em minutos é: "+minutos+"");


        }
    }
}
