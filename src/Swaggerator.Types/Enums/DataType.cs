using System;

using Swaggerator.Types.Attributes;

namespace Swaggerator.Types.Enums
{
    /// <summary>
    ///     Swagger DataTypes
    /// </summary>
    [Flags]
    public enum DataType
    {
        [String("string")]
        String = 0,

        [String("number")]
        Number = 1 << 0,

        [String("integer")]
        Integer = 1 << 1,

        [String("boolean")]
        Boolean = 1 << 2,

        [String("array")]
        Array = 1 << 3,

        [String("object")]
        Object = 1 << 4
    }
}