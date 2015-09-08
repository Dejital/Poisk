using Poisk.Core.Biz;
using StructureMap.Configuration.DSL;

namespace Poisk.Core.Bootstrap
{
    public class CoreRegistry : Registry
    {
        public CoreRegistry()
        {
            For<ISampleService>().Singleton().Use<SampleService>();
        }
    }
}
