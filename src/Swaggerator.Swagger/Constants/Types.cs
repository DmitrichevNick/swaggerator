using System;
using System.Collections.Generic;

namespace Swaggerator.Swagger.Constants
{
    /// <summary>
    ///     Constants of types
    /// </summary>
    public static class Types
    {
        /// <summary>
        ///     Simple types
        /// </summary>
        public static readonly IReadOnlyList<Type> SimpleTypes = new List<Type>
        {
            typeof(bool),
            typeof(short),
            typeof(ushort),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
            typeof(float),
            typeof(double),
            typeof(decimal),
            typeof(string),
            typeof(DateTime),
            typeof(TimeSpan)
        };
    }
}