using Swaggerator.Types.Interfaces;

namespace Swaggerator.Types.Schemas
{
    /// <summary>
    ///     Abstract of Swagger schema
    /// </summary>
    public abstract class Schema : ISchema
    {
        /// <summary>
        ///     Swagger Type
        /// </summary>
        public string Type { get; protected set; }
    }
}