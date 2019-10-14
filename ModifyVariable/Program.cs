using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyVariable
{
    class Program
    {
        /// <summary>
        /// Rename input variable name from c++ to java and vice-versa
        /// </summary>
        /// <param name="inputVariable"></param>
        /// <returns></returns>
        static string ModifyVariable(string inputVariable)
        {
            if (string.IsNullOrEmpty(inputVariable))
            {
                throw new Exception($"string can't be empty or null input name is: {nameof(inputVariable)}");
            }
            string result = string.Empty;
            if (inputVariable.Contains("_"))
            {
                var strArray = inputVariable.Split(new char[] { '_' });
                int indexToSkip = 1;
                var r = (from str in strArray.Skip(indexToSkip) select str.First().ToString().ToUpper() + str.Substring(1));
                result = $"{strArray[0]}{string.Concat(r.ToArray())}";
            }
            else
            {
                var str = new StringBuilder();
                foreach (var ch in inputVariable)
                {
                    // if (ch >= 'A' && ch <= 'Z')

                    if (char.IsUpper(ch) && str.Length > 0)
                    {
                        str.Append('_');
                        str.Append((char)(ch + 32));
                    }
                    else
                    {
                        str.Append(ch);
                    }
                }
                result = str.ToString();

                //Linq Method
                // result = string.Concat(variable.Select(x=> char.IsUpper(x) ? "_" + (char)(x + 32) : x.ToString())).TrimStart('_');
            }
            return result;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string");
                var input = Console.ReadLine();
                var result = ModifyVariable(input);
                Console.WriteLine(result);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }

        }
    }
}
