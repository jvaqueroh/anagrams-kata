using FluentAssertions;
using NUnit.Framework;

namespace AnagramasKata.Tests {
    public class AnagramsCreatorShould {
        [Test]
        public void throws_an_exception_for_an_empty_input() {
            var anagramsCreator = new AnagramsCreator();

            Action call = () => {
                anagramsCreator.GetAnagrams(string.Empty);
            };

            call.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void return_a_list_with_same_one_character_word() {
            var anagramsCreator = new AnagramsCreator();

            var result = anagramsCreator.GetAnagrams("a");

            result.Should().Contain("a");
        }
    }
}