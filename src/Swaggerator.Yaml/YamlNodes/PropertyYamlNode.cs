using Swaggerator.Types.Primitives;
using YamlDotNet.RepresentationModel;

namespace Swaggerator.Yaml.YamlNodes
{
    /// <summary>
    ///     YamlNode of <see cref="Property"/>
    /// </summary>
    public class PropertyYamlNode
    {
        private readonly Property _property;
        private PropertyYamlNode(Property property)
        {
            _property = property;
        }

        public YamlNode Create()
        {
            var rootNode = new YamlMappingNode();
            var propertiesNodes = new YamlMappingNode
            {
                { "type", _property.Type },
                { "example", _property.Example },
                { "format", _property.Format }
            };

            rootNode.Add(_property.Name, propertiesNodes);

            return rootNode;
        }

        public static YamlNode Create(Property property)
        {
            var propertyYamlNode = new PropertyYamlNode(property);

            return propertyYamlNode.Create();
        }
    }
}