using System;

using R5T.Lombardy;

using R5T.T0040;

using Instances = R5T.T0040.X001.Instances;


namespace System
{
    public static class IProjectPathsOperatorExtensions
    {
        public static string GetFilePathFromProjectDirectoryRelativePathUsingProjectDirectoryPath(this IProjectPathsOperator _,
            string projectDirectoryPath,
            string fileProjectDirectoryRelativePath)
        {
            var output = Instances.PathOperator.GetFilePath(
                projectDirectoryPath,
                fileProjectDirectoryRelativePath);

            return output;
        }

        public static string GetFilePathFromProjectDirectoryRelativePathUsingProjectFilePath(this IProjectPathsOperator _,
            string projectFilePath,
            string fileProjectDirectoryRelativePath)
        {
            var projectDirectoryPath = _.GetProjectDirectoryPath(projectFilePath);

            var output = _.GetFilePathFromProjectDirectoryRelativePathUsingProjectDirectoryPath(
                projectDirectoryPath,
                fileProjectDirectoryRelativePath);

            return output;
        }

        /// <summary>
        /// Chooses <see cref="GetFilePathFromProjectDirectoryRelativePathUsingProjectFilePath(IProjectPathsOperator, string, string)"/> as the default.
        /// </summary>
        public static string GetFilePathFromProjectDirectoryRelativePath(this IProjectPathsOperator _,
            string projectFilePath,
            string fileProjectDirectoryRelativePath)
        {
            var output = _.GetFilePathFromProjectDirectoryRelativePathUsingProjectFilePath(
                projectFilePath,
                fileProjectDirectoryRelativePath);

            return output;
        }

        public static string GetProjectDirectoryPath(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var output = Instances.PathOperator.GetParentDirectoryPath_ForFile(projectFilePath);
            return output;
        }

        public static string GetProjectDirectoryRelativeFilePath(this IProjectPathsOperator _,
            string projectFilePath,
            string filePath,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            var projectDirectoryPath = _.GetProjectDirectoryPath(projectFilePath);

            var output = stringlyTypedPathOperator.GetRelativePathDirectoryToFile(
                projectDirectoryPath,
                filePath);

            return output;
        }
    }
}
