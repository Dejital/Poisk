using System;
using Poisk.Core.Model;
using Poisk.Core.Model.Impl;

namespace Poisk.Core.Biz.Impl
{
    internal class PlayerFactory : IPlayerFactory
    {
        public IBeing BuildPlayer(string name)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            return new Player(name, 5);
        }
    }
}
