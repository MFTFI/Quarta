using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EspressionePile
{
    internal class Program
    {
        static char[] parentesiPermesse = new[] {'(', ')'};
        static char[] operatoriPermessi = new[] {'+', '-', '*', '/'};
            
        static string operazione = "(3*(2+5))";
        
        public static void Main(string[] args)
        {
            Stack<char> espressione = new Stack<char>();
            
            foreach (char lettera in operazione)
                espressione.Push(lettera);

            Console.WriteLine(CalcolaOperazione(new Stack<char>(espressione)));

            Console.ReadKey();
        }

        public static int CalcolaOperazione(Stack<char> espressione)
        {
            bool trovato = false;
            Stack<char> operatori = new Stack<char>();
            Stack<int> valori = new Stack<int>();
            char parentesiChiusa = espressione.Pop();

            while (parentesiChiusa != ')' || espressione.Count == 0)
            {
                parentesiChiusa = espressione.Pop();
                trovato = false;
                foreach (char operatore in operatoriPermessi)
                {
                    if (operatore == parentesiChiusa)
                    {
                        operatori.Push(operatore);
                        trovato = true;
                        break;
                    }
                }
                foreach (char operatore in parentesiPermesse)
                {
                    if (operatore == parentesiChiusa)
                    {
                        //operatori.Push(operatore);
                        trovato = true;
                        break;
                    }
                }
                if (!trovato)
                {
                    string valore = "";
                    valore += parentesiChiusa;
                    valori.Push(int.Parse(valore));
                }
            } 
            espressione.Push(parentesiChiusa);

            while (operatori.Count != 0)
            {
                switch (operatori.Pop())
                {
                    case '+':
                    {
                        valori.Push(valori.Pop() + valori.Pop());
                        break;
                    }
                    case '-':
                    {
                        valori.Push(valori.Pop() - valori.Pop());
                        break;
                    }
                    case '*':
                    {
                        valori.Push(valori.Pop() * valori.Pop());
                        break;
                    }
                    case '/':
                    {
                        valori.Push(valori.Pop() / valori.Pop());
                        break;
                    }
                }
            }
            return valori.Pop();
        }
    }
}