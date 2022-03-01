using System;

namespace DelegatesExercises
{
    public delegate String myMethodDelegate(int myInt);

    public class Class1
    {
        public String method1(int value)
        {
            return string.Format("Method 1, value=[{0}]", value);
        }

        public static String method2(int value)
        {
            return string.Format("Method 2, value=[{0}]", value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();

            myMethodDelegate method1 = new myMethodDelegate(c1.method1);
            myMethodDelegate method2 = new myMethodDelegate(Class1.method2);

            Console.WriteLine("{0}", method1(1));
            Console.WriteLine("{0}", method2(2));
        }
    }
}
