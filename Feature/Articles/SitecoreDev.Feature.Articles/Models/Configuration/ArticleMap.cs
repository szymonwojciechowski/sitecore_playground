using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Maps;

namespace SitecoreDev.Feature.Articles.Models.Configuration
{
    public class ArticleMap : SitecoreGlassMap<IArticle>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.Id(f => f.Id);
                config.Field(f => f.Title).FieldName("Title");
                config.Field(f => f.Body).FieldName("Body");
            });
        }
    }
}
