using System.Text.Json.Nodes;

using Swaggerator.Json.Interfaces;
using Swaggerator.Types.Primitives;

namespace Swaggerator.Json.JsonNodes
{
    /// <summary>
    ///     JsonNode of <see cref="Schema"/>
    /// </summary>
    public class SchemaNode : INode
    {
        private readonly Schema _schema;
        private SchemaNode(Schema schema)
        {
            _schema = schema;
        }

        /// <inheritdoc />
        public JsonNode Create()
        {
            var properties = _schema.Properties;

            var rootNode = new JsonObject();
            var requiredPropertiesNode = new JsonArray();
            var propertiesNode = new JsonArray();

            foreach (var property in properties)
            {
                requiredPropertiesNode.Add(property.Name);
                propertiesNode.Add(PropertyNode.Create(property));
            }

            rootNode.Add("required", requiredPropertiesNode);
            rootNode.Add("properties", propertiesNode);

            return rootNode;
        }

        /// <summary>
        ///     Create JSON node of Schema instance
        /// </summary>
        /// <param name="schema">Schema instance</param>
        /// <returns>The result JSON node of <see cref="Schema"/></returns>
        public static JsonNode Create(Schema schema)
        {
            var schemaNode = new SchemaNode(schema);

            return schemaNode.Create();
        }
    }
}