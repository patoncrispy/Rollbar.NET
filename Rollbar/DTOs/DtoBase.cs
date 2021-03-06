﻿namespace Rollbar.DTOs
{

    /// <summary>
    /// Implements an abstract DTO type base.
    /// </summary>
    public abstract class DtoBase
        : ITraceable
    {
        /// <summary>
        /// Traces as string.
        /// </summary>
        /// <param name="indent">The indent.</param>
        /// <returns>
        /// String rendering of this instance.
        /// </returns>
        public virtual string TraceAsString(string indent = "")
        {
            return this.ToString();
        }

        /// <summary>
        /// Validates this instance.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}
