using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p6
{
    class Program
    {
        private static bool isOperator(char ch)
        {
            if (ch == '+' || ch == '*' || ch == '-' || ch == '/' || ch == '^' || ch == '(')
                return true;
            return false;
        }
        private static int precedence(char ch)
        {
            if (ch == '^') return 5;
            if (ch == '/' || ch == '*') return 4;
            if (ch == '+' || ch == '-') return 3;
            if (ch == '(') return -1;
            return -2;
        }
        private static bool isAlphaNum(char ch)
        {
            if ((ch >= '0' && ch <= '9') || (ch >= 'A' && ch <= 'Z') ||
            (ch >= 'a' && ch <= 'z'))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the infix notation: ");
            string infix = Console.ReadLine();
            Stack<char> st = new Stack<char>();
            string ans = "";
            for (int i = 0; i < infix.Length; i++)
            {
                if (isAlphaNum(infix[i]))
                    ans += infix[i];
                else if (infix[i] == '(')
                    st.Push(infix[i]);
                else if (isOperator(infix[i]))
                {
                    if (st.Count == 0 || precedence(infix[i]) > precedence(st.Peek()))
                        st.Push(infix[i]);
                    else
                    {
                        while (st.Count != 0 && precedence(st.Peek()) >
                        precedence(infix[i]))
                        {
                            ans += st.Pop();
                        }
                        st.Push(infix[i]);
                    }
                }
                else if (infix[i] == ')')
                {
                    while (st.Count != 0 && st.Peek() != '(')
                    {
                        ans += st.Pop();
                    }
                    st.Pop();
                }
            }
            while (st.Count != 0)
            {
                ans += st.Pop();
            }
            Console.WriteLine("Infix: " + infix);
            Console.WriteLine("Postfix: " + ans);
            Console.ReadLine();
        }
    }
}
