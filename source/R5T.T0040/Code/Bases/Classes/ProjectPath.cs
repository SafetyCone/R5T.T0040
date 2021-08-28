using System;


namespace R5T.T0040
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ProjectPath : IProjectPath
    {
        #region Static

        public static ProjectPath Instance { get; } = new();

        #endregion
    }
}