using System;

using R5T.F0000;
using R5T.F0002;
using R5T.T0032;


namespace R5T.T0040.X001
{
    public static class Instances
    {
        public static IFileExtension FileExtension { get; } = T0032.FileExtension.Instance;
        public static IFileNameOperator FileNameOperator { get; } = F0000.FileNameOperator.Instance;
        public static IPathOperator PathOperator { get; } = F0002.PathOperator.Instance;
    }
}
