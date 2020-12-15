namespace DotNet.DesignPattern.Intermediate
{
    /// <summary>
    ///     Interface ISubject
    /// </summary>
    interface ISubject
    {
        /// <summary>
        ///     Subscribe
        /// </summary>
        /// <param name="observer"></param>
        void Subscribe(ConcreteObserver observer);

        /// <summary>
        ///     Unsubscribe
        /// </summary>
        /// <param name="observer"></param>
        void Unsubscribe(ConcreteObserver observer);

        /// <summary>
        ///     Notify
        /// </summary>
        void Notify();
    }
}
