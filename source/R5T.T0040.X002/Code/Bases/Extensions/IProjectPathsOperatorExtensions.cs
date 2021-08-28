using System;

using R5T.T0040;
using R5T.T0040.X002;


namespace System
{
    public static class IProjectPathsOperatorExtensions
    {
        public static string GetProjectDirectoryPath(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var projectDirectoryPath = Instances.PathOperator.GetDirectoryPathOfFilePath(projectFilePath);
            return projectDirectoryPath;
        }

        public static string GetCodeDirectoryPath(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var projectDirectoryPath = _.GetProjectDirectoryPath(projectFilePath);

            var codeDirectoryPath = Instances.PathOperator.AppendDirectoryNameToDirectoryPath(
                projectDirectoryPath,
                Instances.CodeDirectoryName.Code());

            return codeDirectoryPath;
        }

        public static string GetBasesDirectoryPath(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var codeDirectoryPath = _.GetCodeDirectoryPath(projectFilePath);

            var basesDirectoryPath = Instances.PathOperator.AppendDirectoryNameToDirectoryPath(
                codeDirectoryPath,
                Instances.CodeDirectoryName.Bases());

            return basesDirectoryPath;
        }

        public static string GetBasesInterfacesDirectoryPath(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var basesDirectoryPath = _.GetBasesDirectoryPath(projectFilePath);

            var basesInterfacesDirectoryPath = Instances.PathOperator.AppendDirectoryNameToDirectoryPath(
                basesDirectoryPath,
                Instances.CodeDirectoryName.Interfaces());

            return basesInterfacesDirectoryPath;
        }

        public static string GetInterfacesDirectoryPath(this IProjectPathsOperator _,
            string projectFilePath)
        {
            var codeDirectoryPath = _.GetCodeDirectoryPath(projectFilePath);

            var interfacesDirectoryPath = Instances.PathOperator.AppendDirectoryNameToDirectoryPath(
                codeDirectoryPath,
                Instances.CodeDirectoryName.Interfaces());

            return interfacesDirectoryPath;
        }
    }
}
