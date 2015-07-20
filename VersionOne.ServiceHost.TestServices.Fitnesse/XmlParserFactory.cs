using System;
using System.Xml;

namespace VersionOne.ServiceHost.TestServices.Fitnesse {
    public static class XmlParserFactory {
        public static XmlFileParser CreateParser(XmlDocument document, DateTime testTime) {
            var detector = new VersionDetector(document);
            var version = detector.GetVersion();

            switch(version) {
                case FitnesseVersion.Current:
                    return new CurrentXmlFileParser(document, testTime);
                case FitnesseVersion.Pre2011:
                    return new Pre2011XmlFileParser(document, testTime);
                default:
                    return null;
            }
        }
    }
}