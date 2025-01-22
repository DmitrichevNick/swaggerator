namespace Swaggerator.Types.Schemas
{
    /// <summary>
    ///     Reference Schema
    /// </summary>
    public class ReferenceSchema : ISchema
    {
        /// <summary>
        ///     Constructor with reference
        /// </summary>
        /// <param name="reference">Reference of Schema</param>
        public ReferenceSchema(string reference)
        {
            Ref = reference;
        }

        /// <summary>
        ///     Reference propert of Schema
        /// </summary>
        public string Ref { get; private set; }
    }
}