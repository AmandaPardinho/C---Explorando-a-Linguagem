using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        int coluna = 0;

        for(int linha = 0; linha < 5; linha++)
        {
            for (coluna = 0; coluna < 5; coluna++)
            {
                if (coluna > linha)

                    break;

                Console.Write(coluna + 1);
            }
            Console.WriteLine();
        }
        

        Console.WriteLine("Tecle enter para sair");
        Console.ReadLine();
    }
}
