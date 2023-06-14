using System;


namespace R5T.Q0000
{
    /// <summary>
    /// Showcases the best way to define a flags enumeration.
    /// </summary>
    [Flags]
    public enum RandomFlags
    {
        /// <summary>
        /// Note: There is no way to test if a flag set has the zero value (since anything bit-wise-anded with zero will always equal zero).
        /// When it comes to flags, none truly means none.
        /// </summary>
        None = 0,

        First = 1 << 0, // i.e. 1
        Second = 1 << 1, // i.e. 2
        Third = 1 << 2, // i.e. 4
        Fourth = 1 << 3, // i.e. 8
    }
}
