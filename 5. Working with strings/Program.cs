using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will \n wrap to next line");
            Console.WriteLine("This will \n print out the quotation mark");

            string firstName = "Khangwie";
            string LastName = "Rasalanavho";
            //concationation
            Console.WriteLine(firstName + " " + LastName);

            //funtions with strings
            Console.WriteLine(LastName.Length);
            //methods on strings
            Console.WriteLine(firstName.ToUpper());
            //method with a parameter eg the contains(), its case stritive
            Console.WriteLine(LastName.Contains("Ra"));
            //access characters using index
            Console.WriteLine(firstName[0]);
            //indexOf will tell u iff the value is there and at what position
            Console.Write("index of a is");
            Console.WriteLine(LastName.IndexOf('0'));//can use double quotes two
            //sbstring, to grab from an index onwards
            Console.WriteLine(firstName.Substring(1));
            //you can also give index and length ie how many chars u wanna grab
            Console.WriteLine(firstName.Substring(1,2));
            Console.Read();
        }
    }
}
