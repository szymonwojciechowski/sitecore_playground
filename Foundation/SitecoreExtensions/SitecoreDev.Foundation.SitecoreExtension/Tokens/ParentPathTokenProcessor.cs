using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Pipelines.ExpandInitialFieldValue;

namespace SitecoreDev.Foundation.SitecoreExtension.Tokens
{
    public class ParentPathTokenProcessor : ExpandInitialFieldValueProcessor
    {
        public override void Process(ExpandInitialFieldValueArgs args)
        {
            var token = args.SourceField.Value;
            if (!string.IsNullOrEmpty(token) && token.Contains("$parentPath"))
            {
                if (args.TargetItem != null)
                {
                    args.Result = args.Result.Replace("$parentPath", args.TargetItem.Paths.ParentPath);
                }
            }
        }
    }
}
