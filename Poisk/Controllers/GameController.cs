using System;
using Poisk.Core.Biz;
using Poisk.Core.Bootstrap;
using Poisk.Core.Model;
using Poisk.Views;
using Container = StructureMap.Container;

namespace Poisk.Controllers
{
    /// <summary>
    /// The primary controller in charge of the game.
    /// </summary>
    internal class GameController
    {
        private Container _container;
        private Display _display;
        private IPlayerFactory _playerFactory;

        public GameController()
        {
            _container = CreateContainer();
            _display = new Display();

            var pc = CreatePlayer(_display.PlayerName);
        }

        private IBeing CreatePlayer(string playerName)
        {
            _playerFactory = _container.GetInstance<IPlayerFactory>();
            return _playerFactory.BuildPlayer(playerName);
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
