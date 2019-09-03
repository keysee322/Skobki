using System;
using System.Collections.Generic;

namespace Skobki
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string s = Console.ReadLine();
            var chars = s.ToCharArray();
            for (int i = 0; i< s.Length; i++)
            {
                if (chars[i] == '[' || chars[i] == '{' || chars[i] == '(')
                    stack.Push(chars[i]);
                else if (chars[i] == ']' && stack.Peek() == '[')
                    stack.Pop();
                else if (chars[i] == '}' && stack.Peek() == '{')
                    stack.Pop();
                else if (chars[i] == ')' && stack.Peek() == '(')
                    stack.Pop();
                else
                    break;
            }
            if (stack.Count == 0)
                Console.WriteLine("Последовательность правильная");
            else Console.WriteLine("Последовательность неправильная");
        }
    }
}
