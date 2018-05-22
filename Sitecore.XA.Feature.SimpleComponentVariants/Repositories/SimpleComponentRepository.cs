using Sitecore.Mvc.Extensions;
using Sitecore.XA.Feature.SimpleComponent.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;

namespace Sitecore.XA.Feature.SimpleComponent.Repositories
{
    public class SimpleComponentRepository : VariantsRepository, ISimpleComponentRepository
    {
        
        public override IRenderingModelBase GetModel()
        {
            SimpleComponentModel model = new SimpleComponentModel();
            FillBaseProperties(model);
            model.CustomProperty = this.Rendering.Parameters["Custom Property"].ValueOrEmpty();
            return model;
        }
    }
}
