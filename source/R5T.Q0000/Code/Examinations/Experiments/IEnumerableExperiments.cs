using System;
using System.Linq;

using R5T.T0141;


namespace R5T.Q0000
{
	[ExperimentsMarker]
	public partial interface IEnumerableExperiments : IExperimentsMarker
	{
		/// <summary>
		/// Experiment for whether <see cref="Enumerable.Zip{TFirst, TSecond, TResult}(System.Collections.Generic.IEnumerable{TFirst}, System.Collections.Generic.IEnumerable{TSecond}, Func{TFirst, TSecond, TResult})"/> throws if its input sequences are of unequal length.
		/// Result: Zip does not throw.
		/// </summary>
		public void DoesZipThrow()
        {
			// Create two sequences of unequal length.
			var first = new[]
			{
				Instances.ExampleStrings.String01,
				Instances.ExampleStrings.String02,
				Instances.ExampleStrings.String03,
			};

			var second = new[]
			{
				Instances.ExampleStrings.String01,
				Instances.ExampleStrings.String02,
			};

			// Output: "Zip does not throw."
			try
			{
				_ = first.Zip(second, (first, second) => first + second);

				Console.WriteLine("Zip does not throw.");
            }
			catch
            {
				Console.WriteLine("Zip throws.");
			}
		}
	}
}