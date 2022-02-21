using FizzBuzz.Rules;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public List<IRule> Rules { get; set; }

        public FizzBuzzer(List<IRule> rules)
        {
            Rules = rules;
        }

        public string FizzBuzz(int number)
        {
            List<string> output = new List<string>();

            foreach (IRule rule in Rules)
            {
                output = rule.Apply(output, number);
            }

            if (output.Count == 0)
            {
                return number.ToString();
            }

            return string.Join("", output);
        }
    }
}
// namespace FizzBuzz
// {
//     public class FizzBuzzer
//     {
//         public string FizzBuzz(int i)
//         {
//             String output="";
//             if (i%11==0) output+="Bong";
//                 else
//                 {
//                 if (i%3==0) output+="Fizz";
//                 if (i%5==0) output+="Buzz";
//                 if (i%7==0) output+="Bang";
//                 if (i%13==0) {
//                     if (output.Length==0) output="Fezz";
//                     else {
//                         int b=output.IndexOf("B");
//                         if (b==-1) output+="Fezz";
//                         else {
//                             output=output.Substring(0,b)+"Fezz"+output.Substring(b,output.Length-b);
//                             }
//                         }
//                     }
//                 }
//                 if (i%17==0 && output.Length>4) {
//                     String newOutput="";
//                     for (int j=0;j<output.Length;j+=4) {
//                         String outputSub=output.Substring(j,4);
//                         newOutput=outputSub+newOutput;
//                     }
//                     output=newOutput;
//                 }
//                 if (output=="") output=i.ToString();

//             return output;
//         }
//     }
// }