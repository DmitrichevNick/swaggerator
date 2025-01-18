using System.Collections.Generic;

namespace Swaggerator.Types.Primitives
{
    /// <summary>
    ///     Component type of OpenAPI
    /// </summary>
    public class Component
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public Component()
        {
            Schemas = new List<Schema>();
        }

        /// <summary>
        ///     Schemas collection
        /// </summary>
        public IList<Schema> Schemas { get; set; }
    }
}