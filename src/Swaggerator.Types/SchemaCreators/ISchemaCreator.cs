using System;
using System.Reflection;

using Swaggerator.Types.Interfaces;

namespace Swaggerator.Types.SchemaCreators
{
    /// <summary>
    ///     Interface of Schema creator
    /// </summary>
    public interface ISchemaCreator
    {
        /// <summary>
        ///     Create Schema by Type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>Schema</returns>
        ISchema Create(Type type);

        /// <summary>
        ///     Create Schema by PropertyInfo
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>Schema</returns>
        ISchema Create(PropertyInfo propertyInfo);
    }
}