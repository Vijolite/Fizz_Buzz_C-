using System;
using FizzBuzz.Rules;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var rules = new List<IRule>()
            {
                new DivisibleRule(3, "Fizz"),
                //new Rule3(),
                new DivisibleRule(5, "Buzz"),
                new DivisibleRule(7, "Bang"),
                new OverwriteRule(11, "Bong"),
                new ReverseRule(17),
                new Rule13 (13,"Fezz"),
            };

            var fizzBuzzer = new FizzBuzzer(rules);

            for (int i = 1; i <= 195; i++)
            {
                Console.WriteLine(fizzBuzzer.FizzBuzz(i));
            }
        }
    }
}
// using System;
// namespace FizzBuzz
// {
//     class Program
//     {
//         static void Main (string[] args) {
//             Console.WriteLine("Hello, FizzBuzz!");
//             var fizzBuzzer = new FizzBuzzer();

//             for (int i=1; i<=359; i++) {
//                Console.WriteLine(i.ToString()+'-'+fizzBuzzer.FizzBuzz(i));
//             }
//         }
//     }
// }

