namespace DZ_16
{
    /// <summary>
    /// This is for calculation multiply and devide.
    /// </summary>
    public class Class2
    {
        private int rez;

        /// <summary>
        /// This is for calculation multiply and calling devide method.
        /// </summary>
        /// <param name="dl">This is for multiplication delegate variable.</param>
        /// <param name="firstMultiplyer">This is for first multiplyer.</param>
        /// <param name="secondMultiplyer">This is for second multiplyer.</param>
        /// <returns>Result of implementation Result method.</returns>
        public DelegateDevide Calc(DelegatePow dl, int firstMultiplyer, int secondMultiplyer)
        {
            this.rez = dl.Invoke(firstMultiplyer, secondMultiplyer);
            DelegateDevide delRez = this.Result;
            return delRez;
        }

        /// <summary>
        /// This is for devide number obtained after multiplication on some other number.
        /// </summary>
        /// <param name="devider">This is for devider.</param>
        /// <returns>Result of devide.</returns>
        public bool Result(int devider)
        {
            decimal ost = this.rez % devider;
            return ost == 0;
        }
    }
}
