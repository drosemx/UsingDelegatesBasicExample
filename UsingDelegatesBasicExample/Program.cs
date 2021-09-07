// See https://aka.ms/new-console-template for more information
using System;

namespace UsingDelegatesBasicExample
{

    class Program
    {
        //Delegate(MyBasicDelegate) that can encapsulate a method that takes a string as an argument and returns void:
        public delegate void MyBasicDelegate(string message);
        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message + " Resultado desde delegate");
        }

        public static void MethodWithCallback(int param1, int param2, MyBasicDelegate callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! this is a basic example about how to use delegates");
            // Instantiate the delegate.
            MyBasicDelegate handler = DelegateMethod;

            // Call the delegate.
            handler("Hello World using delegate");

            // CallBack the delegate.
            MethodWithCallback(1, 2, handler);
        }

    }
}