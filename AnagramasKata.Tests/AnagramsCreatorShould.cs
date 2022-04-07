using FluentAssertions;
using NUnit.Framework;

namespace AnagramasKata.Tests {
    public class AnagramsCreatorShould {
        private AnagramsCreator anagramsCreator = null!;

        [SetUp]
        public void SetUp() {
            anagramsCreator = new AnagramsCreator();
        }

        [Test]
        public void throws_an_exception_for_an_empty_input() {
            Action call = () => {
                anagramsCreator.GetAnagrams(string.Empty);
            };

            call.Should().Throw<ArgumentNullException>();
        }
        
        [TestCase("a", new[]{"a"})]
        [TestCase("ab", new[]{"ab", "ba"})]
        [TestCase("abc", new[] {"abc", "acb", "bac", "bca", "cab", "cba"})]
        public void return_all_combinations_only_once(string input, string[] expected) {
            var result = anagramsCreator.GetAnagrams(input);

            result.Should().BeEquivalentTo(expected);
        }
    }
}