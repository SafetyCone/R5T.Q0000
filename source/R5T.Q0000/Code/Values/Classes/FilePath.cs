using System;


namespace R5T.Q0000
{
    public class FilePath : IFilePath
    {
        #region Infrastructure

        public static FilePath Instance { get; } = new();

        private FilePath()
        {
        }

        #endregion
    }
}
