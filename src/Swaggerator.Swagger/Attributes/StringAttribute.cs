using System;

namespace Swaggerator.Swagger.Attributes
{
    /// <summary>
    ///     Attribute that allow define string value of enum element
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field, AllowMultiple = false)]
    public class StringAttribute : Attribute
    {
        /// <summary>
        ///     Constructor with value
        /// </summary>
        /// <param name="stringValue">String value of enum element</param>
        public StringAttribute(string stringValue)
        {
            StringValue = stringValue;
        }

        /// <summary>
        ///     String value of enum element
        /// </summary>
        public string StringValue { get; set; }
    }
}