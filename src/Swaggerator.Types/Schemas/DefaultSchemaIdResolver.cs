using System;

using Swaggerator.Types.Interfaces;

namespace Swaggerator.Types.Schemas
{
    /// <summary>
    ///     Default Schema Id resolver, that uses Type name
    /// </summary>
    public class DefaultSchemaIdResolver : ISchemaIdResolver
    {
        /// <inheritdoc />
        public string GetSchemaIdByType(Type type)
            => type.Name;
    }
}