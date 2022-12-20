using System;


namespace R5T.Q0000
{
    public class CharacterOperator : ICharacterOperator
    {
        #region Infrastructure

        public static CharacterOperator Instance { get; } = new();

        private CharacterOperator()
        {
        }

        #endregion
    }
}
