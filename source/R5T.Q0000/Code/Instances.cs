using System;


namespace R5T.Q0000
{
    public static class Instances
    {
        public static ICharacterExplorations CharacterExplorations { get; } = Q0000.CharacterExplorations.Instance;
        public static ICharacterOperator CharacterOperator { get; } = Q0000.CharacterOperator.Instance;
        public static IFilePath FilePath { get; } = Q0000.FilePath.Instance;
        public static IFilePathProvider FilePathProvider { get; } = Q0000.FilePathProvider.Instance;
    }
}
