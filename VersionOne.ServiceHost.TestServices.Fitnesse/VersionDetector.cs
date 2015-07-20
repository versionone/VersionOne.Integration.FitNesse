using System.Xml;

namespace VersionOne.ServiceHost.TestServices.Fitnesse {
    public class VersionDetector {
        private readonly XmlDocument document;

        public VersionDetector(XmlDocument document) {
            this.document = document;
        }

        public FitnesseVersion GetVersion() {
            const string newVersionXpath = "suiteResults/FitNesseVersion";
            var version = document.SelectSingleNode(newVersionXpath);
            return version != null ? FitnesseVersion.Current : FitnesseVersion.Pre2011;
        }
    }
}