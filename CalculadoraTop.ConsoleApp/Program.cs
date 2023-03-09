using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            List<string> historico = new List<string>();// lista pq aí não precisa especificar o tamanho do vetore

            do {

                Console.Clear();

                Console.WriteLine("Calculadora Top 2023");

                Console.WriteLine("Digite 1 para realizar uma operação de soma. ");

                Console.WriteLine("Digite 2 para realizar uma operação de sibitração. ");

                Console.WriteLine("Digite 3 para realizar uma operação de multiplicação. ");

                Console.WriteLine("Digite 4 para realizar uma operação de divisão. ");

                Console.WriteLine("Digite S para sair. ");

                Console.WriteLine("Digite V para visualizar o histórico de operações. ");

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "S" && operacao != "s" && operacao != "V" && operacao != "v")
                {
                    Console.WriteLine("Operação inválida, tente novamente. ");

                    Console.ReadLine();

                    continue; //p voltar p inicio do laço
                }

                if (operacao == "1" || operacao == "2" || operacao == "3" || operacao == "4" )
                {
                    string resultadoString = "";

                    decimal resultado = 0;

                    Console.WriteLine("Digite o porimeiro número: ");

                    decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número: ");

                    decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                    if (operacao == "1")
                    {
                        resultado = primeiroNumero + segundoNumero;

                        resultadoString = primeiroNumero.ToString() + " + " + segundoNumero.ToString() + " = " + resultado.ToString();

                        historico.Add(resultadoString);
                    }
                    else if (operacao == "2")
                    {
                        resultado = primeiroNumero - segundoNumero;

                        resultadoString = primeiroNumero.ToString() + " - " + segundoNumero.ToString() + " = " + resultado.ToString();

                        historico.Add(resultadoString);
                    }
                    else if (operacao == "3")
                    {
                        resultado = primeiroNumero * segundoNumero;

                        resultadoString = primeiroNumero.ToString() + " * " + segundoNumero.ToString() + " = " + resultado.ToString();

                        historico.Add(resultadoString);
                    }
                    else if (operacao == "4")
                    {
                        while (segundoNumero == 0)
                        {
                            Console.WriteLine("O segundo número não pode ser zero, digite outro valor...");

                            Console.WriteLine("Digite o segundo número: ");

                            segundoNumero = Convert.ToDecimal(Console.ReadLine());
                        }

                        resultado = primeiroNumero / segundoNumero;

                        resultadoString = primeiroNumero.ToString() + " : " + segundoNumero.ToString() + " = " + resultado.ToString();

                        historico.Add(resultadoString);

                    }

                    decimal resultadoFormatado = Math.Round(resultado, 2); 

                    Console.WriteLine("O resultado da operação é:" + resultadoFormatado);

                    Console.ReadLine();

                }
                else
                {                   
                    foreach (string print in historico) // pq é lista, se fosse vetor podia ser for 
                    {
                        Console.WriteLine(print);
                    }

                    Console.ReadLine();

                }

            } while (true);

        } 
    }
}