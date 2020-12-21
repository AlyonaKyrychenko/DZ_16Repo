namespace DZ_16
{
    /// <summary>
    /// This is for multiplying.
    /// </summary>
    public class Class1
    {
        private DelegateShow handler = Program.Show;

        /// <summary>
        /// Multiply first with second.
        /// </summary>
        /// <param name="x">First multiplier.</param>
        /// <param name="y">Second multiplier.</param>
        /// <returns>Result of multiply.</returns>
        public static int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
