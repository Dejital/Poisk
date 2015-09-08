using Poisk.Core.Bootstrap;
using StructureMap;

namespace Poisk.Controllers
{
    /// <summary>
    /// The primary controller in charge of the game.
    /// </summary>
    internal class GameController
    {
        private Container _container;

        public GameController()
        {
            _container = CreateContainer();
        }

        /// <summary>
        /// Creates a container with the necessary registries.
        /// </summary>
        private Container CreateContainer()
        {
            return new Container(x =>
            {
                x.AddRegistry<CoreRegistry>();
            });
        }
    }
}
