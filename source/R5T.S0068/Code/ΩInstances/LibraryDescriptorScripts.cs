using System;


namespace R5T.S0068
{
    public class LibraryDescriptorScripts : ILibraryDescriptorScripts
    {
        #region Infrastructure

        public static ILibraryDescriptorScripts Instance { get; } = new LibraryDescriptorScripts();


        private LibraryDescriptorScripts()
        {
        }

        #endregion
    }
}
