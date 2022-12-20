using System;


namespace R5T.Q0000
{
    public class NameOfOperatorExperiments : INameOfOperatorExperiments
    {
        #region Infrastructure

        public static INameOfOperatorExperiments Instance { get; } = new NameOfOperatorExperiments();


        private NameOfOperatorExperiments()
        {
        }

        #endregion
    }
}
