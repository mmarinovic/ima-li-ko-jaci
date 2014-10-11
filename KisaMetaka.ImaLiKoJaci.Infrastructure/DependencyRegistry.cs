using KisaMetaka.ImaLiKoJaci.Infrastructure.Data;
using StructureMap.Configuration.DSL;
using StructureMap.Web;

namespace KisaMetaka.ImaLiKoJaci.Infrastructure
{
    public class DependencyRegistry : Registry
    {
        public DependencyRegistry()
        {
            this.For<DataModel>().HybridHttpOrThreadLocalScoped().Use(() => new DataModel());
        }
    }
}
