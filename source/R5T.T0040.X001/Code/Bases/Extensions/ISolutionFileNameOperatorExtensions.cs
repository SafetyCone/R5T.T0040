using System;

using R5T.T0040;

using Instances = R5T.T0040.X001.Instances;


namespace System
{
    public static class ISolutionFileNameOperatorExtensions
    {
        public static string GetSolutionFileNameStem(this ISolutionFileNameOperator _,
            string solutionName)
        {
            Instances.PathOperator.Verify_NoInvalidPathCharacters(solutionName);

            // Just use the solution name as the solution file name stem.
            var output = solutionName;
            return output;
        }

        public static string GetSolutionFileName(this ISolutionFileNameOperator _,
            string solutionName)
        {
            var solutionFileNameStem = _.GetSolutionFileNameStem(solutionName);

            var output = Instances.FileNameOperator.Get_FileName(solutionFileNameStem, Instances.FileExtension.Solution());
            return output;
        }

        public static string GetSolutionNameFromSolutionFileName(this ISolutionFileNameOperator _,
            string solutionFileName)
        {
            var solutionFileNameStem = Instances.FileNameOperator.Get_FileNameStem(solutionFileName);

            // The solution name is just the solution file name stem.
            var output = solutionFileNameStem;
            return output;
        }
    }
}