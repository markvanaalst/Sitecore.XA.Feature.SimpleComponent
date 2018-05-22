using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Mvc.Extensions;
using Sitecore.Resources.Media;
using Sitecore.XA.Feature.SimpleComponent.Models;
using Sitecore.XA.Foundation.Mvc;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;

namespace Sitecore.XA.Feature.SimpleComponent.Repositories
{
    public class SimpleComponentRepository : ModelRepository, ISimpleComponentRepository
    {
        
        public override IRenderingModelBase GetModel()
        {
            SimpleComponentModel model = new SimpleComponentModel();
            FillBaseProperties(model);
            model.CustomProperty = this.Rendering.Parameters["Custom Property"].ValueOrEmpty();
            model.Title = this.Rendering.DataSourceItem.Fields["Title"].GetValue(false);
            model.Description = this.Rendering.DataSourceItem.Fields["Description"].GetValue(false);
            return model;
        }
    }
}
