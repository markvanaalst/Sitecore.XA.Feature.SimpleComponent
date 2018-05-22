using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.XA.Feature.SimpleComponent.Repositories;
using Sitecore.XA.Foundation.Mvc.Controllers;
using Sitecore.XA.Foundation.RenderingVariants.Controllers;

namespace Sitecore.XA.Feature.SimpleComponent.Controllers
{
    public class SimpleComponentController : VariantsController
    {
        protected readonly ISimpleComponentRepository _repository;
        public SimpleComponentController(ISimpleComponentRepository repository)
        {
            _repository = repository;
        }
        protected override object GetModel()
        {
            return _repository.GetModel();
        }
    }
}