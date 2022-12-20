using System;

using R5T.T0131;


namespace R5T.Q0000
{
	[ValuesMarker]
	public partial interface IStrings : IValuesMarker,
		Z0000.IStrings
	{
		public string OfLengthOne => this.A_Uppercase;
	}
}