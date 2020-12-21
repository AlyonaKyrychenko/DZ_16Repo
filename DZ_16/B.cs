namespace DZ_16
{
    /// <summary>
    /// This is for calculation multiply and devide.
    /// </summary>
    public class B
    {
        /// <summary>
        /// This is for showing result.
        /// </summary>
        public DelegateShow ShowHandler;

        /// <summary>
        /// This is for multiplying two numbers.
        /// </summary>
        public DelegatePow PowHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="B"/> class.
        /// </summary>
        public B()
        {
            this.PowHandler = Pow;
        }

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
