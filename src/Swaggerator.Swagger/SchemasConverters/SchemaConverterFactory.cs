using System;

using Swaggerator.Types.Interfaces;
using Swaggerator.Types.Schemas;

namespace Swaggerator.Swagger.SchemasConverters
{
    public static class SchemaConverterFactory
    {
        public static ISchemaConverter Create(ISchema schema)
        {
            var typeName = schema.GetType().Name;

            switch (typeName)
            {
                case nameof(BooleanSchema):
                    return new BooleanSchemaConverter();
                case nameof(NumberSchema):
                    return new NumberSchemaConverter();
                case nameof(IntegerSchema):
                    return new IntegerSchemaConverter();
                case nameof(StringSchema):
                    return new StringSchemaConverter();
                case nameof(ArraySchema):
                    return new StringSchemaConverter();
                case nameof(ObjectSchema):
                    return new StringSchemaConverter();
                default:
                    throw new InvalidOperationException($"Cannot create {nameof(ISchemaConverter)} for type '{typeName}'");
            }
        }
    }
}