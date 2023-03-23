using System;


namespace R5T.Q0000
{
    public class ArrayExperiments : IArrayExperiments
    {
        #region Infrastructure

        public static IArrayExperiments Instance { get; } = new ArrayExperiments();


        private ArrayExperiments()
        {
        }

        #endregion
    }
}
