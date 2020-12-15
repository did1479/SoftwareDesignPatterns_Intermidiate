namespace DotNet.DesignPattern.Intermediate
{
    using System;

    /// <summary>
    ///     Component2 Class
    /// </summary>
    class Component2 : BaseComponent
    {
        /// <summary>
        ///     Notify C
        /// </summary>
        public void DoC()
        {
            Console.WriteLine(GlobalText.Component2DoesCMessage);

            this._mediator.Notify(this, "C");
        }

        /// <summary>
        ///     Notify D
        /// </summary>
        public void DoD()
        {
            Console.WriteLine(GlobalText.Component2DoesDMessage);

            this._mediator.Notify(this, "D");
        }
    }
}
