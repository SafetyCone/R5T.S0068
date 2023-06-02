using System;

using R5T.T0132;


namespace R5T.S0068
{
    [FunctionalityMarker]
    public partial interface ILibraryDescriptorScripts : IFunctionalityMarker
    {
        public void Get_DefaultSolutionName()
        {
            /// Inputs.
            var libraryName =
                Instances.Values.Sample_LibraryName
                ;


            /// Run.
            var solutionName = Instances.LibraryNameOperator.Get_DefaultSolutionName(libraryName);

            Console.WriteLine($"{solutionName}: default solution name for library name '{libraryName}'.");
        }
    }
}
