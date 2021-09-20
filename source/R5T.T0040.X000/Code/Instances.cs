using System;
using System.Threading.Tasks;

using R5T.T0032;
using R5T.T0041;


namespace R5T.T0040.X000
{
    public static class Instances
    {
        public static IFileExtension FileExtension { get; } = T0032.FileExtension.Instance;
        public static IFileNameOperator FileNameOperator { get; } = T0041.FileNameOperator.Instance;
        public static IPathOperator PathOperator { get; } = T0041.PathOperator.Instance;
        public static IProjectFileNameOperator ProjectFileNameOperator { get; } = T0040.ProjectFileNameOperator.Instance;
    }
}
