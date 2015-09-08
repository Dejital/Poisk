using System.Collections.Generic;

namespace Poisk.Core.Model
{
    /// <summary>
    /// Represents any being in the world.
    /// </summary>
    public interface IBeing
    {
        /// <summary>
        /// The display name of the being.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The remaining health points available to the being.
        /// </summary>
        int Health { get; }

        /// <summary>
        /// The collection of the being's inventory.
        /// </summary>
        IEnumerable<string> Inventory { get; }

        /// <summary>
        /// Determines whether the being is alive or dead.
        /// </summary>
        bool IsAlive { get; }
    }
}