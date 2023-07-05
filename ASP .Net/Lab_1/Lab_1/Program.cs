using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace Lab_1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program 1


            /*
             Console.WriteLine("My name is Mubin");
             Console.WriteLine(" Adress is phoolgali shakti chawk ");
             Console.WriteLine("Contact number is 9016029181");
             Console.WriteLine("City is Morbi");
            */

            //Program 2. 

            /*
            Console.WriteLine("Enter the Number 1 :");
            Int32 n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Number 2 :");
            Int32 n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The numbers are : {0} and {1}",n1,n2);
            */

            //Program 3 

            /*
            Console.WriteLine("Enter your name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your country :");
            string country = Console.ReadLine();

            Console.WriteLine("Hello {0} from Country {1}", name, country);
            */

            //Program 4.

            /*
            Console.WriteLine("Enter the length :");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width :");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The area is : {0} ",length*width);
            */



            //program 5.

            /*
            Console.WriteLine("Press 1 for Square \n Press 2 for Rectangle \n Press 3 for Circle");
            Int16 n1 = Convert.ToInt16(Console.ReadLine());

            if(n1 == 1) {
                Console.WriteLine("Enter the length :");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The area of Square is : {0}",length*length);
            }
            else if(n1 == 2) {
                Console.WriteLine("Enter the length :");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the length :");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The area of rectangle is : {0}", length * width);
            }
            else if( n1 == 3)
            {
                Console.WriteLine("Enter the radius :");
                double redius = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The area of rectangle is : {0}", redius*redius*3.14);
            }
            else
            {
                Console.WriteLine("Please enter the valid input");

            }
            */


            //Program 6

            /*
            Console.WriteLine("Press 1 for for F to C \n Press 2 for C to F");
            Int16 n = Convert.ToInt16(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("Enter the fehrenheit :");
                double f = Convert.ToDouble(Console.ReadLine());
                Program p1 = new Program();
                p1.FToC(f);
            }
            if (n == 2)
            {
                Console.WriteLine("Enter the celsius :");
                double c = Convert.ToDouble(Console.ReadLine());
                Program p1 = new Program();
                p1.CToF(c);
            }
            */



        }
        
        /*
        public void FToC(double f)
        {
            double c = ((f - 32) * 5) / 9;
            Console.WriteLine("The celius of the {0} fehrenheit is {1}", f, c);
        }

        public void CToF(double c)
        {
            double f = (c * (9 / 5)) + 32;
            Console.WriteLine("The fehrenheit of the {0} celsius is {1}", c,f);
        }
        */
    }
}