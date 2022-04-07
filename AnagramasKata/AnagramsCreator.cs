namespace AnagramasKata {
    public class AnagramsCreator {
        public List<string> GetAnagrams(string input) {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException();

            return new List<string>() {
                input,
                new string(
                    input.ToCharArray()
                    .Reverse()
                    .ToArray())
            };
        }
    }
}