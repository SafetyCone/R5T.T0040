using System;


namespace R5T.T0040
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ProjectPathsOperator : IProjectPathsOperator
    {
        #region Static

        public static ProjectPathsOperator Instance { get; } = new();

        #endregion
    }
}