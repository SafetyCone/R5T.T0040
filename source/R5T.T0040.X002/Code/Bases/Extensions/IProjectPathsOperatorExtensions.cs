using System;
using System.Collections.Generic;

using R5T.T0040;

using Instances = R5T.T0040.X002.Instances;


namespace System
{
    public static class IProjectPathsOperatorExtensions
    {
        public static IEnumerable<string> FindProjectFilesInDirectoryOrDirectParentDirectories(this IProjectPathsOperator _,
            string directoryPath)
        {
            var output = Instances.FileSystemOperator.FindProjectFilesInDirectoryOrDirectParentDirectories(
                directoryPath);

            return output;
        }

        public static IEnumerable<string> FindProjectFilesInFileDirectoryOrDirectParentDirectories(this IProjectPathsOperator _,
            string filePath)
        {
            var output = Instances.FileSystemOperator.FindProjectFilesInFileDirectoryOrDirectParentDirectories(
                filePath);

            return output;
        }
    }
}