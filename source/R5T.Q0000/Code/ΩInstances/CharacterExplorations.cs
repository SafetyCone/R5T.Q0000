using System;


namespace R5T.Q0000
{
	public class CharacterExplorations : ICharacterExplorations
	{
		#region Infrastructure

	    public static CharacterExplorations Instance { get; } = new();

	    private CharacterExplorations()
	    {
	    }

	    #endregion
	}
}