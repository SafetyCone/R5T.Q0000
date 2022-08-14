using System;
using System.IO;
using System.Linq;

using R5T.T0141;


namespace R5T.Q0000
{
	[ExplorationsMarker]
	public partial interface IPathExplorations : IExplorationsMarker
	{
		public void ShowInvalidPathAndFileNameCharacters()
		{
			// See: ...\Reference\Path-Invalid Characters\Invalid Path Characters.txt
			var invalidPathCharacters01 = Path.GetInvalidPathChars();

			Console.WriteLine($"{nameof(Path)}.{nameof(Path.GetInvalidPathChars)}:");
			Console.WriteLine(String.Join(", ", invalidPathCharacters01));

			Console.WriteLine();

			// Obsolete.
			//var invalidPathCharacters02 = Path.InvalidPathChars;

			Console.WriteLine();

			// See: ...\Reference\Path-Invalid Characters\Invalid File Name Characters.txt
			var invalidFileNameChars = Path.GetInvalidFileNameChars();

			Console.WriteLine($"{nameof(Path)}.{nameof(Path.GetInvalidFileNameChars)}:");
			Console.WriteLine(String.Join(", ", invalidFileNameChars));
		}

		/// <summary>
		/// Result: yes!
		/// </summary>
		public void AreAllInvalidPathCharactersInInvalidFileNameCharacters()
        {
			var invalidPathCharacters = Path.GetInvalidPathChars();
			var invalidFileNameCharacters = Path.GetInvalidFileNameChars();

			var pathCharactersNotInFileNameCharacters = invalidPathCharacters.Except(invalidFileNameCharacters);

			Console.WriteLine("Invalid path characters that are not in invalid file name characters:");
			Console.WriteLine(Instances.CharacterOperator.List(pathCharactersNotInFileNameCharacters)); // Empty.
        }

        public void DescribeInvalidPathAndFileNameCharacters()
        {
            // See: ...\Reference\Path-Invalid Characters\Invalid Path Characters.txt
            var invalidPathCharacters = Path.GetInvalidPathChars();

			var invalidPathCharactersDescription = $"{nameof(Path)}.{nameof(Path.GetInvalidPathChars)}():\n\n" +
				Instances.CharacterOperator.Describe(invalidPathCharacters);

			File.WriteAllText(@"C:\Temp\Invalid Path Characters.txt", invalidPathCharactersDescription);

            // See: ...\Reference\Path-Invalid Characters\Invalid File Name Characters.txt
            var invalidFileNameCharacters = Path.GetInvalidFileNameChars();

            var invalidFileNameCharactersDescription = $"{nameof(Path)}.{nameof(Path.GetInvalidFileNameChars)}():\n\n" +
				Instances.CharacterOperator.Describe(invalidFileNameCharacters);

			File.WriteAllText(@"C:\Temp\Invalid File Name Characters.txt", invalidFileNameCharactersDescription);
		}
    }
}