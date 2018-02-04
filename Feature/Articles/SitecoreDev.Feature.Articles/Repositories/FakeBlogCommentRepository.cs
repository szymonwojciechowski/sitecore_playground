using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SitecoreDev.Feature.Articles.Models;

namespace SitecoreDev.Feature.Articles.Repositories
{
    public class FakeBlogCommentRepository : ICommentRepository
    {
        public IEnumerable<IComment> GetComments(string blogId)
        {
            var comments = new List<IComment>();
            comments.Add(new BlogComment()
            {
                Name = "Jack",
                Comment = "This post was really helpfull",
                DatePosted = DateTime.Now.AddDays(-7)
            });
            comments.Add(new BlogComment()
            {
                Name = "Jane",
                Comment = "You're a really smart guy! Keep up the good work!",
                DatePosted = DateTime.Now.AddDays(-1)
            });
            return comments;
        }
    }
}
