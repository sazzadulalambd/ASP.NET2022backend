using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Class1
    {
         static void main(string[] args)
        {
            Console.WriteLine(PassSecurity.EnryptString("RifatHossain"));

            Console.WriteLine(PassSecurity.DecryptString(PassSecurity.EnryptString("RifatHossain")));

            Console.ReadLine();
        }
    }
}
