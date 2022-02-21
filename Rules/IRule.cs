namespace FizzBuzz.Rules
{
    public interface IRule
    {
        List<string> Apply(List<string> previous, int number);
    }
}