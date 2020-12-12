using System;

namespace Less07_task05
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.MathStruct instance = new MyClass.MathStruct();
            int square = instance.Square(7);

            Console.ReadKey();
        }
    }

    class MyClass
    {
        public struct MathStruct
        {
            public int Square(int a)
            {
                return a * a;
            }
        }
    }
}
