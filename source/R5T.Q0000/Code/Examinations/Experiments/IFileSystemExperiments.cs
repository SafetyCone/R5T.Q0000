using System;
using System.IO;

using R5T.T0141;


namespace R5T.Q0000
{
    [ExperimentsMarker]
    public partial interface IFileSystemExperiments : IExperimentsMarker
    {
        /// <summary>
        /// Try the <see cref="DirectoryInfo.GetFiles(string, EnumerationOptions)"/> method.
        /// Result: With <see cref="EnumerationOptions.RecurseSubdirectories"/> set to true, files in sub-directories are returned.
        /// </summary>
        public void GetFiles_WithEnumerationOptions()
        {
            /// Inputs.
            var directoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Q0000\source\R5T.Q0000";


            /// Run.
            var directoryInfo = new DirectoryInfo(directoryPath);

            var enumerationOptions = new EnumerationOptions
            {
                RecurseSubdirectories = true,
            };

            var fileInfos = directoryInfo.GetFiles(
                F0000.SearchPatterns.Instance.All,
                enumerationOptions);

            foreach (var fileInfo in fileInfos)
            {
                Console.WriteLine(fileInfo.FullName);
            }
        }

        /// <summary>
        /// Does the <see cref="DirectoryInfo.GetFiles()"/> method only return files in the top-level directory?
        /// Result: Yes! Only files in the top-level directory are returned.
        /// </summary>
        public void GetFiles()
        {
            /// Inputs.
            var directoryPath = @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Q0000\source\R5T.Q0000";


            /// Run.
            var directoryInfo = new DirectoryInfo(directoryPath);

            var fileInfos = directoryInfo.GetFiles();

            foreach (var fileInfo in fileInfos)
            {
                Console.WriteLine(fileInfo.FullName);
            }
        }
    }
}
