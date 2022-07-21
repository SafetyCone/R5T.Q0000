using System;


namespace R5T.Q0000
{
	public class PathDemonstrations : IPathDemonstrations
	{
		#region Infrastructure

	    public static PathDemonstrations Instance { get; } = new();

	    private PathDemonstrations()
	    {
        }

	    #endregion
	}
}