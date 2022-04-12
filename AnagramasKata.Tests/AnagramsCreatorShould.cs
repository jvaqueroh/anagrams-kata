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

        [TestCase("a",   new[] { "a" }, TestName = "create anagrams for single letter input")]
        [TestCase("ab",  new[] { "ab", "ba" }, TestName = "create anagrams for two letters input")]
        [TestCase("aa",  new[] { "aa" }, TestName = "create non duplicated anagrams")]
        [TestCase("abc", new[] {"abc", "acb", "bac", "bca", "cab", "cba"}, TestName = "create anagrams for three letters input")]
        public void return_all_combinations_only_once(string input, string[] expected) {
            var result = anagramsCreator.GetAnagrams(input);

            result.Should().BeEquivalentTo(expected);
        }
    }
}