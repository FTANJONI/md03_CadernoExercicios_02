using System;

namespace md03_CadernoExercicios_02
{
    class Program
    /*
     2. Uma empresa irá dar um aumento de salário aos seus funcionários de acordo
        com a categoria de cada empregado. O aumento seguirá a seguinte regra:
        • Funcionários das categorias A, C, F, e H ganharão 10% de aumento sobre o
        salário;
        • Funcionários das categorias B, D, e T ganharão 15% de aumento sobre o
        salário;
        • Funcionários das categorias K e R ganharão 25% de aumento sobre o salário;
     */
    {
        static void Main(string[] args)
        {
            double categoria, salarioAtual = 0, salarioReajustado;

            Console.WriteLine("informe qual categoria o funcionário está enquadrado:");
            Console.WriteLine("\nCategoria 1 = (A, C, F e H)");
            Console.WriteLine("Categoria 2 = (AB,D e T)");
            Console.WriteLine("Categoria 3 = (K e R)");
            categoria = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o salário atual do funcionário:");
            salarioAtual = Convert.ToDouble(Console.ReadLine());
            if (categoria == 1)
            {
                salarioReajustado = salarioAtual * 1.10;
            } else if (categoria == 2)
            {
                salarioReajustado = salarioAtual * 1.15;
            }
            else
            {
                salarioReajustado = salarioAtual * 1.25;
            }
            Console.WriteLine("De acordo com a categoria selecionada, o " +
                "reajuste salarial passará a ser: R$ {0}", salarioReajustado.ToString("0.00"));

        }
    }
}
