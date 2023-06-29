using System;


namespace R5T.S0068
{
    public static class Instances
    {
        public static F0134.ILibraryNameOperator LibraryNameOperator => F0134.LibraryNameOperator.Instance;
        public static IOperations Operations => S0068.Operations.Instance;
        public static F0127.IProjectNameOperator ProjectNameOperator => F0127.ProjectNameOperator.Instance;
        public static L0044.O001.IProjectNameOperations ProjectNameOperations => L0044.O001.ProjectNameOperations.Instance;
        public static Z0046.IValues Values => Z0046.Values.Instance;
    }
}