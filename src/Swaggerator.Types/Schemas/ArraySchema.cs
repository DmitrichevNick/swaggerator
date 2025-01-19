using Swaggerator.Swagger.Extensions;

namespace Swaggerator.Types.Schemas
{
    /// <summary>
    ///     Array types of Schema
    /// </summary>
    public class ArraySchema : Schema
    {
        /// <summary>
        ///     Parameterless constructor
        /// </summary>
        public ArraySchema()
        {
            Type = Enums.DataType.Array.GetString();
            UniqueItems = false;
        }

        /// <summary>
        ///     Items Schema of array
        /// </summary>
        public Schema Items { get; set; }

        /// <summary>
        ///     Are Items of Array unique?
        /// </summary>
        public bool UniqueItems { get; set; }
    }
}