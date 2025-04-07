using System;

class Program
{
    static void Main()
    {
        double capital = 1200.00;
        double taxaJuros = 2.0 / 100; 
        int tempo = 15;

        double juros = capital * taxaJuros * tempo;

        double montante = capital + juros;

        Console.WriteLine("Juros simples (j)");
        Console.WriteLine("Capital [c] (R$).......: " + capital.ToString("F2"));
        Console.WriteLine("Taxa de juros [i] (%)..: " + (taxaJuros * 100).ToString("F2"));
        Console.WriteLine("Tempo [t] (meses)......: " + tempo);
        Console.WriteLine("Juros (R$).....: " + juros.ToString("F2"));
        Console.WriteLine("Montante (R$)..: " + montante.ToString("F2"));
    }
}