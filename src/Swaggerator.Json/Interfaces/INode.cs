using System.Text.Json.Nodes;

namespace Swaggerator.Json.Interfaces
{
    /// <summary>
    ///     Node of JSON
    /// </summary>
    public interface INode
    {
        /// <summary>
        ///     Create JSON node
        /// </summary>
        /// <returns>The result JSON node</returns>
        JsonNode Create();
    }
}