using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    //Generic with class name
    class TestGenericClass<T>
    {
        //Generic with variable
        private T variable1;

        //Generic with constructor
        public TestGenericClass(T value)
        {
            variable1 = value;
        }

        //Generic with member function
        public T TestFunction(T param1)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), param1);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), variable1);

            return variable1;
        }

        //Generic with property
        public T property1 { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestGenericClass<int> intGenericClass = new TestGenericClass<int>(10);
            int val = intGenericClass.TestFunction(200);

            TestGenericClass<string> stringGenericClass = new TestGenericClass<string>("Hello generic");           
            string val1 = stringGenericClass.TestFunction("Using generic");
        }
    }
}
