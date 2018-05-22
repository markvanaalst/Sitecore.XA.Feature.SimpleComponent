using System.Web.Mvc;
using Sitecore.XA.Foundation.Mvc.Models;
using Sitecore.XA.Foundation.Variants.Abstractions.Models;

namespace Sitecore.XA.Feature.SimpleComponent.Models
{
    public class SimpleComponentModel : RenderingModelBase
    {
        public string CustomProperty { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}