using System;
using System.IO;
using System.Linq;

using R5T.T0141;


namespace R5T.Q0000
{
	[DemonstrationsMarker]
	public partial interface IPathDemonstrations : IDemonstrationsMarker
	{
		public void InvalidFileNameCharactersContainsAllInvalidPathCharacters()
        {
			var invalidPathCharacters = Path.GetInvalidPathChars();
			var invalidFileNameCharacters = Path.GetInvalidFileNameChars();

			var pathCharactersNotInFileNameCharacters = invalidPathCharacters.Except(invalidFileNameCharacters).Now();

			var anyPathCharactersNotInFileNameCharacters = pathCharactersNotInFileNameCharacters.Any();

			Console.WriteLine($"Are any invalid path characters not contained in the set of invalid file name characters:\n{anyPathCharactersNotInFileNameCharacters}");

			Console.WriteLine("Invalid path characters that are not in invalid file name characters:");
			Console.WriteLine(
				Instances.CharacterOperator.List(pathCharactersNotInFileNameCharacters)); // Empty.
		}
	}
}