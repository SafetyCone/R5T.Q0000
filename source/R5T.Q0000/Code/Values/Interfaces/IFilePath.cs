using System;

using R5T.T0131;


namespace R5T.Q0000
{
    [ValuesMarker]
    public interface IFilePath : IValuesMarker
    {
        public string TempOutputTextFile => @"C:\Temp\Output.txt";
    }
}
