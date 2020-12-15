namespace DotNet.DesignPattern.Intermediate
{
    using System;

    /// <summary>
    ///     ConcreteObserver Class
    /// </summary>
    public class ConcreteObserver : IObserver
    {
        /// <summary>
        ///     Gets or sets ObserverName
        /// </summary>
        public string ObserverName { get; private set; }

        /// <summary>
        ///     Parametrized Constructior ConcreteObserver
        /// </summary>
        /// <param name="name"></param>
        public ConcreteObserver(string name)
        {
            this.ObserverName = name;
        }

        /// <summary>
        ///     Update Method
        /// </summary>
        public void Update()
        {
            Console.WriteLine(GlobalText.NewProductArriveText, this.ObserverName);
        }
    }
}
