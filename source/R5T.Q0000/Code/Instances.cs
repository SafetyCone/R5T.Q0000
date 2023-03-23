using System;

using R5T.Z0000;


namespace R5T.Q0000
{
    public static class Instances
    {
        public static ICharacterExplorations CharacterExplorations => Q0000.CharacterExplorations.Instance;
        public static IPathExplorations PathExplorations => Q0000.PathExplorations.Instance;


        public static IEnumerableExperiments EnumerableExperiments => Q0000.EnumerableExperiments.Instance;


        public static IPathDemonstrations PathDemonstrations => Q0000.PathDemonstrations.Instance;


        public static ICharacterOperator CharacterOperator => Q0000.CharacterOperator.Instance;
        public static ICharacters Characters => Z0000.Characters.Instance;
        public static F0000.IEnumerableOperator EnumerableOperator => F0000.EnumerableOperator.Instance;
        public static IFilePath FilePath => Q0000.FilePath.Instance;
        public static IFilePathProvider FilePathProvider => Q0000.FilePathProvider.Instance;
        public static Z0004.IStrings ExampleStrings => Z0004.Strings.Instance;
        public static F0000.IPathOperator PathOperator => F0000.PathOperator.Instance;
    }
}
