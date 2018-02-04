using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SitecoreDev.Feature.Articles.Models;

namespace SitecoreDev.Feature.Articles.Repositories
{
    public interface ICommentRepository
    {
        IEnumerable<IComment> GetComments(string blogId);
    }
}
