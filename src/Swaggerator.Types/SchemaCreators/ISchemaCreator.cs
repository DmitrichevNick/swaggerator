using System;

using Swaggerator.Types.Schemas;

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
    }
}