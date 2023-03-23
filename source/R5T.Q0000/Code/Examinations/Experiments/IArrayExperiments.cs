using System;
using System.Collections.Generic;

using R5T.T0141;


namespace R5T.Q0000
{
    [ExperimentsMarker]
    public partial interface IArrayExperiments : IExperimentsMarker
    {
        /// <summary>
        /// An <see cref="Array"/> implements <see cref="IList{T}"/>.
        /// And a list has the <see cref="ICollection{T}.Add(T)"/> method.
        /// <para>What happens if you call Add() on an array?</para>
        /// <result>
        /// Result: System.NotSupportedException: 'Collection was of a fixed size.'
        /// </result>
        /// </summary>
        /// <remarks>
        /// See a great <see href="https://stackoverflow.com/a/15561100">StackOverflow</see> write up of how original design decisions with <see cref="Array"/> cause this.
        /// </remarks>
        public void ArrayAsIList_Add()
        {
            var array = new string[]
            {
                "A",
                "B",
            };

            // Result: System.NotSupportedException: 'Collection was of a fixed size.'
            (array as IList<string>).Add("C");
        }
    }
}
