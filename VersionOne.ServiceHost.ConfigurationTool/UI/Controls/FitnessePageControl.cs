using VersionOne.ServiceHost.ConfigurationTool.Entities;
using VersionOne.ServiceHost.ConfigurationTool.UI.Interfaces;

namespace VersionOne.ServiceHost.ConfigurationTool.UI.Controls {
    public partial class FitnessePageControl : BasePageControl<FitnesseServiceEntity>, IFitnessePageView {
        public FitnessePageControl() {
            InitializeComponent();

            AddControlValidation<FitnesseServiceEntity>(txtFilter, FitnesseServiceEntity.FilterProperty, "Text");

            var validationProvider = GetValidationProvider(typeof(FitnesseServiceEntity));
            pscWatchFolder.AddControlValidation(FitnesseServiceEntity.WatchProperty, validationProvider);
        }

        public override void DataBind() {
            AddControlBinding(chkDisabled, Model, BaseEntity.DisabledProperty);
            AddControlBinding(txtFilter, Model, FitnesseServiceEntity.FilterProperty);
            AddControlBinding(numIntervalMinutes, Model.Timer, TimerEntity.TimerProperty);

            pscWatchFolder.AddControlBinding(Model, FitnesseServiceEntity.WatchProperty);

            BindHelpStrings();
        }

        private void BindHelpStrings() {
            AddHelpSupport(chkDisabled, Model, BaseEntity.DisabledProperty);
            AddHelpSupport(txtFilter, Model, FitnesseServiceEntity.FilterProperty);
            AddHelpSupport(lblPollIntervalSuffix, Model.Timer, TimerEntity.TimerProperty);
            AddHelpSupport(pscWatchFolder, Model, FitnesseServiceEntity.WatchProperty, 0);
        }
    }
}