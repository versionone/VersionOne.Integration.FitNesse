using VersionOne.ServiceHost.ConfigurationTool.BZ;
using VersionOne.ServiceHost.ConfigurationTool.Entities;
using VersionOne.ServiceHost.ConfigurationTool.UI.Interfaces;

namespace VersionOne.ServiceHost.ConfigurationTool.UI.Controllers {
    public class FitnesseController : BasePageController<FitnesseServiceEntity, IFitnessePageView> {
        public FitnesseController(FitnesseServiceEntity model, IFacade facade) : base(model, facade) { }
    }
}