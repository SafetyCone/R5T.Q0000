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
                Instances.CharacterOperator.IsCharacter);
        }

        /// <summary>
        /// Outputs alphanumeric (letter-or-digit) class characters.
        /// </summary>
        public void OutputAlphanumericCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Alphanumeric.txt",
                Instances.CharacterOperator.IsAlphanumeric);
        }

        /// <summary>
        /// Outputs control class characters.
        /// </summary>
        public void OutputControlCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Control.txt",
                Instances.CharacterOperator.IsControl);
        }

        /// <summary>
        /// Outputs digit class characters.
        /// </summary>
        public void OutputDigitCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Digit.txt",
                Instances.CharacterOperator.IsDigit);
        }

        /// <summary>
        /// Outputs letter class characters.
        /// </summary>
        public void OutputLetterCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Letter.txt",
                Instances.CharacterOperator.IsLetter);
        }

        /// <summary>
        /// Outputs lowercase class characters.
        /// </summary>
        public void OutputLowercaseCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Lowercase.txt",
                Instances.CharacterOperator.IsLowercase);
        }

        /// <summary>
        /// Outputs number class characters.
        /// </summary>
        public void OutputNumberCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Number.txt",
                Instances.CharacterOperator.IsNumber);
        }

        /// <summary>
        /// Outputs punctuation class characters.
        /// </summary>
        public void OutputPunctuationCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Punctuation.txt",
                Instances.CharacterOperator.IsPunctuation);
        }

        /// <summary>
        /// Outputs separator class characters.
        /// </summary>
        public void OutputSeparatorCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Separator.txt",
                Instances.CharacterOperator.IsSeparator);
        }

        /// <summary>
        /// Outputs separator class characters.
        /// </summary>
        public void OutputSymbolCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Symbol.txt",
                Instances.CharacterOperator.IsSymbol);
        }

        /// <summary>
        /// Outputs uppercase class characters.
        /// </summary>
        public void OutputUppercaseCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Uppercase.txt",
                Instances.CharacterOperator.IsUppercase);
        }

        /// <summary>
        /// Outputs whitespace class characters.
        /// </summary>
        public void OutputWhitespaceCharacters()
        {
            Instances.CharacterOperator.OutputCharactersWhere(
                @"Characters-Whitespace.txt",
                Instances.CharacterOperator.IsWhitespace);
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