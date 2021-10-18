using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Caesar c = new Caesar();

            c.PlainText = "Hello";
            c.Encrypt();
            Console.WriteLine($"{c.CipherText}");


            MonoalphabeticSubsitution masc = new MonoalphabeticSubsitution();
                
        }
    }
}
