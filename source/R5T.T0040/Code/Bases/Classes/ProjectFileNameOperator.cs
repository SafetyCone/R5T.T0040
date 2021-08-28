using System;


namespace R5T.T0040
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ProjectFileNameOperator : IProjectFileNameOperator
    {
        #region Static

        public static ProjectFileNameOperator Instance { get; } = new();

        #endregion
    }
}