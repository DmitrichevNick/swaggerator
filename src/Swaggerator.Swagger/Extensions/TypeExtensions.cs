using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;

using Swaggerator.Types.Enums;
using Swaggerator.Types.Extensions;

namespace Swaggerator.Swagger.Extensions
{
    /// <summary>
    ///     Extensions of Type
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        ///     Type is enumerable
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>Is Type enumerable</returns>
        public static bool IsEnumerable(this Type type)
        {
            return type is IEnumerable;
        }

        /// <summary>
        ///     Get PropertyInfo list of properties of Type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>List of PropertyInfo</returns>
        public static IList<PropertyInfo> GetPropertiesPropertyInfoList(this Type type)
        {
            return type.GetProperties().ToList();
        }

        /// <summary>
        ///     Get PropertyInfo list of public and not ignored properties of Type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>List of PropertyInfo</returns>
        public static IList<PropertyInfo> GetPublicPropertiesInfoList(this Type type)
        {
            return type.GetProperties(BindingFlags.Public)
                .Where(propertyInfo => propertyInfo.GetCustomAttribute<JsonIgnoreAttribute>() == null)
                .ToList();
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

        /// <summary>
        ///     Get Swagger DataType and default format for type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns><Swagger DataType and default format/returns>
        public static Tuple<DataType, string> GetSwaggerDataTypeAndFormat(this Type type)
        {
            return PrimitiveTypesAndFormats[type];
        }

        public static IList<Type> GetCompositeTypes(this Type type)
        {
            var compositeTypes = new List<Type> { type };

            var childCompositeTypes = type.GetPublicPropertiesInfoList()
                .Where(propertyInfo => !propertyInfo.PropertyType.IsSimple() && !propertyInfo.PropertyType.IsEnumerable())
                .Select(propertyInfo => propertyInfo.PropertyType)
                .Distinct()
                .SelectMany(childType =>
                    compositeTypes.Contains(childType)
                    ? new List<Type>()
                    : GetCompositeTypes(childType))
                .ToList();

            compositeTypes.AddRange(childCompositeTypes);

            return compositeTypes.Distinct().ToList();
        }
    }
}