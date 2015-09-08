using Poisk.Core.Model;

namespace Poisk.Core.Biz
{
    /// <summary>
    /// Builds player characters.
    /// </summary>
    public interface IPlayerFactory
    {
        /// <summary>
        /// Builds a player character.
        /// </summary>
        /// <param name="name">The player character's name.</param>
        /// <returns>A Player character.</returns>
        IBeing BuildPlayer(string name);
    }
}