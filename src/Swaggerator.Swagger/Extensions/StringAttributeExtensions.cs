using System;
using System.Reflection;
using Swaggerator.Swagger.Attributes;

namespace Swaggerator.Swagger.Extensions
{
    public static class StringAttributeExtensions
    {
        public static string GetString(this Enum value)
        {
            var Type = value.GetType();
            var fieldInfo = Type.GetField(value.ToString());

            var stringAttribute = fieldInfo.GetCustomAttribute(typeof(StringAttribute)) as StringAttribute;

            return stringAttribute.StringValue;
        }
    }
}