using System;


namespace R5T.T0040
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SolutionFileNameOperator : ISolutionFileNameOperator
    {
        #region Static

        public static SolutionFileNameOperator Instance { get; } = new();

        #endregion
    }
}