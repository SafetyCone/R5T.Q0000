using System;


namespace R5T.Q0000
{
    public class FileSystemExperiments : IFileSystemExperiments
    {
        #region Infrastructure

        public static IFileSystemExperiments Instance { get; } = new FileSystemExperiments();


        private FileSystemExperiments()
        {
        }

        #endregion
    }
}
