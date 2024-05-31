using System;

using R5T.F0000;
using R5T.F0002;


namespace R5T.T0040.X001
{
    public static class Instances
    {
        public static Z0072.Z002.IFileExtensions FileExtensions => Z0072.Z002.FileExtensions.Instance;
        public static IFileNameOperator FileNameOperator { get; } = F0000.FileNameOperator.Instance;
        public static F0002.IPathOperator PathOperator { get; } = F0002.PathOperator.Instance;
    }
}
