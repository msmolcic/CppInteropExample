namespace CppInvoker
{
    using System.Runtime.InteropServices;

    public static class Calculator
    {
        private const string CppLibraryName = "Calculator.dll";

        [DllImport(CppLibraryName)]
        private static extern int Sum(int first, int second);

        [DllImport(CppLibraryName)]
        private static extern int Diff(int first, int second);

        [DllImport(CppLibraryName)]
        private static extern int Mult(int first, int second);

        [DllImport(CppLibraryName)]
        private static extern int Div(int first, int second);

        public static int Add(int first, int second) => Sum(first, second);
        public static int Subtract(int first, int second) => Diff(first, second);
        public static int Multiply(int first, int second) => Mult(first, second);
        public static int Divide(int first, int second) => Div(first, second);
    }
}
