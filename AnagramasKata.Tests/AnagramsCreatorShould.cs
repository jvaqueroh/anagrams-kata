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
    }
}