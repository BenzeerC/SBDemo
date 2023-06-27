using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            // or
            StringBuilder sb2 = new StringBuilder(20);//Capacity--> Maximum no of characters that we want to store
            //or
            StringBuilder sb3 = new StringBuilder("Your Payment is:",25000);
            sb.Append("Hello to all");//Append used to modify
            Console.WriteLine( sb);
            Console.WriteLine(sb.GetHashCode());//GetHashCode---> Used to get memory location.

            sb.Insert(5, "TEST DATA");//Insert used to add inbeetween data
            Console.WriteLine(sb);

            sb.Remove(5, 4);// Remove used for remove char
            Console.WriteLine(sb);

            sb.Replace("DATA", "data");
            Console.WriteLine(sb);

            sb3.AppendFormat("{0:C}", 25000);
            Console.WriteLine(sb3);



        }
    }
}
