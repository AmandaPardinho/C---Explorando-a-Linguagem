using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Encadeando For");
        /* Criando o seguinte desenho:
         *   *
         *   * *
         *   * * * 
         *   * * * *
         *   * * * * *      
         */

        for (int contadorDeLinhas = 0; contadorDeLinhas < 10; contadorDeLinhas++)
        {
            for(int contadorDeColunas = 0; contadorDeColunas < 10; contadorDeColunas++)
            {
                Console.Write("* ");
                if (contadorDeColunas >= contadorDeLinhas)
                {
                    break;
                }
            }
            Console.WriteLine();
        }

        //Outra solução =>
        Console.WriteLine();

        for(int contadorDeLinhas = 0; contadorDeLinhas < 10; contadorDeLinhas++)
        {
            for(int contadorDeColunas = 0; contadorDeColunas <= contadorDeLinhas; contadorDeColunas++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}