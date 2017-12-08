using System;
using FluentAssertions;
using NUnit.Framework;

namespace Amoenus.NiceActionRepeater.Tests
{
    [TestFixture]
    public class ActionExtensionsTests
    {
        [Test]
        public void RepeatAction_WhenNegative_ThrowsArgumentOutOfRangeException()
        {
            const int expectedCounter = -200;

            Action actionToRepeat = () => { };

            Assert.Throws<ArgumentOutOfRangeException>(() => actionToRepeat.RepeatAction(expectedCounter));
        }

        [Test]
        public void RepeatAction_WhenNull_ThrowsNullReferenceException()
        {
            const int expectedCounter = 200;

            Action actionToRepeat = null;

            Assert.Throws<NullReferenceException>(() => actionToRepeat.RepeatAction(expectedCounter));
        }

        [Test]
        public void RepeatAction_WhenPositive_InvokesActionExpectedNumberOfTimes()
        {
            var actualCounter = 0;
            const int expectedCounter = 200;

            Action actionToRepeat = () => { actualCounter++; };

            actionToRepeat.RepeatAction(expectedCounter);

            expectedCounter.ShouldBeEquivalentTo(actualCounter);
        }

        [Test]
        public void RepeatAction_WhenZero_InvokesActionExpectedNumberOfTimes()
        {
            var actualCounter = 0;
            const int expectedCounter = 0;

            Action actionToRepeat = () => { actualCounter++; };

            actionToRepeat.RepeatAction(expectedCounter);

            expectedCounter.ShouldBeEquivalentTo(actualCounter);
        }
    }
}