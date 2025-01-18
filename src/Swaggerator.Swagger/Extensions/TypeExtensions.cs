using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using Swaggerator.Swagger.Constants;
using Swaggerator.Swagger.Enums;

namespace Swaggerator.Swagger.Extensions
{
    /// <summary>
    ///     Extensions of Type
    /// </summary>
    public static class TypeExtensions
    {
        /// <summary>
        ///     Type is simple
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>Is Type simple?</returns>
        public static bool IsSimple(this Type type)
        {
            return Types.SimpleTypes.Contains(type);
        }

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

        private static readonly Dictionary<Type, Tuple<SwaggerDataTypes, string>> PrimitiveTypesAndFormats
      = new Dictionary<Type, Tuple<SwaggerDataTypes, string>>
      {
          [typeof(bool)] = Tuple.Create(SwaggerDataTypes.Boolean, (string)null),
          [typeof(byte)] = Tuple.Create(SwaggerDataTypes.Integer, "int32"),
          [typeof(sbyte)] = Tuple.Create(SwaggerDataTypes.Integer, "int32"),
          [typeof(short)] = Tuple.Create(SwaggerDataTypes.Integer, "int32"),
          [typeof(ushort)] = Tuple.Create(SwaggerDataTypes.Integer, "int32"),
          [typeof(int)] = Tuple.Create(SwaggerDataTypes.Integer, "int32"),
          [typeof(uint)] = Tuple.Create(SwaggerDataTypes.Integer, "int32"),
          [typeof(long)] = Tuple.Create(SwaggerDataTypes.Integer, "int64"),
          [typeof(ulong)] = Tuple.Create(SwaggerDataTypes.Integer, "int64"),
          [typeof(float)] = Tuple.Create(SwaggerDataTypes.Number, "float"),
          [typeof(double)] = Tuple.Create(SwaggerDataTypes.Number, "double"),
          [typeof(decimal)] = Tuple.Create(SwaggerDataTypes.Number, "double"),
          [typeof(byte[])] = Tuple.Create(SwaggerDataTypes.String, "byte"),
          [typeof(string)] = Tuple.Create(SwaggerDataTypes.String, (string)null),
          [typeof(char)] = Tuple.Create(SwaggerDataTypes.String, (string)null),
          [typeof(DateTime)] = Tuple.Create(SwaggerDataTypes.String, "date-time"),
          [typeof(DateTimeOffset)] = Tuple.Create(SwaggerDataTypes.String, "date-time"),
          [typeof(TimeSpan)] = Tuple.Create(SwaggerDataTypes.String, "date-span"),
          [typeof(Guid)] = Tuple.Create(SwaggerDataTypes.String, "uuid"),
          [typeof(Uri)] = Tuple.Create(SwaggerDataTypes.String, "uri"),
          [typeof(Version)] = Tuple.Create(SwaggerDataTypes.String, (string)null),
#if NET6_0_OR_GREATER
            [typeof(DateOnly)] = Tuple.Create(SwaggerDataTypes.String, "date"),
            [typeof(TimeOnly)] = Tuple.Create(SwaggerDataTypes.String, "time"),
#endif
#if NET7_0_OR_GREATER
            [ typeof(Int128) ] = Tuple.Create(SwaggerDataTypes.Integer, "int128"),
            [ typeof(UInt128) ] = Tuple.Create(SwaggerDataTypes.Integer, "int128"),
#endif
      };

        /// <summary>
        ///     Get Swagger DataType and default format for type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns><Swagger DataType and default format/returns>
        public static Tuple<SwaggerDataTypes, string> GetSwaggerDataTypeAndFormat(this Type type)
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