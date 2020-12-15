namespace DotNet.DesignPattern.Intermediate
{
    using System;

    /// <summary>
    ///     Component1 Class
    /// </summary>
    class Component1 : BaseComponent
    {
        /// <summary>
        ///     Notify A
        /// </summary>
        public void DoA()
        {
            Console.WriteLine(GlobalText.Component1DoesAMessage);

            this._mediator.Notify(this, "A");
        }

        /// <summary>
        ///     Notify B
        /// </summary>
        public void DoB()
        {
            Console.WriteLine(GlobalText.Component1DoesBMessage);

            this._mediator.Notify(this, "B");
        }
    }
}
