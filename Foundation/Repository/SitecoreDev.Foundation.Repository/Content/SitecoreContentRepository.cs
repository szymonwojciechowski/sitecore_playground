using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc;
using Sitecore.Diagnostics;
using SitecoreDev.Foundation.Model;

namespace SitecoreDev.Foundation.Repository.Content
{
    public class SitecoreContentRepository : IContentRepository
    {
        private readonly ISitecoreContext _sitecoreContext;

        public SitecoreContentRepository()
        {
            _sitecoreContext = new SitecoreContext();
        }
        public T GetContentItem<T>(string contentGuid) where T : class, ICmsEntity
        {
            Assert.ArgumentNotNullOrEmpty(contentGuid, "contentGuid");

            return _sitecoreContext.GetItem<T>(Guid.Parse(contentGuid));
        }
    }
}
