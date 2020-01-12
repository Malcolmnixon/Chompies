using System;
using Newtonsoft.Json;

namespace Chompies.Shared
{
    /// <summary>
    /// Vector structure
    /// </summary>
    public struct Vec
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public Vec(float x, float y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Gets or sets the X coordinate
        /// </summary>
        public float X { get; set; }

        /// <summary>
        /// Gets or sets the Y coordinate
        /// </summary>
        public float Y { get; set; }

        /// <summary>
        /// Gets the length
        /// </summary>
        [JsonIgnore]
        public float Length => (float) Math.Sqrt(X * X + Y * Y);

        /// <summary>
        /// Perform linear interpolation
        /// </summary>
        /// <param name="a">First vector</param>
        /// <param name="b">Second vector</param>
        /// <param name="t">Interpolation (clamped to 0..1)</param>
        /// <returns></returns>
        public static Vec Lerp(Vec a, Vec b, float t) => LerpUnclamped(a, b, t < 0 ? 0 : t > 1 ? 1 : t);

        /// <summary>
        /// Perform linear interpolation
        /// </summary>
        /// <param name="a">First vector</param>
        /// <param name="b">Second vector</param>
        /// <param name="t">Interpolation</param>
        /// <returns></returns>
        public static Vec LerpUnclamped(Vec a, Vec b, float t) => a + (b - a) * t;

        /// <summary>
        /// Add two vectors
        /// </summary>
        /// <param name="a">First vector</param>
        /// <param name="b">Second vector</param>
        /// <returns>Addition of vectors</returns>
        public static Vec operator+(Vec a, Vec b) => new Vec(a.X + b.X, a.Y + b.Y);

        /// <summary>
        /// Subtract one vector from another
        /// </summary>
        /// <param name="a">First vector</param>
        /// <param name="b">Second vector</param>
        /// <returns>Vector a - b</returns>
        public static Vec operator-(Vec a, Vec b) => new Vec(a.X - b.X, a.Y - b.Y);

        /// <summary>
        /// Scale a vector
        /// </summary>
        /// <param name="a">Vector</param>
        /// <param name="s">Scale</param>
        /// <returns>Vector a * s</returns>
        public static Vec operator*(Vec a, float s) => new Vec(a.X * s, a.Y * s);
    }
}
