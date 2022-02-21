namespace FizzBuzz.Rules
{
    public class Rule13 : IRule
    {
        public int Divisor { get; set; }
        public string ToAdd { get; set; }

        public Rule13(int divisor, string toAdd)
        {
            Divisor = divisor;
            ToAdd = toAdd;
        }

        public List<string> Apply(List<string> previous, int number)
        {
            if (number % Divisor != 0)
            {
                return previous;
            }

            var output = new List<string>(previous);
            if (output.Count==0)
                output.Add(ToAdd);
            else {
                int i=0;
                while (output[i][0]!='B' && i<output.Count) {
                    i++;
                    if (i==output.Count) break;
                }
                output.Insert(i,ToAdd);
            }
            return output;
        }
    }
}