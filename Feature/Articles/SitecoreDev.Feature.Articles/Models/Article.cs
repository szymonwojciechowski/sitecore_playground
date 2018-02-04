using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreDev.Feature.Articles.Models
{
    public class Article : IArticle
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
