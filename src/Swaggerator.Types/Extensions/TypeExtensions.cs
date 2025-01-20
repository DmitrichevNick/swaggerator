using System;
using System.Collections.Generic;
using System.Linq;

namespace Swaggerator.Types.Extensions
{
    /// <summary>
    ///     Extension methods for Type
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        ///     Simple types
        /// </summary>
        private static readonly IReadOnlyList<Type> SimpleTypes = new List<Type>
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

        /// <summary>
        ///     Is Type simple?
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>Result of check</returns>
        public static bool IsSimple(this Type type)
        {
            return SimpleTypes.Contains(type);
        }
    }
}