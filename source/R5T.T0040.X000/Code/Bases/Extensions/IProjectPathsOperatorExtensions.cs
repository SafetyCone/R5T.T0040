using System;

using R5T.T0040;

using Instances = R5T.T0040.X000.Instances;


namespace System
{
    public static class IProjectPathsOperatorExtensions
    {
        public static string GetProjectDirectoryName(this IProjectPathsOperator _,
            string projectName)
        {
            Instances.PathOperator.VerifyNoInvalidPathCharacters(projectName);

            // After checking, just use the project name as the project directory name.
            var output = projectName;
            return output;
        }

        public static string GetProjectDirectoryPath(this IProjectPathsOperator _,
            string parentDirectoryPath,
            string projectName)
        {
            var projectDirectoryName = _.GetProjectDirectoryName(projectName);

            var output = Instances.PathOperator.AppendDirectoryRelativePathToDirectoryPath(parentDirectoryPath, projectDirectoryName);
            return output;
        }

        public static string GetProjectDirectoryPath(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var output = Instances.PathOperator.GetDirectoryPathOfFilePath(projectFilePath);
            return output;
        }

        public static string GetProjectFilePath(this IProjectPathsOperator _,
            string projectDirectoryPath,
            string projectName)
        {
            var projectFileName = Instances.ProjectFileNameOperator.GetProjectFileName(projectName);

            var output = Instances.PathOperator.GetFilePath(projectDirectoryPath, projectFileName);
            return output;
        }

        public static string GetProjectName(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var projectFileName = Instances.PathOperator.GetFileNameForFilePath(projectFilePath);

            var output = Instances.ProjectFileNameOperator.GetProjectNameFromProjectFileName(projectFileName);
            return output;
        }
    }
}