using System;
using System.Collections.Generic;

using R5T.T0040;

using Instances = R5T.T0040.X002.Instances;


namespace System
{
    public static class ISolutionPathsOperatorExtensions
    {
        public static IEnumerable<string> FindSolutionFilesInDirectoryOrDirectParentDirectories(this ISolutionPathsOperator _,
            string directoryPath)
        {
            var output = Instances.FileSystemOperator.FindSolutionFilesInDirectoryOrDirectParentDirectories(
                directoryPath);

            return output;
        }

        public static IEnumerable<string> FindSolutionFilesInFileDirectoryOrDirectParentDirectories(this ISolutionPathsOperator _,
            string filePath)
        {
            var output = Instances.FileSystemOperator.FindSolutionFilesInFileDirectoryOrDirectParentDirectories(
                filePath);

            return output;
        }
    }
}
