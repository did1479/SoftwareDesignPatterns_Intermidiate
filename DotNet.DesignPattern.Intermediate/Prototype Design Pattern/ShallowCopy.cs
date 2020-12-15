using System;

namespace DotNet.DesignPattern.Intermediate
{
    public class Employee_ShallowCopy : ICloneable
    {
        /// <summary>
        ///     Gets or sets Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets Age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        ///     Gets or sets EmploymentType
        /// </summary>
        public string EmploymentType { get; set; }

        /// <summary>
        ///     Gets or sets Address
        /// </summary>
        public Address_New Address { get; set; }

        /// <summary>
        ///     Clone
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone() as Employee_ShallowCopy;
        }
    }
}
