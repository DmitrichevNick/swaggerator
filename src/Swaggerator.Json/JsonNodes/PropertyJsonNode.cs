using Swaggerator.Types.Primitives;
using System.Text.Json.Nodes;

namespace Swaggerator.Json.JsonNodes
{
    /// <summary>
    ///     JsonNode of <see cref="Property"/>
    /// </summary>
    public class PropertyJsonNode
    {
        private readonly Property _property;
        private PropertyJsonNode(Property property)
        {
            _property = property;
        }

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

        public static JsonNode Create(Property property)
        {
            var propertyNode = new PropertyJsonNode(property);

            return propertyNode.Create();
        }
    }
}