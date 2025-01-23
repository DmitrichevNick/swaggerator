using System;

namespace Swaggerator.Types.Interfaces
{
    /// <summary>
    ///     Interface of Schema Id resolver
    /// </summary>
    public interface ISchemaIdResolver
    {
        /// <summary>
        ///     Get Schema Id by Type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>SchemaId</returns>
        string GetSchemaIdByType(Type type);
    }
}