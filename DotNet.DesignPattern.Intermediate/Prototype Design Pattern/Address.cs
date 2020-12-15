namespace DotNet.DesignPattern.Intermediate
{
    using System;

    /// <summary>
    ///     Address Class
    /// </summary>
    public class Address : ICloneable
    {
        /// <summary>
        ///     Gets or sets State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        ///     Gets or sets City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        ///     Gets or sets Clone
        /// </summary>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
