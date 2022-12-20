using System;

using R5T.T0141;


namespace R5T.Q0000
{
    /// <summary>
    /// Experiments exploring the nameof() operator.
    /// </summary>
    [ExperimentsMarker]
    public partial interface INameOfOperatorExperiments : IExperimentsMarker
    {
        /// <summary>
        /// What happens if you give the nameof() operator a full namespace, like R5T.Q0000?
        /// Result: Q0000, Just the last token of the namespace is returned.
        /// This is to be expected, since for namespace-named type names, just the type name (the last token) is returned.
        /// </summary>
        public void HowIsFullNamespaceNameHandled()
        {
            var namespaceName = nameof(R5T.Q0000);

            Console.WriteLine(namespaceName);
        }
    }
}
