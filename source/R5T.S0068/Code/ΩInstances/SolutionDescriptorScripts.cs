using System;


namespace R5T.S0068
{
    public class SolutionDescriptorScripts : ISolutionDescriptorScripts
    {
        #region Infrastructure

        public static ISolutionDescriptorScripts Instance { get; } = new SolutionDescriptorScripts();


        private SolutionDescriptorScripts()
        {
        }

        #endregion
    }
}
