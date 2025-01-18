namespace Swaggerator.Types.Interfaces
{
    /// <summary>
    ///     Indicates that type has Type property
    /// </summary>
    public interface ITyped
    {
        /// <summary>
        ///     Type of type
        /// </summary>
        string Type { get; set; }
    }
}