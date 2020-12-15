namespace DotNet.DesignPattern.Intermediate
{
    using System.Collections.Generic;

    /// <summary>
    ///     Adapter Class
    /// </summary>
    public class Adapter : Adaptee, ITarget
    {
        /// <summary>
        ///     GetProducts
        /// </summary>
        /// <returns></returns>
        public List<string> GetProducts()
        {
            return GetListOfProducts();
        }
    }
}
