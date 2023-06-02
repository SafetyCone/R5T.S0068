using System;

using R5T.T0132;


namespace R5T.S0068
{
    [FunctionalityMarker]
    public partial interface ISolutionDescriptorScripts : IFunctionalityMarker
    {
        public void Get_DefaultProjectName()
        {
            /// Inputs.
            var solutionName = Instances.Values.Sample_SolutionName;


            /// Run.
            var projectName = Instances.ProjectNameOperator.Get_DefaultProjectName(solutionName);

            Console.WriteLine($"{projectName}: default project name for solution name '{solutionName}'.");
        }
    }
}
