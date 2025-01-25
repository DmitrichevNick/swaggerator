using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Swaggerator.Types.Extensions;
using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Properties;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Types.SchemaCreators
{
    public class ObjectSchemaCreator : ISchemaCreator
    {
        /// <inheritdoc />
        public ISchema Create(Type type)
        {
            var objectSchema = new ObjectSchema();

            objectSchema.Required = GetRequired(type);
            objectSchema.Properties = GetProperties(type);

            return objectSchema;
        }

        private IEnumerable<PropertyInfo> GetPublicProperties(Type type)
        {
            return type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }

        private ISet<string> GetRequired(Type type)
        {
            var requiredList = GetPublicProperties(type)
                .Where(propertyInfo => propertyInfo.IsRequired())
                .Select(propertyInfo => propertyInfo.Name)
                .Distinct();

            return new HashSet<string>(requiredList);
        }

        private Dictionary<string, ISchema> GetProperties(Type type)
        {
            var properties = new Dictionary<string, ISchema>();
            var notIgnoredProperties = GetPublicProperties(type)
                .Where(propertyInfo => !propertyInfo.IsIgnored());

            foreach (var propertyInfo in notIgnoredProperties)
                properties.Add(
                    propertyInfo.Name,
                    PropertyCreatorFactory.CreateSchema(propertyInfo));

            return properties;
        }
    }
}