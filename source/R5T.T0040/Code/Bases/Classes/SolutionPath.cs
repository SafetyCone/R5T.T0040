using System;


namespace R5T.T0040
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SolutionPath : ISolutionPath
    {
        #region Static

        public static SolutionPath Instance { get; } = new();

        #endregion
    }
}