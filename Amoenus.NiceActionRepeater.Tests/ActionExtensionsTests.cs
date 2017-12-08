using System;
using FluentAssertions;
using NUnit.Framework;

namespace Amoenus.NiceActionRepeater.Tests
{
    [TestFixture]
    public class ActionExtensionsTests
    {
        [Test]
        public void RepeatAction_InvokesActionExpectedNumberOfTimes()
        {
            var actualCounter = 0;
            var expectedCounter = 200;

            Action actionToRepeat = () => { actualCounter++; };

            actionToRepeat.RepeatAction(expectedCounter);

            expectedCounter.ShouldBeEquivalentTo(actualCounter);
        }
    }
}