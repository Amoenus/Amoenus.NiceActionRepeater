using System;
using System.Linq;

namespace Amoenus.NiceActionRepeater
{
    /// <summary>
    ///
    /// </summary>
    public static class ActionExtensions
    {
        /// <summary>
        /// Repeats the action specified number of times.
        /// </summary>
        /// <param name="actionToRepeat">The action to repeat.</param>
        /// <param name="repeatCount">The repeat count.</param>
        public static void RepeatAction(this Action actionToRepeat, int repeatCount)
        {
            foreach (Action action in Enumerable.Repeat(actionToRepeat, repeatCount))
            {
                action();
            }
        }
    }
}
