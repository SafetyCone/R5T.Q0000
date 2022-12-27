using System;
using System.IO;
using System.Linq;

using R5T.T0141;


namespace R5T.Q0000
{
	[DemonstrationsMarker]
	public partial interface IPathDemonstrations : IDemonstrationsMarker
	{
		/// <summary>
		/// Shows that all invalid path characters are also included in the list of invalid file name characters.
		/// </summary>
		public void InvalidFileNameCharactersContainsAllInvalidPathCharacters()
        {
			var invalidPathCharacters = Instances.PathOperator.GetInvalidPathCharacters();
			var invalidFileNameCharacters = Instances.PathOperator.GetInvalidFileNameCharacters();

			var pathCharactersNotInFileNameCharacters = invalidPathCharacters.Except(invalidFileNameCharacters).Now();

			var anyPathCharactersNotInFileNameCharacters = pathCharactersNotInFileNameCharacters.Any();

			Console.WriteLine($"Are any invalid path characters not contained in the set of invalid file name characters:\n{anyPathCharactersNotInFileNameCharacters}");

			Console.WriteLine("Invalid path characters that are not in invalid file name characters:");
			Console.WriteLine(
                // Result: empty.
                Instances.CharacterOperator.List(pathCharactersNotInFileNameCharacters));
		}
	}
}