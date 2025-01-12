using Swaggerator.Json.Interfaces;
using Swaggerator.Types.Primitives;
using System.Text.Json.Nodes;

namespace Swaggerator.Json.JsonNodes
{
    /// <summary>
    ///     JsonNode of <see cref="Property"/>
    /// </summary>
    public class PropertyNode : INode
    {
        private readonly Property _property;
        private PropertyNode(Property property)
        {
            _property = property;
        }

        /// <inheritdoc />
        public JsonNode Create()
        {
            var rootNode = new JsonObject();

            var propertiesNodes = new JsonObject
            {
                { "type", _property.Type },
                { "example", _property.Example },
                { "format", _property.Format }
            };

            rootNode.Add(_property.Name, propertiesNodes);

            return rootNode;
        }

        /// <summary>
        ///     Create JSON node of Property instance
        /// </summary>
        /// <param name="schema">Property instance</param>
        /// <returns>The result JSON node of <see cref="Property"/></returns>
        public static JsonNode Create(Property property)
        {
            var propertyNode = new PropertyNode(property);

            return propertyNode.Create();
        }
    }
}