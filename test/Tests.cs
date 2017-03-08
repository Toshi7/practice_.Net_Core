using System;
using Library;
using Xunit;
using FluentAssertions;

namespace CharacterCounterTests
{
    public class GetCounterForLetter
    {
        [Fact]
        public void Should_return_a_count_of_1_if_there_is_a_single_letter_to_parse() 
        {
            CharacterCounter counter = new CharacterCounter();
            counter.ParseString("aaadda");
            counter.GetCountForLetter('a').Should().Be(4);
            //counter.Equal(4, counter.GetCountForLetter('a'));
            //            Assert.Equal(4, counter.GetCountForLetter('a'));
        }
    }
}
