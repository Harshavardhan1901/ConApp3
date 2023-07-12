using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var myNum = 12;
            //var myString = "Sam";
            //var status = true;
            //var grade = 'A';
            //Console.WriteLine("Value Stores in myNum is: " + myNum + "\n Data Type : " + myNum.GetType());
            //Console.WriteLine("Value Stores in myString is: " + myString + "\n Data Type : " + myString.GetType());
            //Console.WriteLine("Value Stores in status is: " + status + "\n Data Type : " + status.GetType());
            //Console.WriteLine("Value Stores in grade is: " + grade + "\n Data Type : " + grade.GetType());
            //Console.ReadKey();

            var myNum = 12;

            dynamic myDynamic = 45;
            Console.WriteLine("Value Stored in myDynamic is: " + myDynamic + "\n DataType Stored is:\t " + myDynamic.GetType());
            myDynamic = "I am Sam";
            Console.WriteLine("Value Stored in myDynamic is: " + myDynamic + "\n DataType Stored is:\t " + myDynamic.GetType());
            myDynamic = 'A';
            Console.WriteLine("Value Stored in myDynamic is: " + myDynamic + "\n DataType Stored is:\t " + myDynamic.GetType());
            Console.WriteLine("Value Stored in myNum is: " + myNum + "\n DataType : " + myNum.GetType());

            Console.ReadKey();
        }
    }
}
