using StructureMap;

namespace KisaMetaka.ImaLiKoJaci.Web
{
    public class DependecyConfig
    {
        public static void RegisterDependencies()
        {
            ObjectFactory.Initialize(x =>
            {
                x.IncludeRegistry<Infrastructure.DependencyRegistry>();

                x.Scan(scanner =>
                {
                    scanner.Assembly("KisaMetaka.ImaLiKoJaci.Infrastructure");
                    scanner.SingleImplementationsOfInterface();
                });
            });
        }
    }
}