namespace DotNet.DesignPattern.Intermediate
{
    using System.Collections.Generic;

    /// <summary>
    ///     Adaptee Class
    /// </summary>
    public class Adaptee
    {
        /// <summary>
        ///     Get List Of Products
        /// </summary>
        /// <returns></returns>
        public List<string> GetListOfProducts()
        {
            List<string> products = new List<string>();
            products.Add("Mobiles");
            products.Add("Television");
            products.Add("Books");
            products.Add("Musical Instruments");
            return products;
        }
    }
}
