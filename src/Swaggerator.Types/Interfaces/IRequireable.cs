namespace Swaggerator.Types.Interfaces
{
    /// <summary>
    ///     Indicates that type can be requireable
    /// </summary>
    public interface IRequireable
    {
        /// <summary>
        ///     Is type required?
        /// </summary>
        bool Required { get; set; }
    }
}