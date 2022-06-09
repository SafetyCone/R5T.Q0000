using System;
using System.IO;
using System.Linq;

using R5T.T0132;


namespace R5T.Q0000
{
    [FunctionalityMarker]
    public interface ICharacterOperator : IFunctionalityMarker,
        F0000.ICharacterOperator
    {
        /// <summary>
        /// Writes characters selected by the predicate to the console and to the specified file.
        /// </summary>
        /// <param name="outputFileName"></param>
        /// <param name="predicate"></param>
        public void OutputCharactersWhere(
            string outputFileName,
            Func<char, bool> predicate,
            bool outputToConsole = true)
        {
            var selectedCharacters = Instances.CharacterOperator.GetCharactersWhere(
                predicate);

            var lines = selectedCharacters
                .Select(character => Instances.CharacterOperator.Describe(character))
                .Now();

            if (outputToConsole)
            {
                // Write to console.
                lines.ForEach(line => Console.WriteLine(line));
            }

            // Write to input file.
            var filePath = Instances.FilePathProvider.GetOutputFilePath(outputFileName);

            FileHelper.WriteAllLinesSynchronous(
                filePath,
                lines);
        }
    }
}
