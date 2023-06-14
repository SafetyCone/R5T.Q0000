using System;


namespace R5T.Q0000
{
    public class EnumerationExplorations : IEnumerationExplorations
    {
        #region Infrastructure

        public static IEnumerationExplorations Instance { get; } = new EnumerationExplorations();


        private EnumerationExplorations()
        {
        }

        #endregion
    }
}
