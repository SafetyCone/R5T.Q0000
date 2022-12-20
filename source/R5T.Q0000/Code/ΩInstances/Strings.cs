using System;


namespace R5T.Q0000
{
	public class Strings : IStrings
	{
		#region Infrastructure

	    public static IStrings Instance { get; } = new Strings();

	    private Strings()
	    {
        }

	    #endregion
	}
}