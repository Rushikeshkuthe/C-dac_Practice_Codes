using System;
//using Arithmatic;
namespace Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Basic Code
            //Console.WriteLine("Hello");

            //int i = 10;
            //int j = 20;
            //int result = i + j;
            //Console.WriteLine(result);
            #endregion

            #region Basic For Loop
            //for (int k = 0; k < 10; k++)
            //{
            //    Console.WriteLine(k);
            //}
            #endregion

           // Console.WriteLine("Enter X value");
           // string xVal = Console.ReadLine();
           // int x = Convert.ToInt32(xVal);

           // Console.WriteLine("Enter Y value");
           // string yVal = Console.ReadLine();
           // int y = Convert.ToInt32(yVal);

           //// Maths obj = new Maths();

           //// int result = obj.Add(x, y);
           // //Console.WriteLine(result);
            
           // Console.ReadLine();

            Customer c= new Customer();
            c.display();

        }

      
    }

    public class Person  
    {
        public virtual void display()
        {
            Console.WriteLine("hello1");
        }
    }

    public class Employee:Person
    {
        public override void display()
        {
            Console.WriteLine("hello2");
        }
    }

    public class Customer : Employee
    {
        public override void display()
        {
            Console.WriteLine("hello3");
        }
    }

}
