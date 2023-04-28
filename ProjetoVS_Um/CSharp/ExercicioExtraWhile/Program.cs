using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício Extra - While");

        //Escreva um contador que imprima os números de 0 a 10

        int contador = 0;

        while(contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}
