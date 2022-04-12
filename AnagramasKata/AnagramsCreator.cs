namespace AnagramasKata {
    public class AnagramsCreator {
        public List<string> GetAnagrams(string input) {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException();

            var result = new List<string>();

            for (int i = 0; i < input.Length; i++) {
                var initial = input[i];
                var rest = input.ToList();
                rest.RemoveAt(i);
                result.Add(initial + new string(rest.ToArray()));
                rest.Reverse();
                result.Add(initial + new string(rest.ToArray()));
            }

            return result.Distinct().ToList();
        }
    }
}