using System.Collections.Generic;

namespace Swaggerator.Types.Interfaces
{
    /// <summary>
    ///     Interface of swagger context
    /// </summary>
    public interface ISwaggerContext
    {
        /// <summary>
        ///     Resolver of schema ID
        /// </summary>
        ISchemaIdResolver SchemaIdResolver { get; }

        /// <summary>
        ///     Repository of schemas
        /// </summary>
        ISchemasRepository SchemasRepository { get; }

        /// <summary>
        ///     Unique set of attributes indicates propety is required
        /// </summary>
        ISet<string> RequiredAttributesTypesNames { get; }
    }
}