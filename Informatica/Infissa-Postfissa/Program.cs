using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infissa_Postfissa
{
    class Program
    {
        static void Main(string[] args)
        {
            string prova = "(3+2)*4";
            string prova2 = "(2+1)*(3-2)";
            string prova3 = "1*(7-4)";

            Console.WriteLine(CreaPostfissa(prova)); 
            Console.WriteLine(CreaPostfissa(prova2));
            Console.WriteLine(CreaPostfissa(prova3));

            Console.ReadKey();
        }

        static string CreaPostfissa(string infissa)
        {
            string solution = "";
            StringBuilder ss = new StringBuilder();
            List<char> caratteri = new List<char>();
            foreach (var carattere in infissa)
                caratteri.Add(carattere);
            
            for (int i = 0; i < caratteri.Count; i++)
            {
                if (caratteri[i] == '(' && caratteri[i + 1] != '(')
                {
                    ss = new StringBuilder();
                    ss.Append(caratteri[i + 1]);
                    ss.Append(caratteri[i + 3]);
                    ss.Append(caratteri[i + 2]);
                    solution += ss;

                    for (int j = 0; j < 5; j++)
                        caratteri.RemoveAt(i);

                    i = 0;
                }
            }

            if (caratteri.Count > 1)
            {
                if (caratteri[0] == '+' || caratteri[0] == '-' || caratteri[0] == '*' || caratteri[0] == '/')
                {
                    ss = new StringBuilder();
                    ss.Append(solution);
                    ss.Append(caratteri[1]);
                    ss.Append(caratteri[0]);
                    solution = "";
                    solution += ss;
                }
                else
                {
                    ss = new StringBuilder();
                    ss.Append(caratteri[0]);
                    ss.Append(solution);
                    ss.Append(caratteri[1]);
                    solution = "";
                    solution += ss;
                }
            }
            else
            {
                ss = new StringBuilder();
                ss.Append(solution);
                ss.Append(caratteri[0]);
                solution = "";
                solution += ss;
            }
            return solution;
        }
    }
}