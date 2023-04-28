using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio 2 - Múltiplos de 3");

        //Imprimir todos os múltiplos de 3 entre 0 e 100

        for(int numero = 1; numero <= 100; numero++)
        {
            if ((numero % 3) == 0)
                Console.WriteLine(numero);
        }

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}
