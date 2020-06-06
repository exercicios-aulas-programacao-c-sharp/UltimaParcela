using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroParcelas;
            decimal valorTotal;
            decimal valorParcela;
            DateTime dataUltimaParcela;

            Console.Write("Valor total do financiamento................: ");
            valorTotal = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Quantidade de parcelas mansais (sem juros)..: ");
            numeroParcelas = Convert.ToInt32(Console.ReadLine());

            valorParcela = valorTotal / numeroParcelas;
            dataUltimaParcela = DateTime.Now.AddMonths(numeroParcelas);
            
            Console.WriteLine($"Sua última parcela será em {dataUltimaParcela.ToShortDateString()}, no valor de {valorParcela:C2}.");

        }
    }
}
