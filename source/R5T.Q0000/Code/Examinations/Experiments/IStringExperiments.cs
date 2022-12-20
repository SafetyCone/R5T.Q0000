using System;
using System.Linq;

using R5T.T0141;


namespace R5T.Q0000
{
	[ExperimentsMarker]
	public partial interface IStringExperiments : IExperimentsMarker
	{
        /// <summary>
        /// What happens if you use the range operator with an index that is out of bounds?
        /// Result: System.ArgumentOutOfRangeException: 'startIndex cannot be larger than length of string. (Parameter 'startIndex')'
        /// </summary>
        public void RangeOperatorWithOutOfBoundsIndex()
		{
			var emptyString = Strings.Instance.Empty;

			var result = emptyString[1..];

			Console.WriteLine(result);
		}

        /// <summary>
        /// What happens if you use the range operator with an index that is the last index (meaning an empty result)?
        /// Result: Just returns an empty string result.
        /// </summary>
        public void RangeOperatorStartingAtLastIndex()
        {
            var stringOfLengthOne = Strings.Instance.OfLengthOne;

            var result = stringOfLengthOne[1..];

            Console.WriteLine(result);
        }

        /// <summary>
        /// What is the length of a null string?
        /// Results:
        /// 
        /// * nullString.Length, as expected produces a NullReferenceException.
        /// * LINQ extension Count(), there is a helpful CA1829 message to use .Length instead of the Count() extension.
        ///     Further, the extension method (which is really just a static method being called on a null input) creates an ArgumentNullException.
        /// </summary>
        public void WhatIsTheLengthOfANullString()
        {
            var nullString = Strings.Instance.Null;

            //// As expected, a null reference exception.s
            //// System.NullReferenceException: 'Object reference not set to an instance of an object.'
            //var length = nullString.Length;

            // System.ArgumentNullException: 'Value cannot be null. (Parameter 'source')'
#pragma warning disable CA1829 // Use Length/Count property instead of Count() when available
            var length = nullString.Count();
#pragma warning restore CA1829 // Use Length/Count property instead of Count() when available

            Console.WriteLine(length);
        }
    }
}