namespace DotNet.DesignPattern.Intermediate
{
    using System;

    /// <summary>
    /// Employee Deep Copy Class
    /// </summary>
    public class Employee_DeepCopy : ICloneable
    {
        /// <summary>
        ///     Gets or set Name
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
        public Address Address { get; set; }

        /// <summary>
        ///     Clone
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            Employee_DeepCopy employee = this.MemberwiseClone() as Employee_DeepCopy;
            // Deep Copy
            employee.Address = this.Address.Clone() as Address;
            return employee;
        }
    }
}
