using System;
using System.Collections.Generic;
using System.Text;

namespace Chompies.Shared
{
    /// <summary>
    /// World element
    /// </summary>
    public class Element
    {
        /// <summary>
        /// Element ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        public Vec Position { get; set; }

        /// <summary>
        /// Orientation
        /// </summary>
        public float Orientation { get; set; }
    }
}
