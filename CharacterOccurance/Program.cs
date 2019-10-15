using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterOccurance
{
    class Program
    {

        static string CountCharacterOccurance(string input, char charToFind)
        {
            string result = string.Empty;
            int count = 0;
            foreach (char ch in input)
            {
                if (ch == charToFind)
                {
                    count++;
                }
            }
            result = $"{charToFind} is {count}";
            return result;
        }
        static string CountCharacterOccurance(string input)
        {
            string result = string.Empty;
            char charToFind;
            string[] strArray = new string[input.Length];
            int count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                charToFind = input[i];
                for (int j = 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        count++;
                    }
                }
                strArray[i] = $"{charToFind}{count}";
                count = 1;
            }
            Array.Sort(strArray);
            result = string.Join(string.Empty, strArray);
            return result;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input string");
                var input = Console.ReadLine();
                // Console.WriteLine("Input character to find");
                //var charToFind = Console.ReadKey().KeyChar;
                //var result = CountCharacterOccurance(input, charToFind);
                var result1 = CountCharacterOccurance(input);
                //Console.WriteLine(result);
                Console.WriteLine(result1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
