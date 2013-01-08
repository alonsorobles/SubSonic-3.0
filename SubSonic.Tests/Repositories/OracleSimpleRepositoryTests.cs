using SubSonic.DataProviders;

namespace SubSonic.Tests.Repositories
{
    public class OracleSimpleRepositoryTests : SimpleRepositoryTests
    {
        public OracleSimpleRepositoryTests() :
            base((IDataProvider) ProviderFactory.GetProvider("NorthwindOracle"))
        {
        }
    }
}