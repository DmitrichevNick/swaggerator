using System.Collections.Generic;

namespace Swaggerator.Types.Interfaces
{
    /// <summary>
    ///     Interface of Schemas repository
    /// </summary>
    public interface ISchemasRepository
    {
        /// <summary>
        ///     Try add schemaId to repository
        /// </summary>
        /// <param name="schemaId">SchemaId</param>
        /// <param name="schema">Schema</param>
        /// <returns>True if added, false if exists</returns>
        bool TryAdd(string schemaId, ISchema schema);

        /// <summary>
        ///     Get all Schemas from repository
        /// </summary>
        /// <returns>Schemas collection</returns>
        IEnumerable<ISchema> GetSchemas();

        /// <summary>
        ///     Get Schema by Schema Id
        /// </summary>
        /// <param name="schemaId">Schema Id</param>
        /// <returns>Schema</returns>
        ISchema GetSchema(string schemaId);

        /// <summary>
        ///     Try get Schema by Schema Id
        /// </summary>
        /// <param name="schemaId">Schema Id</param>
        /// <param name="schema">Schema</param>
        /// <returns>True if exists, false if not</returns>
        bool TryGetSchema(string schemaId, out ISchema schema);
    }
}