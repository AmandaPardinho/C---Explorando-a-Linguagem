using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio 3 - Fatorial");

        //Agora crie uma nova classe, escreva um for que inicie uma variável n (número atual) como 1 e fatorial (resultado total) como 1. Faça seu laço entre 1 a 10 e calcule o resultado!

        double n = 10;
        double fatorial = 1;

        for(int i = 1; i <= n; i++)
        {
            fatorial *= i;
            Console.WriteLine(fatorial);
        }
        

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}

