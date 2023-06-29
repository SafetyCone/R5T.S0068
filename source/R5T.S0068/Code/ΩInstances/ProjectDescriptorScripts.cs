using System;


namespace R5T.S0068
{
    public class ProjectDescriptorScripts : IProjectDescriptorScripts
    {
        #region Infrastructure

        public static IProjectDescriptorScripts Instance { get; } = new ProjectDescriptorScripts();


        private ProjectDescriptorScripts()
        {
        }

        #endregion
    }
}
