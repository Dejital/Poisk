using System.Collections.Generic;

namespace Poisk.Core.Model.Impl
{
    /// <summary>
    /// Plain implementation of <see cref="Being"/> as an enemy of the player character.
    /// </summary>
    internal class Baddie : IBeing
    {
        public Baddie(string name, int health, bool isAlive)
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
