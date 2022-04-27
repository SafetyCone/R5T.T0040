using System;

using R5T.T0044;


namespace R5T.T0040.X002
{
    public static class Instances
    {
        public static IFileSystemOperator FileSystemOperator { get; } = T0044.FileSystemOperator.Instance;
    }
}
