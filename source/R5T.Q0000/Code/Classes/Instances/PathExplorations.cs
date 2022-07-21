using System;


namespace R5T.Q0000
{
	public class PathExplorations : IPathExplorations
	{
		#region Infrastructure

	    public static PathExplorations Instance { get; } = new();

	    private PathExplorations()
	    {
        }

	    #endregion
	}
}