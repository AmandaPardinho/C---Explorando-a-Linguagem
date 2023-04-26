using System;
class Program
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);

        /*Casting => converte uma variável de ponto flutuante para uma variável do tipo inteiro;
          Desconsidera tudo que estiver depois da vírgula;
          Colocar o (int) antes do nome da variável indica para o computador que a intenção ao declarar aquilo era algo pensado e não um erro de digitação;
         */
        int salarioInteiro;
        salarioInteiro = (int) salario;
        Console.WriteLine(salarioInteiro);

        /*Variáveis menos comuns*/
        long x;
        x = 2000000000000000000;
        Console.WriteLine(x);

        short y;
        y = 16000;
        Console.WriteLine(y);

        float altura;
        altura = 1.68f;
        Console.WriteLine(altura);

        /*Outro jeito de declarar uma variável*/
        float z = 1.68f; //deixa o código mais limpo
        Console.WriteLine(z);


        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }
}
