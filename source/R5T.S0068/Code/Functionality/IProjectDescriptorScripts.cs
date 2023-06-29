using System;

using R5T.T0132;


namespace R5T.S0068
{
    [FunctionalityMarker]
    public partial interface IProjectDescriptorScripts : IFunctionalityMarker
    {
        /// <inheritdoc cref="Get_ConstructionServerProjectName"/>
        public void Get_ConstructionClientProjectName()
        {
            /// Inputs.
            var baseProjectName = Instances.Values.Sample_ProjectName;


            /// Run.
            var constructionProjectname = Instances.ProjectNameOperations.Get_ConstructionClientProjectName(baseProjectName);

            Instances.Operations.Write_ModifiedProjectNames_ToConsole(
                baseProjectName,
                constructionProjectname);
        }

        /// <summary>
        /// Web libraries have construction projects, but both server and client construction projects are needed.
        /// </summary>
        public void Get_ConstructionServerProjectName()
        {
            /// Inputs.
            var baseProjectName = Instances.Values.Sample_ProjectName;


            /// Run.
            var constructionProjectname = Instances.ProjectNameOperations.Get_ConstructionServerProjectName(baseProjectName);

            Instances.Operations.Write_ModifiedProjectNames_ToConsole(
                baseProjectName,
                constructionProjectname);
        }

        /// <summary>
        /// Libraries have construction projects.
        /// </summary>
        public void Get_ConstructionProjectName()
        {
            /// Inputs.
            var baseProjectName = Instances.Values.Sample_ProjectName;


            /// Run.
            var constructionProjectname = Instances.ProjectNameOperations.Get_ConstructionProjectName(baseProjectName);

            Instances.Operations.Write_Get_ConstructionProjectName_ToConsole(
                baseProjectName,
                constructionProjectname);
        }
    }
}
