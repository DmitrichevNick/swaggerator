using System;

namespace Swaggerator.Annotations
{
    /// <summary>
    ///     Adds or enriches Response metadata for a given action method
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class SwaggerResponseAttribute : Attribute
    {
        /// <summary>
        ///     A constructor that accepts statusCode, description and type of the response
        /// </summary>
        /// <param name="statusCode">A Status Code corresponds to the response</param>
        /// <param name="description">A description of the response</param>
        /// <param name="type">A type of the response</param>
        public SwaggerResponseAttribute(int statusCode, string description = null, Type type = null)
        {
            StatusCode = statusCode;
            Description = description;
            Type = type ?? typeof(void);
        }

        /// <summary>
        ///     A constructor that accepts statusCode, description, type and content types of the response
        /// </summary>
        /// <param name="statusCode">A Status Code corresponds to the response</param>
        /// <param name="description">A description of the response</param>
        /// <param name="type">A type of the response</param>
        /// <param name="contentTypes">Content types of the response</param>
        public SwaggerResponseAttribute(int statusCode, string description = null, Type type = null, params string[] contentTypes)
        {
            StatusCode = statusCode;
            Description = description;
            Type = type ?? typeof(void);
            ContentTypes = contentTypes;
        }

        /// <summary>
        ///     A short description of the response. GFM syntax can be used for rich text representation.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     A collection of MIME types that the response can be produced with.
        /// </summary>
        public string[] ContentTypes { get; set; }

        /// <summary>
        ///     A type of the response
        /// </summary>
        public Type Type { get; private set; }

        /// <summary>
        ///     A Status Code corresponds to the response
        /// </summary>
        public int StatusCode { get; private set; }
    }
}