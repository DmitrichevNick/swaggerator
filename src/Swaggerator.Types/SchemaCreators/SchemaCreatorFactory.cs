using System;

namespace Swaggerator.Types.SchemaCreators
{
    public static class SchemaCreatorFactory
    {
        /// <summary>
        ///     Create ISchemaCreator for Type
        /// </summary>
        /// <param name="type">Type</param>
        /// <returns>ISchemaCreator</returns>
        public static ISchemaCreator Create(Type type)
        {
            return null;
        }
    }
}