using System.Threading.Tasks;
using Messenger.Core.DbInitializing;
using Messenger.Core.Interfaces;

namespace Messenger.Core.Implementations
{
    public class DbInitializer : IDbInitialier
    {
        private readonly IDefaultDataProvider _defaultDataProvider;

        public DbInitializer(IDefaultDataProvider defaultDataProvider)
        {
            _defaultDataProvider = defaultDataProvider;
        }

        public async void FillDatabaseWithDefaultData()
        {
            await _defaultDataProvider.CheckAndCreateDefaultChat();
        }
    }
}