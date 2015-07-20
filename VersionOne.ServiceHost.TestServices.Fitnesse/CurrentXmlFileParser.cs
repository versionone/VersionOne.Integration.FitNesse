using System;
using System.Xml;

namespace VersionOne.ServiceHost.TestServices.Fitnesse {
    public class CurrentXmlFileParser : XmlFileParser {
        private const string ElapsedXpath = "runTimeInMillis/text()";
        private const string TestRunNameXpath = "name/text()";

        protected override string ResultXpath {
            get { return "/suiteResults/pageHistoryReference"; }
        }

        protected override string TopSuiteNameXpath {
            get { return "/suiteResults/rootPath/text()"; }
        }

        public CurrentXmlFileParser(XmlDocument document, DateTime testTime) : base(document, testTime) { }

        protected  override TestRun CreateTestRun(string topSuiteName, XmlNode testRunNode) {
            if(testRunNode == null || string.IsNullOrEmpty(topSuiteName)) {
                return null;
            }

            var node = testRunNode.SelectSingleNode(TestRunNameXpath);

            if(node != null) {
                var fullName = node.Value;
                var position = fullName.IndexOf(topSuiteName);
                var name = fullName.Substring(position);
                var testRun = new TestRun(TestTime, name) { State = GetTestRunState(testRunNode) };
                var elapsedNode = testRunNode.SelectSingleNode(ElapsedXpath);

                if(elapsedNode != null) {
                    testRun.Elapsed = Convert.ToDouble(elapsedNode.Value);
                }

                return testRun;
            }

            return null;
        }
    }
}