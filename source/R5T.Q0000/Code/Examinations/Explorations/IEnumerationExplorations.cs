using System;

using R5T.T0141;


namespace R5T.Q0000
{
    [ExplorationsMarker]
    public partial interface IEnumerationExplorations : IExplorationsMarker
    {
        public void ExamineFlagValues()
        {
            var values = Enum.GetValues<RandomFlags>();

            foreach (var value in values)
            {
                Console.WriteLine($"{value}: value");
                Console.WriteLine($"{(int)value}: integer");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// How can I get information out of flag enumerations?
        /// </summary>
        public void ExamineFlags()
        {
            var value =
                RandomFlags.First | RandomFlags.Second | RandomFlags.Third
                //| RandomFlags.None
                ;

            // Outputs: DeveloperConsole, VisualStudioSetup, DotNetSdk: DiscoveryType
            Console.WriteLine($"{value}: {nameof(RandomFlags)}");

            Console.WriteLine($"{(int)value}: {nameof(Int32)}");

            var has = value.HasFlag(RandomFlags.First);
            Console.WriteLine($"{has}: has flag {nameof(RandomFlags.First)}");
            // This will always be true!
            Console.WriteLine($"{has}: has flag {nameof(RandomFlags.None)}");
        }
    }
}
