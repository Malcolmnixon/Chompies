using System;

namespace Chompies.Shared
{
    /// <summary>
    /// Actor base class
    /// </summary>
    public class Actor : Element
    {
        /// <summary>
        /// Actor velocity
        /// </summary>
        public Vec Velocity { get; set; }

        /// <summary>
        /// Current player
        /// </summary>
        public string Player { get; set; } = string.Empty;
    }
}
