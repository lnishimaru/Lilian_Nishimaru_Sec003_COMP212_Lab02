using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilian_Nishimaru_Exercise02
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //string builder declaration
            StringBuilder sb = new StringBuilder("This is to test whether the extension method count can return a right answer or not");

            //using the extension method
            int result = sb.CountWords();

            //showing the result
            Console.WriteLine($"There are {result} words.");

        }   
    }
    public static class StringBuilderExtensions
    {
        public static int CountWords(this StringBuilder teste)
        {
            int qt = teste.ToString().Split(' ').Length;
            return qt;
        }
    }
}
