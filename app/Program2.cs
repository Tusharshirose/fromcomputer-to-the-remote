using System;
namespace firstconsoleapp1
{
    class car
    {
        public void display()
        {
            Console.WriteLine("This is a car");
        }
        
    }
    class Audi:car
    {
        public void display()
        {
            Console.WriteLine("This is an Audi A7");
        }
    }
    class BMW:car
    {
        public void display()
        {
            Console.WriteLine("This is an BMW X5");
        }
    }

}
