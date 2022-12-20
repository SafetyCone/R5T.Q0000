using System;


namespace R5T.Q0000
{
	public class StringExperiments : IStringExperiments
	{
		#region Infrastructure

	    public static IStringExperiments Instance { get; } = new StringExperiments();

	    private StringExperiments()
	    {
        }

	    #endregion
	}
}