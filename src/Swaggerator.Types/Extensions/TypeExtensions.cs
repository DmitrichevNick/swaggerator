using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Swaggerator.Types.Enums;

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
        private static readonly Dictionary<Type, Tuple<DataType, string>> PrimitiveTypesAndFormats
              = new Dictionary<Type, Tuple<DataType, string>>
              {
                  [typeof(bool)] = Tuple.Create(DataType.Boolean, (string)null),
                  [typeof(byte)] = Tuple.Create(DataType.Integer, "int32"),
                  [typeof(sbyte)] = Tuple.Create(DataType.Integer, "int32"),
                  [typeof(short)] = Tuple.Create(DataType.Integer, "int32"),
                  [typeof(ushort)] = Tuple.Create(DataType.Integer, "int32"),
                  [typeof(int)] = Tuple.Create(DataType.Integer, "int32"),
                  [typeof(uint)] = Tuple.Create(DataType.Integer, "int32"),
                  [typeof(long)] = Tuple.Create(DataType.Integer, "int64"),
                  [typeof(ulong)] = Tuple.Create(DataType.Integer, "int64"),
                  [typeof(float)] = Tuple.Create(DataType.Number, "float"),
                  [typeof(double)] = Tuple.Create(DataType.Number, "double"),
                  [typeof(decimal)] = Tuple.Create(DataType.Number, "double"),
                  [typeof(byte[])] = Tuple.Create(DataType.String, "byte"),
                  [typeof(string)] = Tuple.Create(DataType.String, (string)null),
                  [typeof(char)] = Tuple.Create(DataType.String, (string)null),
                  [typeof(DateTime)] = Tuple.Create(DataType.String, "date-time"),
                  [typeof(DateTimeOffset)] = Tuple.Create(DataType.String, "date-time"),
                  [typeof(TimeSpan)] = Tuple.Create(DataType.String, "date-span"),
                  [typeof(Guid)] = Tuple.Create(DataType.String, "uuid"),
                  [typeof(Uri)] = Tuple.Create(DataType.String, "uri"),
                  [typeof(Version)] = Tuple.Create(DataType.String, (string)null),
#if NET6_0_OR_GREATER
            [typeof(DateOnly)] = Tuple.Create(DataType.String, "date"),
            [typeof(TimeOnly)] = Tuple.Create(DataType.String, "time"),
#endif
#if NET7_0_OR_GREATER
            [ typeof(Int128) ] = Tuple.Create(DataType.Integer, "int128"),
            [ typeof(UInt128) ] = Tuple.Create(DataType.Integer, "int128"),
#endif
              };

        public static string GetDefaultFormat(this Type type)
        {
            var tuple = PrimitiveTypesAndFormats[type];

            return tuple.Item2;
        }

        public static DataType GetDataType(this Type type)
        {
            if (type == typeof(bool))
                return DataType.Boolean;

            if (type == typeof(byte)
                || type == typeof(sbyte)
                || type == typeof(short)
                || type == typeof(ushort)
                || type == typeof(int)
                || type == typeof(uint)
                || type == typeof(long)
                || type == typeof(ulong)
#if NET7_0_OR_GREATER
                || type == typeof(Int128)
                || type == typeof(UInt128)
#endif
                )
                return DataType.Integer;

            if (type == typeof(float)
                || type == typeof(double)
                || type == typeof(decimal))
                return DataType.Number;

            if (type == typeof(byte[])
                || type == typeof(string)
                || type == typeof(char)
                || type == typeof(DateTime)
                || type == typeof(DateTimeOffset)
                || type == typeof(TimeSpan)
                || type == typeof(Guid)
                || type == typeof(Uri)
                || type == typeof(Version)
#if NET6_0_OR_GREATER
                || type == typeof(DateOnly)
                || type == typeof(TimeOnly)
#endif
                )
                return DataType.String;

            if (type is IEnumerable)
                return DataType.Array;

            if (type is object)
                return DataType.Object;

            throw new ArgumentException($"Converter cannot detect DataType for Type {type}");
        }
    }
}