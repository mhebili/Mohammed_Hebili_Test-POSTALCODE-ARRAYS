using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[8];

            Address add = new Address();
            add.PostalCode = 9300;
            add.City = "Aalst";
            arr[0] = add;

            Address add1 = new Address();
            add1.PostalCode = 2000;
            add1.City = "Antwerp";
            arr[1] = add1;

            Address add2 = new Address();
            add2.PostalCode = 1000;
            add2.City = "Brussels";
            arr[2] = add2;

            Address add3 = new Address();
            add3.PostalCode = 9200;
            add3.City = "Dendermonde";
            arr[3] = add3;

            Address add4 = new Address();
            add4.PostalCode = 9000;
            add4.City = "Ghent";
            arr[4] = add4;

            Address add5 = new Address();
            add5.PostalCode = 8500;
            add5.City = "Kortrijk";
            arr[5] = add5;

            Address add6 = new Address();
            add6.PostalCode = 9700;
            add6.City = "Oudenaarde";
            arr[6] = add6;

            Address add7 = new Address();
            add7.PostalCode = 2300;
            add7.City = "Turnhout";
            arr[7] = add7;

            Console.WriteLine(); //Break line
            string userInput = string.Empty;
            do
            {
                Console.WriteLine("Enter a postal code to search");
                int postalCode = int.Parse(Console.ReadLine());
                bool isFound = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (((Address)arr[i]).PostalCode == postalCode)
                    {
                        Console.WriteLine("Postal Code: {0} City: {1}", ((Address)arr[i]).PostalCode, ((Address)arr[i]).City);
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                    Console.WriteLine("Not Found");

                Console.WriteLine();
                Console.WriteLine("Do you want to continue YES or NO");
                userInput = Console.ReadLine().ToUpper();

            }
            while (userInput == "YES");

            Console.ReadLine(); //Hold back the screen
        }
    }
    class Address
    {
        public int PostalCode { get; set; }
        public string City { get; set; }
    }
}