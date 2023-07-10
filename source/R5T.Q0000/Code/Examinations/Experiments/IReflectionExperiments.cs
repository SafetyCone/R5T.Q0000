using System;

using R5T.T0141;


namespace R5T.Q0000
{
    [ExperimentsMarker]
    public partial interface IReflectionExperiments : IExperimentsMarker
    {
        public void Get_StringAssemblyLocation()
        {
            var stringType = "".GetType();

            Console.WriteLine(stringType.Assembly.Location);
        }
    }
}
