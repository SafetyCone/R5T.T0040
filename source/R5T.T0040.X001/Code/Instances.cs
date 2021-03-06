using System;

using R5T.T0032;
using R5T.T0041;


namespace R5T.T0040.X001
{
    public static class Instances
    {
        public static IFileExtension FileExtension { get; } = T0032.FileExtension.Instance;
        public static IFileNameOperator FileNameOperator { get; } = T0041.FileNameOperator.Instance;
        public static IPathOperator PathOperator { get; } = T0041.PathOperator.Instance;
    }
}
