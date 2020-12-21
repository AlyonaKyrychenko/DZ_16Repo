namespace DZ_16
{
    using System;

    /// <summary>
    /// This deligate for multiply two numbers.
    /// </summary>
    /// <param name="firstMultiplier">This fisrt multiplier.</param>
    /// <param name="secondMultiplier">This second multiplier.</param>
    /// <returns>Result of multiply.</returns>
    public delegate int DelegatePow(int firstMultiplier, int secondMultiplier);

    /// <summary>
    /// This id for devide result of multiply on some number.
    /// </summary>
    /// <param name="devider">This is devider.</param>
    /// <returns>Result of devide.</returns>
    public delegate bool DelegateDevide(int devider);

    /// <summary>
    /// This delegate for showing rezult of programm implementation.
    /// </summary>
    /// <param name="res">Result of programm implementation.</param>
    public delegate void DelegateShow(bool res);

    /// <summary>
    /// This is start of the programm.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This is starting method.
        /// </summary>
        /// <param name="args">Some args.</param>
        public static void Main(string[] args)
        {
            var a = new A();
            var b = new B();
            b.ShowHandler = Show;
            b.ShowHandler(a.Calc(b.PowHandler, 2, 3).Invoke(2));
        }

        /// <summary>
        /// This is for showing result.
        /// </summary>
        /// <param name="res">This is for result.</param>
        public static void Show(bool res)
        {
            Console.WriteLine(res.ToString());
        }
    }
}
