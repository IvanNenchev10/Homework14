using System;

namespace Task14._3.cs
{
    class Program
    {
        interface I1<T>
        {
            void Create(T value);
            T Read();
            T Update(T value);
            void Delete();
        }
        class Test<T> : I1<T>
        {
            private T a;
            public  void Create(T value)
            {
                a = value;
            }
            public T Read()
            {
                return a;
            }
            public T Update(T value)
            {
                a = value;
                return a;
            }
            public  void Delete()
            {
                Console.WriteLine("{0} is deleted", a);
            }
        }
        class Example<T>:I1<T>
        {
            private T a;
            private T b;
            public Example(T a)
            {
                this.a = a;
            }
            public void Create(T num)
            {
                b = num;
            }
            public T Read()
            {
                T result = (dynamic)a + (dynamic)b;
                return result;
            }
            public T Update(T num)
            {
                b = num;
                T result = (dynamic)a + (dynamic)b;
                return result;
            }
            public void Delete()
            {
                Console.WriteLine("{0} is deleted", a);
                Console.WriteLine("{0} is deleted", b);
            }
        }
        static void TestClass1()
        {
            Test<int> test = new Test<int>();
            test.Create(10);
            Console.WriteLine("{0}", test.Read());
            Console.WriteLine("{0}", test.Update(20));
            test.Delete();
        }
        static void TestClass2()
        {
            Example<string> example = new Example<string>("Hello");
            example.Create("World");
            Console.WriteLine("{0}", example.Read());
            Console.WriteLine("{0}", example.Update("C#"));
            example.Delete();
        }
        static void Main()
        {
            TestClass1();
            Console.WriteLine();
            TestClass2(); 
        }
    }
}
