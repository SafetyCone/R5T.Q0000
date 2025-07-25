using System;

using R5T.T0141;


namespace R5T.Q0000
{
	[ExplorationsMarker]
	public interface ICharacterExplorations : IExplorationsMarker
	{
        /// <summary>
        /// Outputs all characters.
        /// </summary>
        public void OutputAllCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-All.txt",
                Instances.CharacterOperator.Is_Character);
        }

        /// <summary>
        /// Outputs alphanumeric (letter-or-digit) class characters.
        /// </summary>
        public void OutputAlphanumericCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Alphanumeric.txt",
                Instances.CharacterOperator.Is_Alphanumeric);
        }

        /// <summary>
        /// Outputs control class characters.
        /// </summary>
        public void OutputControlCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Control.txt",
                Instances.CharacterOperator.Is_Control);
        }

        /// <summary>
        /// Outputs digit class characters.
        /// </summary>
        public void OutputDigitCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Digit.txt",
                Instances.CharacterOperator.Is_Digit);
        }

        /// <summary>
        /// Outputs letter class characters.
        /// </summary>
        public void OutputLetterCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Letter.txt",
                Instances.CharacterOperator.Is_Letter);
        }

        /// <summary>
        /// Outputs lowercase class characters.
        /// </summary>
        public void OutputLowercaseCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Lowercase.txt",
                Instances.CharacterOperator.Is_Lowercase);
        }

        /// <summary>
        /// Outputs number class characters.
        /// </summary>
        public void OutputNumberCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Number.txt",
                Instances.CharacterOperator.Is_Number);
        }

        /// <summary>
        /// Outputs punctuation class characters.
        /// </summary>
        public void OutputPunctuationCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Punctuation.txt",
                Instances.CharacterOperator.Is_Punctuation);
        }

        /// <summary>
        /// Outputs separator class characters.
        /// </summary>
        public void OutputSeparatorCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Separator.txt",
                Instances.CharacterOperator.Is_Separator);
        }

        /// <summary>
        /// Outputs separator class characters.
        /// </summary>
        public void OutputSymbolCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Symbol.txt",
                Instances.CharacterOperator.Is_Symbol);
        }

        /// <summary>
        /// Outputs uppercase class characters.
        /// </summary>
        public void OutputUppercaseCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Uppercase.txt",
                Instances.CharacterOperator.Is_Uppercase);
        }

        /// <summary>
        /// Outputs whitespace class characters.
        /// </summary>
        public void OutputWhitespaceCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Whitespace.txt",
                Instances.CharacterOperator.Is_Whitespace);
        }


        public void OutputCharacterClassFiles()
        {
            this.OutputAllCharacters();
            this.OutputAlphanumericCharacters();
            this.OutputControlCharacters();
            this.OutputDigitCharacters();
            this.OutputLetterCharacters();
            this.OutputLowercaseCharacters();
            this.OutputNumberCharacters();
            this.OutputPunctuationCharacters();
            this.OutputSeparatorCharacters();
            this.OutputSymbolCharacters();
            this.OutputUppercaseCharacters();
            this.OutputWhitespaceCharacters();
        }
    }
}