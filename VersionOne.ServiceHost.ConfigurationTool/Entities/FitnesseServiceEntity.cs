using System.Xml.Serialization;
using VersionOne.ServiceHost.ConfigurationTool.Attributes;
using VersionOne.ServiceHost.ConfigurationTool.Validation;

namespace VersionOne.ServiceHost.ConfigurationTool.Entities {
    [DependsOnService(typeof(TestWriterEntity))]
    [XmlRoot("FitReaderService")]
    public class FitnesseServiceEntity : BaseServiceEntity {
        public const string WatchProperty = "Watch";
        public const string FilterProperty = "Filter";

        [NonEmptyStringValidator]
        [HelpString(HelpResourceKey = "CommonWatch")]
        public string Watch { get; set; }

        [NonEmptyStringValidator]
        [HelpString(HelpResourceKey = "CommonFilter")]
        public string Filter { get; set; }

        public FitnesseServiceEntity() {
            CreateTimer(TimerEntity.DefaultTimerIntervalMinutes);
        }

        public override bool Equals(object obj) {
            if(obj == null || obj.GetType() != typeof(FitnesseServiceEntity)) {
                return false;
            }

            var other = (FitnesseServiceEntity) obj;

            return string.Equals(Watch, other.Watch) && string.Equals(Filter, other.Filter);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}