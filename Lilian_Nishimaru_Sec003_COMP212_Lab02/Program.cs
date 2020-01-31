using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilian_Nishimaru_Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            // test values
            int[] int_array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int var1 = 2;
            string[] string_array = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            string var2 = "g";

            //testing with an int array
            Display(int_array);
            Console.WriteLine($" Search Value: {var1}, Occurrence: {Search(int_array, var1)}");

            //testing with a string array
            Display(string_array);
            Console.WriteLine($" Search Value: {var2}, Occurrence: {Search(string_array, var2)}");
            
            //search for a value that do not exist
            var2 = "x";
            Display(string_array);
            Console.WriteLine($" Search Value: {var2}, Occurrence: {Search(string_array, var2)}");
        }
        public static int Search<T>(T[] dataArray, T searchKey) where T : IComparable<T>
        {
            int x = -1;
            int result = -1;
            // search the occurences of the data array and compares to the search value
            foreach (T i in dataArray)
            {
                x++;
                if (i.CompareTo(searchKey) == 0)
                {
                    result = x;
                    break;
                }
            }
            return result;
        }
        //display the array values for checking
        public static void Display<T>(T[] dataArray)
        {
            Console.WriteLine($"---- Array ----");
            foreach (T i in dataArray)
            {
                Console.Write($"{i}, ");
            }
        }
    }
}
