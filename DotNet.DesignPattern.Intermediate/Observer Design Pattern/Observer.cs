namespace DotNet.DesignPattern.Intermediate
{
    using System.Collections.Generic;

    /// <summary>
    ///     ConcreteSubject Class
    /// </summary>
    public class ConcreteSubject : ISubject
    {
        private List<ConcreteObserver> observers = new List<ConcreteObserver>();

        private int _int;

        /// <summary>
        ///     Gets or sets Inventory
        /// </summary>
        public int Inventory
        {
            get
            {
                return _int;
            }
            set
            {
                if (value > _int)
                    Notify();
                _int = value;
            }
        }

        /// <summary>
        ///     Subscribe
        /// </summary>
        /// <param name="observer"></param>
        public void Subscribe(ConcreteObserver observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        ///     Unsubscribe
        /// </summary>
        /// <param name="observer"></param>
        public void Unsubscribe(ConcreteObserver observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        ///     Notify
        /// </summary>
        public void Notify()
        {
            observers.ForEach(x => x.Update());
        }
    }
}
