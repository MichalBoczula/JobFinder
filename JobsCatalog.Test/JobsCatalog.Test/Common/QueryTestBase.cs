using JobsCatalog.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JobsCatalog.Test.Common
{
    public class QueryTestBase : IDisposable
    {
        public JobsCatalogDbContext Context { get; set; }

        public QueryTestBase()
        {
            Context = DbContexFactory.Create().Object;
        }


        public void Dispose()
        {
            DbContexFactory.CleanUp(Context);
        }
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestBase>
    {
    }
}
