using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace SitecoreDev.Feature.Media.Repositories
{
    public class SitecoreMediaRepository : IMediaRepository
    {
        private readonly Database _database;

        public SitecoreMediaRepository()
        {
            _database = Context.Database;
        }
        public Item GetItem(string contentGuid)
        {
            return _database.GetItem(new ID(contentGuid));
        }
    }
}
