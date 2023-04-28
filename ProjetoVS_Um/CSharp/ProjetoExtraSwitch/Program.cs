using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Extra - Switch");

        int mes = 8;

        switch (mes)
        {
            case 1:
                Console.WriteLine("O mês 1 é o mês de janeiro");
                break;
            case 2:
                Console.WriteLine("O mês 2 é o mês de fevereiro");
                break;
            case 3:
                Console.WriteLine("O mês 3 é o mês de março");
                break;
            case 4:
                Console.WriteLine("O mês 4 é o mês de abril");
                break;
            case 5:
                Console.WriteLine("O mês 5 é o mês de maio");
                break;
            case 6:
                Console.WriteLine("O mês 6 é o mês de junho");
                break;
            case 7:
                Console.WriteLine("O mês 7 é o mês de julho");
                break;
            case 8:
                Console.WriteLine("O mês 8 é o mês de agosto");
                break;
            case 9:
                Console.WriteLine("O mês 9 é o mês de setembro");
                break;
            case 10:
                Console.WriteLine("O mês 10 é o mês de outubro");
                break;
            case 11:
                Console.WriteLine("O mês 11 é o mês de novembro");
                break;
            case 12:
                Console.WriteLine("O mês 12 é o mês de dezembro");
                break;
            default: 
                Console.WriteLine("Opção inválida - só há 12 meses em um ano");
                break;
        }

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}