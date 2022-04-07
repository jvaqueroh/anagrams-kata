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

        [Test]
        public void return_a_list_with_same_one_character_word_from_input() {
            var result = anagramsCreator.GetAnagrams("a");

            result.Should().Contain("a");
        }

        [Test]
        public void return_a_list_with_the_two_characters_word_inverted() {
            var result = anagramsCreator.GetAnagrams("ab");

            result.Should().Contain("ba");
        }

        [TestCase("ab", new[]{"ab", "ba"})]
        public void return_all_combinations(string input, string[] expected) {
            var result = anagramsCreator.GetAnagrams(input);
            result.Should().BeEquivalentTo(expected);
        }
    }
}