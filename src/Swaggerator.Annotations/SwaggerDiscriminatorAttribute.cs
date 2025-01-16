using System;

namespace Swaggerator.Annotations
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
    public class SwaggerDiscriminatorAttribute : Attribute
    {
        public SwaggerDiscriminatorAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }

        public string PropertyName { get; set; }
    }
}