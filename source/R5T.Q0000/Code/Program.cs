using System;


namespace R5T.Q0000
{
    class Program
    {
        static void Main()
        {
            /// Explorations.
            //Instances.CharacterExplorations.OutputAllCharacters();

            //Instances.PathExplorations.ShowInvalidPathAndFileNameCharacters();
            //Instances.PathExplorations.AreAllInvalidPathCharactersInInvalidFileNameCharacters();
            //Instances.PathExplorations.DescribeInvalidPathAndFileNameCharacters();


            /// Experiments.
            //EnumerableExperiments.Instance.DoesZipThrow();

            //FileSystemExperiments.Instance.GetFiles();
            FileSystemExperiments.Instance.GetFiles_WithEnumerationOptions();

            //NameOfOperatorExperiments.Instance.HowIsFullNamespaceNameHandled();

            //StringExperiments.Instance.RangeOperatorWithOutOfBoundsIndex();
            //StringExperiments.Instance.RangeOperatorStartingAtLastIndex();
            //StringExperiments.Instance.WhatIsTheLengthOfANullString();


            /// Demonstrations.
            //Instances.PathDemonstrations.InvalidFileNameCharactersContainsAllInvalidPathCharacters();
        }
    }
}
