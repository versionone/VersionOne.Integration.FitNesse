using System;
using System.Xml;

namespace VersionOne.ServiceHost.TestServices.Fitnesse {
    public class Pre2011XmlFileParser : XmlFileParser {
        private const string TestRunNameXpath = "relativePageName/text()";

        protected override string ResultXpath {
            get { return "/testResults/result"; }
        }

        protected override string TopSuiteNameXpath {
            get { return "/testResults/rootPath/text()"; }
        }

        public Pre2011XmlFileParser(XmlDocument document, DateTime testTime) : base(document, testTime) { }

        protected override TestRun CreateTestRun(string topSuiteName, XmlNode testRunNode) {
            if(testRunNode == null) {
                return null;
            }

            var node = testRunNode.SelectSingleNode(TestRunNameXpath);

            if(node != null) {
                var name = topSuiteName + "." + node.Value;
                var testRun = new TestRun(TestTime, name) { State = GetTestRunState(testRunNode) };
                return testRun;
            }

            return null;
        }
    }
}