using System;
using System.Collections.Generic;
using System.Linq;
using Poisk.Core.Biz;
using Poisk.Core.Bootstrap;
using Poisk.Core.Common;
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
        private readonly Container _container;
        private IPlayerFactory _playerFactory;

        /// <summary>
        /// Contains the main game loop.
        /// </summary>
        public GameController()
        {
            _container = CreateContainer();
            var display = new Display();
            display.DisplayMessage("Welcome to Poisk.");

            var playerName = display.PromptUserForNonEmptyStringResponse("What is your name?", true);
            var pc = CreatePlayer(playerName);
            var playerActionDictionary = GetPlayerActionDictionary();

            while (pc.IsAlive)
            {
                var validResponses = playerActionDictionary.Keys.ToList();
                display.DisplayMessage("Available actions are " + string.Join(", ", validResponses) + ".");
                var playerResponse = display.PromptUserForValidResponse(validResponses);
                var playerAction = playerActionDictionary[playerResponse];
                display.DisplayMessage("Player has taken the " + playerAction + " action.");
                if (playerAction == PlayerAction.Exit)
                    break;
            }

            display.DisplayMessage("Game Over");
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

        /// <summary>
        /// Returns a playable character.
        /// </summary>
        private IBeing CreatePlayer(string playerName)
        {
            _playerFactory = _container.GetInstance<IPlayerFactory>();
            return _playerFactory.BuildPlayer(playerName);
        }

        /// <summary>
        /// Returns a dictionary of string to <see cref="PlayerAction"/> enum key value pairs.
        /// </summary>
        private Dictionary<string, PlayerAction> GetPlayerActionDictionary()
        {
            var actions = Enum.GetValues(typeof (PlayerAction))
                .Cast<PlayerAction>();
            return actions.ToDictionary(a => a.ToString());
        }
    }
}
