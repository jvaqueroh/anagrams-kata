namespace AnagramasKata {
    public class AnagramsCreator {
        public IEnumerable<string> GetAnagrams(string input) {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException(nameof(input));

            var result = new List<string>();

            for (var i = 0; i < input.Length; i++) {
                var initial = input[i];
                var rest = GetRest(input, i);
                if (input.Length < 4) {
                    result.Add(initial + new string(rest));
                    result.Add(initial + new string(rest.Reverse().ToArray()));
                }
                else {
                    var partialResult = GetAnagrams(new string(rest));
                    result.AddRange(partialResult.Select(r => initial + r));
                }
            }

            return result.Distinct();
        }

        private static char[] GetRest(string input, int i) {
            var rest = input.ToList();
            rest.RemoveAt(i);
            return rest.ToArray();
        }
    }
}