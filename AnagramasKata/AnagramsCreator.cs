namespace AnagramasKata {
    public class AnagramsCreator {
        public List<string> GetAnagrams(string input) {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException();

            var result = new List<string>() { input };

            if (input.Length > 1)
                result.Add(
                    new string(
                        input.ToCharArray()
                        .Reverse()
                        .ToArray())
                );

            return result;
        }
    }
}