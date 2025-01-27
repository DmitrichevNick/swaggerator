// using System;

// using Swaggerator.Types.Interfaces;
// using Swaggerator.Types.Schemas;

// namespace Swaggerator.Types.SchemaCreators
// {
//     /// <summary>
//     ///     Creator of Schema with $ref
//     /// </summary>
//     public class ReferenceSchemaCreator : ISchemaCreator
//     {
//         /// <inheritdoc />
//         public ISchema Create(Type type)
//         {
//             if (type == null)
//                 throw new ArgumentNullException(nameof(type), "Parameter 'type' cannot be null.");

//             return new ReferenceSchema($"#/components/schemas/{type.Name}");
//         }
//     }
// }