namespace Oppgave321A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var counter = new Counter();
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                counter.AddText(text);
                counter.ShowCounts();
            }
        }
    }

    public class Counter
    { 
        private const int Range = 250;
        private readonly int[] _counts = new int[Range];

        public void AddText(string text)
        {
            foreach (var character in text ?? string.Empty)
            {
                _counts[(int)character]++;
            }
        }

        public void ShowCounts()
        {
            for (var i = 0; i < Range; i++)
            {
                if (_counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + _counts[i]);
                }
            }
        }
    }
}