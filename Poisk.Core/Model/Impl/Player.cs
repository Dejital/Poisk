using System.Collections.Generic;

namespace Poisk.Core.Model.Impl
{
    /// <summary>
    /// The player character.
    /// </summary>
    internal class Player : IBeing
    {
        public Player(string name, int health, bool isAlive)
        {
            Name = name;
            Health = health;
            IsAlive = isAlive;
            Inventory = new List<string>();
        }

        public string Name { get; private set; }

        public int Health { get; private set; }

        public IEnumerable<string> Inventory { get; private set; }

        public bool IsAlive { get; private set; }
    }
}