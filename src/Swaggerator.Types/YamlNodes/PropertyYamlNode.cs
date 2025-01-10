using Swaggerator.Types.Primitives;
using YamlDotNet.RepresentationModel;

namespace Swaggerator.Types.YamlNodes
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
            var serializator = new YamlDotNet.Serialization.Serializer();
            //var sequence = new YamlSequenceNode();
            //sequence.Add(new )
            //var yn = new YamlDotNet.RepresentationModel.YamlSequenceNode();
            //var s = new YamlDotNet.RepresentationModel.YamlDocument(new YamlScalarNode(_property.Name));

            //yn["type"] = _property.Type;

            var yamlNode = serializator.Serialize(_property);

            return yamlNode;
        }

        public static YamlNode Create(Property property)
        {
            var propertyYamlNode = new PropertyYamlNode(property);

            return propertyYamlNode.Create();
        }
    }
}