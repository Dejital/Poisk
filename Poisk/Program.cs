using Poisk.Core.Biz;
using Poisk.Core.Bootstrap;
using StructureMap;

namespace Poisk
{
    class Program
    {
        private static Container _container;

        static void Main(string[] args)
        {
            _container = new Container(x =>
            {
                x.AddRegistry<CoreRegistry>();
            });

            var sampleService = _container.GetInstance<ISampleService>();
        }
    }
}
