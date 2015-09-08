using Poisk.Core.Biz;
using Poisk.Core.Biz.Impl;
using StructureMap.Configuration.DSL;

namespace Poisk.Core.Bootstrap
{
    public class CoreRegistry : Registry
    {
        public CoreRegistry()
        {
            For<ISampleService>().Singleton().Use<SampleService>();
            For<IPlayerFactory>().Singleton().Use<PlayerFactory>();
        }
    }
}
