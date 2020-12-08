using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 0;
            Console.WriteLine("Please enter a whole number to begin");
            var strInput =   Console.ReadLine();
            if(int.TryParse(strInput,out maxNumber))
            {
                ClassLibrary1.Class1 program = new ClassLibrary1.Class1(maxNumber);
                dynamic result = JsonConvert.DeserializeObject(program.RTNINfo());
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("You must input a whole number.");
            }
            Console.ReadLine();

        }
    }
}
