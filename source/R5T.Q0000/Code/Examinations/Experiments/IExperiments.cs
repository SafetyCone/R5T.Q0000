using System;
using System.Collections.Generic;

using R5T.T0141;


namespace R5T.Q0000
{
    [ExperimentsMarker]
    public partial interface IExperiments : IExperimentsMarker
    {
        /// <summary>
        /// What if you have a dictionary keyed by an interface, but the key instances are a type that implements <see cref="IEquatable{T}"/>;
        /// does the Equals() method of the actual instance type get called?
        /// Result: yes!
        /// </summary>
        public void EquatableInstancesOfInterfaceTypeAndDictionaries()
        {
            var dictionary = new Dictionary<IType, string>
            {
                { new EquatableIType("A"), "A" },
                { new EquatableIType("B"), "B" }
            };

            var newKey = new EquatableIType("A");

            // Result: true.
            var dictionaryContainsNewKey = dictionary.ContainsKey(newKey);

            Console.WriteLine(dictionaryContainsNewKey);
        }
    }
}
