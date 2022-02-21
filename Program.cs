// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace FizzBuzz
{
    class Program
    {
        static void Main (string[] args) {
            Console.WriteLine("Hello, World!");
            var fizzBuzzer = new FizzBuzzer();

            for (int i=1; i<=359; i++) {
               Console.WriteLine(i.ToString()+'-'+fizzBuzzer.FizzBuzz(i));
            }
        }
    }
}

