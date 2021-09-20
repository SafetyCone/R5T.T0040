using System;

using R5T.T0040;

using Instances = R5T.T0040.X000.Instances;


namespace System
{
    public static class IProjectFileNameOperatorExtensions
    {
        public static string GetProjectFileNameStem(this IProjectFileNameOperator _,
            string projectName)
        {
            Instances.PathOperator.VerifyNoInvalidPathCharacters(projectName);

            // Just use the project name as the project file name stem.
            var output = projectName;
            return output;
        }

        public static string GetProjectFileName(this IProjectFileNameOperator _,
            string projectName)
        {
            var projectFileNameStem = _.GetProjectFileNameStem(projectName);

            var output = Instances.FileNameOperator.GetFileName(projectFileNameStem, Instances.FileExtension.CSharpProjectFile());
            return output;
        }

        public static string GetProjectNameFromProjectFileName(this IProjectFileNameOperator _,
            string projectFileName)
        {
            var projectFileNameStem = Instances.FileNameOperator.GetFileNameStemFromFileName(projectFileName);

            // The project name is just the project file name stem.
            var output = projectFileNameStem;
            return output;
        }
    }
}
