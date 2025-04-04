using System;
namespace MyNamespace
{
    public class MyClass
    {
        public static int a = 1;//static variable
        public void variable()
        {
            a = a + 1;
            Console.WriteLine($"Value of a is {a}");
        }
        static void Main(string[] args)
        {
            MyClass var1 = new MyClass();
            var1.variable();
            MyClass var2 = new MyClass();
            var2.variable();
            MyClass var3 = new MyClass();
            var3.variable();
            Console.ReadKey();

        }
    }
}
