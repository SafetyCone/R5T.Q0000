using System;


namespace R5T.Q0000
{
	public class EnumerableExperiments : IEnumerableExperiments
	{
		#region Infrastructure

	    public static IEnumerableExperiments Instance { get; } = new EnumerableExperiments();

	    private EnumerableExperiments()
	    {
        }

	    #endregion
	}
}