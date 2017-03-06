﻿using System;
using Library;
using Xunit;

namespace CharacterCounterTests
{
    public class GetCounterForLetter
    {
        [Fact]
        public void Should_return_a_count_of_1_if_there_is_a_single_letter_to_parse() 
        {
            CharacterCounter counter = new CharacterCounter();
            counter.ParseString("a");
            Assert.Equal(1, counter.GetCountForLetter('a'));
        }
    }
}
