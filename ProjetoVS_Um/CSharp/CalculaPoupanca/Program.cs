using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;

        //Rendimento de 0.5% (= 0.005) ao mês
        /*investimento = investimento + investimento * 0.005;
        Console.WriteLine(investimento);*/

        //Calculando o rendimento em 12 meses
        int mes = 1;
        while(mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você terá R$" + investimento);

            mes++;
        }





        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}
