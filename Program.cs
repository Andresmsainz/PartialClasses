using System;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Partial Classes!");
            Animals animal = new Animals();

            //animal now holds properties and methods from both partial classes in Class1 & Class2
            animal.GetName();
        }
    }
}
