using System.IO;
using System.Reflection;
using Microsoft.Synchronization.Data.SqlServerCe;


namespace PosColector
{
    public class POSDataCacheClientSyncProvider : SqlCeClientSyncProvider
    {
        public POSDataCacheClientSyncProvider()
        {
            ((SqlCeClientSyncProvider)this).ConnectionString = "Data Source=" + Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase), "pos_colector.sdf");
        }

        public POSDataCacheClientSyncProvider(string connectionString)
        {
            ((SqlCeClientSyncProvider)this).ConnectionString = connectionString;
        }
    }
}
