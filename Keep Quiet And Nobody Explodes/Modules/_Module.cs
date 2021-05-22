using System.Collections.Generic;

namespace KeepQuietAndNobodyExplodes.Modules
{
    /// <summary>
    /// Base class for modules.
    /// </summary>
    public abstract class Module
    {
        /// <summary>
        /// The name of the module, shown to the user.
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// The callword(s) to activate the module.
        /// </summary>
        public abstract List<string> Callwords { get; set; }

        /// <summary>
        /// The operation to perform. Returns void as it is expected to output its result directly to the console.
        /// </summary>
        /// <param name="args">Any optional arguments to pass.</param>
        public abstract void Do(string[] args = null);
    }
}
