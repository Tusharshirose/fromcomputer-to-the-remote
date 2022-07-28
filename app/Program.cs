// See https://aka.ms/new-console-template for more information
//System is a namespace used for this class which contains the class Console and functions like WriteLine
//We will group the class and the function in the namespace firstconsoleapp
using System;
namespace firstconsoleapp
{
    //Class name should be same as the file name
    //Every line of code should be inside the class
    class Program
    {
        //Everything that will run should be inside the main function
        static void Main(string[] args)
        {
            int a1=0;
            int a2=0;
            Console.WriteLine("First calculator application");
            Console.WriteLine("Enter the first number");
            a1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            a2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation");
            Console.WriteLine("\tA- add");
            Console.WriteLine("\tS- subtract");
            Console.WriteLine("\tD- division");
            Console.WriteLine("\tM- multiply");
            //Dollar sign shows that this string contains placeholders
            switch(Console.ReadLine())
            {
                case "A":
                    Console.WriteLine($"\n Your result {a1} + {a2} = "+ (a1+a2));
                    break;
                case "S":
                    Console.WriteLine($"\n Your result {a1} - {a2} = "+ (a1-a2));
                    break;
                case "D":
                    Console.WriteLine($"\n Your result {a1} / {a2} = "+ (a1/a2));
                    break;
                case "M":
                    Console.WriteLine($"\n Your result {a1} * {a2} = "+ (a1*a2));
                    break;
                case "SR":
                    Console.WriteLine($"\n Your result {a1} * {a2} * {a2} = "+ (a1*a2*a2));
                    break;
            }
            Console.WriteLine("Hello, World!");
            int number=60;
            double number2=60.0;
            string name="tushar";
            char initial='t';
            bool gender=true;
            Console.WriteLine(gender+""+number2);
            string[] car={"audi","bmw","mercedes","ferrari"};
            foreach(string i in car)
            {
                Console.WriteLine(i);
            }
         }
    }
}
