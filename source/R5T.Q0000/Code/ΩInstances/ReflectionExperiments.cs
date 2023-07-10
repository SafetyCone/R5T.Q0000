using System;


namespace R5T.Q0000
{
    public class ReflectionExperiments : IReflectionExperiments
    {
        #region Infrastructure

        public static IReflectionExperiments Instance { get; } = new ReflectionExperiments();


        private ReflectionExperiments()
        {
        }

        #endregion
    }
}
